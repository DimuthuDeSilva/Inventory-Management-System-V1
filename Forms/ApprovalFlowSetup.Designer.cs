using System.Drawing;

namespace Inventory_Management_System.Forms
{
    partial class ApprovalFlowSetup
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
            this.btnAFSClear = new System.Windows.Forms.Button();
            this.btnAFSUpdate = new System.Windows.Forms.Button();
            this.txtAFSofName = new System.Windows.Forms.TextBox();
            this.txtAFSofCode = new System.Windows.Forms.TextBox();
            this.txtAFSLevel = new System.Windows.Forms.TextBox();
            this.lblAFSofName = new System.Windows.Forms.Label();
            this.lblAFSofCode = new System.Windows.Forms.Label();
            this.lblAFSLevel = new System.Windows.Forms.Label();
            this.txtAFSFunctionName = new System.Windows.Forms.TextBox();
            this.lblAFSFunctionName = new System.Windows.Forms.Label();
            this.dgvAFSlist = new System.Windows.Forms.DataGridView();
            this.btnAFSDelete = new System.Windows.Forms.Button();
            this.btnAFSHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFSlist)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAFSClear
            // 
            this.btnAFSClear.BackColor = System.Drawing.Color.Navy;
            this.btnAFSClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAFSClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAFSClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAFSClear.Location = new System.Drawing.Point(484, 406);
            this.btnAFSClear.Name = "btnAFSClear";
            this.btnAFSClear.Size = new System.Drawing.Size(90, 30);
            this.btnAFSClear.TabIndex = 51;
            this.btnAFSClear.Text = "RESET";
            this.btnAFSClear.UseVisualStyleBackColor = false;
            this.btnAFSClear.Click += new System.EventHandler(this.btnAFSClear_Click);
            // 
            // btnAFSUpdate
            // 
            this.btnAFSUpdate.BackColor = System.Drawing.Color.Navy;
            this.btnAFSUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAFSUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAFSUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAFSUpdate.Location = new System.Drawing.Point(240, 406);
            this.btnAFSUpdate.Name = "btnAFSUpdate";
            this.btnAFSUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnAFSUpdate.TabIndex = 50;
            this.btnAFSUpdate.Text = "UPDATE";
            this.btnAFSUpdate.UseVisualStyleBackColor = false;
            this.btnAFSUpdate.Click += new System.EventHandler(this.btnAFSUpdate_Click);
            // 
            // txtAFSofName
            // 
            this.txtAFSofName.BackColor = System.Drawing.SystemColors.Control;
            this.txtAFSofName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFSofName.Location = new System.Drawing.Point(350, 99);
            this.txtAFSofName.Name = "txtAFSofName";
            this.txtAFSofName.Size = new System.Drawing.Size(242, 27);
            this.txtAFSofName.TabIndex = 38;
            // 
            // txtAFSofCode
            // 
            this.txtAFSofCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtAFSofCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFSofCode.Location = new System.Drawing.Point(350, 45);
            this.txtAFSofCode.Name = "txtAFSofCode";
            this.txtAFSofCode.Size = new System.Drawing.Size(242, 27);
            this.txtAFSofCode.TabIndex = 37;
            // 
            // txtAFSLevel
            // 
            this.txtAFSLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtAFSLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFSLevel.Location = new System.Drawing.Point(44, 99);
            this.txtAFSLevel.Name = "txtAFSLevel";
            this.txtAFSLevel.Size = new System.Drawing.Size(242, 27);
            this.txtAFSLevel.TabIndex = 35;
            // 
            // lblAFSofName
            // 
            this.lblAFSofName.AutoSize = true;
            this.lblAFSofName.BackColor = System.Drawing.SystemColors.Control;
            this.lblAFSofName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFSofName.Location = new System.Drawing.Point(352, 75);
            this.lblAFSofName.Name = "lblAFSofName";
            this.lblAFSofName.Size = new System.Drawing.Size(106, 21);
            this.lblAFSofName.TabIndex = 32;
            this.lblAFSofName.Text = "Officer Name:";
            // 
            // lblAFSofCode
            // 
            this.lblAFSofCode.AutoSize = true;
            this.lblAFSofCode.BackColor = System.Drawing.SystemColors.Control;
            this.lblAFSofCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFSofCode.Location = new System.Drawing.Point(352, 21);
            this.lblAFSofCode.Name = "lblAFSofCode";
            this.lblAFSofCode.Size = new System.Drawing.Size(100, 21);
            this.lblAFSofCode.TabIndex = 31;
            this.lblAFSofCode.Text = "Officer Code:";
            // 
            // lblAFSLevel
            // 
            this.lblAFSLevel.AutoSize = true;
            this.lblAFSLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblAFSLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFSLevel.Location = new System.Drawing.Point(46, 75);
            this.lblAFSLevel.Name = "lblAFSLevel";
            this.lblAFSLevel.Size = new System.Drawing.Size(49, 21);
            this.lblAFSLevel.TabIndex = 30;
            this.lblAFSLevel.Text = "Level:";
            // 
            // txtAFSFunctionName
            // 
            this.txtAFSFunctionName.BackColor = System.Drawing.SystemColors.Control;
            this.txtAFSFunctionName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFSFunctionName.Location = new System.Drawing.Point(44, 45);
            this.txtAFSFunctionName.Name = "txtAFSFunctionName";
            this.txtAFSFunctionName.Size = new System.Drawing.Size(242, 27);
            this.txtAFSFunctionName.TabIndex = 29;
            // 
            // lblAFSFunctionName
            // 
            this.lblAFSFunctionName.AutoSize = true;
            this.lblAFSFunctionName.BackColor = System.Drawing.SystemColors.Control;
            this.lblAFSFunctionName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFSFunctionName.Location = new System.Drawing.Point(46, 21);
            this.lblAFSFunctionName.Name = "lblAFSFunctionName";
            this.lblAFSFunctionName.Size = new System.Drawing.Size(119, 21);
            this.lblAFSFunctionName.TabIndex = 28;
            this.lblAFSFunctionName.Text = "Function Name:";
            // 
            // dgvAFSlist
            // 
            this.dgvAFSlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAFSlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAFSlist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAFSlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAFSlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAFSlist.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAFSlist.Location = new System.Drawing.Point(44, 186);
            this.dgvAFSlist.Name = "dgvAFSlist";
            this.dgvAFSlist.ReadOnly = true;
            this.dgvAFSlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAFSlist.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAFSlist.Size = new System.Drawing.Size(636, 204);
            this.dgvAFSlist.StandardTab = true;
            this.dgvAFSlist.TabIndex = 0;
            this.dgvAFSlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAFSlist_CellDoubleClick);
            // 
            // btnAFSDelete
            // 
            this.btnAFSDelete.BackColor = System.Drawing.Color.Navy;
            this.btnAFSDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAFSDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAFSDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAFSDelete.Location = new System.Drawing.Point(364, 406);
            this.btnAFSDelete.Name = "btnAFSDelete";
            this.btnAFSDelete.Size = new System.Drawing.Size(90, 30);
            this.btnAFSDelete.TabIndex = 54;
            this.btnAFSDelete.Text = "DELETE";
            this.btnAFSDelete.UseVisualStyleBackColor = false;
            this.btnAFSDelete.Click += new System.EventHandler(this.btnAFSDelete_Click);
            // 
            // btnAFSHome
            // 
            this.btnAFSHome.BackColor = System.Drawing.Color.DarkRed;
            this.btnAFSHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAFSHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAFSHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAFSHome.Location = new System.Drawing.Point(648, 1);
            this.btnAFSHome.Name = "btnAFSHome";
            this.btnAFSHome.Size = new System.Drawing.Size(72, 31);
            this.btnAFSHome.TabIndex = 56;
            this.btnAFSHome.Text = "HOME";
            this.btnAFSHome.UseVisualStyleBackColor = false;
            this.btnAFSHome.Click += new System.EventHandler(this.btnAFSHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtAFSofName);
            this.panel1.Controls.Add(this.lblAFSFunctionName);
            this.panel1.Controls.Add(this.txtAFSFunctionName);
            this.panel1.Controls.Add(this.lblAFSLevel);
            this.panel1.Controls.Add(this.txtAFSLevel);
            this.panel1.Controls.Add(this.lblAFSofCode);
            this.panel1.Controls.Add(this.lblAFSofName);
            this.panel1.Controls.Add(this.txtAFSofCode);
            this.panel1.Location = new System.Drawing.Point(44, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 142);
            this.panel1.TabIndex = 57;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Navy;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(120, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
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
            // ApprovalFlowSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 453);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAFSDelete);
            this.Controls.Add(this.btnAFSClear);
            this.Controls.Add(this.btnAFSUpdate);
            this.Controls.Add(this.btnAFSHome);
            this.Controls.Add(this.dgvAFSlist);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ApprovalFlowSetup";
            this.Text = "Approval Flow Setup";
            this.Load += new System.EventHandler(this.ApprovalFlowSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFSlist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAFSClear;
        private System.Windows.Forms.Button btnAFSUpdate;
        private System.Windows.Forms.TextBox txtAFSofName;
        private System.Windows.Forms.TextBox txtAFSofCode;
        private System.Windows.Forms.TextBox txtAFSLevel;
        private System.Windows.Forms.Label lblAFSofName;
        private System.Windows.Forms.Label lblAFSofCode;
        private System.Windows.Forms.Label lblAFSLevel;
        private System.Windows.Forms.TextBox txtAFSFunctionName;
        private System.Windows.Forms.Label lblAFSFunctionName;
        private System.Windows.Forms.DataGridView dgvAFSlist;
        private System.Windows.Forms.Button btnAFSDelete;
        private System.Windows.Forms.Button btnAFSHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblLoggedUser;
    }
}