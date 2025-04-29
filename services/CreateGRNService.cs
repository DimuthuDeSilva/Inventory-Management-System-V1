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

                    string sql = @"SELECT 
                        GRNID, POID, ItemID, ItemName, SupplierID, SupplierName, 
                        UnitPrice, NumberOfUnits, TotalCost, CreatedBy, 
                        DateOfDelivery, CreatedAt, Status, ConfirmedBy, Notes 
                       FROM 
                        goodsreceivednotes 
                       WHERE 
                        Status = 'Pending'";

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
                              (POID, ItemID, ItemName, SupplierID, SupplierName, UnitPrice, 
                               NumberOfUnits, TotalCost, CreatedBy, DateOfDelivery, Notes)                               
                              VALUES 
                              (@POID, @ItemID, @ItemName, @SupplierID, @SupplierName, @UnitPrice, 
                               @NumberOfUnits, @TotalCost, @CreatedBy, @DateOfDelivery, @Notes)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@POID", myGRN.POID);  // Changed from PONumber to POID
                        cmd.Parameters.AddWithValue("@ItemID", myGRN.ItemID);  // Added
                        cmd.Parameters.AddWithValue("@ItemName", myGRN.ItemName);  // Added
                        cmd.Parameters.AddWithValue("@SupplierID", myGRN.SupplierID);
                        cmd.Parameters.AddWithValue("@SupplierName", myGRN.SupplierName);
                        cmd.Parameters.AddWithValue("@UnitPrice", myGRN.UnitPrice);
                        cmd.Parameters.AddWithValue("@NumberOfUnits", myGRN.NumberOfUnits);
                        cmd.Parameters.AddWithValue("@TotalCost", myGRN.TotalCost);
                        cmd.Parameters.AddWithValue("@CreatedBy", Session.Username);  // Added
                        cmd.Parameters.AddWithValue("@DateOfDelivery", myGRN.DateOfDelivery);
                        //cmd.Parameters.AddWithValue("@Status", myGRN.Status);  // Added
                        //cmd.Parameters.AddWithValue("@ConfirmedBy", myGRN.ConfirmedBy ?? (object)DBNull.Value);  // Added (with null handling)
                        cmd.Parameters.AddWithValue("@Notes", myGRN.Notes ?? (object)DBNull.Value);  // Added (with null handling)

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateGRN(CreateGRNmodel myGRN)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"UPDATE goodsreceivednotes 
                       SET POID = @POID,
                           ItemID = @ItemID,
                           ItemName = @ItemName,
                           SupplierID = @SupplierID,
                           SupplierName = @SupplierName,
                           UnitPrice = @UnitPrice,
                           NumberOfUnits = @NumberOfUnits,
                           TotalCost = @TotalCost,
                           CreatedBy = @CreatedBy,
                           DateOfDelivery = @DateOfDelivery,
                           Status = @Status,
                           ConfirmedBy = @ConfirmedBy,
                           Notes = @Notes
                       WHERE GRNID = @GRNID";  // Critical filter

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Primary key filter (MISSING IN ORIGINAL CODE)
                        cmd.Parameters.AddWithValue("@GRNID", myGRN.GRNID);

                        cmd.Parameters.AddWithValue("@POID", myGRN.POID);
                        cmd.Parameters.AddWithValue("@ItemID", myGRN.ItemID);
                        cmd.Parameters.AddWithValue("@ItemName", myGRN.ItemName);
                        cmd.Parameters.AddWithValue("@SupplierID", myGRN.SupplierID);
                        cmd.Parameters.AddWithValue("@SupplierName", myGRN.SupplierName);
                        cmd.Parameters.AddWithValue("@UnitPrice", myGRN.UnitPrice);
                        cmd.Parameters.AddWithValue("@NumberOfUnits", myGRN.NumberOfUnits);
                        cmd.Parameters.AddWithValue("@TotalCost", myGRN.TotalCost);
                        cmd.Parameters.AddWithValue("@CreatedBy", Session.Username);
                        cmd.Parameters.AddWithValue("@DateOfDelivery", myGRN.DateOfDelivery);
                        cmd.Parameters.AddWithValue("@Status", myGRN.Status ?? "Pending"); // Default if null
                        cmd.Parameters.AddWithValue("@ConfirmedBy", myGRN.ConfirmedBy ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Notes", myGRN.Notes ?? (object)DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No records updated - GRNID not found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed: {ex.Message}");
            }
        }

        public DataSet GetPOdetails(int grnPOID)
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"SELECT ItemID, ItemName, SupplierID, SupplierName 
                          FROM goodsreceivednotes 
                          WHERE POID = @POID";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@POID", grnPOID);

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
        //public void DeleteGRN(CreateGRNmodel myGRN)
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
        //        {
        //            connection.Open();

        //            string sql = "DELETE FROM goodsreceivednotes WHERE GRNID = @GRNID";

        //            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
        //            {
        //                cmd.Parameters.AddWithValue("@GRNID", myGRN.GRNID);
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

    }
}
