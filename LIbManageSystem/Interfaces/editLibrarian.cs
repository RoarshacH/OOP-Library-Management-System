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
    public partial class editLibrarian : Form
    {
        public editLibrarian()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Classes.Admin lib = new Classes.Admin();
            DataTable tbl = lib.searchLibrarian(txt_search_key.ToString());
            view_librarians.DataSource = tbl;
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
    }
}
