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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnROLDProcess = new System.Windows.Forms.Button();
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
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.btnRESET = new System.Windows.Forms.Button();
            this.lblAvlQuantity = new System.Windows.Forms.Label();
            this.lblWarehouseID = new System.Windows.Forms.Label();
            this.txtlblWarehouseID = new System.Windows.Forms.TextBox();
            this.txtROLDAvlQntity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvROLDtList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnROLDProcess
            // 
            this.btnROLDProcess.BackColor = System.Drawing.Color.Navy;
            this.btnROLDProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnROLDProcess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnROLDProcess.Location = new System.Drawing.Point(651, 481);
            this.btnROLDProcess.Name = "btnROLDProcess";
            this.btnROLDProcess.Size = new System.Drawing.Size(98, 30);
            this.btnROLDProcess.TabIndex = 50;
            this.btnROLDProcess.Text = "PROCESS";
            this.btnROLDProcess.UseVisualStyleBackColor = false;
            this.btnROLDProcess.Click += new System.EventHandler(this.btnSTOutProcess_Click);
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(26, 319);
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
            this.lblItemID.Location = new System.Drawing.Point(28, 295);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(63, 21);
            this.lblItemID.TabIndex = 42;
            this.lblItemID.Text = "Item ID:";
            // 
            // txtItemStatus
            // 
            this.txtItemStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemStatus.Location = new System.Drawing.Point(330, 373);
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
            this.lblROLItemStatus.Location = new System.Drawing.Point(332, 349);
            this.lblROLItemStatus.Name = "lblROLItemStatus";
            this.lblROLItemStatus.Size = new System.Drawing.Size(90, 21);
            this.lblROLItemStatus.TabIndex = 34;
            this.lblROLItemStatus.Text = "Item Status:";
            // 
            // dgvROLDtList
            // 
            this.dgvROLDtList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvROLDtList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvROLDtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvROLDtList.Location = new System.Drawing.Point(26, 54);
            this.dgvROLDtList.Name = "dgvROLDtList";
            this.dgvROLDtList.ReadOnly = true;
            this.dgvROLDtList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvROLDtList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvROLDtList.Size = new System.Drawing.Size(857, 218);
            this.dgvROLDtList.StandardTab = true;
            this.dgvROLDtList.TabIndex = 0;
            this.dgvROLDtList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTouttList_CellContentClick);
            this.dgvROLDtList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTouttList_CellDoubleClick);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(26, 372);
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
            this.lblItemName.Location = new System.Drawing.Point(28, 348);
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
            this.btnExit.Location = new System.Drawing.Point(803, 12);
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
            this.txtReorderLevelAlert.Location = new System.Drawing.Point(26, 426);
            this.txtReorderLevelAlert.Name = "txtReorderLevelAlert";
            this.txtReorderLevelAlert.Size = new System.Drawing.Size(242, 27);
            this.txtReorderLevelAlert.TabIndex = 64;
            // 
            // lblReOrderLevel
            // 
            this.lblReOrderLevel.AutoSize = true;
            this.lblReOrderLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblReOrderLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReOrderLevel.Location = new System.Drawing.Point(28, 402);
            this.lblReOrderLevel.Name = "lblReOrderLevel";
            this.lblReOrderLevel.Size = new System.Drawing.Size(116, 21);
            this.lblReOrderLevel.TabIndex = 63;
            this.lblReOrderLevel.Text = "Re Order Level:";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(12, 12);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(37, 15);
            this.lblLoggedUser.TabIndex = 65;
            this.lblLoggedUser.Text = "label1";
            this.lblLoggedUser.Click += new System.EventHandler(this.lblLoggedUser_Click);
            // 
            // btnRESET
            // 
            this.btnRESET.BackColor = System.Drawing.Color.Navy;
            this.btnRESET.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRESET.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRESET.Location = new System.Drawing.Point(755, 481);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(98, 30);
            this.btnRESET.TabIndex = 66;
            this.btnRESET.Text = "RESET";
            this.btnRESET.UseVisualStyleBackColor = false;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // lblAvlQuantity
            // 
            this.lblAvlQuantity.AutoSize = true;
            this.lblAvlQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblAvlQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvlQuantity.Location = new System.Drawing.Point(332, 402);
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
            this.lblWarehouseID.Location = new System.Drawing.Point(332, 295);
            this.lblWarehouseID.Name = "lblWarehouseID";
            this.lblWarehouseID.Size = new System.Drawing.Size(110, 21);
            this.lblWarehouseID.TabIndex = 68;
            this.lblWarehouseID.Text = "Warehouse ID:";
            // 
            // txtlblWarehouseID
            // 
            this.txtlblWarehouseID.BackColor = System.Drawing.SystemColors.Control;
            this.txtlblWarehouseID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlblWarehouseID.Location = new System.Drawing.Point(330, 319);
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
            this.txtROLDAvlQntity.Location = new System.Drawing.Point(330, 426);
            this.txtROLDAvlQntity.Name = "txtROLDAvlQntity";
            this.txtROLDAvlQntity.ReadOnly = true;
            this.txtROLDAvlQntity.Size = new System.Drawing.Size(242, 27);
            this.txtROLDAvlQntity.TabIndex = 70;
            this.txtROLDAvlQntity.TabStop = false;
            // 
            // ReorderLevelAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.txtROLDAvlQntity);
            this.Controls.Add(this.txtlblWarehouseID);
            this.Controls.Add(this.lblWarehouseID);
            this.Controls.Add(this.lblAvlQuantity);
            this.Controls.Add(this.btnRESET);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.txtReorderLevelAlert);
            this.Controls.Add(this.lblReOrderLevel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnROLDProcess);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.txtItemStatus);
            this.Controls.Add(this.lblROLItemStatus);
            this.Controls.Add(this.dgvROLDtList);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReorderLevelAlert";
            this.Text = "Create Payment ";
            this.Load += new System.EventHandler(this.ReorderLevelAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvROLDtList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSTOutReset;
        private System.Windows.Forms.Button btnROLDProcess;
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
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.Label lblAvlQuantity;
        private System.Windows.Forms.Label lblWarehouseID;
        private System.Windows.Forms.TextBox txtlblWarehouseID;
        private System.Windows.Forms.TextBox txtROLDAvlQntity;
    }
}