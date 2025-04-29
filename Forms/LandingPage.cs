using System;
using System.Windows.Forms;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

namespace Inventory_Management_System.Forms
{
    public partial class LandingPage : Form
    {
        ApprovePOService approvePOService = new ApprovePOService();
        ConfirmGRNservice confirmGRNservice = new ConfirmGRNservice();
        ConfirmMRNservice confirmMRNservice = new ConfirmMRNservice();
        ConfirmMRreturnService myMRRservice = new ConfirmMRreturnService();

        public LandingPage()
        {
            InitializeComponent();
        }

        private void lblItemSetup_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Admin")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                ItemSetup itemSetup = new ItemSetup();
                this.Hide();
                //updateItem.MdiParent = this;
                itemSetup.Show();
            }
        }

        private void lblWareHouse_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Admin")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                WareHouseSetup warehouseSetup = new WareHouseSetup();
                this.Hide();
                warehouseSetup.Show();
            }
        }

        private void lblPOProcess_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Department User")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                CreatePO createPO = new CreatePO();
                this.Hide();
                createPO.Show();
            }
        }

        private void lblApprovePO_Click(object sender, EventArgs e)
        {
            var checkaccess = approvePOService.GetAllPurchaseOrders();

            if (checkaccess == null) // No access
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                ApprovePO approvePOform = new ApprovePO();
                this.Hide();
                approvePOform.Show();
            }
        }

        private void lblGRNProcess_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Department User")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                CreateGRN createGRN = new CreateGRN();
                this.Hide();
                createGRN.Show();
            }
        }

        private void lblConfirmGRN_Click(object sender, EventArgs e)
        {
            var checkaccess = confirmGRNservice.GetAllGRN();

            if (checkaccess == null) // No access
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                ConfirmGRN confirmGRNform = new ConfirmGRN();
                this.Hide();
                confirmGRNform.Show();
            }
        }

        private void lblApprovalFlow_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Admin")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                ApprovalFlowSetup approvalflowSetup = new ApprovalFlowSetup();
                this.Hide();
                approvalflowSetup.Show();
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Admin")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                UserManagement userManagement = new UserManagement();
                this.Hide();
                userManagement.Show();
            }
        }

        private void lblCreatePayment_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Department User")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                CreatePayment createPayment = new CreatePayment();
                this.Hide();
                createPayment.Show();
            }
        }

        private void lblCreateMRN_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Branch User")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                CreateMRN createMRN = new CreateMRN();
                this.Hide();
                createMRN.Show();
            }
        }

        private void lblConfirmMRN_Click(object sender, EventArgs e)
        {
            var checkaccess = confirmMRNservice.GetAllToConfirmMRNs();

            if (checkaccess == null) // No access
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                ConfirmMRN confirmMRNform = new ConfirmMRN();
                this.Hide();
                confirmMRNform.Show();
            }
        }

        private void lblStockOut_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Department User")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                StockOut createStock = new StockOut();
                this.Hide();
                createStock.Show();
            }
        }

        private void lblLowStockAlert_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Department User")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                ReorderLevelAlert reorder = new ReorderLevelAlert();
                this.Hide();
                reorder.Show();
            }
        }

        private void lblStockin_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Department User")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                StockIn stockIn = new StockIn();
                this.Hide();
                stockIn.Show();
            }
        }

        private void lblCreateMRR_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Branch User")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                CreateMRreturn myMRR = new CreateMRreturn();
                this.Hide();
                myMRR.Show();
            }
        }

        private void lblConfirmMRR_Click(object sender, EventArgs e)
        {
            var checkaccess = myMRRservice.GetAllToConfirmMRRs();

            if (checkaccess == null) // No access
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                ConfirmMRN myMRR = new ConfirmMRN();
                this.Hide();
                myMRR.Show();
            }
        }

        private void lblInventoryReport_Click(object sender, EventArgs e)
        {
            if (Session.Role != "Department User" &&
                Session.Role != "Head of Department")
            {
                MessageBox.Show("You don't have permission to access this page");
            }
            else
            {
                StockReport myReport = new StockReport();
                this.Hide();
                myReport.Show();
            }
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Label lblLandLoggedUser;
        private void LandingPage_Load(object sender, EventArgs e)
        {
            lblLandLoggedUser.Text = Session.FullName;
        }
    }
}
