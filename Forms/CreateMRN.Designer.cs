using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    partial class CreateMRN
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
            this.btnCPOClear = new System.Windows.Forms.Button();
            this.txtMRNNumberOfUnits = new System.Windows.Forms.TextBox();
            this.txtMRNNotes = new System.Windows.Forms.TextBox();
            this.lblMRNNumberOfUnits = new System.Windows.Forms.Label();
            this.lblMRNNotes = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblMRNItemName = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblMRNItemID = new System.Windows.Forms.Label();
            this.dgvMRNList = new System.Windows.Forms.DataGridView();
            this.btnCPOAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.txtMRNdepartment = new System.Windows.Forms.TextBox();
            this.lblMRNdepartment = new System.Windows.Forms.Label();
            this.btnCPOUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRNList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCPOClear
            // 
            this.btnCPOClear.BackColor = System.Drawing.Color.Navy;
            this.btnCPOClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPOClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPOClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCPOClear.Location = new System.Drawing.Point(461, 435);
            this.btnCPOClear.Name = "btnCPOClear";
            this.btnCPOClear.Size = new System.Drawing.Size(90, 30);
            this.btnCPOClear.TabIndex = 51;
            this.btnCPOClear.Text = "RESET";
            this.btnCPOClear.UseVisualStyleBackColor = false;
            this.btnCPOClear.Click += new System.EventHandler(this.btnCPOClear_Click);
            // 
            // txtMRNNumberOfUnits
            // 
            this.txtMRNNumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNNumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNNumberOfUnits.Location = new System.Drawing.Point(426, 79);
            this.txtMRNNumberOfUnits.Name = "txtMRNNumberOfUnits";
            this.txtMRNNumberOfUnits.Size = new System.Drawing.Size(242, 27);
            this.txtMRNNumberOfUnits.TabIndex = 49;
            // 
            // txtMRNNotes
            // 
            this.txtMRNNotes.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNNotes.Location = new System.Drawing.Point(426, 133);
            this.txtMRNNotes.Name = "txtMRNNotes";
            this.txtMRNNotes.Size = new System.Drawing.Size(242, 27);
            this.txtMRNNotes.TabIndex = 48;
            // 
            // lblMRNNumberOfUnits
            // 
            this.lblMRNNumberOfUnits.AutoSize = true;
            this.lblMRNNumberOfUnits.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRNNumberOfUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNNumberOfUnits.Location = new System.Drawing.Point(428, 55);
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
            this.lblMRNNotes.Location = new System.Drawing.Point(428, 109);
            this.lblMRNNotes.Name = "lblMRNNotes";
            this.lblMRNNotes.Size = new System.Drawing.Size(54, 21);
            this.lblMRNNotes.TabIndex = 43;
            this.lblMRNNotes.Text = "Notes:";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(112, 133);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(242, 27);
            this.txtItemName.TabIndex = 35;
            // 
            // lblMRNItemName
            // 
            this.lblMRNItemName.AutoSize = true;
            this.lblMRNItemName.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRNItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNItemName.Location = new System.Drawing.Point(114, 109);
            this.lblMRNItemName.Name = "lblMRNItemName";
            this.lblMRNItemName.Size = new System.Drawing.Size(90, 21);
            this.lblMRNItemName.TabIndex = 30;
            this.lblMRNItemName.Text = "Item Name:";
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(112, 79);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(242, 27);
            this.txtItemID.TabIndex = 29;
            this.txtItemID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemID_KeyUp);
            // 
            // lblMRNItemID
            // 
            this.lblMRNItemID.AutoSize = true;
            this.lblMRNItemID.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRNItemID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNItemID.Location = new System.Drawing.Point(114, 55);
            this.lblMRNItemID.Name = "lblMRNItemID";
            this.lblMRNItemID.Size = new System.Drawing.Size(63, 21);
            this.lblMRNItemID.TabIndex = 28;
            this.lblMRNItemID.Text = "Item ID:";
            // 
            // dgvMRNList
            // 
            this.dgvMRNList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvMRNList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMRNList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMRNList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMRNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMRNList.Location = new System.Drawing.Point(100, 238);
            this.dgvMRNList.Name = "dgvMRNList";
            this.dgvMRNList.ReadOnly = true;
            this.dgvMRNList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMRNList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMRNList.Size = new System.Drawing.Size(583, 181);
            this.dgvMRNList.StandardTab = true;
            this.dgvMRNList.TabIndex = 0;
            this.dgvMRNList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMRNList_CellContentClick);
            // 
            // btnCPOAdd
            // 
            this.btnCPOAdd.BackColor = System.Drawing.Color.Navy;
            this.btnCPOAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPOAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPOAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCPOAdd.Location = new System.Drawing.Point(226, 435);
            this.btnCPOAdd.Name = "btnCPOAdd";
            this.btnCPOAdd.Size = new System.Drawing.Size(90, 30);
            this.btnCPOAdd.TabIndex = 53;
            this.btnCPOAdd.Text = "ADD";
            this.btnCPOAdd.UseVisualStyleBackColor = false;
            this.btnCPOAdd.Click += new System.EventHandler(this.btnCPOAdd_Click);
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
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(16, 10);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(37, 15);
            this.lblLoggedUser.TabIndex = 63;
            this.lblLoggedUser.Text = "label1";
            this.lblLoggedUser.Click += new System.EventHandler(this.lblLoggedUser_Click);
            // 
            // txtMRNdepartment
            // 
            this.txtMRNdepartment.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNdepartment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRNdepartment.Location = new System.Drawing.Point(112, 187);
            this.txtMRNdepartment.Name = "txtMRNdepartment";
            this.txtMRNdepartment.Size = new System.Drawing.Size(242, 27);
            this.txtMRNdepartment.TabIndex = 46;
            // 
            // lblMRNdepartment
            // 
            this.lblMRNdepartment.AutoSize = true;
            this.lblMRNdepartment.BackColor = System.Drawing.SystemColors.Control;
            this.lblMRNdepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNdepartment.Location = new System.Drawing.Point(114, 163);
            this.lblMRNdepartment.Name = "lblMRNdepartment";
            this.lblMRNdepartment.Size = new System.Drawing.Size(96, 21);
            this.lblMRNdepartment.TabIndex = 42;
            this.lblMRNdepartment.Text = "Department:";
            // 
            // btnCPOUpdate
            // 
            this.btnCPOUpdate.BackColor = System.Drawing.Color.Navy;
            this.btnCPOUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPOUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPOUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCPOUpdate.Location = new System.Drawing.Point(346, 435);
            this.btnCPOUpdate.Name = "btnCPOUpdate";
            this.btnCPOUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnCPOUpdate.TabIndex = 50;
            this.btnCPOUpdate.Text = "CANCEL";
            this.btnCPOUpdate.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(100, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 181);
            this.panel1.TabIndex = 64;
            // 
            // CreateMRNform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.btnCPOAdd);
            this.Controls.Add(this.btnCPOClear);
            this.Controls.Add(this.btnCPOUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMRNNumberOfUnits);
            this.Controls.Add(this.txtMRNNotes);
            this.Controls.Add(this.txtMRNdepartment);
            this.Controls.Add(this.lblMRNNumberOfUnits);
            this.Controls.Add(this.lblMRNNotes);
            this.Controls.Add(this.lblMRNdepartment);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblMRNItemName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblMRNItemID);
            this.Controls.Add(this.dgvMRNList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateMRNform";
            this.Text = "Create Material Request Note";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreatePO_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRNList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCPOClear;
        private System.Windows.Forms.TextBox txtMRNNumberOfUnits;
        private System.Windows.Forms.TextBox txtMRNNotes;
        private System.Windows.Forms.Label lblMRNNumberOfUnits;
        private System.Windows.Forms.Label lblMRNNotes;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblMRNItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblMRNItemID;
        private System.Windows.Forms.DataGridView dgvMRNList;
        private System.Windows.Forms.Button btnCPOAdd;
        private System.Windows.Forms.Button button1;
        private Label lblLoggedUser;
        private TextBox txtMRNdepartment;
        private Label lblMRNdepartment;
        private Button btnCPOUpdate;
        private Panel panel1;
    }
}