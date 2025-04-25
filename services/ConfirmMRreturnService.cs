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
using System.Transactions;
using Org.BouncyCastle.Utilities;

namespace Inventory_Management_System.Services
{
    public class ConfirmMRreturnService
    {
        public DataSet GetAllToConfirmMRRs()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();
                    var userID = Session.UserID;

                    string sql = @"
                            SELECT mrr.* 
                            FROM materialrequestreturn mrr
                            JOIN approvalflow af ON 
                                (af.FunctionName = 'Material Request Return Confirm' AND 
                                 af.UserID = @UserID)
                            WHERE 
                                mrr.Status = 'Pending' AND
                                (
                                    mrr.RequestedBy  = @UserID OR
                                    EXISTS (
                                        SELECT 1 FROM approvalflow 
                                        WHERE FunctionName = 'Material Request Return Confirm' 
                                        AND UserID = @UserID
                                    )
                                )
                            ORDER BY mrr.CreatedDate DESC";

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
                MessageBox.Show($"Error loading Material Request Return: {ex.Message}");
                return new DataSet(); // Return empty dataset on error
            }
        }
        public (bool IsSuccess, string Message) ConfirmMRR(int mrrID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    var ApprovedBy = Session.Username;

                    string sql = @"UPDATE materialrequestreturn 
                                SET Status = 'Confirmed',
                                    ApprovedBy = @ApprovedBy
                                WHERE 
                                    MRRID  = @MRRID 
                                    AND Status = 'Pending'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@MRRID ", mrrID);
                        cmd.Parameters.AddWithValue("@ApprovedBy", ApprovedBy);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            return (false, "MRR not found or already confirmed");
                        }

                        return (true, $"MRR #{mrrID} Confirmed successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error here (e.g., using your logging system)
                return (false, $"Failed to Confirm MRR: {ex.Message}");
            }
        }
        public (bool IsSuccess, string Message) RejectMRR(int mrrID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    var ApprovedBy = Session.Username;

                    string sql = @"UPDATE materialrequestreturn 
                                SET Status = 'Rejected',
                                    ApprovedBy = @ApprovedBy
                                WHERE 
                                    MRNID  = @MRNID 
                                    AND Status = 'Pending'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@MRNID ", mrrID);
                        cmd.Parameters.AddWithValue("@ApprovedBy", ApprovedBy);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            return (false, "MRR not found or already rejected");
                        }

                        return (true, $"MRR #{mrrID} Rejected successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error here (e.g., using your logging system)
                return (false, $"Failed to Reject MRR: {ex.Message}");
            }
        }
    }
}
