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
        GRNtoCreatePaymentmodel confirmGRNmodel = new GRNtoCreatePaymentmodel();

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
         
            txtpmntNumber.Clear();
            txtpmntNotes.Clear();
            txtpmntSupplierID.Clear();
            txtpmntReference.Clear();
            txtpmntStatus.Clear();
            txtxpmntAmount.Clear();
            txtpmntMethod.Clear();
            dtpAPOOrderDate.Value = DateTime.Now;
            txtPOID.Clear();

            txtpmntNumber.Enabled = false;
            txtpmntSupplierID.Enabled = false;
            txtxpmntAmount.Enabled = false;
            txtPOID.Enabled = false;
 

            // Load data and handle access
            var paymentProcess = createPaymentService.GetApprovedGRNsWithPOID();

            dgvpmntList.DataSource = paymentProcess.Tables[0];
        }

        private bool ValidatePMNTinputs()
        {
            if (String.IsNullOrWhiteSpace(txtpmntNumber.Text))
            {
                MessageBox.Show("PO Number is required");
                txtpmntNumber.Focus();
                return false;
            }
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

            DataRowView row = (DataRowView)dgvpmntList.Rows[e.RowIndex].DataBoundItem;

            // Map data from row to createPayment object
            createPayment.POID = Convert.ToInt32(row["POID"]);
            confirmGRNmodel.PONumber = row["PONumber"].ToString();
            confirmGRNmodel.SupplierID = Convert.ToInt32(row["SupplierID"]);
            confirmGRNmodel.OrderDate = Convert.ToDateTime(row["DateOfDelivery"]);

            confirmGRNmodel.Status = row["Status"].ToString();
            confirmGRNmodel.UnitPrice = Convert.ToDecimal(row["UnitPrice"]);
            confirmGRNmodel.NumberOfUnits = Convert.ToInt32(row["NumberOfUnits"]);
            createPayment.Amount = Convert.ToDecimal(row["TotalCost"]);
            confirmGRNmodel.CreatedBy = Convert.ToInt32(row["CreatedBy"]);
            confirmGRNmodel.ConfirmedBy = row["ConfirmedBy"] != DBNull.Value ?
                                     Convert.ToInt32(row["ConfirmedBy"]) : (int?)null;
            confirmGRNmodel.Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : null;

            // Map to UI controls
            txtpmntNumber.Text = confirmGRNmodel.PONumber;
            txtpmntNotes.Text = confirmGRNmodel.Notes ?? string.Empty;
            txtpmntSupplierID.Text = confirmGRNmodel.SupplierID.ToString();
            txtpmntReference.Text = createPayment.PaymentReference; // Or payment reference if different
            txtpmntStatus.Text = confirmGRNmodel.Status;
            txtxpmntAmount.Text = createPayment.Amount.ToString("N2"); // Formatted with 2 decimal places
            txtpmntMethod.Text = string.Empty; // Clear payment method
            dtpAPOOrderDate.Value = confirmGRNmodel.OrderDate;

            // Populate form fields
            txtPOID.Text = createPayment.POID.ToString();
            txtpmntNumber.Text = confirmGRNmodel.PONumber;
            txtpmntSupplierID.Text = confirmGRNmodel.SupplierID.ToString();
            dtpAPOOrderDate.Value = confirmGRNmodel.OrderDate;
            txtxpmntAmount.Text = createPayment.Amount.ToString("N2");
            //txtpmntReference.Text = createPayment.PaymentReference.ToString();
            txtpmntStatus.Text = confirmGRNmodel.Status.ToString();
            txtpmntNotes.Text = confirmGRNmodel.Notes ?? "";
            //txtpmntPaymentMethod.Text = createPayment.PaymentMethod.ToString();

            //btnAPOAdd.Enabled = false;
            btnPmntProcess.Enabled = true;
        }

    }
    
}
