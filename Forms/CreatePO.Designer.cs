using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    partial class CreatePO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCPOClear = new System.Windows.Forms.Button();
            this.btnCPOUpdate = new System.Windows.Forms.Button();
            this.txtCPONumberOfUnits = new System.Windows.Forms.TextBox();
            this.txtCPONotes = new System.Windows.Forms.TextBox();
            this.txtCPOSupplierID = new System.Windows.Forms.TextBox();
            this.lblCPONumberOfUnits = new System.Windows.Forms.Label();
            this.lblCPONotes = new System.Windows.Forms.Label();
            this.lblCPOSupplierID = new System.Windows.Forms.Label();
            this.lblCPOTotalAmount = new System.Windows.Forms.Label();
            this.txtCPOCreatedBy = new System.Windows.Forms.TextBox();
            this.txtCPOUnitPrice = new System.Windows.Forms.TextBox();
            this.txtCPOTotalAmount = new System.Windows.Forms.TextBox();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.lblCPOCreatedBy = new System.Windows.Forms.Label();
            this.lblCPOUnitPrice = new System.Windows.Forms.Label();
            this.lblCPOOrderDate = new System.Windows.Forms.Label();
            this.lblPONumber = new System.Windows.Forms.Label();
            this.txtPOID = new System.Windows.Forms.TextBox();
            this.lblPOID = new System.Windows.Forms.Label();
            this.dgvPOList = new System.Windows.Forms.DataGridView();
            this.btnCPOAdd = new System.Windows.Forms.Button();
            this.btnCPODelete = new System.Windows.Forms.Button();
            this.lblCPOExDD = new System.Windows.Forms.Label();
            this.dtpCPOOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCPOExDD = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCPOClear
            // 
            this.btnCPOClear.BackColor = System.Drawing.Color.Navy;
            this.btnCPOClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPOClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPOClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCPOClear.Location = new System.Drawing.Point(546, 486);
            this.btnCPOClear.Name = "btnCPOClear";
            this.btnCPOClear.Size = new System.Drawing.Size(90, 30);
            this.btnCPOClear.TabIndex = 51;
            this.btnCPOClear.Text = "CLEAR";
            this.btnCPOClear.UseVisualStyleBackColor = false;
            this.btnCPOClear.Click += new System.EventHandler(this.btnCPOClear_Click);
            // 
            // btnCPOUpdate
            // 
            this.btnCPOUpdate.BackColor = System.Drawing.Color.Navy;
            this.btnCPOUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPOUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPOUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCPOUpdate.Location = new System.Drawing.Point(354, 486);
            this.btnCPOUpdate.Name = "btnCPOUpdate";
            this.btnCPOUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnCPOUpdate.TabIndex = 50;
            this.btnCPOUpdate.Text = "UPDATE";
            this.btnCPOUpdate.UseVisualStyleBackColor = false;
            this.btnCPOUpdate.Click += new System.EventHandler(this.btnCPOUpdate_Click);
            // 
            // txtCPONumberOfUnits
            // 
            this.txtCPONumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPONumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPONumberOfUnits.Location = new System.Drawing.Point(294, 185);
            this.txtCPONumberOfUnits.Name = "txtCPONumberOfUnits";
            this.txtCPONumberOfUnits.Size = new System.Drawing.Size(242, 27);
            this.txtCPONumberOfUnits.TabIndex = 49;
            // 
            // txtCPONotes
            // 
            this.txtCPONotes.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPONotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPONotes.Location = new System.Drawing.Point(562, 163);
            this.txtCPONotes.Name = "txtCPONotes";
            this.txtCPONotes.Size = new System.Drawing.Size(242, 27);
            this.txtCPONotes.TabIndex = 48;
            // 
            // txtCPOSupplierID
            // 
            this.txtCPOSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPOSupplierID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPOSupplierID.Location = new System.Drawing.Point(25, 163);
            this.txtCPOSupplierID.Name = "txtCPOSupplierID";
            this.txtCPOSupplierID.Size = new System.Drawing.Size(242, 27);
            this.txtCPOSupplierID.TabIndex = 46;
            // 
            // lblCPONumberOfUnits
            // 
            this.lblCPONumberOfUnits.AutoSize = true;
            this.lblCPONumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPONumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPONumberOfUnits.Location = new System.Drawing.Point(296, 161);
            this.lblCPONumberOfUnits.Name = "lblCPONumberOfUnits";
            this.lblCPONumberOfUnits.Size = new System.Drawing.Size(132, 21);
            this.lblCPONumberOfUnits.TabIndex = 45;
            this.lblCPONumberOfUnits.Text = "Number Of Units:";
            // 
            // lblCPONotes
            // 
            this.lblCPONotes.AutoSize = true;
            this.lblCPONotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPONotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPONotes.Location = new System.Drawing.Point(564, 139);
            this.lblCPONotes.Name = "lblCPONotes";
            this.lblCPONotes.Size = new System.Drawing.Size(54, 21);
            this.lblCPONotes.TabIndex = 43;
            this.lblCPONotes.Text = "Notes:";
            // 
            // lblCPOSupplierID
            // 
            this.lblCPOSupplierID.AutoSize = true;
            this.lblCPOSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOSupplierID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOSupplierID.Location = new System.Drawing.Point(27, 139);
            this.lblCPOSupplierID.Name = "lblCPOSupplierID";
            this.lblCPOSupplierID.Size = new System.Drawing.Size(90, 21);
            this.lblCPOSupplierID.TabIndex = 42;
            this.lblCPOSupplierID.Text = "Supplier ID:";
            // 
            // lblCPOTotalAmount
            // 
            this.lblCPOTotalAmount.AutoSize = true;
            this.lblCPOTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOTotalAmount.Location = new System.Drawing.Point(564, 22);
            this.lblCPOTotalAmount.Name = "lblCPOTotalAmount";
            this.lblCPOTotalAmount.Size = new System.Drawing.Size(105, 21);
            this.lblCPOTotalAmount.TabIndex = 41;
            this.lblCPOTotalAmount.Text = "Total Amount:";
            // 
            // txtCPOCreatedBy
            // 
            this.txtCPOCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPOCreatedBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPOCreatedBy.Location = new System.Drawing.Point(562, 103);
            this.txtCPOCreatedBy.Name = "txtCPOCreatedBy";
            this.txtCPOCreatedBy.Size = new System.Drawing.Size(242, 27);
            this.txtCPOCreatedBy.TabIndex = 40;
            // 
            // txtCPOUnitPrice
            // 
            this.txtCPOUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPOUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPOUnitPrice.Location = new System.Drawing.Point(294, 135);
            this.txtCPOUnitPrice.Name = "txtCPOUnitPrice";
            this.txtCPOUnitPrice.Size = new System.Drawing.Size(242, 27);
            this.txtCPOUnitPrice.TabIndex = 39;
            // 
            // txtCPOTotalAmount
            // 
            this.txtCPOTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtCPOTotalAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPOTotalAmount.Location = new System.Drawing.Point(562, 46);
            this.txtCPOTotalAmount.Name = "txtCPOTotalAmount";
            this.txtCPOTotalAmount.Size = new System.Drawing.Size(242, 27);
            this.txtCPOTotalAmount.TabIndex = 36;
            // 
            // txtPONumber
            // 
            this.txtPONumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtPONumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPONumber.Location = new System.Drawing.Point(25, 103);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(242, 27);
            this.txtPONumber.TabIndex = 35;
            // 
            // lblCPOCreatedBy
            // 
            this.lblCPOCreatedBy.AutoSize = true;
            this.lblCPOCreatedBy.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOCreatedBy.Location = new System.Drawing.Point(564, 79);
            this.lblCPOCreatedBy.Name = "lblCPOCreatedBy";
            this.lblCPOCreatedBy.Size = new System.Drawing.Size(88, 21);
            this.lblCPOCreatedBy.TabIndex = 34;
            this.lblCPOCreatedBy.Text = "Created By:";
            // 
            // lblCPOUnitPrice
            // 
            this.lblCPOUnitPrice.AutoSize = true;
            this.lblCPOUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOUnitPrice.Location = new System.Drawing.Point(296, 111);
            this.lblCPOUnitPrice.Name = "lblCPOUnitPrice";
            this.lblCPOUnitPrice.Size = new System.Drawing.Size(80, 21);
            this.lblCPOUnitPrice.TabIndex = 33;
            this.lblCPOUnitPrice.Text = "Unit Price:";
            // 
            // lblCPOOrderDate
            // 
            this.lblCPOOrderDate.AutoSize = true;
            this.lblCPOOrderDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOOrderDate.Location = new System.Drawing.Point(296, 10);
            this.lblCPOOrderDate.Name = "lblCPOOrderDate";
            this.lblCPOOrderDate.Size = new System.Drawing.Size(90, 21);
            this.lblCPOOrderDate.TabIndex = 32;
            this.lblCPOOrderDate.Text = "Order Date:";
            // 
            // lblPONumber
            // 
            this.lblPONumber.AutoSize = true;
            this.lblPONumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblPONumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPONumber.Location = new System.Drawing.Point(27, 79);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Size = new System.Drawing.Size(96, 21);
            this.lblPONumber.TabIndex = 30;
            this.lblPONumber.Text = "PO Number:";
            // 
            // txtPOID
            // 
            this.txtPOID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPOID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOID.Location = new System.Drawing.Point(25, 46);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Size = new System.Drawing.Size(242, 27);
            this.txtPOID.TabIndex = 29;
            // 
            // lblPOID
            // 
            this.lblPOID.AutoSize = true;
            this.lblPOID.BackColor = System.Drawing.SystemColors.Control;
            this.lblPOID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOID.Location = new System.Drawing.Point(27, 22);
            this.lblPOID.Name = "lblPOID";
            this.lblPOID.Size = new System.Drawing.Size(53, 21);
            this.lblPOID.TabIndex = 28;
            this.lblPOID.Text = "PO ID:";
            // 
            // dgvPOList
            // 
            this.dgvPOList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPOList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPOList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPOList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPOList.Location = new System.Drawing.Point(44, 277);
            this.dgvPOList.Name = "dgvPOList";
            this.dgvPOList.ReadOnly = true;
            this.dgvPOList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPOList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPOList.Size = new System.Drawing.Size(831, 192);
            this.dgvPOList.StandardTab = true;
            this.dgvPOList.TabIndex = 0;
            this.dgvPOList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPOList_CellDoubleClick);
            // 
            // btnCPOAdd
            // 
            this.btnCPOAdd.BackColor = System.Drawing.Color.Navy;
            this.btnCPOAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPOAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPOAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCPOAdd.Location = new System.Drawing.Point(258, 486);
            this.btnCPOAdd.Name = "btnCPOAdd";
            this.btnCPOAdd.Size = new System.Drawing.Size(90, 30);
            this.btnCPOAdd.TabIndex = 53;
            this.btnCPOAdd.Text = "ADD";
            this.btnCPOAdd.UseVisualStyleBackColor = false;
            this.btnCPOAdd.Click += new System.EventHandler(this.btnCPOAdd_Click);
            // 
            // btnCPODelete
            // 
            this.btnCPODelete.BackColor = System.Drawing.Color.Navy;
            this.btnCPODelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPODelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPODelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCPODelete.Location = new System.Drawing.Point(450, 486);
            this.btnCPODelete.Name = "btnCPODelete";
            this.btnCPODelete.Size = new System.Drawing.Size(90, 30);
            this.btnCPODelete.TabIndex = 54;
            this.btnCPODelete.Text = "DELETE";
            this.btnCPODelete.UseVisualStyleBackColor = false;
            this.btnCPODelete.Click += new System.EventHandler(this.btnCPODelete_Click);
            // 
            // lblCPOExDD
            // 
            this.lblCPOExDD.AutoSize = true;
            this.lblCPOExDD.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPOExDD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPOExDD.Location = new System.Drawing.Point(296, 59);
            this.lblCPOExDD.Name = "lblCPOExDD";
            this.lblCPOExDD.Size = new System.Drawing.Size(171, 21);
            this.lblCPOExDD.TabIndex = 56;
            this.lblCPOExDD.Text = "Expected Delivery Date:";
            // 
            // dtpCPOOrderDate
            // 
            this.dtpCPOOrderDate.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCPOOrderDate.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCPOOrderDate.Location = new System.Drawing.Point(294, 34);
            this.dtpCPOOrderDate.Name = "dtpCPOOrderDate";
            this.dtpCPOOrderDate.Size = new System.Drawing.Size(242, 25);
            this.dtpCPOOrderDate.TabIndex = 58;
            // 
            // dtpCPOExDD
            // 
            this.dtpCPOExDD.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCPOExDD.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCPOExDD.Location = new System.Drawing.Point(294, 83);
            this.dtpCPOExDD.Name = "dtpCPOExDD";
            this.dtpCPOExDD.Size = new System.Drawing.Size(242, 25);
            this.dtpCPOExDD.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(847, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 31);
            this.button1.TabIndex = 61;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
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
            this.panel1.Controls.Add(this.lblPONumber);
            this.panel1.Controls.Add(this.txtPONumber);
            this.panel1.Controls.Add(this.txtPOID);
            this.panel1.Controls.Add(this.lblPOID);
            this.panel1.Location = new System.Drawing.Point(44, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 233);
            this.panel1.TabIndex = 64;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(10, 6);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(75, 15);
            this.lblLoggedUser.TabIndex = 66;
            this.lblLoggedUser.Text = "Current User:";
            // 
            // CreatePO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.btnCPODelete);
            this.Controls.Add(this.btnCPOAdd);
            this.Controls.Add(this.btnCPOClear);
            this.Controls.Add(this.btnCPOUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPOList);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreatePO";
            this.Text = "Create Purchase Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreatePO_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCPOClear;
        private System.Windows.Forms.Button btnCPOUpdate;
        private System.Windows.Forms.TextBox txtCPONumberOfUnits;
        private System.Windows.Forms.TextBox txtCPONotes;
        private System.Windows.Forms.TextBox txtCPOSupplierID;
        private System.Windows.Forms.Label lblCPONumberOfUnits;
        private System.Windows.Forms.Label lblCPONotes;
        private System.Windows.Forms.Label lblCPOSupplierID;
        private System.Windows.Forms.Label lblCPOTotalAmount;
        private System.Windows.Forms.TextBox txtCPOCreatedBy;
        private System.Windows.Forms.TextBox txtCPOUnitPrice;
        private System.Windows.Forms.TextBox txtCPOTotalAmount;
        private System.Windows.Forms.TextBox txtPONumber;
        private System.Windows.Forms.Label lblCPOCreatedBy;
        private System.Windows.Forms.Label lblCPOUnitPrice;
        private System.Windows.Forms.Label lblCPOOrderDate;
        private System.Windows.Forms.Label lblPONumber;
        private System.Windows.Forms.TextBox txtPOID;
        private System.Windows.Forms.Label lblPOID;
        private System.Windows.Forms.DataGridView dgvPOList;
        private System.Windows.Forms.Button btnCPOAdd;
        private System.Windows.Forms.Button btnCPODelete;
        private System.Windows.Forms.Label lblCPOExDD;
        private System.Windows.Forms.DateTimePicker dtpCPOOrderDate;
        private System.Windows.Forms.DateTimePicker dtpCPOExDD;
        private System.Windows.Forms.Button button1;
        private Panel panel1;
        private Label lblLoggedUser;
    }
}