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
    public partial class AccountViewV : UserControl
    {
        public bool ViewOnly { get; set; }
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



        public AccountViewV()
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
        
        private void AccountViewV_Load(object sender, EventArgs e)
        {
            if (ViewOnly)
            {
                txtAccNo.Enabled = false;
                txtAccoType.Enabled = false;
                txtFunds.Enabled = false;
                txtAccHolderID.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
            }
        }


        public void UpdateDisplay()
        {
            if (accHolder != null && account != null)
            {
                txtAccNo.Text = account.Id.ToString();
                txtAccoType.Text = account.Type;
                txtFunds.Text = account.Balance.ToString();
                txtAccHolderID.Text = accHolder.ID.ToString();
                txtFirstName.Text = accHolder.FirstName;
                txtLastName.Text = accHolder.Surname;
                                
            }
            else
            {
                txtAccNo.Text = String.Empty;
                txtAccoType.Text = String.Empty;
                txtFunds.Text = String.Empty;
                txtAccHolderID.Text = String.Empty;
                txtFirstName.Text = String.Empty;
                txtLastName.Text = String.Empty;
            }
        }
    }
}
