using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AddMenuButton(string text, int x, int y, EventHandler handler)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.Size = new Size(250, 40);
            btn.Font = new Font("Arial", 10);
            btn.Click += handler;
            this.Controls.Add(btn);
        }
        private void OpenConfiguration(object sender, EventArgs e)
        {
            //ConfigurationForm configForm = new ConfigurationForm();
            //configForm.ShowDialog();
        }

        private void OpenAddItem(object sender, EventArgs e)
        {
            //ItemSetupForm itemSetupForm = new ItemSetupForm();
            //itemSetupForm.ShowDialog();
        }

        private Label lblWelcome;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvalFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvePOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodReceivedNoteGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPaymentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialRequestNoteMRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmMRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialRequestReturnMRRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMRRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmMRRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRNReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRNReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRRReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowStockAlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstHomeMenu = new System.Windows.Forms.MenuStrip();
            this.pbxLandingPage = new System.Windows.Forms.PictureBox();
            this.mstHomeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLandingPage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWelcome.Location = new System.Drawing.Point(348, 154);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(691, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME TO INVENTORY MANAGEMENT SYSTEM";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSetupToolStripMenuItem,
            this.approvalFlowToolStripMenuItem,
            this.warehouseSetupToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.configurationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.itemSetupToolStripMenuItem.Text = "Item Setup";
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // approvalFlowToolStripMenuItem
            // 
            this.approvalFlowToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvalFlowToolStripMenuItem.Name = "approvalFlowToolStripMenuItem";
            this.approvalFlowToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.approvalFlowToolStripMenuItem.Text = "Approval Flow\t";
            // 
            // warehouseSetupToolStripMenuItem
            // 
            this.warehouseSetupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseSetupToolStripMenuItem.Name = "warehouseSetupToolStripMenuItem";
            this.warehouseSetupToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.warehouseSetupToolStripMenuItem.Text = "Warehouse Setup";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.purchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPOToolStripMenuItem,
            this.updatePOToolStripMenuItem,
            this.approvePOToolStripMenuItem,
            this.cancelPOToolStripMenuItem});
            this.purchaseOrderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            // 
            // createPOToolStripMenuItem
            // 
            this.createPOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPOToolStripMenuItem.Name = "createPOToolStripMenuItem";
            this.createPOToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.createPOToolStripMenuItem.Text = "Create PO";
            // 
            // updatePOToolStripMenuItem
            // 
            this.updatePOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePOToolStripMenuItem.Name = "updatePOToolStripMenuItem";
            this.updatePOToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.updatePOToolStripMenuItem.Text = "Update PO";
            // 
            // approvePOToolStripMenuItem
            // 
            this.approvePOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvePOToolStripMenuItem.Name = "approvePOToolStripMenuItem";
            this.approvePOToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.approvePOToolStripMenuItem.Text = "Approve PO";
            // 
            // cancelPOToolStripMenuItem
            // 
            this.cancelPOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPOToolStripMenuItem.Name = "cancelPOToolStripMenuItem";
            this.cancelPOToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cancelPOToolStripMenuItem.Text = "Cancel PO";
            // 
            // goodReceivedNoteGRNToolStripMenuItem
            // 
            this.goodReceivedNoteGRNToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goodReceivedNoteGRNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGRNToolStripMenuItem,
            this.confirmGRNToolStripMenuItem,
            this.cancelGRNToolStripMenuItem});
            this.goodReceivedNoteGRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodReceivedNoteGRNToolStripMenuItem.Name = "goodReceivedNoteGRNToolStripMenuItem";
            this.goodReceivedNoteGRNToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.goodReceivedNoteGRNToolStripMenuItem.Text = "Good Received Note (GRN)";
            // 
            // addGRNToolStripMenuItem
            // 
            this.addGRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGRNToolStripMenuItem.Name = "addGRNToolStripMenuItem";
            this.addGRNToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.addGRNToolStripMenuItem.Text = "Add GRN\t";
            // 
            // confirmGRNToolStripMenuItem
            // 
            this.confirmGRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmGRNToolStripMenuItem.Name = "confirmGRNToolStripMenuItem";
            this.confirmGRNToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.confirmGRNToolStripMenuItem.Text = "Confirm GRN";
            // 
            // cancelGRNToolStripMenuItem
            // 
            this.cancelGRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelGRNToolStripMenuItem.Name = "cancelGRNToolStripMenuItem";
            this.cancelGRNToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cancelGRNToolStripMenuItem.Text = "Cancel GRN";
            // 
            // createPaymentToolStripMenuItem
            // 
            this.createPaymentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createPaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPaymentToolStripMenuItem1});
            this.createPaymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPaymentToolStripMenuItem.Name = "createPaymentToolStripMenuItem";
            this.createPaymentToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.createPaymentToolStripMenuItem.Text = "Create Payment";
            // 
            // createPaymentToolStripMenuItem1
            // 
            this.createPaymentToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPaymentToolStripMenuItem1.Name = "createPaymentToolStripMenuItem1";
            this.createPaymentToolStripMenuItem1.Size = new System.Drawing.Size(186, 24);
            this.createPaymentToolStripMenuItem1.Text = "Create Payment";
            // 
            // materialRequestNoteMRNToolStripMenuItem
            // 
            this.materialRequestNoteMRNToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialRequestNoteMRNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMRNToolStripMenuItem,
            this.confirmMRNToolStripMenuItem,
            this.stockOutToolStripMenuItem});
            this.materialRequestNoteMRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRequestNoteMRNToolStripMenuItem.Name = "materialRequestNoteMRNToolStripMenuItem";
            this.materialRequestNoteMRNToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.materialRequestNoteMRNToolStripMenuItem.Text = "Material Request Note (MRN)\t";
            // 
            // addMRNToolStripMenuItem
            // 
            this.addMRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMRNToolStripMenuItem.Name = "addMRNToolStripMenuItem";
            this.addMRNToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.addMRNToolStripMenuItem.Text = "Add MRN";
            // 
            // confirmMRNToolStripMenuItem
            // 
            this.confirmMRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmMRNToolStripMenuItem.Name = "confirmMRNToolStripMenuItem";
            this.confirmMRNToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.confirmMRNToolStripMenuItem.Text = "Confirm MRN";
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            // 
            // materialRequestReturnMRRToolStripMenuItem
            // 
            this.materialRequestReturnMRRToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialRequestReturnMRRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMRRToolStripMenuItem,
            this.confirmMRRToolStripMenuItem,
            this.stockInToolStripMenuItem});
            this.materialRequestReturnMRRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRequestReturnMRRToolStripMenuItem.Name = "materialRequestReturnMRRToolStripMenuItem";
            this.materialRequestReturnMRRToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.materialRequestReturnMRRToolStripMenuItem.Text = "Material Request Return (MRR)";
            // 
            // addMRRToolStripMenuItem
            // 
            this.addMRRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMRRToolStripMenuItem.Name = "addMRRToolStripMenuItem";
            this.addMRRToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.addMRRToolStripMenuItem.Text = "Add MRR";
            // 
            // confirmMRRToolStripMenuItem
            // 
            this.confirmMRRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmMRRToolStripMenuItem.Name = "confirmMRRToolStripMenuItem";
            this.confirmMRRToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.confirmMRRToolStripMenuItem.Text = "Confirm MRR";
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.stockInToolStripMenuItem.Text = "Stock In";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockReportToolStripMenuItem,
            this.pOReportToolStripMenuItem,
            this.gRNReportToolStripMenuItem,
            this.mRNReportToolStripMenuItem,
            this.mRRReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.stockReportToolStripMenuItem.Text = "Stock Report";
            // 
            // pOReportToolStripMenuItem
            // 
            this.pOReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOReportToolStripMenuItem.Name = "pOReportToolStripMenuItem";
            this.pOReportToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.pOReportToolStripMenuItem.Text = "PO Report";
            // 
            // gRNReportToolStripMenuItem
            // 
            this.gRNReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gRNReportToolStripMenuItem.Name = "gRNReportToolStripMenuItem";
            this.gRNReportToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.gRNReportToolStripMenuItem.Text = "GRN Report";
            // 
            // mRNReportToolStripMenuItem
            // 
            this.mRNReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRNReportToolStripMenuItem.Name = "mRNReportToolStripMenuItem";
            this.mRNReportToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.mRNReportToolStripMenuItem.Text = "MRN Report";
            // 
            // mRRReportToolStripMenuItem
            // 
            this.mRRReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRRReportToolStripMenuItem.Name = "mRRReportToolStripMenuItem";
            this.mRRReportToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.mRRReportToolStripMenuItem.Text = "MRR Report";
            // 
            // lowStockAlerToolStripMenuItem
            // 
            this.lowStockAlerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lowStockAlerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowStockAlerToolStripMenuItem.Name = "lowStockAlerToolStripMenuItem";
            this.lowStockAlerToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.lowStockAlerToolStripMenuItem.Text = "Low Stock Alert";
            // 
            // mstHomeMenu
            // 
            this.mstHomeMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mstHomeMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstHomeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.goodReceivedNoteGRNToolStripMenuItem,
            this.createPaymentToolStripMenuItem,
            this.materialRequestNoteMRNToolStripMenuItem,
            this.materialRequestReturnMRRToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.lowStockAlerToolStripMenuItem});
            this.mstHomeMenu.Location = new System.Drawing.Point(0, 0);
            this.mstHomeMenu.Name = "mstHomeMenu";
            this.mstHomeMenu.Size = new System.Drawing.Size(1298, 28);
            this.mstHomeMenu.TabIndex = 2;
            this.mstHomeMenu.Text = "Home Menu";
            // 
            // pbxLandingPage
            // 
            this.pbxLandingPage.Image = ((System.Drawing.Image)(resources.GetObject("pbxLandingPage.Image")));
            this.pbxLandingPage.Location = new System.Drawing.Point(352, 224);
            this.pbxLandingPage.Name = "pbxLandingPage";
            this.pbxLandingPage.Size = new System.Drawing.Size(685, 263);
            this.pbxLandingPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLandingPage.TabIndex = 3;
            this.pbxLandingPage.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1298, 633);
            this.Controls.Add(this.pbxLandingPage);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.mstHomeMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.Text = "Inventory Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mstHomeMenu.ResumeLayout(false);
            this.mstHomeMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLandingPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private IContainer components;
        private ToolStripMenuItem configurationToolStripMenuItem;
        private ToolStripMenuItem itemSetupToolStripMenuItem;
        private ToolStripMenuItem approvalFlowToolStripMenuItem;
        private ToolStripMenuItem warehouseSetupToolStripMenuItem;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private ToolStripMenuItem createPOToolStripMenuItem;
        private ToolStripMenuItem updatePOToolStripMenuItem;
        private ToolStripMenuItem approvePOToolStripMenuItem;
        private ToolStripMenuItem cancelPOToolStripMenuItem;
        private ToolStripMenuItem goodReceivedNoteGRNToolStripMenuItem;
        private ToolStripMenuItem addGRNToolStripMenuItem;
        private ToolStripMenuItem confirmGRNToolStripMenuItem;
        private ToolStripMenuItem cancelGRNToolStripMenuItem;
        private ToolStripMenuItem createPaymentToolStripMenuItem;
        private ToolStripMenuItem createPaymentToolStripMenuItem1;
        private ToolStripMenuItem materialRequestNoteMRNToolStripMenuItem;
        private ToolStripMenuItem addMRNToolStripMenuItem;
        private ToolStripMenuItem confirmMRNToolStripMenuItem;
        private ToolStripMenuItem stockOutToolStripMenuItem;
        private ToolStripMenuItem materialRequestReturnMRRToolStripMenuItem;
        private ToolStripMenuItem addMRRToolStripMenuItem;
        private ToolStripMenuItem confirmMRRToolStripMenuItem;
        private ToolStripMenuItem stockInToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem stockReportToolStripMenuItem;
        private ToolStripMenuItem pOReportToolStripMenuItem;
        private ToolStripMenuItem gRNReportToolStripMenuItem;
        private ToolStripMenuItem mRNReportToolStripMenuItem;
        private ToolStripMenuItem mRRReportToolStripMenuItem;
        private ToolStripMenuItem lowStockAlerToolStripMenuItem;
        private MenuStrip mstHomeMenu;
        private PictureBox pbxLandingPage;

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSetup updateItem = new ItemSetup();
            this.Hide();
            //updateItem.MdiParent = this;
            updateItem.Show();
        }
    }
}
