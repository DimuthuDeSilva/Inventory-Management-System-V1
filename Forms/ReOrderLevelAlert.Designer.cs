using System.Drawing;

namespace Inventory_Management_System.Forms
{
    partial class ReorderLevelAlert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItemStatus = new System.Windows.Forms.TextBox();
            this.lblROLItemStatus = new System.Windows.Forms.Label();
            this.dgvROLDtList = new System.Windows.Forms.DataGridView();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtReorderLevelAlert = new System.Windows.Forms.TextBox();
            this.lblReOrderLevel = new System.Windows.Forms.Label();
            this.lblAvlQuantity = new System.Windows.Forms.Label();
            this.lblWarehouseID = new System.Windows.Forms.Label();
            this.txtlblWarehouseID = new System.Windows.Forms.TextBox();
            this.txtROLDAvlQntity = new System.Windows.Forms.TextBox();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRESET = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvROLDtList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(33, 45);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(242, 27);
            this.txtItemID.TabIndex = 46;
            this.txtItemID.TabStop = false;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.BackColor = System.Drawing.SystemColors.Control;
            this.lblItemID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(35, 21);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(63, 21);
            this.lblItemID.TabIndex = 42;
            this.lblItemID.Text = "Item ID:";
            // 
            // txtItemStatus
            // 
            this.txtItemStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemStatus.Location = new System.Drawing.Point(311, 45);
            this.txtItemStatus.Name = "txtItemStatus";
            this.txtItemStatus.ReadOnly = true;
            this.txtItemStatus.Size = new System.Drawing.Size(242, 27);
            this.txtItemStatus.TabIndex = 40;
            this.txtItemStatus.TabStop = false;
            // 
            // lblROLItemStatus
            // 
            this.lblROLItemStatus.AutoSize = true;
            this.lblROLItemStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblROLItemStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblROLItemStatus.Location = new System.Drawing.Point(313, 21);
            this.lblROLItemStatus.Name = "lblROLItemStatus";
            this.lblROLItemStatus.Size = new System.Drawing.Size(90, 21);
            this.lblROLItemStatus.TabIndex = 34;
            this.lblROLItemStatus.Text = "Item Status:";
            // 
            // dgvROLDtList
            // 
            this.dgvROLDtList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvROLDtList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvROLDtList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvROLDtList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvROLDtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvROLDtList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvROLDtList.Location = new System.Drawing.Point(31, 54);
            this.dgvROLDtList.Name = "dgvROLDtList";
            this.dgvROLDtList.ReadOnly = true;
            this.dgvROLDtList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvROLDtList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvROLDtList.Size = new System.Drawing.Size(857, 218);
            this.dgvROLDtList.StandardTab = true;
            this.dgvROLDtList.TabIndex = 0;
            this.dgvROLDtList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTouttList_CellDoubleClick);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(33, 123);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(242, 27);
            this.txtItemName.TabIndex = 49;
            this.txtItemName.TabStop = false;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.SystemColors.Control;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(35, 99);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(90, 21);
            this.lblItemName.TabIndex = 45;
            this.lblItemName.Text = "Item Name:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(836, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 36);
            this.btnExit.TabIndex = 60;
            this.btnExit.Text = "HOME";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtReorderLevelAlert
            // 
            this.txtReorderLevelAlert.BackColor = System.Drawing.SystemColors.Control;
            this.txtReorderLevelAlert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReorderLevelAlert.Location = new System.Drawing.Point(589, 45);
            this.txtReorderLevelAlert.Name = "txtReorderLevelAlert";
            this.txtReorderLevelAlert.ReadOnly = true;
            this.txtReorderLevelAlert.Size = new System.Drawing.Size(242, 27);
            this.txtReorderLevelAlert.TabIndex = 64;
            this.txtReorderLevelAlert.TabStop = false;
            // 
            // lblReOrderLevel
            // 
            this.lblReOrderLevel.AutoSize = true;
            this.lblReOrderLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblReOrderLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReOrderLevel.Location = new System.Drawing.Point(591, 21);
            this.lblReOrderLevel.Name = "lblReOrderLevel";
            this.lblReOrderLevel.Size = new System.Drawing.Size(116, 21);
            this.lblReOrderLevel.TabIndex = 63;
            this.lblReOrderLevel.Text = "Re Order Level:";
            // 
            // lblAvlQuantity
            // 
            this.lblAvlQuantity.AutoSize = true;
            this.lblAvlQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblAvlQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvlQuantity.Location = new System.Drawing.Point(591, 99);
            this.lblAvlQuantity.Name = "lblAvlQuantity";
            this.lblAvlQuantity.Size = new System.Drawing.Size(140, 21);
            this.lblAvlQuantity.TabIndex = 67;
            this.lblAvlQuantity.Text = "Available Quantity:";
            // 
            // lblWarehouseID
            // 
            this.lblWarehouseID.AutoSize = true;
            this.lblWarehouseID.BackColor = System.Drawing.SystemColors.Control;
            this.lblWarehouseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseID.Location = new System.Drawing.Point(313, 99);
            this.lblWarehouseID.Name = "lblWarehouseID";
            this.lblWarehouseID.Size = new System.Drawing.Size(110, 21);
            this.lblWarehouseID.TabIndex = 68;
            this.lblWarehouseID.Text = "Warehouse ID:";
            // 
            // txtlblWarehouseID
            // 
            this.txtlblWarehouseID.BackColor = System.Drawing.SystemColors.Control;
            this.txtlblWarehouseID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlblWarehouseID.Location = new System.Drawing.Point(311, 123);
            this.txtlblWarehouseID.Name = "txtlblWarehouseID";
            this.txtlblWarehouseID.ReadOnly = true;
            this.txtlblWarehouseID.Size = new System.Drawing.Size(242, 27);
            this.txtlblWarehouseID.TabIndex = 69;
            this.txtlblWarehouseID.TabStop = false;
            // 
            // txtROLDAvlQntity
            // 
            this.txtROLDAvlQntity.BackColor = System.Drawing.SystemColors.Control;
            this.txtROLDAvlQntity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtROLDAvlQntity.Location = new System.Drawing.Point(589, 123);
            this.txtROLDAvlQntity.Name = "txtROLDAvlQntity";
            this.txtROLDAvlQntity.ReadOnly = true;
            this.txtROLDAvlQntity.Size = new System.Drawing.Size(242, 27);
            this.txtROLDAvlQntity.TabIndex = 70;
            this.txtROLDAvlQntity.TabStop = false;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(12, 9);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(75, 15);
            this.lblLoggedUser.TabIndex = 71;
            this.lblLoggedUser.Text = "Current User:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnRESET);
            this.panel1.Controls.Add(this.txtReorderLevelAlert);
            this.panel1.Controls.Add(this.lblReOrderLevel);
            this.panel1.Controls.Add(this.txtROLDAvlQntity);
            this.panel1.Controls.Add(this.txtItemID);
            this.panel1.Controls.Add(this.txtlblWarehouseID);
            this.panel1.Controls.Add(this.lblItemID);
            this.panel1.Controls.Add(this.lblWarehouseID);
            this.panel1.Controls.Add(this.txtItemStatus);
            this.panel1.Controls.Add(this.lblItemName);
            this.panel1.Controls.Add(this.lblROLItemStatus);
            this.panel1.Controls.Add(this.lblAvlQuantity);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Location = new System.Drawing.Point(31, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 230);
            this.panel1.TabIndex = 72;
            // 
            // btnRESET
            // 
            this.btnRESET.Location = new System.Drawing.Point(673, 179);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(75, 30);
            this.btnRESET.TabIndex = 71;
            this.btnRESET.Text = "Reset";
            this.btnRESET.UseVisualStyleBackColor = true;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // ReorderLevelAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvROLDtList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReorderLevelAlert";
            this.Text = "ReOrder Level Alert";
            this.Load += new System.EventHandler(this.ReorderLevelAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvROLDtList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtItemStatus;
        private System.Windows.Forms.Label lblROLItemStatus;
        private System.Windows.Forms.DataGridView dgvROLDtList;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtReorderLevelAlert;
        private System.Windows.Forms.Label lblReOrderLevel;
        private System.Windows.Forms.Label lblAvlQuantity;
        private System.Windows.Forms.Label lblWarehouseID;
        private System.Windows.Forms.TextBox txtlblWarehouseID;
        private System.Windows.Forms.TextBox txtROLDAvlQntity;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRESET;
    }
}