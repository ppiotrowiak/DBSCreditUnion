namespace DBSCreditUnion
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnHomeLogin = new System.Windows.Forms.Button();
            this.panelHomeLogin = new System.Windows.Forms.Panel();
            this.gbxHomeLogin = new System.Windows.Forms.GroupBox();
            this.btnHomePLoginLogin = new System.Windows.Forms.Button();
            this.txtHomePLoginPassword = new System.Windows.Forms.TextBox();
            this.txtHomePLoginUserName = new System.Windows.Forms.TextBox();
            this.lblHomePassword = new System.Windows.Forms.Label();
            this.lblHomeUsername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblimage = new System.Windows.Forms.Label();
            this.panelHomeLogin.SuspendLayout();
            this.gbxHomeLogin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe WP", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMainTitle.Location = new System.Drawing.Point(415, 49);
            this.lblMainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(273, 45);
            this.lblMainTitle.TabIndex = 2;
            this.lblMainTitle.Text = "DBS Credit Union";
            // 
            // btnHomeLogin
            // 
            this.btnHomeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeLogin.Location = new System.Drawing.Point(284, 285);
            this.btnHomeLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomeLogin.Name = "btnHomeLogin";
            this.btnHomeLogin.Size = new System.Drawing.Size(112, 82);
            this.btnHomeLogin.TabIndex = 4;
            this.btnHomeLogin.Text = "Login";
            this.btnHomeLogin.UseVisualStyleBackColor = true;
            this.btnHomeLogin.Click += new System.EventHandler(this.btnHomeLogin_Click);
            // 
            // panelHomeLogin
            // 
            this.panelHomeLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelHomeLogin.Controls.Add(this.gbxHomeLogin);
            this.panelHomeLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHomeLogin.Location = new System.Drawing.Point(0, 101);
            this.panelHomeLogin.Margin = new System.Windows.Forms.Padding(2);
            this.panelHomeLogin.Name = "panelHomeLogin";
            this.panelHomeLogin.Size = new System.Drawing.Size(697, 512);
            this.panelHomeLogin.TabIndex = 5;
            this.panelHomeLogin.Visible = false;
            // 
            // gbxHomeLogin
            // 
            this.gbxHomeLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxHomeLogin.Controls.Add(this.btnHomePLoginLogin);
            this.gbxHomeLogin.Controls.Add(this.txtHomePLoginPassword);
            this.gbxHomeLogin.Controls.Add(this.txtHomePLoginUserName);
            this.gbxHomeLogin.Controls.Add(this.lblHomePassword);
            this.gbxHomeLogin.Controls.Add(this.lblHomeUsername);
            this.gbxHomeLogin.Location = new System.Drawing.Point(204, 126);
            this.gbxHomeLogin.Margin = new System.Windows.Forms.Padding(2);
            this.gbxHomeLogin.Name = "gbxHomeLogin";
            this.gbxHomeLogin.Padding = new System.Windows.Forms.Padding(2);
            this.gbxHomeLogin.Size = new System.Drawing.Size(264, 203);
            this.gbxHomeLogin.TabIndex = 0;
            this.gbxHomeLogin.TabStop = false;
            // 
            // btnHomePLoginLogin
            // 
            this.btnHomePLoginLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePLoginLogin.Location = new System.Drawing.Point(152, 143);
            this.btnHomePLoginLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomePLoginLogin.Name = "btnHomePLoginLogin";
            this.btnHomePLoginLogin.Size = new System.Drawing.Size(64, 31);
            this.btnHomePLoginLogin.TabIndex = 4;
            this.btnHomePLoginLogin.Text = "login";
            this.btnHomePLoginLogin.UseVisualStyleBackColor = true;
            this.btnHomePLoginLogin.Click += new System.EventHandler(this.btnHomePLoginLogin_Click);
            // 
            // txtHomePLoginPassword
            // 
            this.txtHomePLoginPassword.Location = new System.Drawing.Point(108, 80);
            this.txtHomePLoginPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtHomePLoginPassword.Name = "txtHomePLoginPassword";
            this.txtHomePLoginPassword.Size = new System.Drawing.Size(108, 20);
            this.txtHomePLoginPassword.TabIndex = 3;
            this.txtHomePLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtHomePLoginUserName
            // 
            this.txtHomePLoginUserName.Location = new System.Drawing.Point(108, 32);
            this.txtHomePLoginUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtHomePLoginUserName.Name = "txtHomePLoginUserName";
            this.txtHomePLoginUserName.Size = new System.Drawing.Size(108, 20);
            this.txtHomePLoginUserName.TabIndex = 2;
            // 
            // lblHomePassword
            // 
            this.lblHomePassword.AutoSize = true;
            this.lblHomePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePassword.Location = new System.Drawing.Point(38, 82);
            this.lblHomePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomePassword.Name = "lblHomePassword";
            this.lblHomePassword.Size = new System.Drawing.Size(68, 17);
            this.lblHomePassword.TabIndex = 1;
            this.lblHomePassword.Text = "password";
            // 
            // lblHomeUsername
            // 
            this.lblHomeUsername.AutoSize = true;
            this.lblHomeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeUsername.Location = new System.Drawing.Point(35, 34);
            this.lblHomeUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeUsername.Name = "lblHomeUsername";
            this.lblHomeUsername.Size = new System.Drawing.Size(71, 17);
            this.lblHomeUsername.TabIndex = 0;
            this.lblHomeUsername.Text = "username";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblimage
            // 
            this.lblimage.Image = ((System.Drawing.Image)(resources.GetObject("lblimage.Image")));
            this.lblimage.Location = new System.Drawing.Point(323, 31);
            this.lblimage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblimage.Name = "lblimage";
            this.lblimage.Size = new System.Drawing.Size(100, 90);
            this.lblimage.TabIndex = 7;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 613);
            this.Controls.Add(this.lblimage);
            this.Controls.Add(this.btnHomeLogin);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelHomeLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelHomeLogin.ResumeLayout(false);
            this.gbxHomeLogin.ResumeLayout(false);
            this.gbxHomeLogin.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button btnHomeLogin;
        private System.Windows.Forms.GroupBox gbxHomeLogin;
        private System.Windows.Forms.Label lblHomePassword;
        private System.Windows.Forms.Label lblHomeUsername;
        private System.Windows.Forms.TextBox txtHomePLoginPassword;
        private System.Windows.Forms.TextBox txtHomePLoginUserName;
        private System.Windows.Forms.Button btnHomePLoginLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Panel panelHomeLogin;
        private System.Windows.Forms.Label lblimage;

    }
}

