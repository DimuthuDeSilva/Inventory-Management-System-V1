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
using Org.BouncyCastle.Asn1.Cmp;

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
                //currentGRN.PONumber = txtGRNPONumber.Text;
                currentGRN.SupplierID = Convert.ToInt32(txtGRNSupplierID.Text);
                currentGRN.ItemID = Convert.ToInt32(txtItemID.Text);
                currentGRN.POID = Convert.ToInt32(txtPOID.Text);
                currentGRN.SupplierName = txtGRNSupplierName.Text;
                currentGRN.ItemName = txtItemName.Text;
                currentGRN.Notes = txtCPONotes.Text;
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
            // Validate PO ID (required)
            if (!int.TryParse(txtPOID.Text, out _))
            {
                MessageBox.Show("PO ID is required");
                txtPOID.Focus();
                return false;
            }

            // Validate Item ID (required)
            if (!int.TryParse(txtItemID.Text, out _))
            {
                MessageBox.Show("Item ID is required");
                txtItemID.Focus();
                return false;
            }

            // Validate Item Name (required)
            if (String.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Item Name is required");
                txtItemName.Focus();
                return false;
            }

            // Validate Supplier ID (must be integer)
            if (!int.TryParse(txtGRNSupplierID.Text, out _))
            {
                MessageBox.Show("Invalid Supplier ID - must be a number");
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

            // Validate Created By (required)
            //if (String.IsNullOrWhiteSpace(txtGRNCreatedBy.Text))
            //{
            //    MessageBox.Show("Created By field is required");
            //    txtGRNCreatedBy.Focus();
            //    return false;
            //}

            // Validate Date of Delivery (must be today or in the past)
            if (dtpDateOfDelivery.Value > DateTime.Now)
            {
                MessageBox.Show("Delivery date cannot be in the future");
                dtpDateOfDelivery.Focus();
                return false;
            }

            // Validate Created At date (must be today or in the past)
            //if (dtpCreatedAt.Value > DateTime.Now)
            //{
            //    MessageBox.Show("Created At date cannot be in the future");
            //    dtpCreatedAt.Focus();
            //    return false;
            //}

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

            // Validate calculated total matches unit price * quantity
            decimal calculatedTotal = unitPrice * numberOfUnits;
            if (Math.Abs(calculatedTotal - totalCost) > 0.01m) // Allow for minor rounding differences
            {
                MessageBox.Show($"Total Cost doesn't match calculated value (Unit Price × Quantity = {calculatedTotal.ToString("N2")})");
                txtGRNTotalCost.Focus();
                return false;
            }

            // Validate Status (required)
            //if (String.IsNullOrWhiteSpace(cboGRNStatus.Text))
            //{
            //    MessageBox.Show("Status is required");
            //    cboGRNStatus.Focus();
            //    return false;
            //}

            return true;
        }

        private void btnGRNUpdate_Click_1(object sender, EventArgs e)
        {
            if (!ValidateGRNInputs()) return;

            try
            {

                currentGRN.SupplierID = Convert.ToInt32(txtGRNSupplierID.Text);
                currentGRN.ItemID = Convert.ToInt32(txtItemID.Text);
                currentGRN.POID = Convert.ToInt32(txtGRNID.Text);
                currentGRN.GRNID = Convert.ToInt32(txtGRNID.Text);
                currentGRN.SupplierName = txtGRNSupplierName.Text;
                currentGRN.ItemName = txtItemName.Text;
                currentGRN.Notes = txtCPONotes.Text;
                currentGRN.DateOfDelivery = dtpDateOfDelivery.Value;
                currentGRN.UnitPrice = Convert.ToDecimal(txtGRNUnitPrice.Text);
                currentGRN.NumberOfUnits = Convert.ToInt32(txtGRNNumberOfUnits.Text);
                currentGRN.TotalCost = Convert.ToDecimal(txtGRNTotalCost.Text);

                grnService.UpdateGRN(currentGRN);
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
            txtPOID.Clear();                 
            txtGRNSupplierID.Clear();              
            txtGRNSupplierName.Clear();             
            txtGRNUnitPrice.Clear();               
            txtGRNNumberOfUnits.Clear();            
            txtGRNTotalCost.Clear();               
            txtItemID.Clear();               
            txtItemName.Clear();               
            txtCPONotes.Clear();               
            txtGRNID.Clear();               
            dtpDateOfDelivery.Value = DateTime.Now;

  
            txtGRNTotalCost.Enabled = false;

            btnGRNAdd.Enabled = true;

            dgvGRNList.DataSource = grnService.GetAllGRN().Tables[0];
        }

        private void dgvGRNList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Scroll to and select the row
            dgvGRNList.CurrentCell = dgvGRNList.Rows[e.RowIndex].Cells[0];

            DataRowView row = (DataRowView)dgvGRNList.Rows[e.RowIndex].DataBoundItem;

            // Load data into GRN model
            currentGRN.GRNID = row["GRNID"] != DBNull.Value ? Convert.ToInt32(row["GRNID"]) : 0;
            currentGRN.POID = row["POID"] != DBNull.Value ? Convert.ToInt32(row["POID"]) : 0;
            currentGRN.ItemID = row["ItemID"] != DBNull.Value ? Convert.ToInt32(row["ItemID"]) : 0;
            currentGRN.ItemName = row["ItemName"] != DBNull.Value ? row["ItemName"].ToString() : string.Empty;
            currentGRN.SupplierID = row["SupplierID"] != DBNull.Value ? Convert.ToInt32(row["SupplierID"]) : 0;
            currentGRN.SupplierName = row["SupplierName"] != DBNull.Value ? row["SupplierName"].ToString() : string.Empty;
            currentGRN.UnitPrice = row["UnitPrice"] != DBNull.Value ? Convert.ToDecimal(row["UnitPrice"]) : 0;
            currentGRN.NumberOfUnits = row["NumberOfUnits"] != DBNull.Value ? Convert.ToInt32(row["NumberOfUnits"]) : 0;
            currentGRN.TotalCost = row["TotalCost"] != DBNull.Value ? Convert.ToDecimal(row["TotalCost"]) : 0;
            currentGRN.CreatedBy = row["CreatedBy"] != DBNull.Value ? row["CreatedBy"].ToString() : string.Empty;
            currentGRN.DateOfDelivery = row["DateOfDelivery"] != DBNull.Value ? Convert.ToDateTime(row["DateOfDelivery"]) : DateTime.Now;
            currentGRN.CreatedAt = row["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(row["CreatedAt"]) : DateTime.Now;
            currentGRN.Status = row["Status"] != DBNull.Value ? row["Status"].ToString() : string.Empty;
            currentGRN.Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : string.Empty;

            // Populate form fields
            txtGRNID.Text = currentGRN.GRNID.ToString();
            txtPOID.Text = currentGRN.POID.ToString();
            txtItemID.Text = currentGRN.ItemID.ToString();
            txtItemName.Text = currentGRN.ItemName;
            txtGRNSupplierID.Text = currentGRN.SupplierID.ToString();
            txtGRNSupplierName.Text = currentGRN.SupplierName;
            txtGRNUnitPrice.Text = currentGRN.UnitPrice.ToString("0.00");
            txtGRNNumberOfUnits.Text = currentGRN.NumberOfUnits.ToString();
            txtGRNTotalCost.Text = currentGRN.TotalCost.ToString("0.00");
            dtpDateOfDelivery.Value = currentGRN.DateOfDelivery;
            txtCPONotes.Text = currentGRN.Notes;

            // Update button states
            btnGRNAdd.Enabled = false;
            btnGRNUpdate.Enabled = true;
            btnGRNReset.Enabled = true;
        }

        private void btnGRNHome_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }

        //private void txtPOID_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (!int.TryParse(txtPOID.Text, out int grnPOID))
        //    {
        //        MessageBox.Show("Invalid PO ID - must be a number");
        //        txtPOID.SelectAll();
        //        return;
        //    }

        //    try
        //    {
        //        DataSet poDetails = grnService.GetPOdetails(grnPOID);

        //        if (poDetails.Tables[0].Rows.Count == 0)
        //        {
        //            MessageBox.Show("No purchase order found with this ID");
        //            return;
        //        }

        //        DataRow row = poDetails.Tables[0].Rows[0];

        //        // Populate the fields
        //        txtItemID.Text = row["ItemID"].ToString();
        //        txtItemName.Text = row["ItemName"].ToString();
        //        txtGRNSupplierID.Text = row["SupplierID"].ToString();
        //        txtGRNSupplierName.Text = row["SupplierName"].ToString();

        //        // Optional: Focus next field for better UX
        //        txtGRNUnitPrice.Focus();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error retrieving PO details: {ex.Message}");
        //    }
        //}

        private void txtPOID_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPOID.Text, out int grnPOID))
            {
                MessageBox.Show("Invalid PO ID - must be a number");
                txtPOID.SelectAll();
                return;
            }

            try
            {
                DataSet poDetails = grnService.GetPOdetails(grnPOID);

                if (poDetails.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No purchase order found with this ID");
                    return;
                }

                DataRow row = poDetails.Tables[0].Rows[0];

                // Populate the fields
                txtItemID.Text = row["ItemID"].ToString();
                txtItemName.Text = row["ItemName"].ToString();
                txtGRNSupplierID.Text = row["SupplierID"].ToString();
                txtGRNSupplierName.Text = row["SupplierName"].ToString();

                // Optional: Focus next field for better UX
                txtGRNUnitPrice.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving PO details: {ex.Message}");
            }
        }

        private void CreateGRN_Load_1(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnGRNReset.PerformClick();
        }
    }
    
}
