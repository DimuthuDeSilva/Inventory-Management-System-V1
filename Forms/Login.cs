using System;
using System.Windows.Forms;
using InventoryManagementSystem.Service;

namespace Inventory_Management_System.Forms
{
    public partial class Login : Form
    {
        LoginService login = new LoginService();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim(); // <-- use the correct textbox for password

            if (login.ValidateUser(username, password))
            {

                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
