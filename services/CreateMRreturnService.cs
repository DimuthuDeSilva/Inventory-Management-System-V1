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
    public class CreateMRreturnService
    {
        public DataSet GetAllMRR()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "SELECT * FROM materialrequestreturn";

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
        public bool CreateMRR(CreateMRreturnModel myCreateMRreturn)
        {
            using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert into materialrequestnotes
                        string mrnSql = @"
                            INSERT INTO materialrequestreturn 
                            (Department, RequestedBy, ItemID, ItemName, 
                             NumberOfUnits, Status, ApprovedBy, Notes, CreatedDate)
                            VALUES 
                            (@Department, @RequestedBy, @ItemID, @ItemName, 
                             @NumberOfUnits, @Status, @ApprovedBy, @Notes, @CreatedDate);

                            SELECT LAST_INSERT_ID();";

                        int newMRreturnID;
                        using (MySqlCommand cmd = new MySqlCommand(mrnSql, connection, transaction))
                        {
                            string requestedBy = Session.Username?.ToString() ?? "System";

                            cmd.Parameters.AddWithValue("@Department", myCreateMRreturn.Department);
                            cmd.Parameters.AddWithValue("@RequestedBy", myCreateMRreturn.RequestedBy);
                            cmd.Parameters.AddWithValue("@ItemID", myCreateMRreturn.ItemID);
                            cmd.Parameters.AddWithValue("@ItemName", myCreateMRreturn.ItemName);
                            cmd.Parameters.AddWithValue("@NumberOfUnits", myCreateMRreturn.NumberOfUnits);
                            cmd.Parameters.AddWithValue("@Status", myCreateMRreturn.Status ?? "Pending"); // Default to "Pending" if null
                            cmd.Parameters.AddWithValue("@ApprovedBy", myCreateMRreturn.ApprovedBy ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@Notes", myCreateMRreturn.Notes ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                            newMRreturnID = Convert.ToInt32(cmd.ExecuteScalar());
                            myCreateMRreturn.MRRID = newMRreturnID;
                        }
                        if (myCreateMRreturn.Status == "Pending")
                        {

                            // 2. Get Item Name from items table
                            string itemName = string.Empty;
                            string getItemNameSql = "SELECT Name FROM items WHERE ItemID = @ItemID";

                            using (MySqlCommand cmd = new MySqlCommand(getItemNameSql, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ItemID", myCreateMRreturn.ItemID);
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
                        MessageBox.Show($"Failed to create Material Request Return: {ex.Message}");
                        return false;
                    }
                    return true;

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
