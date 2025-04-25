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
    public partial class ApprovalFlowSetup : Form
    {
        ApprovalFlowModel approvalflowModel = new ApprovalFlowModel();
        ApprovalFlowService approvalflowService = new ApprovalFlowService();
        int approvalflowID;
        public ApprovalFlowSetup()
        {
            InitializeComponent();
        }

        private bool ValidateFLOWinputs()
        {
            if (String.IsNullOrWhiteSpace(txtAFSFunctionName.Text))
            {
                MessageBox.Show("Invalid Function Name");
                txtAFSFunctionName.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtAFSofName.Text))
            {
                MessageBox.Show("Invalid Officer Name");
                txtAFSofName.Focus();
                return false;
            }
            if (!int.TryParse(txtAFSLevel.Text, out _))
            {
                MessageBox.Show("Invalid Approval Level");
                txtAFSLevel.Focus();
                return false;
            }
            if (!int.TryParse(txtAFSofCode.Text, out _))
            {
                MessageBox.Show("Invalid Officer Code");
                txtAFSofCode.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateFLOWinputs()) return;

            try
            {
                approvalflowModel.FunctionName = txtAFSFunctionName.Text;
                approvalflowModel.Level = Convert.ToInt32(txtAFSLevel.Text);
                approvalflowModel.UserName = txtAFSofName.Text;
                approvalflowModel.UserID = Convert.ToInt32(txtAFSofCode.Text);


                approvalflowService.AddFlow(approvalflowModel);
                MessageBox.Show("Approval Flow Added Successfully!");
                btnAFSClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Approval Flow: {ex.Message}");
            }
        }

        private void btnAFSClear_Click(object sender, EventArgs e)
        {            

            txtAFSLevel.Clear();
            txtAFSofCode.Clear();
            txtAFSofName.Clear();
            txtAFSFunctionName.Clear();

            // Reset button states
            //btnAFSAdd.Enabled = true;
            btnAFSUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnAFSDelete.Enabled = false;

            var afsSetup = approvalflowService.GetAllApprovalFlow();

            if (afsSetup.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Records");
            }


            // Refresh the DataGridView
            dgvAFSlist.DataSource = approvalflowService.GetAllApprovalFlow().Tables[0];
            
        }

        private void btnAFSUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateFLOWinputs()) return;

            try
            {
                approvalflowModel.ApprovalFlowID = approvalflowID;
                approvalflowModel.FunctionName = txtAFSFunctionName.Text;
                approvalflowModel.Level = Convert.ToInt32(txtAFSLevel.Text);
                approvalflowModel.UserName = txtAFSofName.Text;
                approvalflowModel.UserID = Convert.ToInt32(txtAFSofCode.Text);


                approvalflowService.UpdateFlow(approvalflowModel);
                MessageBox.Show("Approval Flow Updated Successfully!");
                btnAFSClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Updating Approval Flow: {ex.Message}");
            }
        }

        private void dgvAFSlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvAFSlist.Rows[e.RowIndex].DataBoundItem;

            approvalflowModel.ApprovalFlowID = Convert.ToInt32(row["ApprovalFlowID"]);
            approvalflowModel.FunctionName = row["FunctionName"].ToString();
            approvalflowModel.Level = Convert.ToInt32(row["Level"]);
            approvalflowModel.UserName = row["UserName"].ToString();
            approvalflowModel.UserID = Convert.ToInt32(row["UserID"]);


            ////Populate form fields
            approvalflowID = approvalflowModel.ApprovalFlowID;
            //Console.WriteLine(approvalflowModel.ApprovalFlowID);
            Console.WriteLine(approvalflowModel);
            txtAFSLevel.Text = approvalflowModel.Level.ToString();
            txtAFSofCode.Text = approvalflowModel.UserID.ToString();
            txtAFSFunctionName.Text = approvalflowModel.FunctionName;
            txtAFSofName.Text = approvalflowModel.UserName;

            //Update button states
            btnAdd.Enabled = false;
            btnAFSUpdate.Enabled = true;
            btnAFSDelete.Enabled = true;

        }

        private void btnAFSDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm For Delete The selected Item", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                approvalflowService.DeleteFlow(approvalflowModel);
                MessageBox.Show("Flow Deleted");
                btnAFSClear.PerformClick();
            }
        }

        private void ApprovalFlowSetup_Load(object sender, EventArgs e)
        {

            btnAFSClear.PerformClick();
        }

        private void btnAFSHome_Click(object sender, EventArgs e)
        {

            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void lblLoggedUser_Click(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnAFSClear.PerformClick();
        }

        //private void txtAFSFunctionName_KeyUp(object sender, KeyEventArgs e)
        //{
        //    var functionName = txtAFSFunctionName.Text.ToString();
        //    bool check = approvalflowService.isExist(functionName);
        //    if (!check)
        //    {
        //        MessageBox.Show("The entered Function Name does not exist in our system. Please enter a valid Function Name.");
        //    }
        //    var function = approvalflowService.GetFunctionName(functionName);
        //    txtAFSFunctionName.Text = function.ToString();
        //}
    }
    
}
