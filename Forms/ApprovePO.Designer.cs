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
            this.txtAPONotes = new System.Windows.Forms.TextBox();
            this.txtAPOSupplierID = new System.Windows.Forms.TextBox();
            this.lblAPONotes = new System.Windows.Forms.Label();
            this.lblAPOSupplierID = new System.Windows.Forms.Label();
            this.lblAPOTotalAmount = new System.Windows.Forms.Label();
            this.txtAPOCreatedBy = new System.Windows.Forms.TextBox();
            this.txtAPOStatus = new System.Windows.Forms.TextBox();
            this.txtAPOTotalAmount = new System.Windows.Forms.TextBox();
            this.txtAPONumber = new System.Windows.Forms.TextBox();
            this.lblAPOCreatedBy = new System.Windows.Forms.Label();
            this.lblAPOStatus = new System.Windows.Forms.Label();
            this.lblAPOOrderDate = new System.Windows.Forms.Label();
            this.lblAPONumber = new System.Windows.Forms.Label();
            this.txtPOID = new System.Windows.Forms.TextBox();
            this.lblPOID = new System.Windows.Forms.Label();
            this.dgvAPOList = new System.Windows.Forms.DataGridView();
            this.btnAPOReject = new System.Windows.Forms.Button();
            this.lblAPOExDD = new System.Windows.Forms.Label();
            this.dtpAPOOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpAPOExDD = new System.Windows.Forms.DateTimePicker();
            this.txtAPOUnitPrice = new System.Windows.Forms.TextBox();
            this.lblAPOUnitPrice = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAPONumberOfUnits = new System.Windows.Forms.TextBox();
            this.lblAPONumberOfUnits = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // txtAPONotes
            // 
            this.txtAPONotes.BackColor = System.Drawing.SystemColors.Control;
            this.txtAPONotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPONotes.Location = new System.Drawing.Point(566, 213);
            this.txtAPONotes.Name = "txtAPONotes";
            this.txtAPONotes.Size = new System.Drawing.Size(242, 27);
            this.txtAPONotes.TabIndex = 48;
            // 
            // txtAPOSupplierID
            // 
            this.txtAPOSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.txtAPOSupplierID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPOSupplierID.Location = new System.Drawing.Point(68, 373);
            this.txtAPOSupplierID.Name = "txtAPOSupplierID";
            this.txtAPOSupplierID.ReadOnly = true;
            this.txtAPOSupplierID.Size = new System.Drawing.Size(242, 27);
            this.txtAPOSupplierID.TabIndex = 46;
            this.txtAPOSupplierID.TabStop = false;
            // 
            // lblAPONotes
            // 
            this.lblAPONotes.AutoSize = true;
            this.lblAPONotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPONotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPONotes.Location = new System.Drawing.Point(568, 189);
            this.lblAPONotes.Name = "lblAPONotes";
            this.lblAPONotes.Size = new System.Drawing.Size(54, 21);
            this.lblAPONotes.TabIndex = 43;
            this.lblAPONotes.Text = "Notes:";
            // 
            // lblAPOSupplierID
            // 
            this.lblAPOSupplierID.AutoSize = true;
            this.lblAPOSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPOSupplierID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPOSupplierID.Location = new System.Drawing.Point(70, 349);
            this.lblAPOSupplierID.Name = "lblAPOSupplierID";
            this.lblAPOSupplierID.Size = new System.Drawing.Size(90, 21);
            this.lblAPOSupplierID.TabIndex = 42;
            this.lblAPOSupplierID.Text = "Supplier ID:";
            // 
            // lblAPOTotalAmount
            // 
            this.lblAPOTotalAmount.AutoSize = true;
            this.lblAPOTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPOTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPOTotalAmount.Location = new System.Drawing.Point(568, 27);
            this.lblAPOTotalAmount.Name = "lblAPOTotalAmount";
            this.lblAPOTotalAmount.Size = new System.Drawing.Size(105, 21);
            this.lblAPOTotalAmount.TabIndex = 41;
            this.lblAPOTotalAmount.Text = "Total Amount:";
            // 
            // txtAPOCreatedBy
            // 
            this.txtAPOCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtAPOCreatedBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPOCreatedBy.Location = new System.Drawing.Point(566, 105);
            this.txtAPOCreatedBy.Name = "txtAPOCreatedBy";
            this.txtAPOCreatedBy.ReadOnly = true;
            this.txtAPOCreatedBy.Size = new System.Drawing.Size(242, 27);
            this.txtAPOCreatedBy.TabIndex = 40;
            this.txtAPOCreatedBy.TabStop = false;
            // 
            // txtAPOStatus
            // 
            this.txtAPOStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtAPOStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPOStatus.Location = new System.Drawing.Point(566, 159);
            this.txtAPOStatus.Name = "txtAPOStatus";
            this.txtAPOStatus.ReadOnly = true;
            this.txtAPOStatus.Size = new System.Drawing.Size(242, 27);
            this.txtAPOStatus.TabIndex = 39;
            this.txtAPOStatus.TabStop = false;
            // 
            // txtAPOTotalAmount
            // 
            this.txtAPOTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtAPOTotalAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPOTotalAmount.Location = new System.Drawing.Point(566, 51);
            this.txtAPOTotalAmount.Name = "txtAPOTotalAmount";
            this.txtAPOTotalAmount.ReadOnly = true;
            this.txtAPOTotalAmount.Size = new System.Drawing.Size(242, 27);
            this.txtAPOTotalAmount.TabIndex = 36;
            this.txtAPOTotalAmount.TabStop = false;
            // 
            // txtAPONumber
            // 
            this.txtAPONumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtAPONumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPONumber.Location = new System.Drawing.Point(68, 319);
            this.txtAPONumber.Name = "txtAPONumber";
            this.txtAPONumber.ReadOnly = true;
            this.txtAPONumber.Size = new System.Drawing.Size(242, 27);
            this.txtAPONumber.TabIndex = 35;
            this.txtAPONumber.TabStop = false;
            // 
            // lblAPOCreatedBy
            // 
            this.lblAPOCreatedBy.AutoSize = true;
            this.lblAPOCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPOCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPOCreatedBy.Location = new System.Drawing.Point(568, 81);
            this.lblAPOCreatedBy.Name = "lblAPOCreatedBy";
            this.lblAPOCreatedBy.Size = new System.Drawing.Size(88, 21);
            this.lblAPOCreatedBy.TabIndex = 34;
            this.lblAPOCreatedBy.Text = "Created By:";
            // 
            // lblAPOStatus
            // 
            this.lblAPOStatus.AutoSize = true;
            this.lblAPOStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPOStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPOStatus.Location = new System.Drawing.Point(568, 135);
            this.lblAPOStatus.Name = "lblAPOStatus";
            this.lblAPOStatus.Size = new System.Drawing.Size(55, 21);
            this.lblAPOStatus.TabIndex = 33;
            this.lblAPOStatus.Text = "Status:";
            // 
            // lblAPOOrderDate
            // 
            this.lblAPOOrderDate.AutoSize = true;
            this.lblAPOOrderDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPOOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPOOrderDate.Location = new System.Drawing.Point(70, 403);
            this.lblAPOOrderDate.Name = "lblAPOOrderDate";
            this.lblAPOOrderDate.Size = new System.Drawing.Size(90, 21);
            this.lblAPOOrderDate.TabIndex = 32;
            this.lblAPOOrderDate.Text = "Order Date:";
            // 
            // lblAPONumber
            // 
            this.lblAPONumber.AutoSize = true;
            this.lblAPONumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPONumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPONumber.Location = new System.Drawing.Point(70, 295);
            this.lblAPONumber.Name = "lblAPONumber";
            this.lblAPONumber.Size = new System.Drawing.Size(96, 21);
            this.lblAPONumber.TabIndex = 30;
            this.lblAPONumber.Text = "PO Number:";
            // 
            // txtPOID
            // 
            this.txtPOID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPOID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOID.Location = new System.Drawing.Point(68, 265);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.ReadOnly = true;
            this.txtPOID.Size = new System.Drawing.Size(242, 27);
            this.txtPOID.TabIndex = 29;
            this.txtPOID.TabStop = false;
            // 
            // lblPOID
            // 
            this.lblPOID.AutoSize = true;
            this.lblPOID.BackColor = System.Drawing.SystemColors.Control;
            this.lblPOID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOID.Location = new System.Drawing.Point(70, 241);
            this.lblPOID.Name = "lblPOID";
            this.lblPOID.Size = new System.Drawing.Size(53, 21);
            this.lblPOID.TabIndex = 28;
            this.lblPOID.Text = "PO ID:";
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
            // lblAPOExDD
            // 
            this.lblAPOExDD.AutoSize = true;
            this.lblAPOExDD.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPOExDD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPOExDD.Location = new System.Drawing.Point(345, 242);
            this.lblAPOExDD.Name = "lblAPOExDD";
            this.lblAPOExDD.Size = new System.Drawing.Size(171, 21);
            this.lblAPOExDD.TabIndex = 56;
            this.lblAPOExDD.Text = "Expected Delivery Date:";
            // 
            // dtpAPOOrderDate
            // 
            this.dtpAPOOrderDate.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAPOOrderDate.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAPOOrderDate.Location = new System.Drawing.Point(68, 427);
            this.dtpAPOOrderDate.Name = "dtpAPOOrderDate";
            this.dtpAPOOrderDate.Size = new System.Drawing.Size(242, 25);
            this.dtpAPOOrderDate.TabIndex = 58;
            this.dtpAPOOrderDate.TabStop = false;
            // 
            // dtpAPOExDD
            // 
            this.dtpAPOExDD.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAPOExDD.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAPOExDD.Location = new System.Drawing.Point(343, 266);
            this.dtpAPOExDD.Name = "dtpAPOExDD";
            this.dtpAPOExDD.Size = new System.Drawing.Size(242, 25);
            this.dtpAPOExDD.TabIndex = 59;
            this.dtpAPOExDD.TabStop = false;
            // 
            // txtAPOUnitPrice
            // 
            this.txtAPOUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtAPOUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPOUnitPrice.Location = new System.Drawing.Point(343, 333);
            this.txtAPOUnitPrice.Name = "txtAPOUnitPrice";
            this.txtAPOUnitPrice.ReadOnly = true;
            this.txtAPOUnitPrice.Size = new System.Drawing.Size(242, 27);
            this.txtAPOUnitPrice.TabIndex = 49;
            this.txtAPOUnitPrice.TabStop = false;
            // 
            // lblAPOUnitPrice
            // 
            this.lblAPOUnitPrice.AutoSize = true;
            this.lblAPOUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPOUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPOUnitPrice.Location = new System.Drawing.Point(345, 309);
            this.lblAPOUnitPrice.Name = "lblAPOUnitPrice";
            this.lblAPOUnitPrice.Size = new System.Drawing.Size(80, 21);
            this.lblAPOUnitPrice.TabIndex = 45;
            this.lblAPOUnitPrice.Text = "Unit Price:";
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
            // txtAPONumberOfUnits
            // 
            this.txtAPONumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.txtAPONumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPONumberOfUnits.Location = new System.Drawing.Point(343, 396);
            this.txtAPONumberOfUnits.Name = "txtAPONumberOfUnits";
            this.txtAPONumberOfUnits.ReadOnly = true;
            this.txtAPONumberOfUnits.Size = new System.Drawing.Size(242, 27);
            this.txtAPONumberOfUnits.TabIndex = 64;
            this.txtAPONumberOfUnits.TabStop = false;
            // 
            // lblAPONumberOfUnits
            // 
            this.lblAPONumberOfUnits.AutoSize = true;
            this.lblAPONumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPONumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPONumberOfUnits.Location = new System.Drawing.Point(345, 372);
            this.lblAPONumberOfUnits.Name = "lblAPONumberOfUnits";
            this.lblAPONumberOfUnits.Size = new System.Drawing.Size(132, 21);
            this.lblAPONumberOfUnits.TabIndex = 63;
            this.lblAPONumberOfUnits.Text = "Number Of Units:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAPOReject);
            this.panel1.Controls.Add(this.btnAPOApprove);
            this.panel1.Controls.Add(this.btnAPOClear);
            this.panel1.Controls.Add(this.txtAPOTotalAmount);
            this.panel1.Controls.Add(this.lblAPOStatus);
            this.panel1.Controls.Add(this.lblAPOCreatedBy);
            this.panel1.Controls.Add(this.txtAPOStatus);
            this.panel1.Controls.Add(this.txtAPOCreatedBy);
            this.panel1.Controls.Add(this.txtAPONotes);
            this.panel1.Controls.Add(this.lblAPOTotalAmount);
            this.panel1.Controls.Add(this.lblAPONotes);
            this.panel1.Location = new System.Drawing.Point(47, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 321);
            this.panel1.TabIndex = 67;
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
            this.Controls.Add(this.txtAPONumberOfUnits);
            this.Controls.Add(this.lblAPONumberOfUnits);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtpAPOExDD);
            this.Controls.Add(this.dtpAPOOrderDate);
            this.Controls.Add(this.lblAPOExDD);
            this.Controls.Add(this.txtAPOUnitPrice);
            this.Controls.Add(this.txtAPOSupplierID);
            this.Controls.Add(this.lblAPOUnitPrice);
            this.Controls.Add(this.lblAPOSupplierID);
            this.Controls.Add(this.txtAPONumber);
            this.Controls.Add(this.lblAPOOrderDate);
            this.Controls.Add(this.lblAPONumber);
            this.Controls.Add(this.txtPOID);
            this.Controls.Add(this.lblPOID);
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
        private System.Windows.Forms.TextBox txtAPONotes;
        private System.Windows.Forms.TextBox txtAPOSupplierID;
        private System.Windows.Forms.Label lblAPONotes;
        private System.Windows.Forms.Label lblAPOSupplierID;
        private System.Windows.Forms.Label lblAPOTotalAmount;
        private System.Windows.Forms.TextBox txtAPOCreatedBy;
        private System.Windows.Forms.TextBox txtAPOStatus;
        private System.Windows.Forms.TextBox txtAPOTotalAmount;
        private System.Windows.Forms.TextBox txtAPONumber;
        private System.Windows.Forms.Label lblAPOCreatedBy;
        private System.Windows.Forms.Label lblAPOStatus;
        private System.Windows.Forms.Label lblAPOOrderDate;
        private System.Windows.Forms.Label lblAPONumber;
        private System.Windows.Forms.TextBox txtPOID;
        private System.Windows.Forms.Label lblPOID;
        private System.Windows.Forms.DataGridView dgvAPOList;
        private System.Windows.Forms.Button btnAPOReject;
        private System.Windows.Forms.Label lblAPOExDD;
        private System.Windows.Forms.DateTimePicker dtpAPOOrderDate;
        private System.Windows.Forms.DateTimePicker dtpAPOExDD;
        private System.Windows.Forms.TextBox txtAPOUnitPrice;
        private System.Windows.Forms.Label lblAPOUnitPrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAPONumberOfUnits;
        private System.Windows.Forms.Label lblAPONumberOfUnits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoggedUser;
    }
}