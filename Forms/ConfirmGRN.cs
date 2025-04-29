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
    public partial class ConfirmGRN : Form
    {
        ConfirmGRNmodel currentGRN = new ConfirmGRNmodel();
        ConfirmGRNservice confirmgrnService = new ConfirmGRNservice();
        public ConfirmGRN()
        {
            InitializeComponent();
        }

        private void btncfmGRNConfirm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcfmGRNID.Text, out int grnID) || grnID <= 0)
            {
                MessageBox.Show("Please Select a valid GRN ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var itemid = Convert.ToInt32(txtItemID.Text);
            var quantity = Convert.ToInt32(txtcfmGRNNumberOfUnits.Text);
            var result = confirmgrnService.ConfirmGRN(grnID, itemid, quantity);

            MessageBox.Show(
                result.Message,
                result.IsSuccess ? "Success" : "Error",
                MessageBoxButtons.OK,
                result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (result.IsSuccess)
            {
                // Refresh the view or close the form
                this.DialogResult = DialogResult.OK;
            }
            btncfmGRNClear.PerformClick();
        }


        private void btncfmGRNClear_Click(object sender, EventArgs e)
        {      
            txtcfmGRNID.Clear();
            txtPOID.Clear();
            txtItemID.Clear();
            txtItemName.Clear();
            //txtcfmPONumber.Clear();
            txtcfmGRNNotes.Clear();
            txtcfmSupplierID.Clear();
            txtcfmSupplierName.Clear();
            txtcfmGRNNumberOfUnits.Clear();
            txtcfmTotalCost.Clear();
            //txtcfmCreatedBy.Clear();
            txtcfmUnitPrice.Clear();
            dtpcfmDateOfDelivery.Value = DateTime.Now.AddDays(7);


            //btnAPOAdd.Enabled = true;
            btncfmGRNConfirm.Enabled = true;

            // Load data and handle access
            var grns = confirmgrnService.GetAllGRN();

            if (grns == null) // No access
            {
                MessageBox.Show("You don't have permission to access this page");
                this.Close();
                new LandingPage().Show();
                return;
            }

            if (grns.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No pending GRNs found");
            }

            dgvcfmGRNList.DataSource = grns.Tables[0];
        }

        private void dgvcfmGRNList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Scroll to and select the row
            dgvcfmGRNList.CurrentCell = dgvcfmGRNList.Rows[e.RowIndex].Cells[0];

            DataRowView row = (DataRowView)dgvcfmGRNList.Rows[e.RowIndex].DataBoundItem;

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
            //currentGRN.CreatedBy = row["CreatedBy"] != DBNull.Value ? row["CreatedBy"].ToString() : string.Empty;
            currentGRN.DateOfDelivery = row["DateOfDelivery"] != DBNull.Value ? Convert.ToDateTime(row["DateOfDelivery"]) : DateTime.Now;
            currentGRN.CreatedAt = row["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(row["CreatedAt"]) : DateTime.Now;
            currentGRN.Status = row["Status"] != DBNull.Value ? row["Status"].ToString() : string.Empty;
            currentGRN.Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : string.Empty;

            // Populate form fields
            txtcfmGRNID.Text = currentGRN.GRNID.ToString();
            txtPOID.Text = currentGRN.POID.ToString();
            txtItemID.Text = currentGRN.ItemID.ToString();
            txtItemName.Text = currentGRN.ItemName;
            txtcfmSupplierID.Text = currentGRN.SupplierID.ToString();
            txtcfmSupplierName.Text = currentGRN.SupplierName;
            txtcfmUnitPrice.Text = currentGRN.UnitPrice.ToString("0.00");
            txtcfmGRNNumberOfUnits.Text = currentGRN.NumberOfUnits.ToString();
            txtcfmTotalCost.Text = currentGRN.TotalCost.ToString("0.00");
            dtpcfmDateOfDelivery.Value = currentGRN.DateOfDelivery;
            txtcfmGRNNotes.Text = currentGRN.Notes;

            // Update button states
            btncfmGRNConfirm.Enabled = true;
            btncfmGRNReject.Enabled = true;
            btncfmGRNClear.Enabled = true;
        }

        private void btncfmGRNReject_Click (object sender, EventArgs e)
        {
            if (!int.TryParse(txtcfmGRNID.Text, out int grnID) || grnID <= 0)
            {
                MessageBox.Show("Please enter a valid GRN ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = confirmgrnService.RejectGRN (grnID);

            MessageBox.Show(
                result.Message,
                result.IsSuccess ? "Success" : "Error",
                MessageBoxButtons.OK,
                result.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (result.IsSuccess)
            {
                // Refresh the view or close the form
                this.DialogResult = DialogResult.OK;
            }
            btncfmGRNClear.PerformClick();
        }

        private void ConfirmGRNform_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btncfmGRNClear.PerformClick();
        }

        private void btncfmGRNExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }

    }
}
