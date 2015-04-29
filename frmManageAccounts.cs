using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSCreditUnion
{
    public partial class frmManageAccounts : Form
    {
        public frmManageAccounts()
        {
            InitializeComponent();
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
            
            //prepare next panel and display it
            //to see full code - right-click the box below and select "Stop hiding current"
            //if adding to an existing member
            if (rbtnAccManPNewAccExistingMem.Checked)
            {                          
                //read-only member txt
                txtManAccPFullDetFName.ReadOnly = true;
                txtManAccPFullDetLName.ReadOnly = true;
                txtManAccPFullDetPho.ReadOnly = true;
                txtManAccPFullDetEmail.ReadOnly = true;
                txtManAccPFullDetAddr1.ReadOnly = true;
                txtManAccPFullDetAddr2.ReadOnly = true;
                txtManAccPFullDetCity.ReadOnly = true;
                cmbManAccPFullDetCounty.Enabled = false;
                txtManAccPFullDetAccHolder.ReadOnly = true;
                
                //read only account details
                txtManAccPFullDetSortC.ReadOnly = true;
                txtManAccPFullDetAccNo.ReadOnly = true;                                           
            
            }

            
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

        
        
        
        //CLICK account type - current (enable overdaft)
        private void rbtManAccPFullDetCurrent_Click(object sender, EventArgs e)
        {
            txtManAccPFullDetOverdr.ReadOnly = false;
            txtManAccPFullDetIntRate.ReadOnly = true;
            txtManAccPFullDetOverdr.Text = "0";
        }

        
        
        //CLICK account type - savings (disable overdraft)
        private void rbtManAccPFullDetSavings_Click(object sender, EventArgs e)
        {          
            txtManAccPFullDetOverdr.ReadOnly = true;
            txtManAccPFullDetIntRate.ReadOnly = false;
            txtManAccPFullDetOverdr.Text = "0";

        }

        
        
        //CLICK cancel
        private void btnManAccPFullDetCancel_Click(object sender, EventArgs e)
        {
            //panelManAccFullDet.Controls.Clear();
            BackToHomeGridView();
        }
       

        
        
        //CLICK submit - create a new holder and / or account          
        private void btnManAccPFullDetSubmit_Click(object sender, EventArgs e)
        {                  
            
            MessageBox.Show("All details have been saved");
            
            //show accounts dgv
            BackToHomeGridView();
        }




        
        //*************** EDIT ACCOUNT EVENTS *************************************


        
        //CLICK - next go to full details panel for edit
        private void btnManAccPEditSearchNext_Click(object sender, EventArgs e)
        {


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

        
        
        //CLICK save changes to account or/and account holder
        private void btnManAccPFullDetSaveEdit_Click(object sender, EventArgs e)
        {                                  
            
            
            MessageBox.Show("Changes have been saved");
        }




        
        
        // *******************  VIEW DETAILS OF ONE ACCOUNT ************************
        


        //CLICK next - go to view full details of one account
        private void btnManAccPViewSearchNext_Click(object sender, EventArgs e)
        {


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

       
        //CLICK close full view details panel and show base grid view
        private void btnManAccPFullDetClose_Click(object sender, EventArgs e)
        {
                      
            BackToHomeGridView();
        }


        //CLICK serialize
        private void btnManAccPFullDetSerialize_Click(object sender, EventArgs e)
        {

        }

        
        
        //CLICK deserialize
        private void btnManAccPFullDetDeserialize_Click(object sender, EventArgs e)
        {

        }

       

        
 

        
        //************* METHODS *************************  

        
        //hide all panels and show home grid view (all accounts)
        private void BackToHomeGridView()
        {
            panelManAccFullDet.Visible = false;
            panelAccManNewAcc.Visible = false;
            panelManAccEditSearch.Visible = false;
            panelManAccViewAccSearch.Visible = false;
        }

        
        

       
    }
}
