using LIbManageSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbManageSystem.Interfaces
{
    public partial class dashbord_lib : Form
    {
        public dashbord_lib()
        {
            InitializeComponent();
            rtndate.Value = DateTime.Now.AddDays(14);
            string user = Settings.Default.usertype;
            if (user == "admin")
            {
                btn_payment.Visible = false;
                btn_members.Visible = false;
                btn_books.Visible   = false;

            }
            else
            {
                btn_home.Visible = false;
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clean() {
            txt_bookid.Clear();
            txt_memid.Clear();
            cmb_book.Text = "";
            cmb_book.SelectedIndex = -1;
            fine.Clear();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaces.book_functions bk = new Interfaces.book_functions();
            bk.Show();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings.Default.usertype = "";
            Form1 log = new Form1();
            log.Show();
        }

        private void Btn_payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaces.payment pay = new Interfaces.payment();
            pay.Show();
        }

        private void Btn_members_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaces.member_functions mem = new Interfaces.member_functions();
            mem.Show();
        }

        private void Btn_issueBook_Click(object sender, EventArgs e)
        {
            Classes.Members mem = new Classes.Members();
            if (txt_memid.Text == "")
            {
                MessageBox.Show("User ID Is Empty", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_bookid.Text == "")
            {
                MessageBox.Show("BOOK ID is Empty", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            else {

                int r = mem.borrw_book(Convert.ToInt32(txt_memid.Text), Convert.ToInt32(txt_bookid.Text),
                Convert.ToString(today_datetime.Text), Convert.ToString(rtndate.Text));
                if (r > 0)
                {
                    MessageBox.Show("Borrow Book Successfull");
                }
                else if (r == -1) {
                    //Do Nothing
                }
                else
                {
                    MessageBox.Show("User ID or BOOK ID Incorrect", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            clean();
            }

        private void Btn_search_mem_Click(object sender, EventArgs e)
        {
            if (txt_mem_se.Text == "")
            {
                MessageBox.Show("User ID Is Empty","Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                Classes.Members mem = new Classes.Members();
                DataTable dt = mem.findb_book(Convert.ToInt32(txt_mem_se.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Books Borrowed Currently", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    cmb_book.DataSource = dt;
                    cmb_book.DisplayMember = "book_name";
                    cmb_book.ValueMember = "book_id";
                }
                clean();
            }
            
        }

        private void Btn_acceptBook_Click(object sender, EventArgs e)
        {
            
            Classes.Members mem = new Classes.Members();
            if (cmb_book.Text == "")
            {
                MessageBox.Show("NO  Book Selected", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                int r = mem.ret_book(Convert.ToInt32(txt_mem_se.Text), Convert.ToInt32(cmb_book.SelectedValue), Convert.ToString(datertn.Text),
               Convert.ToInt32(fine.Text));
                if (r > 0)
                {
                    MessageBox.Show("Succesfull");
                }
                else
                {
                    MessageBox.Show("Unsuccssfull");
                }
            }
           
            clean();
        }

       
        private void Cmb_book_DropDownClosed(object sender, EventArgs e)
        {
            Classes.Members mem = new Classes.Members();
            if (Convert.ToString(cmb_book.SelectedValue) == "")
            {
                MessageBox.Show("NO  Book Selected", "",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable data = mem.fill_book(Convert.ToInt32(txt_mem_se.Text), Convert.ToInt32(cmb_book.SelectedValue));
                foreach (DataRow row in data.Rows)
                {

                    txt_mem_se.Text = row["mem_id"].ToString();
                    rtn_dateDB.Text = row["ret_date"].ToString();
                    DateTime today = DateTime.Today;
                    DateTime rtndt = Convert.ToDateTime(row["ret_date"].ToString());
                    double difference = (today - rtndt).TotalDays;

                    if (difference > 0)
                    {


                        int finetot = 5 * Convert.ToInt32(difference);
                        fine.Text = Convert.ToString(finetot);
                    }
                    else
                    {
                        fine.Text = Convert.ToString(0);
                    }
                }
            }
       
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Classes.Librarian nav = new Classes.Librarian();
            nav.navigation();
        }

    }
    

     
}
