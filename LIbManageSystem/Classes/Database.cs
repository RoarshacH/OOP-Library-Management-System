using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace LIbManageSystem.Classes
{
    class Database
    {
        private string ConnectionString { get; set; }
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter dataadapter;
        private SqlDataReader reader;

        public Database()
        {
            string ConnectionString = @"Data Source=LAPTOP-DILSHAN\SQLEXPRESS;Initial Catalog=db_Libmanage;Integrated Security=True;";
            con = new SqlConnection(ConnectionString);
        }

        // Update Database
        public int updateDatabase(string query)
        {
            int result = 0;
            using (con)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    result = cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (SqlException)
                {
                    
                    //MessageBox.Show(ex.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return result;
        }

        // Query Database
        public DataTable retriveData(string query)
        {
            DataTable dt = new DataTable();

            using (con)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    dataadapter = new SqlDataAdapter(query, con);
                    dataadapter.Fill(dt);
                    con.Close();
                }
                catch (SqlException)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
            return dt;
        }
    
    }
}
