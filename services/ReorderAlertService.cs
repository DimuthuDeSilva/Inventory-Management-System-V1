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
    public class ReorderAlertService
    {
        public DataSet GetAllReOrderAlerts()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"
                SELECT 
                    i.ItemID, 
                    i.Name AS ItemName, 
                    i.ReorderLevel,
                    w.WarehouseID,
                    w.Name AS WarehouseName,
                    ist.AvailableQuantity,
                    i.IsActive
                FROM 
                    items i
                LEFT JOIN 
                    inventorystocks ist ON i.ItemID = ist.ItemID
                LEFT JOIN 
                    warehouses w ON i.WarehouseID = w.WarehouseID
                WHERE 
                    i.IsActive = 1
                    AND ist.AvailableQuantity <= i.ReorderLevel";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}",
                               "Database Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            return ds;
        }

        //public bool checkReOrderLvel()
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
        //        {
        //            connection.Open();

        //            string sql ="";

        //            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
        //            {
        //                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //                adapter.Fill(ds);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error retrieving data: {ex.Message}",
        //                       "Database Error",
        //                       MessageBoxButtons.OK,
        //                       MessageBoxIcon.Error);
        //    }
        //    return true;
        //}
    }
}
