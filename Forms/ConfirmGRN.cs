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
        ConfirmGRNmodel confirmGRN = new ConfirmGRNmodel();
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

            var result = confirmgrnService.ConfirmGRN(grnID);

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
            txtcfmPONumber.Clear();
            txtcfmGRNNotes.Clear();
            txtcfmSupplierID.Clear();
            txtcfmSupplierName.Clear();
            txtcfmGRNNumberOfUnits.Clear();
            txtcfmTotalCost.Clear();
            txtcfmCreatedBy.Clear();
            txtcfmUnitPrice.Clear();
            dtpcfmDateOfDelivery.Value = DateTime.Now.AddDays(7);


            //btnAPOAdd.Enabled = true;
            btncfmGRNConfirm.Enabled = false;

            // Load data and handle access
            var grns = confirmgrnService.GetAllGRN();

            if (grns == null) // No access
            {
                MessageBox.Show("You don't have permission to access this page");
                this.Close();
                new Home().Show();
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

            DataRowView row = (DataRowView)dgvcfmGRNList.Rows[e.RowIndex].DataBoundItem;

            confirmGRN.GRNID = row["GRNID"] != DBNull.Value ? Convert.ToInt32(row["GRNID"]) : 0;
            confirmGRN.PONumber = row["PONumber"] != DBNull.Value ? row["PONumber"].ToString() : string.Empty;
            confirmGRN.SupplierID = row["SupplierID"] != DBNull.Value ? Convert.ToInt32(row["SupplierID"]) : 0;
            confirmGRN.SupplierName = row["SupplierName"] != DBNull.Value ? row["SupplierName"].ToString() : string.Empty;
            confirmGRN.DateOfDelivery = Convert.ToDateTime(row["DateOfDelivery"]);
            confirmGRN.UnitPrice = row["UnitPrice"] != DBNull.Value ? Convert.ToDecimal(row["UnitPrice"]) : 0;
            confirmGRN.NumberOfUnits = row["NumberOfUnits"] != DBNull.Value ? Convert.ToInt32(row["NumberOfUnits"]) : 0;
            confirmGRN.TotalCost = row["TotalCost"] != DBNull.Value ? Convert.ToDecimal(row["TotalCost"]) : 0;
            confirmGRN.CreatedBy = Convert.ToInt32(row["CreatedBy"]);
            confirmGRN.Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : null;


            // Populate form fields
            txtcfmGRNID.Text = confirmGRN.GRNID.ToString();
            txtcfmPONumber.Text = confirmGRN.PONumber;
            txtcfmSupplierID.Text = confirmGRN.SupplierID.ToString();
            txtcfmSupplierName.Text = confirmGRN.SupplierName;
            dtpcfmDateOfDelivery.Value = confirmGRN.DateOfDelivery;
            txtcfmUnitPrice.Text = confirmGRN.UnitPrice.ToString("0.00");
            txtcfmGRNNumberOfUnits.Text = confirmGRN.NumberOfUnits.ToString();
            txtcfmTotalCost.Text = confirmGRN.TotalCost.ToString("0.00");
            txtcfmGRNNotes.Text = confirmGRN.Notes ?? "";
            txtcfmCreatedBy.Text = confirmGRN.CreatedBy.ToString();

            //btnAPOAdd.Enabled = false;
            btncfmGRNConfirm.Enabled = true;
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
            btncfmGRNClear.PerformClick();
        }

        private void btncfmGRNExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void lblLoggedUser_Click(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btncfmGRNClear.PerformClick();
        }
    }
}
