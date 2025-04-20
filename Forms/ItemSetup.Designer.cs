using System.Drawing;

namespace Inventory_Management_System.Forms
{
    partial class ItemSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdWarehouseID = new System.Windows.Forms.TextBox();
            this.txtUpdStatus = new System.Windows.Forms.TextBox();
            this.txtUpdSupplierID = new System.Windows.Forms.TextBox();
            this.lblUpdWarehouseID = new System.Windows.Forms.Label();
            this.lblUpdStatus = new System.Windows.Forms.Label();
            this.lblUpdSupplierID = new System.Windows.Forms.Label();
            this.lblUpdTotalCost = new System.Windows.Forms.Label();
            this.txtUpdUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUpdQuantity = new System.Windows.Forms.TextBox();
            this.txtUpdReorderLevel = new System.Windows.Forms.TextBox();
            this.txtUpdDescription = new System.Windows.Forms.TextBox();
            this.txtUpdTotalCost = new System.Windows.Forms.TextBox();
            this.txtUpdName = new System.Windows.Forms.TextBox();
            this.lblUpdUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdQuantity = new System.Windows.Forms.Label();
            this.lblUpdReorderLevel = new System.Windows.Forms.Label();
            this.lblUpdDescription = new System.Windows.Forms.Label();
            this.lblUpdName = new System.Windows.Forms.Label();
            this.txtUpdItemID = new System.Windows.Forms.TextBox();
            this.lblUpdItemID = new System.Windows.Forms.Label();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mstHomeMenu = new System.Windows.Forms.MenuStrip();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.mstHomeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Sienna;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(1025, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 42);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(1025, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 42);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdWarehouseID
            // 
            this.txtUpdWarehouseID.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdWarehouseID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdWarehouseID.Location = new System.Drawing.Point(631, 278);
            this.txtUpdWarehouseID.Name = "txtUpdWarehouseID";
            this.txtUpdWarehouseID.Size = new System.Drawing.Size(242, 27);
            this.txtUpdWarehouseID.TabIndex = 49;
            // 
            // txtUpdStatus
            // 
            this.txtUpdStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdStatus.Location = new System.Drawing.Point(631, 332);
            this.txtUpdStatus.Name = "txtUpdStatus";
            this.txtUpdStatus.Size = new System.Drawing.Size(242, 27);
            this.txtUpdStatus.TabIndex = 48;
            // 
            // txtUpdSupplierID
            // 
            this.txtUpdSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdSupplierID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdSupplierID.Location = new System.Drawing.Point(200, 332);
            this.txtUpdSupplierID.Name = "txtUpdSupplierID";
            this.txtUpdSupplierID.Size = new System.Drawing.Size(242, 27);
            this.txtUpdSupplierID.TabIndex = 46;
            // 
            // lblUpdWarehouseID
            // 
            this.lblUpdWarehouseID.AutoSize = true;
            this.lblUpdWarehouseID.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdWarehouseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdWarehouseID.Location = new System.Drawing.Point(633, 254);
            this.lblUpdWarehouseID.Name = "lblUpdWarehouseID";
            this.lblUpdWarehouseID.Size = new System.Drawing.Size(110, 21);
            this.lblUpdWarehouseID.TabIndex = 45;
            this.lblUpdWarehouseID.Text = "Warehouse ID:";
            // 
            // lblUpdStatus
            // 
            this.lblUpdStatus.AutoSize = true;
            this.lblUpdStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdStatus.Location = new System.Drawing.Point(633, 308);
            this.lblUpdStatus.Name = "lblUpdStatus";
            this.lblUpdStatus.Size = new System.Drawing.Size(55, 21);
            this.lblUpdStatus.TabIndex = 43;
            this.lblUpdStatus.Text = "Status:";
            // 
            // lblUpdSupplierID
            // 
            this.lblUpdSupplierID.AutoSize = true;
            this.lblUpdSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdSupplierID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdSupplierID.Location = new System.Drawing.Point(202, 308);
            this.lblUpdSupplierID.Name = "lblUpdSupplierID";
            this.lblUpdSupplierID.Size = new System.Drawing.Size(90, 21);
            this.lblUpdSupplierID.TabIndex = 42;
            this.lblUpdSupplierID.Text = "Supplier ID:";
            // 
            // lblUpdTotalCost
            // 
            this.lblUpdTotalCost.AutoSize = true;
            this.lblUpdTotalCost.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdTotalCost.Location = new System.Drawing.Point(633, 200);
            this.lblUpdTotalCost.Name = "lblUpdTotalCost";
            this.lblUpdTotalCost.Size = new System.Drawing.Size(80, 21);
            this.lblUpdTotalCost.TabIndex = 41;
            this.lblUpdTotalCost.Text = "Total Cost:";
            // 
            // txtUpdUnitPrice
            // 
            this.txtUpdUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdUnitPrice.Location = new System.Drawing.Point(631, 170);
            this.txtUpdUnitPrice.Name = "txtUpdUnitPrice";
            this.txtUpdUnitPrice.Size = new System.Drawing.Size(242, 27);
            this.txtUpdUnitPrice.TabIndex = 40;
            // 
            // txtUpdQuantity
            // 
            this.txtUpdQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdQuantity.Location = new System.Drawing.Point(631, 116);
            this.txtUpdQuantity.Name = "txtUpdQuantity";
            this.txtUpdQuantity.Size = new System.Drawing.Size(242, 27);
            this.txtUpdQuantity.TabIndex = 39;
            // 
            // txtUpdReorderLevel
            // 
            this.txtUpdReorderLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdReorderLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdReorderLevel.Location = new System.Drawing.Point(200, 278);
            this.txtUpdReorderLevel.Name = "txtUpdReorderLevel";
            this.txtUpdReorderLevel.Size = new System.Drawing.Size(242, 27);
            this.txtUpdReorderLevel.TabIndex = 38;
            // 
            // txtUpdDescription
            // 
            this.txtUpdDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdDescription.Location = new System.Drawing.Point(200, 224);
            this.txtUpdDescription.Name = "txtUpdDescription";
            this.txtUpdDescription.Size = new System.Drawing.Size(242, 27);
            this.txtUpdDescription.TabIndex = 37;
            // 
            // txtUpdTotalCost
            // 
            this.txtUpdTotalCost.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdTotalCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdTotalCost.Location = new System.Drawing.Point(631, 224);
            this.txtUpdTotalCost.Name = "txtUpdTotalCost";
            this.txtUpdTotalCost.Size = new System.Drawing.Size(242, 27);
            this.txtUpdTotalCost.TabIndex = 36;
            // 
            // txtUpdName
            // 
            this.txtUpdName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdName.Location = new System.Drawing.Point(200, 170);
            this.txtUpdName.Name = "txtUpdName";
            this.txtUpdName.Size = new System.Drawing.Size(242, 27);
            this.txtUpdName.TabIndex = 35;
            // 
            // lblUpdUnitPrice
            // 
            this.lblUpdUnitPrice.AutoSize = true;
            this.lblUpdUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdUnitPrice.Location = new System.Drawing.Point(633, 146);
            this.lblUpdUnitPrice.Name = "lblUpdUnitPrice";
            this.lblUpdUnitPrice.Size = new System.Drawing.Size(80, 21);
            this.lblUpdUnitPrice.TabIndex = 34;
            this.lblUpdUnitPrice.Text = "Unit Price:";
            // 
            // lblUpdQuantity
            // 
            this.lblUpdQuantity.AutoSize = true;
            this.lblUpdQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdQuantity.Location = new System.Drawing.Point(633, 92);
            this.lblUpdQuantity.Name = "lblUpdQuantity";
            this.lblUpdQuantity.Size = new System.Drawing.Size(73, 21);
            this.lblUpdQuantity.TabIndex = 33;
            this.lblUpdQuantity.Text = "Quantity:";
            // 
            // lblUpdReorderLevel
            // 
            this.lblUpdReorderLevel.AutoSize = true;
            this.lblUpdReorderLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdReorderLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdReorderLevel.Location = new System.Drawing.Point(202, 254);
            this.lblUpdReorderLevel.Name = "lblUpdReorderLevel";
            this.lblUpdReorderLevel.Size = new System.Drawing.Size(109, 21);
            this.lblUpdReorderLevel.TabIndex = 32;
            this.lblUpdReorderLevel.Text = "Reorder Level:";
            // 
            // lblUpdDescription
            // 
            this.lblUpdDescription.AutoSize = true;
            this.lblUpdDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdDescription.Location = new System.Drawing.Point(202, 200);
            this.lblUpdDescription.Name = "lblUpdDescription";
            this.lblUpdDescription.Size = new System.Drawing.Size(92, 21);
            this.lblUpdDescription.TabIndex = 31;
            this.lblUpdDescription.Text = "Description:";
            // 
            // lblUpdName
            // 
            this.lblUpdName.AutoSize = true;
            this.lblUpdName.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdName.Location = new System.Drawing.Point(202, 146);
            this.lblUpdName.Name = "lblUpdName";
            this.lblUpdName.Size = new System.Drawing.Size(55, 21);
            this.lblUpdName.TabIndex = 30;
            this.lblUpdName.Text = "Name:";
            // 
            // txtUpdItemID
            // 
            this.txtUpdItemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdItemID.Location = new System.Drawing.Point(200, 116);
            this.txtUpdItemID.Name = "txtUpdItemID";
            this.txtUpdItemID.Size = new System.Drawing.Size(242, 27);
            this.txtUpdItemID.TabIndex = 29;
            // 
            // lblUpdItemID
            // 
            this.lblUpdItemID.AutoSize = true;
            this.lblUpdItemID.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdItemID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdItemID.Location = new System.Drawing.Point(202, 92);
            this.lblUpdItemID.Name = "lblUpdItemID";
            this.lblUpdItemID.Size = new System.Drawing.Size(59, 21);
            this.lblUpdItemID.TabIndex = 28;
            this.lblUpdItemID.Text = "ItemID:";
            // 
            // dgvItemList
            // 
            this.dgvItemList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Location = new System.Drawing.Point(0, 399);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvItemList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemList.Size = new System.Drawing.Size(1314, 234);
            this.dgvItemList.StandardTab = true;
            this.dgvItemList.TabIndex = 0;
            this.dgvItemList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Navy;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(1025, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 42);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(1025, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 42);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.mstHomeMenu.TabIndex = 55;
            this.mstHomeMenu.Text = "Home Menu";
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
            this.createPOToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.createPOToolStripMenuItem.Text = "Create PO";
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
            // 
            // confirmGRNToolStripMenuItem
            // 
            this.confirmGRNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmGRNToolStripMenuItem.Name = "confirmGRNToolStripMenuItem";
            this.confirmGRNToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.confirmGRNToolStripMenuItem.Text = "Confirm GRN";
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
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1298, 633);
            this.Controls.Add(this.mstHomeMenu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUpdWarehouseID);
            this.Controls.Add(this.txtUpdStatus);
            this.Controls.Add(this.txtUpdSupplierID);
            this.Controls.Add(this.lblUpdWarehouseID);
            this.Controls.Add(this.lblUpdStatus);
            this.Controls.Add(this.lblUpdSupplierID);
            this.Controls.Add(this.lblUpdTotalCost);
            this.Controls.Add(this.txtUpdUnitPrice);
            this.Controls.Add(this.txtUpdQuantity);
            this.Controls.Add(this.txtUpdReorderLevel);
            this.Controls.Add(this.txtUpdDescription);
            this.Controls.Add(this.txtUpdTotalCost);
            this.Controls.Add(this.txtUpdName);
            this.Controls.Add(this.lblUpdUnitPrice);
            this.Controls.Add(this.lblUpdQuantity);
            this.Controls.Add(this.lblUpdReorderLevel);
            this.Controls.Add(this.lblUpdDescription);
            this.Controls.Add(this.lblUpdName);
            this.Controls.Add(this.txtUpdItemID);
            this.Controls.Add(this.lblUpdItemID);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemSetup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.mstHomeMenu.ResumeLayout(false);
            this.mstHomeMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdWarehouseID;
        private System.Windows.Forms.TextBox txtUpdStatus;
        private System.Windows.Forms.TextBox txtUpdSupplierID;
        private System.Windows.Forms.Label lblUpdWarehouseID;
        private System.Windows.Forms.Label lblUpdStatus;
        private System.Windows.Forms.Label lblUpdSupplierID;
        private System.Windows.Forms.Label lblUpdTotalCost;
        private System.Windows.Forms.TextBox txtUpdUnitPrice;
        private System.Windows.Forms.TextBox txtUpdQuantity;
        private System.Windows.Forms.TextBox txtUpdReorderLevel;
        private System.Windows.Forms.TextBox txtUpdDescription;
        private System.Windows.Forms.TextBox txtUpdTotalCost;
        private System.Windows.Forms.TextBox txtUpdName;
        private System.Windows.Forms.Label lblUpdUnitPrice;
        private System.Windows.Forms.Label lblUpdQuantity;
        private System.Windows.Forms.Label lblUpdReorderLevel;
        private System.Windows.Forms.Label lblUpdDescription;
        private System.Windows.Forms.Label lblUpdName;
        private System.Windows.Forms.TextBox txtUpdItemID;
        private System.Windows.Forms.Label lblUpdItemID;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip mstHomeMenu;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvalFlowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvePOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodReceivedNoteGRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmGRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelGRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPaymentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem materialRequestNoteMRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmMRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialRequestReturnMRRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMRRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmMRRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRNReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mRNReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mRRReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowStockAlerToolStripMenuItem;
    }
}