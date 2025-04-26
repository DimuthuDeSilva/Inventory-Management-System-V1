using System.Drawing;

namespace Inventory_Management_System.Forms
{
    partial class StockIn
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
            this.btnSTinProcess = new System.Windows.Forms.Button();
            this.txtMRRNotes = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblMRRNotes = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblReceivedQuantity = new System.Windows.Forms.Label();
            this.txtMRRStatus = new System.Windows.Forms.TextBox();
            this.txtIssuedQuantity = new System.Windows.Forms.TextBox();
            this.txtMRRID = new System.Windows.Forms.TextBox();
            this.lblMRRStatus = new System.Windows.Forms.Label();
            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.lblMRRID = new System.Windows.Forms.Label();
            this.dgvStockIntList = new System.Windows.Forms.DataGridView();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnRESET = new System.Windows.Forms.Button();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIntList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSTinProcess
            // 
            this.btnSTinProcess.BackColor = System.Drawing.Color.Navy;
            this.btnSTinProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTinProcess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSTinProcess.Location = new System.Drawing.Point(337, 186);
            this.btnSTinProcess.Name = "btnSTinProcess";
            this.btnSTinProcess.Size = new System.Drawing.Size(98, 30);
            this.btnSTinProcess.TabIndex = 50;
            this.btnSTinProcess.Text = "PROCESS";
            this.btnSTinProcess.UseVisualStyleBackColor = false;
            this.btnSTinProcess.Click += new System.EventHandler(this.btnSTinProcess_Click);
            // 
            // txtMRRNotes
            // 
            this.txtMRRNotes.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRRNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRRNotes.Location = new System.Drawing.Point(616, 425);
            this.txtMRRNotes.Name = "txtMRRNotes";
            this.txtMRRNotes.Size = new System.Drawing.Size(242, 27);
            this.txtMRRNotes.TabIndex = 48;
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(52, 372);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(242, 27);
            this.txtItemID.TabIndex = 46;
            this.txtItemID.TabStop = false;
            // 
            // lblMRRNotes
            // 
            this.lblMRRNotes.AutoSize = true;
            this.lblMRRNotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRRNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRRNotes.Location = new System.Drawing.Point(618, 400);
            this.lblMRRNotes.Name = "lblMRRNotes";
            this.lblMRRNotes.Size = new System.Drawing.Size(54, 21);
            this.lblMRRNotes.TabIndex = 43;
            this.lblMRRNotes.Text = "Notes:";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.BackColor = System.Drawing.SystemColors.Control;
            this.lblItemID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(54, 348);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(63, 21);
            this.lblItemID.TabIndex = 42;
            this.lblItemID.Text = "Item ID:";
            // 
            // lblReceivedQuantity
            // 
            this.lblReceivedQuantity.AutoSize = true;
            this.lblReceivedQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblReceivedQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedQuantity.Location = new System.Drawing.Point(618, 348);
            this.lblReceivedQuantity.Name = "lblReceivedQuantity";
            this.lblReceivedQuantity.Size = new System.Drawing.Size(139, 21);
            this.lblReceivedQuantity.TabIndex = 41;
            this.lblReceivedQuantity.Text = "Received Quantity:";
            // 
            // txtMRRStatus
            // 
            this.txtMRRStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRRStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRRStatus.Location = new System.Drawing.Point(337, 402);
            this.txtMRRStatus.Name = "txtMRRStatus";
            this.txtMRRStatus.ReadOnly = true;
            this.txtMRRStatus.Size = new System.Drawing.Size(242, 27);
            this.txtMRRStatus.TabIndex = 40;
            this.txtMRRStatus.TabStop = false;
            // 
            // txtIssuedQuantity
            // 
            this.txtIssuedQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtIssuedQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedQuantity.Location = new System.Drawing.Point(616, 372);
            this.txtIssuedQuantity.Name = "txtIssuedQuantity";
            this.txtIssuedQuantity.Size = new System.Drawing.Size(242, 27);
            this.txtIssuedQuantity.TabIndex = 36;
            // 
            // txtMRRID
            // 
            this.txtMRRID.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRRID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRRID.Location = new System.Drawing.Point(52, 318);
            this.txtMRRID.Name = "txtMRRID";
            this.txtMRRID.ReadOnly = true;
            this.txtMRRID.Size = new System.Drawing.Size(242, 27);
            this.txtMRRID.TabIndex = 35;
            this.txtMRRID.TabStop = false;
            // 
            // lblMRRStatus
            // 
            this.lblMRRStatus.AutoSize = true;
            this.lblMRRStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRRStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRRStatus.Location = new System.Drawing.Point(339, 378);
            this.lblMRRStatus.Name = "lblMRRStatus";
            this.lblMRRStatus.Size = new System.Drawing.Size(93, 21);
            this.lblMRRStatus.TabIndex = 34;
            this.lblMRRStatus.Text = "MRR Status:";
            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblReceivedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedDate.Location = new System.Drawing.Point(618, 294);
            this.lblReceivedDate.Name = "lblReceivedDate";
            this.lblReceivedDate.Size = new System.Drawing.Size(111, 21);
            this.lblReceivedDate.TabIndex = 32;
            this.lblReceivedDate.Text = "Received Date:";
            // 
            // lblMRRID
            // 
            this.lblMRRID.AutoSize = true;
            this.lblMRRID.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRRID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRRID.Location = new System.Drawing.Point(54, 294);
            this.lblMRRID.Name = "lblMRRID";
            this.lblMRRID.Size = new System.Drawing.Size(66, 21);
            this.lblMRRID.TabIndex = 30;
            this.lblMRRID.Text = "MRR ID:";
            // 
            // dgvStockIntList
            // 
            this.dgvStockIntList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStockIntList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockIntList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStockIntList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStockIntList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockIntList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStockIntList.Location = new System.Drawing.Point(26, 54);
            this.dgvStockIntList.Name = "dgvStockIntList";
            this.dgvStockIntList.ReadOnly = true;
            this.dgvStockIntList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStockIntList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStockIntList.Size = new System.Drawing.Size(857, 218);
            this.dgvStockIntList.StandardTab = true;
            this.dgvStockIntList.TabIndex = 0;
            this.dgvStockIntList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSTintList_CellDoubleClick);
            // 
            // dtpReceivedDate
            // 
            this.dtpReceivedDate.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReceivedDate.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReceivedDate.Location = new System.Drawing.Point(616, 318);
            this.dtpReceivedDate.Name = "dtpReceivedDate";
            this.dtpReceivedDate.Size = new System.Drawing.Size(242, 25);
            this.dtpReceivedDate.TabIndex = 58;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(52, 426);
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
            this.lblItemName.Location = new System.Drawing.Point(54, 402);
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
            this.btnExit.Location = new System.Drawing.Point(837, 1);
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
            this.txtQuantity.Location = new System.Drawing.Point(337, 330);
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
            this.lblQuantity.Location = new System.Drawing.Point(339, 306);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 21);
            this.lblQuantity.TabIndex = 63;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnRESET
            // 
            this.btnRESET.BackColor = System.Drawing.Color.Navy;
            this.btnRESET.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRESET.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRESET.Location = new System.Drawing.Point(441, 186);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(98, 30);
            this.btnRESET.TabIndex = 66;
            this.btnRESET.Text = "RESET";
            this.btnRESET.UseVisualStyleBackColor = false;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(12, 9);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(75, 15);
            this.lblLoggedUser.TabIndex = 67;
            this.lblLoggedUser.Text = "Current User:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSTinProcess);
            this.panel1.Controls.Add(this.btnRESET);
            this.panel1.Location = new System.Drawing.Point(26, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 237);
            this.panel1.TabIndex = 68;
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtpReceivedDate);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtMRRNotes);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblMRRNotes);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lblReceivedQuantity);
            this.Controls.Add(this.txtMRRStatus);
            this.Controls.Add(this.txtIssuedQuantity);
            this.Controls.Add(this.txtMRRID);
            this.Controls.Add(this.lblMRRStatus);
            this.Controls.Add(this.lblReceivedDate);
            this.Controls.Add(this.lblMRRID);
            this.Controls.Add(this.dgvStockIntList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockIn";
            this.Text = "Stock In Process";
            this.Load += new System.EventHandler(this.StockIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIntList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSTOutReset;
        private System.Windows.Forms.Button btnSTinProcess;
        private System.Windows.Forms.TextBox txtMRRNotes;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblMRRNotes;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblReceivedQuantity;
        private System.Windows.Forms.TextBox txtMRRStatus;
        private System.Windows.Forms.TextBox txtIssuedQuantity;
        private System.Windows.Forms.TextBox txtMRRID;
        private System.Windows.Forms.Label lblMRRStatus;
        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.Label lblMRRID;
        private System.Windows.Forms.DataGridView dgvStockIntList;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Panel panel1;
    }
}