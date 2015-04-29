using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModels;
using BLL;

namespace DBSCreditUnion
{
    public partial class frmManageTransactions : Form
    {
       
        private AccountHolder holderSource;
        private AccountHolder holderDestination;
        private AccountHolder holderExternal;
        private Account accountSource;
        private Account accountDestination;
        private Account accountExternal;

        
        private string mode;
        

        // constructor with mode
        public frmManageTransactions(string mode)
        {
            InitializeComponent();

            // enter chosen mode
            this.mode = mode;
            switchMode(mode);
        }


        // paramaterless constructor
        public frmManageTransactions()
        {
            InitializeComponent();

            // set default mode to "transfer"
            mode = "transfer";
            switchMode(mode);

            
        }

        // switch mode - to switch between tabs
        // enum to be used for modes in future version or this method dropped
        private void switchMode(string mode)
        {
            switch (mode)
            {
                case "transfer":
                    {
                        ApplyTransferMode();
                    }
                    break;
                case "deposit":
                    {
                        ApplyDepositMode();
                    }
                    break;
                case "withdrawal":
                    {
                        ApplyWithdrawalMode();
                    }
                    break;
                default :
                    {
                        ApplyTransferMode();
                    }
                    break;
            }
        }

        // ***** GUI Modes *****
        private void ApplyDepositMode()
        {
            tabTransfers.SelectTab("tabPage7");
            // clear details
            txtDepositAccount.Text = "";
            txtAmountToDeposit.Text = "";
            holderDestination = null;
            accountDestination = null;
            // deleting details from the control
            ctrlAccDeposit.Wipe();
            // hide cancel transaction button
            btnCancelTransaction.Visible = false;
        }

        private void ApplyWithdrawalMode()
        {
            tabTransfers.SelectTab("tabPage6");
            // clear details
            txtWithdrawalAccount.Text = "";
            txtAmountToWithdraw.Text = "";
            holderSource = null;
            accountSource = null;
            // deleting details from the control
            ctrAccWithdrawal.Wipe();
            // hide cancel transaction button
            btnCancelTransaction.Visible = false;
        }

        private void ApplyTransferMode()
        {
            tabTransfers.SelectTab("tabPage1");
            // button cancel is only needed for step 2 onwards
            btnCancelTransaction.Visible = false;
            //reset references
            holderSource = null;
            holderDestination = null;
            accountDestination = null;
            accountSource = null;
            ctrAViewHSourceAccount.Wipe();
            ctrExtAccountH.Wipe();
            txtSourceAccountNumber.Text = "";
        }

        private void ApplyTransferModePage2()
        {
            tabTransfers.SelectTab("tabPage2");
            btnCancelTransaction.Visible = true;
        }

        // Destination account internal
        private void ApplyTransferModePage3()
        {
            tabTransfers.SelectTab("tabPage3");
            // Updating account details control
            ctrAViewHDestinationAccount.Account = accountDestination;
            ctrAViewHDestinationAccount.AccountHolder = holderDestination;
            ctrAViewHDestinationAccount.UpdateDisplay();
            
            // Update account number text field
            if (accountDestination == null)
            {
                txtDestinationAccountNumber.Text = String.Empty;
            }
            else
            {
                txtDestinationAccountNumber.Text = accountDestination.Id.ToString();
            }
        }

        // Destination account external
        private void ApplyTransferModePage4()
        {
            tabTransfers.SelectTab("tabPage4");
        }

        // Summary of transfer
        private void ApplyTransferModePage5()
        {
            tabTransfers.SelectTab("tabPage5");
            if (accountSource != null && holderSource != null)
            {
                ctrAViewVSourceAccount.Account = accountSource;
                ctrAViewVSourceAccount.AccountHolder = holderSource;
                ctrAViewVSourceAccount.UpdateDisplay();
            }
            if (accountDestination != null && holderDestination != null && rdoDBSCreditUnion.Checked)
            {
                ctrDestAccountStep4.Account = accountDestination;
                ctrDestAccountStep4.AccountHolder = holderDestination;
                ctrDestAccountStep4.UpdateDisplay();
            }
            if (accountExternal != null && holderExternal != null && rdoAnotherInstitution.Checked)
            {
                ctrDestAccountStep4.Account = accountExternal;
                ctrDestAccountStep4.AccountHolder = holderExternal;
                ctrDestAccountStep4.UpdateDisplay();
            }
        }

      
        // button with transaction icon on the form
        private void btnSwitchTransfer_Click(object sender, EventArgs e)
        {
            switchMode("transfer");
        }

        // button with withdrawal icon on the form
        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            switchMode("withdrawal");
        }

        // button with deposit icon on the form
        private void btnSwitchDeposit_Click(object sender, EventArgs e)
        {
            switchMode("deposit");
        }

        // Loading account for withdrawal
        private void btnGetWithdrawalAcc_Click(object sender, EventArgs e)
        {
            GetWithdrawalAccount();
        }

        // Method to load account and account holder details into frmManageTransactions
        private void btnGetDepositAccount_Click(object sender, EventArgs e)
        {
            GetDepositAccount();
        }

        // Method to load account only
        private bool LoadAccount(int number, ref Account account)
        {
            bool loaded;
            loaded = false;
            Account tempAccount;

            BLLAccountMgmt bllAM = new BLLAccountMgmt();
            tempAccount = bllAM.GetAccountDetailsBLL(number);

            if ((tempAccount != null) && (tempAccount.Id != 0))
            {
                loaded = true;
                // if account is not a default empty one, assign reference
                account = tempAccount;
            }
                    
            return loaded;
        }

        // Method to load account holder only
        private bool LoadAccountHolder(int holderId, ref AccountHolder holder)
        {
            bool loaded;
            AccountHolder tempHolder;
            loaded = false;

            BLLAccountMgmt bllAM = new BLLAccountMgmt();
            tempHolder = bllAM.GetAccHolderDetailsBLL(holderId);

            if ((tempHolder != null) && (tempHolder.ID != 0))
            {
                loaded = true;
                // if account holder is not a default empty one, assign reference
                holder = tempHolder;
            }

            return loaded;
        }

        // These two methods could be redesigned to accept any control: horizontal or vertical
        private void PopulateHControl(Account account, AccountHolder holder, AccountViewH view)
        {
            if (account != null && holder != null && view != null)
            {
                // Assign values and refresh display
                view.Account = account;
                view.AccountHolder = holder;
                view.UpdateDisplay();
            }
        }



        // canceling operations
        private void btnDepositCancel_Click(object sender, EventArgs e)
        {
            // go back to default state of Deposit
            ApplyDepositMode();
        }

        private void btnWithdrawCancel_Click(object sender, EventArgs e)
        {
            // go back to default state of Withdrawal
            ApplyWithdrawalMode();
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            // go back to default state of transaction
            ApplyTransferMode();
        }
       
        // executes deposit (button Proceed clicked)
        private void btnDepositGo_Click(object sender, EventArgs e)
        {
            if (holderDestination == null || accountDestination == null)
            {
                MessageBox.Show("Enter account details first");
            }
            else
            {
                //parse amount of money to transfer
                int amount;
                bool parsed;
                string amountString;

                amountString = txtAmountToDeposit.Text;
                parsed = int.TryParse(amountString, out amount);

                if (parsed)
                {
                    // run deposit code
                    BLLTransactionMgmt bll = new BLLTransactionMgmt();

                    // for debugging:
                    //MessageBox.Show("Running deposit code"); 
                    string result;
                    result = bll.SaveDeposit(accountDestination, amount);
                    MessageBox.Show(result);
                    GetDepositAccount();
                    txtAmountToDeposit.Text = "";
                }
                else
                {
                    MessageBox.Show("Enter amount to deposit in cents, i.e. 1000 = \u20AC 10");
                }

            }
        }

        // executes withdrawal
        private void btnWithdrawGo_Click(object sender, EventArgs e)
        {
            if (holderSource == null || accountSource == null)
            {
                MessageBox.Show("Enter account details first");
            }
            else
            {
                //parse amount of money to transfer
                int amount;
                bool parsed;
                string amountString;

                amountString = txtAmountToWithdraw.Text;
                parsed = int.TryParse(amountString, out amount);

                if (parsed)
                {
                    // run withdrawal code
                    BLLTransactionMgmt bll = new BLLTransactionMgmt();

                    // for debugging
                    //MessageBox.Show("Running deposit code");
                    string result;
                    result = bll.WithdrawMoney(accountSource, amount);
                    MessageBox.Show(result);
                    GetWithdrawalAccount();
                    txtAmountToWithdraw.Text = "";
                }
                else
                {
                    MessageBox.Show("Enter amount to withdraw in cents, i.e. 1000 = \u20AC 10");
                }

            }
        }

        // this method loads account and populates withdrawal control
        private void GetWithdrawalAccount()
        {
            // **check if it would be benefficial to refactor
            int accNo;
            bool parsed;
            bool loadSuccess;
            string numberString;

            // getting account number from the user
            numberString = txtWithdrawalAccount.Text;
            parsed = int.TryParse(numberString, out accNo);

            // getting account and account holder details from the database
            if (parsed)
            {
                loadSuccess = LoadAccount(accNo, ref accountSource);

                if (loadSuccess)
                {
                    // for debugging:
                    //MessageBox.Show("Account loaded, now getting account holder details...");
                    loadSuccess = LoadAccountHolder(accountSource.AccountHolderID, ref holderSource);

                    if (loadSuccess)
                    {
                        // for debugging
                        MessageBox.Show("Accound holder details loaded!");
                        //updating display
                        PopulateHControl(accountSource, holderSource, ctrAccWithdrawal);
                    }
                    else
                    {
                        MessageBox.Show("Accound holder details not loaded :(");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to load account");
                }
            }
            else
            {
                MessageBox.Show("Please enter account number in numerical format");
            }
        }

        // this method loads deposit account and populates control
        private void GetDepositAccount()
        {
            int accNo;
            bool parsed;
            bool loadSuccess;
            string numberString;

            // getting account number from the user
            numberString = txtDepositAccount.Text;
            parsed = int.TryParse(numberString, out accNo);

            // getting account and account holder details from the database
            if (parsed)
            {
                loadSuccess = LoadAccount(accNo, ref accountDestination);

                if (loadSuccess)
                {
                    // for debugging
                    // MessageBox.Show("Account loaded, now getting account holder details...");
                    loadSuccess = LoadAccountHolder(accountDestination.AccountHolderID, ref holderDestination);

                    if (loadSuccess)
                    {
                        // for debugging
                        //MessageBox.Show("Accound holder details loaded!");
                        //updating display
                        PopulateHControl(accountDestination, holderDestination, ctrlAccDeposit);
                    }
                    else
                    {
                        MessageBox.Show("Accound holder details not loaded :(");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to load account");
                }
            }
            else
            {
                MessageBox.Show("Please enter account number in numerical format");
            }
        }

        // while on page tabPage1 and clicked Next
        private void btnStep1Next_Click(object sender, EventArgs e)
        {
            if (accountSource != null && holderSource != null)
            {
                ApplyTransferModePage2();
            }
            else
            {
                MessageBox.Show("Choose account first");
            }
        }

        // while on page tabPage1 click Clear
        private void btnStep1Clear_Click(object sender, EventArgs e)
        {
            ApplyTransferMode();
            
        }

        // Transfer - load and show source account
        private void btnViewSourceAccount_Click(object sender, EventArgs e)
        {
            // **check if it would be benefficial to refactor
            int accNo;
            bool parsed;
            bool loadSuccess;
            string numberString;

            // getting account number from the user
            numberString = txtSourceAccountNumber.Text;
            parsed = int.TryParse(numberString, out accNo);

            // getting account and account holder details from the database
            if (parsed)
            {
                loadSuccess = LoadAccount(accNo, ref accountSource);

                if (loadSuccess)
                {
                    // For debugging
                    //MessageBox.Show("Account loaded, now getting account holder details...");
                    loadSuccess = LoadAccountHolder(accountSource.AccountHolderID, ref holderSource);

                    if (loadSuccess)
                    {
                        // for debugging
                        //MessageBox.Show("Accound holder details loaded!");
                        //updating display
                        PopulateHControl(accountSource, holderSource, ctrAViewHSourceAccount);
                    }
                    else
                    {
                        MessageBox.Show("Accound holder details not loaded :(");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to load account");
                }
            }
            else
            {
                MessageBox.Show("Please enter account number in numerical format");
            }
        }

        // this is btnStep2Previous - While on page 2 go back to page 1
        private void button2_Click(object sender, EventArgs e)
        {
            tabTransfers.SelectTab("tabPage1");
        }

        // while on page 2 go to page 3
        private void btnStep2Next_Click(object sender, EventArgs e)
        {
            if (rdoDBSCreditUnion.Checked)
            {
                ApplyTransferModePage3();
            }
            else
            {
                ApplyTransferModePage4();
            }
        }

        // while on page 3 internal account, bo back to page 2
        private void btnStep3intPrevious_Click(object sender, EventArgs e)
        {
            ApplyTransferModePage2();
        }

        // while on page 3 external account go back to page 2
        private void btnStep3extPrevious_Click(object sender, EventArgs e)
        {
            ApplyTransferModePage2();
        }

        // Transfer - load internal destination account
        private void btnViewDestinationAccountInternal_Click(object sender, EventArgs e)
        {
            // **check if it would be benefficial to refactor
            int accNo;
            bool parsed;
            bool loadSuccess;
            string numberString;

            // getting account number from the user
            numberString = txtDestinationAccountNumber.Text;
            parsed = int.TryParse(numberString, out accNo);

            // getting account and account holder details from the database
            if (parsed)
            {
                loadSuccess = LoadAccount(accNo, ref accountDestination);

                if (loadSuccess)
                {
                    // for debugging:
                    // MessageBox.Show("Account loaded, now getting account holder details...");
                    loadSuccess = LoadAccountHolder(accountDestination.AccountHolderID, ref holderDestination);

                    if (loadSuccess)
                    {
                        // for debugging
                        //MessageBox.Show("Accound holder details loaded!");
                        //updating display
                        PopulateHControl(accountDestination, holderDestination, ctrAViewHDestinationAccount);
                    }
                    else
                    {
                        MessageBox.Show("Accound holder details not loaded :(");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to load account");
                }
            }
            else
            {
                MessageBox.Show("Please enter account number in numerical format");
            }
        }

        // Transfer page 3 button Clear clicked - wipe out information
        private void btnStep3internalClear_Click(object sender, EventArgs e)
        {
            accountDestination = null;
            holderDestination = null;
            txtDestinationAccountNumber.Text = "";
            ctrAViewHDestinationAccount.Wipe();
        }

        // While on page 3 go to page 5 - transfer summary
        private void btnStep3internalNext_Click(object sender, EventArgs e)
        {
            if (holderDestination == null || accountDestination == null)
            {
                MessageBox.Show("Enter account details first");
            }
            else
            {
                ApplyTransferModePage5();
            }
        }

        // This happens when button Previous is clicked on Step 4 page
        private void btnStep4Previous_Click(object sender, EventArgs e)
        {
            if (rdoDBSCreditUnion.Checked)
            {
                ApplyTransferModePage3();
            }
            else
            {
                ApplyTransferModePage4();
            }
        }

        // Clear description and amount to transfer from Step 4 (tabPage5)
        private void btnTransferClear_Click(object sender, EventArgs e)
        {
            txtDescription.Text = String.Empty;
            txtAmountToTransfer.Text = String.Empty;
        }

        // This executes transfer
        private void btnTransferGo_Click(object sender, EventArgs e)
        {
                
                //parse amount of money to transfer
                int amount;
                bool parsed;
                string amountString;
                string message;
                string transactionDescription;

                transactionDescription = txtDescription.Text;

                amountString = txtAmountToTransfer.Text;
                parsed = int.TryParse(amountString, out amount);

                if (parsed)
                {
                    // run deposit code
                    BLLTransactionMgmt bll = new BLLTransactionMgmt();
                    
                    // Depending on whether internal or external transfer use appropriate method
                    if (rdoDBSCreditUnion.Checked)
                    {
                        // for debugging
                        //MessageBox.Show("Executing internal transfer");
                        message = bll.Transfer(accountSource, accountDestination, amount, transactionDescription);
                        MessageBox.Show(message);
                        // Refresh source account details
                        reloadSource();
                        txtDescription.Text = string.Empty;
                        txtAmountToTransfer.Text = string.Empty;
                    }
                    else
                    {
                        // for debugging
                        //MessageBox.Show("External transfer");
                        message = bll.Transfer(accountSource, accountExternal, holderExternal, amount, transactionDescription);
                        MessageBox.Show(message);
                        // Refresh source account details
                        reloadSource();
                        txtDescription.Text = string.Empty;
                        txtAmountToTransfer.Text = string.Empty;
                    }                  
                }
                else
                {
                    MessageBox.Show("Enter amount to transfer in cents, i.e. 1000 = \u20AC 10");
                }                     
        }

        // This is launched when Cancel button on tabPage4 is pressed
        private void btnStep3extClear_Click(object sender, EventArgs e)
        {
            accountExternal = null;
            holderExternal = null;
            ctrExtAccountH.Wipe();
        }

        // This happens when clicking next on external account details screen
        private void btnStep3extNext_Click(object sender, EventArgs e)
        {
            if (ctrExtAccountH.Read())
            {
                holderExternal = ctrExtAccountH.AccountHolder;
                accountExternal = ctrExtAccountH.Account;
                ApplyTransferModePage5();
            }
            else
            {
                MessageBox.Show("Details not valid");
            }
        }

        //private void ctrDestAccountStep4_Load(object sender, EventArgs e)
        //{

        //}

        private void reloadSource()
        {
            bool loadSuccess;

            {
                loadSuccess = LoadAccount(accountSource.Id, ref accountSource);

                if (loadSuccess)
                {
                    // For debugging
                    //MessageBox.Show("Account loaded, now getting account holder details...");
                    loadSuccess = LoadAccountHolder(accountSource.AccountHolderID, ref holderSource);

                    if (loadSuccess)
                    {
                        // for debugging
                        //MessageBox.Show("Accound holder details loaded!");
                        //updating display
                        ApplyTransferModePage5();
                    }
                    else
                    {
                        MessageBox.Show("Accound holder details not loaded :(");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to load account");
                }
            }
        }


    }
}
