using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Account
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string SortCode { get; set; }
        public int Balance { get; set; }
        public int InterestRate { get; set; }
        public int OverdraftLimit { get; set; }
        public int AccountHolderID { get; set; }

        //parameterless constructor
        public Account()
        { 
        
        }
     
        //constructor,  all properties
        public Account(int id, string type, string sortC, int balance, int intRate, int overDr, int accHoldID)
        {
            Id = id;
            Type = type;
            SortCode = sortC;
            Balance = balance;
            InterestRate = intRate;
            OverdraftLimit = overDr;
            AccountHolderID = accHoldID;
        
        }

        //constructor, no holder ID
        public Account(int accId, string type, string sortC, int balance, int intRate, int overDr)
        {
            Id = accId;
            Type = type;
            SortCode = sortC;
            Balance = balance;
            InterestRate = intRate;
            OverdraftLimit = overDr;         
        }

        public enum SpGetAccount
        {
            SpGetAccount_Id = 0,
            SpGetAccount_Type,
            SpGetAccount_SortCode,
            SpGetAccount_Balance,
            SpGetAccount_Overdraft,
            SpGetAccount_IntRate,
            SpGetAccount_AccHolderID

        }





        // for debugging only
        public override string ToString()
        {
            string details = Id + "\n" + Type + "\n" + SortCode + "\n" + Balance + "\n" + InterestRate + "\n" + OverdraftLimit + "\n" + AccountHolderID;
            return details;
        }

    }
}
