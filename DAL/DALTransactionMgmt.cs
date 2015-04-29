using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DataModels;

/*
 * This class is responsible for communication with the dabase.
 */ 

namespace DAL
{
    public class DALTransactionMgmt
    {

        private string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DBSCreditUnion"].ConnectionString;

        //************** Populate transactions DGV *************//
        public DataSet GetAllTransactionsDAL()
        {
            // declare a dataset
            DataSet ds = null;
            try
            {
                // create a connection
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    // create new data adapter
                    SqlDataAdapter da = new SqlDataAdapter();

                    // instantiate a dataset
                    ds = new DataSet();

                    // prepare sql command
                    da.SelectCommand = new SqlCommand("spGetAllTransactions", conn);

                    // execute the sql command
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

       
        //Add transaction to the database
        public bool AddNewtransaction(Transaction trans, ref string transId)
        {
            bool result;
            result = false;
            int numRows;

            try
            {
                // define connection and commands
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("spPerformTransfer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // for debugging only
                    //Console.WriteLine("Transaction received");

                    SqlParameter transTypePar = new SqlParameter("@Type", SqlDbType.NVarChar, 256);
                    transTypePar.Value = trans.Type;

                    SqlParameter transDescPar = new SqlParameter("@Description", SqlDbType.NVarChar, 256);
                    transDescPar.Value = trans.Description;

                    // -- Note: check length of the parameter!
                    SqlParameter transAmountPar = new SqlParameter("@Amount", SqlDbType.Int, 4);
                    transAmountPar.Value = trans.Amount;

                    SqlParameter transStaffIdPar = new SqlParameter("@StaffId", SqlDbType.Int, 4);
                    transStaffIdPar.Value = trans.StaffId;

                    SqlParameter transSourceAccPar = new SqlParameter("@SourceID", SqlDbType.Int, 4);
                    transSourceAccPar.Value = trans.SourceAccountId;

                    SqlParameter transDestAccPar = new SqlParameter("@DestinationID", SqlDbType.Int, 4);
                    transDestAccPar.Value = trans.DestinationAccountId;

                    // Output parameters
                    SqlParameter transIDPar = new SqlParameter("@TransactionID", SqlDbType.Int, 4);
                    transIDPar.Direction = ParameterDirection.Output;

                    SqlParameter transStatusPar = new SqlParameter("@Status", SqlDbType.Int, 4);
                    transStatusPar.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(transTypePar);
                    cmd.Parameters.Add(transDescPar);
                    cmd.Parameters.Add(transAmountPar);
                    cmd.Parameters.Add(transStaffIdPar);
                    cmd.Parameters.Add(transSourceAccPar);
                    cmd.Parameters.Add(transDestAccPar);
                    cmd.Parameters.Add(transIDPar);
                    cmd.Parameters.Add(transStatusPar);

                    conn.Open();
                    numRows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (numRows > 0)
                    {
                        result = true;
                        transId = Convert.ToString(transIDPar.Value);
                    }
                    else
                    {
                        transId = "0";
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return result;
        }

    }
}
