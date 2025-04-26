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
using System.Transactions;
using Org.BouncyCastle.Utilities;

namespace Inventory_Management_System.Services
{
    public class ApprovePOService
    {
        public DataSet GetAllPurchaseOrders()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();
                    var userID = Session.UserID;

                    string sql = @"
                SELECT po.* 
                FROM PurchaseOrders po
                JOIN approvalflow af ON 
                    (af.FunctionName = 'Purchase Order Confirmation' AND 
                     af.UserID = @UserID)
                WHERE 
                    po.Status = 'Pending' AND
                    (
                        po.CreatedBy = @UserID OR
                        EXISTS (
                            SELECT 1 FROM approvalflow 
                            WHERE FunctionName = 'Purchase Order Confirmation' 
                            AND UserID = @UserID
                        )
                    )
                ORDER BY po.CreatedAt DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(ds);
                    }

                    // Additional access check if no records returned
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        string checkAccessSql = @"SELECT 1 FROM approvalflow 
                                   WHERE FunctionName = 'Purchase Order Confirmation'
                                   AND UserID = @UserID";
                        using (MySqlCommand accessCmd = new MySqlCommand(checkAccessSql, connection))
                        {
                            accessCmd.Parameters.AddWithValue("@UserID", userID);
                            if (accessCmd.ExecuteScalar() == null)
                            {
                                // Check if user created any POs (even if none are pending)
                                string checkCreatorSql = "SELECT 1 FROM PurchaseOrders WHERE CreatedBy = @UserID LIMIT 1";
                                using (MySqlCommand creatorCmd = new MySqlCommand(checkCreatorSql, connection))
                                {
                                    creatorCmd.Parameters.AddWithValue("@UserID", userID);
                                    if (creatorCmd.ExecuteScalar() == null)
                                    {
                                        return null; // Indicate no access
                                    }
                                }
                            }
                        }
                    }
                }
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Purchase Orders: {ex.Message}");
                return new DataSet(); // Return empty dataset on error
            }
        }
        public (bool IsSuccess, string Message) ConfirmPO(int poID, string notes)
        {
            using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var ApprovedBy = Session.UserID;

                        // 1. First update the PO status to Approved
                        string updateSql = @"
                                            UPDATE purchaseorders 
                                            SET 
                                                Status = 'Approved',
                                                ApprovedBy = @ApprovedBy
                                            WHERE 
                                                POID = @POID
                                                AND Status = 'Pending'";
                        

                        using (MySqlCommand cmd = new MySqlCommand(updateSql, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@POID", poID);
                            cmd.Parameters.AddWithValue("@ApprovedBy", ApprovedBy);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                transaction.Rollback();
                                return (false, "PO not found or already approved");
                            }
                        }

                        // 2. Get the approved PO details
                        string getPoSql = @"
                    SELECT 
                        po.PONumber, po.SupplierID, po.UnitPrice, po.NumberOfUnits, 
                        po.TotalAmount, po.CreatedBy, po.Notes, po.ExpectedDeliveryDate,
                        s.Name AS SupplierName
                    FROM purchaseorders po
                    JOIN suppliers s ON po.SupplierID = s.SupplierID
                    WHERE po.POID = @POID";

                        string poNumber = string.Empty;
                        int supplierID = 0;
                        decimal unitPrice = 0;
                        int numberOfUnits = 0;
                        decimal totalAmount = 0;
                        int createdBy = 0;
                        string note = string.Empty;
                        DateTime expectedDeliveryDate;
                        string supplierName = string.Empty;

                        using (MySqlCommand cmd = new MySqlCommand(getPoSql, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@POID", poID);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    poNumber = reader["PONumber"].ToString();
                                    supplierID = Convert.ToInt32(reader["SupplierID"]);
                                    unitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                                    numberOfUnits = Convert.ToInt32(reader["NumberOfUnits"]);
                                    totalAmount = Convert.ToDecimal(reader["TotalAmount"]);
                                    createdBy = Convert.ToInt32(reader["CreatedBy"]);
                                    note = reader["Notes"].ToString();
                                    expectedDeliveryDate = Convert.ToDateTime(reader["ExpectedDeliveryDate"]);
                                    supplierName = reader["SupplierName"].ToString();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    return (false, "PO details not found");
                                }
                            }
                        }

                        // 3. Insert into goodsreceivednotes
                        string grnSql = @"
                    INSERT INTO goodsreceivednotes
                    (PONumber, SupplierID, SupplierName, UnitPrice, 
                     NumberOfUnits, TotalCost, CreatedBy, DateOfDelivery, 
                     CreatedAt, Status, ConfirmedBy, Notes)
                    VALUES
                    (@PONumber, @SupplierID, @SupplierName, @UnitPrice, 
                     @NumberOfUnits, @TotalCost, @CreatedBy, @DateOfDelivery, 
                     @CreatedAt, @Status, @ConfirmedBy, @Notes);
                    SELECT LAST_INSERT_ID();";

                        int grnId = 0;
                        using (MySqlCommand cmd = new MySqlCommand(grnSql, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@PONumber", poNumber);
                            cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                            cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                            cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                            cmd.Parameters.AddWithValue("@NumberOfUnits", numberOfUnits);
                            cmd.Parameters.AddWithValue("@TotalCost", totalAmount);
                            cmd.Parameters.AddWithValue("@CreatedBy", createdBy);
                            cmd.Parameters.AddWithValue("@DateOfDelivery", expectedDeliveryDate); // Using PO's expected delivery date
                            cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Status", "Pending"); // Initial GRN status
                            cmd.Parameters.AddWithValue("@ConfirmedBy", DBNull.Value); // Not confirmed yet
                            cmd.Parameters.AddWithValue("@Notes", notes);
                                
                            grnId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        transaction.Commit();
                        return (true, $"PO #{poID} approved successfully. GRN #{grnId} created.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return (false, $"Failed to approve PO: {ex.Message}");
                    }
                }
            }
        }
    

        public (bool IsSuccess, string Message) RejectPO(int poID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    var ApprovedBy = Session.UserID;

                    string sql = @"
                UPDATE purchaseorders 
                SET 
                    Status = 'Rejected',
                    ApprovedBy = @ApprovedBy
                WHERE 
                    POID = @POID
                    AND Status = 'Pending'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@POID", poID);
                        cmd.Parameters.AddWithValue("@ApprovedBy", ApprovedBy);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            return (false, "PO not found or already rejected");
                        }

                        return (true, $"PO #{poID} rejected successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error here (e.g., using your logging system)
                return (false, $"Failed to reject PO: {ex.Message}");
            }
        }
    }
}
