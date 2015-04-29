namespace DBSCreditUnion
{
    partial class ExtAccountH
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblSortCode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.erpName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpANumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpSCode = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpANumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(30, 70);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // lblSortCode
            // 
            this.lblSortCode.AutoSize = true;
            this.lblSortCode.Location = new System.Drawing.Point(30, 110);
            this.lblSortCode.Name = "lblSortCode";
            this.lblSortCode.Size = new System.Drawing.Size(54, 13);
            this.lblSortCode.TabIndex = 2;
            this.lblSortCode.Text = "Sort Code";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(165, 67);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(108, 20);
            this.txtAccountNumber.TabIndex = 4;
            this.txtAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountNumber_Validating);
            // 
            // txtSortCode
            // 
            this.txtSortCode.Location = new System.Drawing.Point(165, 103);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(108, 20);
            this.txtSortCode.TabIndex = 5;
            this.txtSortCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtSortCode_Validating);
            // 
            // erpName
            // 
            this.erpName.ContainerControl = this;
            // 
            // erpANumber
            // 
            this.erpANumber.ContainerControl = this;
            // 
            // erpSCode
            // 
            this.erpSCode.ContainerControl = this;
            // 
            // ExtAccountH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSortCode);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSortCode);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblName);
            this.Name = "ExtAccountH";
            this.Size = new System.Drawing.Size(401, 170);
            this.Load += new System.EventHandler(this.ExtAccountH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpANumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblSortCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.ErrorProvider erpName;
        private System.Windows.Forms.ErrorProvider erpANumber;
        private System.Windows.Forms.ErrorProvider erpSCode;
    }
}
