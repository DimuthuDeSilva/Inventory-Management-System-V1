using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    partial class ConfirmMRN
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
            this.btnMRNClear = new System.Windows.Forms.Button();
            this.txtMRNNumberOfUnits = new System.Windows.Forms.TextBox();
            this.txtMRNNotes = new System.Windows.Forms.TextBox();
            this.lblMRNNumberOfUnits = new System.Windows.Forms.Label();
            this.lblMRNNotes = new System.Windows.Forms.Label();
            this.txtMRNItemName = new System.Windows.Forms.TextBox();
            this.lblMRNItemName = new System.Windows.Forms.Label();
            this.txtMRNItemID = new System.Windows.Forms.TextBox();
            this.lblMRNItemID = new System.Windows.Forms.Label();
            this.dgvMRNList = new System.Windows.Forms.DataGridView();
            this.btnMRNConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMRNdepartment = new System.Windows.Forms.TextBox();
            this.lblMRNdepartment = new System.Windows.Forms.Label();
            this.btnMRNReject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRNList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMRNClear
            // 
            this.btnMRNClear.BackColor = System.Drawing.Color.Navy;
            this.btnMRNClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMRNClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMRNClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMRNClear.Location = new System.Drawing.Point(434, 435);
            this.btnMRNClear.Name = "btnMRNClear";
            this.btnMRNClear.Size = new System.Drawing.Size(93, 30);
            this.btnMRNClear.TabIndex = 51;
            this.btnMRNClear.Text = "CLEAR";
            this.btnMRNClear.UseVisualStyleBackColor = false;
            this.btnMRNClear.Click += new System.EventHandler(this.btnMRNClear_Click);
            // 
            // txtMRNNumberOfUnits
            // 
            this.txtMRNNumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNNumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNNumberOfUnits.Location = new System.Drawing.Point(361, 66);
            this.txtMRNNumberOfUnits.Name = "txtMRNNumberOfUnits";
            this.txtMRNNumberOfUnits.ReadOnly = true;
            this.txtMRNNumberOfUnits.Size = new System.Drawing.Size(242, 27);
            this.txtMRNNumberOfUnits.TabIndex = 49;
            this.txtMRNNumberOfUnits.TabStop = false;
            // 
            // txtMRNNotes
            // 
            this.txtMRNNotes.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNNotes.Location = new System.Drawing.Point(361, 120);
            this.txtMRNNotes.Name = "txtMRNNotes";
            this.txtMRNNotes.Size = new System.Drawing.Size(242, 27);
            this.txtMRNNotes.TabIndex = 48;
            // 
            // lblMRNNumberOfUnits
            // 
            this.lblMRNNumberOfUnits.AutoSize = true;
            this.lblMRNNumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRNNumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNNumberOfUnits.Location = new System.Drawing.Point(363, 42);
            this.lblMRNNumberOfUnits.Name = "lblMRNNumberOfUnits";
            this.lblMRNNumberOfUnits.Size = new System.Drawing.Size(132, 21);
            this.lblMRNNumberOfUnits.TabIndex = 45;
            this.lblMRNNumberOfUnits.Text = "Number Of Units:";
            // 
            // lblMRNNotes
            // 
            this.lblMRNNotes.AutoSize = true;
            this.lblMRNNotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRNNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNNotes.Location = new System.Drawing.Point(363, 96);
            this.lblMRNNotes.Name = "lblMRNNotes";
            this.lblMRNNotes.Size = new System.Drawing.Size(54, 21);
            this.lblMRNNotes.TabIndex = 43;
            this.lblMRNNotes.Text = "Notes:";
            // 
            // txtMRNItemName
            // 
            this.txtMRNItemName.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNItemName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNItemName.Location = new System.Drawing.Point(108, 133);
            this.txtMRNItemName.Name = "txtMRNItemName";
            this.txtMRNItemName.ReadOnly = true;
            this.txtMRNItemName.Size = new System.Drawing.Size(242, 27);
            this.txtMRNItemName.TabIndex = 35;
            this.txtMRNItemName.TabStop = false;
            // 
            // lblMRNItemName
            // 
            this.lblMRNItemName.AutoSize = true;
            this.lblMRNItemName.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRNItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNItemName.Location = new System.Drawing.Point(110, 109);
            this.lblMRNItemName.Name = "lblMRNItemName";
            this.lblMRNItemName.Size = new System.Drawing.Size(90, 21);
            this.lblMRNItemName.TabIndex = 30;
            this.lblMRNItemName.Text = "Item Name:";
            // 
            // txtMRNItemID
            // 
            this.txtMRNItemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNItemID.Location = new System.Drawing.Point(108, 79);
            this.txtMRNItemID.Name = "txtMRNItemID";
            this.txtMRNItemID.ReadOnly = true;
            this.txtMRNItemID.Size = new System.Drawing.Size(242, 27);
            this.txtMRNItemID.TabIndex = 29;
            this.txtMRNItemID.TabStop = false;
            // 
            // lblMRNItemID
            // 
            this.lblMRNItemID.AutoSize = true;
            this.lblMRNItemID.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRNItemID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNItemID.Location = new System.Drawing.Point(110, 55);
            this.lblMRNItemID.Name = "lblMRNItemID";
            this.lblMRNItemID.Size = new System.Drawing.Size(63, 21);
            this.lblMRNItemID.TabIndex = 28;
            this.lblMRNItemID.Text = "Item ID:";
            // 
            // dgvMRNList
            // 
            this.dgvMRNList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMRNList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMRNList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMRNList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMRNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMRNList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMRNList.Location = new System.Drawing.Point(45, 228);
            this.dgvMRNList.Name = "dgvMRNList";
            this.dgvMRNList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMRNList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMRNList.Size = new System.Drawing.Size(673, 191);
            this.dgvMRNList.StandardTab = true;
            this.dgvMRNList.TabIndex = 0;
            this.dgvMRNList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMRNList_CellContentClick);
            // 
            // btnMRNConfirm
            // 
            this.btnMRNConfirm.BackColor = System.Drawing.Color.Navy;
            this.btnMRNConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMRNConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMRNConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMRNConfirm.Location = new System.Drawing.Point(199, 435);
            this.btnMRNConfirm.Name = "btnMRNConfirm";
            this.btnMRNConfirm.Size = new System.Drawing.Size(94, 30);
            this.btnMRNConfirm.TabIndex = 53;
            this.btnMRNConfirm.Text = "CONFIRM";
            this.btnMRNConfirm.UseVisualStyleBackColor = false;
            this.btnMRNConfirm.Click += new System.EventHandler(this.btnMRNConfirm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(692, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 31);
            this.button1.TabIndex = 61;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMRNdepartment
            // 
            this.txtMRNdepartment.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNdepartment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNdepartment.Location = new System.Drawing.Point(108, 187);
            this.txtMRNdepartment.Name = "txtMRNdepartment";
            this.txtMRNdepartment.ReadOnly = true;
            this.txtMRNdepartment.Size = new System.Drawing.Size(242, 27);
            this.txtMRNdepartment.TabIndex = 46;
            this.txtMRNdepartment.TabStop = false;
            // 
            // lblMRNdepartment
            // 
            this.lblMRNdepartment.AutoSize = true;
            this.lblMRNdepartment.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRNdepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNdepartment.Location = new System.Drawing.Point(110, 163);
            this.lblMRNdepartment.Name = "lblMRNdepartment";
            this.lblMRNdepartment.Size = new System.Drawing.Size(96, 21);
            this.lblMRNdepartment.TabIndex = 42;
            this.lblMRNdepartment.Text = "Department:";
            // 
            // btnMRNReject
            // 
            this.btnMRNReject.BackColor = System.Drawing.Color.Navy;
            this.btnMRNReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMRNReject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMRNReject.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMRNReject.Location = new System.Drawing.Point(319, 435);
            this.btnMRNReject.Name = "btnMRNReject";
            this.btnMRNReject.Size = new System.Drawing.Size(96, 30);
            this.btnMRNReject.TabIndex = 50;
            this.btnMRNReject.Text = "REJECTED";
            this.btnMRNReject.UseVisualStyleBackColor = false;
            this.btnMRNReject.Click += new System.EventHandler(this.btnMRNReject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtMRNNumberOfUnits);
            this.panel1.Controls.Add(this.lblMRNNotes);
            this.panel1.Controls.Add(this.lblMRNNumberOfUnits);
            this.panel1.Controls.Add(this.txtMRNNotes);
            this.panel1.Location = new System.Drawing.Point(45, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 181);
            this.panel1.TabIndex = 64;
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
            // ConfirmMRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.btnMRNConfirm);
            this.Controls.Add(this.btnMRNClear);
            this.Controls.Add(this.btnMRNReject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMRNdepartment);
            this.Controls.Add(this.lblMRNdepartment);
            this.Controls.Add(this.txtMRNItemName);
            this.Controls.Add(this.lblMRNItemName);
            this.Controls.Add(this.txtMRNItemID);
            this.Controls.Add(this.lblMRNItemID);
            this.Controls.Add(this.dgvMRNList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfirmMRN";
            this.Text = "Confirm Material Request Note";
            this.Load += new System.EventHandler(this.CreatePO_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRNList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMRNClear;
        private System.Windows.Forms.TextBox txtMRNNumberOfUnits;
        private System.Windows.Forms.TextBox txtMRNNotes;
        private System.Windows.Forms.Label lblMRNNumberOfUnits;
        private System.Windows.Forms.Label lblMRNNotes;
        private System.Windows.Forms.TextBox txtMRNItemName;
        private System.Windows.Forms.Label lblMRNItemName;
        private System.Windows.Forms.TextBox txtMRNItemID;
        private System.Windows.Forms.Label lblMRNItemID;
        private System.Windows.Forms.DataGridView dgvMRNList;
        private System.Windows.Forms.Button btnMRNConfirm;
        private System.Windows.Forms.Button button1;
        private TextBox txtMRNdepartment;
        private Label lblMRNdepartment;
        private Button btnMRNReject;
        private Panel panel1;
        private Label lblLoggedUser;
    }
}