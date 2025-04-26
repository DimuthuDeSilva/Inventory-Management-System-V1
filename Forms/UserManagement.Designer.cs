using System.Drawing;

namespace Inventory_Management_System.Forms
{
    partial class UserManagement
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
            this.btnUMClear = new System.Windows.Forms.Button();
            this.btnUMUpdate = new System.Windows.Forms.Button();
            this.lblumRole = new System.Windows.Forms.Label();
            this.lblumPassword = new System.Windows.Forms.Label();
            this.lblumIsActive = new System.Windows.Forms.Label();
            this.txtumEmail = new System.Windows.Forms.TextBox();
            this.lblumEmail = new System.Windows.Forms.Label();
            this.lblumFullName = new System.Windows.Forms.Label();
            this.lblumUsername = new System.Windows.Forms.Label();
            this.txtUMuserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.dgvUMlist = new System.Windows.Forms.DataGridView();
            this.btnUMAdd = new System.Windows.Forms.Button();
            this.btnUMDelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtumPassword = new System.Windows.Forms.TextBox();
            this.txtumUsername = new System.Windows.Forms.TextBox();
            this.txtumFullName = new System.Windows.Forms.TextBox();
            this.txtumStatus = new System.Windows.Forms.TextBox();
            this.txtumRole = new System.Windows.Forms.TextBox();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUMlist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUMClear
            // 
            this.btnUMClear.BackColor = System.Drawing.Color.Navy;
            this.btnUMClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUMClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUMClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUMClear.Location = new System.Drawing.Point(566, 483);
            this.btnUMClear.Name = "btnUMClear";
            this.btnUMClear.Size = new System.Drawing.Size(90, 30);
            this.btnUMClear.TabIndex = 51;
            this.btnUMClear.Text = "CLEAR";
            this.btnUMClear.UseVisualStyleBackColor = false;
            this.btnUMClear.Click += new System.EventHandler(this.btnUMClear_Click_1);
            // 
            // btnUMUpdate
            // 
            this.btnUMUpdate.BackColor = System.Drawing.Color.Navy;
            this.btnUMUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUMUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUMUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUMUpdate.Location = new System.Drawing.Point(374, 483);
            this.btnUMUpdate.Name = "btnUMUpdate";
            this.btnUMUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUMUpdate.TabIndex = 50;
            this.btnUMUpdate.Text = "UPDATE";
            this.btnUMUpdate.UseVisualStyleBackColor = false;
            this.btnUMUpdate.Click += new System.EventHandler(this.btnUMUpdate_Click);
            // 
            // lblumRole
            // 
            this.lblumRole.AutoSize = true;
            this.lblumRole.BackColor = System.Drawing.SystemColors.Control;
            this.lblumRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblumRole.Location = new System.Drawing.Point(615, 62);
            this.lblumRole.Name = "lblumRole";
            this.lblumRole.Size = new System.Drawing.Size(44, 21);
            this.lblumRole.TabIndex = 45;
            this.lblumRole.Text = "Role:";
            // 
            // lblumPassword
            // 
            this.lblumPassword.AutoSize = true;
            this.lblumPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblumPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblumPassword.Location = new System.Drawing.Point(349, 165);
            this.lblumPassword.Name = "lblumPassword";
            this.lblumPassword.Size = new System.Drawing.Size(79, 21);
            this.lblumPassword.TabIndex = 42;
            this.lblumPassword.Text = "Password:";
            // 
            // lblumIsActive
            // 
            this.lblumIsActive.AutoSize = true;
            this.lblumIsActive.BackColor = System.Drawing.SystemColors.Control;
            this.lblumIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblumIsActive.Location = new System.Drawing.Point(615, 128);
            this.lblumIsActive.Name = "lblumIsActive";
            this.lblumIsActive.Size = new System.Drawing.Size(55, 21);
            this.lblumIsActive.TabIndex = 41;
            this.lblumIsActive.Text = "Status:";
            // 
            // txtumEmail
            // 
            this.txtumEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtumEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtumEmail.Location = new System.Drawing.Point(347, 137);
            this.txtumEmail.Name = "txtumEmail";
            this.txtumEmail.Size = new System.Drawing.Size(242, 27);
            this.txtumEmail.TabIndex = 39;
            // 
            // lblumEmail
            // 
            this.lblumEmail.AutoSize = true;
            this.lblumEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblumEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblumEmail.Location = new System.Drawing.Point(349, 113);
            this.lblumEmail.Name = "lblumEmail";
            this.lblumEmail.Size = new System.Drawing.Size(51, 21);
            this.lblumEmail.TabIndex = 33;
            this.lblumEmail.Text = "Email:";
            // 
            // lblumFullName
            // 
            this.lblumFullName.AutoSize = true;
            this.lblumFullName.BackColor = System.Drawing.SystemColors.Control;
            this.lblumFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblumFullName.Location = new System.Drawing.Point(349, 62);
            this.lblumFullName.Name = "lblumFullName";
            this.lblumFullName.Size = new System.Drawing.Size(84, 21);
            this.lblumFullName.TabIndex = 32;
            this.lblumFullName.Text = "Full Name:";
            // 
            // lblumUsername
            // 
            this.lblumUsername.AutoSize = true;
            this.lblumUsername.BackColor = System.Drawing.SystemColors.Control;
            this.lblumUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblumUsername.Location = new System.Drawing.Point(82, 128);
            this.lblumUsername.Name = "lblumUsername";
            this.lblumUsername.Size = new System.Drawing.Size(91, 21);
            this.lblumUsername.TabIndex = 30;
            this.lblumUsername.Text = "User Name:";
            // 
            // txtUMuserID
            // 
            this.txtUMuserID.BackColor = System.Drawing.SystemColors.Control;
            this.txtUMuserID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUMuserID.Location = new System.Drawing.Point(80, 86);
            this.txtUMuserID.Name = "txtUMuserID";
            this.txtUMuserID.ReadOnly = true;
            this.txtUMuserID.Size = new System.Drawing.Size(242, 27);
            this.txtUMuserID.TabIndex = 29;
            this.txtUMuserID.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(82, 62);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(64, 21);
            this.lblUserID.TabIndex = 28;
            this.lblUserID.Text = "User ID:";
            // 
            // dgvUMlist
            // 
            this.dgvUMlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUMlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUMlist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUMlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvUMlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUMlist.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUMlist.Location = new System.Drawing.Point(51, 249);
            this.dgvUMlist.Name = "dgvUMlist";
            this.dgvUMlist.ReadOnly = true;
            this.dgvUMlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUMlist.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUMlist.Size = new System.Drawing.Size(828, 216);
            this.dgvUMlist.StandardTab = true;
            this.dgvUMlist.TabIndex = 0;
            this.dgvUMlist.TabStop = false;
            this.dgvUMlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUMlist_CellDoubleClick);
            // 
            // btnUMAdd
            // 
            this.btnUMAdd.BackColor = System.Drawing.Color.Navy;
            this.btnUMAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUMAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUMAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUMAdd.Location = new System.Drawing.Point(278, 483);
            this.btnUMAdd.Name = "btnUMAdd";
            this.btnUMAdd.Size = new System.Drawing.Size(90, 30);
            this.btnUMAdd.TabIndex = 53;
            this.btnUMAdd.Text = "ADD";
            this.btnUMAdd.UseVisualStyleBackColor = false;
            this.btnUMAdd.Click += new System.EventHandler(this.btnUMAdd_Click);
            // 
            // btnUMDelete
            // 
            this.btnUMDelete.BackColor = System.Drawing.Color.Navy;
            this.btnUMDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUMDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUMDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUMDelete.Location = new System.Drawing.Point(470, 483);
            this.btnUMDelete.Name = "btnUMDelete";
            this.btnUMDelete.Size = new System.Drawing.Size(90, 30);
            this.btnUMDelete.TabIndex = 54;
            this.btnUMDelete.Text = "DELETE";
            this.btnUMDelete.UseVisualStyleBackColor = false;
            this.btnUMDelete.Click += new System.EventHandler(this.btnUMDelete_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkRed;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Location = new System.Drawing.Point(844, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 31);
            this.btnHome.TabIndex = 61;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtumPassword
            // 
            this.txtumPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtumPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtumPassword.Location = new System.Drawing.Point(347, 189);
            this.txtumPassword.Name = "txtumPassword";
            this.txtumPassword.Size = new System.Drawing.Size(242, 27);
            this.txtumPassword.TabIndex = 64;
            // 
            // txtumUsername
            // 
            this.txtumUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtumUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtumUsername.Location = new System.Drawing.Point(80, 152);
            this.txtumUsername.Name = "txtumUsername";
            this.txtumUsername.Size = new System.Drawing.Size(242, 27);
            this.txtumUsername.TabIndex = 65;
            // 
            // txtumFullName
            // 
            this.txtumFullName.BackColor = System.Drawing.SystemColors.Control;
            this.txtumFullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtumFullName.Location = new System.Drawing.Point(347, 86);
            this.txtumFullName.Name = "txtumFullName";
            this.txtumFullName.Size = new System.Drawing.Size(242, 27);
            this.txtumFullName.TabIndex = 66;
            // 
            // txtumStatus
            // 
            this.txtumStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtumStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtumStatus.Location = new System.Drawing.Point(613, 152);
            this.txtumStatus.Name = "txtumStatus";
            this.txtumStatus.Size = new System.Drawing.Size(242, 27);
            this.txtumStatus.TabIndex = 36;
            // 
            // txtumRole
            // 
            this.txtumRole.BackColor = System.Drawing.SystemColors.Control;
            this.txtumRole.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtumRole.Location = new System.Drawing.Point(613, 86);
            this.txtumRole.Name = "txtumRole";
            this.txtumRole.Size = new System.Drawing.Size(242, 27);
            this.txtumRole.TabIndex = 67;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(12, 9);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(75, 15);
            this.lblLoggedUser.TabIndex = 68;
            this.lblLoggedUser.Text = "Current User:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(51, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 186);
            this.panel1.TabIndex = 69;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.txtumRole);
            this.Controls.Add(this.txtumFullName);
            this.Controls.Add(this.txtumUsername);
            this.Controls.Add(this.txtumPassword);
            this.Controls.Add(this.btnUMDelete);
            this.Controls.Add(this.btnUMAdd);
            this.Controls.Add(this.btnUMClear);
            this.Controls.Add(this.btnUMUpdate);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblumRole);
            this.Controls.Add(this.lblumPassword);
            this.Controls.Add(this.lblumIsActive);
            this.Controls.Add(this.txtumEmail);
            this.Controls.Add(this.txtumStatus);
            this.Controls.Add(this.lblumEmail);
            this.Controls.Add(this.lblumFullName);
            this.Controls.Add(this.lblumUsername);
            this.Controls.Add(this.txtUMuserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.dgvUMlist);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserManagement";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagementForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUMlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUMClear;
        private System.Windows.Forms.Button btnUMUpdate;
        private System.Windows.Forms.Label lblumRole;
        private System.Windows.Forms.Label lblumPassword;
        private System.Windows.Forms.Label lblumIsActive;
        private System.Windows.Forms.TextBox txtumEmail;
        private System.Windows.Forms.Label lblumEmail;
        private System.Windows.Forms.Label lblumFullName;
        private System.Windows.Forms.Label lblumUsername;
        private System.Windows.Forms.TextBox txtUMuserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.DataGridView dgvUMlist;
        private System.Windows.Forms.Button btnUMAdd;
        private System.Windows.Forms.Button btnUMDelete;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtumPassword;
        private System.Windows.Forms.TextBox txtumUsername;
        private System.Windows.Forms.TextBox txtumFullName;
        private System.Windows.Forms.TextBox txtumStatus;
        private System.Windows.Forms.TextBox txtumRole;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Panel panel1;
    }
}