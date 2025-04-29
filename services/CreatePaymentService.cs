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

                    string sql = @"SELECT 
                            GRNID, 
                            POID, 
                            ItemID, 
                            ItemName, 
                            SupplierID, 
                            SupplierName, 
                            UnitPrice, 
                            NumberOfUnits, 
                            TotalCost, 
                            CreatedBy, 
                            DateOfDelivery, 
                            CreatedAt, 
                            Status, 
                            ConfirmedBy, 
                            Notes
                          FROM goodsreceivednotes
                          WHERE Status IN ('Approved', 'Completed')
                          ORDER BY DateOfDelivery DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving approved GRNs: {ex.Message}",
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
                                       (PaymentID, PaymentReference, POID, Amount, 
                                        PaymentMethod, Status, PaymentDate, 
                                        ProcessedBy, Notes)
                                       VALUES 
                                       (@PaymentID, @PaymentReference, @POID, @Amount, 
                                        @PaymentMethod, @Status, @PaymentDate, 
                                        @ProcessedBy, @Notes)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, connection, transaction))
                            {
                                //cmd.Parameters.AddWithValue("@PaymentID", myPayment.PaymentID);
                                cmd.Parameters.AddWithValue("@PaymentID", myPayment.PaymentID);
                                cmd.Parameters.AddWithValue("@PaymentReference", myPayment.PaymentReference);
                                cmd.Parameters.AddWithValue("@POID", myPayment.POID);
                                cmd.Parameters.AddWithValue("@Amount", myPayment.Amount);
                                cmd.Parameters.AddWithValue("@PaymentMethod", myPayment.PaymentMethod);
                                cmd.Parameters.AddWithValue("@Status", myPayment.Status);
                                cmd.Parameters.AddWithValue("@PaymentDate", myPayment.PaymentDate);
                                cmd.Parameters.AddWithValue("@ProcessedBy", myPayment.ProcessedBy);
                                cmd.Parameters.AddWithValue("@Notes", myPayment.Notes ?? (object)DBNull.Value);

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
                                                       ConfirmedBy = @ConfirmedBy,
                                                   WHERE GRNID = @GRNID
                                                   AND Status = 'Approved'";  // Only update if currently confirmed

                            using (MySqlCommand cmd = new MySqlCommand(updateGrnSql, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@GRNID", myPayment.GRNID);
                                cmd.Parameters.AddWithValue("@ConfirmedBy", Session.Username);


                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected == 0)
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
