using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using DataModels;

namespace DBSCreditUnion
{
    public partial class frmHome : Form
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DBSCreditUnion"].ConnectionString;
        public frmHome()
        {
            InitializeComponent();
        }
      
               
        
        
        //*************  LOGIN   EVENTS  ********************************
        
        //ON LOAD hide login panel
        private void frmHome_Load(object sender, EventArgs e)
        {
            panelHomeLogin.Visible = false;
        }


        //CLICK show login panel
        private void btnHomeLogin_Click(object sender, EventArgs e)
        {
            panelHomeLogin.Visible = true;
            btnHomeLogin.Visible = false;

        }

        //MENU show login panel
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHomeLogin.Visible = true;
            btnHomeLogin.Visible = false;
        }

        
        //CLICK user logges in. Show frmManageAaccounts
        private void btnHomePLoginLogin_Click(object sender, EventArgs e)
        {
           
            bool success = false;

            Staff stf = new Staff();

            stf.Name = txtHomePLoginUserName.Text;
            stf.Password = txtHomePLoginPassword.Text;

            BLLAccountMgmt bllAM = new BLLAccountMgmt();

            success = bllAM.CheckLoginBLL(stf);

            if (success)
            {              

                this.Hide(); //must not close frmHome - Application Run form

                frmManageAccounts ma = new frmManageAccounts();

                ma.PopulateAccountsDGV();

                ma.panelAccManNewAcc.Visible = false;
                ma.panelManAccEditSearch.Visible = false;
                ma.panelManAccFullDet.Visible = false;
                ma.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");

                panelHomeLogin.Visible = false;
                btnHomeLogin.Visible = true;
                txtHomePLoginUserName.Text = "";
                txtHomePLoginPassword.Text = "";

            }                                                    
                        
           
            
        }


       //****************  EXIT EVENTS ******************************************

        //MENU exit application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

       
    }
}
