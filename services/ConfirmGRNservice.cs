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
                        string checkAccessSql = "SELECT 1 FROM approvalflow WHERE UserID = @UserID";
                        using (MySqlCommand accessCmd = new MySqlCommand(checkAccessSql, connection))
                        {
                            accessCmd.Parameters.AddWithValue("@UserID", userID);
                            if (accessCmd.ExecuteScalar() == null)
                            {
                                return null; // Indicate no access
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
        public (bool IsSuccess, string Message) ConfirmGRN (int grnID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    var ConfirmedBy = Session.UserID;

                    string sql = @"UPDATE goodsreceivednotes 
                                SET 
                                    Status = 'Confirmed',
                                    ConfirmedBy = @ConfirmedBy
                                WHERE 
                                    GRNID  = @GRNID 
                                    AND Status = 'Pending'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@GRNID ", grnID);
                        cmd.Parameters.AddWithValue("@ConfirmedBy", ConfirmedBy);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            return (false, "GRN not found or already Confirmed");
                        }

                        return (true, $"PO #{grnID} Confirmed successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error here (e.g., using your logging system)
                return (false, $"Failed to confirm GRN: {ex.Message}");
            }
        }
        public (bool IsSuccess, string Message) RejectGRN (int grnID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    var ConfirmedBy = Session.UserID;

                    string sql = @"
                UPDATE goodsreceivednotes 
                SET 
                    Status = 'Rejected',
                    ConfirmedBy = @ConfirmedBy
                WHERE 
                    GRNID  = @GRNID 
                    AND Status = 'Pending'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@GRNID ", grnID);
                        cmd.Parameters.AddWithValue("@ConfirmedBy",ConfirmedBy);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            return (false, "GRN not found or already rejected");
                        }

                        return (true, $"GRN #{grnID} rejected successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error here (e.g., using your logging system)
                return (false, $"Failed to reject GRN: {ex.Message}");
            }
        }
    }
}
