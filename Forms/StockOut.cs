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
    public partial class StockOut : Form
    {
        StockOutModel myStockoutmodel = new StockOutModel();
        StockOutService myStockoutService = new StockOutService();

        public StockOut()
        {
            InitializeComponent();
        }


        private bool ValidateStockReleaseInputs()
        {
            // Validate MRNID (must be a positive number)
            if (!int.TryParse(txtMRNID.Text, out int mrnId) || mrnId <= 0)
            {
                MessageBox.Show("Please enter a valid MRN ID (positive number)");
                txtMRNID.Focus();
                return false;
            }

            // Validate ItemID (must be a positive number)
            if (!int.TryParse(txtItemID.Text, out int itemId) || itemId <= 0)
            {
                MessageBox.Show("Please enter a valid Item ID (positive number)");
                txtItemID.Focus();
                return false;
            }

            // Validate ItemName (cannot be empty)
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter an Item Name");
                txtItemName.Focus();
                return false;
            }

            // Validate Quantity (must be positive number)
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid Quantity (positive number)");
                txtQuantity.Focus();
                return false;
            }

            // Validate IssuedQuantity (must be positive and <= Quantity)
            if (!int.TryParse(txtIssuedQuantity.Text, out int issuedQty) || issuedQty <= 0)
            {
                MessageBox.Show("Please enter a valid Issued Quantity (positive number)");
                txtIssuedQuantity.Focus();
                return false;
            }

            if (issuedQty > quantity)
            {
                MessageBox.Show("Issued Quantity cannot be greater than total Quantity");
                txtIssuedQuantity.Focus();
                return false;
            }

            // Validate IssuedBy (cannot be empty)
            if (string.IsNullOrWhiteSpace(dtpIssuedDate.Text))
            {
                MessageBox.Show("Please enter your name as Issued By");
                dtpIssuedDate.Focus();
                return false;
            }

            // All validations passed
            return true;
        }
        private void btnSTOutProcess_Click(object sender, EventArgs e)
        {
            if (!ValidateStockReleaseInputs()) return;

            try
            {
                myStockoutmodel.MRNID = Convert.ToInt32(txtMRNID.Text);
                myStockoutmodel.ItemID = Convert.ToInt32(txtItemID.Text);
                myStockoutmodel.ItemName = txtItemName.Text.ToString();
                myStockoutmodel.Quantity = Convert.ToInt32(txtQuantity.Text);
                myStockoutmodel.IssuedQuantity = Convert.ToInt32(txtIssuedQuantity.Text);
                myStockoutmodel.IssuedBy = Session.CurrentUser?.Username;
                myStockoutmodel.Notes = txtSOSNotes.Text.ToString();
                myStockoutmodel.Status = "Issued"; // Default status when releasing stock

                myStockoutService.StockOutProcess(myStockoutmodel);
                MessageBox.Show("Stock released successfully!");
                btnRESET.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error releasing stock: {ex.Message}");
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            txtMRNID.Clear();
            txtItemID.Clear();
            txtItemName.Clear();
            txtQuantity.Clear();
            txtStatus.Clear();
            txtIssuedQuantity.Clear();
            dtpIssuedDate.Value = DateTime.Now;
            txtSOSNotes.Clear();

            txtMRNID.Enabled = false;
            txtItemID.Enabled = false;
            txtItemName.Enabled = false;
            txtQuantity.Enabled = false;

            // Load data and handle access
            var stockOutprocess = myStockoutService.GetApprovedMRNsWithMRNID();

            dgvSTouttList.DataSource = stockOutprocess.Tables[0];
        }

        private void dgvSTouttList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvSTouttList.Rows[e.RowIndex].DataBoundItem;

            // Define property for textbox or Model data
            myStockoutmodel.MRNID = Convert.ToInt32(row["MRNID"]);
            myStockoutmodel.ItemID = Convert.ToInt32(row["ItemID"]);
            myStockoutmodel.MRNID = Convert.ToInt32(row["MRNID"]);
            myStockoutmodel.NumberOfUnits = Convert.ToInt32(row["NumberOfUnits"]);
            //myStockoutmodel.IssuedQuantity = Convert.ToInt32(row["IssuedQuantity"]);
            myStockoutmodel.ItemName = row["ItemName"].ToString();
            myStockoutmodel.Status = row["Status"].ToString();
            myStockoutmodel.Notes = row["Notes"].ToString();
            //myStockoutmodel.IssuedDate = Convert.ToDateTime(row["IssuedDate"]);

            // Map to UI controls
            txtMRNID.Text = myStockoutmodel.MRNID.ToString();
            txtItemID.Text = myStockoutmodel.ItemID.ToString();
            txtItemName.Text = myStockoutmodel.ItemName.ToString();
            txtQuantity.Text = myStockoutmodel.NumberOfUnits.ToString();
            txtStatus.Text = myStockoutmodel.Status.ToString();
            //txtIssuedQuantity.Text = myStockoutmodel.IssuedQuantity.ToString();
            //dtpIssuedDate.Value = myStockoutmodel.IssuedDate;
            txtSOSNotes.Text = myStockoutmodel.Notes.ToString();

            //btnAPOAdd.Enabled = false;
            btnRESET.Enabled = true;
        }

        private void StockOut_Load_1(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnRESET.PerformClick();
        }
    }
    
}
