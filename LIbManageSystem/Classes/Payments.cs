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
    class Payments
    {
        public int pay_ID { get; set; }
        public string payType { get; set; }
        public string paymentAmount  { get; set; }
        public string paymentDetails { get; set; }

        Classes.Database dt;
        public Payments() { }

        public int addPayment(string p_type,float p_amt, string p_details,int libID,int memID,string curr_time) {
            
            
            try
            {
                dt = new Classes.Database();
                string query = "INSERT INTO tbl_Payment (payType, paymentAmount, paymentDetails,lib_id,mem_id,date_time) VALUES('"
                                + p_type + "' , " +p_amt+" , '"+ p_details + "' , "+ libID + " , " + memID + ", '" + curr_time + "' )";
                MessageBox.Show(query);
                int ret = dt.updateDatabase(query);
               
                return ret;

            }
            catch (Exception ex)
            {

                
                throw ex;
            }


        }

        

    }
}
