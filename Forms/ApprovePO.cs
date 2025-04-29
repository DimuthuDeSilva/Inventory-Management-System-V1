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
        PurchaseOrderInvoiceService myInvoice = new PurchaseOrderInvoiceService();
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
            var notes = txtCPONotes.Text;
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
                this.PrintInvoice(poID);
            }
            btnAPOClear.PerformClick();
        }

        private void PrintInvoice(int poID)
        {
            DataSet ds = myInvoice.GetPoInvoice(poID);

            if (ds.Tables.Count > 0)
            {
                string filePath = $@"D:\PO Invoice\ApprovedPoInvoice_{poID}.pdf";
                myInvoice.ExportPoInvoiceToPdf(poID, filePath);
                MessageBox.Show("PDF exported successfully to:\n" + filePath);
            }
        }


        private void btnAPOClear_Click(object sender, EventArgs e)
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

            txtPOID.Enabled = false;
            txtCPOSupplierID.Enabled = false;
            txtCPOTotalAmount.Enabled = false;
            txtCPOCreatedBy.Enabled = false;
            txtCPONumberOfUnits.Enabled = false;
            txtItemID.Enabled = false;
            txtItemName.Enabled = false;
            txtSupplierName.Enabled = false;
            txtCPONotes.Enabled = false;
            dtpCPOExDD.Enabled = false;
            dtpCPOOrderDate.Enabled = false;
            txtCPOUnitPrice.Enabled = false;

            //btnAPOAdd.Enabled = true;
            btnAPOApprove.Enabled = false;

            // Load data and handle access
            var purchaseOrders = approvePOService.GetAllPurchaseOrders();

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

            // Set approvePO properties from selected row
            approvePO.POID = Convert.ToInt32(row["POID"]);
            approvePO.ItemID = Convert.ToInt32(row["ItemID"]);
            approvePO.ItemName = row["ItemName"].ToString();
            approvePO.SupplierID = Convert.ToInt32(row["SupplierID"]);
            approvePO.SupplierName = row["SupplierName"].ToString();
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
            txtItemID.Text = approvePO.ItemID.ToString();  // Changed from PONumber to ItemID
            txtItemName.Text = approvePO.ItemName;
            txtCPOSupplierID.Text = approvePO.SupplierID.ToString();
            txtSupplierName.Text = approvePO.SupplierName;
            dtpCPOOrderDate.Value = approvePO.OrderDate;
            dtpCPOExDD.Value = approvePO.ExpectedDeliveryDate ?? DateTime.Now.AddDays(7);
            txtCPOTotalAmount.Text = approvePO.TotalAmount.ToString("N2");
            txtCPOUnitPrice.Text = approvePO.UnitPrice.ToString("N2");
            txtCPONumberOfUnits.Text = approvePO.NumberOfUnits.ToString();
            txtCPONotes.Text = approvePO.Notes ?? "";

            // Set button state
            btnAPOApprove.Enabled = (approvePO.Status == "Pending");  // Only enable if status is Pending
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
            LandingPage home = new LandingPage();
            home.Show();
        }

        private void ApprovePOForm_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnAPOClear.PerformClick();
        }
    }
}
