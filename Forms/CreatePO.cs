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
                currentPO.PONumber = txtPONumber.Text;
                currentPO.SupplierID = Convert.ToInt32(txtCPOSupplierID.Text);
                currentPO.OrderDate = dtpCPOOrderDate.Value;
                currentPO.ExpectedDeliveryDate = dtpCPOExDD.Value;
                currentPO.UnitPrice = Convert.ToDecimal(txtCPOUnitPrice.Text);
                currentPO.NumberOfUnits = Convert.ToInt32(txtCPONumberOfUnits.Text);
                currentPO.TotalAmount = Convert.ToDecimal(txtCPOTotalAmount.Text);
                currentPO.CreatedBy = Convert.ToInt32(txtCPOCreatedBy.Text);
                currentPO.Notes = txtCPONotes.Text;
             
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
            if (String.IsNullOrWhiteSpace(txtPONumber.Text))
            {
                MessageBox.Show("PO Number is required");
                txtPONumber.Focus();
                return false;
            }
            if (!int.TryParse(txtCPOSupplierID.Text, out _))
            {
                MessageBox.Show("Invalid Supplier ID");
                txtCPOSupplierID.Focus();
                return false;
            }
            if (dtpCPOOrderDate.Value > DateTime.Now)
            {
                MessageBox.Show("Order date cannot be in the future");
                dtpCPOOrderDate.Focus();
                return false;
            }
            if (dtpCPOExDD.Value < dtpCPOOrderDate.Value)
            {
                MessageBox.Show("Delivery date cannot be before order date");
                dtpCPOExDD.Focus();
                return false;
            }
            if (!decimal.TryParse(txtCPOUnitPrice.Text, out _))
            {
                MessageBox.Show("Invalid Unit Price");
                txtCPOUnitPrice.Focus();
                return false;
            }
            if (!int.TryParse(txtCPONumberOfUnits.Text, out _))
            {
                MessageBox.Show("Invalid Number Of Units");
                txtCPONumberOfUnits.Focus();
                return false;
            }
            if (!decimal.TryParse(txtCPOTotalAmount.Text, out _))
            {
                MessageBox.Show("Invalid Total Amount");
                txtCPOTotalAmount.Focus();
                return false;
            }
            if (!int.TryParse(txtCPOCreatedBy.Text, out _))
            {
                MessageBox.Show("Invalid Created User");
                txtCPOCreatedBy.Focus();
                return false;
            }
            return true;
        }

        private void btnCPOUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidatePOInputs()) return;

            try
            {
                currentPO.PONumber = txtPONumber.Text;
                currentPO.SupplierID = Convert.ToInt32(txtCPOSupplierID.Text);
                currentPO.OrderDate = dtpCPOOrderDate.Value;
                currentPO.ExpectedDeliveryDate = dtpCPOExDD.Value;
                currentPO.UnitPrice = Convert.ToDecimal(txtCPOUnitPrice.Text);
                currentPO.NumberOfUnits = Convert.ToInt32(txtCPONumberOfUnits.Text);
                currentPO.TotalAmount = Convert.ToDecimal(txtCPOTotalAmount.Text);
                currentPO.CreatedBy = Convert.ToInt32(txtCPOCreatedBy.Text);
                currentPO.Notes = txtCPONotes.Text;

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
            txtPONumber.Clear();
            txtPOID.Clear();
            txtCPOUnitPrice.Clear();
            txtCPONotes.Clear();
            txtCPOSupplierID.Clear();
            txtCPOTotalAmount.Clear();
            txtCPOCreatedBy.Clear();
            txtCPONumberOfUnits.Clear();
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

            currentPO.POID = Convert.ToInt32(row["POID"]);
            currentPO.PONumber = row["PONumber"].ToString();
            currentPO.SupplierID = Convert.ToInt32(row["SupplierID"]);
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
            txtPONumber.Text = currentPO.PONumber.ToString();
            txtCPOSupplierID.Text = currentPO.SupplierID.ToString();
            txtCPOUnitPrice.Text = currentPO.UnitPrice.ToString();
            dtpCPOOrderDate.Value = currentPO.OrderDate;
            dtpCPOExDD.Value = currentPO.ExpectedDeliveryDate ?? DateTime.Now.AddDays(7);
            txtCPOTotalAmount.Text = currentPO.TotalAmount.ToString();
            txtCPOCreatedBy.Text = currentPO.CreatedBy.ToString();
            txtCPONumberOfUnits.Text = currentPO.NumberOfUnits.ToString();
            txtCPONotes.Text = currentPO.Notes ?? "";

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
