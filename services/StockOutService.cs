using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Services
{
    public class StockOutService
    {
        public DataSet GetApprovedMRNsWithMRNID()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"SELECT MRNID, Department, RequestedBy, 
                              ItemID, ItemName, NumberOfUnits, 
                              Status, ApprovedBy, Notes, CreatedDate
                               FROM materialrequestnotes
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
                MessageBox.Show($"Error retrieving approved MRNs: {ex.Message}",
                               "Database Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            return ds;
        }
        public (bool IsSuccess, string Message) StockOutProcess(StockOutModel myStockout)
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
                            var IssuedBy = Session.Username;

                            // 1. Insert payment record
                            string sql = @"INSERT INTO stockout 
                                (MRNID, ItemID, ItemName, Quantity, 
                                IssuedQuantity, IssuedDate, IssuedBy, Notes, Status)
                                VALUES 
                                (@MRNID, @ItemID, @ItemName, @Quantity, 
                                @IssuedQuantity, @IssuedDate, @IssuedBy, @Notes, @Status)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, connection, transaction))
                            {
                                // If including StockOutID (remove if auto-increment)
                                cmd.Parameters.AddWithValue("@StockOutID", myStockout.StockOutID);

                                cmd.Parameters.AddWithValue("@MRNID", myStockout.MRNID);
                                cmd.Parameters.AddWithValue("@ItemID", myStockout.ItemID);
                                cmd.Parameters.AddWithValue("@ItemName", myStockout.ItemName ?? string.Empty);
                                cmd.Parameters.AddWithValue("@Quantity", myStockout.Quantity);
                                cmd.Parameters.AddWithValue("@IssuedQuantity", myStockout.IssuedQuantity ?? 0); // Default to 0 if null
                                cmd.Parameters.AddWithValue("@IssuedDate", myStockout.IssuedDate);
                                cmd.Parameters.AddWithValue("@IssuedBy", myStockout.IssuedBy ?? string.Empty);
                                cmd.Parameters.AddWithValue("@Notes", myStockout.Notes ?? string.Empty);
                                cmd.Parameters.AddWithValue("@Status", myStockout.Status ?? "Issued"); // Default status

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected == 0)
                                {
                                    transaction.Rollback();
                                    return (false, "Stock out processing failed - no rows affected");
                                }
                            }

                            // 2. Update inventory stock quantity
                            string updateInventorySql = @"UPDATE inventorystocks 
                                        SET AvailableQuantity = AvailableQuantity - @IssuedQuantity
                                        WHERE ItemID = @ItemID";

                            using (MySqlCommand inventoryCmd = new MySqlCommand(updateInventorySql, connection, transaction))
                            {
                                inventoryCmd.Parameters.AddWithValue("@IssuedQuantity", myStockout.IssuedQuantity ?? 0);
                                inventoryCmd.Parameters.AddWithValue("@ItemID", myStockout.ItemID);

                                int inventoryRowsAffected = inventoryCmd.ExecuteNonQuery();

                                if (inventoryRowsAffected == 0)
                                {
                                    transaction.Rollback();
                                    return (false, "Stockout processed but failed to update inventory quantity");
                                }
                            }

                            // 3. Update goods received notes status
                            string updateMRNSql = @"UPDATE materialrequestnotes 
                               SET Status = 'Stock Released'
                               WHERE MRNID = @MRNID";

                            using (MySqlCommand updateCmd = new MySqlCommand(updateMRNSql, connection, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@MRNID", myStockout.MRNID);

                                int mrnRowsAffected = updateCmd.ExecuteNonQuery();

                                if (mrnRowsAffected == 0)
                                {
                                    transaction.Rollback();
                                    return (false, "Stockout processed but failed to update Material Request Notes status");
                                }
                            }

                            transaction.Commit();
                            return (true, $"Stockout processed successfully, inventory updated, and MRN status updated");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return (false, $"Error processing Stockout: {ex.Message}");
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
