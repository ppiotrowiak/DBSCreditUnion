namespace DBSCreditUnion
{
    partial class frmManageTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTransactions));
            this.lblCreditUnionLogo = new System.Windows.Forms.Label();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnSwitchDeposit = new System.Windows.Forms.Button();
            this.btnSwitchTransfer = new System.Windows.Forms.Button();
            this.btnCancelTransaction = new System.Windows.Forms.Button();
            this.tabTransfers = new DBSCreditUnion.WizardPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStep1Clear = new System.Windows.Forms.Button();
            this.btnStep1Next = new System.Windows.Forms.Button();
            this.ctrAViewHSourceAccount = new DBSCreditUnion.AccountViewH();
            this.btnViewSourceAccount = new System.Windows.Forms.Button();
            this.txtSourceAccountNumber = new System.Windows.Forms.TextBox();
            this.lblSourceAccountNumber = new System.Windows.Forms.Label();
            this.lblTransferStep1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStep2Next = new System.Windows.Forms.Button();
            this.btnStep2Previous = new System.Windows.Forms.Button();
            this.grpAccountType = new System.Windows.Forms.GroupBox();
            this.rdoDBSCreditUnion = new System.Windows.Forms.RadioButton();
            this.rdoAnotherInstitution = new System.Windows.Forms.RadioButton();
            this.lblTransferStep2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnStep3intPrevious = new System.Windows.Forms.Button();
            this.btnStep3internalClear = new System.Windows.Forms.Button();
            this.btnStep3internalNext = new System.Windows.Forms.Button();
            this.ctrAViewHDestinationAccount = new DBSCreditUnion.AccountViewH();
            this.btnViewDestinationAccountInternal = new System.Windows.Forms.Button();
            this.txtDestinationAccountNumber = new System.Windows.Forms.TextBox();
            this.lblDestinationAccount = new System.Windows.Forms.Label();
            this.lblTransferStep3Internal = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnStep3extPrevious = new System.Windows.Forms.Button();
            this.btnStep3extClear = new System.Windows.Forms.Button();
            this.btnStep3extNext = new System.Windows.Forms.Button();
            this.ctrExtAccountH = new DBSCreditUnion.ExtAccountH();
            this.lblTransferStep3External = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnStep4Previous = new System.Windows.Forms.Button();
            this.grpAmountToTransfer = new System.Windows.Forms.GroupBox();
            this.btnTransferClear = new System.Windows.Forms.Button();
            this.btnTransferGo = new System.Windows.Forms.Button();
            this.txtAmountToTransfer = new System.Windows.Forms.TextBox();
            this.grbDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grbAccountInfo = new System.Windows.Forms.GroupBox();
            this.ctrAViewVSourceAccount = new DBSCreditUnion.AccountViewV();
            this.grbDestination = new System.Windows.Forms.GroupBox();
            this.ctrDestAccountStep4 = new DBSCreditUnion.ExtAccountH();
            this.lblTransferStep4 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.grpAmountToWithdraw = new System.Windows.Forms.GroupBox();
            this.btnWithdrawCancel = new System.Windows.Forms.Button();
            this.btnWithdrawGo = new System.Windows.Forms.Button();
            this.txtAmountToWithdraw = new System.Windows.Forms.TextBox();
            this.btnGetWithdrawalAcc = new System.Windows.Forms.Button();
            this.txtWithdrawalAccount = new System.Windows.Forms.TextBox();
            this.lblWithdrawalAccount = new System.Windows.Forms.Label();
            this.ctrAccWithdrawal = new DBSCreditUnion.AccountViewH();
            this.lblWithdrawal = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.grbAmountToDeposit = new System.Windows.Forms.GroupBox();
            this.btnDepositCancel = new System.Windows.Forms.Button();
            this.btnDepositGo = new System.Windows.Forms.Button();
            this.txtAmountToDeposit = new System.Windows.Forms.TextBox();
            this.btnGetDepositAccount = new System.Windows.Forms.Button();
            this.txtDepositAccount = new System.Windows.Forms.TextBox();
            this.lblDepositAccount = new System.Windows.Forms.Label();
            this.ctrlAccDeposit = new DBSCreditUnion.AccountViewH();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.menu1 = new DBSCreditUnion.menu();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTransfers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpAccountType.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.grpAmountToTransfer.SuspendLayout();
            this.grbDescription.SuspendLayout();
            this.grbAccountInfo.SuspendLayout();
            this.grbDestination.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.grpAmountToWithdraw.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.grbAmountToDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreditUnionLogo
            // 
            this.lblCreditUnionLogo.AutoSize = true;
            this.lblCreditUnionLogo.Font = new System.Drawing.Font("Segoe WP", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditUnionLogo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCreditUnionLogo.Location = new System.Drawing.Point(415, 49);
            this.lblCreditUnionLogo.Name = "lblCreditUnionLogo";
            this.lblCreditUnionLogo.Size = new System.Drawing.Size(263, 40);
            this.lblCreditUnionLogo.TabIndex = 2;
            this.lblCreditUnionLogo.Text = "DBS Credit Union";
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Image = global::DBSCreditUnion.Properties.Resources.withdrawal;
            this.btnWithdrawal.Location = new System.Drawing.Point(84, 23);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(75, 75);
            this.btnWithdrawal.TabIndex = 7;
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // btnSwitchDeposit
            // 
            this.btnSwitchDeposit.Image = global::DBSCreditUnion.Properties.Resources.deposit;
            this.btnSwitchDeposit.Location = new System.Drawing.Point(165, 23);
            this.btnSwitchDeposit.Name = "btnSwitchDeposit";
            this.btnSwitchDeposit.Size = new System.Drawing.Size(75, 75);
            this.btnSwitchDeposit.TabIndex = 6;
            this.btnSwitchDeposit.UseVisualStyleBackColor = true;
            this.btnSwitchDeposit.Click += new System.EventHandler(this.btnSwitchDeposit_Click);
            // 
            // btnSwitchTransfer
            // 
            this.btnSwitchTransfer.Image = global::DBSCreditUnion.Properties.Resources.transfer1;
            this.btnSwitchTransfer.Location = new System.Drawing.Point(3, 23);
            this.btnSwitchTransfer.Name = "btnSwitchTransfer";
            this.btnSwitchTransfer.Size = new System.Drawing.Size(75, 75);
            this.btnSwitchTransfer.TabIndex = 5;
            this.btnSwitchTransfer.UseVisualStyleBackColor = true;
            this.btnSwitchTransfer.Click += new System.EventHandler(this.btnSwitchTransfer_Click);
            // 
            // btnCancelTransaction
            // 
            this.btnCancelTransaction.Location = new System.Drawing.Point(51, 527);
            this.btnCancelTransaction.Name = "btnCancelTransaction";
            this.btnCancelTransaction.Size = new System.Drawing.Size(107, 27);
            this.btnCancelTransaction.TabIndex = 8;
            this.btnCancelTransaction.Text = "Cancel";
            this.btnCancelTransaction.UseVisualStyleBackColor = true;
            this.btnCancelTransaction.Click += new System.EventHandler(this.btnCancelTransaction_Click);
            // 
            // tabTransfers
            // 
            this.tabTransfers.Controls.Add(this.tabPage1);
            this.tabTransfers.Controls.Add(this.tabPage2);
            this.tabTransfers.Controls.Add(this.tabPage3);
            this.tabTransfers.Controls.Add(this.tabPage4);
            this.tabTransfers.Controls.Add(this.tabPage5);
            this.tabTransfers.Controls.Add(this.tabPage6);
            this.tabTransfers.Controls.Add(this.tabPage7);
            this.tabTransfers.Location = new System.Drawing.Point(-1, 100);
            this.tabTransfers.Name = "tabTransfers";
            this.tabTransfers.SelectedIndex = 0;
            this.tabTransfers.Size = new System.Drawing.Size(707, 421);
            this.tabTransfers.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage1.Controls.Add(this.btnStep1Clear);
            this.tabPage1.Controls.Add(this.btnStep1Next);
            this.tabPage1.Controls.Add(this.ctrAViewHSourceAccount);
            this.tabPage1.Controls.Add(this.btnViewSourceAccount);
            this.tabPage1.Controls.Add(this.txtSourceAccountNumber);
            this.tabPage1.Controls.Add(this.lblSourceAccountNumber);
            this.tabPage1.Controls.Add(this.lblTransferStep1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnStep1Clear
            // 
            this.btnStep1Clear.Location = new System.Drawing.Point(455, 362);
            this.btnStep1Clear.Name = "btnStep1Clear";
            this.btnStep1Clear.Size = new System.Drawing.Size(107, 27);
            this.btnStep1Clear.TabIndex = 7;
            this.btnStep1Clear.Text = "Clear";
            this.btnStep1Clear.UseVisualStyleBackColor = true;
            this.btnStep1Clear.Click += new System.EventHandler(this.btnStep1Clear_Click);
            // 
            // btnStep1Next
            // 
            this.btnStep1Next.Location = new System.Drawing.Point(567, 362);
            this.btnStep1Next.Name = "btnStep1Next";
            this.btnStep1Next.Size = new System.Drawing.Size(107, 27);
            this.btnStep1Next.TabIndex = 5;
            this.btnStep1Next.Text = "Next";
            this.btnStep1Next.UseVisualStyleBackColor = true;
            this.btnStep1Next.Click += new System.EventHandler(this.btnStep1Next_Click);
            // 
            // ctrAViewHSourceAccount
            // 
            this.ctrAViewHSourceAccount.Location = new System.Drawing.Point(39, 170);
            this.ctrAViewHSourceAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrAViewHSourceAccount.Name = "ctrAViewHSourceAccount";
            this.ctrAViewHSourceAccount.Size = new System.Drawing.Size(650, 200);
            this.ctrAViewHSourceAccount.TabIndex = 4;
            // 
            // btnViewSourceAccount
            // 
            this.btnViewSourceAccount.Location = new System.Drawing.Point(180, 141);
            this.btnViewSourceAccount.Name = "btnViewSourceAccount";
            this.btnViewSourceAccount.Size = new System.Drawing.Size(107, 27);
            this.btnViewSourceAccount.TabIndex = 3;
            this.btnViewSourceAccount.Text = "View Account";
            this.btnViewSourceAccount.UseVisualStyleBackColor = true;
            this.btnViewSourceAccount.Click += new System.EventHandler(this.btnViewSourceAccount_Click);
            // 
            // txtSourceAccountNumber
            // 
            this.txtSourceAccountNumber.Location = new System.Drawing.Point(180, 98);
            this.txtSourceAccountNumber.Name = "txtSourceAccountNumber";
            this.txtSourceAccountNumber.Size = new System.Drawing.Size(106, 20);
            this.txtSourceAccountNumber.TabIndex = 2;
            // 
            // lblSourceAccountNumber
            // 
            this.lblSourceAccountNumber.AutoSize = true;
            this.lblSourceAccountNumber.Location = new System.Drawing.Point(15, 100);
            this.lblSourceAccountNumber.Name = "lblSourceAccountNumber";
            this.lblSourceAccountNumber.Size = new System.Drawing.Size(124, 13);
            this.lblSourceAccountNumber.TabIndex = 1;
            this.lblSourceAccountNumber.Text = "Source Account Number";
            // 
            // lblTransferStep1
            // 
            this.lblTransferStep1.AutoSize = true;
            this.lblTransferStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransferStep1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTransferStep1.Location = new System.Drawing.Point(15, 30);
            this.lblTransferStep1.Name = "lblTransferStep1";
            this.lblTransferStep1.Size = new System.Drawing.Size(360, 20);
            this.lblTransferStep1.TabIndex = 0;
            this.lblTransferStep1.Text = "Transfer of funds - Step 1 - Source Account";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage2.Controls.Add(this.btnStep2Next);
            this.tabPage2.Controls.Add(this.btnStep2Previous);
            this.tabPage2.Controls.Add(this.grpAccountType);
            this.tabPage2.Controls.Add(this.lblTransferStep2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btnStep2Next
            // 
            this.btnStep2Next.Location = new System.Drawing.Point(567, 362);
            this.btnStep2Next.Name = "btnStep2Next";
            this.btnStep2Next.Size = new System.Drawing.Size(107, 27);
            this.btnStep2Next.TabIndex = 8;
            this.btnStep2Next.Text = "Next";
            this.btnStep2Next.UseVisualStyleBackColor = true;
            this.btnStep2Next.Click += new System.EventHandler(this.btnStep2Next_Click);
            // 
            // btnStep2Previous
            // 
            this.btnStep2Previous.Location = new System.Drawing.Point(48, 362);
            this.btnStep2Previous.Name = "btnStep2Previous";
            this.btnStep2Previous.Size = new System.Drawing.Size(107, 27);
            this.btnStep2Previous.TabIndex = 7;
            this.btnStep2Previous.Text = "Previous";
            this.btnStep2Previous.UseVisualStyleBackColor = true;
            this.btnStep2Previous.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpAccountType
            // 
            this.grpAccountType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpAccountType.Controls.Add(this.rdoDBSCreditUnion);
            this.grpAccountType.Controls.Add(this.rdoAnotherInstitution);
            this.grpAccountType.Location = new System.Drawing.Point(246, 154);
            this.grpAccountType.Name = "grpAccountType";
            this.grpAccountType.Size = new System.Drawing.Size(200, 100);
            this.grpAccountType.TabIndex = 4;
            this.grpAccountType.TabStop = false;
            this.grpAccountType.Text = "Destination account type";
            // 
            // rdoDBSCreditUnion
            // 
            this.rdoDBSCreditUnion.AutoSize = true;
            this.rdoDBSCreditUnion.Checked = true;
            this.rdoDBSCreditUnion.Location = new System.Drawing.Point(15, 19);
            this.rdoDBSCreditUnion.Name = "rdoDBSCreditUnion";
            this.rdoDBSCreditUnion.Size = new System.Drawing.Size(108, 17);
            this.rdoDBSCreditUnion.TabIndex = 2;
            this.rdoDBSCreditUnion.TabStop = true;
            this.rdoDBSCreditUnion.Text = "DBS Credit Union";
            this.rdoDBSCreditUnion.UseVisualStyleBackColor = true;
            // 
            // rdoAnotherInstitution
            // 
            this.rdoAnotherInstitution.AutoSize = true;
            this.rdoAnotherInstitution.Location = new System.Drawing.Point(15, 53);
            this.rdoAnotherInstitution.Name = "rdoAnotherInstitution";
            this.rdoAnotherInstitution.Size = new System.Drawing.Size(110, 17);
            this.rdoAnotherInstitution.TabIndex = 3;
            this.rdoAnotherInstitution.Text = "Another Institution";
            this.rdoAnotherInstitution.UseVisualStyleBackColor = true;
            // 
            // lblTransferStep2
            // 
            this.lblTransferStep2.AutoSize = true;
            this.lblTransferStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransferStep2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTransferStep2.Location = new System.Drawing.Point(15, 30);
            this.lblTransferStep2.Name = "lblTransferStep2";
            this.lblTransferStep2.Size = new System.Drawing.Size(336, 20);
            this.lblTransferStep2.TabIndex = 1;
            this.lblTransferStep2.Text = "Transfer of funds - Step 2 - Choose Type";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage3.Controls.Add(this.btnStep3intPrevious);
            this.tabPage3.Controls.Add(this.btnStep3internalClear);
            this.tabPage3.Controls.Add(this.btnStep3internalNext);
            this.tabPage3.Controls.Add(this.ctrAViewHDestinationAccount);
            this.tabPage3.Controls.Add(this.btnViewDestinationAccountInternal);
            this.tabPage3.Controls.Add(this.txtDestinationAccountNumber);
            this.tabPage3.Controls.Add(this.lblDestinationAccount);
            this.tabPage3.Controls.Add(this.lblTransferStep3Internal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(699, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnStep3intPrevious
            // 
            this.btnStep3intPrevious.Location = new System.Drawing.Point(48, 362);
            this.btnStep3intPrevious.Name = "btnStep3intPrevious";
            this.btnStep3intPrevious.Size = new System.Drawing.Size(107, 27);
            this.btnStep3intPrevious.TabIndex = 10;
            this.btnStep3intPrevious.Text = "Previous";
            this.btnStep3intPrevious.UseVisualStyleBackColor = true;
            this.btnStep3intPrevious.Click += new System.EventHandler(this.btnStep3intPrevious_Click);
            // 
            // btnStep3internalClear
            // 
            this.btnStep3internalClear.Location = new System.Drawing.Point(455, 362);
            this.btnStep3internalClear.Name = "btnStep3internalClear";
            this.btnStep3internalClear.Size = new System.Drawing.Size(107, 27);
            this.btnStep3internalClear.TabIndex = 9;
            this.btnStep3internalClear.Text = "Clear";
            this.btnStep3internalClear.UseVisualStyleBackColor = true;
            this.btnStep3internalClear.Click += new System.EventHandler(this.btnStep3internalClear_Click);
            // 
            // btnStep3internalNext
            // 
            this.btnStep3internalNext.Location = new System.Drawing.Point(567, 362);
            this.btnStep3internalNext.Name = "btnStep3internalNext";
            this.btnStep3internalNext.Size = new System.Drawing.Size(107, 27);
            this.btnStep3internalNext.TabIndex = 8;
            this.btnStep3internalNext.Text = "Next";
            this.btnStep3internalNext.UseVisualStyleBackColor = true;
            this.btnStep3internalNext.Click += new System.EventHandler(this.btnStep3internalNext_Click);
            // 
            // ctrAViewHDestinationAccount
            // 
            this.ctrAViewHDestinationAccount.Location = new System.Drawing.Point(39, 170);
            this.ctrAViewHDestinationAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrAViewHDestinationAccount.Name = "ctrAViewHDestinationAccount";
            this.ctrAViewHDestinationAccount.Size = new System.Drawing.Size(650, 200);
            this.ctrAViewHDestinationAccount.TabIndex = 6;
            // 
            // btnViewDestinationAccountInternal
            // 
            this.btnViewDestinationAccountInternal.Location = new System.Drawing.Point(180, 141);
            this.btnViewDestinationAccountInternal.Name = "btnViewDestinationAccountInternal";
            this.btnViewDestinationAccountInternal.Size = new System.Drawing.Size(107, 27);
            this.btnViewDestinationAccountInternal.TabIndex = 5;
            this.btnViewDestinationAccountInternal.Text = "View Account";
            this.btnViewDestinationAccountInternal.UseVisualStyleBackColor = true;
            this.btnViewDestinationAccountInternal.Click += new System.EventHandler(this.btnViewDestinationAccountInternal_Click);
            // 
            // txtDestinationAccountNumber
            // 
            this.txtDestinationAccountNumber.Location = new System.Drawing.Point(180, 98);
            this.txtDestinationAccountNumber.Name = "txtDestinationAccountNumber";
            this.txtDestinationAccountNumber.Size = new System.Drawing.Size(106, 20);
            this.txtDestinationAccountNumber.TabIndex = 4;
            // 
            // lblDestinationAccount
            // 
            this.lblDestinationAccount.AutoSize = true;
            this.lblDestinationAccount.Location = new System.Drawing.Point(15, 100);
            this.lblDestinationAccount.Name = "lblDestinationAccount";
            this.lblDestinationAccount.Size = new System.Drawing.Size(143, 13);
            this.lblDestinationAccount.TabIndex = 3;
            this.lblDestinationAccount.Text = "Destination Account Number";
            // 
            // lblTransferStep3Internal
            // 
            this.lblTransferStep3Internal.AutoSize = true;
            this.lblTransferStep3Internal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferStep3Internal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTransferStep3Internal.Location = new System.Drawing.Point(15, 30);
            this.lblTransferStep3Internal.Name = "lblTransferStep3Internal";
            this.lblTransferStep3Internal.Size = new System.Drawing.Size(462, 20);
            this.lblTransferStep3Internal.TabIndex = 2;
            this.lblTransferStep3Internal.Text = "Transfer of funds - Step 3 - Destination Account Internal";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage4.Controls.Add(this.btnStep3extPrevious);
            this.tabPage4.Controls.Add(this.btnStep3extClear);
            this.tabPage4.Controls.Add(this.btnStep3extNext);
            this.tabPage4.Controls.Add(this.ctrExtAccountH);
            this.tabPage4.Controls.Add(this.lblTransferStep3External);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(699, 395);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // btnStep3extPrevious
            // 
            this.btnStep3extPrevious.Location = new System.Drawing.Point(48, 362);
            this.btnStep3extPrevious.Name = "btnStep3extPrevious";
            this.btnStep3extPrevious.Size = new System.Drawing.Size(107, 27);
            this.btnStep3extPrevious.TabIndex = 12;
            this.btnStep3extPrevious.Text = "Previous";
            this.btnStep3extPrevious.UseVisualStyleBackColor = true;
            this.btnStep3extPrevious.Click += new System.EventHandler(this.btnStep3extPrevious_Click);
            // 
            // btnStep3extClear
            // 
            this.btnStep3extClear.Location = new System.Drawing.Point(455, 362);
            this.btnStep3extClear.Name = "btnStep3extClear";
            this.btnStep3extClear.Size = new System.Drawing.Size(107, 27);
            this.btnStep3extClear.TabIndex = 11;
            this.btnStep3extClear.Text = "Clear";
            this.btnStep3extClear.UseVisualStyleBackColor = true;
            this.btnStep3extClear.Click += new System.EventHandler(this.btnStep3extClear_Click);
            // 
            // btnStep3extNext
            // 
            this.btnStep3extNext.Location = new System.Drawing.Point(567, 362);
            this.btnStep3extNext.Name = "btnStep3extNext";
            this.btnStep3extNext.Size = new System.Drawing.Size(107, 27);
            this.btnStep3extNext.TabIndex = 10;
            this.btnStep3extNext.Text = "Next";
            this.btnStep3extNext.UseVisualStyleBackColor = true;
            this.btnStep3extNext.Click += new System.EventHandler(this.btnStep3extNext_Click);
            // 
            // ctrExtAccountH
            // 
            this.ctrExtAccountH.Account = null;
            this.ctrExtAccountH.AccountHolder = null;
            this.ctrExtAccountH.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ctrExtAccountH.Location = new System.Drawing.Point(60, 122);
            this.ctrExtAccountH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrExtAccountH.Name = "ctrExtAccountH";
            this.ctrExtAccountH.Size = new System.Drawing.Size(497, 162);
            this.ctrExtAccountH.TabIndex = 4;
            this.ctrExtAccountH.ViewOnly = false;
            // 
            // lblTransferStep3External
            // 
            this.lblTransferStep3External.AutoSize = true;
            this.lblTransferStep3External.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferStep3External.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTransferStep3External.Location = new System.Drawing.Point(15, 30);
            this.lblTransferStep3External.Name = "lblTransferStep3External";
            this.lblTransferStep3External.Size = new System.Drawing.Size(466, 20);
            this.lblTransferStep3External.TabIndex = 3;
            this.lblTransferStep3External.Text = "Transfer of funds - Step 3 - Destination Account External";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage5.Controls.Add(this.btnStep4Previous);
            this.tabPage5.Controls.Add(this.grpAmountToTransfer);
            this.tabPage5.Controls.Add(this.grbDescription);
            this.tabPage5.Controls.Add(this.grbAccountInfo);
            this.tabPage5.Controls.Add(this.grbDestination);
            this.tabPage5.Controls.Add(this.lblTransferStep4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(699, 395);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            // 
            // btnStep4Previous
            // 
            this.btnStep4Previous.Location = new System.Drawing.Point(48, 348);
            this.btnStep4Previous.Name = "btnStep4Previous";
            this.btnStep4Previous.Size = new System.Drawing.Size(107, 27);
            this.btnStep4Previous.TabIndex = 13;
            this.btnStep4Previous.Text = "Previous";
            this.btnStep4Previous.UseVisualStyleBackColor = true;
            this.btnStep4Previous.Click += new System.EventHandler(this.btnStep4Previous_Click);
            // 
            // grpAmountToTransfer
            // 
            this.grpAmountToTransfer.Controls.Add(this.btnTransferClear);
            this.grpAmountToTransfer.Controls.Add(this.btnTransferGo);
            this.grpAmountToTransfer.Controls.Add(this.txtAmountToTransfer);
            this.grpAmountToTransfer.Location = new System.Drawing.Point(297, 333);
            this.grpAmountToTransfer.Name = "grpAmountToTransfer";
            this.grpAmountToTransfer.Size = new System.Drawing.Size(402, 56);
            this.grpAmountToTransfer.TabIndex = 8;
            this.grpAmountToTransfer.TabStop = false;
            this.grpAmountToTransfer.Text = "Amount to transfer in cents";
            // 
            // btnTransferClear
            // 
            this.btnTransferClear.Location = new System.Drawing.Point(285, 15);
            this.btnTransferClear.Name = "btnTransferClear";
            this.btnTransferClear.Size = new System.Drawing.Size(107, 27);
            this.btnTransferClear.TabIndex = 2;
            this.btnTransferClear.Text = "Clear";
            this.btnTransferClear.UseVisualStyleBackColor = true;
            this.btnTransferClear.Click += new System.EventHandler(this.btnTransferClear_Click);
            // 
            // btnTransferGo
            // 
            this.btnTransferGo.Location = new System.Drawing.Point(171, 15);
            this.btnTransferGo.Name = "btnTransferGo";
            this.btnTransferGo.Size = new System.Drawing.Size(107, 27);
            this.btnTransferGo.TabIndex = 1;
            this.btnTransferGo.Text = "Proceed";
            this.btnTransferGo.UseVisualStyleBackColor = true;
            this.btnTransferGo.Click += new System.EventHandler(this.btnTransferGo_Click);
            // 
            // txtAmountToTransfer
            // 
            this.txtAmountToTransfer.Location = new System.Drawing.Point(14, 19);
            this.txtAmountToTransfer.Name = "txtAmountToTransfer";
            this.txtAmountToTransfer.Size = new System.Drawing.Size(151, 20);
            this.txtAmountToTransfer.TabIndex = 0;
            // 
            // grbDescription
            // 
            this.grbDescription.Controls.Add(this.txtDescription);
            this.grbDescription.Location = new System.Drawing.Point(297, 254);
            this.grbDescription.Name = "grbDescription";
            this.grbDescription.Size = new System.Drawing.Size(402, 73);
            this.grbDescription.TabIndex = 6;
            this.grbDescription.TabStop = false;
            this.grbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(14, 16);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(378, 47);
            this.txtDescription.TabIndex = 0;
            // 
            // grbAccountInfo
            // 
            this.grbAccountInfo.Controls.Add(this.ctrAViewVSourceAccount);
            this.grbAccountInfo.Location = new System.Drawing.Point(3, 67);
            this.grbAccountInfo.Name = "grbAccountInfo";
            this.grbAccountInfo.Size = new System.Drawing.Size(285, 260);
            this.grbAccountInfo.TabIndex = 5;
            this.grbAccountInfo.TabStop = false;
            this.grbAccountInfo.Text = "Account Info";
            // 
            // ctrAViewVSourceAccount
            // 
            this.ctrAViewVSourceAccount.Location = new System.Drawing.Point(9, 19);
            this.ctrAViewVSourceAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrAViewVSourceAccount.Name = "ctrAViewVSourceAccount";
            this.ctrAViewVSourceAccount.Size = new System.Drawing.Size(270, 231);
            this.ctrAViewVSourceAccount.TabIndex = 6;
            this.ctrAViewVSourceAccount.ViewOnly = true;
            // 
            // grbDestination
            // 
            this.grbDestination.Controls.Add(this.ctrDestAccountStep4);
            this.grbDestination.Location = new System.Drawing.Point(294, 67);
            this.grbDestination.Name = "grbDestination";
            this.grbDestination.Size = new System.Drawing.Size(405, 178);
            this.grbDestination.TabIndex = 5;
            this.grbDestination.TabStop = false;
            this.grbDestination.Text = "Destination account";
            // 
            // ctrDestAccountStep4
            // 
            this.ctrDestAccountStep4.Account = null;
            this.ctrDestAccountStep4.AccountHolder = null;
            this.ctrDestAccountStep4.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ctrDestAccountStep4.Location = new System.Drawing.Point(17, 12);
            this.ctrDestAccountStep4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrDestAccountStep4.Name = "ctrDestAccountStep4";
            this.ctrDestAccountStep4.Size = new System.Drawing.Size(386, 154);
            this.ctrDestAccountStep4.TabIndex = 0;
            this.ctrDestAccountStep4.ViewOnly = true;
            // 
            // lblTransferStep4
            // 
            this.lblTransferStep4.AutoSize = true;
            this.lblTransferStep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferStep4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTransferStep4.Location = new System.Drawing.Point(15, 30);
            this.lblTransferStep4.Name = "lblTransferStep4";
            this.lblTransferStep4.Size = new System.Drawing.Size(294, 20);
            this.lblTransferStep4.TabIndex = 4;
            this.lblTransferStep4.Text = "Transfer of funds - Step 4 - Amount";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage6.Controls.Add(this.grpAmountToWithdraw);
            this.tabPage6.Controls.Add(this.btnGetWithdrawalAcc);
            this.tabPage6.Controls.Add(this.txtWithdrawalAccount);
            this.tabPage6.Controls.Add(this.lblWithdrawalAccount);
            this.tabPage6.Controls.Add(this.ctrAccWithdrawal);
            this.tabPage6.Controls.Add(this.lblWithdrawal);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(699, 395);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            // 
            // grpAmountToWithdraw
            // 
            this.grpAmountToWithdraw.Controls.Add(this.btnWithdrawCancel);
            this.grpAmountToWithdraw.Controls.Add(this.btnWithdrawGo);
            this.grpAmountToWithdraw.Controls.Add(this.txtAmountToWithdraw);
            this.grpAmountToWithdraw.Location = new System.Drawing.Point(297, 333);
            this.grpAmountToWithdraw.Name = "grpAmountToWithdraw";
            this.grpAmountToWithdraw.Size = new System.Drawing.Size(402, 56);
            this.grpAmountToWithdraw.TabIndex = 9;
            this.grpAmountToWithdraw.TabStop = false;
            this.grpAmountToWithdraw.Text = "Amount to withdraw in cents";
            // 
            // btnWithdrawCancel
            // 
            this.btnWithdrawCancel.Location = new System.Drawing.Point(285, 15);
            this.btnWithdrawCancel.Name = "btnWithdrawCancel";
            this.btnWithdrawCancel.Size = new System.Drawing.Size(107, 27);
            this.btnWithdrawCancel.TabIndex = 2;
            this.btnWithdrawCancel.Text = "Cancel";
            this.btnWithdrawCancel.UseVisualStyleBackColor = true;
            this.btnWithdrawCancel.Click += new System.EventHandler(this.btnWithdrawCancel_Click);
            // 
            // btnWithdrawGo
            // 
            this.btnWithdrawGo.Location = new System.Drawing.Point(171, 15);
            this.btnWithdrawGo.Name = "btnWithdrawGo";
            this.btnWithdrawGo.Size = new System.Drawing.Size(107, 27);
            this.btnWithdrawGo.TabIndex = 1;
            this.btnWithdrawGo.Text = "Proceed";
            this.btnWithdrawGo.UseVisualStyleBackColor = true;
            this.btnWithdrawGo.Click += new System.EventHandler(this.btnWithdrawGo_Click);
            // 
            // txtAmountToWithdraw
            // 
            this.txtAmountToWithdraw.Location = new System.Drawing.Point(14, 19);
            this.txtAmountToWithdraw.Name = "txtAmountToWithdraw";
            this.txtAmountToWithdraw.Size = new System.Drawing.Size(151, 20);
            this.txtAmountToWithdraw.TabIndex = 0;
            // 
            // btnGetWithdrawalAcc
            // 
            this.btnGetWithdrawalAcc.Location = new System.Drawing.Point(230, 130);
            this.btnGetWithdrawalAcc.Name = "btnGetWithdrawalAcc";
            this.btnGetWithdrawalAcc.Size = new System.Drawing.Size(107, 27);
            this.btnGetWithdrawalAcc.TabIndex = 6;
            this.btnGetWithdrawalAcc.Text = "View Account";
            this.btnGetWithdrawalAcc.UseVisualStyleBackColor = true;
            this.btnGetWithdrawalAcc.Click += new System.EventHandler(this.btnGetWithdrawalAcc_Click);
            // 
            // txtWithdrawalAccount
            // 
            this.txtWithdrawalAccount.Location = new System.Drawing.Point(230, 87);
            this.txtWithdrawalAccount.Name = "txtWithdrawalAccount";
            this.txtWithdrawalAccount.Size = new System.Drawing.Size(106, 20);
            this.txtWithdrawalAccount.TabIndex = 5;
            // 
            // lblWithdrawalAccount
            // 
            this.lblWithdrawalAccount.AutoSize = true;
            this.lblWithdrawalAccount.Location = new System.Drawing.Point(69, 90);
            this.lblWithdrawalAccount.Name = "lblWithdrawalAccount";
            this.lblWithdrawalAccount.Size = new System.Drawing.Size(87, 13);
            this.lblWithdrawalAccount.TabIndex = 4;
            this.lblWithdrawalAccount.Text = "Account Number";
            // 
            // ctrAccWithdrawal
            // 
            this.ctrAccWithdrawal.Location = new System.Drawing.Point(39, 150);
            this.ctrAccWithdrawal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrAccWithdrawal.Name = "ctrAccWithdrawal";
            this.ctrAccWithdrawal.Size = new System.Drawing.Size(650, 200);
            this.ctrAccWithdrawal.TabIndex = 2;
            // 
            // lblWithdrawal
            // 
            this.lblWithdrawal.AutoSize = true;
            this.lblWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWithdrawal.Location = new System.Drawing.Point(15, 30);
            this.lblWithdrawal.Name = "lblWithdrawal";
            this.lblWithdrawal.Size = new System.Drawing.Size(173, 20);
            this.lblWithdrawal.TabIndex = 1;
            this.lblWithdrawal.Text = "Withdrawal of Funds";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage7.Controls.Add(this.grbAmountToDeposit);
            this.tabPage7.Controls.Add(this.btnGetDepositAccount);
            this.tabPage7.Controls.Add(this.txtDepositAccount);
            this.tabPage7.Controls.Add(this.lblDepositAccount);
            this.tabPage7.Controls.Add(this.ctrlAccDeposit);
            this.tabPage7.Controls.Add(this.lblDeposit);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(699, 395);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            // 
            // grbAmountToDeposit
            // 
            this.grbAmountToDeposit.Controls.Add(this.btnDepositCancel);
            this.grbAmountToDeposit.Controls.Add(this.btnDepositGo);
            this.grbAmountToDeposit.Controls.Add(this.txtAmountToDeposit);
            this.grbAmountToDeposit.Location = new System.Drawing.Point(297, 333);
            this.grbAmountToDeposit.Name = "grbAmountToDeposit";
            this.grbAmountToDeposit.Size = new System.Drawing.Size(402, 56);
            this.grbAmountToDeposit.TabIndex = 10;
            this.grbAmountToDeposit.TabStop = false;
            this.grbAmountToDeposit.Text = "Amount to deposit in cents";
            // 
            // btnDepositCancel
            // 
            this.btnDepositCancel.Location = new System.Drawing.Point(285, 15);
            this.btnDepositCancel.Name = "btnDepositCancel";
            this.btnDepositCancel.Size = new System.Drawing.Size(107, 27);
            this.btnDepositCancel.TabIndex = 2;
            this.btnDepositCancel.Text = "Cancel";
            this.btnDepositCancel.UseVisualStyleBackColor = true;
            this.btnDepositCancel.Click += new System.EventHandler(this.btnDepositCancel_Click);
            // 
            // btnDepositGo
            // 
            this.btnDepositGo.Location = new System.Drawing.Point(171, 15);
            this.btnDepositGo.Name = "btnDepositGo";
            this.btnDepositGo.Size = new System.Drawing.Size(107, 27);
            this.btnDepositGo.TabIndex = 1;
            this.btnDepositGo.Text = "Proceed";
            this.btnDepositGo.UseVisualStyleBackColor = true;
            this.btnDepositGo.Click += new System.EventHandler(this.btnDepositGo_Click);
            // 
            // txtAmountToDeposit
            // 
            this.txtAmountToDeposit.Location = new System.Drawing.Point(14, 19);
            this.txtAmountToDeposit.Name = "txtAmountToDeposit";
            this.txtAmountToDeposit.Size = new System.Drawing.Size(151, 20);
            this.txtAmountToDeposit.TabIndex = 0;
            // 
            // btnGetDepositAccount
            // 
            this.btnGetDepositAccount.Location = new System.Drawing.Point(230, 130);
            this.btnGetDepositAccount.Name = "btnGetDepositAccount";
            this.btnGetDepositAccount.Size = new System.Drawing.Size(107, 27);
            this.btnGetDepositAccount.TabIndex = 9;
            this.btnGetDepositAccount.Text = "View Account";
            this.btnGetDepositAccount.UseVisualStyleBackColor = true;
            this.btnGetDepositAccount.Click += new System.EventHandler(this.btnGetDepositAccount_Click);
            // 
            // txtDepositAccount
            // 
            this.txtDepositAccount.Location = new System.Drawing.Point(230, 87);
            this.txtDepositAccount.Name = "txtDepositAccount";
            this.txtDepositAccount.Size = new System.Drawing.Size(106, 20);
            this.txtDepositAccount.TabIndex = 8;
            // 
            // lblDepositAccount
            // 
            this.lblDepositAccount.AutoSize = true;
            this.lblDepositAccount.Location = new System.Drawing.Point(69, 90);
            this.lblDepositAccount.Name = "lblDepositAccount";
            this.lblDepositAccount.Size = new System.Drawing.Size(87, 13);
            this.lblDepositAccount.TabIndex = 7;
            this.lblDepositAccount.Text = "Account Number";
            // 
            // ctrlAccDeposit
            // 
            this.ctrlAccDeposit.Location = new System.Drawing.Point(39, 150);
            this.ctrlAccDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlAccDeposit.Name = "ctrlAccDeposit";
            this.ctrlAccDeposit.Size = new System.Drawing.Size(650, 186);
            this.ctrlAccDeposit.TabIndex = 3;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDeposit.Location = new System.Drawing.Point(15, 30);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(126, 20);
            this.lblDeposit.TabIndex = 2;
            this.lblDeposit.Text = "Deposit Funds";
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(-1, 0);
            this.menu1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(707, 37);
            this.menu1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(323, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 86);
            this.label1.TabIndex = 9;
            // 
            // frmManageTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelTransaction);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.btnSwitchDeposit);
            this.Controls.Add(this.btnSwitchTransfer);
            this.Controls.Add(this.lblCreditUnionLogo);
            this.Controls.Add(this.tabTransfers);
            this.Controls.Add(this.menu1);
            this.Name = "frmManageTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageTransactions";
            this.tabTransfers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpAccountType.ResumeLayout(false);
            this.grpAccountType.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.grpAmountToTransfer.ResumeLayout(false);
            this.grpAmountToTransfer.PerformLayout();
            this.grbDescription.ResumeLayout(false);
            this.grbDescription.PerformLayout();
            this.grbAccountInfo.ResumeLayout(false);
            this.grbDestination.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.grpAmountToWithdraw.ResumeLayout(false);
            this.grpAmountToWithdraw.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.grbAmountToDeposit.ResumeLayout(false);
            this.grbAmountToDeposit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private menu menu1;
        private WizardPages tabTransfers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTransferStep1;
        private System.Windows.Forms.Label lblSourceAccountNumber;
        private System.Windows.Forms.Label lblCreditUnionLogo;
        private System.Windows.Forms.TextBox txtSourceAccountNumber;
        private System.Windows.Forms.Button btnViewSourceAccount;
        private AccountViewH ctrAViewHSourceAccount;
        private System.Windows.Forms.Label lblTransferStep2;
        private System.Windows.Forms.RadioButton rdoAnotherInstitution;
        private System.Windows.Forms.RadioButton rdoDBSCreditUnion;
        private System.Windows.Forms.GroupBox grpAccountType;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblTransferStep3Internal;
        private System.Windows.Forms.Label lblDestinationAccount;
        private System.Windows.Forms.Button btnViewDestinationAccountInternal;
        private System.Windows.Forms.TextBox txtDestinationAccountNumber;
        private AccountViewH ctrAViewHDestinationAccount;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblTransferStep3External;
        private ExtAccountH ctrExtAccountH;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblTransferStep4;
        private System.Windows.Forms.GroupBox grbDestination;
        private ExtAccountH ctrDestAccountStep4;
        private System.Windows.Forms.GroupBox grpAmountToTransfer;
        private System.Windows.Forms.TextBox txtAmountToTransfer;
        private System.Windows.Forms.GroupBox grbDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox grbAccountInfo;
        private AccountViewV ctrAViewVSourceAccount;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private AccountViewH ctrAccWithdrawal;
        private System.Windows.Forms.Label lblWithdrawal;
        private AccountViewH ctrlAccDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btnGetWithdrawalAcc;
        private System.Windows.Forms.TextBox txtWithdrawalAccount;
        private System.Windows.Forms.Label lblWithdrawalAccount;
        private System.Windows.Forms.Button btnGetDepositAccount;
        private System.Windows.Forms.TextBox txtDepositAccount;
        private System.Windows.Forms.Label lblDepositAccount;
        private System.Windows.Forms.Button btnTransferGo;
        private System.Windows.Forms.GroupBox grpAmountToWithdraw;
        private System.Windows.Forms.Button btnWithdrawGo;
        private System.Windows.Forms.TextBox txtAmountToWithdraw;
        private System.Windows.Forms.GroupBox grbAmountToDeposit;
        private System.Windows.Forms.Button btnDepositGo;
        private System.Windows.Forms.TextBox txtAmountToDeposit;
        private System.Windows.Forms.Button btnSwitchTransfer;
        private System.Windows.Forms.Button btnSwitchDeposit;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Button btnTransferClear;
        private System.Windows.Forms.Button btnWithdrawCancel;
        private System.Windows.Forms.Button btnDepositCancel;
        private System.Windows.Forms.Button btnStep1Clear;
        private System.Windows.Forms.Button btnStep1Next;
        private System.Windows.Forms.Button btnStep2Previous;
        private System.Windows.Forms.Button btnCancelTransaction;
        private System.Windows.Forms.Button btnStep2Next;
        private System.Windows.Forms.Button btnStep3internalClear;
        private System.Windows.Forms.Button btnStep3internalNext;
        private System.Windows.Forms.Button btnStep3extClear;
        private System.Windows.Forms.Button btnStep3extNext;
        private System.Windows.Forms.Button btnStep3intPrevious;
        private System.Windows.Forms.Button btnStep3extPrevious;
        private System.Windows.Forms.Button btnStep4Previous;
        private System.Windows.Forms.Label label1;
    }
}