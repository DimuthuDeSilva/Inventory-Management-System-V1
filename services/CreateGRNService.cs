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
    public class CreateGRNService
    {
        public DataSet GetAllGRN()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "SELECT * FROM goodsreceivednotes";

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
        public void CreateGRN(CreateGRNmodel myGRN)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"INSERT INTO goodsreceivednotes 
                      (GRNID, PONumber, SupplierID, SupplierName, UnitPrice, TotalCost, 
                       NumberOfUnits, DateOfDelivery)
                      VALUES 
                      (@GRNID, @PONumber, @SupplierID, @SupplierName, @UnitPrice, @TotalCost, 
                       @NumberOfUnits, @DateOfDelivery)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@GRNID", myGRN.GRNID);
                        cmd.Parameters.AddWithValue("@PONumber", myGRN.PONumber);
                        cmd.Parameters.AddWithValue("@SupplierID", myGRN.SupplierID);
                        cmd.Parameters.AddWithValue("@SupplierName", myGRN.SupplierName);
                        cmd.Parameters.AddWithValue("@UnitPrice", myGRN.UnitPrice);
                        cmd.Parameters.AddWithValue("@TotalCost", myGRN.TotalCost);
                        cmd.Parameters.AddWithValue("@NumberOfUnits", myGRN.NumberOfUnits);
                        cmd.Parameters.AddWithValue("@DateOfDelivery", myGRN.DateOfDelivery);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ConfirmGRN(CreateGRNmodel myGRN)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"UPDATE goodsreceivednotes 
                   SET PONumber = @PONumber,
                       SupplierID = @SupplierID,
                       SupplierName = @SupplierName,
                       UnitPrice = @UnitPrice,
                       TotalCost = @TotalCost,
                       NumberOfUnits = @NumberOfUnits,
                       DateOfDelivery = @DateOfDelivery
                   WHERE GRNID = @GRNID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@GRNID", myGRN.GRNID);
                        cmd.Parameters.AddWithValue("@PONumber", myGRN.PONumber);
                        cmd.Parameters.AddWithValue("@SupplierID", myGRN.SupplierID);
                        cmd.Parameters.AddWithValue("@SupplierName", myGRN.SupplierName);
                        cmd.Parameters.AddWithValue("@UnitPrice", myGRN.UnitPrice);
                        cmd.Parameters.AddWithValue("@TotalCost", myGRN.TotalCost);
                        cmd.Parameters.AddWithValue("@NumberOfUnits", myGRN.NumberOfUnits);
                        cmd.Parameters.AddWithValue("@DateOfDelivery", myGRN.DateOfDelivery);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CancelGRN(CreateGRNmodel myGRN)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "DELETE FROM goodsreceivednotes WHERE GRNID = @GRNID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@GRNID", myGRN.GRNID);
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
