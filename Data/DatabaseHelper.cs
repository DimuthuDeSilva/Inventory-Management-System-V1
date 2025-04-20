// Data/DatabaseHelper.cs
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem.Data
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            // Configure your connection string
            connectionString = "server=127.0.0.1;user=root;database=inventory_management_system;password=Bachelor@2320380";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void InitializeDatabase()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    // Create tables if they don't exist
                    string[] createTableQueries = {
                        @"CREATE TABLE IF NOT EXISTS Items (
                            ItemId INT AUTO_INCREMENT PRIMARY KEY,
                            Name VARCHAR(100) NOT NULL,
                            Quantity INT DEFAULT 0,
                            Supplier VARCHAR(100),
                            Category VARCHAR(50),
                            Price DECIMAL(10,2),
                            ReorderLevel INT,
                            CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                        );",

                        @"CREATE TABLE IF NOT EXISTS Warehouses (
                            WarehouseId INT AUTO_INCREMENT PRIMARY KEY,
                            Name VARCHAR(100) NOT NULL,
                            Location VARCHAR(255),
                            Capacity INT,
                            CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                        );"
                        
                        // Add other table creation queries here
                    };

                    foreach (var query in createTableQueries)
                    {
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing database: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is closed
                using (var connection = GetConnection())
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

        }
    }
}