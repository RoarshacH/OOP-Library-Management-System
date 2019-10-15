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
    public partial class member_functions : Form
    {
        public member_functions()
        {
            InitializeComponent();
        }
        public void clean() {
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_addLine1.Clear();
            txt_addCity.Clear();
            txt_contactNo.Clear();
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Classes.Librarian nav = new Classes.Librarian();
            nav.navigation();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if ((txt_firstName.Text == "") || (txt_lastName.Text == "") || (txt_addLine1.Text == "") ||
                (txt_addCity.Text == "") || (txt_contactNo.Text == ""))
            {
                MessageBox.Show("Some Required Fields Are Empty", "Empty Fields",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                Classes.Members mb = new Classes.Members();
                int r = mb.addMember(txt_firstName.Text, txt_lastName.Text, txt_addLine1.Text, 
                    txt_addCity.Text, txt_contactNo.Text);
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
        private void clean_edit() {
            txt_memse.Clear();
            f_namese.Clear(); 
            l_namese.Clear(); 
            add_se.Clear();
            city_se.Clear();
            contact_se.Clear();
        }
   
        private void Btn_search_mem_Click(object sender, EventArgs e)
        {
            if (txt_memse.Text == "")
            {
                MessageBox.Show("Empty Member Id", "Empty Field",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                Classes.Members mb = new Classes.Members();
                DataTable dt = mb.searchmem(Convert.ToInt32(txt_memse.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No User with this Member Id", "No User",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    foreach (DataRow row in dt.Rows)
                    {
                        txt_memse.Text = row["mem_ID"].ToString();
                        f_namese.Text = row["memFirstName"].ToString();
                        l_namese.Text = row["memLastName"].ToString();
                        add_se.Text = row["memaddressLine1"].ToString();
                        city_se.Text = row["memaddressLine2"].ToString();
                        contact_se.Text = row["memcontactNumber"].ToString();
                    }
                }
            }
                  
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            clean_edit();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_memse.Text == "")
            {
                MessageBox.Show("Empty Member Id", "Empty Field",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Classes.Members mb = new Classes.Members();
                int r = mb.delete_member(Convert.ToInt32(txt_memse.Text));
                if (r != 0)
                {
                    MessageBox.Show("Data Deleted");
                }
                else
                {
                    MessageBox.Show("Error Deleting Data");
                }
                clean_edit();
            }

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if ((f_namese.Text == "") || (l_namese.Text == "") || (add_se.Text == "") ||
                (city_se.Text == "") || (contact_se.Text == "") || (txt_memse.Text == ""))
            {
                MessageBox.Show("Some Required Fields Are Empty", "Empty Fields",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Classes.Members mb = new Classes.Members();
                int r = mb.update_member(f_namese.Text, l_namese.Text, add_se.Text,
                    city_se.Text, contact_se.Text,Convert.ToInt32(txt_memse.Text));
                if (r != 0)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Error Updatig Data");
                }
                clean_edit();
            }
        }

        private void Txt_memse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Contact_se_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_contactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
