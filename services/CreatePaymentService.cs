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
using Org.BouncyCastle.Asn1.Ocsp;

namespace Inventory_Management_System.Services
{
    public class CreatePaymentService
    {
        public DataSet GetApprovedGRNsWithPOID()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();

                    string sql = @"SELECT grn.GRNID, grn.PONumber, po.POID, 
                                 grn.SupplierID, grn.SupplierName, 
                                 grn.UnitPrice, grn.NumberOfUnits, 
                                 grn.TotalCost, grn.CreatedBy, 
                                 grn.DateOfDelivery, grn.CreatedAt, 
                                 grn.Status, grn.ConfirmedBy, grn.Notes
                          FROM goodsreceivednotes grn
                          INNER JOIN purchaseorders po ON grn.PONumber = po.PONumber
                          WHERE grn.Status = 'Approved'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving approved GRNs with POID: {ex.Message}",
                               "Database Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            return ds;
        }


        public (bool IsSuccess, string Message) PaymentProcess(CreatePaymentModel myPayment)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(SqlHelper.connectionstring()))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var processedBy = Session.Username;

                            // 1. Insert payment record
                            string sql = @"INSERT INTO payments 
                        (PaymentID, PaymentReference, POID, Amount, PaymentMethod, 
                        Status, PaymentDate, ProcessedBy, Notes)
                        VALUES 
                        (@PaymentID, @PaymentReference, @POID, @Amount, @PaymentMethod, 
                        @Status, @PaymentDate, @ProcessedBy, @Notes)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@PaymentID", myPayment.PaymentID);
                                cmd.Parameters.AddWithValue("@PaymentReference", myPayment.PaymentReference ?? string.Empty);
                                cmd.Parameters.AddWithValue("@POID", myPayment.POID);
                                cmd.Parameters.AddWithValue("@Amount", myPayment.Amount);
                                cmd.Parameters.AddWithValue("@PaymentMethod", myPayment.PaymentMethod ?? "Unknown");
                                cmd.Parameters.AddWithValue("@Status", myPayment.Status ?? "Processed");
                                cmd.Parameters.AddWithValue("@PaymentDate", myPayment.PaymentDate);
                                cmd.Parameters.AddWithValue("@ProcessedBy", processedBy);
                                cmd.Parameters.AddWithValue("@Notes", myPayment.Notes ?? string.Empty);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected == 0)
                                {
                                    transaction.Rollback();
                                    return (false, "Payment processing failed - no rows affected");
                                }
                            }

                            // 2. Update goods received notes status
                            string updateGrnSql = @"UPDATE goodsreceivednotes 
                                          SET Status = 'Paid', 
                                              
                                          WHERE POID = @POID";

                            using (MySqlCommand updateCmd = new MySqlCommand(updateGrnSql, connection, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@POID", myPayment.POID);
                                

                                int grnRowsAffected = updateCmd.ExecuteNonQuery();

                                if (grnRowsAffected == 0)
                                {
                                    transaction.Rollback();
                                    return (false, "Payment processed but failed to update Goods Received Notes status");
                                }
                            }

                            transaction.Commit();
                            return (true, $"Payment processed successfully and GRN status updated");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return (false, $"Error processing payment: {ex.Message}");
                        }
                    }
                }
            }
            catch (MySqlException dbEx)
            {
                return (false, $"Database error: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error processing payment: {ex.Message}");
            }
        }
    }
    
}
