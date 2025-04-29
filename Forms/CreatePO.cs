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
    public partial class CreatePO : Form
    {
        CreatePOModel currentPO = new CreatePOModel();
        CreatePOService poService = new CreatePOService();

        public CreatePO()
        {
            InitializeComponent();
            txtCPOUnitPrice.TextChanged += CalculateTotalAmount;
            txtCPONumberOfUnits.TextChanged += CalculateTotalAmount;
        }

        private void CalculateTotalAmount(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCPOUnitPrice.Text, out decimal unitPrice) &&
                int.TryParse(txtCPONumberOfUnits.Text, out int numberOfUnits))
            {
                decimal totalAmount = unitPrice * numberOfUnits;
                txtCPOTotalAmount.Text = totalAmount.ToString();
            }
            else
            {
                txtCPOTotalAmount.Text = "0";
            }
        }
        private void btnCPOAdd_Click(object sender, EventArgs e)
        {
            if (!ValidatePOInputs()) return;

            try
            {
                currentPO.ItemID = Convert.ToInt32(txtItemID.Text);
                currentPO.SupplierID = Convert.ToInt32(txtCPOSupplierID.Text);
                currentPO.OrderDate = dtpCPOOrderDate.Value;
                currentPO.ExpectedDeliveryDate = dtpCPOExDD.Value;
                currentPO.UnitPrice = Convert.ToDecimal(txtCPOUnitPrice.Text);
                currentPO.NumberOfUnits = Convert.ToInt32(txtCPONumberOfUnits.Text);
                currentPO.TotalAmount = Convert.ToDecimal(txtCPOTotalAmount.Text);
                currentPO.CreatedBy = Convert.ToInt32(Session.UserID);
                currentPO.Notes = txtCPONotes.Text;
                currentPO.ItemName = txtItemName.Text;
                currentPO.SupplierName = txtSupplierName.Text;
                
                poService.CreatePurchaseOrder(currentPO);
                MessageBox.Show("Purchase Order Created Successfully!");
                btnCPOClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating PO: {ex.Message}");
            }
        }

        private bool ValidatePOInputs()
        {
            // Validate Item ID
            if (String.IsNullOrWhiteSpace(txtItemID.Text))
            {
                MessageBox.Show("Item ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemID.Focus();
                return false;
            }
            if (!int.TryParse(txtItemID.Text, out int itemId) || itemId <= 0)
            {
                MessageBox.Show("Invalid Item ID (must be positive number)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemID.Focus();
                return false;
            }

            // Validate Item Name
            if (String.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Item Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemName.Focus();
                return false;
            }

            // Validate Supplier ID
            if (String.IsNullOrWhiteSpace(txtCPOSupplierID.Text))
            {
                MessageBox.Show("Supplier ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPOSupplierID.Focus();
                return false;
            }
            if (!int.TryParse(txtCPOSupplierID.Text, out int supplierId) || supplierId <= 0)
            {
                MessageBox.Show("Invalid Supplier ID (must be a number)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPOSupplierID.Focus();
                return false;
            }

            // Validate Supplier Name
            if (String.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Supplier Name is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplierName.Focus();
                return false;
            }

            // Validate Dates
            if (dtpCPOOrderDate.Value > DateTime.Now)
            {
                MessageBox.Show("Order date cannot be in the future", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpCPOOrderDate.Focus();
                return false;
            }
            if (dtpCPOExDD.Value < dtpCPOOrderDate.Value)
            {
                MessageBox.Show("Delivery date cannot be before order date", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpCPOExDD.Focus();
                return false;
            }

            // Validate Unit Price
            if (String.IsNullOrWhiteSpace(txtCPOUnitPrice.Text))
            {
                MessageBox.Show("Unit Price is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPOUnitPrice.Focus();
                return false;
            }
            if (!decimal.TryParse(txtCPOUnitPrice.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Invalid Unit Price (must be positive number)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPOUnitPrice.Focus();
                return false;
            }

            // Validate Number of Units
            if (String.IsNullOrWhiteSpace(txtCPONumberOfUnits.Text))
            {
                MessageBox.Show("Number of Units is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPONumberOfUnits.Focus();
                return false;
            }
            if (!int.TryParse(txtCPONumberOfUnits.Text, out int numberOfUnits) || numberOfUnits <= 0)
            {
                MessageBox.Show("Invalid Number of Units (must be positive integer)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPONumberOfUnits.Focus();
                return false;
            }

            // Validate Total Amount
            if (String.IsNullOrWhiteSpace(txtCPOTotalAmount.Text))
            {
                MessageBox.Show("Total Amount is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPOTotalAmount.Focus();
                return false;
            }
            if (!decimal.TryParse(txtCPOTotalAmount.Text, out decimal totalAmount) || totalAmount <= 0)
            {
                MessageBox.Show("Invalid Total Amount (must be positive number)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPOTotalAmount.Focus();
                return false;
            }

            // Validate Created By
            ////if (String.IsNullOrWhiteSpace(txtCPOCreatedBy.Text))
            ////{
            ////    MessageBox.Show("Created By is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    txtCPOCreatedBy.Focus();
            ////    return false;
            //}
            return true;
        }

        private void btnCPOUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidatePOInputs()) return;

            try
            {
                currentPO.ItemID = Convert.ToInt32(txtItemID.Text);
                currentPO.SupplierID = Convert.ToInt32(txtCPOSupplierID.Text);
                currentPO.OrderDate = dtpCPOOrderDate.Value;
                currentPO.ExpectedDeliveryDate = dtpCPOExDD.Value;
                currentPO.UnitPrice = Convert.ToDecimal(txtCPOUnitPrice.Text);
                currentPO.NumberOfUnits = Convert.ToInt32(txtCPONumberOfUnits.Text);
                currentPO.TotalAmount = Convert.ToDecimal(txtCPOTotalAmount.Text);
                currentPO.CreatedBy = Convert.ToInt32(Session.UserID);
                currentPO.Notes = txtCPONotes.Text;
                currentPO.ItemName = txtItemName.Text;
                currentPO.SupplierName = txtSupplierName.Text;

                bool success = poService.UpdatePurchaseOrder(currentPO);
                if (success)
                {
                    MessageBox.Show("Purchase Order Updated Successfully!");
                    btnCPOClear.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating PO: {ex.Message}");
            }
        }

        private void btnCPOClear_Click(object sender, EventArgs e)
        {
            txtItemID.Clear();
            txtItemName.Clear();  
            txtPOID.Clear();
            txtCPOUnitPrice.Clear();
            txtCPONotes.Clear();
            txtCPOSupplierID.Clear();
            txtSupplierName.Clear();  
            txtCPOTotalAmount.Clear();
            txtCPONumberOfUnits.Clear();

            // Reset date pickers
            dtpCPOOrderDate.Value = DateTime.Now;
            dtpCPOExDD.Value = DateTime.Now.AddDays(7);

            btnCPOAdd.Enabled = true;
            btnCPOUpdate.Enabled = false;

            dgvPOList.DataSource = poService.GetAllPurchaseOrders().Tables[0];
        }

        private void dgvPOList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvPOList.Rows[e.RowIndex].DataBoundItem;

            // Set currentPO properties from selected row
            currentPO.POID = Convert.ToInt32(row["POID"]);
            currentPO.ItemID = Convert.ToInt32(row["ItemID"]);
            currentPO.ItemName = row["ItemName"].ToString();
            currentPO.SupplierID = Convert.ToInt32(row["SupplierID"]);
            currentPO.SupplierName = row["SupplierName"].ToString();
            currentPO.OrderDate = Convert.ToDateTime(row["OrderDate"]);
            currentPO.ExpectedDeliveryDate = row["ExpectedDeliveryDate"] != DBNull.Value ?
                                          Convert.ToDateTime(row["ExpectedDeliveryDate"]) : (DateTime?)null;
            currentPO.UnitPrice = Convert.ToDecimal(row["UnitPrice"]);
            currentPO.NumberOfUnits = row["NumberOfUnits"] != DBNull.Value ?
                                    Convert.ToInt32(row["NumberOfUnits"]) : 0;
            currentPO.TotalAmount = Convert.ToDecimal(row["TotalAmount"]);
            currentPO.CreatedBy = Convert.ToInt32(row["CreatedBy"]);
            currentPO.Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : null;

            // Populate form fields
            txtPOID.Text = currentPO.POID.ToString();
            txtItemID.Text = currentPO.ItemID.ToString();  // Changed from PONumber to ItemID
            txtItemName.Text = currentPO.ItemName;  // Added ItemName field
            txtCPOSupplierID.Text = currentPO.SupplierID.ToString();
            txtSupplierName.Text = currentPO.SupplierName;  // Added SupplierName field
            txtCPOUnitPrice.Text = currentPO.UnitPrice.ToString("N2");  // Format as currency
            dtpCPOOrderDate.Value = currentPO.OrderDate;
            dtpCPOExDD.Value = currentPO.ExpectedDeliveryDate ?? DateTime.Now.AddDays(7);
            txtCPOTotalAmount.Text = currentPO.TotalAmount.ToString("N2");  // Format as currency
            txtCPONumberOfUnits.Text = currentPO.NumberOfUnits.ToString();
            txtCPONotes.Text = currentPO.Notes ?? string.Empty;

            // Removed txtCPOCreatedBy since we're using Session.Username
            btnCPOAdd.Enabled = false;
            btnCPOUpdate.Enabled = true;
        }

        private void btnCPODelete_Click(object sender, EventArgs e)
        {
            if (currentPO.POID == 0)
            {
                MessageBox.Show("No PO selected");
                return;
            }

            if (MessageBox.Show("Confirm deletion of this Purchase Order?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    poService.DeletePO(currentPO);
                    MessageBox.Show("Purchase Order deleted successfully");
                    btnCPOClear.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting PO: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }

        private void CreatePO_Load_1(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnCPOClear.PerformClick();
        }

    }
}
