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
    public partial class StockIn : Form
    {
        StockInModel myStockinmodel = new StockInModel();
        StockInService myStockinService = new StockInService();

        public StockIn()
        {
            InitializeComponent();
        }

        private bool ValidateStockReleaseInputs()
        {
            // Validate MRNID (must be a positive number)
            if (!int.TryParse(txtMRRID.Text, out int mrnId) || mrnId <= 0)
            {
                MessageBox.Show("Please enter a valid MRN ID (positive number)");
                txtMRRID.Focus();
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
            if (string.IsNullOrWhiteSpace(dtpReceivedDate.Text))
            {
                MessageBox.Show("Please enter your name as Issued By");
                dtpReceivedDate.Focus();
                return false;
            }

            // All validations passed
            return true;
        }
        private void btnSTinProcess_Click(object sender, EventArgs e)
        {
            if (!ValidateStockReleaseInputs()) return;

            try
            {
                myStockinmodel.MRRID = Convert.ToInt32(txtMRRID.Text);
                myStockinmodel.ItemID = Convert.ToInt32(txtItemID.Text);
                myStockinmodel.ItemName = txtItemName.Text.ToString();
                myStockinmodel.Quantity = Convert.ToInt32(txtQuantity.Text);
                myStockinmodel.ReceivedQuantity = Convert.ToInt32(txtIssuedQuantity.Text);
                myStockinmodel.ReceivedBy = Session.CurrentUser?.Username;
                myStockinmodel.Notes = txtMRRNotes.Text.ToString();
                myStockinmodel.Status = "Received"; // Default status when receiving stock

                myStockinService.StockInProcess(myStockinmodel);
                MessageBox.Show("Stock received successfully!");
                btnRESET.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error receiving stock: {ex.Message}");
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnRESET.PerformClick();
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            txtMRRID.Clear();
            txtItemID.Clear();
            txtItemName.Clear();
            txtQuantity.Clear();
            txtMRRStatus.Clear();
            txtIssuedQuantity.Clear();
            dtpReceivedDate.Value = DateTime.Now;
            txtMRRNotes.Clear();

            // Load data and handle access
            var stockinprocess = myStockinService.GetApprovedMRRsWithMRRID();

            dgvStockIntList.DataSource = stockinprocess.Tables[0];
        }

        private void dgvSTintList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvStockIntList.Rows[e.RowIndex].DataBoundItem;

            // Define property for textbox or Model data
            myStockinmodel.MRRID = Convert.ToInt32(row["MRRID"]);
            myStockinmodel.ItemID = Convert.ToInt32(row["ItemID"]);
            myStockinmodel.MRRID = Convert.ToInt32(row["MRRID"]);
            myStockinmodel.NumberOfUnits = Convert.ToInt32(row["NumberOfUnits"]);
            //myStockoutmodel.IssuedQuantity = Convert.ToInt32(row["IssuedQuantity"]);
            myStockinmodel.ItemName = row["ItemName"].ToString();
            myStockinmodel.Status = row["Status"].ToString();
            myStockinmodel.Notes = row["Notes"].ToString();
            //myStockoutmodel.IssuedDate = Convert.ToDateTime(row["IssuedDate"]);

            // Map to UI controls
            txtMRRID.Text = myStockinmodel.MRRID.ToString();
            txtItemID.Text = myStockinmodel.ItemID.ToString();
            txtItemName.Text = myStockinmodel.ItemName.ToString();
            txtQuantity.Text = myStockinmodel.NumberOfUnits.ToString();
            txtMRRStatus.Text = myStockinmodel.Status.ToString();
            //txtIssuedQuantity.Text = myStockoutmodel.IssuedQuantity.ToString();
            //dtpIssuedDate.Value = myStockoutmodel.IssuedDate;
            txtMRRNotes.Text = myStockinmodel.Notes.ToString();

            //btnAPOAdd.Enabled = false;
            btnRESET.Enabled = true;
        }
    }
    
}
