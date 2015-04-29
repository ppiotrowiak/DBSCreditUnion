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
    public class BLLTransactionMgmt
    {
        // cashier account number as a constant
        private readonly int cashierNo = 10000001;
        
        // external transfer special account
        private readonly int externalNo = 10000002;

        // staffId - to be taken from login screen in the next version 
        private readonly int staffId = 1;
        

        

        //Get all transactions
        public DataSet GetAllTransactionsBLL()
        {

            DALTransactionMgmt dalTM = new DALTransactionMgmt();
            DataSet ds = dalTM.GetAllTransactionsDAL();

            return ds;

        }

        // Business logic for storing deposit details
        public string SaveDeposit(Account account, int amount)
        {
            string result;
            bool stored;
            string transId = "";

            if (account != null)
            {
                result = "Account to receive deposit " + account.ToString();
                
                if (amount > 0)
                {
                    if (account.Type == "CURRENT" || account.Type == "SAVINGS")
                    {
                        result += "Amount to be deposited to account: " + amount;
                        // code for dll here
                        Transaction transaction = new Transaction("DEPOSIT", "", amount, staffId, cashierNo, account.Id);
                        DALTransactionMgmt DALma = new DALTransactionMgmt();
                        stored = DALma.AddNewtransaction(transaction, ref transId);

                        if (stored)
                        {
                            result += " Transaction stored successfully. Transaction reference: " + transId;
                        }
                        else
                        {
                            result += " Something went wrong, transaction not stored.";
                        }
                    }
                    else
                    {
                        result = "Ungrecognised type of account, has to be CURRENT or SAVINGS";
                    }
                }
                else
                {
                    result += "Amount to deposit must be greater than 0.";
                }
            }
            else
            {
                result = "Account not received";
            }
            return result;
        }

        // Business logic for withdrawal of deposits
        public string WithdrawMoney(Account account, int amount)
        {
                    
            // result to send back to presentation layer
            string result;
            bool stored;
            string transId = "";
            

            if (account != null)
            {
                if (amount > 0)
                {
                    if (account.Type == "SAVINGS")
                    {
                        if (account.Balance >= amount)
                        {
                            
                            // perform transfer
                            Transaction transaction = new Transaction("WITHDRAWAL", "" ,amount, staffId, account.Id, cashierNo);
                            DALTransactionMgmt DALma = new DALTransactionMgmt();
                            stored = DALma.AddNewtransaction(transaction, ref transId);

                            if (stored)
                            {
                                result = "Transaction stored successfully. Transaction reference: " + transId;
                            }
                            else
                            {
                                result = "Something went wrong, transaction not stored.";
                            }
                        }
                        else
                        {
                            result = "Insufficient balance.";
                        }
                    }
                    else if (account.Type == "CURRENT")
                    {
                        if ((account.Balance + account.OverdraftLimit) >= amount)
                        {
                            
                            // perform transfer
                            Transaction transaction = new Transaction("WITHDRAWAL", "", amount, staffId, account.Id, cashierNo);
                            DALTransactionMgmt DALma = new DALTransactionMgmt();
                            stored = DALma.AddNewtransaction(transaction, ref transId);
                            if (stored)
                            {
                                result = "Transaction stored successfully.";
                            }
                            else
                            {
                                result = "Something went wrong, transaction not stored.";
                            }
                        }
                        else
                        {
                            result = "Insufficient balance.";
                        }
                    }
                    else
                    {
                        result = "Wrong account type, has to be CURRENT or SAVINGS";
                    }
                }
                else
                {
                    result = "Amount to withdraw must be greater than 0.";
                }
            }
            else
            {
                result = "Something went wrong, account not received.";
            }

            return result;
        }

        // Business logic for transfers internal (overloaded methods
        public string Transfer(Account source, Account destination, int amount, string description)
        {
            // result to send back to presentation layer
            string result;
            bool stored;
            Transaction transaction;
            string transId = "";

            if ((source.Type != "CURRENT" && source.Type != "SAVINGS") || (destination.Type != "CURRENT" && destination.Type != "SAVINGS"))
            {
                result = "Only transfers involving CURRENT and SAVINGS accounts are permitted";
            }
            else
            {
                if ((source.Type == "CURRENT" && amount > (source.Balance + source.OverdraftLimit))
                    || (source.Type == "SAVINGS" && amount > source.Balance))
                {
                    result = "Insufficient balance.";
                }
                else
                {
                    if (source.Id == destination.Id)
                    {
                        result = "Transfers within the same account is not permitted!";
                    }
                    else
                    {
                        // Create a new transaction
                        transaction = new Transaction("TRANSFER", description, amount, staffId, source.Id, destination.Id);
                        DALTransactionMgmt DALma = new DALTransactionMgmt();
                        // Executing the transaction
                        stored = DALma.AddNewtransaction(transaction, ref transId);

                        if (stored)
                        {
                            result = "Transaction executed successfully. Transaction reference: " + transId;
                        }
                        else
                        {
                            result = "Something went wrong. Transaction not stored.";
                        }                      
                    }
                }
            }
            return result;
        }

        // Business logic for transfering money to an account outside of DBS Credit Union
        public string Transfer(Account source, Account destination, AccountHolder holder, int amount, string description)
        {
            // result to send back to presentation layer
            string result;
            bool stored;
            Transaction transaction;
            string tdescription;
            string transId = "";

            if (source.Type != "CURRENT") 
            {
                result = "Only transfers involving CURRENT accounts are permitted";
            }
            else
            {
                if (amount > (source.Balance + source.OverdraftLimit))
                    
                {
                    result = "Insufficient balance.";
                }
                else
                {
                    result = "Creating new transaction";
                    // Create a new transaction
                    // Reshaping the description
                    tdescription = "To: Name: " + holder.FirstName + " Account number: " + destination.Id.ToString() 
                        + " Sort Code: " + destination.SortCode + " ;" + description;

                    transaction = new Transaction("EXTRANSFER", tdescription, amount, staffId, source.Id, externalNo);
                    DALTransactionMgmt DALma = new DALTransactionMgmt();
                    // Executing the transaction
                    stored = DALma.AddNewtransaction(transaction, ref transId);

                    if (stored)
                    {
                        result = "Transaction executed successfully. Transaction reference: " + transId;
                    }
                    else
                    {
                        result = "Something went wrong. Transaction not stored.";
                    }
                    
                }
            }
            return result;
        }
    }
}
