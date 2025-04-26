using System.Drawing;

namespace Inventory_Management_System.Forms
{
    partial class CreateGRN
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
            this.btnGRNReset = new System.Windows.Forms.Button();
            this.txtGRNSupplierID = new System.Windows.Forms.TextBox();
            this.lblGRNSupplierID = new System.Windows.Forms.Label();
            this.lblGRNTotalCost = new System.Windows.Forms.Label();
            this.txtGRNNumberOfUnits = new System.Windows.Forms.TextBox();
            this.txtGRNUnitPrice = new System.Windows.Forms.TextBox();
            this.txtGRNTotalCost = new System.Windows.Forms.TextBox();
            this.txtGRNPONumber = new System.Windows.Forms.TextBox();
            this.lblNumberOfUnits = new System.Windows.Forms.Label();
            this.lblGRNUnitPrice = new System.Windows.Forms.Label();
            this.lblGRNPONumber = new System.Windows.Forms.Label();
            this.txtGRNID = new System.Windows.Forms.TextBox();
            this.lblGRNID = new System.Windows.Forms.Label();
            this.dgvGRNList = new System.Windows.Forms.DataGridView();
            this.btnGRNAdd = new System.Windows.Forms.Button();
            this.lblDateOfDelivery = new System.Windows.Forms.Label();
            this.dtpDateOfDelivery = new System.Windows.Forms.DateTimePicker();
            this.btnGRNHome = new System.Windows.Forms.Button();
            this.lblGRNsupplierName = new System.Windows.Forms.Label();
            this.txtGRNSupplierName = new System.Windows.Forms.TextBox();
            this.btnGRNUpdate = new System.Windows.Forms.Button();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRNList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGRNReset
            // 
            this.btnGRNReset.BackColor = System.Drawing.Color.Navy;
            this.btnGRNReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGRNReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRNReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGRNReset.Location = new System.Drawing.Point(499, 484);
            this.btnGRNReset.Name = "btnGRNReset";
            this.btnGRNReset.Size = new System.Drawing.Size(90, 30);
            this.btnGRNReset.TabIndex = 51;
            this.btnGRNReset.Text = "RESET";
            this.btnGRNReset.UseVisualStyleBackColor = false;
            this.btnGRNReset.Click += new System.EventHandler(this.btnGRNReset_Click);
            // 
            // txtGRNSupplierID
            // 
            this.txtGRNSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.txtGRNSupplierID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRNSupplierID.Location = new System.Drawing.Point(90, 210);
            this.txtGRNSupplierID.Name = "txtGRNSupplierID";
            this.txtGRNSupplierID.ReadOnly = true;
            this.txtGRNSupplierID.Size = new System.Drawing.Size(242, 27);
            this.txtGRNSupplierID.TabIndex = 46;
            this.txtGRNSupplierID.TabStop = false;
            // 
            // lblGRNSupplierID
            // 
            this.lblGRNSupplierID.AutoSize = true;
            this.lblGRNSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.lblGRNSupplierID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRNSupplierID.Location = new System.Drawing.Point(92, 186);
            this.lblGRNSupplierID.Name = "lblGRNSupplierID";
            this.lblGRNSupplierID.Size = new System.Drawing.Size(90, 21);
            this.lblGRNSupplierID.TabIndex = 42;
            this.lblGRNSupplierID.Text = "Supplier ID:";
            // 
            // lblGRNTotalCost
            // 
            this.lblGRNTotalCost.AutoSize = true;
            this.lblGRNTotalCost.BackColor = System.Drawing.SystemColors.Control;
            this.lblGRNTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRNTotalCost.Location = new System.Drawing.Point(596, 132);
            this.lblGRNTotalCost.Name = "lblGRNTotalCost";
            this.lblGRNTotalCost.Size = new System.Drawing.Size(80, 21);
            this.lblGRNTotalCost.TabIndex = 41;
            this.lblGRNTotalCost.Text = "Total Cost:";
            // 
            // txtGRNNumberOfUnits
            // 
            this.txtGRNNumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.txtGRNNumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRNNumberOfUnits.Location = new System.Drawing.Point(594, 102);
            this.txtGRNNumberOfUnits.Name = "txtGRNNumberOfUnits";
            this.txtGRNNumberOfUnits.Size = new System.Drawing.Size(242, 27);
            this.txtGRNNumberOfUnits.TabIndex = 40;
            // 
            // txtGRNUnitPrice
            // 
            this.txtGRNUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtGRNUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRNUnitPrice.Location = new System.Drawing.Point(340, 185);
            this.txtGRNUnitPrice.Name = "txtGRNUnitPrice";
            this.txtGRNUnitPrice.Size = new System.Drawing.Size(242, 27);
            this.txtGRNUnitPrice.TabIndex = 39;
            // 
            // txtGRNTotalCost
            // 
            this.txtGRNTotalCost.BackColor = System.Drawing.SystemColors.Control;
            this.txtGRNTotalCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRNTotalCost.Location = new System.Drawing.Point(594, 156);
            this.txtGRNTotalCost.Name = "txtGRNTotalCost";
            this.txtGRNTotalCost.ReadOnly = true;
            this.txtGRNTotalCost.Size = new System.Drawing.Size(242, 27);
            this.txtGRNTotalCost.TabIndex = 36;
            this.txtGRNTotalCost.TabStop = false;
            // 
            // txtGRNPONumber
            // 
            this.txtGRNPONumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtGRNPONumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRNPONumber.Location = new System.Drawing.Point(90, 156);
            this.txtGRNPONumber.Name = "txtGRNPONumber";
            this.txtGRNPONumber.Size = new System.Drawing.Size(242, 27);
            this.txtGRNPONumber.TabIndex = 35;
            // 
            // lblNumberOfUnits
            // 
            this.lblNumberOfUnits.AutoSize = true;
            this.lblNumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUnits.Location = new System.Drawing.Point(596, 78);
            this.lblNumberOfUnits.Name = "lblNumberOfUnits";
            this.lblNumberOfUnits.Size = new System.Drawing.Size(132, 21);
            this.lblNumberOfUnits.TabIndex = 34;
            this.lblNumberOfUnits.Text = "Number Of Units:";
            // 
            // lblGRNUnitPrice
            // 
            this.lblGRNUnitPrice.AutoSize = true;
            this.lblGRNUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblGRNUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRNUnitPrice.Location = new System.Drawing.Point(342, 160);
            this.lblGRNUnitPrice.Name = "lblGRNUnitPrice";
            this.lblGRNUnitPrice.Size = new System.Drawing.Size(80, 21);
            this.lblGRNUnitPrice.TabIndex = 33;
            this.lblGRNUnitPrice.Text = "Unit Price:";
            // 
            // lblGRNPONumber
            // 
            this.lblGRNPONumber.AutoSize = true;
            this.lblGRNPONumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblGRNPONumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRNPONumber.Location = new System.Drawing.Point(92, 132);
            this.lblGRNPONumber.Name = "lblGRNPONumber";
            this.lblGRNPONumber.Size = new System.Drawing.Size(96, 21);
            this.lblGRNPONumber.TabIndex = 30;
            this.lblGRNPONumber.Text = "PO Number:";
            // 
            // txtGRNID
            // 
            this.txtGRNID.BackColor = System.Drawing.SystemColors.Control;
            this.txtGRNID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRNID.Location = new System.Drawing.Point(90, 102);
            this.txtGRNID.Name = "txtGRNID";
            this.txtGRNID.ReadOnly = true;
            this.txtGRNID.Size = new System.Drawing.Size(242, 27);
            this.txtGRNID.TabIndex = 29;
            this.txtGRNID.TabStop = false;
            // 
            // lblGRNID
            // 
            this.lblGRNID.AutoSize = true;
            this.lblGRNID.BackColor = System.Drawing.SystemColors.Control;
            this.lblGRNID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRNID.Location = new System.Drawing.Point(92, 78);
            this.lblGRNID.Name = "lblGRNID";
            this.lblGRNID.Size = new System.Drawing.Size(65, 21);
            this.lblGRNID.TabIndex = 28;
            this.lblGRNID.Text = "GRN ID:";
            // 
            // dgvGRNList
            // 
            this.dgvGRNList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGRNList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGRNList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGRNList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvGRNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRNList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGRNList.Location = new System.Drawing.Point(71, 283);
            this.dgvGRNList.Name = "dgvGRNList";
            this.dgvGRNList.ReadOnly = true;
            this.dgvGRNList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvGRNList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGRNList.Size = new System.Drawing.Size(787, 181);
            this.dgvGRNList.StandardTab = true;
            this.dgvGRNList.TabIndex = 0;
            this.dgvGRNList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGRNList_CellDoubleClick);
            // 
            // btnGRNAdd
            // 
            this.btnGRNAdd.BackColor = System.Drawing.Color.Navy;
            this.btnGRNAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGRNAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRNAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGRNAdd.Location = new System.Drawing.Point(308, 484);
            this.btnGRNAdd.Name = "btnGRNAdd";
            this.btnGRNAdd.Size = new System.Drawing.Size(90, 30);
            this.btnGRNAdd.TabIndex = 53;
            this.btnGRNAdd.Text = "ADD";
            this.btnGRNAdd.UseVisualStyleBackColor = false;
            this.btnGRNAdd.Click += new System.EventHandler(this.btnGRNAdd_Click);
            // 
            // lblDateOfDelivery
            // 
            this.lblDateOfDelivery.AutoSize = true;
            this.lblDateOfDelivery.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateOfDelivery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfDelivery.Location = new System.Drawing.Point(596, 186);
            this.lblDateOfDelivery.Name = "lblDateOfDelivery";
            this.lblDateOfDelivery.Size = new System.Drawing.Size(127, 21);
            this.lblDateOfDelivery.TabIndex = 56;
            this.lblDateOfDelivery.Text = "Date Of Delivery:";
            // 
            // dtpDateOfDelivery
            // 
            this.dtpDateOfDelivery.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfDelivery.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfDelivery.Location = new System.Drawing.Point(594, 210);
            this.dtpDateOfDelivery.Name = "dtpDateOfDelivery";
            this.dtpDateOfDelivery.Size = new System.Drawing.Size(242, 25);
            this.dtpDateOfDelivery.TabIndex = 59;
            // 
            // btnGRNHome
            // 
            this.btnGRNHome.BackColor = System.Drawing.Color.DarkRed;
            this.btnGRNHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGRNHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRNHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGRNHome.Location = new System.Drawing.Point(845, 1);
            this.btnGRNHome.Name = "btnGRNHome";
            this.btnGRNHome.Size = new System.Drawing.Size(70, 31);
            this.btnGRNHome.TabIndex = 61;
            this.btnGRNHome.Text = "HOME";
            this.btnGRNHome.UseVisualStyleBackColor = false;
            this.btnGRNHome.Click += new System.EventHandler(this.btnGRNHome_Click);
            // 
            // lblGRNsupplierName
            // 
            this.lblGRNsupplierName.AutoSize = true;
            this.lblGRNsupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.lblGRNsupplierName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRNsupplierName.Location = new System.Drawing.Point(342, 103);
            this.lblGRNsupplierName.Name = "lblGRNsupplierName";
            this.lblGRNsupplierName.Size = new System.Drawing.Size(117, 21);
            this.lblGRNsupplierName.TabIndex = 62;
            this.lblGRNsupplierName.Text = "Supplier Name:";
            // 
            // txtGRNSupplierName
            // 
            this.txtGRNSupplierName.BackColor = System.Drawing.SystemColors.Control;
            this.txtGRNSupplierName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRNSupplierName.Location = new System.Drawing.Point(340, 128);
            this.txtGRNSupplierName.Name = "txtGRNSupplierName";
            this.txtGRNSupplierName.ReadOnly = true;
            this.txtGRNSupplierName.Size = new System.Drawing.Size(242, 27);
            this.txtGRNSupplierName.TabIndex = 63;
            this.txtGRNSupplierName.TabStop = false;
            // 
            // btnGRNUpdate
            // 
            this.btnGRNUpdate.BackColor = System.Drawing.Color.Navy;
            this.btnGRNUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGRNUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRNUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGRNUpdate.Location = new System.Drawing.Point(404, 484);
            this.btnGRNUpdate.Name = "btnGRNUpdate";
            this.btnGRNUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnGRNUpdate.TabIndex = 64;
            this.btnGRNUpdate.Text = "UPDATE";
            this.btnGRNUpdate.UseVisualStyleBackColor = false;
            this.btnGRNUpdate.Click += new System.EventHandler(this.btnGRNUpdate_Click_1);
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(12, 9);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(75, 15);
            this.lblLoggedUser.TabIndex = 66;
            this.lblLoggedUser.Text = "Current User:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(71, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 200);
            this.panel1.TabIndex = 67;
            // 
            // CreateGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.btnGRNUpdate);
            this.Controls.Add(this.txtGRNSupplierName);
            this.Controls.Add(this.lblGRNsupplierName);
            this.Controls.Add(this.btnGRNAdd);
            this.Controls.Add(this.btnGRNReset);
            this.Controls.Add(this.btnGRNHome);
            this.Controls.Add(this.dtpDateOfDelivery);
            this.Controls.Add(this.lblDateOfDelivery);
            this.Controls.Add(this.txtGRNSupplierID);
            this.Controls.Add(this.lblGRNSupplierID);
            this.Controls.Add(this.lblGRNTotalCost);
            this.Controls.Add(this.txtGRNNumberOfUnits);
            this.Controls.Add(this.txtGRNUnitPrice);
            this.Controls.Add(this.txtGRNTotalCost);
            this.Controls.Add(this.txtGRNPONumber);
            this.Controls.Add(this.lblNumberOfUnits);
            this.Controls.Add(this.lblGRNUnitPrice);
            this.Controls.Add(this.lblGRNPONumber);
            this.Controls.Add(this.txtGRNID);
            this.Controls.Add(this.lblGRNID);
            this.Controls.Add(this.dgvGRNList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateGRN";
            this.Text = "Create Good Received Note";
            this.Load += new System.EventHandler(this.CreateGRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRNList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGRNReset;
        private System.Windows.Forms.TextBox txtGRNSupplierID;
        private System.Windows.Forms.Label lblGRNSupplierID;
        private System.Windows.Forms.Label lblGRNTotalCost;
        private System.Windows.Forms.TextBox txtGRNNumberOfUnits;
        private System.Windows.Forms.TextBox txtGRNUnitPrice;
        private System.Windows.Forms.TextBox txtGRNTotalCost;
        private System.Windows.Forms.TextBox txtGRNPONumber;
        private System.Windows.Forms.Label lblNumberOfUnits;
        private System.Windows.Forms.Label lblGRNUnitPrice;
        private System.Windows.Forms.Label lblGRNPONumber;
        private System.Windows.Forms.TextBox txtGRNID;
        private System.Windows.Forms.Label lblGRNID;
        private System.Windows.Forms.DataGridView dgvGRNList;
        private System.Windows.Forms.Button btnGRNAdd;
        private System.Windows.Forms.Label lblDateOfDelivery;
        private System.Windows.Forms.DateTimePicker dtpDateOfDelivery;
        private System.Windows.Forms.Button btnGRNHome;
        private System.Windows.Forms.Label lblGRNsupplierName;
        private System.Windows.Forms.TextBox txtGRNSupplierName;
        private System.Windows.Forms.Button btnGRNUpdate;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Panel panel1;
    }
}