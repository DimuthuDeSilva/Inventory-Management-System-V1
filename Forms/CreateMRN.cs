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
    public partial class CreateMRN : Form
    {
        CreateMRNmodel myMRN = new CreateMRNmodel();
        CreateMRNService myMRNservice = new CreateMRNService();

        public CreateMRN()
        {
            InitializeComponent();
        }
        private void btnCPOAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMRNInputs()) return;

            try
            {
                myMRN.Department = txtMRNdepartment.Text;
                //myMRN.RequestedBy = txtRequestedBy.Text;  // Make sure this textbox exists in your form
                myMRN.ItemID = Convert.ToInt32(txtItemID.Text);  // Make sure this textbox exists
                myMRN.ItemName = txtItemName.Text;
                myMRN.NumberOfUnits = Convert.ToInt32(txtMRNNumberOfUnits.Text);
                myMRN.Status = "Pending";  // Default status as per your table structure
                myMRN.ApprovedBy = null;  // Will be set when approved
                myMRN.Notes = txtMRNNotes.Text;
                // CreatedDate is automatically handled by the database (CURRENT_TIMESTAMP)

                myMRNservice.CreateMRN(myMRN);
                MessageBox.Show("Material Request Note Created Successfully!");
                btnCPOClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating Material Request Note: {ex.Message}");
            }
        }

        private bool ValidateMRNInputs()
        {
            if (String.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Item Name is required");
                txtItemName.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtMRNdepartment.Text))
            {
                MessageBox.Show("Department is required");
                txtMRNdepartment.Focus();
                return false;
            }
            if (!int.TryParse(txtMRNNumberOfUnits.Text, out int numberOfUnits) || numberOfUnits <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (positive whole number)");
                txtMRNNumberOfUnits.Focus();
                return false;
            }
            if (!int.TryParse(txtItemID.Text, out int itemId) || itemId <= 0)
            {
                MessageBox.Show("Please enter a valid Item ID (positive number)");
                txtItemID.Focus();
                return false;
            }
                return true;
        }     

        private void btnCPOClear_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            txtItemID.Clear();
            txtMRNNotes.Clear();
            txtMRNdepartment.Clear();
            txtMRNNumberOfUnits.Clear();

            btnCPOAdd.Enabled = true;
            //btnCPOUpdate.Enabled = false;

            dgvMRNList.DataSource = myMRNservice.GetAllMRN().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }

        private void CreatePO_Load_1(object sender, EventArgs e)
        {
            btnCPOClear.PerformClick();
        }

        private void txtItemID_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void lblLoggedUser_Click(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnCPOClear.PerformClick();
        }

        private void dgvMRNList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvMRNList.Rows[e.RowIndex].DataBoundItem;

            // Map data from row to createPayment object
            myMRN.ItemID = Convert.ToInt32(row["ItemID"]);
            myMRN.MRNID = Convert.ToInt32(row["MRNID"]);
            myMRN.NumberOfUnits = Convert.ToInt32(row["NumberOfUnits"]);
            myMRN.ItemName = row["ItemName"].ToString();
            myMRN.RequestedBy = row["RequestedBy"].ToString();
            myMRN.Status = row["Status"].ToString();
            myMRN.ApprovedBy = row["ApprovedBy"].ToString();
            myMRN.Department = row["Department"].ToString();


            // Populate form fields
            txtItemID.Text = myMRN.ItemID.ToString();
            txtItemName.Text = myMRN.ItemName.ToString();
            txtMRNdepartment.Text = myMRN.Department.ToString();
            txtMRNNumberOfUnits.Text = myMRN.NumberOfUnits.ToString();
            txtMRNNotes.Text = myMRN.Notes ?? "";

            btnCPOAdd.Enabled = true;
            btnCPOClear.Enabled = true;
        }

        private void txtItemID_Leave(object sender, EventArgs e)
        {
            var itemID = Convert.ToInt32(txtItemID.Text);
            bool check = myMRNservice.isExist(itemID);
            if (!check)
            {
                MessageBox.Show("The entered Item ID does not exist in our system. Please enter a valid Item ID.");
            }
            var itemName = myMRNservice.GetItemName(itemID);
            txtItemName.Text = itemName.ToString();
        }

        private void btnCPOUpdate_Click(object sender, EventArgs e)
        {
            if (myMRN.Status != "Pending")
            {
                MessageBox.Show("Cannot cancel a Material Request Note that has been Confirmed,Rejected or Stock Released.",
                              "Operation Not Allowed",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
            }
            else
            {
                var mrnID = myMRN.MRNID;
                bool check = myMRNservice.CancelMRN(mrnID);

                if (check)
                {
                    MessageBox.Show("MRN Cancelled Successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to cencael the MRN", 
                            "Please contact administrator",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                }
            }
            btnCPOClear.PerformClick();
            
        }
    }
}
