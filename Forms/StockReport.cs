using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Services;

namespace Inventory_Management_System.Forms
{
    public partial class StockReport : Form
    {
        ReportService myReportService = new ReportService();
        public StockReport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var fromDate = dtpFromDate.Value.Date;  // .Date to get just the date part
            var toDate = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1);  // Include entire end date

            try
            {
                DataSet reportData = myReportService.StockReport(fromDate, toDate);
                dgvStockReport.DataSource = reportData.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LandingPage home = new LandingPage();
            home.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
        }
    }
}
