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
    public class ItemService
    {
        public DataSet GetAllItems()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "SELECT * FROM items";

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

        public void CreateItem(Items myItem)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"INSERT INTO items 
                      (Name, Description, Quantity, ReorderLevel, UnitPrice, 
                       TotalCost, SupplierID, WarehouseID, IsActive)
                      VALUES 
                      (@Name, @Description, @Quantity, @ReorderLevel, @UnitPrice, 
                       @TotalCost, @SupplierID, @WarehouseID, @IsActive)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", myItem.Name);
                        cmd.Parameters.AddWithValue("@Description", myItem.Description);
                        cmd.Parameters.AddWithValue("@Quantity", myItem.Quantity);
                        cmd.Parameters.AddWithValue("@ReorderLevel", myItem.ReorderLevel);
                        cmd.Parameters.AddWithValue("@UnitPrice", myItem.UnitPrice);
                        cmd.Parameters.AddWithValue("@TotalCost", myItem.TotalCost);
                        cmd.Parameters.AddWithValue("@SupplierID", myItem.SupplierID);
                        cmd.Parameters.AddWithValue("@WarehouseID", myItem.WarehouseID);
                        cmd.Parameters.AddWithValue("@IsActive", myItem.IsActive);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateItem(Items myItem)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"UPDATE Items 
                           SET Name = @Name,
                               Description = @Description,
                               Quantity = @Quantity,
                               ReorderLevel = @ReorderLevel,
                               UnitPrice = @UnitPrice,
                               TotalCost = @TotalCost,
                               SupplierID = @SupplierID,
                               WarehouseID = @WarehouseID,
                               IsActive = @IsActive
                           WHERE ItemID = @ItemID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", myItem.ItemID);
                        cmd.Parameters.AddWithValue("@Name", myItem.Name);
                        cmd.Parameters.AddWithValue("@Description", myItem.Description);
                        cmd.Parameters.AddWithValue("@Quantity", myItem.Quantity);
                        cmd.Parameters.AddWithValue("@ReorderLevel", myItem.ReorderLevel);
                        cmd.Parameters.AddWithValue("@UnitPrice", myItem.UnitPrice);
                        cmd.Parameters.AddWithValue("@TotalCost", myItem.TotalCost);
                        cmd.Parameters.AddWithValue("@SupplierID", myItem.SupplierID);
                        cmd.Parameters.AddWithValue("@WarehouseID", myItem.WarehouseID);
                        cmd.Parameters.AddWithValue("@IsActive", myItem.IsActive);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteItem(Items myItem)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "DELETE FROM Items WHERE ItemID = @ItemID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", myItem.ItemID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}