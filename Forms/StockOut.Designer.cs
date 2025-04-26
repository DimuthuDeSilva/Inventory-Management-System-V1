using System.Drawing;

namespace Inventory_Management_System.Forms
{
    partial class StockOut
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
            this.btnSTOutProcess = new System.Windows.Forms.Button();
            this.txtSOSNotes = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblAPONotes = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblIssuedQuantity = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtIssuedQuantity = new System.Windows.Forms.TextBox();
            this.txtMRNID = new System.Windows.Forms.TextBox();
            this.lblSOStatus = new System.Windows.Forms.Label();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.lblMRNID = new System.Windows.Forms.Label();
            this.dgvSTouttList = new System.Windows.Forms.DataGridView();
            this.dtpIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.btnRESET = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTouttList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSTOutProcess
            // 
            this.btnSTOutProcess.BackColor = System.Drawing.Color.Navy;
            this.btnSTOutProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTOutProcess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSTOutProcess.Location = new System.Drawing.Point(627, 179);
            this.btnSTOutProcess.Name = "btnSTOutProcess";
            this.btnSTOutProcess.Size = new System.Drawing.Size(98, 30);
            this.btnSTOutProcess.TabIndex = 50;
            this.btnSTOutProcess.Text = "PROCESS";
            this.btnSTOutProcess.UseVisualStyleBackColor = false;
            this.btnSTOutProcess.Click += new System.EventHandler(this.btnSTOutProcess_Click);
            // 
            // txtSOSNotes
            // 
            this.txtSOSNotes.BackColor = System.Drawing.SystemColors.Control;
            this.txtSOSNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOSNotes.Location = new System.Drawing.Point(628, 372);
            this.txtSOSNotes.Name = "txtSOSNotes";
            this.txtSOSNotes.Size = new System.Drawing.Size(242, 27);
            this.txtSOSNotes.TabIndex = 48;
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(36, 372);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(242, 27);
            this.txtItemID.TabIndex = 46;
            this.txtItemID.TabStop = false;
            // 
            // lblAPONotes
            // 
            this.lblAPONotes.AutoSize = true;
            this.lblAPONotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPONotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPONotes.Location = new System.Drawing.Point(630, 347);
            this.lblAPONotes.Name = "lblAPONotes";
            this.lblAPONotes.Size = new System.Drawing.Size(54, 21);
            this.lblAPONotes.TabIndex = 43;
            this.lblAPONotes.Text = "Notes:";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.BackColor = System.Drawing.SystemColors.Control;
            this.lblItemID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(38, 348);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(63, 21);
            this.lblItemID.TabIndex = 42;
            this.lblItemID.Text = "Item ID:";
            // 
            // lblIssuedQuantity
            // 
            this.lblIssuedQuantity.AutoSize = true;
            this.lblIssuedQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblIssuedQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedQuantity.Location = new System.Drawing.Point(630, 295);
            this.lblIssuedQuantity.Name = "lblIssuedQuantity";
            this.lblIssuedQuantity.Size = new System.Drawing.Size(121, 21);
            this.lblIssuedQuantity.TabIndex = 41;
            this.lblIssuedQuantity.Text = "Issued Quantity:";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(334, 372);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(242, 27);
            this.txtStatus.TabIndex = 40;
            this.txtStatus.TabStop = false;
            // 
            // txtIssuedQuantity
            // 
            this.txtIssuedQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtIssuedQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedQuantity.Location = new System.Drawing.Point(628, 319);
            this.txtIssuedQuantity.Name = "txtIssuedQuantity";
            this.txtIssuedQuantity.Size = new System.Drawing.Size(242, 27);
            this.txtIssuedQuantity.TabIndex = 36;
            // 
            // txtMRNID
            // 
            this.txtMRNID.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNID.Location = new System.Drawing.Point(36, 318);
            this.txtMRNID.Name = "txtMRNID";
            this.txtMRNID.ReadOnly = true;
            this.txtMRNID.Size = new System.Drawing.Size(242, 27);
            this.txtMRNID.TabIndex = 35;
            this.txtMRNID.TabStop = false;
            // 
            // lblSOStatus
            // 
            this.lblSOStatus.AutoSize = true;
            this.lblSOStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblSOStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSOStatus.Location = new System.Drawing.Point(336, 348);
            this.lblSOStatus.Name = "lblSOStatus";
            this.lblSOStatus.Size = new System.Drawing.Size(95, 21);
            this.lblSOStatus.TabIndex = 34;
            this.lblSOStatus.Text = "MRN Status:";
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblIssuedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedDate.Location = new System.Drawing.Point(336, 401);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(93, 21);
            this.lblIssuedDate.TabIndex = 32;
            this.lblIssuedDate.Text = "Issued Date:";
            // 
            // lblMRNID
            // 
            this.lblMRNID.AutoSize = true;
            this.lblMRNID.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRNID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNID.Location = new System.Drawing.Point(38, 294);
            this.lblMRNID.Name = "lblMRNID";
            this.lblMRNID.Size = new System.Drawing.Size(68, 21);
            this.lblMRNID.TabIndex = 30;
            this.lblMRNID.Text = "MRN ID:";
            // 
            // dgvSTouttList
            // 
            this.dgvSTouttList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSTouttList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSTouttList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSTouttList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSTouttList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTouttList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSTouttList.Location = new System.Drawing.Point(26, 54);
            this.dgvSTouttList.Name = "dgvSTouttList";
            this.dgvSTouttList.ReadOnly = true;
            this.dgvSTouttList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSTouttList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSTouttList.Size = new System.Drawing.Size(857, 218);
            this.dgvSTouttList.StandardTab = true;
            this.dgvSTouttList.TabIndex = 0;
            this.dgvSTouttList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTouttList_CellDoubleClick);
            // 
            // dtpIssuedDate
            // 
            this.dtpIssuedDate.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssuedDate.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssuedDate.Location = new System.Drawing.Point(334, 425);
            this.dtpIssuedDate.Name = "dtpIssuedDate";
            this.dtpIssuedDate.Size = new System.Drawing.Size(242, 25);
            this.dtpIssuedDate.TabIndex = 58;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(36, 426);
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
            this.lblItemName.Location = new System.Drawing.Point(38, 402);
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
            this.btnExit.Location = new System.Drawing.Point(829, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 36);
            this.btnExit.TabIndex = 60;
            this.btnExit.Text = "HOME";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(334, 318);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(242, 27);
            this.txtQuantity.TabIndex = 64;
            this.txtQuantity.TabStop = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(336, 294);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 21);
            this.lblQuantity.TabIndex = 63;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(12, 12);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(75, 15);
            this.lblLoggedUser.TabIndex = 65;
            this.lblLoggedUser.Text = "Current User:";
            // 
            // btnRESET
            // 
            this.btnRESET.BackColor = System.Drawing.Color.Navy;
            this.btnRESET.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRESET.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRESET.Location = new System.Drawing.Point(731, 179);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(98, 30);
            this.btnRESET.TabIndex = 66;
            this.btnRESET.Text = "RESET";
            this.btnRESET.UseVisualStyleBackColor = false;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnRESET);
            this.panel1.Controls.Add(this.btnSTOutProcess);
            this.panel1.Location = new System.Drawing.Point(26, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 231);
            this.panel1.TabIndex = 67;
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtpIssuedDate);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtSOSNotes);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblAPONotes);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lblIssuedQuantity);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtIssuedQuantity);
            this.Controls.Add(this.txtMRNID);
            this.Controls.Add(this.lblSOStatus);
            this.Controls.Add(this.lblIssuedDate);
            this.Controls.Add(this.lblMRNID);
            this.Controls.Add(this.dgvSTouttList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockOut";
            this.Text = "Create Payment ";
            this.Load += new System.EventHandler(this.StockOut_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTouttList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSTOutReset;
        private System.Windows.Forms.Button btnSTOutProcess;
        private System.Windows.Forms.TextBox txtSOSNotes;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblAPONotes;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblIssuedQuantity;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtIssuedQuantity;
        private System.Windows.Forms.TextBox txtMRNID;
        private System.Windows.Forms.Label lblSOStatus;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.Label lblMRNID;
        private System.Windows.Forms.DataGridView dgvSTouttList;
        private System.Windows.Forms.DateTimePicker dtpIssuedDate;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.Panel panel1;
    }
}