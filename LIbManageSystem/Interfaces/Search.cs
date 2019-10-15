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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            Classes.Book bk = new Classes.Book();
            if (txt_Keywords.Text == "")
            {
                MessageBox.Show( "NO Keywords", "Keyords Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (combo_choice.Text == "") {
                MessageBox.Show( "Category Not Selected", "NO Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable ds = bk.bookSearch(combo_choice.Text, txt_Keywords.Text);
                if (ds.Rows.Count == 0)
                {
                    MessageBox.Show("No Books By that Search Parameters", "NO Book", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    searchView1.DataSource = ds;
                }
                
                                
            }
            
        }
    }
}
