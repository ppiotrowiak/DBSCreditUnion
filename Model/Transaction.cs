using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Transaction
    {
        public int      Id                   { get; set; }
        public string   Date                 { get; set; }
        public string   Type                 { get; set; }
        public string   Description          { get; set; }
        public int      Amount               { get; set; }
        public int      StaffId              { get; set; }
        public int      SourceAccountId      { get; set; }
        public int      DestinationAccountId { get; set; }

        // basic constructor
        public Transaction()
        {

        }

        // constructor with all parameters except Date and ID
        public Transaction(string type, string description, int amount, int staffId, int source, int destination)
        {
            Id = 0;
            Date = "";
            Type = type;
            Description = description;
            Amount = amount;
            StaffId = staffId;
            SourceAccountId = source;
            DestinationAccountId = destination;
        }

        // constructor with all parameters except ID
        public Transaction(string date, string type, string description, int amount, int staffId, int source, int destination)
        {
            Id = 0;
            Date = date;
            Description = description;
            Amount = amount;
            StaffId = staffId;
            SourceAccountId = source;
            DestinationAccountId = destination;
        }

        // constructor will all parameters
        public Transaction(int id, string date, string type, string description, int amount, int staffId, int source, int destination)
        {
            Id = id;
            Date = date;
            Description = description;
            Amount = amount;
            StaffId = staffId;
            SourceAccountId = source;
            DestinationAccountId = destination;
        }

        // ToString for debugging
        public override string ToString()
        {
            return "Id: " + Id + "\n Date: " + Date + "\n Description: " + Description + "\nAmount: " + Amount + "\nStaffId: "
                + StaffId + "\nSource Account:" + SourceAccountId + "\nDestination Account" + DestinationAccountId;
        }
    }
}
