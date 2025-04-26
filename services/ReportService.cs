using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Inventory_Management_System.Services
{
    public class ReportService
    {
        public DataSet StockReport(DateTime fromDate, DateTime toDate)
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    // Modified query to include date filtering
                    string sql = @"SELECT * FROM `inventorystocks` 
                          WHERE AddedDate BETWEEN @fromDate AND @toDate
                          ORDER BY AddedDate";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@fromDate", fromDate);
                        cmd.Parameters.AddWithValue("@toDate", toDate);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                // Better error handling - consider logging instead of showing a message box
                // in a service method
                throw new Exception("Error generating stock report: " + ex.Message);
            }
            return ds;
        }
    }
}
