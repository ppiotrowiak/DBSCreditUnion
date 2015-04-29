using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using DataModels;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;





namespace DBSCreditUnion
{
    public partial class frmManageAccounts : Form
    {
        //email input validation
        private string emailRegEx = @"@.*?";
        
        //xml local file setup
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "Account.xml";

        //sort code from App.config
        string sortCode = System.Configuration.ConfigurationManager.AppSettings["sortCode"];
        
        
        public frmManageAccounts()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }
        


        
        //*****************   ADD NEW ACCOUNT EVENTS ************************

        //CHECK radiobox - enable existing Acc. holder ID textbox
        private void rbtnAccManPNewAccExistingMem_Click(object sender, EventArgs e)
        {
            txtManAccPNewAccAccHolder.Enabled = true;
        }

       
        
        //CHECK radiobox - disable  existing Acc. Holder ID textbox
        private void rbtnAccManPNewAccNewMem_Click(object sender, EventArgs e)
        {
            txtManAccPNewAccAccHolder.Enabled = false;
        }



        
        
        //CLICK Next, go to full details page to create account
        private void btnAccManPNewAccNext_Click(object sender, EventArgs e)
        {

            //an option not selected
            if (!rbtnAccManPNewAccNewMem.Checked && !rbtnAccManPNewAccExistingMem.Checked)
            {
                MessageBox.Show("Please select one option");

            }

            
            //an option is selected
            else
            {              


                //****** Existing holder  /   New holder options ********

                string nextHolderID;
                string nextAccNo;
                int accHolderID = 0;


                //prepare full details panel for adding an account to an EXISTING holder
                if (rbtnAccManPNewAccExistingMem.Checked)
                {
                    //read-only holder fields                   
                    txtManAccPFullDetFName.ReadOnly = true;
                    txtManAccPFullDetLName.ReadOnly = true;
                    txtManAccPFullDetPho.ReadOnly = true;
                    txtManAccPFullDetEmail.ReadOnly = true;
                    txtManAccPFullDetAddr1.ReadOnly = true;
                    txtManAccPFullDetAddr2.ReadOnly = true;
                    txtManAccPFullDetCity.ReadOnly = true;
                    cmbManAccPFullDetCounty.Enabled = false;


                    //validate user input - account holder ID                    
                    int outInt;
                    string input = txtManAccPNewAccAccHolder.Text;
            
                    bool isAnInt = int.TryParse(input, out outInt);

                    if (!isAnInt)
                    {
                        MessageBox.Show("Please enter a  valid account holder ID");
                        txtManAccPNewAccAccHolder.Text = "";
                    }


                    if (isAnInt)
                    {

                        //prepare next panel and display it

                        //read only acc holder details
                        txtManAccPFullDetAccHolder.ReadOnly = true;
                        //read only account details
                        txtManAccPFullDetSortC.ReadOnly = true;
                        txtManAccPFullDetAccNo.ReadOnly = true;



                        //hide/show relevant buttons
                        btnManAccPFullDetSerialize.Visible = false;
                        btnManAccPFullDetDeserialize.Visible = false;
                        btnManAccPFullDetCancel.Visible = true;
                        btnManAccPFullDetSaveEdit.Visible = false;
                        btnManAccPFullDetClose.Visible = false;
                        btnManAccPFullDetSubmitNew.Visible = true;

                        //display full details panel
                        panelManAccFullDet.Visible = true;
                        panelManAccEditSearch.Visible = true;
                        panelManAccViewAccSearch.Visible = true;
                                                                      
                        
                        //grab holder ID
                        accHolderID = int.Parse(txtManAccPNewAccAccHolder.Text);

                        AccountHolder ah;

                        BLLAccountMgmt bllAM = new BLLAccountMgmt();
                        ah = bllAM.GetAccHolderDetailsBLL(accHolderID); //get holder details

                        nextAccNo = bllAM.GetNextAccNoBLL().ToString(); //get next account number


                        if (ah.FirstName != null) //check if holder details arrived from DB
                        {

                            //holder details
                            txtManAccPFullDetFName.Text = ah.FirstName;
                            txtManAccPFullDetLName.Text = ah.Surname;
                            txtManAccPFullDetEmail.Text = ah.Email;
                            txtManAccPFullDetPho.Text = ah.Phone;
                            txtManAccPFullDetAddr1.Text = ah.Address1;
                            txtManAccPFullDetAddr2.Text = ah.Address2;
                            txtManAccPFullDetCity.Text = ah.City;
                            cmbManAccPFullDetCounty.SelectedItem = ah.County;
                            txtManAccPFullDetAccHolder.Text = ah.ID.ToString();
                            //account details
                            txtManAccPFullDetAccNo.Text = nextAccNo;
                            txtManAccPFullDetSortC.Text = sortCode;

                           
                        }


                        else if (ah.FirstName == null)
                        {
                            MessageBox.Show("Account holder not found");

                            BackToHomeGridView();

                        }
                    }

                }




                ////prepare full details panel for adding an account to a NEW holder
                if (rbtnAccManPNewAccNewMem.Checked)
                {

                    //Display next holder id and next account number                 

                    BLLAccountMgmt bllAM = new BLLAccountMgmt();

                    nextHolderID = bllAM.GetNextHolderIDBLL().ToString();
                    nextAccNo = bllAM.GetNextAccNoBLL().ToString();


                    txtManAccPFullDetAccHolder.Text = nextHolderID;
                    txtManAccPFullDetAccNo.Text = nextAccNo;


                    //display sort code from App.config            
                    txtManAccPFullDetSortC.Text = sortCode;

                    
                    //prepare next panel and display it

                    //read only acc holder details
                    txtManAccPFullDetAccHolder.ReadOnly = true;
                    //read only account details
                    txtManAccPFullDetSortC.ReadOnly = true;
                    txtManAccPFullDetAccNo.ReadOnly = true;



                    //hide/show relevant buttons
                    btnManAccPFullDetSerialize.Visible = false;
                    btnManAccPFullDetDeserialize.Visible = false;
                    btnManAccPFullDetCancel.Visible = true;
                    btnManAccPFullDetSaveEdit.Visible = false;
                    btnManAccPFullDetClose.Visible = false;
                    btnManAccPFullDetSubmitNew.Visible = true;

                    //display full details panel
                    panelManAccFullDet.Visible = true;
                    panelManAccEditSearch.Visible = true;
                    panelManAccViewAccSearch.Visible = true;
                                      

                }
            
            }
           
        } //end of "add new account" event  *********************
        
       
 




        
        //CLICK account type - current (enable overdaft)
        private void rbtManAccPFullDetCurrent_Click(object sender, EventArgs e)
        {
            txtManAccPFullDetOverdr.ReadOnly = false;
            txtManAccPFullDetIntRate.ReadOnly = true;
            txtManAccPFullDetOverdr.Text = "0";
            txtManAccPFullDetIntRate.Text = "0";
            
        }
              
       


        //CLICK account type - savings (disable overdraft)
        private void rbtManAccPFullDetSavings_Click(object sender, EventArgs e)
        {          
            txtManAccPFullDetOverdr.ReadOnly = true;
            txtManAccPFullDetIntRate.ReadOnly = false;
            txtManAccPFullDetOverdr.Text = "0";
            txtManAccPFullDetIntRate.Text = "0";

        }
              
        
        
        
        
        //CLICK cancel
        private void btnManAccPFullDetCancel_Click(object sender, EventArgs e)
        {
            //panelManAccFullDet.Controls.Clear();
            BackToHomeGridView();
        }
       
              
        
        
        
        
        
        //CLICK SUBMIT  - create a new holder and / or account          
        private void btnManAccPFullDetSubmit_Click(object sender, EventArgs e)
        {
            
            bool success = false; 
            
            
            //Create  a NEW holder AND and NEW account

            if (rbtnAccManPNewAccNewMem.Checked)
            {
                //new holder
                AccountHolder ah = CreateNewAccHolderObject();
           
                //new account
                Account acc = CreateNewAccountObjectNoHolderID();

                
                //send both objects to  DB
                if (ah != null && acc != null)
                {
                    BLLAccountMgmt bllAM = new BLLAccountMgmt();

                    success = bllAM.AddNewHolderBLL(ah); //holder

                    int accHolderID = int.Parse(txtManAccPFullDetAccHolder.Text);
                    success = bllAM.AddNewAccountBLL(acc, accHolderID); //account
                }
            
            }

         
            
            
            //Create a new account and add to EXISTING  holder
            if (rbtnAccManPNewAccExistingMem.Checked)
            {

                Account acc = CreateNewAccountObjectNoHolderID();

                if (acc != null)
                {
                    BLLAccountMgmt bllAM = new BLLAccountMgmt();

                    int accHolderID = int.Parse(txtManAccPFullDetAccHolder.Text);
                    success = bllAM.AddNewAccountBLL(acc, accHolderID);
                }
            }
           
            
            
            
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                // final result actions
                if (success == true)
                {
                    MessageBox.Show("All details have been saved");
                    //show accounts dgv
                    BackToHomeGridView();
                }

                else  if (success == false)
      
                {
                    MessageBox.Show("Details not saved. Try again.");
                }
            }
            
            
        }
        


        
        //*************** EDIT ACCOUNT EVENTS *************************************
                
        //CLICK - next go to full details panel for edit
        private void btnManAccPEditSearchNext_Click(object sender, EventArgs e)
        {

            //grab  input and check if is a valid account number           
            int outInt;
            string input = txtManAccPEditSearchAccID.Text;

            bool isAnInt = int.TryParse(input, out outInt);

            if (!isAnInt)
            {
                MessageBox.Show("Please enter a  valid account number");
                txtManAccPEditSearchAccID.Text = "";
            }



            if (isAnInt)
            {
                //get and populate details (account and holder)
                int accNumber = int.Parse(txtManAccPEditSearchAccID.Text);

                GetAndPopulateAccountAndHolderDetails(accNumber); 
                
                
                
                
                //prepare next panel and display it
                //to see full code - right-click the box below and select "Stop hiding current"

                //change header text
                lblManAccPCreateAccHeading.Text = "Edit account";


                //hide/show relevant buttons
                //NOTE: "save edit" and "submit new"  buttons are stacked 
                //(In design mode only the top one is visible)
                btnManAccPFullDetSerialize.Visible = false;
                btnManAccPFullDetDeserialize.Visible = false;
                btnManAccPFullDetCancel.Visible = true;
                btnManAccPFullDetSaveEdit.Visible = true;
                btnManAccPFullDetClose.Visible = false;
                btnManAccPFullDetSubmitNew.Visible = false;




                //customize fields for edit
                //holder
                txtManAccPFullDetFName.ReadOnly = true;
                txtManAccPFullDetLName.ReadOnly = true;
                txtManAccPFullDetPho.ReadOnly = false;
                txtManAccPFullDetEmail.ReadOnly = false;
                txtManAccPFullDetAddr1.ReadOnly = false;
                txtManAccPFullDetAddr2.ReadOnly = false;
                txtManAccPFullDetCity.ReadOnly = false;
                cmbManAccPFullDetCounty.Enabled = true;
                txtManAccPFullDetAccHolder.ReadOnly = true;
                //account
                txtManAccPFullDetAccNo.ReadOnly = true;
                txtManAccPFullDetSortC.ReadOnly = true;
                lblManAccPFullDetInitBal.Text = "Balance";  //instead of "initial balance";
                txtManAccPFullDetIntBal.ReadOnly = true;
                rbtManAccPFullDetCurrent.Enabled = false;
                rbtManAccPFullDetSavings.Enabled = false;
                txtManAccPFullDetOverdr.ReadOnly = false;
                txtManAccPFullDetIntRate.ReadOnly = false;

                //show full details pane
                panelManAccFullDet.BringToFront();
                panelManAccFullDet.Show();
               
            }
            
        }
            

        
        
        //CLICK save changes to account or/and account holder
        private void btnManAccPFullDetSaveEdit_Click(object sender, EventArgs e)
        {
            bool successHolder = false;
            bool successAccount = false;

            //create a holder object
            AccountHolder accHold = CreateNewAccHolderObject();
            
            //create an account object
            Account account = CreateNewAccountObjectNoHolderID();                   
            
            //send both to DB
            if (account != null && accHold != null)
            {
                accHold.ID = int.Parse(txtManAccPFullDetAccHolder.Text);
                account.Id = int.Parse(txtManAccPFullDetAccNo.Text);
                
                BLLAccountMgmt bllAM = new BLLAccountMgmt();
                successHolder = bllAM.EditAccHolderBLL(accHold);
                successAccount = bllAM.EditAccountBLL(account);
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                //edit status messages
                if (successHolder && successAccount)
                {
                    MessageBox.Show("All changes saved");
                    BackToHomeGridView();
                }

                if (successHolder == false)
                {
                    MessageBox.Show("Account holder changes failed to save");
                }

                if (successAccount == false)
                {
                    MessageBox.Show("Account changes failed to save");
                }
                
            }
        }

           




        
        
        // *******************  VIEW DETAILS OF ONE ACCOUNT ************************


        //CLICK next - go to view full details of one account
        private void btnManAccPViewSearchNext_Click(object sender, EventArgs e)
        {

            //grab  input and check if is a valid account number
            int accountID = 0;
            int outInt;
            string input = txtManAccPViewSearchAccID.Text;
            
            bool isAnInt = int.TryParse(input, out outInt);

            if (!isAnInt)
            {
                MessageBox.Show("Please enter a  valid account number");
                txtManAccPViewSearchAccID.Text = "";
            }

            
            if (isAnInt)
            {

                accountID = int.Parse(txtManAccPViewSearchAccID.Text);
                ////get and populate details
                GetAndPopulateAccountAndHolderDetails(accountID);

                
                
                //prepare next panel and display it
                //to see full code - right-click the box below and select "Stop hiding current"

                //show full details panel         
                panelManAccFullDet.Visible = true;
                panelManAccEditSearch.Visible = true;

                //change heading text
                lblManAccPCreateAccHeading.Text = "View full account details";

                // hide / show relevant buttons
                btnManAccPFullDetSerialize.Visible = true;
                btnManAccPFullDetDeserialize.Visible = true;
                btnManAccPFullDetCancel.Visible = false;
                btnManAccPFullDetSaveEdit.Visible = false;
                btnManAccPFullDetClose.Visible = true;
                btnManAccPFullDetSubmitNew.Visible = false;



                //all controls read only

                //holder
                txtManAccPFullDetFName.ReadOnly = true;
                txtManAccPFullDetLName.ReadOnly = true;
                txtManAccPFullDetPho.ReadOnly = true;
                txtManAccPFullDetEmail.ReadOnly = true;
                txtManAccPFullDetAddr1.ReadOnly = true;
                txtManAccPFullDetAddr2.ReadOnly = true;
                txtManAccPFullDetCity.ReadOnly = true;
                cmbManAccPFullDetCounty.Enabled = false;
                txtManAccPFullDetAccHolder.ReadOnly = true;
                //account
                txtManAccPFullDetAccNo.ReadOnly = true;
                txtManAccPFullDetSortC.ReadOnly = true;
                lblManAccPFullDetInitBal.Text = "Balance";  //instead of "initial balance";
                txtManAccPFullDetIntBal.ReadOnly = true;
                rbtManAccPFullDetCurrent.Enabled = false;
                rbtManAccPFullDetSavings.Enabled = false;
                txtManAccPFullDetOverdr.ReadOnly = true;
                txtManAccPFullDetIntRate.ReadOnly = true;

           

            }
        }




        //CLICK close full view details panel and show base grid view
        private void btnManAccPFullDetClose_Click(object sender, EventArgs e)
        {

            BackToHomeGridView();
        }


        //CLICK serialize
        private void btnManAccPFullDetSerialize_Click(object sender, EventArgs e)
        {

            string fName = txtManAccPFullDetFName.Text;
            string lName = txtManAccPFullDetLName.Text;
            string email = txtManAccPFullDetEmail.Text;
            string phone = txtManAccPFullDetPho.Text;
            string add1= txtManAccPFullDetAddr1.Text;
            string add2 = txtManAccPFullDetAddr2.Text;
            string city = txtManAccPFullDetCity.Text;
            string county = cmbManAccPFullDetCounty.SelectedItem.ToString();                                         
            int id = int.Parse(txtManAccPFullDetAccHolder.Text);

            AccountHolder ah = new AccountHolder(id, fName, lName, email, phone, add1, add2, city, county);



            XmlSerializer serializer = new XmlSerializer(typeof(AccountHolder));
            using (XmlWriter xmlWriter = XmlWriter.Create(path))

            {              
                serializer.Serialize(xmlWriter, ah);
                xmlWriter.Close();
            }
           
            txtManAccPFullDetAccHolder.Text = " ";            
            txtManAccPFullDetAddr1.Text = " ";
            txtManAccPFullDetAddr2.Text = " ";
            txtManAccPFullDetCity.Text = " ";
            cmbManAccPFullDetCounty.SelectedItem = " ";
            txtManAccPFullDetEmail.Text = " ";
            txtManAccPFullDetFName.Text = " ";
            txtManAccPFullDetPho.Text = " ";
            txtManAccPFullDetLName.Text = " ";

        }

        
        
        //CLICK deserialize
        private void btnManAccPFullDetDeserialize_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AccountHolder));

            using (XmlReader xmlReader = XmlReader.Create(path))
            {
                AccountHolder ah = (serializer.Deserialize(xmlReader)) as AccountHolder;
                xmlReader.Close();


                txtManAccPFullDetAddr1.Text = ah.Address1;
                txtManAccPFullDetAddr2.Text = ah.Address2;
                txtManAccPFullDetCity.Text = ah.City;
                cmbManAccPFullDetCounty.SelectedItem = ah.County;
                txtManAccPFullDetEmail.Text = ah.Email;
                txtManAccPFullDetFName.Text = ah.FirstName;
                txtManAccPFullDetPho.Text = ah.Phone;
                txtManAccPFullDetLName.Text = ah.Surname;
                txtManAccPFullDetAccHolder.Text = ah.ID.ToString();
            }

        }

       

        
 

        
        //************* METHODS *************************  

        
        //hide all panels and show home grid view (all accounts)
        private void BackToHomeGridView()
        {
            //set up panels to correct view           
            panelManAccFullDet.Visible = false;
            panelAccManNewAcc.Visible = false;
            panelManAccEditSearch.Visible = false;
            panelManAccViewAccSearch.Visible = false;

            //populate
            PopulateAccountsDGV();                                     

        }

        
        
        
        //populate accounts dgv
        public void PopulateAccountsDGV()
        {
            dgvManAcc.DataSource = null;
            
            BLLAccountMgmt bllAM = new BLLAccountMgmt();            
            DataSet ds = bllAM.GetAllAccountsBLL();
            dgvManAcc.DataSource = ds.Tables[0];
            
            dgvManAcc.Columns[0].HeaderCell.Value = "account holder ID";
            dgvManAcc.Columns[1].HeaderCell.Value = "first name";
            dgvManAcc.Columns[2].HeaderCell.Value = "last name";
            dgvManAcc.Columns[3].HeaderCell.Value = "account number";
            dgvManAcc.Columns[4].HeaderCell.Value = "account type";
            dgvManAcc.Columns[5].HeaderCell.Value = "balance";
            dgvManAcc.Columns[6].HeaderCell.Value = "interest rate";
            dgvManAcc.Columns[7].HeaderCell.Value = "overdraft limit";

        }


        
        
        //create a new account
        private Account CreateNewAccountObjectNoHolderID()
        {                      
                       
            Account acc = null;
            string accountTypeWarning = "";

            bool allInputValid = true;
            
            string type = "";

            if (rbtManAccPFullDetCurrent.Checked)
            {
                type = "Current";
            }
            
            else if (rbtManAccPFullDetSavings.Checked)
            {
                type = "Savings";
            }

            else if (!rbtManAccPFullDetCurrent.Checked && !rbtManAccPFullDetSavings.Checked)
            {
                allInputValid = false;
                accountTypeWarning = "Make sure account type is selected";
            }
            
            //balance
            int bal = 0;

            if (int.TryParse(txtManAccPFullDetIntBal.Text, out bal))
            {
                
            }
            else
            {
                errorProvider3.SetError(txtManAccPFullDetIntBal, "Please enter a number");
                allInputValid = false;
            }
           


            //overdraft
            int od = 0 ;
            if (int.TryParse(txtManAccPFullDetOverdr.Text, out od))
            {
                
            }
            else
            {
                errorProvider4.SetError(txtManAccPFullDetOverdr, "Please select account type");
                
                allInputValid = false;
            }



            //interest rate
            int ir = 0;
            if (int.TryParse(txtManAccPFullDetIntRate.Text, out ir))
            {
              
            }
            else
            {
                errorProvider4.SetError(txtManAccPFullDetIntRate, "Please select account type");
                allInputValid = false;
            }


            
            //sort code
            string sortC = txtManAccPFullDetSortC.Text;

            int balance = bal;
            int overdDr = od;
            int intRate = ir;
            int accId = int.Parse(txtManAccPFullDetAccNo.Text);


            if (allInputValid == true)
            {
                acc = new Account(accId, type, sortC, balance, intRate, overdDr);
            }

            else
            {

                MessageBox.Show("There are errors in entered account details." 
                                    + "\n"+accountTypeWarning 
                                    + "\nPlease correct.");
            }

            return acc;      
               
        }

        
        


        //create a new acc holder
        private AccountHolder CreateNewAccHolderObject()
        {
            string fName = txtManAccPFullDetFName.Text;
            string lName = txtManAccPFullDetLName.Text;
            string email = txtManAccPFullDetEmail.Text;
            string phone = txtManAccPFullDetPho.Text;
            string add1 = txtManAccPFullDetAddr1.Text;
            string add2 = txtManAccPFullDetAddr2.Text;
            string city = txtManAccPFullDetCity.Text;       
            string county;
            
            if (cmbManAccPFullDetCounty.SelectedItem == null)
            {
                county = "";
            }
            else
                county = cmbManAccPFullDetCounty.SelectedItem.ToString();

            int id = int.Parse(txtManAccPFullDetAccHolder.Text);
            AccountHolder ah = new AccountHolder(id, fName, lName, email, phone, add1, add2, city, county);
            
            
            return ah;
        }


        //get and populate full account and holder details (for edit and view)
        private void GetAndPopulateAccountAndHolderDetails(int accNumber)
        {
            Account acc;
            BLLAccountMgmt bllAM = new BLLAccountMgmt();
            acc = bllAM.GetAccountDetailsBLL(accNumber);


            //get holder details
            int holderID = acc.AccountHolderID;
            AccountHolder accHold;
            accHold = bllAM.GetAccHolderDetailsBLL(holderID);

            if (accHold.FirstName != null)
            {
                
               

                //display holder details
                txtManAccPFullDetFName.Text = accHold.FirstName;
                txtManAccPFullDetLName.Text = accHold.Surname;
                txtManAccPFullDetEmail.Text = accHold.Email;
                txtManAccPFullDetPho.Text = accHold.Phone;
                txtManAccPFullDetAddr1.Text = accHold.Address1;
                txtManAccPFullDetAddr2.Text = accHold.Address2;
                txtManAccPFullDetCity.Text = accHold.City;
                cmbManAccPFullDetCounty.SelectedItem = accHold.County;
                txtManAccPFullDetAccHolder.Text = accHold.ID.ToString();

                //display account details
                txtManAccPFullDetAccNo.Text = acc.Id.ToString();
                txtManAccPFullDetSortC.Text = acc.SortCode;
                txtManAccPFullDetIntBal.Text = acc.Balance.ToString();

                
               


                if (acc.Type.ToString().ToLower() == "current")
                {
                    rbtManAccPFullDetCurrent.Checked = true;
                    txtManAccPFullDetIntRate.Enabled = false;
                }

                else if (acc.Type.ToString().ToLower() == "savings")
                {
                    rbtManAccPFullDetSavings.Checked = true;
                    txtManAccPFullDetOverdr.Enabled = false;
                }

               
                txtManAccPFullDetOverdr.Text = acc.OverdraftLimit.ToString();
                txtManAccPFullDetIntRate.Text = acc.InterestRate.ToString();
            }

            else
            {
                MessageBox.Show("Entered account does not exist");
                BackToHomeGridView();
            }
        }
        
        
        
        // display transactions in the dgv
        public void PopulateTransactionsDGV()
        {
            dgvManAcc.DataSource = null;

            BLLTransactionMgmt bllTM = new BLLTransactionMgmt();
            DataSet ds = bllTM.GetAllTransactionsBLL();
            dgvManAcc.DataSource = ds.Tables[0];
            dgvManAcc.Columns[0].HeaderCell.Value = "transaction ID";
            dgvManAcc.Columns[1].HeaderCell.Value = "transaction date";
            dgvManAcc.Columns[2].HeaderCell.Value = "transaction type";
            dgvManAcc.Columns[3].HeaderCell.Value = "description";
            dgvManAcc.Columns[4].HeaderCell.Value = "amount";
            dgvManAcc.Columns[5].HeaderCell.Value = "staff ID";
            dgvManAcc.Columns[6].HeaderCell.Value = "source acc. no.";
            dgvManAcc.Columns[7].HeaderCell.Value = "destination acc. no.";
           
        }










        // ***********   input validation *****************


        //validate first name
        private void txtManAccPFullDetFName_Validating(object sender, CancelEventArgs e)
        {



            if (string.IsNullOrEmpty(txtManAccPFullDetFName.Text))
            {
                errorProvider1.SetError(txtManAccPFullDetFName, "Please enter first name");

                e.Cancel = true;
            }
            else
            {

                e.Cancel = false;
            }

        }

        //first name validated
        private void txtManAccPFullDetFName_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }








        //validate last name
        private void txtManAccPFullDetLName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtManAccPFullDetLName.Text))
            {
                errorProvider2.SetError(txtManAccPFullDetLName, "Please enter last name");

                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        //last name validated
        private void txtManAccPFullDetLName_Validated(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }







        //validate balance
        private void txtManAccPFullDetIntBal_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrEmpty(txtManAccPFullDetIntBal.Text))
            {
                errorProvider3.SetError(txtManAccPFullDetIntBal, "Please enter a number");

                e.Cancel = true;
            }

            else
            {

                e.Cancel = false;
            }
        }


        //balance validated
        private void txtManAccPFullDetIntBal_Validated(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }







        //valdate email
        private void txtManAccPFullDetEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtManAccPFullDetEmail.Text))
            {
                errorProvider5.SetError(txtManAccPFullDetEmail, "Please enter email address");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtManAccPFullDetEmail.Text, emailRegEx))
            {
                errorProvider5.SetError(txtManAccPFullDetEmail, "Incorrect format for email address");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        //email validated
        private void txtManAccPFullDetEmail_Validated(object sender, EventArgs e)
        {
            errorProvider5.Clear();
        }

        
        
        //phone
        private void txtManAccPFullDetPho_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtManAccPFullDetPho.Text))
            {
                errorProvider6.SetError(txtManAccPFullDetPho, "Please enter phone");

                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        
        //address 1
        private void txtManAccPFullDetAddr1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtManAccPFullDetAddr1.Text))
            {
                errorProvider7.SetError(txtManAccPFullDetAddr1, "Please enter address1");

                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        //address 2
        private void txtManAccPFullDetAddr2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtManAccPFullDetAddr2.Text))
            {
                errorProvider8.SetError(txtManAccPFullDetAddr2, "Please enter address2");

                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        
        //city 
        private void txtManAccPFullDetCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtManAccPFullDetCity.Text))
            {
                errorProvider9.SetError(txtManAccPFullDetCity, "Please enter city");

                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        
        //county
        private void cmbManAccPFullDetCounty_Validating(object sender, CancelEventArgs e)
        {

            if (cmbManAccPFullDetCounty.SelectedIndex < 0)
            {
                errorProvider10.SetError(cmbManAccPFullDetCounty, "Please select county");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void panelManAccFullDet_Paint(object sender, PaintEventArgs e)
        {

        }









        
        
    }
}
