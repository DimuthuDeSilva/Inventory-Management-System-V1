using System.Drawing;

namespace Inventory_Management_System.Forms
{
    partial class CreatePayment
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
            this.btnPmntReset = new System.Windows.Forms.Button();
            this.btnPmntProcess = new System.Windows.Forms.Button();
            this.txtpmntNotes = new System.Windows.Forms.TextBox();
            this.txtpmntSupplierID = new System.Windows.Forms.TextBox();
            this.lblAPONotes = new System.Windows.Forms.Label();
            this.lblAPOSupplierID = new System.Windows.Forms.Label();
            this.lblpmntReference = new System.Windows.Forms.Label();
            this.txtpmntStatus = new System.Windows.Forms.TextBox();
            this.txtpmntReference = new System.Windows.Forms.TextBox();
            this.txtpmntNumber = new System.Windows.Forms.TextBox();
            this.lblpmntStatus = new System.Windows.Forms.Label();
            this.lblAPONumber = new System.Windows.Forms.Label();
            this.txtPOID = new System.Windows.Forms.TextBox();
            this.lblPOID = new System.Windows.Forms.Label();
            this.dgvpmntList = new System.Windows.Forms.DataGridView();
            this.txtxpmntAmount = new System.Windows.Forms.TextBox();
            this.lblpmntAmount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtpmntMethod = new System.Windows.Forms.TextBox();
            this.lblpmntPaymentMethod = new System.Windows.Forms.Label();
            this.dtpAPOOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblAPOOrderDate = new System.Windows.Forms.Label();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpmntList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPmntReset
            // 
            this.btnPmntReset.BackColor = System.Drawing.Color.Navy;
            this.btnPmntReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPmntReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPmntReset.Location = new System.Drawing.Point(455, 488);
            this.btnPmntReset.Name = "btnPmntReset";
            this.btnPmntReset.Size = new System.Drawing.Size(98, 30);
            this.btnPmntReset.TabIndex = 51;
            this.btnPmntReset.Text = "RESET";
            this.btnPmntReset.UseVisualStyleBackColor = false;
            this.btnPmntReset.Click += new System.EventHandler(this.btnPmntReset_Click);
            // 
            // btnPmntProcess
            // 
            this.btnPmntProcess.BackColor = System.Drawing.Color.Navy;
            this.btnPmntProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPmntProcess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPmntProcess.Location = new System.Drawing.Point(345, 488);
            this.btnPmntProcess.Name = "btnPmntProcess";
            this.btnPmntProcess.Size = new System.Drawing.Size(98, 30);
            this.btnPmntProcess.TabIndex = 50;
            this.btnPmntProcess.Text = "PROCESS";
            this.btnPmntProcess.UseVisualStyleBackColor = false;
            this.btnPmntProcess.Click += new System.EventHandler(this.btnPmntProcess_Click);
            // 
            // txtpmntNotes
            // 
            this.txtpmntNotes.BackColor = System.Drawing.SystemColors.Control;
            this.txtpmntNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpmntNotes.Location = new System.Drawing.Point(615, 435);
            this.txtpmntNotes.Name = "txtpmntNotes";
            this.txtpmntNotes.Size = new System.Drawing.Size(242, 27);
            this.txtpmntNotes.TabIndex = 48;
            // 
            // txtpmntSupplierID
            // 
            this.txtpmntSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.txtpmntSupplierID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpmntSupplierID.Location = new System.Drawing.Point(47, 434);
            this.txtpmntSupplierID.Name = "txtpmntSupplierID";
            this.txtpmntSupplierID.ReadOnly = true;
            this.txtpmntSupplierID.Size = new System.Drawing.Size(242, 27);
            this.txtpmntSupplierID.TabIndex = 46;
            this.txtpmntSupplierID.TabStop = false;
            // 
            // lblAPONotes
            // 
            this.lblAPONotes.AutoSize = true;
            this.lblAPONotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPONotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPONotes.Location = new System.Drawing.Point(617, 410);
            this.lblAPONotes.Name = "lblAPONotes";
            this.lblAPONotes.Size = new System.Drawing.Size(54, 21);
            this.lblAPONotes.TabIndex = 43;
            this.lblAPONotes.Text = "Notes:";
            // 
            // lblAPOSupplierID
            // 
            this.lblAPOSupplierID.AutoSize = true;
            this.lblAPOSupplierID.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPOSupplierID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPOSupplierID.Location = new System.Drawing.Point(49, 410);
            this.lblAPOSupplierID.Name = "lblAPOSupplierID";
            this.lblAPOSupplierID.Size = new System.Drawing.Size(90, 21);
            this.lblAPOSupplierID.TabIndex = 42;
            this.lblAPOSupplierID.Text = "Supplier ID:";
            // 
            // lblpmntReference
            // 
            this.lblpmntReference.AutoSize = true;
            this.lblpmntReference.BackColor = System.Drawing.SystemColors.Control;
            this.lblpmntReference.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmntReference.Location = new System.Drawing.Point(617, 302);
            this.lblpmntReference.Name = "lblpmntReference";
            this.lblpmntReference.Size = new System.Drawing.Size(146, 21);
            this.lblpmntReference.TabIndex = 41;
            this.lblpmntReference.Text = "Payment Reference:";
            // 
            // txtpmntStatus
            // 
            this.txtpmntStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtpmntStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpmntStatus.Location = new System.Drawing.Point(615, 380);
            this.txtpmntStatus.Name = "txtpmntStatus";
            this.txtpmntStatus.Size = new System.Drawing.Size(242, 27);
            this.txtpmntStatus.TabIndex = 40;
            // 
            // txtpmntReference
            // 
            this.txtpmntReference.BackColor = System.Drawing.SystemColors.Control;
            this.txtpmntReference.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpmntReference.Location = new System.Drawing.Point(615, 326);
            this.txtpmntReference.Name = "txtpmntReference";
            this.txtpmntReference.Size = new System.Drawing.Size(242, 27);
            this.txtpmntReference.TabIndex = 36;
            // 
            // txtpmntNumber
            // 
            this.txtpmntNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtpmntNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpmntNumber.Location = new System.Drawing.Point(47, 380);
            this.txtpmntNumber.Name = "txtpmntNumber";
            this.txtpmntNumber.ReadOnly = true;
            this.txtpmntNumber.Size = new System.Drawing.Size(242, 27);
            this.txtpmntNumber.TabIndex = 35;
            this.txtpmntNumber.TabStop = false;
            // 
            // lblpmntStatus
            // 
            this.lblpmntStatus.AutoSize = true;
            this.lblpmntStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblpmntStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmntStatus.Location = new System.Drawing.Point(617, 356);
            this.lblpmntStatus.Name = "lblpmntStatus";
            this.lblpmntStatus.Size = new System.Drawing.Size(92, 21);
            this.lblpmntStatus.TabIndex = 34;
            this.lblpmntStatus.Text = "GRN Status:";
            // 
            // lblAPONumber
            // 
            this.lblAPONumber.AutoSize = true;
            this.lblAPONumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPONumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPONumber.Location = new System.Drawing.Point(49, 356);
            this.lblAPONumber.Name = "lblAPONumber";
            this.lblAPONumber.Size = new System.Drawing.Size(96, 21);
            this.lblAPONumber.TabIndex = 30;
            this.lblAPONumber.Text = "PO Number:";
            // 
            // txtPOID
            // 
            this.txtPOID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPOID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOID.Location = new System.Drawing.Point(47, 326);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.ReadOnly = true;
            this.txtPOID.Size = new System.Drawing.Size(242, 27);
            this.txtPOID.TabIndex = 29;
            this.txtPOID.TabStop = false;
            // 
            // lblPOID
            // 
            this.lblPOID.AutoSize = true;
            this.lblPOID.BackColor = System.Drawing.SystemColors.Control;
            this.lblPOID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOID.Location = new System.Drawing.Point(49, 302);
            this.lblPOID.Name = "lblPOID";
            this.lblPOID.Size = new System.Drawing.Size(53, 21);
            this.lblPOID.TabIndex = 28;
            this.lblPOID.Text = "PO ID:";
            // 
            // dgvpmntList
            // 
            this.dgvpmntList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvpmntList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpmntList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvpmntList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvpmntList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpmntList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvpmntList.Location = new System.Drawing.Point(26, 43);
            this.dgvpmntList.Name = "dgvpmntList";
            this.dgvpmntList.ReadOnly = true;
            this.dgvpmntList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvpmntList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpmntList.Size = new System.Drawing.Size(857, 229);
            this.dgvpmntList.StandardTab = true;
            this.dgvpmntList.TabIndex = 0;
            this.dgvpmntList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpmntList_CellDoubleClick);
            // 
            // txtxpmntAmount
            // 
            this.txtxpmntAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtxpmntAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxpmntAmount.Location = new System.Drawing.Point(332, 326);
            this.txtxpmntAmount.Name = "txtxpmntAmount";
            this.txtxpmntAmount.ReadOnly = true;
            this.txtxpmntAmount.Size = new System.Drawing.Size(242, 27);
            this.txtxpmntAmount.TabIndex = 49;
            this.txtxpmntAmount.TabStop = false;
            // 
            // lblpmntAmount
            // 
            this.lblpmntAmount.AutoSize = true;
            this.lblpmntAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblpmntAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmntAmount.Location = new System.Drawing.Point(334, 302);
            this.lblpmntAmount.Name = "lblpmntAmount";
            this.lblpmntAmount.Size = new System.Drawing.Size(69, 21);
            this.lblpmntAmount.TabIndex = 45;
            this.lblpmntAmount.Text = "Amount:";
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
            // txtpmntMethod
            // 
            this.txtpmntMethod.BackColor = System.Drawing.SystemColors.Control;
            this.txtpmntMethod.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpmntMethod.Location = new System.Drawing.Point(332, 380);
            this.txtpmntMethod.Name = "txtpmntMethod";
            this.txtpmntMethod.Size = new System.Drawing.Size(242, 27);
            this.txtpmntMethod.TabIndex = 64;
            // 
            // lblpmntPaymentMethod
            // 
            this.lblpmntPaymentMethod.AutoSize = true;
            this.lblpmntPaymentMethod.BackColor = System.Drawing.SystemColors.Control;
            this.lblpmntPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmntPaymentMethod.Location = new System.Drawing.Point(334, 356);
            this.lblpmntPaymentMethod.Name = "lblpmntPaymentMethod";
            this.lblpmntPaymentMethod.Size = new System.Drawing.Size(131, 21);
            this.lblpmntPaymentMethod.TabIndex = 63;
            this.lblpmntPaymentMethod.Text = "Payment Method:";
            // 
            // dtpAPOOrderDate
            // 
            this.dtpAPOOrderDate.CalendarFont = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAPOOrderDate.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAPOOrderDate.Location = new System.Drawing.Point(332, 434);
            this.dtpAPOOrderDate.Name = "dtpAPOOrderDate";
            this.dtpAPOOrderDate.Size = new System.Drawing.Size(242, 25);
            this.dtpAPOOrderDate.TabIndex = 58;
            this.dtpAPOOrderDate.TabStop = false;
            // 
            // lblAPOOrderDate
            // 
            this.lblAPOOrderDate.AutoSize = true;
            this.lblAPOOrderDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblAPOOrderDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPOOrderDate.Location = new System.Drawing.Point(334, 410);
            this.lblAPOOrderDate.Name = "lblAPOOrderDate";
            this.lblAPOOrderDate.Size = new System.Drawing.Size(90, 21);
            this.lblAPOOrderDate.TabIndex = 32;
            this.lblAPOOrderDate.Text = "Order Date:";
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
            this.panel1.Location = new System.Drawing.Point(26, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 248);
            this.panel1.TabIndex = 67;
            // 
            // CreatePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 544);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.txtpmntMethod);
            this.Controls.Add(this.lblpmntPaymentMethod);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtpAPOOrderDate);
            this.Controls.Add(this.btnPmntReset);
            this.Controls.Add(this.btnPmntProcess);
            this.Controls.Add(this.txtxpmntAmount);
            this.Controls.Add(this.txtpmntNotes);
            this.Controls.Add(this.txtpmntSupplierID);
            this.Controls.Add(this.lblpmntAmount);
            this.Controls.Add(this.lblAPONotes);
            this.Controls.Add(this.lblAPOSupplierID);
            this.Controls.Add(this.lblpmntReference);
            this.Controls.Add(this.txtpmntStatus);
            this.Controls.Add(this.txtpmntReference);
            this.Controls.Add(this.txtpmntNumber);
            this.Controls.Add(this.lblpmntStatus);
            this.Controls.Add(this.lblAPOOrderDate);
            this.Controls.Add(this.lblAPONumber);
            this.Controls.Add(this.txtPOID);
            this.Controls.Add(this.lblPOID);
            this.Controls.Add(this.dgvpmntList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreatePayment";
            this.Text = "Create Payment ";
            this.Load += new System.EventHandler(this.ApprovePOForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpmntList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPmntReset;
        private System.Windows.Forms.Button btnPmntProcess;
        private System.Windows.Forms.TextBox txtpmntNotes;
        private System.Windows.Forms.TextBox txtpmntSupplierID;
        private System.Windows.Forms.Label lblAPONotes;
        private System.Windows.Forms.Label lblAPOSupplierID;
        private System.Windows.Forms.Label lblpmntReference;
        private System.Windows.Forms.TextBox txtpmntStatus;
        private System.Windows.Forms.TextBox txtpmntReference;
        private System.Windows.Forms.TextBox txtpmntNumber;
        private System.Windows.Forms.Label lblpmntStatus;
        private System.Windows.Forms.Label lblAPONumber;
        private System.Windows.Forms.TextBox txtPOID;
        private System.Windows.Forms.Label lblPOID;
        private System.Windows.Forms.DataGridView dgvpmntList;
        private System.Windows.Forms.TextBox txtxpmntAmount;
        private System.Windows.Forms.Label lblpmntAmount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtpmntMethod;
        private System.Windows.Forms.Label lblpmntPaymentMethod;
        private System.Windows.Forms.DateTimePicker dtpAPOOrderDate;
        private System.Windows.Forms.Label lblAPOOrderDate;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Panel panel1;
    }
}