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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncfmGRNClear = new System.Windows.Forms.Button();
            this.btncfmGRNConfirm = new System.Windows.Forms.Button();
            this.txtcfmGRNNotes = new System.Windows.Forms.TextBox();
            this.txtcfmSupplierID = new System.Windows.Forms.TextBox();
            this.lblcfmGRNNotes = new System.Windows.Forms.Label();
            this.lblcfmSupplierID = new System.Windows.Forms.Label();
            this.lblcfmTotalCost = new System.Windows.Forms.Label();
            this.txtcfmCreatedBy = new System.Windows.Forms.TextBox();
            this.txtcfmSupplierName = new System.Windows.Forms.TextBox();
            this.txtcfmTotalCost = new System.Windows.Forms.TextBox();
            this.txtcfmPONumber = new System.Windows.Forms.TextBox();
            this.lblcfmCreatedBy = new System.Windows.Forms.Label();
            this.lblcfmSupplierName = new System.Windows.Forms.Label();
            this.lblcfmPONumber = new System.Windows.Forms.Label();
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
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcfmGRNList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncfmGRNClear
            // 
            this.btncfmGRNClear.BackColor = System.Drawing.Color.Navy;
            this.btncfmGRNClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncfmGRNClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btncfmGRNClear.Location = new System.Drawing.Point(877, 171);
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
            this.btncfmGRNConfirm.Location = new System.Drawing.Point(634, 171);
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
            this.txtcfmGRNNotes.Location = new System.Drawing.Point(711, 350);
            this.txtcfmGRNNotes.Name = "txtcfmGRNNotes";
            this.txtcfmGRNNotes.Size = new System.Drawing.Size(242, 27);
            this.txtcfmGRNNotes.TabIndex = 48;
            // 
            // txtcfmSupplierID
            // 
            this.txtcfmSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmSupplierID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmSupplierID.Location = new System.Drawing.Point(42, 404);
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
            this.lblcfmGRNNotes.Location = new System.Drawing.Point(713, 326);
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
            this.lblcfmSupplierID.Location = new System.Drawing.Point(44, 380);
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
            this.lblcfmTotalCost.Location = new System.Drawing.Point(376, 380);
            this.lblcfmTotalCost.Name = "lblcfmTotalCost";
            this.lblcfmTotalCost.Size = new System.Drawing.Size(80, 21);
            this.lblcfmTotalCost.TabIndex = 41;
            this.lblcfmTotalCost.Text = "Total Cost:";
            // 
            // txtcfmCreatedBy
            // 
            this.txtcfmCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmCreatedBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmCreatedBy.Location = new System.Drawing.Point(711, 296);
            this.txtcfmCreatedBy.Name = "txtcfmCreatedBy";
            this.txtcfmCreatedBy.ReadOnly = true;
            this.txtcfmCreatedBy.Size = new System.Drawing.Size(242, 27);
            this.txtcfmCreatedBy.TabIndex = 40;
            this.txtcfmCreatedBy.TabStop = false;
            // 
            // txtcfmSupplierName
            // 
            this.txtcfmSupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmSupplierName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmSupplierName.Location = new System.Drawing.Point(42, 458);
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
            this.txtcfmTotalCost.Location = new System.Drawing.Point(374, 404);
            this.txtcfmTotalCost.Name = "txtcfmTotalCost";
            this.txtcfmTotalCost.ReadOnly = true;
            this.txtcfmTotalCost.Size = new System.Drawing.Size(242, 27);
            this.txtcfmTotalCost.TabIndex = 36;
            this.txtcfmTotalCost.TabStop = false;
            // 
            // txtcfmPONumber
            // 
            this.txtcfmPONumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmPONumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmPONumber.Location = new System.Drawing.Point(42, 350);
            this.txtcfmPONumber.Name = "txtcfmPONumber";
            this.txtcfmPONumber.ReadOnly = true;
            this.txtcfmPONumber.Size = new System.Drawing.Size(242, 27);
            this.txtcfmPONumber.TabIndex = 35;
            this.txtcfmPONumber.TabStop = false;
            // 
            // lblcfmCreatedBy
            // 
            this.lblcfmCreatedBy.AutoSize = true;
            this.lblcfmCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmCreatedBy.Location = new System.Drawing.Point(713, 272);
            this.lblcfmCreatedBy.Name = "lblcfmCreatedBy";
            this.lblcfmCreatedBy.Size = new System.Drawing.Size(88, 21);
            this.lblcfmCreatedBy.TabIndex = 34;
            this.lblcfmCreatedBy.Text = "Created By:";
            // 
            // lblcfmSupplierName
            // 
            this.lblcfmSupplierName.AutoSize = true;
            this.lblcfmSupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmSupplierName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmSupplierName.Location = new System.Drawing.Point(44, 434);
            this.lblcfmSupplierName.Name = "lblcfmSupplierName";
            this.lblcfmSupplierName.Size = new System.Drawing.Size(117, 21);
            this.lblcfmSupplierName.TabIndex = 33;
            this.lblcfmSupplierName.Text = "Supplier Name:";
            // 
            // lblcfmPONumber
            // 
            this.lblcfmPONumber.AutoSize = true;
            this.lblcfmPONumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblcfmPONumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmPONumber.Location = new System.Drawing.Point(44, 326);
            this.lblcfmPONumber.Name = "lblcfmPONumber";
            this.lblcfmPONumber.Size = new System.Drawing.Size(96, 21);
            this.lblcfmPONumber.TabIndex = 30;
            this.lblcfmPONumber.Text = "PO Number:";
            // 
            // txtcfmGRNID
            // 
            this.txtcfmGRNID.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmGRNID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmGRNID.Location = new System.Drawing.Point(42, 296);
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
            this.lblcfmGRNID.Location = new System.Drawing.Point(44, 272);
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
            this.dgvcfmGRNList.Location = new System.Drawing.Point(26, 40);
            this.dgvcfmGRNList.Name = "dgvcfmGRNList";
            this.dgvcfmGRNList.ReadOnly = true;
            this.dgvcfmGRNList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvcfmGRNList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcfmGRNList.Size = new System.Drawing.Size(1000, 212);
            this.dgvcfmGRNList.StandardTab = true;
            this.dgvcfmGRNList.TabIndex = 0;
            this.dgvcfmGRNList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcfmGRNList_CellDoubleClick);
            // 
            // btncfmGRNReject
            // 
            this.btncfmGRNReject.BackColor = System.Drawing.Color.Navy;
            this.btncfmGRNReject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncfmGRNReject.ForeColor = System.Drawing.SystemColors.Control;
            this.btncfmGRNReject.Location = new System.Drawing.Point(759, 171);
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
            this.lblcfmDateOfDelivery.Location = new System.Drawing.Point(376, 432);
            this.lblcfmDateOfDelivery.Name = "lblcfmDateOfDelivery";
            this.lblcfmDateOfDelivery.Size = new System.Drawing.Size(127, 21);
            this.lblcfmDateOfDelivery.TabIndex = 56;
            this.lblcfmDateOfDelivery.Text = "Date Of Delivery:";
            // 
            // dtpcfmDateOfDelivery
            // 
            this.dtpcfmDateOfDelivery.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpcfmDateOfDelivery.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpcfmDateOfDelivery.Location = new System.Drawing.Point(374, 456);
            this.dtpcfmDateOfDelivery.Name = "dtpcfmDateOfDelivery";
            this.dtpcfmDateOfDelivery.Size = new System.Drawing.Size(242, 25);
            this.dtpcfmDateOfDelivery.TabIndex = 59;
            this.dtpcfmDateOfDelivery.TabStop = false;
            // 
            // txtcfmUnitPrice
            // 
            this.txtcfmUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmUnitPrice.Location = new System.Drawing.Point(374, 294);
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
            this.lblcfmUnitPrice.Location = new System.Drawing.Point(376, 270);
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
            this.btncfmGRNExit.Location = new System.Drawing.Point(946, 1);
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
            this.lblcfmNumberOfUnits.Location = new System.Drawing.Point(376, 326);
            this.lblcfmNumberOfUnits.Name = "lblcfmNumberOfUnits";
            this.lblcfmNumberOfUnits.Size = new System.Drawing.Size(132, 21);
            this.lblcfmNumberOfUnits.TabIndex = 61;
            this.lblcfmNumberOfUnits.Text = "Number Of Units:";
            // 
            // txtcfmGRNNumberOfUnits
            // 
            this.txtcfmGRNNumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.txtcfmGRNNumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfmGRNNumberOfUnits.Location = new System.Drawing.Point(374, 350);
            this.txtcfmGRNNumberOfUnits.Name = "txtcfmGRNNumberOfUnits";
            this.txtcfmGRNNumberOfUnits.ReadOnly = true;
            this.txtcfmGRNNumberOfUnits.Size = new System.Drawing.Size(242, 27);
            this.txtcfmGRNNumberOfUnits.TabIndex = 62;
            this.txtcfmGRNNumberOfUnits.TabStop = false;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(12, 11);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(37, 15);
            this.lblLoggedUser.TabIndex = 66;
            this.lblLoggedUser.Text = "label1";
            this.lblLoggedUser.Click += new System.EventHandler(this.lblLoggedUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btncfmGRNClear);
            this.panel1.Controls.Add(this.btncfmGRNConfirm);
            this.panel1.Controls.Add(this.btncfmGRNReject);
            this.panel1.Location = new System.Drawing.Point(26, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 238);
            this.panel1.TabIndex = 67;
            // 
            // ConfirmGRNform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1037, 507);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.txtcfmGRNNumberOfUnits);
            this.Controls.Add(this.lblcfmNumberOfUnits);
            this.Controls.Add(this.btncfmGRNExit);
            this.Controls.Add(this.dtpcfmDateOfDelivery);
            this.Controls.Add(this.lblcfmDateOfDelivery);
            this.Controls.Add(this.txtcfmUnitPrice);
            this.Controls.Add(this.txtcfmGRNNotes);
            this.Controls.Add(this.txtcfmSupplierID);
            this.Controls.Add(this.lblcfmUnitPrice);
            this.Controls.Add(this.lblcfmGRNNotes);
            this.Controls.Add(this.lblcfmSupplierID);
            this.Controls.Add(this.lblcfmTotalCost);
            this.Controls.Add(this.txtcfmCreatedBy);
            this.Controls.Add(this.txtcfmSupplierName);
            this.Controls.Add(this.txtcfmTotalCost);
            this.Controls.Add(this.txtcfmPONumber);
            this.Controls.Add(this.lblcfmCreatedBy);
            this.Controls.Add(this.lblcfmSupplierName);
            this.Controls.Add(this.lblcfmPONumber);
            this.Controls.Add(this.txtcfmGRNID);
            this.Controls.Add(this.lblcfmGRNID);
            this.Controls.Add(this.dgvcfmGRNList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfirmGRNform";
            this.Text = "Confirm Material Request Note";
            this.Load += new System.EventHandler(this.ConfirmGRNform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcfmGRNList)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtcfmCreatedBy;
        private System.Windows.Forms.TextBox txtcfmSupplierName;
        private System.Windows.Forms.TextBox txtcfmTotalCost;
        private System.Windows.Forms.TextBox txtcfmPONumber;
        private System.Windows.Forms.Label lblcfmCreatedBy;
        private System.Windows.Forms.Label lblcfmSupplierName;
        private System.Windows.Forms.Label lblcfmPONumber;
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
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Panel panel1;
    }
}