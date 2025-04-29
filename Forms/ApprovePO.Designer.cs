using System.Drawing;

namespace Inventory_Management_System.Forms
{
    partial class ApprovePO
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
            this.btnAPOClear = new System.Windows.Forms.Button();
            this.btnAPOApprove = new System.Windows.Forms.Button();
            this.dgvAPOList = new System.Windows.Forms.DataGridView();
            this.btnAPOReject = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPOID = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtCPOUnitPrice = new System.Windows.Forms.TextBox();
            this.lblCPOUnitPrice = new System.Windows.Forms.Label();
            this.lblCPONumberOfUnits = new System.Windows.Forms.Label();
            this.txtCPONumberOfUnits = new System.Windows.Forms.TextBox();
            this.lblCPOExDD = new System.Windows.Forms.Label();
            this.dtpCPOExDD = new System.Windows.Forms.DateTimePicker();
            this.txtCPONotes = new System.Windows.Forms.TextBox();
            this.dtpCPOOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblCPONotes = new System.Windows.Forms.Label();
            this.txtCPOSupplierID = new System.Windows.Forms.TextBox();
            this.lblCPOTotalAmount = new System.Windows.Forms.Label();
            this.lblCPOOrderDate = new System.Windows.Forms.Label();
            this.txtCPOCreatedBy = new System.Windows.Forms.TextBox();
            this.lblCPOSupplierID = new System.Windows.Forms.Label();
            this.txtCPOTotalAmount = new System.Windows.Forms.TextBox();
            this.lblCPOCreatedBy = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblPOID = new System.Windows.Forms.Label();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAPOList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAPOClear
            // 
            this.btnAPOClear.BackColor = System.Drawing.Color.Navy;
            this.btnAPOClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPOClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAPOClear.Location = new System.Drawing.Point(487, 259);
            this.btnAPOClear.Name = "btnAPOClear";
            this.btnAPOClear.Size = new System.Drawing.Size(98, 30);
            this.btnAPOClear.TabIndex = 51;
            this.btnAPOClear.Text = "RESET";
            this.btnAPOClear.UseVisualStyleBackColor = false;
            this.btnAPOClear.Click += new System.EventHandler(this.btnAPOClear_Click);
            // 
            // btnAPOApprove
            // 
            this.btnAPOApprove.BackColor = System.Drawing.Color.Navy;
            this.btnAPOApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPOApprove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAPOApprove.Location = new System.Drawing.Point(244, 259);
            this.btnAPOApprove.Name = "btnAPOApprove";
            this.btnAPOApprove.Size = new System.Drawing.Size(98, 30);
            this.btnAPOApprove.TabIndex = 50;
            this.btnAPOApprove.Text = "APPROVE";
            this.btnAPOApprove.UseVisualStyleBackColor = false;
            this.btnAPOApprove.Click += new System.EventHandler(this.btnAPOApprove_Click);
            // 
            // dgvAPOList
            // 
            this.dgvAPOList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAPOList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAPOList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAPOList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAPOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAPOList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAPOList.Location = new System.Drawing.Point(47, 44);
            this.dgvAPOList.Name = "dgvAPOList";
            this.dgvAPOList.ReadOnly = true;
            this.dgvAPOList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAPOList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAPOList.Size = new System.Drawing.Size(832, 163);
            this.dgvAPOList.StandardTab = true;
            this.dgvAPOList.TabIndex = 0;
            this.dgvAPOList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAPOList_CellDoubleClick);
            // 
            // btnAPOReject
            // 
            this.btnAPOReject.BackColor = System.Drawing.Color.Navy;
            this.btnAPOReject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPOReject.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAPOReject.Location = new System.Drawing.Point(369, 259);
            this.btnAPOReject.Name = "btnAPOReject";
            this.btnAPOReject.Size = new System.Drawing.Size(98, 30);
            this.btnAPOReject.TabIndex = 54;
            this.btnAPOReject.Text = "REJECT";
            this.btnAPOReject.UseVisualStyleBackColor = false;
            this.btnAPOReject.Click += new System.EventHandler(this.btnAPOReject_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(836, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 36);
            this.btnExit.TabIndex = 60;
            this.btnExit.Text = "HOME";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtPOID);
            this.panel1.Controls.Add(this.txtSupplierName);
            this.panel1.Controls.Add(this.lblSupplierName);
            this.panel1.Controls.Add(this.lblItemName);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.txtCPOUnitPrice);
            this.panel1.Controls.Add(this.lblCPOUnitPrice);
            this.panel1.Controls.Add(this.lblCPONumberOfUnits);
            this.panel1.Controls.Add(this.txtCPONumberOfUnits);
            this.panel1.Controls.Add(this.lblCPOExDD);
            this.panel1.Controls.Add(this.dtpCPOExDD);
            this.panel1.Controls.Add(this.txtCPONotes);
            this.panel1.Controls.Add(this.dtpCPOOrderDate);
            this.panel1.Controls.Add(this.lblCPONotes);
            this.panel1.Controls.Add(this.txtCPOSupplierID);
            this.panel1.Controls.Add(this.lblCPOTotalAmount);
            this.panel1.Controls.Add(this.lblCPOOrderDate);
            this.panel1.Controls.Add(this.txtCPOCreatedBy);
            this.panel1.Controls.Add(this.lblCPOSupplierID);
            this.panel1.Controls.Add(this.txtCPOTotalAmount);
            this.panel1.Controls.Add(this.lblCPOCreatedBy);
            this.panel1.Controls.Add(this.lblItemID);
            this.panel1.Controls.Add(this.txtItemID);
            this.panel1.Controls.Add(this.lblPOID);
            this.panel1.Controls.Add(this.btnAPOReject);
            this.panel1.Controls.Add(this.btnAPOApprove);
            this.panel1.Controls.Add(this.btnAPOClear);
            this.panel1.Location = new System.Drawing.Point(47, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 321);
            this.panel1.TabIndex = 67;
            // 
            // txtPOID
            // 
            this.txtPOID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPOID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOID.Location = new System.Drawing.Point(31, 50);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.ReadOnly = true;
            this.txtPOID.Size = new System.Drawing.Size(242, 27);
            this.txtPOID.TabIndex = 87;
            this.txtPOID.TabStop = false;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(297, 52);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(242, 27);
            this.txtSupplierName.TabIndex = 86;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.lblSupplierName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(299, 28);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(117, 21);
            this.lblSupplierName.TabIndex = 85;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.SystemColors.Control;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(33, 134);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(90, 21);
            this.lblItemName.TabIndex = 83;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(31, 158);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(242, 27);
            this.txtItemName.TabIndex = 84;
            this.txtItemName.TabStop = false;
            // 
            // txtCPOUnitPrice
            // 
            this.txtCPOUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPOUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPOUnitPrice.Location = new System.Drawing.Point(297, 214);
            this.txtCPOUnitPrice.Name = "txtCPOUnitPrice";
            this.txtCPOUnitPrice.ReadOnly = true;
            this.txtCPOUnitPrice.Size = new System.Drawing.Size(242, 27);
            this.txtCPOUnitPrice.TabIndex = 71;
            this.txtCPOUnitPrice.TabStop = false;
            // 
            // lblCPOUnitPrice
            // 
            this.lblCPOUnitPrice.AutoSize = true;
            this.lblCPOUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOUnitPrice.Location = new System.Drawing.Point(299, 190);
            this.lblCPOUnitPrice.Name = "lblCPOUnitPrice";
            this.lblCPOUnitPrice.Size = new System.Drawing.Size(80, 21);
            this.lblCPOUnitPrice.TabIndex = 67;
            this.lblCPOUnitPrice.Text = "Unit Price:";
            // 
            // lblCPONumberOfUnits
            // 
            this.lblCPONumberOfUnits.AutoSize = true;
            this.lblCPONumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPONumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPONumberOfUnits.Location = new System.Drawing.Point(566, 28);
            this.lblCPONumberOfUnits.Name = "lblCPONumberOfUnits";
            this.lblCPONumberOfUnits.Size = new System.Drawing.Size(132, 21);
            this.lblCPONumberOfUnits.TabIndex = 76;
            this.lblCPONumberOfUnits.Text = "Number Of Units:";
            // 
            // txtCPONumberOfUnits
            // 
            this.txtCPONumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPONumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPONumberOfUnits.Location = new System.Drawing.Point(564, 52);
            this.txtCPONumberOfUnits.Name = "txtCPONumberOfUnits";
            this.txtCPONumberOfUnits.ReadOnly = true;
            this.txtCPONumberOfUnits.Size = new System.Drawing.Size(242, 27);
            this.txtCPONumberOfUnits.TabIndex = 79;
            // 
            // lblCPOExDD
            // 
            this.lblCPOExDD.AutoSize = true;
            this.lblCPOExDD.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOExDD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOExDD.Location = new System.Drawing.Point(299, 136);
            this.lblCPOExDD.Name = "lblCPOExDD";
            this.lblCPOExDD.Size = new System.Drawing.Size(171, 21);
            this.lblCPOExDD.TabIndex = 80;
            this.lblCPOExDD.Text = "Expected Delivery Date:";
            // 
            // dtpCPOExDD
            // 
            this.dtpCPOExDD.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCPOExDD.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCPOExDD.Location = new System.Drawing.Point(297, 160);
            this.dtpCPOExDD.Name = "dtpCPOExDD";
            this.dtpCPOExDD.Size = new System.Drawing.Size(242, 25);
            this.dtpCPOExDD.TabIndex = 82;
            this.dtpCPOExDD.TabStop = false;
            // 
            // txtCPONotes
            // 
            this.txtCPONotes.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPONotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPONotes.Location = new System.Drawing.Point(564, 214);
            this.txtCPONotes.Name = "txtCPONotes";
            this.txtCPONotes.Size = new System.Drawing.Size(242, 27);
            this.txtCPONotes.TabIndex = 78;
            // 
            // dtpCPOOrderDate
            // 
            this.dtpCPOOrderDate.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCPOOrderDate.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCPOOrderDate.Location = new System.Drawing.Point(297, 106);
            this.dtpCPOOrderDate.Name = "dtpCPOOrderDate";
            this.dtpCPOOrderDate.Size = new System.Drawing.Size(242, 25);
            this.dtpCPOOrderDate.TabIndex = 81;
            this.dtpCPOOrderDate.TabStop = false;
            // 
            // lblCPONotes
            // 
            this.lblCPONotes.AutoSize = true;
            this.lblCPONotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPONotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPONotes.Location = new System.Drawing.Point(566, 190);
            this.lblCPONotes.Name = "lblCPONotes";
            this.lblCPONotes.Size = new System.Drawing.Size(54, 21);
            this.lblCPONotes.TabIndex = 75;
            this.lblCPONotes.Text = "Notes:";
            // 
            // txtCPOSupplierID
            // 
            this.txtCPOSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPOSupplierID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPOSupplierID.Location = new System.Drawing.Point(31, 212);
            this.txtCPOSupplierID.Name = "txtCPOSupplierID";
            this.txtCPOSupplierID.ReadOnly = true;
            this.txtCPOSupplierID.Size = new System.Drawing.Size(242, 27);
            this.txtCPOSupplierID.TabIndex = 77;
            this.txtCPOSupplierID.TabStop = false;
            // 
            // lblCPOTotalAmount
            // 
            this.lblCPOTotalAmount.AutoSize = true;
            this.lblCPOTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOTotalAmount.Location = new System.Drawing.Point(566, 82);
            this.lblCPOTotalAmount.Name = "lblCPOTotalAmount";
            this.lblCPOTotalAmount.Size = new System.Drawing.Size(105, 21);
            this.lblCPOTotalAmount.TabIndex = 73;
            this.lblCPOTotalAmount.Text = "Total Amount:";
            // 
            // lblCPOOrderDate
            // 
            this.lblCPOOrderDate.AutoSize = true;
            this.lblCPOOrderDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOOrderDate.Location = new System.Drawing.Point(299, 82);
            this.lblCPOOrderDate.Name = "lblCPOOrderDate";
            this.lblCPOOrderDate.Size = new System.Drawing.Size(90, 21);
            this.lblCPOOrderDate.TabIndex = 66;
            this.lblCPOOrderDate.Text = "Order Date:";
            // 
            // txtCPOCreatedBy
            // 
            this.txtCPOCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPOCreatedBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPOCreatedBy.Location = new System.Drawing.Point(564, 160);
            this.txtCPOCreatedBy.Name = "txtCPOCreatedBy";
            this.txtCPOCreatedBy.ReadOnly = true;
            this.txtCPOCreatedBy.Size = new System.Drawing.Size(242, 27);
            this.txtCPOCreatedBy.TabIndex = 72;
            this.txtCPOCreatedBy.TabStop = false;
            // 
            // lblCPOSupplierID
            // 
            this.lblCPOSupplierID.AutoSize = true;
            this.lblCPOSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOSupplierID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOSupplierID.Location = new System.Drawing.Point(33, 188);
            this.lblCPOSupplierID.Name = "lblCPOSupplierID";
            this.lblCPOSupplierID.Size = new System.Drawing.Size(90, 21);
            this.lblCPOSupplierID.TabIndex = 74;
            this.lblCPOSupplierID.Text = "Supplier ID:";
            // 
            // txtCPOTotalAmount
            // 
            this.txtCPOTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPOTotalAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPOTotalAmount.Location = new System.Drawing.Point(564, 106);
            this.txtCPOTotalAmount.Name = "txtCPOTotalAmount";
            this.txtCPOTotalAmount.ReadOnly = true;
            this.txtCPOTotalAmount.Size = new System.Drawing.Size(242, 27);
            this.txtCPOTotalAmount.TabIndex = 70;
            this.txtCPOTotalAmount.TabStop = false;
            // 
            // lblCPOCreatedBy
            // 
            this.lblCPOCreatedBy.AutoSize = true;
            this.lblCPOCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOCreatedBy.Location = new System.Drawing.Point(566, 136);
            this.lblCPOCreatedBy.Name = "lblCPOCreatedBy";
            this.lblCPOCreatedBy.Size = new System.Drawing.Size(88, 21);
            this.lblCPOCreatedBy.TabIndex = 68;
            this.lblCPOCreatedBy.Text = "Created By:";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.BackColor = System.Drawing.SystemColors.Control;
            this.lblItemID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(33, 80);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(63, 21);
            this.lblItemID.TabIndex = 65;
            this.lblItemID.Text = "Item ID:";
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(31, 104);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(242, 27);
            this.txtItemID.TabIndex = 69;
            this.txtItemID.TabStop = false;
            // 
            // lblPOID
            // 
            this.lblPOID.AutoSize = true;
            this.lblPOID.BackColor = System.Drawing.SystemColors.Control;
            this.lblPOID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOID.Location = new System.Drawing.Point(33, 26);
            this.lblPOID.Name = "lblPOID";
            this.lblPOID.Size = new System.Drawing.Size(53, 21);
            this.lblPOID.TabIndex = 64;
            this.lblPOID.Text = "PO ID:";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(12, 9);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(75, 15);
            this.lblLoggedUser.TabIndex = 68;
            this.lblLoggedUser.Text = "Current User:";
            // 
            // ApprovePO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvAPOList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ApprovePO";
            this.Text = "Approve Purchase Order";
            this.Load += new System.EventHandler(this.ApprovePOForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAPOList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAPOClear;
        private System.Windows.Forms.Button btnAPOApprove;
        private System.Windows.Forms.DataGridView dgvAPOList;
        private System.Windows.Forms.Button btnAPOReject;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtCPOUnitPrice;
        private System.Windows.Forms.Label lblCPOUnitPrice;
        private System.Windows.Forms.Label lblCPONumberOfUnits;
        private System.Windows.Forms.TextBox txtCPONumberOfUnits;
        private System.Windows.Forms.Label lblCPOExDD;
        private System.Windows.Forms.DateTimePicker dtpCPOExDD;
        private System.Windows.Forms.TextBox txtCPONotes;
        private System.Windows.Forms.DateTimePicker dtpCPOOrderDate;
        private System.Windows.Forms.Label lblCPONotes;
        private System.Windows.Forms.TextBox txtCPOSupplierID;
        private System.Windows.Forms.Label lblCPOTotalAmount;
        private System.Windows.Forms.Label lblCPOOrderDate;
        private System.Windows.Forms.TextBox txtCPOCreatedBy;
        private System.Windows.Forms.Label lblCPOSupplierID;
        private System.Windows.Forms.TextBox txtCPOTotalAmount;
        private System.Windows.Forms.Label lblCPOCreatedBy;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblPOID;
        private System.Windows.Forms.TextBox txtPOID;
    }
}