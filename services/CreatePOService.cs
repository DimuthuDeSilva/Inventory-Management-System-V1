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
using Inventory_Management_System.Forms;

namespace Inventory_Management_System.Services
{
    public class CreatePOService
    {
        public DataSet GetAllPurchaseOrders()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = "SELECT * FROM PurchaseOrders WHERE Status != 'Deleted'";

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

        public bool CreatePurchaseOrder(CreatePOModel myCreatePO)
        {
            // Set initial status based on amount
            if (myCreatePO.TotalAmount >= 20000)
            {
                myCreatePO.Status = "Pending";
            }
            else
            {
                myCreatePO.Status = "Completed";
            }

            using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert into PurchaseOrders
                        string poSql = @"INSERT INTO purchaseorders 
                        (ItemID, ItemName, SupplierID, SupplierName, 
                         UnitPrice, NumberOfUnits, TotalAmount, OrderDate, 
                         ExpectedDeliveryDate, CreatedBy, ApprovedBy, 
                         Notes, CreatedAt, Status)
                        VALUES 
                        (@ItemID, @ItemName, @SupplierID, @SupplierName, 
                         @UnitPrice, @NumberOfUnits, @TotalAmount, @OrderDate, 
                         @ExpectedDeliveryDate, @CreatedBy, @ApprovedBy, 
                         @Notes, @CreatedAt, @Status);
                        SELECT LAST_INSERT_ID();";

                        int newPOID;
                        using (MySqlCommand cmd = new MySqlCommand(poSql, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ItemID", myCreatePO.ItemID);
                            cmd.Parameters.AddWithValue("@ItemName", myCreatePO.ItemName);
                            cmd.Parameters.AddWithValue("@SupplierName", myCreatePO.SupplierName);
                            cmd.Parameters.AddWithValue("@SupplierID", myCreatePO.SupplierID);
                            cmd.Parameters.AddWithValue("@OrderDate", myCreatePO.OrderDate);
                            cmd.Parameters.AddWithValue("@ExpectedDeliveryDate", myCreatePO.ExpectedDeliveryDate);
                            cmd.Parameters.AddWithValue("@UnitPrice", myCreatePO.UnitPrice);
                            cmd.Parameters.AddWithValue("@NumberOfUnits", myCreatePO.NumberOfUnits);
                            cmd.Parameters.AddWithValue("@TotalAmount", myCreatePO.TotalAmount);
                            cmd.Parameters.AddWithValue("@CreatedBy", myCreatePO.CreatedBy);
                            cmd.Parameters.AddWithValue("@ApprovedBy", myCreatePO.ApprovedBy ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@Notes", myCreatePO.Notes ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@Status", myCreatePO.Status);
                            cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                            newPOID = Convert.ToInt32(cmd.ExecuteScalar());
                            myCreatePO.POID = newPOID;
                        }
                        if (myCreatePO.Status == "Completed")
                        {

                            // 2. Get Supplier Name from suppliers table
                            string supplierName = string.Empty;
                            string getSupplierSql = "SELECT Name FROM suppliers WHERE SupplierID = @SupplierID";

                            using (MySqlCommand cmd = new MySqlCommand(getSupplierSql, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@SupplierID", myCreatePO.SupplierID);
                                supplierName = cmd.ExecuteScalar()?.ToString() ?? string.Empty;
                            }

                            if (string.IsNullOrEmpty(supplierName))
                            {
                                throw new Exception("Supplier not found in database");
                            }

                            // 3. Insert into goodsreceivednotes
                            string grnSql = @"INSERT INTO goodsreceivednotes
                              (POID, ItemID, ItemName, SupplierID, SupplierName, 
                               UnitPrice, NumberOfUnits, TotalCost, CreatedBy, 
                               DateOfDelivery, CreatedAt, Status, ConfirmedBy, Notes)
                              VALUES
                              (@GRNID, @POID, @ItemID, @ItemName, @SupplierID, @SupplierName, 
                               @UnitPrice, @NumberOfUnits, @TotalCost, @CreatedBy, 
                               @DateOfDelivery, @CreatedAt, @Status, @ConfirmedBy, @Notes);
                              SELECT LAST_INSERT_ID();";

                            using (MySqlCommand cmd = new MySqlCommand(grnSql, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@POID", myCreatePO.POID);
                                cmd.Parameters.AddWithValue("@ItemID", myCreatePO.ItemID);
                                cmd.Parameters.AddWithValue("@ItemName", myCreatePO.ItemName);
                                cmd.Parameters.AddWithValue("@SupplierID", myCreatePO.SupplierID);
                                cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                                cmd.Parameters.AddWithValue("@UnitPrice", myCreatePO.UnitPrice);
                                cmd.Parameters.AddWithValue("@NumberOfUnits", myCreatePO.NumberOfUnits);
                                cmd.Parameters.AddWithValue("@TotalCost", myCreatePO.TotalAmount);
                                cmd.Parameters.AddWithValue("@CreatedBy", myCreatePO.CreatedBy);
                                cmd.Parameters.AddWithValue("@DateOfDelivery", myCreatePO.ExpectedDeliveryDate);
                                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                                cmd.Parameters.AddWithValue("@Status", "Pending");
                                cmd.Parameters.AddWithValue("@ConfirmedBy", DBNull.Value);
                                cmd.Parameters.AddWithValue("@Notes", myCreatePO.Notes ?? (object)DBNull.Value);

                                int newGRNID = Convert.ToInt32(cmd.ExecuteScalar());
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to create purchase order: {ex.Message}");
                        return false;
                    }
                }
            }
            
        }

        public bool UpdatePurchaseOrder(CreatePOModel myUpdatePO)
        {
            using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
            {
                connection.Open();

                // First check the current status of the PO
                string statusCheckSql = "SELECT Status FROM PurchaseOrders WHERE POID = @POID";
                string currentStatus;

                using (MySqlCommand cmd = new MySqlCommand(statusCheckSql, connection))
                {
                    cmd.Parameters.AddWithValue("@POID", myUpdatePO.POID);
                    currentStatus = cmd.ExecuteScalar()?.ToString() ?? string.Empty;
                }

                // If status is Approved or Rejected, don't allow update
                if (currentStatus == "Approved" || currentStatus == "Rejected" || currentStatus == "Deleted")
                {
                    MessageBox.Show("Cannot update a Purchase Order that has been Approved, Rejected or Deleted.");
                    return false;
                }

                // Recalculate status based on new amount
                if (myUpdatePO.TotalAmount >= 20000)
                {
                    myUpdatePO.Status = "Pending";
                }
                else
                {
                    myUpdatePO.Status = "Completed";
                }

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Update PurchaseOrders table
                        string poUpdateSql = @"UPDATE purchaseorders 
                                                  SET ItemID = @ItemID,
                                                      ItemName = @ItemName,
                                                      SupplierID = @SupplierID,
                                                      SupplierName = @SupplierName,
                                                      UnitPrice = @UnitPrice,
                                                      NumberOfUnits = @NumberOfUnits,
                                                      TotalAmount = @TotalAmount,
                                                      OrderDate = @OrderDate,
                                                      ExpectedDeliveryDate = @ExpectedDeliveryDate,
                                                      CreatedBy = @CreatedBy,
                                                      ApprovedBy = @ApprovedBy,
                                                      Notes = @Notes,
                                                      Status = @Status
                                                  WHERE POID = @POID";

                        using (MySqlCommand cmd = new MySqlCommand(poUpdateSql, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@POID", myUpdatePO.POID);
                            cmd.Parameters.AddWithValue("@ItemID", myUpdatePO.ItemID);
                            cmd.Parameters.AddWithValue("@ItemName", myUpdatePO.ItemName);
                            cmd.Parameters.AddWithValue("@SupplierName", myUpdatePO.SupplierName);
                            cmd.Parameters.AddWithValue("@SupplierID", myUpdatePO.SupplierID);
                            cmd.Parameters.AddWithValue("@OrderDate", myUpdatePO.OrderDate);
                            cmd.Parameters.AddWithValue("@ExpectedDeliveryDate", myUpdatePO.ExpectedDeliveryDate);
                            cmd.Parameters.AddWithValue("@UnitPrice", myUpdatePO.UnitPrice);
                            cmd.Parameters.AddWithValue("@NumberOfUnits", myUpdatePO.NumberOfUnits);
                            cmd.Parameters.AddWithValue("@TotalAmount", myUpdatePO.TotalAmount);
                            cmd.Parameters.AddWithValue("@CreatedBy", myUpdatePO.CreatedBy);
                            cmd.Parameters.AddWithValue("@ApprovedBy", myUpdatePO.ApprovedBy ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@Notes", myUpdatePO.Notes ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@Status", myUpdatePO.Status);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                throw new Exception("No rows were updated. PO might not exist.");
                            }
                        }

                        // If status changed to "Completed", we might need to create a GRN
                        // (This would depend on your business logic - you might need to check if a GRN already exists)
                        // Similar logic to CreatePurchaseOrder could be added here if needed

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to update purchase order: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public void DeletePO(CreatePOModel myItem)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    // First delete related PO items (if needed)
                    string deleteItemsSql = "UPDATE `purchaseorders` SET `Status` = 'Deleted' WHERE `POID` = @POID;";
                    using (MySqlCommand deleteItemsCmd = new MySqlCommand(deleteItemsSql, connection))
                    {
                        deleteItemsCmd.Parameters.AddWithValue("@POID", myItem.POID);
                        deleteItemsCmd.ExecuteNonQuery();
                    }

                    // Then delete the purchase order
                    //string deleteOrderSql = "DELETE FROM PurchaseOrders WHERE POID = @POID";
                    //using (MySqlCommand cmd = new MySqlCommand(deleteOrderSql, connection))
                    //{
                    //    cmd.Parameters.AddWithValue("@POID", myItem.POID);
                    //    int rowsAffected = cmd.ExecuteNonQuery();
            
                    //    if (rowsAffected == 0)
                    //    {
                    //        MessageBox.Show("No purchase order found with the specified ID.");
                    //    }
                    //}
                }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
            catch (Exception ex)
            {
                  MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}