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
    public partial class addLibrarian : Form
    {
        public addLibrarian()
        {
            InitializeComponent();
        }
        public void clean() {
           txt_firstName.Clear();
           txt_lastName.Clear();
           txt_addLine1.Clear();
           txt_addCity.Clear();
           txt_contactNo.Clear();
           cmb_libType.SelectedIndex = -1;
           txt_username.Clear();
           txt_password.Clear();

        }

        private void Btn_addLibrarian_Click(object sender, EventArgs e)
        {
            if ((txt_firstName.Text == "") || (txt_lastName.Text == "") || (txt_addLine1.Text == "")||
            (txt_addCity.Text == "") || (txt_contactNo.Text == "") || (cmb_libType.Text == "") ||
            (txt_username.Text == "") || (txt_password.Text == ""))
            {
                MessageBox.Show("Required Fields are Empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Classes.Admin lib = new Classes.Admin();
                string fName = txt_firstName.Text;
                string lName = txt_lastName.Text;
                string line1 = txt_addLine1.Text;
                string city = txt_addCity.Text;
                string contact = txt_contactNo.Text;
                string libtype = cmb_libType.Text;
                string username = txt_username.Text;
                string password = txt_password.Text;

                //int r = book.testAdd(bname, auth);
                int r = lib.addLibrarian(fName, lName, line1, city, contact, username, password, libtype);
                if (r != 0)
                {
                    MessageBox.Show("Data Saved");
                }
                else
                {
                    MessageBox.Show("Data Not Saved");
                }
                clean();
            }
            
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Classes.Librarian nav = new Classes.Librarian();
            nav.navigation();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
