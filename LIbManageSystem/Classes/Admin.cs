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
    class Admin : Librarians
    {
        public Admin() { }

        public int addLibrarian(string FName, string LName, string line1, string city, string contact,
           string uername, string password, string libtype)
        {

            try
            {
                string query = "INSERT INTO tbl_Librarian(libFirstName,libLastName,addressLine1,addressLine2,contactNumber,username,libpassword,libtype)VALUES(" + "'" + FName + "'" + ","
                                + "'" + LName + "'" + "," + "'" + line1 + "'" + ","
                                + "'" + city + "'" + "," + "'" + contact + "'" + "," +
                                "'" + uername + "'" + "," + "'" + password + "'" + "," +
                                "'" + libtype + "'" + ")";
                Classes.Database db = new Classes.Database();
                int ret = db.updateDatabase(query);
                return ret;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DataTable searchLibrarian(string keywords) {

            Classes.Database dt = new Classes.Database();
            string query = @"SELECT * From tbl_Librarian WHERE libFirstName = '" + keywords + "' OR libFirstName LIKE '%" + keywords + "%' " +
                "libLastName = '" + keywords + "' OR libLastName LIKE '%" + keywords + "%' ;";
            try
            {
                dt = new Classes.Database();
                return dt.retriveData(query);

            }
            catch (Exception ex) {

                throw ex;
            }
        }
    }
}
