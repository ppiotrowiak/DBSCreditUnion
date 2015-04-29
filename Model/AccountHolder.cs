using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class AccountHolder
    {
        public int ID {get; set;}
        public string FirstName {get; set;}
        public string Surname {get; set;}
        public string Email {get; set;}
        public string Phone {get; set;}
        public string Address1 {get; set;}
        public string Address2 {get; set;}
        public string City {get; set;}
        public string County {get; set;}

        
        //parameterless constructor
        public AccountHolder()
        { 
        
        }
        
        
        //constructor with ID
        public AccountHolder(int id, string fName, string lName, 
            string email, string phone, string add1, string add2, string city, string county)
        {
            ID = id;
            FirstName = fName;
            Surname = lName;
            Email = email;
            Phone = phone;
            Address1 = add1;
            Address2 = add2;
            City = city;
            County = county;       
        }


        //constructor without ID
        public AccountHolder(string fName, string lName,
            string email, string phone, string add1, string add2, string city, string county)
        {            
            FirstName = fName;
            Surname = lName;
            Email = email;
            Phone = phone;
            Address1 = add1;
            Address2 = add2;
            City = city;
            County = county;
        }

        public enum SpGetAccountHolder
        {
            SpGetAccountHolder_FirstName = 0,
            SpGetAccountHolder_Surname,
            SpGetAccountHolder_Email,
            SpGetAccountHolder_Phone,
            SpGetAccountHolder_Address1,
            SpGetAccountHolder_Address2,
            SpGetAccountHolder_City,
            SpGetAccountHolder_County               
        }


    }
}
