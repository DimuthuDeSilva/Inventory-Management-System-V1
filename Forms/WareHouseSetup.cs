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
    public partial class WareHouseSetup : Form
    {
        WareHouse myWarehouse = new WareHouse();
        WareHouseService warehouseService = new WareHouseService();
        public WareHouseSetup()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            if (String.IsNullOrWhiteSpace(txtWarehouseName.Text))
            {
                MessageBox.Show("Please enter a valid warehouse name");
                txtWarehouseName.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtWarehouseLocation.Text))
            {
                MessageBox.Show("Please enter a valid location");
                txtWarehouseLocation.Focus();
                return false;
            }

            if (!int.TryParse(txtWarehouseCapacity.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Please enter a valid capacity (positive whole number)");
                txtWarehouseCapacity.Focus();
                return false;
            }

            if (!int.TryParse(txtWarehouseManagerID.Text, out int managerId) || managerId <= 0)
            {
                MessageBox.Show("Please enter a valid manager ID (positive whole number)");
                txtWarehouseManagerID.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtContactPhone.Text) || txtContactPhone.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid phone number (at least 10 digits)");
                txtContactPhone.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtWareHouseStatus.Text))
            {
                MessageBox.Show("Status is required (1/0, true/false, active/inactive)",
                               "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWareHouseStatus.Focus();
                return false;
            }

            return true;
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

        private void btnWHAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                myWarehouse.Name = txtWarehouseName.Text;
                myWarehouse.Location = txtWarehouseLocation.Text;
                myWarehouse.Capacity = Convert.ToInt32(txtWarehouseCapacity.Text);
                myWarehouse.ManagerID = Convert.ToInt32(txtWarehouseManagerID.Text);
                myWarehouse.ContactPhone = txtContactPhone.Text;
                myWarehouse.IsActive = ParseStatusInput(txtWareHouseStatus.Text);

                warehouseService.CreateWareHouse(myWarehouse);
                MessageBox.Show("Warehouse added successfully");
                btnWHClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving warehouse: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWarehouseName.Clear();
            txtWarehouseLocation.Clear();
            txtContactPhone.Clear();
            txtWarehouseCapacity.Clear();
            txtWarehouseManagerID.Clear();
            txtWareHouseStatus.Clear();

            // Reset button states
            btnWHAdd.Enabled = true;
            btnWHUpdate.Enabled = false;
            //btnDelete.Enabled = false;

            // Refresh the DataGridView
            dgvWarehouseList.DataSource = warehouseService.GetAllItems().Tables[0];
        }

        private void btnWHUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                myWarehouse.Name = txtWarehouseName.Text;
                myWarehouse.Location = txtWarehouseLocation.Text;
                myWarehouse.Capacity = Convert.ToInt32(txtWarehouseCapacity.Text);
                myWarehouse.ManagerID = Convert.ToInt32(txtWarehouseManagerID.Text);
                myWarehouse.ContactPhone = txtContactPhone.Text;
                myWarehouse.IsActive = ParseStatusInput(txtWareHouseStatus.Text);

                warehouseService.UpdateWareHouse(myWarehouse);
                MessageBox.Show("Warehouse updated successfully");
                btnWHClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating warehouse: {ex.Message}");
            }
        }

        private void dgvWareHouseList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ensure a valid row is clicked (not header)

            DataRowView row = (DataRowView)dgvWarehouseList.Rows[e.RowIndex].DataBoundItem;

            // Assign values to the Warehouse object
            myWarehouse.Name = row["Name"].ToString();
            myWarehouse.Location = row["Location"].ToString();
            myWarehouse.Capacity = Convert.ToInt32(row["Capacity"]);
            myWarehouse.ManagerID = Convert.ToInt32(row["ManagerID"]);
            myWarehouse.ContactPhone = row["ContactPhone"].ToString();
            myWarehouse.IsActive = Convert.ToBoolean(row["IsActive"]);
            myWarehouse.WarehouseID = Convert.ToInt32(row["WarehouseID"]);

            // Update the textboxes
            txtWarehouseID.Text = myWarehouse.WarehouseID.ToString();
            txtWarehouseName.Text = myWarehouse.Name;
            txtWarehouseLocation.Text = myWarehouse.Location;
            txtContactPhone.Text = myWarehouse.ContactPhone.ToString();
            txtWarehouseCapacity.Text = myWarehouse.Capacity.ToString();
            txtWarehouseManagerID.Text = myWarehouse.ManagerID.ToString();
            txtWareHouseStatus.Text = myWarehouse.IsActive.ToString();
            


                // Remove the row from the grid (if still needed)
                //dgvWarehouseList.Rows.RemoveAt(e.RowIndex);

                // Update button states
                btnWHAdd.Enabled = false;
                btnWHUpdate.Enabled = true;
                //btnDelete.Enabled = true;
            
        }

        private void btnWHDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm For Delete The selected Warehouse", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                warehouseService.DeleteWarehouse(myWarehouse);
                MessageBox.Show("Warehouse Deleted");
                btnWHClear.PerformClick();
            }
        }

        private void WareHouseSetup_Load(object sender, EventArgs e)
        {
            btnWHClear.PerformClick();
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnWHClear.PerformClick();
        }
    }
}
