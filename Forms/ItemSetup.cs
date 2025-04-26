using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

namespace Inventory_Management_System.Forms
{
    public partial class ItemSetup : Form
    {
        Items myItem = new Items();
        ItemService itemService = new ItemService();
        public ItemSetup()
        {
            InitializeComponent();
            txtUpdUnitPrice.TextChanged += CalculateTotalCost;
            txtUpdQuantity.TextChanged += CalculateTotalCost;
        }
        private void CalculateTotalCost(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUpdUnitPrice.Text, out decimal unitPrice) &&
                int.TryParse(txtUpdQuantity.Text, out int Quantity))
            {
                decimal totalCost = unitPrice * Quantity;
                txtUpdTotalCost.Text = totalCost.ToString();
            }
            else
            {
                txtUpdTotalCost.Text = "0";
            }
        }

        private bool ValidateInputs()
        {
            // Name validation (required, max length 100)
            if (string.IsNullOrWhiteSpace(txtUpdName.Text) || txtUpdName.Text.Length > 100)
            {
                MessageBox.Show("Name is required and must be 100 characters or less", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdName.Focus();
                return false;
            }

            // Description validation (max length 150)
            if (txtUpdDescription.Text.Length > 150)
            {
                MessageBox.Show("Description must be 150 characters or less", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdDescription.Focus();
                return false;
            }

            // Quantity validation (must be non-negative integer)
            if (!int.TryParse(txtUpdQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a non-negative whole number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdQuantity.Focus();
                return false;
            }

            // ReorderLevel validation (must be non-negative integer)
            if (!int.TryParse(txtUpdReorderLevel.Text, out int reorderLevel) || reorderLevel < 0)
            {
                MessageBox.Show("Reorder Level must be a non-negative whole number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdReorderLevel.Focus();
                return false;
            }

            // UnitPrice validation (must be positive decimal)
            if (!decimal.TryParse(txtUpdUnitPrice.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Unit Price must be a positive number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdUnitPrice.Focus();
                return false;
            }

            // TotalCost validation (must be positive decimal)
            if (!decimal.TryParse(txtUpdTotalCost.Text, out decimal totalCost) || totalCost <= 0)
            {
                MessageBox.Show("Total Cost must be a positive number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdTotalCost.Focus();
                return false;
            }

            // SupplierID validation (must be positive integer)
            if (!int.TryParse(txtUpdSupplierID.Text, out int supplierId) || supplierId <= 0)
            {
                MessageBox.Show("Supplier ID must be a valid positive number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdSupplierID.Focus();
                return false;
            }

            // WarehouseID validation (must be positive integer)
            if (!int.TryParse(txtUpdWarehouseID.Text, out int warehouseId) || warehouseId <= 0)
            {
                MessageBox.Show("Warehouse ID must be a valid positive number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdWarehouseID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUpdStatus.Text))
            {
                MessageBox.Show("Status is required (1/0, true/false, active/inactive)",
                               "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpdStatus.Focus();
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                myItem.Name = txtUpdName.Text;
                myItem.Description = txtUpdDescription.Text;
                myItem.Quantity = Convert.ToInt32(txtUpdQuantity.Text);
                myItem.ReorderLevel = Convert.ToInt32(txtUpdReorderLevel.Text);
                myItem.UnitPrice = Convert.ToDecimal(txtUpdUnitPrice.Text);
                myItem.TotalCost = Convert.ToDecimal(txtUpdTotalCost.Text);
                myItem.SupplierID = Convert.ToInt32(txtUpdSupplierID.Text);
                myItem.WarehouseID = Convert.ToInt32(txtUpdWarehouseID.Text);
                myItem.IsActive = ParseStatusInput(txtUpdStatus.Text);

                itemService.CreateItem(myItem);
                MessageBox.Show("New Item Added successfully");
                btnClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUpdName.Clear();
            txtUpdDescription.Clear();
            txtUpdQuantity.Clear();
            txtUpdReorderLevel.Clear();
            txtUpdUnitPrice.Clear();
            txtUpdTotalCost.Clear();
            txtUpdSupplierID.Clear();
            txtUpdWarehouseID.Clear();
            txtUpdStatus.Clear();
            txtUpdItemID.Clear();

            // Reset button states
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            //btnDelete.Enabled = false;

            if (Session.Role != null && Session.Role == "Manager")
            {
                btnAdd.Visible = false;
            }

            txtUpdItemID.Enabled = false;

            // Refresh the DataGridView
            dgvItemList.DataSource = itemService.GetAllItems().Tables[0];
        }
        private bool ParseStatusInput(string statusText)
        {
            if (string.IsNullOrWhiteSpace(statusText))
                return false; // Default to false if empty

            // Check for numeric values (1/0)
            if (int.TryParse(statusText, out int numericStatus))
                return numericStatus == 1;

            // Check for boolean strings
            if (bool.TryParse(statusText, out bool boolStatus))
                return boolStatus;

            // Check for active/inactive variations
            return statusText.Trim().Equals("active", StringComparison.OrdinalIgnoreCase) ||
                   statusText.Trim().Equals("yes", StringComparison.OrdinalIgnoreCase) ||
                   statusText.Trim().Equals("y", StringComparison.OrdinalIgnoreCase) ||
                   statusText.Trim() == "1";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                myItem.Name = txtUpdName.Text;
                myItem.Description = txtUpdDescription.Text;
                myItem.Quantity = Convert.ToInt32(txtUpdQuantity.Text);
                myItem.ReorderLevel = Convert.ToInt32(txtUpdReorderLevel.Text);
                myItem.UnitPrice = Convert.ToDecimal(txtUpdUnitPrice.Text);
                myItem.TotalCost = Convert.ToDecimal(txtUpdTotalCost.Text);
                myItem.SupplierID = Convert.ToInt32(txtUpdSupplierID.Text);
                myItem.WarehouseID = Convert.ToInt32(txtUpdWarehouseID.Text);
                myItem.IsActive = ParseStatusInput(txtUpdStatus.Text);

                itemService.UpdateItem(myItem);
                MessageBox.Show("Item Updated Successfully");
                btnClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating item: {ex.Message}");
            }
        }

        private void dgvItemList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ensure a valid row is clicked (not header)

            DataRowView row = (DataRowView)dgvItemList.Rows[e.RowIndex].DataBoundItem;

                myItem.ItemID = Convert.ToInt32(row["ItemID"]);
                myItem.Name = row["Name"].ToString();
                myItem.Description = row["Description"].ToString();
                myItem.Quantity = Convert.ToInt32(row["Quantity"]);
                myItem.ReorderLevel = Convert.ToInt32(row["ReorderLevel"]);
                myItem.UnitPrice = Convert.ToDecimal(row["UnitPrice"]);
                myItem.TotalCost = Convert.ToDecimal(row["TotalCost"]);
                myItem.SupplierID = Convert.ToInt32(row["SupplierID"]);
                myItem.WarehouseID = Convert.ToInt32(row["WarehouseID"]);
                myItem.IsActive = Convert.ToBoolean(row["IsActive"]);

                txtUpdItemID.Text = myItem.ItemID.ToString();
                txtUpdName.Text = myItem.Name;
                txtUpdDescription.Text = myItem.Description;
                txtUpdQuantity.Text = myItem.Quantity.ToString();
                txtUpdReorderLevel.Text = myItem.ReorderLevel.ToString();
                txtUpdUnitPrice.Text = myItem.UnitPrice.ToString("N2");
                txtUpdTotalCost.Text = myItem.TotalCost.ToString("N2");
                txtUpdSupplierID.Text = myItem.SupplierID.ToString();
                txtUpdWarehouseID.Text = myItem.WarehouseID.ToString();
                txtUpdStatus.Text = myItem.IsActive.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm For Delete The selected Item", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                itemService.DeleteItem(myItem);
                MessageBox.Show("Item Deleted");
                btnClear.PerformClick();
            }
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnClear.PerformClick();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }
    }
}
