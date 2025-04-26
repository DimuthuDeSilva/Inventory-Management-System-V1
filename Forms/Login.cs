//using System;
//using System.Windows.Forms;
//using InventoryManagementSystem.Service;
//using Inventory_Management_System.Models;
//using Inventory_Management_System.Services;
//namespace Inventory_Management_System.Forms
//{
//    public partial class Login : Form
//    {
//        LoginService login = new LoginService();
//        public Login()
//        {
//            InitializeComponent();
//        }

//        //private void btnLogin_Click(object sender, EventArgs e)
//        //{
//        //    string username = txtUsername.Text.Trim();
//        //    string password = txtPassword.Text.Trim(); // <-- use the correct textbox for password

//        //    var user = login.ValidateUser(username, password);

//        //    if (user != null)
//        //    {
//        //        // Set session variables
//        //        Session.Username = user.Username;
//        //        Session.Role = user.Role;
//        //        Session.UserID = user.UserID;
//        //        Session.Fullname = user.Fullname;

//        //        //MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

//        //        Home mainForm = new Home();
//        //        mainForm.Show();
//        //        this.Hide();
//        //    }
//        //    else
//        //    {
//        //        MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        //    }
//        //}
//        private void btnLogin_Click(object sender, EventArgs e)
//        {
//            string username = txtUsername.Text;
//            string password = txtPassword.Text;

//            UserManagementService userService = new UserManagementService();

//            authenticatedUser = userService.AuthenticateUser(username, password);

//            if (authenticatedUser != null)
//            {
//                // Update last login time
//                userService.UpdateLastLogin(authenticatedUser.UserID);

//                // Store user details in session (if needed)
//                Session.CurrentUser = authenticatedUser;

//                // Redirect to main dashboard
//                MainForm mainForm = new MainForm(authenticatedUser);
//                mainForm.Show();
//                this.Hide();
//            }
//            else
//            {
//                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}
// Login.cs
using System;
using System.Windows.Forms;
using InventoryManagementSystem.Service;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Forms
{
    public partial class Login : Form
    {
        private readonly LoginService _loginService;

        public Login()
        {
            InitializeComponent();
            _loginService = new LoginService();

            // Set password character to hide password
            txtPassword.PasswordChar = '*';

            // Handle Enter key press for login
            txtPassword.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin.PerformClick();
                }
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var authenticatedUser = _loginService.AuthenticateUser(username, password);

                if (authenticatedUser != null)
                {
                    // Update last login time
                    _loginService.UpdateLastLogin(authenticatedUser.UserID);

                    // Store user details in session
                    Session.CurrentUser = authenticatedUser;

                    // Show main form
                    this.Hide();
                    var mainForm = new LandingPage();
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}