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
    public partial class CreateMRreturn : Form
    {
        CreateMRreturnModel myMRR = new CreateMRreturnModel();
        CreateMRreturnService myMRRservice = new CreateMRreturnService();
        ItemstoCreateMRR myitems = new ItemstoCreateMRR();

        public CreateMRreturn()
        {
            InitializeComponent();
        }
        private void btnMRRAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateMRNInputs()) return;

            try
            {
                myMRR.Department = txtMRRdepartment.Text;
                //myMRR.RequestedBy = txtRequestedBy.Text;  // Make sure this textbox exists in your form
                myMRR.ItemID = Convert.ToInt32(txtMRRItemID.Text);  // Make sure this textbox exists
                myMRR.ItemName = txtMRRItemName.Text;
                myMRR.NumberOfUnits = Convert.ToInt32(txtMRRNumberOfUnits.Text);
                myMRR.Status = "Pending";  // Default status as per your table structure
                myMRR.ApprovedBy = null;  // Will be set when approved
                myMRR.Notes = txtMRRNotes.Text;
                // CreatedDate is automatically handled by the database (CURRENT_TIMESTAMP)

                myMRRservice.CreateMRR(myMRR);
                MessageBox.Show("Material Request Return Created Successfully!");
                btnMRRClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating Material Request Return: {ex.Message}");
            }
        }

        private bool ValidateMRNInputs()
        {
            if (String.IsNullOrWhiteSpace(txtMRRItemName.Text))
            {
                MessageBox.Show("Item Name is required");
                txtMRRItemName.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtMRRdepartment.Text))
            {
                MessageBox.Show("Department is required");
                txtMRRdepartment.Focus();
                return false;
            }
            if (!int.TryParse(txtMRRNumberOfUnits.Text, out int numberOfUnits) || numberOfUnits <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (positive whole number)");
                txtMRRNumberOfUnits.Focus();
                return false;
            }
            if (!int.TryParse(txtMRRItemID.Text, out int itemId) || itemId <= 0)
            {
                MessageBox.Show("Please enter a valid Item ID (positive number)");
                txtMRRItemID.Focus();
                return false;
            }
                return true;
        }

        private void btnMRRClear_Click(object sender, EventArgs e)
        {
            txtMRRItemID.Clear();
            txtMRRItemName.Clear();
            txtMRRdepartment.Clear();
            txtMRRNumberOfUnits.Clear();
            txtMRRNotes.Clear();

            btnMRRAdd.Enabled = true;
            //btnCPOUpdate.Enabled = false;

            dgvMRRList.DataSource = myMRRservice.GetAllMRR().Tables[0];
        }

        private void dgvMRNList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvMRRList.Rows[e.RowIndex].DataBoundItem;

            // Map data from row to createPayment object
            myitems.ItemID = Convert.ToInt32(row["ItemID"]);
            myitems.Name = row["Name"].ToString();
            myitems.Description = row["Description"].ToString();
            myitems.Quantity = Convert.ToInt32(row["Quantity"]);
            myitems.ReorderLevel = Convert.ToInt32(row["ReorderLevel"]);
            myitems.UnitPrice = Convert.ToDecimal(row["UnitPrice"]);
            myitems.TotalCost = Convert.ToDecimal(row["TotalCost"]);
            myitems.SupplierID = Convert.ToInt32(row["SupplierID"]);
            myitems.WarehouseID = Convert.ToInt32(row["WarehouseID"]);
            myitems.IsActive = Convert.ToBoolean(row["IsActive"]);

            // Populate form fields
            txtMRRItemID.Text = myitems.ItemID.ToString();
            txtMRRItemName.Text = myitems.Name.ToString();
            txtMRRdepartment.Text = myMRR.Department.ToString();
            txtMRRNumberOfUnits.Text = myMRR.NumberOfUnits.ToString();
            txtMRRNotes.Text = myMRR.Notes ?? "";

            btnMRRAdd.Enabled = true;
            btnMRRClear.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void CreatePO_Load_1(object sender, EventArgs e)
        {
            btnMRRClear.PerformClick();
        }

        private void txtItemID_KeyUp(object sender, KeyEventArgs e)
        {
            var itemID = Convert.ToInt32(txtMRRItemID.Text);
            bool check = myMRRservice.isExist(itemID);
            if (!check)
            {
                MessageBox.Show("The entered Item ID does not exist in our system. Please enter a valid Item ID.");
            }
            var itemName = myMRRservice.GetItemName(itemID);
            txtMRRItemName.Text = itemName.ToString();
        }

        private void lblLoggedUser_Click(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnMRRClear.PerformClick();
        }
    }
}
