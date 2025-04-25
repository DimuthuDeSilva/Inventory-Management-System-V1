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
    public partial class ConfirmMRN : Form
    {
        ConfirmMRNmodel myMRN = new ConfirmMRNmodel();
        ConfirmMRNservice myMRNservice = new ConfirmMRNservice();

        public ConfirmMRN()
        {
            InitializeComponent();
        }

        private void btnMRNConfirm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMRNItemID.Text, out int mrnID) || mrnID <= 0)
            {
                MessageBox.Show("Please enter a valid MRN ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var notes = txtMRNNotes.Text;

            var result = myMRNservice.ConfirmMRN(mrnID);

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
            btnMRNClear.PerformClick();
        }

        private void btnMRNReject_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMRNItemID.Text, out int mrnID) || mrnID <= 0)
            {
                MessageBox.Show("Please enter a valid MRN ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var notes = txtMRNNotes.Text;

            var result = myMRNservice.RejectMRN(mrnID);

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
            btnMRNClear.PerformClick();
        }

        private void btnMRNClear_Click(object sender, EventArgs e)
        {
            txtMRNItemID.Clear();
            txtMRNItemName.Clear();
            txtMRNdepartment.Clear();
            txtMRNNumberOfUnits.Clear();
            txtMRNNotes.Clear();

            //btnAPOAdd.Enabled = true;
            btnMRNConfirm.Enabled = true;

            // Load data and handle access
            var mrn = myMRNservice.GetAllToConfirmMRNs();

            if (mrn == null) // No access
            {
                MessageBox.Show("You don't have permission to access this page");
                this.Close();
                new Home().Show();
                return;
            }

            if (mrn.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No pending MRNs found");
            }

            dgvMRNList.DataSource = mrn.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void CreatePO_Load_1(object sender, EventArgs e)
        {
            btnMRNClear.PerformClick();
        }

        private void lblLoggedUser_Click(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnMRNClear.PerformClick();
        }

        private void dgvMRNList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvMRNList.Rows[e.RowIndex].DataBoundItem;

            // Map data from row to createPayment object
            myMRN.MRNID = Convert.ToInt32(row["MRNID"]);
            myMRN.ItemID = Convert.ToInt32(row["ItemID"]);
            myMRN.NumberOfUnits = Convert.ToInt32(row["NumberOfUnits"]);
            myMRN.Department = row["Department"].ToString();
            myMRN.RequestedBy = row["RequestedBy"].ToString();
            myMRN.ItemName = row["ItemName"].ToString();
            myMRN.Status = row["Status"].ToString();
            myMRN.ApprovedBy = row["ApprovedBy"].ToString();
            myMRN.Notes = row["Notes"].ToString();
            myMRN.CreatedDate = Convert.ToDateTime(row["CreatedDate"]);

            // Populate form fields
            txtMRNItemID.Text = myMRN.ItemID.ToString();
            txtMRNItemName.Text = myMRN.ItemName.ToString();
            txtMRNdepartment.Text = myMRN.Department.ToString();
            txtMRNNumberOfUnits.Text = myMRN.NumberOfUnits.ToString();
            txtMRNNotes.Text = myMRN.Notes ?? "";

            btnMRNConfirm.Enabled = true;
            btnMRNReject.Enabled = true;
        }
    }
}
