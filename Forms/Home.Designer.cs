//namespace Inventory_Management_System.Forms
//{
//    partial class Home
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.lblWelcome = new System.Windows.Forms.Label();
//            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
//            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.addItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
//            this.updateItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.warehouseSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.createPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.updatePOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.approvePOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.cancelPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.goodReceivedNoteGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.addGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.confirmGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.cancelGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.createPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.createPaymentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
//            this.materialRequestNoteMRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.addMRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.confirmMRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.materialRequestReturnMRRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.addMRRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.confirmMRRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.pOReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.gRNReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.mRNReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.mRRReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.lowStockAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
//            this.menuStrip1.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // lblWelcome
//            // 
//            this.lblWelcome.AutoSize = true;
//            this.lblWelcome.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblWelcome.Location = new System.Drawing.Point(300, 50);
//            this.lblWelcome.Name = "lblWelcome";
//            this.lblWelcome.Size = new System.Drawing.Size(691, 32);
//            this.lblWelcome.TabIndex = 0;
//            this.lblWelcome.Text = "WELCOME TO INVENTORY MANAGEMENT SYSTEM";
//            // 
//            // menuStrip1
//            // 
//            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.configurationToolStripMenuItem,
//            this.purchaseOrderToolStripMenuItem,
//            this.goodReceivedNoteGRNToolStripMenuItem,
//            this.createPaymentToolStripMenuItem,
//            this.materialRequestNoteMRNToolStripMenuItem,
//            this.materialRequestReturnMRRToolStripMenuItem,
//            this.reportsToolStripMenuItem,
//            this.lowStockAlertToolStripMenuItem});
//            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
//            this.menuStrip1.Name = "menuStrip1";
//            this.menuStrip1.Size = new System.Drawing.Size(1306, 24);
//            this.menuStrip1.TabIndex = 1;
//            this.menuStrip1.Text = "menuStrip1";
//            // 
//            // configurationToolStripMenuItem
//            // 
//            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.itemSetupToolStripMenuItem,
//            this.addItemToolStripMenuItem,
//            this.warehouseSetupToolStripMenuItem,
//            this.userManagementToolStripMenuItem,
//            this.toolStripComboBox1});
//            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
//            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
//            this.configurationToolStripMenuItem.Text = "Configuration";
//            // 
//            // itemSetupToolStripMenuItem
//            // 
//            this.itemSetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.addItemToolStripMenuItem1,
//            this.updateItemToolStripMenuItem});
//            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
//            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.itemSetupToolStripMenuItem.Text = "Item Setup";
//            // 
//            // addItemToolStripMenuItem1
//            // 
//            this.addItemToolStripMenuItem1.Name = "addItemToolStripMenuItem1";
//            this.addItemToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
//            this.addItemToolStripMenuItem1.Text = "Add Item";
//            // 
//            // updateItemToolStripMenuItem
//            // 
//            this.updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
//            this.updateItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.updateItemToolStripMenuItem.Text = "Update Item";
//            // 
//            // addItemToolStripMenuItem
//            // 
//            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
//            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.addItemToolStripMenuItem.Text = "Approval Flow";
//            // 
//            // warehouseSetupToolStripMenuItem
//            // 
//            this.warehouseSetupToolStripMenuItem.Name = "warehouseSetupToolStripMenuItem";
//            this.warehouseSetupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.warehouseSetupToolStripMenuItem.Text = "Warehouse Setup";
//            // 
//            // userManagementToolStripMenuItem
//            // 
//            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
//            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.userManagementToolStripMenuItem.Text = "User Management";
//            // 
//            // purchaseOrderToolStripMenuItem
//            // 
//            this.purchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.createPOToolStripMenuItem,
//            this.updatePOToolStripMenuItem,
//            this.approvePOToolStripMenuItem,
//            this.cancelPOToolStripMenuItem});
//            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
//            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
//            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
//            // 
//            // createPOToolStripMenuItem
//            // 
//            this.createPOToolStripMenuItem.Name = "createPOToolStripMenuItem";
//            this.createPOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.createPOToolStripMenuItem.Text = "Create PO";
//            // 
//            // updatePOToolStripMenuItem
//            // 
//            this.updatePOToolStripMenuItem.Name = "updatePOToolStripMenuItem";
//            this.updatePOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.updatePOToolStripMenuItem.Text = "Update PO";
//            // 
//            // approvePOToolStripMenuItem
//            // 
//            this.approvePOToolStripMenuItem.Name = "approvePOToolStripMenuItem";
//            this.approvePOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.approvePOToolStripMenuItem.Text = "Approve PO";
//            // 
//            // cancelPOToolStripMenuItem
//            // 
//            this.cancelPOToolStripMenuItem.Name = "cancelPOToolStripMenuItem";
//            this.cancelPOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.cancelPOToolStripMenuItem.Text = "Cancel PO";
//            // 
//            // goodReceivedNoteGRNToolStripMenuItem
//            // 
//            this.goodReceivedNoteGRNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.addGRNToolStripMenuItem,
//            this.confirmGRNToolStripMenuItem,
//            this.cancelGRNToolStripMenuItem});
//            this.goodReceivedNoteGRNToolStripMenuItem.Name = "goodReceivedNoteGRNToolStripMenuItem";
//            this.goodReceivedNoteGRNToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
//            this.goodReceivedNoteGRNToolStripMenuItem.Text = "Good Received Note (GRN)";
//            // 
//            // addGRNToolStripMenuItem
//            // 
//            this.addGRNToolStripMenuItem.Name = "addGRNToolStripMenuItem";
//            this.addGRNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.addGRNToolStripMenuItem.Text = "Add GRN";
//            // 
//            // confirmGRNToolStripMenuItem
//            // 
//            this.confirmGRNToolStripMenuItem.Name = "confirmGRNToolStripMenuItem";
//            this.confirmGRNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.confirmGRNToolStripMenuItem.Text = "Confirm GRN";
//            // 
//            // cancelGRNToolStripMenuItem
//            // 
//            this.cancelGRNToolStripMenuItem.Name = "cancelGRNToolStripMenuItem";
//            this.cancelGRNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.cancelGRNToolStripMenuItem.Text = "Cancel GRN";
//            // 
//            // createPaymentToolStripMenuItem
//            // 
//            this.createPaymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.createPaymentToolStripMenuItem1});
//            this.createPaymentToolStripMenuItem.Name = "createPaymentToolStripMenuItem";
//            this.createPaymentToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
//            this.createPaymentToolStripMenuItem.Text = "Create Payment";
//            // 
//            // createPaymentToolStripMenuItem1
//            // 
//            this.createPaymentToolStripMenuItem1.Name = "createPaymentToolStripMenuItem1";
//            this.createPaymentToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
//            this.createPaymentToolStripMenuItem1.Text = "Create Payment";
//            // 
//            // materialRequestNoteMRNToolStripMenuItem
//            // 
//            this.materialRequestNoteMRNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.addMRNToolStripMenuItem,
//            this.confirmMRNToolStripMenuItem,
//            this.stockOutToolStripMenuItem});
//            this.materialRequestNoteMRNToolStripMenuItem.Name = "materialRequestNoteMRNToolStripMenuItem";
//            this.materialRequestNoteMRNToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
//            this.materialRequestNoteMRNToolStripMenuItem.Text = "Material Request Note (MRN)";
//            // 
//            // addMRNToolStripMenuItem
//            // 
//            this.addMRNToolStripMenuItem.Name = "addMRNToolStripMenuItem";
//            this.addMRNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.addMRNToolStripMenuItem.Text = "Add MRN";
//            // 
//            // confirmMRNToolStripMenuItem
//            // 
//            this.confirmMRNToolStripMenuItem.Name = "confirmMRNToolStripMenuItem";
//            this.confirmMRNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.confirmMRNToolStripMenuItem.Text = "Confirm MRN";
//            // 
//            // stockOutToolStripMenuItem
//            // 
//            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
//            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.stockOutToolStripMenuItem.Text = "Stock Out";
//            // 
//            // materialRequestReturnMRRToolStripMenuItem
//            // 
//            this.materialRequestReturnMRRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.addMRRToolStripMenuItem,
//            this.confirmMRRToolStripMenuItem,
//            this.stockInToolStripMenuItem});
//            this.materialRequestReturnMRRToolStripMenuItem.Name = "materialRequestReturnMRRToolStripMenuItem";
//            this.materialRequestReturnMRRToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
//            this.materialRequestReturnMRRToolStripMenuItem.Text = "Material Request Return (MRR)";
//            // 
//            // addMRRToolStripMenuItem
//            // 
//            this.addMRRToolStripMenuItem.Name = "addMRRToolStripMenuItem";
//            this.addMRRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.addMRRToolStripMenuItem.Text = "Add MRR";
//            // 
//            // confirmMRRToolStripMenuItem
//            // 
//            this.confirmMRRToolStripMenuItem.Name = "confirmMRRToolStripMenuItem";
//            this.confirmMRRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.confirmMRRToolStripMenuItem.Text = "Confirm MRR";
//            // 
//            // stockInToolStripMenuItem
//            // 
//            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
//            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.stockInToolStripMenuItem.Text = "Stock In";
//            // 
//            // reportsToolStripMenuItem
//            // 
//            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.stockReportToolStripMenuItem,
//            this.pOReportToolStripMenuItem,
//            this.gRNReportToolStripMenuItem,
//            this.mRNReportToolStripMenuItem,
//            this.mRRReportToolStripMenuItem});
//            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
//            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
//            this.reportsToolStripMenuItem.Text = "Reports";
//            // 
//            // stockReportToolStripMenuItem
//            // 
//            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
//            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.stockReportToolStripMenuItem.Text = "Stock Report";
//            // 
//            // pOReportToolStripMenuItem
//            // 
//            this.pOReportToolStripMenuItem.Name = "pOReportToolStripMenuItem";
//            this.pOReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.pOReportToolStripMenuItem.Text = "PO Report";
//            // 
//            // gRNReportToolStripMenuItem
//            // 
//            this.gRNReportToolStripMenuItem.Name = "gRNReportToolStripMenuItem";
//            this.gRNReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.gRNReportToolStripMenuItem.Text = "GRN Report";
//            // 
//            // mRNReportToolStripMenuItem
//            // 
//            this.mRNReportToolStripMenuItem.Name = "mRNReportToolStripMenuItem";
//            this.mRNReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.mRNReportToolStripMenuItem.Text = "MRN Report";
//            // 
//            // mRRReportToolStripMenuItem
//            // 
//            this.mRRReportToolStripMenuItem.Name = "mRRReportToolStripMenuItem";
//            this.mRRReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
//            this.mRRReportToolStripMenuItem.Text = "MRR Report";
//            // 
//            // lowStockAlertToolStripMenuItem
//            // 
//            this.lowStockAlertToolStripMenuItem.Name = "lowStockAlertToolStripMenuItem";
//            this.lowStockAlertToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
//            this.lowStockAlertToolStripMenuItem.Text = "Low Stock Alert";
//            // 
//            // toolStripComboBox1
//            // 
//            this.toolStripComboBox1.Name = "toolStripComboBox1";
//            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
//            // 
//            // Home
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1306, 633);
//            this.Controls.Add(this.lblWelcome);
//            this.Controls.Add(this.menuStrip1);
//            this.MainMenuStrip = this.menuStrip1;
//            this.Name = "Home";
//            this.Text = "Inventory Management System";
//            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//            this.menuStrip1.ResumeLayout(false);
//            this.menuStrip1.PerformLayout();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label lblWelcome;
//        private System.Windows.Forms.MenuStrip menuStrip1;
//        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem1;
//        private System.Windows.Forms.ToolStripMenuItem updateItemToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem warehouseSetupToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem createPOToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem updatePOToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem approvePOToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem cancelPOToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem goodReceivedNoteGRNToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem addGRNToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem confirmGRNToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem cancelGRNToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem createPaymentToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem createPaymentToolStripMenuItem1;
//        private System.Windows.Forms.ToolStripMenuItem materialRequestNoteMRNToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem addMRNToolStripMenuItem;
//        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
//        private System.Windows.Forms.ToolStripMenuItem confirmMRNToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem materialRequestReturnMRRToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem addMRRToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem confirmMRRToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem pOReportToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem gRNReportToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem mRNReportToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem mRRReportToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem lowStockAlertToolStripMenuItem;
//    }
//}