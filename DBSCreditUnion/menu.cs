using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSCreditUnion
{
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
        }

        //logout
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show home form
            frmHome home = new frmHome();
            home.Visible = true;
            home.panelHomeLogin.Visible = false;
            
            //close current form
            ExitCurrentForm();
        }

        
        
        
        //exit application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        
        
        
        //view all accounts
        private void viewAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close current form
            ExitCurrentForm();

            frmManageAccounts ma = new frmManageAccounts();
            ma.PopulateAccountsDGV();

            ma.lblManAccDgvHeader.Text = "Accounts";
            ma.panelAccManNewAcc.Visible = false;
            ma.panelManAccEditSearch.Visible = false;
            ma.panelManAccFullDet.Visible = false;
            ma.ShowDialog();
        }

        
        
        
        //view all transations
        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close current form
            ExitCurrentForm();

            frmManageAccounts ma = new frmManageAccounts();
            // Here load dgv - there is only 1 dgv
            ma.PopulateTransactionsDGV();

            ma.lblManAccDgvHeader.Text = "Transactions";
            ma.panelAccManNewAcc.Visible = false;
            ma.panelManAccEditSearch.Visible = false;
            ma.panelManAccFullDet.Visible = false;
            ma.ShowDialog();
        }
      

        
        //add new account
        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close current form
            ExitCurrentForm();

            frmManageAccounts ma = new frmManageAccounts();          
             ma.panelManAccFullDet.Visible = false;
             ma.panelAccManNewAcc.Visible = true;
             ma.panelManAccEditSearch.Visible = false;
             ma.panelManAccViewAccSearch.Visible = false;
           
            
            ma.txtManAccPNewAccAccHolder.Enabled = false;

            ma.ShowDialog();

        }

        
        
        
        //edit account / member
        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close current form
            ExitCurrentForm();            
            
            frmManageAccounts ma = new frmManageAccounts();          

            ma.panelManAccFullDet.Hide();            

            ma.ShowDialog();        
            
        }


        
        //view one account full details
        private void viewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close current form
            ExitCurrentForm();
            
            //select account to view - open form
            frmManageAccounts ma = new frmManageAccounts();
            ma.panelManAccViewAccSearch.Visible = true;          
            ma.panelManAccEditSearch.Visible = false;
            
            ma.ShowDialog();
            
        }
        
        
        



        //****************** TRANSACTIONS *****************************
        
        
        //deposit funds
        private void depositFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close current form
            ExitCurrentForm();
            
            frmManageTransactions tr = new frmManageTransactions("deposit");
                    
            tr.ShowDialog();
                        
        }

        
        
        //withdraw funds
        private void withdrawFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close current form
            ExitCurrentForm();

            frmManageTransactions tr = new frmManageTransactions("withdrawal");
  
            tr.ShowDialog();
        }
               
        
        //transfer funds
        private void transferFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close current form
            ExitCurrentForm();

            frmManageTransactions tr = new frmManageTransactions("transfer");
            tr.ShowDialog();
            
        }


        
        // ********************  METHODS *****************

        private void ExitCurrentForm()
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        
       








    }
}
