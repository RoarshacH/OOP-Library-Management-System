using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using LIbManageSystem.Properties;

namespace LIbManageSystem.Classes
{
    abstract class Librarians
    {
        public int Id { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string addressline1 { get; set; }
        protected string addressCity { get; set; }
        protected string contactNo { get; set; }
        protected string usrName { get; set; }
        protected string libtype { get; set; }
        protected string libpassword { get; set; }

        public int logIN(string username, string password)
        {
            try
            {
                int result = 0;
                
                string query = "select * from tbl_Librarian where username = '" +username+"';" ;
                Classes.Database db = new Classes.Database();
                DataTable tbl = db.retriveData(query);
                 foreach (DataRow row in tbl.Rows) {
                        if (row["libpassword"].ToString() == password)
                        {
                            if (row["libtype"].ToString() == "Admin     ")
                            { result = 1; }
                            else
                            { result = 2; }
                            
                        }

                    }
               
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void navigation() {

            string user = Settings.Default.usertype;
            if (user == "admin")
            {
                Interfaces.dashboard_admin admindah = new Interfaces.dashboard_admin();
                admindah.Show();

            }
            else {
                Interfaces.dashbord_lib lib = new Interfaces.dashbord_lib();
                lib.Show();
            }


        }
        // end of login

       
        // end of add librarian
    }
}
