using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LIbManageSystem.Classes
{
    class Librarian:Librarians
    {
       
        // Connection String
        

        public Librarian() { }

        public Librarian(string FName, string LName, string line1, string city, string contact,
            string uername, string password, string type)
        {
            FirstName = FName;
            LastName = LName;
            addressline1 = line1;
            addressCity = city;
            contactNo = contact;
            usrName = uername;
            libtype = type;
            libpassword = password;

        }
        Classes.Database dt = new Classes.Database();

        






    }
}
