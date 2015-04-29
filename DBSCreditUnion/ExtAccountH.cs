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
using System.Text.RegularExpressions;

namespace DBSCreditUnion
{
    public partial class ExtAccountH : UserControl
    {
        public bool ViewOnly { get; set; }
        private AccountHolder accHolder;
        private Account account;

        private string name;
        private int sortCode;
        private int accNumber;

        
        // This class tries to create a new account and account holder every time 
        // Next is clicked on the main form
        public AccountHolder AccountHolder
        {
            set
            {
                this.accHolder = value;
            }
            get
            {
                return accHolder;
            }
        }

        public Account Account
        {
            set
            {
                this.account = value;
            }
            get
            {
                return account;
            }
        }
     
        public ExtAccountH()
        {
            InitializeComponent();
            // Turning off auto validation
            this.AutoValidate = AutoValidate.Disable;
        }

        // wipe out details and update display
        public void Wipe()
        {
            accHolder = null;
            account = null;
            erpName.Clear();
            erpANumber.Clear();
            erpSCode.Clear();
            txtName.Text = String.Empty;
            txtAccountNumber.Text = String.Empty;
            txtSortCode.Text = String.Empty;
            this.UpdateDisplay();
        }

        // refresh the text boxes
        public void UpdateDisplay()
        {
            if (accHolder != null && account != null)
            {
                txtName.Text = accHolder.FirstName + " " +accHolder.Surname;
                txtAccountNumber.Text = account.Id.ToString();
                txtSortCode.Text = account.SortCode;                                
            }
            else
            {
                txtName.Text = String.Empty;
                txtAccountNumber.Text = String.Empty;
                txtSortCode.Text = String.Empty;
            }
        }

        // on load disable txt boxes if read only
        private void ExtAccountH_Load(object sender, EventArgs e)
        {
            if (ViewOnly)
            {
                txtName.Enabled = false;
                txtAccountNumber.Enabled = false;
                txtSortCode.Enabled = false;
            }
        }

        // Validate details entered by the user
        private bool Validate()
        {
            bool valid;
            

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                valid = true;
            }
            else
            {
                MessageBox.Show("Invalid data");
                valid = false;
            }

            return valid;
        }

        // Validating name text field
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                erpName.SetError(txtName, "Please enter name.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                erpName.Clear();
            }
        }

        // Validating account number (8 digits)
        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            Regex expression;
            expression = new Regex("^\\d{8}$");

            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                erpANumber.SetError(txtAccountNumber, "Please enter account number");
                e.Cancel = true;
            }
            else if(expression.IsMatch(txtAccountNumber.Text))
            {
              
                e.Cancel = false;
                erpANumber.Clear();
              
            }
            else
            {
                erpANumber.SetError(txtAccountNumber, "Please enter account number in 8 digit format");
                e.Cancel = true;
            }
        }

        // Validating sort code (6 digits)
        private void txtSortCode_Validating(object sender, CancelEventArgs e)
        {
            Regex expression;
            expression = new Regex("^\\d{6}$");

            if (string.IsNullOrEmpty(txtSortCode.Text))
            {
                erpSCode.SetError(txtSortCode, "Please enter sort code");
                e.Cancel = true;
            }
            else if (expression.IsMatch(txtSortCode.Text))
            {
                e.Cancel = false;
                erpSCode.Clear();
            }
            else
            {
                erpSCode.SetError(txtSortCode, "Please enter sort code in 6 digit format");
                e.Cancel = true;
            }
        }

        public bool Read()
        {
            bool read;

            // Check if input data valid
            if (Validate())
            {
                name = txtName.Text;
                // both numbers are checked already and at this stage we can be sure they contain digits only
                accNumber = int.Parse(txtAccountNumber.Text);
                sortCode = int.Parse(txtSortCode.Text);

                account = new Account(accNumber, "EXTERNAL", sortCode.ToString(), 0, 0, 0);
                accHolder = new AccountHolder(name, "", "", "", "", "", "", "");
                read = true;
            }
            else
            {
                // Not creating new account
                read = false;
            }
            return read;
        }
    }
}
