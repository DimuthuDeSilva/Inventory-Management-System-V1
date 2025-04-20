using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Data;
using MySql.Data.MySqlClient;

namespace Inventory_Management_System.Data
{
    public class ItemRepository
    {
        private readonly DatabaseHelper _dbHelper;

        public ItemRepository(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        //public List<Item> GetAllItems()
        //{
        //    var items = new List<Item>();

        //    using (var connection = _dbHelper.GetConnection())
        //    {
        //        connection.Open();
        //        string query = "SELECT * FROM Items WHERE IsActive = TRUE";

        //        using (var command = new MySqlCommand(query, connection))
        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                items.Add(new Item
        //                {
        //                    ItemID = reader.GetInt32("ItemID"),
        //                    Name = reader.GetString("Name"),
        //                    // Map all other properties...
        //                });
        //            }
        //        }
        //    }
        //    return items;
        //}

        // Add similar methods for Add, Update, Delete
    }
}