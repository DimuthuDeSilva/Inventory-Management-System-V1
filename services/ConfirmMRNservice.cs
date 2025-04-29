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
    public class ConfirmMRNservice
    {
        public DataSet GetAllToConfirmMRNs()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();
                    var userID = Session.UserID;

                    string sql = @"
                SELECT mrn.* 
                FROM materialrequestnotes mrn
                JOIN approvalflow af ON 
                    (af.FunctionName = 'Material Request Note Confirm' AND 
                     af.UserID = @UserID)
                WHERE 
                    mrn.Status = 'Pending' AND
                    (
                        mrn.RequestedBy = @UserID OR
                        EXISTS (
                            SELECT 1 FROM approvalflow 
                            WHERE FunctionName = 'Material Request Note Confirm' 
                            AND UserID = @UserID
                        )
                    )
                ORDER BY mrn.CreatedDate DESC";

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
                                       WHERE FunctionName = 'Material Request Note Confirm'
                                       AND UserID = @UserID";
                        using (MySqlCommand accessCmd = new MySqlCommand(checkAccessSql, connection))
                        {
                            accessCmd.Parameters.AddWithValue("@UserID", userID);
                            if (accessCmd.ExecuteScalar() == null)
                            {
                                // Check if user requested any MRNs (even if none are pending)
                                string checkRequesterSql = "SELECT 1 FROM materialrequestnotes WHERE RequestedBy = @UserID LIMIT 1";
                                using (MySqlCommand requesterCmd = new MySqlCommand(checkRequesterSql, connection))
                                {
                                    requesterCmd.Parameters.AddWithValue("@UserID", userID);
                                    if (requesterCmd.ExecuteScalar() == null)
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
                MessageBox.Show($"Error loading Material Request Notes: {ex.Message}");
                return new DataSet(); // Return empty dataset on error
            }
        }

        public (bool IsSuccess, string Message) ConfirmMRN(int mrnID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    var approvedBy = Session.Username;

                    string sql = @"UPDATE materialrequestnotes 
                                  SET Status = 'Confirmed',
                                      ApprovedBy = @ApprovedBy
                                  WHERE MRNID = @MRNID 
                                  AND Status = 'Pending'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Fixed: Removed space after "@MRNID" in parameter name
                        cmd.Parameters.AddWithValue("@MRNID", mrnID);
                        cmd.Parameters.AddWithValue("@ApprovedBy", approvedBy);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            return (false, "MRN not found or already confirmed");
                        }

                        return (true, $"MRN #{mrnID} confirmed successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error here (e.g., using your logging system)
                return (false, $"Failed to confirm MRN: {ex.Message}");
            }
        }

        public (bool IsSuccess, string Message) RejectMRN(int mrnID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    var approvedBy = Session.Username;

                    string sql = @"UPDATE materialrequestnotes 
                                  SET Status = 'Rejected',
                                      ApprovedBy = @ApprovedBy
                                  WHERE MRNID = @MRNID 
                                  AND Status = 'Pending'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Fixed: Removed space after "@MRNID" in parameter name
                        cmd.Parameters.AddWithValue("@MRNID", mrnID);
                        cmd.Parameters.AddWithValue("@ApprovedBy", approvedBy);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            return (false, "MRN not found or already Rejected");
                        }

                        return (true, $"MRN #{mrnID} Rejected successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error here (e.g., using your logging system)
                return (false, $"Failed to reject MRN: {ex.Message}");
            }
        }
    }
}
