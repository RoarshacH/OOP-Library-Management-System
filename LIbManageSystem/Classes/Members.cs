using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace LIbManageSystem.Classes
{
    class Members

    {
        public int Id { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string addressline1 { get; set; }
        protected string addressCity { get; set; }
        protected string contactNo { get; set; }

        Classes.Database dt;

        public int addMember(string FName, string LName, string line1, string city, string contact)
        {

            try
            {
                
                string query = "INSERT INTO tbl_Member(memFirstName,memLastName,memaddressLine1,memaddressLine2,memcontactNumber) VALUES(' " +
                                FName + "' , '" + LName + "' , '"+ line1 + "' , '" + city + "' , '" +contact+ "' )";
                dt = new Classes.Database();
                Console.WriteLine(query);
                int ret = dt.updateDatabase(query);
                return ret;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DataTable searchmem(int memid) {
            string query = @"select * from tbl_Member where mem_ID = " +memid;
            try
            {
                dt = new Classes.Database();
                return dt.retriveData(query);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public int update_member(string FName, string LName, string line1, string city, string contact,int memid) {

            try
            {

                string query = "UPDATE tbl_Member SET memFirstName = '" + FName +
                    "', memLastName = '"+ LName +"' ,memaddressLine1 ='"+line1+"', memaddressLine2 = '"+ city
                    +"', memcontactNumber = '"+contact +"' WHERE mem_ID ="+memid;
                dt = new Classes.Database();
                Console.WriteLine(query);
                int ret = dt.updateDatabase(query);
                return ret;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public int delete_member(int mem)
        {

            try
            {

                string query = "DELETE FROM tbl_Member WHERE mem_ID = " + mem;
                dt = new Classes.Database();
                int ret = dt.updateDatabase(query);
                return ret;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private Boolean pending_yes(int memid) {

            try
            {
                dt = new Classes.Database();
                string query = "SELECT * FROM tbl_Borrow WHERE mem_id =" + memid + "AND pending = 'YES';";
                Boolean pending;
                DataTable tbl =  dt.retriveData(query);
                if (tbl.Rows.Count >= 2)
                {
                    pending = true;
                }
                else
                {
                    pending = false;
                }
                return pending;

            }
            catch (Exception)
            {

                throw;
            }

        }

        private Boolean alredy_borrowed(int bookid)
        {

            string query = @"select * from tbl_Books where book_ID = " + bookid + " AND bkstatus ='Unavailable'";
            try
            {
                dt = new Classes.Database();
                Boolean borrowed;
                DataTable tbl = dt.retriveData(query);
                if (tbl.Rows.Count == 1)
                {
                    borrowed = true;
                }
                else
                {
                    borrowed = false;
                }
                return borrowed;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public int borrw_book(int mem, int book, string acc_date, string ret_date)
        {
            int ret;
            if (alredy_borrowed(book))
            {
                MessageBox.Show("BOOK Alredy Borrowed", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                ret = -1;
            }
            else if (pending_yes(mem))
            {
                MessageBox.Show("User alredy Borrowed 2 Books", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                ret = -1;
            }
            else
            {
                string query = "INSERT INTO tbl_borrow(mem_id,book_id,borrow_date,ret_date,pending)VALUES( " +
                                    mem + ", " + book + ", '" + acc_date + "', '" + ret_date + "','YES');" +
                                    "UPDATE tbl_Books SET bkstatus ='Unavailable' WHERE book_ID = " + book + ";";
                dt = new Classes.Database();
                ret = dt.updateDatabase(query);      

            }
            return ret;

        }
        public DataTable fill_book(int mem, int book)
        {
            dt = new Classes.Database();
            string query = "SELECT * FROM tbl_Borrow WHERE mem_id =" + mem + "AND book_id = " + book +
                ";";
            return dt.retriveData(query);
        }

        public int ret_book(int mem, int book, string date,float fine)
        {


            try
            {
                // Db Connection

                string query = "UPDATE tbl_Books SET bkstatus ='Available' WHERE book_ID = " + book + "; " +
                                "UPDATE tbl_borrow SET pending ='NO' ,fine = "+ fine + 
                                " WHERE book_id = " + book + "AND mem_id =" + mem + ";";

                DateTime today = DateTime.Today;
                
                dt = new Classes.Database();
                int ret = dt.updateDatabase(query);
                return ret;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public DataTable findb_book(int mem)
        {

            try
            {
                // Db Connection
                dt = new Classes.Database();
                string query = "SELECT tbl_borrow.book_id,book_name,fine_day FROM tbl_Borrow,tbl_Books WHERE mem_id =" +
                    mem + " AND pending= 'YES' AND tbl_borrow.book_id = tbl_Books.book_ID;";
                return dt.retriveData(query);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }



    }
}
