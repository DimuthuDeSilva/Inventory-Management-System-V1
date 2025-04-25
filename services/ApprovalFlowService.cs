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
    public class ApprovalFlowService
    {
        public DataSet GetAllApprovalFlow()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "SELECT * FROM approvalflow";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public void AddFlow(ApprovalFlowModel myAFSmodel)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"INSERT INTO approvalflow 
                      (FunctionName, Level, UserID, UserName)
                      VALUES 
                      (@FunctionName, @Level, @UserID, @UserName)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@FunctionName", myAFSmodel.FunctionName);
                        cmd.Parameters.AddWithValue("@Level", myAFSmodel.Level);
                        cmd.Parameters.AddWithValue("@UserID", myAFSmodel.UserID);
                        cmd.Parameters.AddWithValue("@UserName", myAFSmodel.UserName);


                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool UpdateFlow(ApprovalFlowModel myAFSmodel)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"UPDATE approvalflow 
                   SET FunctionName = @FunctionName, 
                       Level = @Level, 
                       UserID = @UserID, 
                       UserName = @UserName
                   WHERE ApprovalFlowID = @ApprovalFlowID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@FunctionName", myAFSmodel.FunctionName);
                        cmd.Parameters.AddWithValue("@Level", myAFSmodel.Level);
                        cmd.Parameters.AddWithValue("@UserID", myAFSmodel.UserID);
                        cmd.Parameters.AddWithValue("@UserName", myAFSmodel.UserName);
                        cmd.Parameters.AddWithValue("@ApprovalFlowID", myAFSmodel.ApprovalFlowID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating approval flow: {ex.Message}");
                return false;
            }
        }

        public void DeleteFlow(ApprovalFlowModel myAFSmodel)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "DELETE FROM approvalflow WHERE ApprovalFlowID = @ApprovalFlowID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApprovalFlowID", myAFSmodel.ApprovalFlowID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string GetFunctionName(int ApprovalFlowID)
        {
            string functionName = string.Empty;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    // Correct SQL query to get just the Name for a specific ItemID
                    string sql = "SELECT `FunctionName` FROM `approvalflow` WHERE `ApprovalFlowID ` = @ApprovalFlowID ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@ApprovalFlowID", ApprovalFlowID);

                        // Execute scalar since we only need one value
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            functionName = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // You might want to log the error here
            }

            return functionName;
        }
        public bool isExist(string functionName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string checkfunctionSql = "SELECT COUNT(1) FROM approvalflow WHERE FunctionName = @FunctionName";

                    using (MySqlCommand cmd = new MySqlCommand(checkfunctionSql, connection))
                    {
                        // Correct parameter name to match SQL (@itemID)
                        cmd.Parameters.AddWithValue("@FunctionName", functionName);
                        var result = cmd.ExecuteScalar();
                        bool itemExists = result != null && result.ToString() == functionName;

                        if (!itemExists)
                        {
                            return false;
                        }

                        return itemExists;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Return false if there's an error (or you could rethrow the exception)
            }
            return true;
        }
    }
}