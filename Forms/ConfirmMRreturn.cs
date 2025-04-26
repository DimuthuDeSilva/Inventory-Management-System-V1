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
using MySql.Data.MySqlClient;

namespace Inventory_Management_System.Forms
{
    public partial class ConfirmMRreturn : Form
    {
        ConfirmMRreturnModel myMRR = new ConfirmMRreturnModel();
        ConfirmMRreturnService myMRRservice = new ConfirmMRreturnService();

        public ConfirmMRreturn()
        {
            InitializeComponent();
        }


        private void btnMRRConfirm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMRRItemID.Text, out int mrrID) || mrrID <= 0)
            {
                MessageBox.Show("Please enter a valid MRR ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var notes = txtMRRNotes.Text;

            var result = myMRRservice.ConfirmMRR(mrrID);

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
            btnMRRClear.PerformClick();
        }

        private void btnMRRReject_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMRRItemID.Text, out int mrrID) || mrrID <= 0)
            {
                MessageBox.Show("Please enter a valid MRR ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var notes = txtMRRNotes.Text;

            var result = myMRRservice.RejectMRR(mrrID);

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
            btnMRRClear.PerformClick();
        }

        private void btnMRRClear_Click(object sender, EventArgs e)
        {
            txtMRRItemID.Clear();
            txtMRRItemName.Clear();
            txtMRRdepartment.Clear();
            txtMRRNumberOfUnits.Clear();
            txtMRRNotes.Clear();

            //btnAPOAdd.Enabled = true;
            btnMRRConfirm.Enabled = true;

            // Load data and handle access
            var mrr = myMRRservice.GetAllToConfirmMRRs();

            if (mrr == null) // No access
            {
                MessageBox.Show("You don't have permission to access this page");
                this.Close();
                new LandingPage().Show();
                return;
            }

            if (mrr.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No pending MRRs found");
            }

            dgvMRRList.DataSource = mrr.Tables[0];
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
            btnMRRClear.PerformClick();
        }

        private void dgvMRNList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvMRRList.Rows[e.RowIndex].DataBoundItem;

            // Map data from row to createPayment object
            myMRR.MRRID = Convert.ToInt32(row["MRNID"]);
            myMRR.ItemID = Convert.ToInt32(row["ItemID"]);
            myMRR.NumberOfUnits = Convert.ToInt32(row["NumberOfUnits"]);
            myMRR.Department = row["Department"].ToString();
            myMRR.RequestedBy = row["RequestedBy"].ToString();
            myMRR.ItemName = row["ItemName"].ToString();
            myMRR.Status = row["Status"].ToString();
            myMRR.ApprovedBy = row["ApprovedBy"].ToString();
            myMRR.Notes = row["Notes"].ToString();
            myMRR.CreatedDate = Convert.ToDateTime(row["CreatedDate"]);

            // Populate form fields
            txtMRRItemID.Text = myMRR.ItemID.ToString();
            txtMRRItemName.Text = myMRR.ItemName.ToString();
            txtMRRdepartment.Text = myMRR.Department.ToString();
            txtMRRNumberOfUnits.Text = myMRR.NumberOfUnits.ToString();
            txtMRRNotes.Text = myMRR.Notes ?? "";

            btnMRRConfirm.Enabled = true;
            btnMRRReject.Enabled = true;
        }
    }
}
