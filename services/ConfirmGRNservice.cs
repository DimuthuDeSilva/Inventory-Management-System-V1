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
using Inventory_Management_System.Forms;

namespace Inventory_Management_System.Services
{
    public class ConfirmGRNservice
    {
        public DataSet GetAllGRN()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();
                    var userID = Session.UserID;

                    string sql = @"
                SELECT grn.* 
                FROM goodsreceivednotes grn
                JOIN approvalflow af ON 
                    (af.FunctionName = 'GRN Confirmation' AND 
                     af.UserID = @UserID)
                WHERE 
                    grn.Status = 'Pending' AND
                    (
                        grn.CreatedBy = @UserID OR
                        EXISTS (
                            SELECT 1 FROM approvalflow 
                            WHERE FunctionName = 'GRN Confirmation' 
                            AND UserID = @UserID
                        )
                    )
                ORDER BY grn.CreatedAt DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(ds);
                    }

                    // Additional access check if no records returned
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        string checkAccessSql = @"SELECT 1 FROM approvalflow 
                                       WHERE FunctionName = 'GRN Confirmation'
                                       AND UserID = @UserID";
                        using (MySqlCommand accessCmd = new MySqlCommand(checkAccessSql, connection))
                        {
                            accessCmd.Parameters.AddWithValue("@UserID", userID);
                            if (accessCmd.ExecuteScalar() == null)
                            {
                                // Check if user created any GRNs (even if none are pending)
                                string checkCreatorSql = "SELECT 1 FROM goodsreceivednotes WHERE CreatedBy = @UserID LIMIT 1";
                                using (MySqlCommand creatorCmd = new MySqlCommand(checkCreatorSql, connection))
                                {
                                    creatorCmd.Parameters.AddWithValue("@UserID", userID);
                                    if (creatorCmd.ExecuteScalar() == null)
                                    {
                                        return null; // Indicate no access
                                    }
                                }
                            }
                        }
                    }
                }
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Goods Received Notes: {ex.Message}");
                return new DataSet(); // Return empty dataset on error
            }
        }
        public (bool IsSuccess, string Message) ConfirmGRN(int grnID, int itemID, int quantity)
        {
            using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var confirmedBy = Session.Username;

                        // 1. First update the GRN status
                        string updateGRNSql = @"UPDATE goodsreceivednotes 
                                      SET Status = 'Confirmed',
                                          ConfirmedBy = @ConfirmedBy
                                      WHERE GRNID = @GRNID 
                                      AND Status = 'Pending'";

                        using (MySqlCommand cmd = new MySqlCommand(updateGRNSql, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@GRNID", grnID);
                            cmd.Parameters.AddWithValue("@ConfirmedBy", confirmedBy);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                transaction.Rollback();
                                return (false, "GRN not found or already confirmed");
                            }
                        }

                        // 2. Update inventory stock
                        string updateInventorySql = @"UPDATE inventorystocks 
                                           SET AvailableQuantity = AvailableQuantity + @Quantity
                                           WHERE ItemID = @ItemID";

                        using (MySqlCommand cmd = new MySqlCommand(updateInventorySql, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ItemID", itemID);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);

                            int inventoryRows = cmd.ExecuteNonQuery();
                            if (inventoryRows == 0)
                            {
                                transaction.Rollback();
                                return (false, "Item not found in inventory");
                            }
                        }

                        transaction.Commit();
                        return (true, $"GRN #{grnID} confirmed and inventory updated successfully");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return (false, $"Failed to confirm GRN: {ex.Message}");
                    }
                }
            }
        }
        public (bool IsSuccess, string Message) RejectGRN(int grnID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    var rejectedBy = Session.Username;  // More accurate variable name

                    string sql = @"
                UPDATE goodsreceivednotes 
                SET 
                    Status = 'Rejected',
                    ConfirmedBy = @ConfirmedBy
                WHERE 
                    GRNID = @GRNID 
                    AND Status = 'Pending'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Fixed: Removed space after "@GRNID" in parameter name
                        cmd.Parameters.AddWithValue("@GRNID", grnID);
                        cmd.Parameters.AddWithValue("@ConfirmedBy", rejectedBy);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            return (false, "GRN not found or already rejected/processed");
                        }

                        return (true, $"GRN #{grnID} rejected successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                // Added missing catch block
                return (false, $"Failed to reject GRN: {ex.Message}");
            }
        }
    }
}
