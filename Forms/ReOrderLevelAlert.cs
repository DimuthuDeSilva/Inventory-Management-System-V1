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
    public partial class ReorderLevelAlert : Form
    {
        ReOrderLevelModel myreorderModel = new ReOrderLevelModel();
        ReorderAlertService myreorderService = new ReorderAlertService();

        public ReorderLevelAlert()
        {
            InitializeComponent();
        }
        private void btnSTOutProcess_Click(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            //txtStockOutID.Clear();
            //txtMRNID.Clear();
            txtItemID.Clear();
            txtItemName.Clear();
            txtReorderLevelAlert.Clear();
            txtItemStatus.Clear();
            //txtIssuedQuantity.Clear();
            //dtpIssuedDate.Value = DateTime.Now;
            //txtSOSNotes.Clear();

            // Load data and handle access
            var reorderAlert = myreorderService.GetAllReOrderAlerts();

            dgvROLDtList.DataSource = reorderAlert.Tables[0];
        }

        private void dgvSTouttList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView row = (DataRowView)dgvROLDtList.Rows[e.RowIndex].DataBoundItem;

            // Define property for textbox or Model data
            //myStockoutmodel.StockOutID = Convert.ToInt32(row["StockOutID"]);
            myreorderModel.ItemID = Convert.ToInt32(row["ItemID"]);
            myreorderModel.Name = row["ItemName"].ToString();
            myreorderModel.WarehouseID = Convert.ToInt32(row["WarehouseID"]);
            myreorderModel.Quantity = Convert.ToInt32(row["AvailableQuantity"]);
            myreorderModel.ReorderLevel = Convert.ToInt32(row["ReorderLevel"]);
            myreorderModel.IsActive = Convert.ToBoolean(row["IsActive"]);



            // Map to UI controls
            //txtStockOutID.Text = myStockoutmodel.StockOutID.ToString();
            txtItemID.Text = myreorderModel.ItemID.ToString();
            txtItemName.Text = myreorderModel.Name.ToString();
            txtReorderLevelAlert.Text = myreorderModel.ReorderLevel.ToString();
            txtItemStatus.Text = myreorderModel.IsActive.ToString();
            txtROLDAvlQntity.Text = myreorderModel.Quantity.ToString();
            txtlblWarehouseID.Text = myreorderModel.WarehouseID.ToString();
        }

        private void ReorderLevelAlert_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Current User : {Session.FullName}";
            btnRESET.PerformClick();
            btnRESET.Visible = false ;
        }
    }
    
}
