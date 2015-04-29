using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModels;

namespace DBSCreditUnion
{
    // this shares some common methods and properties with AccountViewV and ExtAccountH controls, 
    // so they could implement the same interface
    public partial class AccountViewH : UserControl
    {
        private AccountHolder accHolder;
        private Account account;

        // get properties are not needed, these are read-only properties
        public AccountHolder AccountHolder
        {
            set
            {
                this.accHolder = value;
            }
        }
                      

        public Account Account 
        {
            set
            {
                this.account = value;
            }
        }


        public AccountViewH()
        {
            InitializeComponent();
        }

        // wipe out details and update display
        public void Wipe()
        {
            accHolder = null;
            account = null;
            this.UpdateDisplay();
        }

        
        // Ideally there should be different account type classes, i.e. savings account or current account
        public void UpdateDisplay()
        {
            if (accHolder != null && account != null)
            {
                lblAccountTypeValue.Text = account.Type;
                lblAvailableFundsValue.Text = account.Balance.ToString();
                lblMemberIDValue.Text = accHolder.ID.ToString();
                lblFirstNameValue.Text = accHolder.FirstName;
                lblLastNameValue.Text = accHolder.Surname;
            }
            else
            {
                lblAccountTypeValue.Text = "";
                lblAvailableFundsValue.Text = "";
                lblMemberIDValue.Text = "";
                lblFirstNameValue.Text = "";
                lblLastNameValue.Text = "";
            }
        }
    }
}
