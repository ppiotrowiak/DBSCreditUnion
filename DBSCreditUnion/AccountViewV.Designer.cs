namespace DBSCreditUnion
{
    partial class AccountViewV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblAvailableFunds = new System.Windows.Forms.Label();
            this.lblAccHID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.txtAccoType = new System.Windows.Forms.TextBox();
            this.txtFunds = new System.Windows.Forms.TextBox();
            this.txtAccHolderID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(14, 31);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(67, 13);
            this.lblAccountNo.TabIndex = 0;
            this.lblAccountNo.Text = "Account No.";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(14, 61);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(74, 13);
            this.lblAccountType.TabIndex = 1;
            this.lblAccountType.Text = "Account Type";
            // 
            // lblAvailableFunds
            // 
            this.lblAvailableFunds.AutoSize = true;
            this.lblAvailableFunds.Location = new System.Drawing.Point(14, 91);
            this.lblAvailableFunds.Name = "lblAvailableFunds";
            this.lblAvailableFunds.Size = new System.Drawing.Size(82, 13);
            this.lblAvailableFunds.TabIndex = 2;
            this.lblAvailableFunds.Text = "Available Funds";
            // 
            // lblAccHID
            // 
            this.lblAccHID.AutoSize = true;
            this.lblAccHID.Location = new System.Drawing.Point(14, 121);
            this.lblAccHID.Name = "lblAccHID";
            this.lblAccHID.Size = new System.Drawing.Size(77, 13);
            this.lblAccHID.TabIndex = 3;
            this.lblAccHID.Text = "Acc. Holder ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(14, 151);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(14, 181);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(136, 24);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(123, 20);
            this.txtAccNo.TabIndex = 6;
            // 
            // txtAccoType
            // 
            this.txtAccoType.Location = new System.Drawing.Point(136, 54);
            this.txtAccoType.Name = "txtAccoType";
            this.txtAccoType.Size = new System.Drawing.Size(123, 20);
            this.txtAccoType.TabIndex = 7;
            // 
            // txtFunds
            // 
            this.txtFunds.Location = new System.Drawing.Point(136, 84);
            this.txtFunds.Name = "txtFunds";
            this.txtFunds.Size = new System.Drawing.Size(123, 20);
            this.txtFunds.TabIndex = 8;
            // 
            // txtAccHolderID
            // 
            this.txtAccHolderID.Location = new System.Drawing.Point(136, 114);
            this.txtAccHolderID.Name = "txtAccHolderID";
            this.txtAccHolderID.Size = new System.Drawing.Size(123, 20);
            this.txtAccHolderID.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(136, 144);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(123, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(136, 174);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(123, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // AccountViewV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtAccHolderID);
            this.Controls.Add(this.txtFunds);
            this.Controls.Add(this.txtAccoType);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAccHID);
            this.Controls.Add(this.lblAvailableFunds);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblAccountNo);
            this.Name = "AccountViewV";
            this.Size = new System.Drawing.Size(276, 250);
            this.Load += new System.EventHandler(this.AccountViewV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblAvailableFunds;
        private System.Windows.Forms.Label lblAccHID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.TextBox txtAccoType;
        private System.Windows.Forms.TextBox txtFunds;
        private System.Windows.Forms.TextBox txtAccHolderID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
    }
}
