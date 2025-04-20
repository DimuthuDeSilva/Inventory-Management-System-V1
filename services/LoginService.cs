using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Inventory_Management_System.Data;

namespace InventoryManagementSystem.Service
{
    public class LoginService
    {
        public bool ValidateUser(string username, string password)
        {
            bool isValid = false;
            try
            {
                string connStr = SqlHelper.connectionstring();
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();
                    string sql = "SELECT COUNT(*) FROM users WHERE Username = @username AND Password = @password AND IsActive = 1";

                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        isValid = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating user: " + ex.Message);
            }

            return isValid;
        }
    }
}

