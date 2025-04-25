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
    public partial class ApprovePO : Form
    {
        Models.ApprovePO approvePO = new Models.ApprovePO();
        ApprovePOService approvePOService = new ApprovePOService();
        public ApprovePO()
        {
            InitializeComponent();
        }

        private void btnAPOApprove_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPOID.Text, out int poID) || poID <= 0)
            {
                MessageBox.Show("Please enter a valid PO ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var notes = txtAPONotes.Text;

            var result = approvePOService.ConfirmPO(poID, notes);

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
            btnAPOClear.PerformClick();
        }


        private void btnAPOClear_Click(object sender, EventArgs e)
        {
         
            txtAPONumber.Clear();
            txtAPONotes.Clear();
            txtAPOSupplierID.Clear();
            txtAPOTotalAmount.Clear();
            txtAPOCreatedBy.Clear();
            txtAPOUnitPrice.Clear();
            txtAPONumberOfUnits.Clear();
            dtpAPOOrderDate.Value = DateTime.Now;
            dtpAPOExDD.Value = DateTime.Now.AddDays(7);
            txtAPONotes.Clear();

            //btnAPOAdd.Enabled = true;
            btnAPOApprove.Enabled = false;

            // Load data and handle access
            var purchaseOrders = approvePOService.GetAllPurchaseOrders();

            if (purchaseOrders == null) // No access
            {
                MessageBox.Show("You don't have permission to access this page");
                this.Close();
                new Home().Show();
                return;
            }

            if (purchaseOrders.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No pending purchase orders found");
            }

            dgvAPOList.DataSource = purchaseOrders.Tables[0];
        }

        private void dgvAPOList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvAPOList.Rows[e.RowIndex].DataBoundItem;

            approvePO.POID = Convert.ToInt32(row["POID"]);
            approvePO.PONumber = row["PONumber"].ToString();
            approvePO.SupplierID = Convert.ToInt32(row["SupplierID"]);
            approvePO.OrderDate = Convert.ToDateTime(row["OrderDate"]);
            approvePO.ExpectedDeliveryDate = row["ExpectedDeliveryDate"] != DBNull.Value ?
                                          Convert.ToDateTime(row["ExpectedDeliveryDate"]) : (DateTime?)null;
            approvePO.Status = row["Status"].ToString();
            approvePO.UnitPrice = Convert.ToDecimal(row["UnitPrice"]);
            approvePO.NumberOfUnits = Convert.ToInt32(row["NumberOfUnits"]);
            approvePO.TotalAmount = Convert.ToDecimal(row["TotalAmount"]);
            approvePO.CreatedBy = Convert.ToInt32(row["CreatedBy"]);
            approvePO.ApprovedBy = row["ApprovedBy"] != DBNull.Value ?
                                 Convert.ToInt32(row["ApprovedBy"]) : (int?)null;
            approvePO.Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : null;

            // Populate form fields
            txtPOID.Text = approvePO.POID.ToString();
            txtAPONumber.Text = approvePO.PONumber;
            txtAPOSupplierID.Text = approvePO.SupplierID.ToString();
            dtpAPOOrderDate.Value = approvePO.OrderDate;
            dtpAPOExDD.Value = approvePO.ExpectedDeliveryDate ?? DateTime.Now.AddDays(7);
            txtAPOTotalAmount.Text = approvePO.TotalAmount.ToString("N2");
            txtAPOCreatedBy.Text = approvePO.CreatedBy.ToString();
            txtAPOUnitPrice.Text = approvePO.UnitPrice.ToString();
            txtAPONumberOfUnits.Text = approvePO.NumberOfUnits.ToString();
            txtAPONotes.Text = approvePO.Notes ?? "";
            txtAPOStatus.Text = approvePO.Status;

            //btnAPOAdd.Enabled = false;
            btnAPOApprove.Enabled = true;
        }

        private void btnAPOReject_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPOID.Text, out int poID) || poID <= 0)
            {
                MessageBox.Show("Please enter a valid PO ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = approvePOService.RejectPO(poID);

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
            btnAPOClear.PerformClick();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void ApprovePOForm_Load(object sender, EventArgs e)
        {
            btnAPOClear.PerformClick();
        }

        private void lblLoggedUser_Click(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnAPOClear.PerformClick();
        }
    }
}
