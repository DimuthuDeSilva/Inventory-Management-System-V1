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
    public class CreateMRNService
    {
        public DataSet GetAllMRN()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "SELECT * FROM materialrequestnotes";

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

        public bool CreateMRN(CreateMRNmodel myCreateMRN)
        {
            using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert into materialrequestnotes
                        string mrnSql = @"INSERT INTO materialrequestnotes 
                        (Department, RequestedBy, ItemID, ItemName, 
                         NumberOfUnits, Status, ApprovedBy, Notes, CreatedDate)
                        VALUES 
                        (@Department, @RequestedBy, @ItemID, @ItemName, 
                         @NumberOfUnits, @Status, @ApprovedBy, @Notes, @CreatedDate);
                        SELECT LAST_INSERT_ID();";

                        int newMRNID;
                        using (MySqlCommand cmd = new MySqlCommand(mrnSql, connection, transaction))
                        {
                            string requestedBy = Session.Username?.ToString() ?? "System";

                            cmd.Parameters.AddWithValue("@Department", myCreateMRN.Department);
                            cmd.Parameters.AddWithValue("@RequestedBy", myCreateMRN.RequestedBy);
                            cmd.Parameters.AddWithValue("@ItemID", myCreateMRN.ItemID);
                            cmd.Parameters.AddWithValue("@ItemName", myCreateMRN.ItemName);
                            cmd.Parameters.AddWithValue("@NumberOfUnits", myCreateMRN.NumberOfUnits);
                            cmd.Parameters.AddWithValue("@Status", myCreateMRN.Status ?? "Pending"); // Default to "Pending" if null
                            cmd.Parameters.AddWithValue("@ApprovedBy", myCreateMRN.ApprovedBy ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@Notes", myCreateMRN.Notes ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                            newMRNID = Convert.ToInt32(cmd.ExecuteScalar());
                            myCreateMRN.MRNID = newMRNID;
                        }
                        if (myCreateMRN.Status == "Pending")
                        {

                            // 2. Get Item Name from suppliers table
                            string itemName = string.Empty;
                            string getItemNameSql = "SELECT Name FROM items WHERE ItemID = @ItemID";

                            using (MySqlCommand cmd = new MySqlCommand(getItemNameSql, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ItemID", myCreateMRN.ItemID);
                                itemName = cmd.ExecuteScalar()?.ToString() ?? string.Empty;
                            }

                            if (string.IsNullOrEmpty(itemName))
                            {
                                throw new Exception("Item not found in the list");
                            }

                            transaction.Commit();

                        }
                    }

                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to create Material Request Note: {ex.Message}");
                        return false;
                    }
                    return true;

                }
            }

        }

        public bool CancelMRN(CreateMRNmodel myCancelMRN)
        {
            using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
            {
                connection.Open();

                // First check the current status of the PO
                string statusCheckSql = "SELECT Status FROM materialrequestnotes WHERE MRNID  = @MRNID";
                string currentStatus;

                using (MySqlCommand cmd = new MySqlCommand(statusCheckSql, connection))
                {
                    cmd.Parameters.AddWithValue("@MRNID ", myCancelMRN.MRNID);
                    currentStatus = cmd.ExecuteScalar()?.ToString() ?? string.Empty;
                }

                // If status is Approved or Rejected, don't allow update
                if (currentStatus == "Confirmed" || currentStatus == "Rejected")
                {
                    MessageBox.Show("Cannot cancel a Material Request Note that has been Confirmed or Rejected.");
                    return false;
                }

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Update PurchaseOrders table
                        string mrnUpdateSql = @"UPDATE materialrequestnotes 
                                   SET Status = @Status
                                   WHERE MRNID = @MRNID";

                        using (MySqlCommand cmd = new MySqlCommand(mrnUpdateSql, connection, transaction))
                        {
                         
                            cmd.Parameters.AddWithValue("@Status", myCancelMRN.Status);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                throw new Exception("No rows were updated. MRN might not exist.");
                            }
                        }

                        // If status changed to "Completed", we might need to create a GRN
                        // (This would depend on your business logic - you might need to check if a GRN already exists)
                        // Similar logic to CreatePurchaseOrder could be added here if needed

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to update Material Request Note: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public string GetItemName(int itemID)
        {
            string itemName = string.Empty;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    // Correct SQL query to get just the Name for a specific ItemID
                    string sql = "SELECT `Name` FROM `items` WHERE `ItemID` = @ItemID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@ItemID", itemID);

                        // Execute scalar since we only need one value
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            itemName = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // You might want to log the error here
            }

            return itemName;
        }
        public bool isExist(int itemID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string checkItemSql = "SELECT COUNT(1) FROM Items WHERE ItemID = @itemID";

                    using (MySqlCommand cmd = new MySqlCommand(checkItemSql, connection))
                    {
                        // Correct parameter name to match SQL (@itemID)
                        cmd.Parameters.AddWithValue("@itemID", itemID);
                        bool itemExists = Convert.ToInt32(cmd.ExecuteScalar()) > 0;

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