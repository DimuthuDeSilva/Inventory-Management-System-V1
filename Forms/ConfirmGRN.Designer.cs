using System.Drawing;

namespace Inventory_Management_System.Forms
{
    partial class ConfirmGRN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncfmGRNClear = new System.Windows.Forms.Button();
            this.btncfmGRNConfirm = new System.Windows.Forms.Button();
            this.txtcfmGRNNotes = new System.Windows.Forms.TextBox();
            this.txtcfmSupplierID = new System.Windows.Forms.TextBox();
            this.lblcfmGRNNotes = new System.Windows.Forms.Label();
            this.lblcfmSupplierID = new System.Windows.Forms.Label();
            this.lblcfmTotalCost = new System.Windows.Forms.Label();
            this.txtcfmSupplierName = new System.Windows.Forms.TextBox();
            this.txtcfmTotalCost = new System.Windows.Forms.TextBox();
            this.lblcfmSupplierName = new System.Windows.Forms.Label();
            this.txtcfmGRNID = new System.Windows.Forms.TextBox();
            this.lblcfmGRNID = new System.Windows.Forms.Label();
            this.dgvcfmGRNList = new System.Windows.Forms.DataGridView();
            this.btncfmGRNReject = new System.Windows.Forms.Button();
            this.lblcfmDateOfDelivery = new System.Windows.Forms.Label();
            this.dtpcfmDateOfDelivery = new System.Windows.Forms.DateTimePicker();
            this.txtcfmUnitPrice = new System.Windows.Forms.TextBox();
            this.lblcfmUnitPrice = new System.Windows.Forms.Label();
            this.btncfmGRNExit = new System.Windows.Forms.Button();
            this.lblcfmNumberOfUnits = new System.Windows.Forms.Label();
            this.txtcfmGRNNumberOfUnits = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.txtPOID = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPOID = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcfmGRNList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncfmGRNClear
            // 
            this.btncfmGRNClear.BackColor = System.Drawing.Color.Navy;
            this.btncfmGRNClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncfmGRNClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btncfmGRNClear.Location = new System.Drawing.Point(553, 235);
            this.btncfmGRNClear.Name = "btncfmGRNClear";
            this.btncfmGRNClear.Size = new System.Drawing.Size(98, 30);
            this.btncfmGRNClear.TabIndex = 51;
            this.btncfmGRNClear.Text = "CLEAR";
            this.btncfmGRNClear.UseVisualStyleBackColor = false;
            this.btncfmGRNClear.Click += new System.EventHandler(this.btncfmGRNClear_Click);
            // 
            // btncfmGRNConfirm
            // 
            this.btncfmGRNConfirm.BackColor = System.Drawing.Color.Navy;
            this.btncfmGRNConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncfmGRNConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btncfmGRNConfirm.Location = new System.Drawing.Point(354, 496);
            this.btncfmGRNConfirm.Name = "btncfmGRNConfirm";
            this.btncfmGRNConfirm.Size = new System.Drawing.Size(98, 30);
            this.btncfmGRNConfirm.TabIndex = 50;
            this.btncfmGRNConfirm.Text = "CONFIRM";
            this.btncfmGRNConfirm.UseVisualStyleBackColor = false;
            this.btncfmGRNConfirm.Click += new System.EventHandler(this.btncfmGRNConfirm_Click);
            // 
            // txtcfmGRNNotes
            // 
            this.txtcfmGRNNotes.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmGRNNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmGRNNotes.Location = new System.Drawing.Point(567, 173);
            this.txtcfmGRNNotes.Name = "txtcfmGRNNotes";
            this.txtcfmGRNNotes.Size = new System.Drawing.Size(242, 27);
            this.txtcfmGRNNotes.TabIndex = 48;
            // 
            // txtcfmSupplierID
            // 
            this.txtcfmSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmSupplierID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmSupplierID.Location = new System.Drawing.Point(21, 164);
            this.txtcfmSupplierID.Name = "txtcfmSupplierID";
            this.txtcfmSupplierID.ReadOnly = true;
            this.txtcfmSupplierID.Size = new System.Drawing.Size(242, 27);
            this.txtcfmSupplierID.TabIndex = 46;
            this.txtcfmSupplierID.TabStop = false;
            // 
            // lblcfmGRNNotes
            // 
            this.lblcfmGRNNotes.AutoSize = true;
            this.lblcfmGRNNotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmGRNNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmGRNNotes.Location = new System.Drawing.Point(569, 149);
            this.lblcfmGRNNotes.Name = "lblcfmGRNNotes";
            this.lblcfmGRNNotes.Size = new System.Drawing.Size(54, 21);
            this.lblcfmGRNNotes.TabIndex = 43;
            this.lblcfmGRNNotes.Text = "Notes:";
            // 
            // lblcfmSupplierID
            // 
            this.lblcfmSupplierID.AutoSize = true;
            this.lblcfmSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmSupplierID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmSupplierID.Location = new System.Drawing.Point(23, 140);
            this.lblcfmSupplierID.Name = "lblcfmSupplierID";
            this.lblcfmSupplierID.Size = new System.Drawing.Size(90, 21);
            this.lblcfmSupplierID.TabIndex = 42;
            this.lblcfmSupplierID.Text = "Supplier ID:";
            // 
            // lblcfmTotalCost
            // 
            this.lblcfmTotalCost.AutoSize = true;
            this.lblcfmTotalCost.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmTotalCost.Location = new System.Drawing.Point(344, 434);
            this.lblcfmTotalCost.Name = "lblcfmTotalCost";
            this.lblcfmTotalCost.Size = new System.Drawing.Size(80, 21);
            this.lblcfmTotalCost.TabIndex = 41;
            this.lblcfmTotalCost.Text = "Total Cost:";
            // 
            // txtcfmSupplierName
            // 
            this.txtcfmSupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmSupplierName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmSupplierName.Location = new System.Drawing.Point(342, 294);
            this.txtcfmSupplierName.Name = "txtcfmSupplierName";
            this.txtcfmSupplierName.ReadOnly = true;
            this.txtcfmSupplierName.Size = new System.Drawing.Size(242, 27);
            this.txtcfmSupplierName.TabIndex = 39;
            this.txtcfmSupplierName.TabStop = false;
            // 
            // txtcfmTotalCost
            // 
            this.txtcfmTotalCost.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmTotalCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmTotalCost.Location = new System.Drawing.Point(342, 458);
            this.txtcfmTotalCost.Name = "txtcfmTotalCost";
            this.txtcfmTotalCost.ReadOnly = true;
            this.txtcfmTotalCost.Size = new System.Drawing.Size(242, 27);
            this.txtcfmTotalCost.TabIndex = 36;
            this.txtcfmTotalCost.TabStop = false;
            // 
            // lblcfmSupplierName
            // 
            this.lblcfmSupplierName.AutoSize = true;
            this.lblcfmSupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmSupplierName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmSupplierName.Location = new System.Drawing.Point(344, 270);
            this.lblcfmSupplierName.Name = "lblcfmSupplierName";
            this.lblcfmSupplierName.Size = new System.Drawing.Size(117, 21);
            this.lblcfmSupplierName.TabIndex = 33;
            this.lblcfmSupplierName.Text = "Supplier Name:";
            // 
            // txtcfmGRNID
            // 
            this.txtcfmGRNID.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmGRNID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmGRNID.Location = new System.Drawing.Point(21, 56);
            this.txtcfmGRNID.Name = "txtcfmGRNID";
            this.txtcfmGRNID.ReadOnly = true;
            this.txtcfmGRNID.Size = new System.Drawing.Size(242, 27);
            this.txtcfmGRNID.TabIndex = 29;
            this.txtcfmGRNID.TabStop = false;
            // 
            // lblcfmGRNID
            // 
            this.lblcfmGRNID.AutoSize = true;
            this.lblcfmGRNID.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmGRNID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmGRNID.Location = new System.Drawing.Point(23, 32);
            this.lblcfmGRNID.Name = "lblcfmGRNID";
            this.lblcfmGRNID.Size = new System.Drawing.Size(65, 21);
            this.lblcfmGRNID.TabIndex = 28;
            this.lblcfmGRNID.Text = "GRN ID:";
            // 
            // dgvcfmGRNList
            // 
            this.dgvcfmGRNList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvcfmGRNList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvcfmGRNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcfmGRNList.Location = new System.Drawing.Point(44, 43);
            this.dgvcfmGRNList.Name = "dgvcfmGRNList";
            this.dgvcfmGRNList.ReadOnly = true;
            this.dgvcfmGRNList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvcfmGRNList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcfmGRNList.Size = new System.Drawing.Size(831, 212);
            this.dgvcfmGRNList.StandardTab = true;
            this.dgvcfmGRNList.TabIndex = 0;
            this.dgvcfmGRNList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcfmGRNList_CellDoubleClick);
            // 
            // btncfmGRNReject
            // 
            this.btncfmGRNReject.BackColor = System.Drawing.Color.Navy;
            this.btncfmGRNReject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncfmGRNReject.ForeColor = System.Drawing.SystemColors.Control;
            this.btncfmGRNReject.Location = new System.Drawing.Point(476, 496);
            this.btncfmGRNReject.Name = "btncfmGRNReject";
            this.btncfmGRNReject.Size = new System.Drawing.Size(98, 30);
            this.btncfmGRNReject.TabIndex = 54;
            this.btncfmGRNReject.Text = "REJECT";
            this.btncfmGRNReject.UseVisualStyleBackColor = false;
            this.btncfmGRNReject.Click += new System.EventHandler(this.btncfmGRNReject_Click);
            // 
            // lblcfmDateOfDelivery
            // 
            this.lblcfmDateOfDelivery.AutoSize = true;
            this.lblcfmDateOfDelivery.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmDateOfDelivery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmDateOfDelivery.Location = new System.Drawing.Point(569, 41);
            this.lblcfmDateOfDelivery.Name = "lblcfmDateOfDelivery";
            this.lblcfmDateOfDelivery.Size = new System.Drawing.Size(127, 21);
            this.lblcfmDateOfDelivery.TabIndex = 56;
            this.lblcfmDateOfDelivery.Text = "Date Of Delivery:";
            // 
            // dtpcfmDateOfDelivery
            // 
            this.dtpcfmDateOfDelivery.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpcfmDateOfDelivery.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpcfmDateOfDelivery.Location = new System.Drawing.Point(567, 65);
            this.dtpcfmDateOfDelivery.Name = "dtpcfmDateOfDelivery";
            this.dtpcfmDateOfDelivery.Size = new System.Drawing.Size(242, 25);
            this.dtpcfmDateOfDelivery.TabIndex = 59;
            this.dtpcfmDateOfDelivery.TabStop = false;
            // 
            // txtcfmUnitPrice
            // 
            this.txtcfmUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmUnitPrice.Location = new System.Drawing.Point(342, 348);
            this.txtcfmUnitPrice.Name = "txtcfmUnitPrice";
            this.txtcfmUnitPrice.ReadOnly = true;
            this.txtcfmUnitPrice.Size = new System.Drawing.Size(242, 27);
            this.txtcfmUnitPrice.TabIndex = 49;
            this.txtcfmUnitPrice.TabStop = false;
            // 
            // lblcfmUnitPrice
            // 
            this.lblcfmUnitPrice.AutoSize = true;
            this.lblcfmUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmUnitPrice.Location = new System.Drawing.Point(344, 324);
            this.lblcfmUnitPrice.Name = "lblcfmUnitPrice";
            this.lblcfmUnitPrice.Size = new System.Drawing.Size(80, 21);
            this.lblcfmUnitPrice.TabIndex = 45;
            this.lblcfmUnitPrice.Text = "Unit Price:";
            // 
            // btncfmGRNExit
            // 
            this.btncfmGRNExit.BackColor = System.Drawing.Color.DarkRed;
            this.btncfmGRNExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncfmGRNExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncfmGRNExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btncfmGRNExit.Location = new System.Drawing.Point(837, 1);
            this.btncfmGRNExit.Name = "btncfmGRNExit";
            this.btncfmGRNExit.Size = new System.Drawing.Size(80, 36);
            this.btncfmGRNExit.TabIndex = 60;
            this.btncfmGRNExit.Text = "HOME";
            this.btncfmGRNExit.UseVisualStyleBackColor = false;
            this.btncfmGRNExit.Click += new System.EventHandler(this.btncfmGRNExit_Click);
            // 
            // lblcfmNumberOfUnits
            // 
            this.lblcfmNumberOfUnits.AutoSize = true;
            this.lblcfmNumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmNumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmNumberOfUnits.Location = new System.Drawing.Point(344, 380);
            this.lblcfmNumberOfUnits.Name = "lblcfmNumberOfUnits";
            this.lblcfmNumberOfUnits.Size = new System.Drawing.Size(132, 21);
            this.lblcfmNumberOfUnits.TabIndex = 61;
            this.lblcfmNumberOfUnits.Text = "Number Of Units:";
            // 
            // txtcfmGRNNumberOfUnits
            // 
            this.txtcfmGRNNumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmGRNNumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmGRNNumberOfUnits.Location = new System.Drawing.Point(342, 404);
            this.txtcfmGRNNumberOfUnits.Name = "txtcfmGRNNumberOfUnits";
            this.txtcfmGRNNumberOfUnits.ReadOnly = true;
            this.txtcfmGRNNumberOfUnits.Size = new System.Drawing.Size(242, 27);
            this.txtcfmGRNNumberOfUnits.TabIndex = 62;
            this.txtcfmGRNNumberOfUnits.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btncfmGRNClear);
            this.panel1.Controls.Add(this.lblcfmGRNID);
            this.panel1.Controls.Add(this.txtcfmGRNID);
            this.panel1.Controls.Add(this.lblcfmSupplierID);
            this.panel1.Controls.Add(this.dtpcfmDateOfDelivery);
            this.panel1.Controls.Add(this.txtcfmSupplierID);
            this.panel1.Controls.Add(this.lblcfmDateOfDelivery);
            this.panel1.Controls.Add(this.txtcfmGRNNotes);
            this.panel1.Controls.Add(this.lblcfmGRNNotes);
            this.panel1.Location = new System.Drawing.Point(44, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 277);
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
            // txtPOID
            // 
            this.txtPOID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPOID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOID.Location = new System.Drawing.Point(108, 43);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Size = new System.Drawing.Size(242, 27);
            this.txtPOID.TabIndex = 75;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.SystemColors.Control;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(116, 178);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(90, 21);
            this.lblItemName.TabIndex = 72;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblPOID
            // 
            this.lblPOID.AutoSize = true;
            this.lblPOID.BackColor = System.Drawing.SystemColors.Control;
            this.lblPOID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOID.Location = new System.Drawing.Point(110, 19);
            this.lblPOID.Name = "lblPOID";
            this.lblPOID.Size = new System.Drawing.Size(53, 21);
            this.lblPOID.TabIndex = 74;
            this.lblPOID.Text = "PO ID:";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(114, 202);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(242, 27);
            this.txtItemName.TabIndex = 73;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.BackColor = System.Drawing.SystemColors.Control;
            this.lblItemID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(110, 70);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(63, 21);
            this.lblItemID.TabIndex = 70;
            this.lblItemID.Text = "Item ID:";
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(108, 94);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(242, 27);
            this.txtItemID.TabIndex = 71;
            // 
            // ConfirmGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.txtPOID);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblPOID);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.btncfmGRNReject);
            this.Controls.Add(this.btncfmGRNConfirm);
            this.Controls.Add(this.txtcfmGRNNumberOfUnits);
            this.Controls.Add(this.lblcfmNumberOfUnits);
            this.Controls.Add(this.btncfmGRNExit);
            this.Controls.Add(this.txtcfmUnitPrice);
            this.Controls.Add(this.lblcfmUnitPrice);
            this.Controls.Add(this.lblcfmTotalCost);
            this.Controls.Add(this.txtcfmSupplierName);
            this.Controls.Add(this.txtcfmTotalCost);
            this.Controls.Add(this.lblcfmSupplierName);
            this.Controls.Add(this.dgvcfmGRNList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfirmGRN";
            this.Text = "Confirm Material Request Note";
            this.Load += new System.EventHandler(this.ConfirmGRNform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcfmGRNList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncfmGRNClear;
        private System.Windows.Forms.Button btncfmGRNConfirm;
        private System.Windows.Forms.TextBox txtcfmGRNNotes;
        private System.Windows.Forms.TextBox txtcfmSupplierID;
        private System.Windows.Forms.Label lblcfmGRNNotes;
        private System.Windows.Forms.Label lblcfmSupplierID;
        private System.Windows.Forms.Label lblcfmTotalCost;
        private System.Windows.Forms.TextBox txtcfmSupplierName;
        private System.Windows.Forms.TextBox txtcfmTotalCost;
        private System.Windows.Forms.Label lblcfmSupplierName;
        private System.Windows.Forms.TextBox txtcfmGRNID;
        private System.Windows.Forms.Label lblcfmGRNID;
        private System.Windows.Forms.DataGridView dgvcfmGRNList;
        private System.Windows.Forms.Button btncfmGRNReject;
        private System.Windows.Forms.Label lblcfmDateOfDelivery;
        private System.Windows.Forms.DateTimePicker dtpcfmDateOfDelivery;
        private System.Windows.Forms.TextBox txtcfmUnitPrice;
        private System.Windows.Forms.Label lblcfmUnitPrice;
        private System.Windows.Forms.Button btncfmGRNExit;
        private System.Windows.Forms.Label lblcfmNumberOfUnits;
        private System.Windows.Forms.TextBox txtcfmGRNNumberOfUnits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.TextBox txtPOID;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPOID;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtItemID;
    }
}