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
    public partial class dashboard_admin : Form
    {
        public dashboard_admin()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_books_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaces.book_functions books = new Interfaces.book_functions();
            books.Show();
        }

        private void Btn_librarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaces.addLibrarian lib = new Interfaces.addLibrarian();
            lib.Show();
        }

        private void Btn_members_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaces.member_functions mem = new Interfaces.member_functions();
            mem.Show();
        }

        private void Btn_payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaces.payment pay = new Interfaces.payment();
            pay.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings.Default.usertype = "";
            Form1 log = new Form1();
            log.Show();
        }

        private void Edit_Librarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaces.editLibrarian lib = new Interfaces.editLibrarian();
            lib.Show();
        }
    }
}
