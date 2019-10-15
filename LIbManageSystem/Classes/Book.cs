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
    class Book
    {
        protected int BookId { get; set; }
        protected string BookName { get; set; }
        protected string Auther { get; set; }
        protected string Genre { get; set; }
        protected float Price { get; set; }
        protected float FineDay { get; set; }
        protected string Location { get; set; }
        protected string Status { get; set; }

        // Arributes of Book Class
        public Book(int bookid) {
                      
        }
        // Different Constructors
        public Book() { }

        Classes.Database dt;
        // Real Function
        public int addBook(string BookName, string Auther, string Genre, float Price, float FineDay,
            string Location, string Status)
        {
            try
            {
                // Db Connection
                dt = new Classes.Database(); 
                string query = "INSERT INTO tbl_Books(book_name,auther,genre,price,fine_day,bklocation,bkstatus)VALUES(" + "'" + BookName + 
                    "'" + "," +  "'" + Auther + "'" + "," + "'" + Genre + "'" + "," +
                                Price + "," + FineDay + "," +
                                "'" + Location + "'" + "," + "'" + Status + "'" + ")";
                // SQL Auerry to insert Book Details
                int ret = dt.updateDatabase(query); // runnig the SQL query
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int updateBook(int bkID, string BookName, string Auther, string Genre, float Price, float FineDay,
            string Location, string Status)
        {
            
            try
            {
                // Db Connection
                dt = new Classes.Database();
                string query = "UPDATE tbl_Books SET book_name ='" + BookName + "', auther = '" + Auther + "',genre ='" +
                    Genre + "', price = " + Price + " ,fine_day =" + FineDay + ",bklocation = '" + Location + "', bkstatus ='" + Status
                    + "' WHERE book_ID = " +bkID;
                // SQL Auerry to update Book Details  
                int ret = dt.updateDatabase(query); // runnig the SQL query
                
                return ret; // returing the result of the query 1 == success ,other unsuccesfull
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable searchbk(int bkid)
        {
            string query = @"select * from tbl_Books where book_ID = " + bkid;
            // query to select by book id
            try
            {
                dt = new Classes.Database();
                return dt.retriveData(query);
                // return the data as a data table
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public int delete_book(int bkID)
        {
            try
            {
                string query = "DELETE FROM tbl_Books WHERE book_ID = " + bkID;
                // SQL querry to delete the book record 
                dt = new Classes.Database();
                int ret = dt.updateDatabase(query);
                return ret;
                // returing the result of the query 1 == success ,other unsuccesfull
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataTable bookSearch(string choice,string keywords) {
            //string query = "SELECT * From tbl_Books WHERE @combo = '@input' OR @combo like '%@input%' ";
            string query = @"SELECT book_name AS Name, auther AS Auther, genre AS Genre, bklocation AS Location, bkstatus AS Status"+
                " From tbl_Books WHERE " + choice + " = '" + keywords + "'" + "OR " + choice + " LIKE '%" + keywords + "%';";
            // Query to get Book List When the user search for the Book
            try
            {
                dt = new Classes.Database();
                return dt.retriveData(query);
                // Return the List of Books as a Data Table according to the keywords and by book name or auther 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

