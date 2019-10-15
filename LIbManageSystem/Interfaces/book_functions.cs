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
    public partial class book_functions : Form
    {
        public book_functions()
        {
            InitializeComponent();
            string user = Settings.Default.usertype;
            if (user != "admin")
            {
                groupBox_editbk.Visible = false;
                this.Size = new Size(510, 595);
                btn_close.Location = new System.Drawing.Point(423, 0);
                label3.Location = new System.Drawing.Point(159, 16);

            }
        }

        private void Btn_addBook_Click(object sender, EventArgs e)
        {
            if ((txt_bookName.Text =="") || (txt_auther.Text == "") || (txt_price.Text == "") ||
                (txt_fineDay.Text == "") || (txt_location.Text == "") || (cmb_status.Text == ""))
            {
                MessageBox.Show("Required Fields are Empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Classes.Book book = new Classes.Book();
                string bname = txt_bookName.Text;
                string auth = txt_auther.Text;
                string genre = txt_genre.Text;
                float price = (float)Convert.ToDouble(txt_price.Text);
                float fine = (float)Convert.ToDouble(txt_fineDay.Text);
                string location = txt_location.Text;
                string status = cmb_status.Text;


                //int r = book.testAdd(bname, auth);
                int r = book.addBook(bname, auth, genre, price, fine, location, status);
                if (r != 0)
                {
                    MessageBox.Show("New Book is added", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error ading Book", "Details are incorrect Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clear_all();

            }
            
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Classes.Librarian nav = new Classes.Librarian();
            nav.navigation();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_all() {
            txt_bookName.Clear();
            txt_auther.Clear();
            txt_genre.SelectedIndex = -1;
            txt_location.Clear();
            cmb_status.SelectedIndex = -1;
            txt_price.Clear();
            txt_fineDay.Clear();
            
        }
        private void Btn_reset_Click(object sender, EventArgs e)
        {
            clear_all();

        }

        private void Btn_search_book_Click(object sender, EventArgs e)
        {
            if (txt_search_book.Text == "")
            {
                MessageBox.Show("Given Book ID is Empty", "Search ID Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                Classes.Book bk = new Classes.Book();
                DataTable dt = bk.searchbk(Convert.ToInt32(txt_search_book.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Book For the Given ID", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        txt_bookname_change.Text = row["book_name"].ToString();
                        txt_auther_change.Text = row["auther"].ToString();
                        cmb_se.Text = row["genre"].ToString();
                        txt_price_change.Text = row["price"].ToString();
                        txt_fineDay_change.Text = row["fine_day"].ToString();
                        txt_location_change.Text = row["bklocation"].ToString();
                        cmb_status_change.Text = row["bkstatus"].ToString();
                    }
                }   
            }
        }

        private void clear_search() {
            txt_bookname_change.Clear();
            txt_auther_change.Clear();
            cmb_se.SelectedItem = -1;
            txt_price_change.Clear();
            txt_fineDay_change.Clear();
            txt_location_change.Clear();
            cmb_status_change.SelectedItem = -1;
            txt_search_book.Clear();
                       
        }

        private void Btn_delete_book_Click(object sender, EventArgs e)
        {
            Classes.Book bk = new Classes.Book();
            int r = bk.delete_book(Convert.ToInt32(txt_search_book.Text));
            if (r != 0)
            {
                MessageBox.Show("Data Deleted", "Corretly Deleted Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data NOT Deleted", "Error Deleting Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clear_search();
        }

        private void Btn_reset_edit_Click(object sender, EventArgs e)
        {
            clear_search();
        }

        private void Txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Txt_fineDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Btn_confirm_edit_Click(object sender, EventArgs e)
        {
            if ((txt_bookname_change.Text == "") || (txt_auther_change.Text == "") || (txt_price_change.Text == "") ||
                (txt_fineDay_change.Text == "") || (txt_location_change.Text == "") || (cmb_status_change.Text == "") || 
                (txt_search_book.Text == ""))
            {
                MessageBox.Show("Required Fields are Empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Classes.Book book = new Classes.Book();
                string bname = txt_bookname_change.Text;
                string auth = txt_auther_change.Text;
                string genre = cmb_se.Text;
                float price = (float)Convert.ToDouble(txt_price_change.Text);
                float fine = (float)Convert.ToDouble(txt_fineDay_change.Text);
                string location = txt_location_change.Text;
                string status = cmb_status_change.Text;
                int bid = Convert.ToInt32(txt_search_book.Text);


                //int r = book.testAdd(bname, auth);
                int r = book.updateBook(bid,bname, auth, genre, price, fine, location, status);
                if (r != 0)
                {
                    MessageBox.Show("Book Details are Updated", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error Updating Book", "Details are incorrect Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clear_search();

            }
        }

        private void Txt_search_book_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
