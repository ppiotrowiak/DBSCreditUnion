using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        //parameterless constr.
        public Staff()
        {

        }


        //full constructor
        public Staff(int id, string name, string pass)
        {
            Id = id;
            Name = name;
            Password = pass;
        }


    }


}
