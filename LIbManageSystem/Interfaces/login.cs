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

namespace LIbManageSystem
{
    public partial class Form1 : Form
    {
        int user;
        public Form1()
        {
            InitializeComponent();
            clean();
        }
        public void clean() {
            txt_password.Clear();
            txt_username.Clear();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Classes.Librarian lib = new Classes.Librarian();
            string username = txt_username.Text;
            string password = txt_password.Text;

            int r = lib.logIN(username, password);
            user = r;

            if (r == 1)
            {
                this.Hide();
                Interfaces.dashboard_admin admindah = new Interfaces.dashboard_admin();
                admindah.Show();
                Settings.Default.usertype = "admin";
                clean();
                

            }
            else if (r == 2) {

                Interfaces.dashbord_lib libdah = new Interfaces.dashbord_lib();
                libdah.Show();
                this.Hide();
                Settings.Default.usertype = "user";
                clean();
            }
            else
            {
                MessageBox.Show("Incorrect Login");
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Interfaces.Search sh = new Interfaces.Search();
            this.Hide();
            sh.Show();
            clean();
        }
    }
}
