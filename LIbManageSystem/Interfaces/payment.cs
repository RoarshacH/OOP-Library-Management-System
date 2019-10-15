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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Classes.Librarian nav = new Classes.Librarian();
            nav.navigation();
        }
        public void clean()
        {
            txt_lib.Clear();
            txt_mem.Clear();
            txt_payment.Clear();
            txt_detals.Clear();
            cmb_type.SelectedIndex = -1;

        }

        private void Btn_payment_Click(object sender, EventArgs e)
        {
            if ((txt_mem.Text == "") || (txt_lib.Text == "") || (cmb_type.Text=="") || (txt_payment.Text == "") ||(txt_detals.Text==""))
            {
                MessageBox.Show("Reqvied Fields are Emplty", "Empty Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                int mem = Convert.ToInt32(txt_mem.Text);
                int lib = Convert.ToInt32(txt_lib.Text);
                float pay = (float)Convert.ToDouble(txt_payment.Text);
                Classes.Payments py = new Classes.Payments();
                int r = py.addPayment(Convert.ToString(cmb_type.Text), pay, Convert.ToString(txt_detals.Text), 
                    lib, mem, Convert.ToString(cur_date.Text));

                if (r != 0)
                {
                    MessageBox.Show("Payment Accepted");
                }
                else
                {
                    MessageBox.Show("Error Saving Data");
                }
            }
            
            clean();

        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_mem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_lib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
