using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.Data;
using Inventory_Management_System.Models;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Inventory_Management_System.Services
{
    public class StockInService
    {
        public DataSet GetApprovedMRRsWithMRRID()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"SELECT MRRID, Department, RequestedBy, 
                              ItemID, ItemName, NumberOfUnits, 
                              Status, ApprovedBy, Notes, CreatedDate
                               FROM materialrequestreturn
                               WHERE Status = 'Confirmed'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving approved MRRs: {ex.Message}",
                               "Database Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            return ds;
        }
        
        public (bool IsSuccess, string Message) StockInProcess(StockInModel myStockin)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var ReceivedBy = Session.Username;

                            // 1. Insert payment record
                            string sql = @"INSERT INTO stockin 
                                            (StockInID, MRRID, ItemID, ItemName, Quantity, 
                                            ReceivedQuantity, ReceivedDate, ReceivedBy, Notes, Status)
                                            VALUES 
                                            (@StockInID, @MRRID, @ItemID, @ItemName, @Quantity, 
                                            @ReceivedQuantity, @ReceivedDate, @ReceivedBy, @Notes, @Status)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, connection, transaction))
                            {
                                // If including StockOutID (remove if auto-increment)
                                cmd.Parameters.AddWithValue("@StockInID", myStockin.StockInID);

                                cmd.Parameters.AddWithValue("@MRRID", myStockin.MRRID);
                                cmd.Parameters.AddWithValue("@ItemID", myStockin.ItemID);
                                cmd.Parameters.AddWithValue("@ItemName", myStockin.ItemName ?? string.Empty);
                                cmd.Parameters.AddWithValue("@Quantity", myStockin.Quantity);
                                cmd.Parameters.AddWithValue("@ReceivedQuantity", myStockin.ReceivedQuantity);
                                cmd.Parameters.AddWithValue("@ReceivedDate", myStockin.ReceivedDate);
                                cmd.Parameters.AddWithValue("@ReceivedBy", myStockin.ReceivedBy ?? string.Empty);
                                cmd.Parameters.AddWithValue("@Notes", myStockin.Notes ?? string.Empty);
                                cmd.Parameters.AddWithValue("@Status", myStockin.Status ?? "Issued"); // Default status

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected == 0)
                                {
                                    transaction.Rollback();
                                    return (false, "Stock in processing failed - no rows affected");
                                }
                            }

                            // 2. Update inventory stock quantity
                            string updateInventorySql = @"UPDATE inventorystocks 
                                        SET AvailableQuantity = AvailableQuantity + @ReceivedQuantity
                                        WHERE ItemID = @ItemID";

                            using (MySqlCommand inventoryCmd = new MySqlCommand(updateInventorySql, connection, transaction))
                            {
                                inventoryCmd.Parameters.AddWithValue("@ReceivedQuantity", myStockin.ReceivedQuantity);
                                inventoryCmd.Parameters.AddWithValue("@ItemID", myStockin.ItemID);

                                int inventoryRowsAffected = inventoryCmd.ExecuteNonQuery();

                                if (inventoryRowsAffected == 0)
                                {
                                    transaction.Rollback();
                                    return (false, "Stockin processed but failed to update inventory quantity");
                                }
                            }

                            // 3. Update goods received notes status
                            string updateMRNSql = @"UPDATE materialrequestreturn 
                               SET Status = 'Stock Collected'
                               WHERE MRRID = @MRRID";

                            using (MySqlCommand updateCmd = new MySqlCommand(updateMRNSql, connection, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@MRRID", myStockin.MRRID);

                                int mrnRowsAffected = updateCmd.ExecuteNonQuery();

                                if (mrnRowsAffected == 0)
                                {
                                    transaction.Rollback();
                                    return (false, "Stockin processed but failed to update Material Request Notes status");
                                }
                            }

                            transaction.Commit();
                            return (true, $"Stockin processed successfully, inventory updated, and MRR status updated");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return (false, $"Error processing Stockin: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Database connection error: {ex.Message}");
            }
        }
    }
}
