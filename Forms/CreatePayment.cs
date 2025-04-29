using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

namespace Inventory_Management_System.Forms
{
    public partial class CreatePayment : Form
    {
        CreatePaymentModel createPayment = new CreatePaymentModel();
        CreatePaymentService createPaymentService = new CreatePaymentService();

        public CreatePayment()
        {
            InitializeComponent();
        }

        private void btnPmntProcess_Click(object sender, EventArgs e)
        {
            if (!ValidatePMNTinputs()) return;

            try
            {
                createPayment.POID = Convert.ToInt32(txtPOID.Text);
                createPayment.PaymentReference = txtpmntReference.Text.ToString();                   
                createPayment.Amount = Convert.ToDecimal(txtxpmntAmount.Text);
                createPayment.PaymentMethod = txtpmntMethod.Text.ToString();
                createPayment.Status = txtpmntStatus.Text.ToString();
                createPayment.Notes = txtpmntNotes.Text.ToString();
                createPayment.ProcessedBy = Session.Username;

                createPaymentService.PaymentProcess(createPayment);
                MessageBox.Show("Payment processed Successfully!");
                btnPmntReset.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}");
            }
        }


        private void btnPmntReset_Click(object sender, EventArgs e)
        {
         
            txtpmntNotes.Clear();
            txtpmntSupplierID.Clear();
            txtpmntReference.Clear();
            txtpmntStatus.Clear();
            txtxpmntAmount.Clear();
            txtpmntMethod.Clear();
            dtpAPOOrderDate.Value = DateTime.Now;
            txtPOID.Clear();

            txtpmntSupplierID.Enabled = false;
            txtxpmntAmount.Enabled = false;
            txtPOID.Enabled = false;
 

            // Load data and handle access
            var paymentProcess = createPaymentService.GetApprovedGRNsWithPOID();

            dgvpmntList.DataSource = paymentProcess.Tables[0];
        }

        private bool ValidatePMNTinputs()
        {
           
            if (String.IsNullOrWhiteSpace(txtpmntMethod.Text))
            {
                MessageBox.Show("Payment method is required", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpmntMethod.Focus();
                return false;
            }
            //if (String.IsNullOrWhiteSpace(txtpmntReference.Text))
            //{
            //    MessageBox.Show("Eneter a Reference text.");
            //    txtpmntReference.Focus();
            //    return false;
            //}

            // Clean and standardize the input
            var cleanedInput = txtpmntMethod.Text.Trim();
            var allowedPaymentMethods = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "Cash", "Cash" },
                    { "Cheque", "Cheque" },
                    { "Check", "Cheque" }, // Alternative spelling
                    { "Bank Transfer", "Bank Transfer" },
                    { "Transfer", "Bank Transfer" },
                    { "Bank", "Bank Transfer" }
                };

            if (allowedPaymentMethods.TryGetValue(cleanedInput, out string standardizedMethod))
            {
                // Update the textbox with standardized value if needed
                txtpmntMethod.Text = standardizedMethod;
            }
            else
            {
                MessageBox.Show("Please type a valid payment method:\n\n" +
                               "- Cash\n- Cheque\n- Bank Transfer",
                               "Invalid Payment Method",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtpmntMethod.Focus();
                return false;
            }
            if (!int.TryParse(txtpmntSupplierID.Text, out _))
            {
                MessageBox.Show("Invalid Supplier ID");
                txtpmntSupplierID.Focus();
                return false;
            }
            if (dtpAPOOrderDate.Value > DateTime.Now)
            {
                MessageBox.Show("Order date cannot be in the future");
                dtpAPOOrderDate.Focus();
                return false;
            }
            if (!decimal.TryParse(txtxpmntAmount.Text, out _))
            {
                MessageBox.Show("Invalid Total Amount");
                txtxpmntAmount.Focus();
                return false;
            }
            return true;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }

        private void ApprovePOForm_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnPmntReset.PerformClick();
        }

        private void dgvpmntList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                // Scroll to and select the row
                dgvpmntList.CurrentCell = dgvpmntList.Rows[e.RowIndex].Cells[0];

                DataRowView row = (DataRowView)dgvpmntList.Rows[e.RowIndex].DataBoundItem;
                createPayment.GRNID = row["GRNID"] != DBNull.Value ? Convert.ToInt32(row["GRNID"]) : 0;
                createPayment.POID = row["POID"] != DBNull.Value ? Convert.ToInt32(row["POID"]) : 0;
                createPayment.ItemID = row["ItemID"] != DBNull.Value ? Convert.ToInt32(row["ItemID"]) : 0;
                createPayment.ItemName = row["ItemName"] != DBNull.Value ? row["ItemName"].ToString() : string.Empty;
                createPayment.SupplierID = row["SupplierID"] != DBNull.Value ? Convert.ToInt32(row["SupplierID"]) : 0;
                createPayment.SupplierName = row["SupplierName"] != DBNull.Value ? row["SupplierName"].ToString() : string.Empty;
                createPayment.UnitPrice = row["UnitPrice"] != DBNull.Value ? Convert.ToDecimal(row["UnitPrice"]) : 0;
                createPayment.NumberOfUnits = row["NumberOfUnits"] != DBNull.Value ? Convert.ToInt32(row["NumberOfUnits"]) : 0;
                createPayment.TotalCost = row["TotalCost"] != DBNull.Value ? Convert.ToDecimal(row["TotalCost"]) : 0;
                //currentGRN.CreatedBy = row["CreatedBy"] != DBNull.Value ? row["CreatedBy"].ToString() : string.Empty;
                createPayment.DateOfDelivery = row["DateOfDelivery"] != DBNull.Value ? Convert.ToDateTime(row["DateOfDelivery"]) : DateTime.Now;
                createPayment.CreatedAt = row["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(row["CreatedAt"]) : DateTime.Now;
                createPayment.Status = row["Status"] != DBNull.Value ? row["Status"].ToString() : string.Empty;
                createPayment.Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : string.Empty;

                // Populate form fields
                txtPOID.Text = createPayment.POID.ToString();
                txtpmntStatus.Text = createPayment.Status.ToString();
                txtpmntSupplierID.Text = createPayment.SupplierID.ToString();
                txtxpmntAmount.Text = createPayment.TotalCost.ToString("0.00");
                dtpAPOOrderDate.Value = createPayment.DateOfDelivery;
                txtpmntNotes.Text = createPayment.Notes;


                // Update button states
                btnPmntProcess.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment details: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

    }
    
}
