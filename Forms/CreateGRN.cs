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
    public partial class CreateGRN : Form
    {
        CreateGRNmodel currentGRN = new CreateGRNmodel();
        CreateGRNService grnService = new CreateGRNService();

        public CreateGRN()
        {
            InitializeComponent();

            txtGRNUnitPrice.TextChanged += CalculateTotalCost;
            txtGRNNumberOfUnits.TextChanged += CalculateTotalCost;
        }

        private void CalculateTotalCost(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtGRNUnitPrice.Text, out decimal unitPrice) &&
                int.TryParse(txtGRNNumberOfUnits.Text, out int numberOfUnits))
            {
                decimal totalCost = unitPrice * numberOfUnits;
                txtGRNTotalCost.Text = totalCost.ToString();
            }
            else
            {
                txtGRNTotalCost.Text = "0";
            }
        }
        private void btnGRNAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateGRNInputs()) return;

            try
            {
                currentGRN.PONumber = txtGRNPONumber.Text;
                currentGRN.SupplierID = Convert.ToInt32(txtGRNSupplierID.Text);
                currentGRN.SupplierName = txtGRNSupplierName.Text;
                currentGRN.DateOfDelivery = dtpDateOfDelivery.Value;
                currentGRN.UnitPrice = Convert.ToDecimal(txtGRNUnitPrice.Text);
                currentGRN.NumberOfUnits = Convert.ToInt32(txtGRNNumberOfUnits.Text);
                currentGRN.TotalCost = Convert.ToDecimal(txtGRNTotalCost.Text);

                grnService.CreateGRN(currentGRN);
                MessageBox.Show("Goods Received Note Created Successfully!");
                btnGRNReset.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating GRN: {ex.Message}");
            }
        }

        private bool ValidateGRNInputs()
        {
            // Validate PO Number (required)
            if (String.IsNullOrWhiteSpace(txtGRNPONumber.Text))
            {
                MessageBox.Show("PO Number is required");
                txtGRNPONumber.Focus();
                return false;
            }

            // Validate Supplier ID (must be integer)
            if (!int.TryParse(txtGRNSupplierID.Text, out _))
            {
                MessageBox.Show("Invalid Supplier ID");
                txtGRNSupplierID.Focus();
                return false;
            }

            // Validate Supplier Name (required)
            if (String.IsNullOrWhiteSpace(txtGRNSupplierName.Text))
            {
                MessageBox.Show("Supplier Name is required");
                txtGRNSupplierName.Focus();
                return false;
            }

            // Validate Date of Delivery (must be today or in the past)
            if (dtpDateOfDelivery.Value > DateTime.Now)
            {
                MessageBox.Show("Delivery date cannot be in the future");
                dtpDateOfDelivery.Focus();
                return false;
            }

            // Validate Unit Price (must be decimal and positive)
            if (!decimal.TryParse(txtGRNUnitPrice.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Invalid Unit Price - must be a positive number");
                txtGRNUnitPrice.Focus();
                return false;
            }

            // Validate Number of Units (must be integer and positive)
            if (!int.TryParse(txtGRNNumberOfUnits.Text, out int numberOfUnits) || numberOfUnits <= 0)
            {
                MessageBox.Show("Invalid Number Of Units - must be a positive whole number");
                txtGRNNumberOfUnits.Focus();
                return false;
            }

            // Validate Total Cost (must be decimal and positive)
            if (!decimal.TryParse(txtGRNTotalCost.Text, out decimal totalCost) || totalCost <= 0)
            {
                MessageBox.Show("Invalid Total Cost - must be a positive number");
                txtGRNTotalCost.Focus();
                return false;
            }

            // Optional: Validate calculated total matches unit price * quantity
            decimal calculatedTotal = unitPrice * numberOfUnits;
            if (Math.Abs(calculatedTotal - totalCost) > 0.01m) // Allow for minor rounding differences
            {
                MessageBox.Show($"Total Cost doesn't match calculated value (Unit Price × Quantity = {calculatedTotal})");
                txtGRNTotalCost.Focus();
                return false;
            }

            return true;
        }

        private void btnGRNUpdate_Click_1(object sender, EventArgs e)
        {
            if (!ValidateGRNInputs()) return;

            try
            {
                currentGRN.PONumber = txtGRNPONumber.Text;
                currentGRN.SupplierID = Convert.ToInt32(txtGRNSupplierID.Text);
                currentGRN.SupplierName = txtGRNSupplierName.Text;
                currentGRN.DateOfDelivery = dtpDateOfDelivery.Value;
                currentGRN.UnitPrice = Convert.ToDecimal(txtGRNUnitPrice.Text);
                currentGRN.NumberOfUnits = Convert.ToInt32(txtGRNNumberOfUnits.Text);
                currentGRN.TotalCost = Convert.ToDecimal(txtGRNTotalCost.Text);

                grnService.CreateGRN(currentGRN);
                MessageBox.Show("Goods Received Note Updated Successfully!");
                btnGRNReset.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Updating GRN: {ex.Message}");
            }
        }

        private void btnGRNReset_Click(object sender, EventArgs e)
        {
            txtGRNPONumber.Clear();                 
            txtGRNSupplierID.Clear();              
            txtGRNSupplierName.Clear();             
            txtGRNUnitPrice.Clear();               
            txtGRNNumberOfUnits.Clear();            
            txtGRNTotalCost.Clear();               
            dtpDateOfDelivery.Value = DateTime.Now;

            btnGRNAdd.Enabled = true;

            dgvGRNList.DataSource = grnService.GetAllGRN().Tables[0];
        }

        private void dgvGRNList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Scroll to and select the row - ADD AT BEGINNING
            dgvGRNList.CurrentCell = dgvGRNList.Rows[e.RowIndex].Cells[0];

            DataRowView row = (DataRowView)dgvGRNList.Rows[e.RowIndex].DataBoundItem;

            // Load data into GRN model
            currentGRN.GRNID = row["GRNID"] != DBNull.Value ? Convert.ToInt32(row["GRNID"]) : 0;
            currentGRN.PONumber = row["PONumber"] != DBNull.Value ? row["PONumber"].ToString() : string.Empty;
            currentGRN.SupplierID = row["SupplierID"] != DBNull.Value ? Convert.ToInt32(row["SupplierID"]) : 0;
            currentGRN.SupplierName = row["SupplierName"] != DBNull.Value ? row["SupplierName"].ToString() : string.Empty;
            currentGRN.DateOfDelivery = row["DateOfDelivery"] != DBNull.Value ? Convert.ToDateTime(row["DateOfDelivery"]) : DateTime.Now;
            currentGRN.UnitPrice = row["UnitPrice"] != DBNull.Value ? Convert.ToDecimal(row["UnitPrice"]) : 0;
            currentGRN.NumberOfUnits = row["NumberOfUnits"] != DBNull.Value ? Convert.ToInt32(row["NumberOfUnits"]) : 0;
            currentGRN.TotalCost = row["TotalCost"] != DBNull.Value ? Convert.ToDecimal(row["TotalCost"]) : 0;

            // Populate form fields
            txtGRNID.Text = currentGRN.GRNID.ToString();
            txtGRNPONumber.Text = currentGRN.PONumber;
            txtGRNSupplierID.Text = currentGRN.SupplierID.ToString();
            txtGRNSupplierName.Text = currentGRN.SupplierName;
            dtpDateOfDelivery.Value = currentGRN.DateOfDelivery;
            txtGRNUnitPrice.Text = currentGRN.UnitPrice.ToString("0.00");
            txtGRNNumberOfUnits.Text = currentGRN.NumberOfUnits.ToString();
            txtGRNTotalCost.Text = currentGRN.TotalCost.ToString("0.00");

            // Update button states
            btnGRNAdd.Enabled = false;
            btnGRNUpdate.Enabled = true;
            btnGRNReset.Enabled = true;
        }

        private void btnGRNHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void CreateGRN_Load(object sender, EventArgs e)
        {
            btnGRNReset.PerformClick();
        }

        private void lblLoggedUser_Click(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnGRNReset.PerformClick();
        }
    }
}
