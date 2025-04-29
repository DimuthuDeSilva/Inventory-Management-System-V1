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
    public partial class UserManagement : Form
    {
        User currentUser = new User();
        UserManagementService userService = new UserManagementService();

        public UserManagement()
        {
            InitializeComponent();
        }
        private void btnUMAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateUMInputs()) return;

            try
            {
                // Set user properties based on the table structure
                currentUser.Username = txtumUsername.Text;
                currentUser.Password = txtumPassword.Text; // Note: In production, you should hash this password
                currentUser.FullName = txtumFullName.Text;
                currentUser.Email = txtumEmail.Text; // This can be null according to table structure
                currentUser.Role = txtumRole.Text;
                currentUser.IsActive = ParseStatusInput(txtumStatus.Text);

                // Call the user service to create the user
                userService.CreateUser(currentUser);
                MessageBox.Show("User Created Successfully!");
                btnUMClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}");
            }
        }

        private bool ParseStatusInput(string statusText)
        {
            if (string.IsNullOrWhiteSpace(statusText))
                return false; // Default to false if empty

            // Check for numeric values (1/0)
            if (int.TryParse(statusText, out int numericStatus))
                return numericStatus == 1;

            // Check for boolean strings
            if (bool.TryParse(statusText, out bool boolStatus))
                return boolStatus;

            // Check for active/inactive variations
            return statusText.Trim().Equals("active", StringComparison.OrdinalIgnoreCase) ||
                   statusText.Trim().Equals("yes", StringComparison.OrdinalIgnoreCase) ||
                   statusText.Trim().Equals("y", StringComparison.OrdinalIgnoreCase) ||
                   statusText.Trim() == "1";
        }

        private bool ValidateUMInputs()
        {
            if (String.IsNullOrWhiteSpace(txtumUsername.Text))
            {
                MessageBox.Show("User Name is required");
                txtumUsername.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtumFullName.Text))
            {
                MessageBox.Show("Full Name is required");
                txtumFullName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtumEmail.Text))
            {
                MessageBox.Show("Email is required", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtumEmail.Focus();
                return false;
            }

            try
            {
                var email = new System.Net.Mail.MailAddress(txtumEmail.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtumEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtumPassword.Text))
            {
                MessageBox.Show("Password is required", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtumPassword.Focus();
                return false;
            }

            if (txtumPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtumPassword.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtumRole.Text))
            {
                MessageBox.Show("User Name is required");
                txtumRole.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtumStatus.Text))
            {
                MessageBox.Show("Status is required (1/0, true/false, active/inactive)",
                               "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtumStatus.Focus();
                return false;
            }

            // Try to parse to see if it's a valid status
            try
            {
                // This will throw if the input is completely invalid
                var test = ParseStatusInput(txtumStatus.Text);
            }
            catch
            {
                MessageBox.Show("Status must be one of: 1/0, true/false, active/inactive, yes/no",
                               "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtumStatus.Focus();
                return false;
            }

            return true;
        }

        private void btnUMUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateUMInputs()) return;

            try
            {
                // Set user properties based on the table structure
                currentUser.Username = txtumUsername.Text;
                currentUser.Password = txtumPassword.Text; // Note: In production, you should hash this password
                currentUser.FullName = txtumFullName.Text;
                currentUser.Email = txtumEmail.Text; // This can be null according to table structure
                currentUser.Role = txtumRole.Text;
                currentUser.IsActive = ParseStatusInput(txtumStatus.Text);

                // Call the user service to create the user
                userService.UpdateUser(currentUser);
                MessageBox.Show("User Updated Successfully!");
                btnUMClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}");
            }
        }

        private void btnUMClear_Click_1(object sender, EventArgs e)
        {
            txtUMuserID.Clear();
            txtumEmail.Clear();
            txtumUsername.Clear();
            txtumFullName.Clear();
            txtumStatus.Clear();
            txtumPassword.Clear();
            txtumRole.Clear();
            txtumStatus.Clear();

            btnUMAdd.Enabled = true;
            btnUMUpdate.Enabled = false;

            dgvUMlist.DataSource = userService.GetAllUsers().Tables[0];
        }

        private void dgvUMlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvUMlist.Rows[e.RowIndex].DataBoundItem;

            currentUser.UserID = Convert.ToInt32(row["UserID"]);
            currentUser.Username = row["Username"].ToString();
            currentUser.Password = row["Password"].ToString();
            currentUser.FullName = row["FullName"].ToString();
            currentUser.Email = row["Email"].ToString();
            currentUser.Role = row["Role"].ToString();
            currentUser.IsActive = Convert.ToBoolean(row["IsActive"]);
            currentUser.CreatedAt = Convert.ToDateTime(row["CreatedAt"]);
            currentUser.LastLogin = row["LastLogin"] != DBNull.Value ?
                                  Convert.ToDateTime(row["LastLogin"]) : (DateTime?)null;

            // Populate form fields
            txtUMuserID.Text = currentUser.UserID.ToString();
            txtumUsername.Text = currentUser.Username;
            txtumPassword.Text = currentUser.Password;
            txtumFullName.Text = currentUser.FullName;
            txtumEmail.Text = currentUser.Email;
            txtumRole.Text = currentUser.Role;
            txtumStatus.Text = currentUser.IsActive ? "Active" : "Inactive";
            // Note: You might want to add DateTimePicker controls for CreatedAt and LastLogin if needed

            btnUMAdd.Enabled = false;
            btnUMUpdate.Enabled = true;
        }

        private void btnUMDelete_Click(object sender, EventArgs e)
        {
            if (currentUser.UserID == 0)
            {
                MessageBox.Show("Please select a user");
                return;
            }

            if (MessageBox.Show("Confirm deletion of this User?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    userService.DeleteUser(currentUser.UserID);
                    MessageBox.Show("User deleted successfully");
                    btnUMClear.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}");
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }

        private void UserManagementForm_Load_1(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnUMClear.PerformClick();
        }
    }
}
