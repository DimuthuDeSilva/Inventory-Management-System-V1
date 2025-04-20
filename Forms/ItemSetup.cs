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
    public partial class ItemSetup : Form
    {
        Items myItem = new Items();
        ItemService itemService = new ItemService();
        public ItemSetup()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUpdName.Text))
            {
                MessageBox.Show("Invalid Name");
                txtUpdName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdDescription.Text))
            {
                MessageBox.Show("Invalid Description");
                txtUpdDescription.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdReorderLevel.Text))
            {
                MessageBox.Show("Invalid ReorderLevel");
                txtUpdReorderLevel.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdQuantity.Text))
            {
                MessageBox.Show("Invalid Quantity");
                txtUpdQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdUnitPrice.Text))
            {
                MessageBox.Show("Invalid UnitPrice");
                txtUpdUnitPrice.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdTotalCost.Text))
            {
                MessageBox.Show("Invalid TotalCost");
                txtUpdTotalCost.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdSupplierID.Text))
            {
                MessageBox.Show("Invalid SupplierID");
                txtUpdSupplierID.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdWarehouseID.Text))
            {
                MessageBox.Show("Invalid WarehouseID");
                txtUpdWarehouseID.Focus();
            }
            //else if (String.IsNullOrWhiteSpace(txtUpdStatus.Text))
            //{
            //    MessageBox.Show("Invalid Status");
            //    txtUpdStatus.Focus();
            //}
            else
            {
                myItem.Name = txtUpdName.Text;
                myItem.Description = txtUpdDescription.Text;
                myItem.Quantity = Convert.ToInt32(txtUpdQuantity.Text);
                myItem.ReorderLevel = Convert.ToInt32(txtUpdReorderLevel.Text);
                myItem.UnitPrice = Convert.ToDecimal(txtUpdUnitPrice.Text);
                myItem.TotalCost = Convert.ToDecimal(txtUpdTotalCost.Text);
                myItem.SupplierID = Convert.ToInt32(txtUpdSupplierID.Text);
                myItem.WarehouseID = Convert.ToInt32(txtUpdWarehouseID.Text);
                myItem.IsActive = true;

                itemService.CreateItem(myItem);
                MessageBox.Show("New Item Added");
                btnClear.PerformClick();
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

            // Reset button states
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            //btnDelete.Enabled = false;

            // Refresh the DataGridView
            dgvItemList.DataSource = itemService.GetAllItems().Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUpdName.Text))
            {
                MessageBox.Show("Invalid Name");
                txtUpdName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdDescription.Text))
            {
                MessageBox.Show("Invalid Description");
                txtUpdDescription.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdReorderLevel.Text))
            {
                MessageBox.Show("Invalid ReorderLevel");
                txtUpdReorderLevel.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdQuantity.Text))
            {
                MessageBox.Show("Invalid Quantity");
                txtUpdQuantity.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdUnitPrice.Text))
            {
                MessageBox.Show("Invalid UnitPrice");
                txtUpdUnitPrice.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdTotalCost.Text))
            {
                MessageBox.Show("Invalid TotalCost");
                txtUpdTotalCost.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdSupplierID.Text))
            {
                MessageBox.Show("Invalid SupplierID");
                txtUpdSupplierID.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtUpdWarehouseID.Text))
            {
                MessageBox.Show("Invalid WarehouseID");
                txtUpdWarehouseID.Focus();
            }
            //else if (String.IsNullOrWhiteSpace(txtUpdStatus.Text))
            //{
            //    MessageBox.Show("Invalid Status");
            //    txtUpdStatus.Focus();
            //}
            else
            {
                myItem.Name = txtUpdName.Text;
                myItem.Description = txtUpdDescription.Text;
                myItem.Quantity = Convert.ToInt32(txtUpdQuantity.Text);
                myItem.ReorderLevel = Convert.ToInt32(txtUpdReorderLevel.Text);
                myItem.UnitPrice = Convert.ToDecimal(txtUpdUnitPrice.Text);
                myItem.TotalCost = Convert.ToDecimal(txtUpdTotalCost.Text);
                myItem.SupplierID = Convert.ToInt32(txtUpdSupplierID.Text);
                myItem.WarehouseID = Convert.ToInt32(txtUpdWarehouseID.Text);
                myItem.IsActive = true;

                itemService.UpdateItem(myItem);
                MessageBox.Show("New Item Added");
                btnClear.PerformClick();
            }
        }

        private void dgvItemList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked (not header)
            {
                DataGridViewRow row = dgvItemList.Rows[e.RowIndex];

                // Assign values to the item object
                myItem.ItemID = Convert.ToInt32(row.Cells[0].Value);
                myItem.Name = row.Cells[1].Value.ToString();
                myItem.Description = row.Cells[2].Value?.ToString() ?? ""; // Handle potential null
                myItem.Quantity = Convert.ToInt32(row.Cells[3].Value);
                myItem.ReorderLevel = Convert.ToInt32(row.Cells[4].Value);
                myItem.UnitPrice = Convert.ToDecimal(row.Cells[5].Value);
                myItem.TotalCost = Convert.ToDecimal(row.Cells[6].Value);
                myItem.SupplierID = Convert.ToInt32(row.Cells[7].Value);
                myItem.WarehouseID = Convert.ToInt32(row.Cells[8].Value);
                myItem.IsActive = true;

                // Update the textboxes
                txtUpdName.Text = myItem.Name;
                txtUpdDescription.Text = myItem.Description;
                txtUpdQuantity.Text = myItem.Quantity.ToString();
                txtUpdReorderLevel.Text = myItem.ReorderLevel.ToString();
                txtUpdUnitPrice.Text = myItem.UnitPrice.ToString();
                txtUpdTotalCost.Text = myItem.TotalCost.ToString();
                txtUpdSupplierID.Text = myItem.SupplierID.ToString();
                txtUpdWarehouseID.Text = myItem.WarehouseID.ToString();

                // Remove the row from the grid (if still needed)
                dgvItemList.Rows.RemoveAt(e.RowIndex);

                // Update button states
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                //btnDelete.Enabled = true;
            }
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
            btnClear.PerformClick();
        }
    }
}
