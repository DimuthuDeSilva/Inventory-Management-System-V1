using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Inventory_Management_System.Data;
using Inventory_Management_System.Models;

namespace InventoryManagementSystem.Service
{
    //public class LoginService
    //{
    //    //public bool ValidateUser(string username, string password)
    //    //{
    //    //    bool isValid = false;
    //    //    try
    //    //    {
    //    //        string connStr = SqlHelper.connectionstring();
    //    //        using (MySqlConnection connection = new MySqlConnection(connStr))
    //    //        {
    //    //            connection.Open();
    //    //            string sql = "SELECT COUNT(*) FROM users WHERE Username = @username AND Password = @password AND IsActive = 1";

    //    //            using (var command = new MySqlCommand(sql, connection))
    //    //            {
    //    //                command.Parameters.AddWithValue("@username", username);
    //    //                command.Parameters.AddWithValue("@password", password);

    //    //                int count = Convert.ToInt32(command.ExecuteScalar());

    //    //                isValid = count > 0;
    //    //            }
    //    //        }
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        MessageBox.Show("Error validating user: " + ex.Message);
    //    //    }

    //    //    return isValid;
    //    //}
    //    //public User ValidateUser(string username, string password)
    //    //    {
    //    //        User user = null;

    //    //        try
    //    //        {
    //    //            string connStr = SqlHelper.connectionstring();
    //    //            using (MySqlConnection connection = new MySqlConnection(connStr))
    //    //            {
    //    //                connection.Open();

    //    //                string sql = "SELECT UserID, Username, FullName, Role FROM users WHERE Username = @username AND Password = @password AND IsActive = 1";

    //    //                using (var command = new MySqlCommand(sql, connection))
    //    //                {
    //    //                    command.Parameters.AddWithValue("@username", username);
    //    //                    command.Parameters.AddWithValue("@password", password);

    //    //                    using (MySqlDataReader reader = command.ExecuteReader())
    //    //                    {
    //    //                        if (reader.Read())
    //    //                        {
    //    //                            user = new User
    //    //                            {
    //    //                                UserID = reader.GetInt32("UserID"),
    //    //                                Username = reader.GetString("Username"),
    //    //                                Fullname = reader.GetString("FullName"),
    //    //                                Role = reader.GetString("Role"),
    //    //                            };
    //    //                        }
    //    //                    }
    //    //                }
    //    //            }
    //    //        }
    //    //        catch (Exception ex)
    //    //        {
    //    //            MessageBox.Show("Error validating user: " + ex.Message);
    //    //        }

    //    //        return user;
    //    //    }
    //    //}
    //}
    // LoginService.cs
        public class LoginService
        {
            public User AuthenticateUser(string username, string password)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                    {
                        connection.Open();

                        string sql = @"SELECT UserID, Username, Password, FullName, Email, Role, IsActive, CreatedAt, LastLogin 
                               FROM Users 
                               WHERE Username = @Username AND Password = @Password AND IsActive = 1";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Password", password);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    return new User
                                    {
                                        UserID = Convert.ToInt32(reader["UserID"]),
                                        Username = reader["Username"].ToString(),
                                        Password = reader["Password"].ToString(),
                                        FullName = reader["FullName"].ToString(),
                                        Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : null,
                                        Role = reader["Role"].ToString(),
                                        IsActive = Convert.ToBoolean(reader["IsActive"]),
                                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                        LastLogin = reader["LastLogin"] != DBNull.Value ? Convert.ToDateTime(reader["LastLogin"]) : (DateTime?)null
                                    };
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Authentication failed: {ex.Message}");
                }
                return null;
            }

            public bool UpdateLastLogin(int userId)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                    {
                        connection.Open();

                        string sql = "UPDATE Users SET LastLogin = NOW() WHERE UserID = @UserID";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update last login: {ex.Message}");
                    return false;
                }
            }
        }

}

