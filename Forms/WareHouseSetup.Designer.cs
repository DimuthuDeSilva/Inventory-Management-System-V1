using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    partial class WareHouseSetup : Form
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
            this.btnWHClear = new System.Windows.Forms.Button();
            this.btnWHUpdate = new System.Windows.Forms.Button();
            this.txtWareHouseStatus = new System.Windows.Forms.TextBox();
            this.txtWarehouseManagerID = new System.Windows.Forms.TextBox();
            this.lblWareHouseStatus = new System.Windows.Forms.Label();
            this.lblManagerID = new System.Windows.Forms.Label();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.txtWarehouseCapacity = new System.Windows.Forms.TextBox();
            this.txtWarehouseLocation = new System.Windows.Forms.TextBox();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblWareHouseName = new System.Windows.Forms.Label();
            this.txtWarehouseID = new System.Windows.Forms.TextBox();
            this.lblWarehouseID = new System.Windows.Forms.Label();
            this.dgvWarehouseList = new System.Windows.Forms.DataGridView();
            this.btnWHAdd = new System.Windows.Forms.Button();
            this.btnWHDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWHClear
            // 
            this.btnWHClear.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnWHClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWHClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWHClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWHClear.Location = new System.Drawing.Point(1137, 534);
            this.btnWHClear.Name = "btnWHClear";
            this.btnWHClear.Size = new System.Drawing.Size(90, 30);
            this.btnWHClear.TabIndex = 51;
            this.btnWHClear.Text = "RESET";
            this.btnWHClear.UseVisualStyleBackColor = false;
            this.btnWHClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnWHUpdate
            // 
            this.btnWHUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnWHUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWHUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWHUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWHUpdate.Location = new System.Drawing.Point(945, 534);
            this.btnWHUpdate.Name = "btnWHUpdate";
            this.btnWHUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnWHUpdate.TabIndex = 50;
            this.btnWHUpdate.Text = "UPDATE";
            this.btnWHUpdate.UseVisualStyleBackColor = false;
            this.btnWHUpdate.Click += new System.EventHandler(this.btnWHUpdate_Click);
            // 
            // txtWareHouseStatus
            // 
            this.txtWareHouseStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtWareHouseStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWareHouseStatus.Location = new System.Drawing.Point(693, 135);
            this.txtWareHouseStatus.Name = "txtWareHouseStatus";
            this.txtWareHouseStatus.Size = new System.Drawing.Size(314, 27);
            this.txtWareHouseStatus.TabIndex = 48;
            // 
            // txtWarehouseManagerID
            // 
            this.txtWarehouseManagerID.BackColor = System.Drawing.SystemColors.Control;
            this.txtWarehouseManagerID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseManagerID.Location = new System.Drawing.Point(262, 297);
            this.txtWarehouseManagerID.Name = "txtWarehouseManagerID";
            this.txtWarehouseManagerID.Size = new System.Drawing.Size(314, 27);
            this.txtWarehouseManagerID.TabIndex = 46;
            // 
            // lblWareHouseStatus
            // 
            this.lblWareHouseStatus.AutoSize = true;
            this.lblWareHouseStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblWareHouseStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWareHouseStatus.Location = new System.Drawing.Point(695, 111);
            this.lblWareHouseStatus.Name = "lblWareHouseStatus";
            this.lblWareHouseStatus.Size = new System.Drawing.Size(139, 21);
            this.lblWareHouseStatus.TabIndex = 43;
            this.lblWareHouseStatus.Text = "WareHouse Status:";
            // 
            // lblManagerID
            // 
            this.lblManagerID.AutoSize = true;
            this.lblManagerID.BackColor = System.Drawing.SystemColors.Control;
            this.lblManagerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerID.Location = new System.Drawing.Point(264, 273);
            this.lblManagerID.Name = "lblManagerID";
            this.lblManagerID.Size = new System.Drawing.Size(94, 21);
            this.lblManagerID.TabIndex = 42;
            this.lblManagerID.Text = "Manager ID:";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtContactPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPhone.Location = new System.Drawing.Point(693, 81);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(314, 27);
            this.txtContactPhone.TabIndex = 39;
            // 
            // txtWarehouseCapacity
            // 
            this.txtWarehouseCapacity.BackColor = System.Drawing.SystemColors.Control;
            this.txtWarehouseCapacity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseCapacity.Location = new System.Drawing.Point(262, 243);
            this.txtWarehouseCapacity.Name = "txtWarehouseCapacity";
            this.txtWarehouseCapacity.Size = new System.Drawing.Size(314, 27);
            this.txtWarehouseCapacity.TabIndex = 38;
            // 
            // txtWarehouseLocation
            // 
            this.txtWarehouseLocation.BackColor = System.Drawing.SystemColors.Control;
            this.txtWarehouseLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseLocation.Location = new System.Drawing.Point(262, 189);
            this.txtWarehouseLocation.Name = "txtWarehouseLocation";
            this.txtWarehouseLocation.Size = new System.Drawing.Size(314, 27);
            this.txtWarehouseLocation.TabIndex = 37;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.BackColor = System.Drawing.SystemColors.Control;
            this.txtWarehouseName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseName.Location = new System.Drawing.Point(262, 135);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(314, 27);
            this.txtWarehouseName.TabIndex = 35;
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.BackColor = System.Drawing.SystemColors.Control;
            this.lblContactPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPhone.Location = new System.Drawing.Point(695, 57);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(114, 21);
            this.lblContactPhone.TabIndex = 33;
            this.lblContactPhone.Text = "Contact Phone:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.BackColor = System.Drawing.SystemColors.Control;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(264, 219);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(72, 21);
            this.lblCapacity.TabIndex = 32;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(264, 165);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(72, 21);
            this.lblLocation.TabIndex = 31;
            this.lblLocation.Text = "Location:";
            // 
            // lblWareHouseName
            // 
            this.lblWareHouseName.AutoSize = true;
            this.lblWareHouseName.BackColor = System.Drawing.SystemColors.Control;
            this.lblWareHouseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWareHouseName.Location = new System.Drawing.Point(264, 111);
            this.lblWareHouseName.Name = "lblWareHouseName";
            this.lblWareHouseName.Size = new System.Drawing.Size(55, 21);
            this.lblWareHouseName.TabIndex = 30;
            this.lblWareHouseName.Text = "Name:";
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.BackColor = System.Drawing.SystemColors.Control;
            this.txtWarehouseID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseID.Location = new System.Drawing.Point(262, 81);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(314, 27);
            this.txtWarehouseID.TabIndex = 29;
            // 
            // lblWarehouseID
            // 
            this.lblWarehouseID.AutoSize = true;
            this.lblWarehouseID.BackColor = System.Drawing.SystemColors.Control;
            this.lblWarehouseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseID.Location = new System.Drawing.Point(264, 57);
            this.lblWarehouseID.Name = "lblWarehouseID";
            this.lblWarehouseID.Size = new System.Drawing.Size(110, 21);
            this.lblWarehouseID.TabIndex = 28;
            this.lblWarehouseID.Text = "Warehouse ID:";
            // 
            // dgvWarehouseList
            // 
            this.dgvWarehouseList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvWarehouseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouseList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvWarehouseList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvWarehouseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouseList.Location = new System.Drawing.Point(25, 330);
            this.dgvWarehouseList.Name = "dgvWarehouseList";
            this.dgvWarehouseList.ReadOnly = true;
            this.dgvWarehouseList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvWarehouseList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWarehouseList.Size = new System.Drawing.Size(1261, 187);
            this.dgvWarehouseList.StandardTab = true;
            this.dgvWarehouseList.TabIndex = 0;
            this.dgvWarehouseList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWareHouseList_CellDoubleClick);
            // 
            // btnWHAdd
            // 
            this.btnWHAdd.BackColor = System.Drawing.Color.Navy;
            this.btnWHAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWHAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWHAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWHAdd.Location = new System.Drawing.Point(849, 534);
            this.btnWHAdd.Name = "btnWHAdd";
            this.btnWHAdd.Size = new System.Drawing.Size(90, 30);
            this.btnWHAdd.TabIndex = 53;
            this.btnWHAdd.Text = "ADD";
            this.btnWHAdd.UseVisualStyleBackColor = false;
            this.btnWHAdd.Click += new System.EventHandler(this.btnWHAdd_Click);
            // 
            // btnWHDelete
            // 
            this.btnWHDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnWHDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWHDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWHDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWHDelete.Location = new System.Drawing.Point(1041, 534);
            this.btnWHDelete.Name = "btnWHDelete";
            this.btnWHDelete.Size = new System.Drawing.Size(90, 30);
            this.btnWHDelete.TabIndex = 54;
            this.btnWHDelete.Text = "DELETE";
            this.btnWHDelete.UseVisualStyleBackColor = false;
            this.btnWHDelete.Click += new System.EventHandler(this.btnWHDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(1226, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 31);
            this.btnExit.TabIndex = 57;
            this.btnExit.Text = "HOME";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Location = new System.Drawing.Point(36, 23);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(0, 20);
            this.lblLoggedUser.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 66;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WareHouseSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1298, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWHDelete);
            this.Controls.Add(this.btnWHAdd);
            this.Controls.Add(this.btnWHClear);
            this.Controls.Add(this.btnWHUpdate);
            this.Controls.Add(this.txtWareHouseStatus);
            this.Controls.Add(this.txtWarehouseManagerID);
            this.Controls.Add(this.lblWareHouseStatus);
            this.Controls.Add(this.lblManagerID);
            this.Controls.Add(this.txtContactPhone);
            this.Controls.Add(this.txtWarehouseCapacity);
            this.Controls.Add(this.txtWarehouseLocation);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.lblContactPhone);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblWareHouseName);
            this.Controls.Add(this.txtWarehouseID);
            this.Controls.Add(this.lblWarehouseID);
            this.Controls.Add(this.dgvWarehouseList);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WareHouseSetup";
            this.Text = "Warehouse Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WareHouseSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWHClear;
        private System.Windows.Forms.Button btnWHUpdate;
        private System.Windows.Forms.TextBox txtWareHouseStatus;
        private System.Windows.Forms.TextBox txtWarehouseManagerID;
        private System.Windows.Forms.Label lblWareHouseStatus;
        private System.Windows.Forms.Label lblManagerID;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.TextBox txtWarehouseCapacity;
        private System.Windows.Forms.TextBox txtWarehouseLocation;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblWareHouseName;
        private System.Windows.Forms.TextBox txtWarehouseID;
        private System.Windows.Forms.Label lblWarehouseID;
        private System.Windows.Forms.DataGridView dgvWarehouseList;
        private System.Windows.Forms.Button btnWHAdd;
        private System.Windows.Forms.Button btnWHDelete;
        private Button btnExit;
        private Label lblLoggedUser;
        private Label label1;
    }
}