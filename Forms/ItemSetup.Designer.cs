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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Navy;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(594, 484);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "RESET";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Navy;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(350, 484);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdWarehouseID
            // 
            this.txtUpdWarehouseID.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdWarehouseID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdWarehouseID.Location = new System.Drawing.Point(601, 123);
            this.txtUpdWarehouseID.Name = "txtUpdWarehouseID";
            this.txtUpdWarehouseID.Size = new System.Drawing.Size(242, 27);
            this.txtUpdWarehouseID.TabIndex = 49;
            // 
            // txtUpdStatus
            // 
            this.txtUpdStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdStatus.Location = new System.Drawing.Point(601, 177);
            this.txtUpdStatus.Name = "txtUpdStatus";
            this.txtUpdStatus.Size = new System.Drawing.Size(242, 27);
            this.txtUpdStatus.TabIndex = 48;
            // 
            // txtUpdSupplierID
            // 
            this.txtUpdSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdSupplierID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdSupplierID.Location = new System.Drawing.Point(340, 123);
            this.txtUpdSupplierID.Name = "txtUpdSupplierID";
            this.txtUpdSupplierID.Size = new System.Drawing.Size(242, 27);
            this.txtUpdSupplierID.TabIndex = 46;
            // 
            // lblUpdWarehouseID
            // 
            this.lblUpdWarehouseID.AutoSize = true;
            this.lblUpdWarehouseID.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdWarehouseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdWarehouseID.Location = new System.Drawing.Point(603, 99);
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
            this.lblUpdStatus.Location = new System.Drawing.Point(603, 153);
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
            this.lblUpdSupplierID.Location = new System.Drawing.Point(342, 99);
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
            this.lblUpdTotalCost.Location = new System.Drawing.Point(603, 45);
            this.lblUpdTotalCost.Name = "lblUpdTotalCost";
            this.lblUpdTotalCost.Size = new System.Drawing.Size(80, 21);
            this.lblUpdTotalCost.TabIndex = 41;
            this.lblUpdTotalCost.Text = "Total Cost:";
            // 
            // txtUpdUnitPrice
            // 
            this.txtUpdUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdUnitPrice.Location = new System.Drawing.Point(340, 177);
            this.txtUpdUnitPrice.Name = "txtUpdUnitPrice";
            this.txtUpdUnitPrice.Size = new System.Drawing.Size(242, 27);
            this.txtUpdUnitPrice.TabIndex = 40;
            // 
            // txtUpdQuantity
            // 
            this.txtUpdQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdQuantity.Location = new System.Drawing.Point(340, 231);
            this.txtUpdQuantity.Name = "txtUpdQuantity";
            this.txtUpdQuantity.Size = new System.Drawing.Size(242, 27);
            this.txtUpdQuantity.TabIndex = 39;
            // 
            // txtUpdReorderLevel
            // 
            this.txtUpdReorderLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdReorderLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdReorderLevel.Location = new System.Drawing.Point(340, 69);
            this.txtUpdReorderLevel.Name = "txtUpdReorderLevel";
            this.txtUpdReorderLevel.Size = new System.Drawing.Size(242, 27);
            this.txtUpdReorderLevel.TabIndex = 38;
            // 
            // txtUpdDescription
            // 
            this.txtUpdDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdDescription.Location = new System.Drawing.Point(76, 177);
            this.txtUpdDescription.Name = "txtUpdDescription";
            this.txtUpdDescription.Size = new System.Drawing.Size(242, 27);
            this.txtUpdDescription.TabIndex = 37;
            // 
            // txtUpdTotalCost
            // 
            this.txtUpdTotalCost.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdTotalCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdTotalCost.Location = new System.Drawing.Point(601, 69);
            this.txtUpdTotalCost.Name = "txtUpdTotalCost";
            this.txtUpdTotalCost.Size = new System.Drawing.Size(242, 27);
            this.txtUpdTotalCost.TabIndex = 36;
            // 
            // txtUpdName
            // 
            this.txtUpdName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdName.Location = new System.Drawing.Point(76, 123);
            this.txtUpdName.Name = "txtUpdName";
            this.txtUpdName.Size = new System.Drawing.Size(242, 27);
            this.txtUpdName.TabIndex = 35;
            // 
            // lblUpdUnitPrice
            // 
            this.lblUpdUnitPrice.AutoSize = true;
            this.lblUpdUnitPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdUnitPrice.Location = new System.Drawing.Point(341, 153);
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
            this.lblUpdQuantity.Location = new System.Drawing.Point(342, 207);
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
            this.lblUpdReorderLevel.Location = new System.Drawing.Point(342, 45);
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
            this.lblUpdDescription.Location = new System.Drawing.Point(78, 153);
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
            this.lblUpdName.Location = new System.Drawing.Point(78, 99);
            this.lblUpdName.Name = "lblUpdName";
            this.lblUpdName.Size = new System.Drawing.Size(55, 21);
            this.lblUpdName.TabIndex = 30;
            this.lblUpdName.Text = "Name:";
            // 
            // txtUpdItemID
            // 
            this.txtUpdItemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdItemID.Location = new System.Drawing.Point(76, 69);
            this.txtUpdItemID.Name = "txtUpdItemID";
            this.txtUpdItemID.Size = new System.Drawing.Size(242, 27);
            this.txtUpdItemID.TabIndex = 29;
            // 
            // lblUpdItemID
            // 
            this.lblUpdItemID.AutoSize = true;
            this.lblUpdItemID.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdItemID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdItemID.Location = new System.Drawing.Point(78, 45);
            this.lblUpdItemID.Name = "lblUpdItemID";
            this.lblUpdItemID.Size = new System.Drawing.Size(59, 21);
            this.lblUpdItemID.TabIndex = 28;
            this.lblUpdItemID.Text = "ItemID:";
            // 
            // dgvItemList
            // 
            this.dgvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Location = new System.Drawing.Point(40, 273);
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
            this.dgvItemList.Size = new System.Drawing.Size(837, 185);
            this.dgvItemList.StandardTab = true;
            this.dgvItemList.TabIndex = 0;
            this.dgvItemList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Navy;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(226, 484);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Navy;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(474, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(845, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 31);
            this.btnExit.TabIndex = 56;
            this.btnExit.Text = "HOME";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
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
            this.panel1.Location = new System.Drawing.Point(40, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 232);
            this.panel1.TabIndex = 67;
            // 
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
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
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemSetup";
            this.Text = "Item Setup";
            this.Load += new System.EventHandler(this.UpdateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Panel panel1;
    }
}