using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DataModels;


namespace DAL
{
       
    
    public class DALAccountMgmt
    {
        
        
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DBSCreditUnion"].ConnectionString;

        
        // *****************************  GET NEXT HOLDER / ACCOUNT ID  **********************
        
        //get next holder ID
        public int GetNextHolderIDDAL()
        {
            string value = "";
            int nextHolderID = 0;

            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spGetMaxAccountHolderID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    value = cmd.ExecuteScalar().ToString();
                    conn.Close();


                    if (value == "")
                    {
                        nextHolderID = 0;
                    }

                    else
                    {
                        nextHolderID = Convert.ToInt32(value) + 1;
                    }
                }
            }
            catch (SqlException ex)
            { 
                throw; 
            }
                                        
            return nextHolderID;        
        }

        
        //get next Account No
        public int GetNextAccNoDAL()
        {
            string value = "";
            int nextAccNo = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spGetMaxAccountID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    value = cmd.ExecuteScalar().ToString();
                    conn.Close();


                    if (value == "")
                    {
                        nextAccNo = 1;
                    }

                    else
                    {
                        nextAccNo = Convert.ToInt32(value) + 1;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return nextAccNo;                  

        }


        //************* CREATE NEW HOLDER AND ACCOUNT **************
        
        //new acc holder
        public bool AddNewHolderDAL(AccountHolder ah)
        {
            bool success = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spAddAccountHolder", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ahFNamePar = new SqlParameter("@AHFirstName", SqlDbType.NVarChar, 256);
                    ahFNamePar.Value = ah.FirstName;

                    SqlParameter ahLNamePar = new SqlParameter("@AHSurname", SqlDbType.NVarChar, 256);
                    ahLNamePar.Value = ah.Surname;

                    SqlParameter ahEmailPar = new SqlParameter("@AHEmail", SqlDbType.NVarChar, 256);
                    ahEmailPar.Value = ah.Email;

                    SqlParameter ahPhonePar = new SqlParameter("@AHPhone", SqlDbType.NVarChar, 256);
                    ahPhonePar.Value = ah.Phone;

                    SqlParameter ahAdd1Par = new SqlParameter("@AHAddress1", SqlDbType.NVarChar, 256);
                    ahAdd1Par.Value = ah.Address1;

                    SqlParameter ahAdd2Par = new SqlParameter("@AHAddress2", SqlDbType.NVarChar, 256);
                    ahAdd2Par.Value = ah.Address2;

                    SqlParameter ahCityPar = new SqlParameter("@AHCity", SqlDbType.NVarChar, 256);
                    ahCityPar.Value = ah.City;

                    SqlParameter ahCountyPar = new SqlParameter("@AHCounty", SqlDbType.NVarChar, 256);
                    ahCountyPar.Value = ah.County;

                    SqlParameter ahIDPar = new SqlParameter("@AccountHolderID", SqlDbType.Int, 4);
                    ahIDPar.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(ahFNamePar);
                    cmd.Parameters.Add(ahLNamePar);
                    cmd.Parameters.Add(ahEmailPar);
                    cmd.Parameters.Add(ahPhonePar);
                    cmd.Parameters.Add(ahAdd1Par);
                    cmd.Parameters.Add(ahAdd2Par);
                    cmd.Parameters.Add(ahCityPar);
                    cmd.Parameters.Add(ahCountyPar);
                    cmd.Parameters.Add(ahIDPar);

                    conn.Open();
                    int numRows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (numRows > 0)
                    {
                        ah.ID = Convert.ToInt16(ahIDPar.Value);
                        success = true;
                    }
                }
            }
            catch (SqlException ex)
            { 
                throw; 
            }
            return success;
        }

        
        
        //new account
        public bool AddNewAccountDAL(Account acc, int holderID)
        {
            bool success = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spAddAccount", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter accTypePar = new SqlParameter("@AccountType", SqlDbType.NVarChar, 256);
                    accTypePar.Value = acc.Type;

                    SqlParameter accSortCPar = new SqlParameter("@AccountSortCode", SqlDbType.Int, 4);
                    accSortCPar.Value = acc.SortCode;

                    SqlParameter accBalancePar = new SqlParameter("@AccountBalance", SqlDbType.Int, 4);
                    accBalancePar.Value = acc.Balance;

                    SqlParameter accOverDPar = new SqlParameter("@AccountOverdraftLimit", SqlDbType.Int, 4);
                    accOverDPar.Value = acc.OverdraftLimit;

                    SqlParameter accIntRateDPar = new SqlParameter("@AccountInterestRate", SqlDbType.Int, 4);
                    accIntRateDPar.Value = acc.InterestRate;

                    SqlParameter accHolderIDPar = new SqlParameter("@AccountHolderID", SqlDbType.Int, 4);
                    accHolderIDPar.Value = holderID; //get from current instance of acc. holder

                    SqlParameter accIDPar = new SqlParameter("@AccountID", SqlDbType.Int, 4);
                    accIDPar.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(accTypePar);
                    cmd.Parameters.Add(accSortCPar);
                    cmd.Parameters.Add(accBalancePar);
                    cmd.Parameters.Add(accOverDPar);
                    cmd.Parameters.Add(accIntRateDPar);
                    cmd.Parameters.Add(accHolderIDPar);
                    cmd.Parameters.Add(accIDPar);


                    conn.Open();
                    int numRows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (numRows > 0)
                    {
                        acc.Id = Convert.ToInt32(accIDPar.Value);
                        success = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            
            return success;
        
        }

        
        
        //****** ADD NEW ACCOUNT TO EXISTING HOLDER *******

        
        
        //Get holder details
        public AccountHolder GetAccHolderDetailsDAL(int holderID)
        {
            //constructor not used here to allow creating an "empty" instance
            //when searched holder doesn't exist. 
            //This in turn prevents null object reference error 
            //when a negative search result is returned to GUI
            
            AccountHolder ah = new AccountHolder();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAccountHolder", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ahIDPar = new SqlParameter("@AccountHolderId", SqlDbType.Int, 4);
                    ahIDPar.Value = holderID;
                    cmd.Parameters.Add(ahIDPar);


                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr != null)
                    {
                        while (dr.Read())
                        {

                            ah.FirstName = dr.GetValue(Convert.ToInt32(DataModels.AccountHolder.SpGetAccountHolder.SpGetAccountHolder_FirstName)).ToString();
                            ah.Surname = dr.GetValue(Convert.ToInt32(DataModels.AccountHolder.SpGetAccountHolder.SpGetAccountHolder_Surname)).ToString();
                            ah.Email = dr.GetValue(Convert.ToInt32(DataModels.AccountHolder.SpGetAccountHolder.SpGetAccountHolder_Email)).ToString();
                            ah.Phone = dr.GetValue(Convert.ToInt32(DataModels.AccountHolder.SpGetAccountHolder.SpGetAccountHolder_Phone)).ToString();
                            ah.Address1 = dr.GetValue(Convert.ToInt32(DataModels.AccountHolder.SpGetAccountHolder.SpGetAccountHolder_Address1)).ToString();
                            ah.Address2 = dr.GetValue(Convert.ToInt32(DataModels.AccountHolder.SpGetAccountHolder.SpGetAccountHolder_Address2)).ToString();
                            ah.City = dr.GetValue(Convert.ToInt32(DataModels.AccountHolder.SpGetAccountHolder.SpGetAccountHolder_City)).ToString();
                            ah.County = dr.GetValue(Convert.ToInt32(DataModels.AccountHolder.SpGetAccountHolder.SpGetAccountHolder_County)).ToString();
                            ah.ID = holderID;

                        }

                    }

                    dr.Close();
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return ah;             
        }



        //******************  POPULATE ACCOUNTS DGV ***************
        
        public DataSet GetAllAccountsDAL()
        {
            DataSet ds = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    ds = new DataSet();

                    da.SelectCommand = new SqlCommand("spGetAllAccountsV2", conn);

                    conn.Open();
                    da.Fill(ds);
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return ds;
        
        }


        //****************  EDIT ACCOUNT ****************************
        
        
        //get account details
        public Account GetAccountDetailsDAL(int accNum)
        {

            //constructor not used here to allow creating an "empty" instance
            //when searched account doesn't exist. 
            //This in turn prevents null object reference error 
            //when a negative search result is returned to GUI.
            
            Account acc = new Account();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAccount", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter accNoPar = new SqlParameter("@AccountID", SqlDbType.Int, 4);
                    accNoPar.Value = accNum;
                    cmd.Parameters.Add(accNoPar);


                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            acc.Id = int.Parse(dr.GetValue(Convert.ToInt32(DataModels.Account.SpGetAccount.SpGetAccount_Id)).ToString());
                            acc.Type = dr.GetValue(Convert.ToInt32(DataModels.Account.SpGetAccount.SpGetAccount_Type)).ToString();
                            acc.SortCode = dr.GetValue(Convert.ToInt32(DataModels.Account.SpGetAccount.SpGetAccount_SortCode)).ToString();
                            acc.Balance = int.Parse(dr.GetValue(Convert.ToInt32(DataModels.Account.SpGetAccount.SpGetAccount_Balance)).ToString());
                            acc.OverdraftLimit = int.Parse(dr.GetValue(Convert.ToInt32(DataModels.Account.SpGetAccount.SpGetAccount_Overdraft)).ToString());
                            acc.InterestRate = int.Parse(dr.GetValue(Convert.ToInt32(DataModels.Account.SpGetAccount.SpGetAccount_IntRate)).ToString());
                            acc.AccountHolderID = int.Parse(dr.GetValue(Convert.ToInt32(DataModels.Account.SpGetAccount.SpGetAccount_AccHolderID)).ToString());
                        }
                    }

                    dr.Close();
                    conn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return acc;
        }


        //edit account
        public bool EditAccountDAL(Account acc)
        {
            bool successEdit = false;
            bool successIntRate = false;
            bool successOverdraft = false;

            try
            {
                //edit overdraft
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spUpdateAccountOverdraftLimit", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter accIDPar = new SqlParameter("@AccountID", SqlDbType.Int, 4);
                    accIDPar.Value = acc.Id;

                    SqlParameter accOverdrPar = new SqlParameter("@NewOverdraftLimit", SqlDbType.Int, 4);
                    accOverdrPar.Value = acc.OverdraftLimit;

                    SqlParameter accRowsPar = new SqlParameter("@RowsAffected", SqlDbType.Int, 4);
                    accRowsPar.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(accIDPar);
                    cmd.Parameters.Add(accOverdrPar);
                    cmd.Parameters.Add(accRowsPar);

                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();


                    if (i > 0)
                    {
                        successOverdraft = true;
                    }

                    //edit interest rate
                    SqlCommand cmd1 = new SqlCommand("spUpdateAccountInterestRate", conn);

                    cmd1.CommandType = CommandType.StoredProcedure;

                    SqlParameter accIDPar1 = new SqlParameter("@AccountID", SqlDbType.Int, 4);
                    accIDPar1.Value = acc.Id;

                    SqlParameter accIntRatePar = new SqlParameter("@NewInterestRate", SqlDbType.Int, 4);
                    accIntRatePar.Value = acc.InterestRate;

                    SqlParameter accRowsPar1 = new SqlParameter("@RowsAffected", SqlDbType.Int, 4);
                    accRowsPar1.Direction = ParameterDirection.Output;

                    cmd1.Parameters.Add(accIDPar1);
                    cmd1.Parameters.Add(accIntRatePar);
                    cmd1.Parameters.Add(accRowsPar1);

                    conn.Open();
                    int x = cmd1.ExecuteNonQuery();
                    conn.Close();

                    if (x > 0)
                    {
                        successIntRate = true;
                    }


                    if (successOverdraft && successIntRate)
                    { successEdit = true; }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            
            return successEdit;

        }

        

        //edit holder
        public bool EditAccHolderDAL(AccountHolder ah)
        {
            bool success = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spEditContactDetails", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter accHoldIDPar = new SqlParameter("@AccountHolderID", SqlDbType.Int, 4);
                    accHoldIDPar.Value = ah.ID;

                    SqlParameter accHoldEmailPar = new SqlParameter("@AHEmail", SqlDbType.NVarChar, 256);
                    accHoldEmailPar.Value = ah.Email;

                    SqlParameter accHoldPhonePar = new SqlParameter("@AHPhone", SqlDbType.NVarChar, 256);
                    accHoldPhonePar.Value = ah.Phone;

                    SqlParameter accHoldAdd1Par = new SqlParameter("@AHAddress1", SqlDbType.NVarChar, 256);
                    accHoldAdd1Par.Value = ah.Address1;

                    SqlParameter accHoldAdd2Par = new SqlParameter("@AHAddress2", SqlDbType.NVarChar, 256);
                    accHoldAdd2Par.Value = ah.Address2;

                    SqlParameter accHoldCityPar = new SqlParameter("@AHCity", SqlDbType.NVarChar, 256);
                    accHoldCityPar.Value = ah.City;

                    SqlParameter accHoldCountyPar = new SqlParameter("@AHCounty", SqlDbType.NVarChar, 256);
                    accHoldCountyPar.Value = ah.County;

                    SqlParameter accHoldRowsAffPar = new SqlParameter("@RowsAffected", SqlDbType.Int, 4);
                    accHoldRowsAffPar.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(accHoldIDPar);
                    cmd.Parameters.Add(accHoldEmailPar);
                    cmd.Parameters.Add(accHoldPhonePar);
                    cmd.Parameters.Add(accHoldAdd1Par);
                    cmd.Parameters.Add(accHoldAdd2Par);
                    cmd.Parameters.Add(accHoldCityPar);
                    cmd.Parameters.Add(accHoldCountyPar);
                    cmd.Parameters.Add(accHoldRowsAffPar);


                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (i > 0)
                    { success = true; }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return success;

        }



        public bool CheckLoginDAL(Staff stf)
        {
            bool success = false;
            string user = stf.Name;
            string pass = stf.Password;

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {

                    SqlDataReader dr = null;
                    con.Open();

                    SqlCommand cmd = new SqlCommand("spCheckLogin", con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter userPar = new SqlParameter("@user", SqlDbType.NVarChar, 256);
                    SqlParameter passPar = new SqlParameter("@pass", SqlDbType.NVarChar, 256);
                    userPar.Value = user;
                    passPar.Value = pass;
                    cmd.Parameters.Add(userPar);
                    cmd.Parameters.Add(passPar);

                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    { success = true; }

                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return success;

        }

        

    }
}
