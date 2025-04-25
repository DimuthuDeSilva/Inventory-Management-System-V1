using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Models;
using Inventory_Management_System.Services;

namespace Inventory_Management_System.Forms
{
    public partial class Home : Form
    {
        ApprovePOService approvePOService = new ApprovePOService();
        ConfirmGRNservice confirmGRNservice = new ConfirmGRNservice();
        ConfirmMRNservice confirmMRNservice = new ConfirmMRNservice();
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
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
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mstHomeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLandingPage)).BeginInit();
            this.SuspendLayout();
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
            this.approvalFlowToolStripMenuItem.Click += new System.EventHandler(this.approvalFlowToolStripMenuItem_Click);
            // 
            // warehouseSetupToolStripMenuItem
            // 
            this.warehouseSetupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseSetupToolStripMenuItem.Name = "warehouseSetupToolStripMenuItem";
            this.warehouseSetupToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.warehouseSetupToolStripMenuItem.Text = "Warehouse Setup";
            this.warehouseSetupToolStripMenuItem.Click += new System.EventHandler(this.warehouseSetupToolStripMenuItem_Click_1);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
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
            this.createPOToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.createPOToolStripMenuItem.Text = "Create PO";
            this.createPOToolStripMenuItem.Click += new System.EventHandler(this.createPOToolStripMenuItem_Click);
            // 
            // updatePOToolStripMenuItem
            // 
            this.updatePOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePOToolStripMenuItem.Name = "updatePOToolStripMenuItem";
            this.updatePOToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.updatePOToolStripMenuItem.Text = "Update PO";
            // 
            // approvePOToolStripMenuItem
            // 
            this.approvePOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvePOToolStripMenuItem.Name = "approvePOToolStripMenuItem";
            this.approvePOToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.approvePOToolStripMenuItem.Text = "Approve PO";
            this.approvePOToolStripMenuItem.Click += new System.EventHandler(this.approvePOToolStripMenuItem_Click);
            // 
            // cancelPOToolStripMenuItem
            // 
            this.cancelPOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPOToolStripMenuItem.Name = "cancelPOToolStripMenuItem";
            this.cancelPOToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
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
            this.addGRNToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.addGRNToolStripMenuItem.Text = "Add GRN\t";
            this.addGRNToolStripMenuItem.Click += new System.EventHandler(this.addGRNToolStripMenuItem_Click);
            // 
            // confirmGRNToolStripMenuItem
            // 
            this.confirmGRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmGRNToolStripMenuItem.Name = "confirmGRNToolStripMenuItem";
            this.confirmGRNToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.confirmGRNToolStripMenuItem.Text = "Confirm GRN";
            this.confirmGRNToolStripMenuItem.Click += new System.EventHandler(this.confirmGRNToolStripMenuItem_Click);
            // 
            // cancelGRNToolStripMenuItem
            // 
            this.cancelGRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelGRNToolStripMenuItem.Name = "cancelGRNToolStripMenuItem";
            this.cancelGRNToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
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
            this.createPaymentToolStripMenuItem1.Click += new System.EventHandler(this.createPaymentToolStripMenuItem1_Click);
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
            this.addMRNToolStripMenuItem.Click += new System.EventHandler(this.addMRNToolStripMenuItem_Click);
            // 
            // confirmMRNToolStripMenuItem
            // 
            this.confirmMRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmMRNToolStripMenuItem.Name = "confirmMRNToolStripMenuItem";
            this.confirmMRNToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.confirmMRNToolStripMenuItem.Text = "Confirm MRN";
            this.confirmMRNToolStripMenuItem.Click += new System.EventHandler(this.confirmMRNToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
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
            this.lowStockAlerToolStripMenuItem.Click += new System.EventHandler(this.lowStockAlerToolStripMenuItem_Click);
            // 
            // mstHomeMenu
            // 
            this.mstHomeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mstHomeMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.mstHomeMenu.Dock = System.Windows.Forms.DockStyle.None;
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
            this.mstHomeMenu.Location = new System.Drawing.Point(5, 6);
            this.mstHomeMenu.Name = "mstHomeMenu";
            this.mstHomeMenu.Size = new System.Drawing.Size(1279, 28);
            this.mstHomeMenu.TabIndex = 2;
            this.mstHomeMenu.Text = "Home Menu";
            // 
            // pbxLandingPage
            // 
            this.pbxLandingPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLandingPage.BackgroundImage")));
            this.pbxLandingPage.Image = ((System.Drawing.Image)(resources.GetObject("pbxLandingPage.Image")));
            this.pbxLandingPage.Location = new System.Drawing.Point(339, 128);
            this.pbxLandingPage.Name = "pbxLandingPage";
            this.pbxLandingPage.Size = new System.Drawing.Size(685, 387);
            this.pbxLandingPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLandingPage.TabIndex = 3;
            this.pbxLandingPage.TabStop = false;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.ForeColor = System.Drawing.Color.Navy;
            this.lblLoggedUser.Location = new System.Drawing.Point(584, 87);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(42, 21);
            this.lblLoggedUser.TabIndex = 4;
            this.lblLoggedUser.Text = "Hi....";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DimGray;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Location = new System.Drawing.Point(1127, 101);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(80, 36);
            this.btnLogOut.TabIndex = 57;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(1127, 59);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 36);
            this.btnExit.TabIndex = 58;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1439, 633);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.mstHomeMenu);
            this.Controls.Add(this.pbxLandingPage);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
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
        private void warehouseSetupToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void createPOToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void approvePOToolStripMenuItem_Click(object sender, EventArgs e)
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

        private Label lblLoggedUser;
        private void Home_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Welcome, {Session.FullName}";
        }

        private void addGRNToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void confirmGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkaccess = approvePOService.GetAllPurchaseOrders();

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

        private void approvalFlowToolStripMenuItem_Click(object sender, EventArgs e)
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

        private Button btnExit;
        private Button btnLogOut;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void createPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void addMRNToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void confirmMRNToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void lowStockAlerToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
