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
    public class WareHouseService
    {
        public DataSet GetAllItems()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "SELECT * FROM warehouses";

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
        public void CreateWareHouse(WareHouse wareHouse)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"INSERT INTO warehouses 
          (Name, Location, Capacity, ManagerID, ContactPhone, IsActive)
          VALUES 
          (@Name, @Location, @Capacity, @ManagerID, @ContactPhone, @IsActive)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", wareHouse.Name);
                        cmd.Parameters.AddWithValue("@Location", wareHouse.Location);
                        cmd.Parameters.AddWithValue("@Capacity", wareHouse.Capacity);
                        cmd.Parameters.AddWithValue("@ManagerID", wareHouse.ManagerID);
                        cmd.Parameters.AddWithValue("@ContactPhone", wareHouse.ContactPhone);
                        cmd.Parameters.AddWithValue("@IsActive", wareHouse.IsActive);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateWareHouse(WareHouse wareHouse)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"UPDATE warehouses 
                                   SET Name = @Name,
                                       Location = @Location,
                                       Capacity = @Capacity,
                                       ManagerID = @ManagerID,
                                       ContactPhone = @ContactPhone,
                                       IsActive = @IsActive
                                   WHERE WarehouseID = @WarehouseID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@WarehouseID", wareHouse.WarehouseID);
                        cmd.Parameters.AddWithValue("@Name", wareHouse.Name);
                        cmd.Parameters.AddWithValue("@Location", wareHouse.Location);
                        cmd.Parameters.AddWithValue("@Capacity", wareHouse.Capacity);
                        cmd.Parameters.AddWithValue("@ManagerID", wareHouse.ManagerID);
                        cmd.Parameters.AddWithValue("@ContactPhone", wareHouse.ContactPhone);
                        cmd.Parameters.AddWithValue("@IsActive", wareHouse.IsActive);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteWarehouse(WareHouse wareHouse)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "DELETE FROM warehouses WHERE WarehouseID = @WarehouseID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@WarehouseID", wareHouse.WarehouseID);
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
