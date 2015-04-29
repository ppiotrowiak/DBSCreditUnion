using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DataModels;
using System.Data;


namespace BLL
{
    public class BLLAccountMgmt
    {
        DALAccountMgmt dalAM = new DALAccountMgmt();

        
        // ******** get next holder id + next account no
        
        //holder ID
        public int GetNextHolderIDBLL()
        {
            int nextHoldID = 0;
            try
            {
            nextHoldID = dalAM.GetNextHolderIDDAL();
            }
            catch (Exception ex)
            {
                throw;
            }

            return nextHoldID;
        }

        
        //account no
        public int GetNextAccNoBLL()
        {
            int accNo = 0;
            try
            {
            accNo = dalAM.GetNextAccNoDAL();
            }
            catch (Exception ex)
            {
                throw;
            }

            return accNo;       
        }


        //************* CREATE NEW HOLDER AND ACCOUNT **************

        public AccountHolder GetAccHolderDetailsBLL(int accHolderID)
        {
            AccountHolder ah;

            DALAccountMgmt dalAM = new DALAccountMgmt();
            try
            {
            ah = dalAM.GetAccHolderDetailsDAL(accHolderID);
            }
            catch (Exception ex)
            {
                throw;
            }

             return ah;
        
        }
        
        
        
        //New Acc Holder
        public bool AddNewHolderBLL(AccountHolder ah)
        {
            bool success = false;

            DALAccountMgmt dalAM = new DALAccountMgmt();
            try
            {
            success = dalAM.AddNewHolderDAL(ah);
            }
            catch (Exception ex)
            {
                throw;
            }

            return success;
        
        }

        //new account
        public bool AddNewAccountBLL(Account acc, int holderID)
        {
            bool success = false;

            DALAccountMgmt dalAM = new DALAccountMgmt();
            try
            {
            success = dalAM.AddNewAccountDAL(acc, holderID);
            }
            catch (Exception ex)
            {
                throw;
            }

            return success;
        }

       


        
        //******************  ACCOUNTS DGV ***************

        public DataSet GetAllAccountsBLL()
        {           

            DALAccountMgmt dalAM = new DALAccountMgmt();
            
            DataSet ds = dalAM.GetAllAccountsDAL();
                       

            return ds;
        
        }


       
        
        
        // *************** EDIT ACCOUNT ****************

        //get account details
        public Account GetAccountDetailsBLL(int accNum)
        {

            Account acc;
            
            DALAccountMgmt dalAM = new DALAccountMgmt();
            try
            {
            acc = dalAM.GetAccountDetailsDAL(accNum);
            }
            catch (Exception ex)
            {
                throw;
            }
            return acc;

        }

        
        
        //edit account
        public bool EditAccountBLL(Account acc)
        {
            bool success = false;

            DALAccountMgmt dalAM = new DALAccountMgmt();
            try
            {
            success = dalAM.EditAccountDAL(acc);
            }
            catch (Exception ex)
            {
                throw;
            }
            return success;
        }


        
        
        //edit holder
        public bool EditAccHolderBLL(AccountHolder ah)
        {
            bool success = false;

            DALAccountMgmt dalAM = new DALAccountMgmt();

            try
            {
            success = dalAM.EditAccHolderDAL(ah);
            }
            catch (Exception ex)
            {
                throw;
            }
            return success;
        }

        public bool CheckLoginBLL(Staff stf)
        {
            bool success = false;

            DALAccountMgmt dalAM = new DALAccountMgmt();
            try
            {
            success = dalAM.CheckLoginDAL(stf);
            }
            catch (Exception ex)
            {
                throw;
            }
            return success;
        }

        
      

    }

    
}
