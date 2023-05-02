using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class FRegister : Form
    {
        public FRegister()
        {
            InitializeComponent();
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_sdt.ForeColor = Color.White;
                lb_err_sdt.Visible = false;
            }
            catch
            {

            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_name.ForeColor = Color.White;
                lb_err_name.Visible = false;
            }
            catch
            {

            }
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_pass.ForeColor = Color.White;
                lb_err_pass.Visible = false;
            }
            catch
            {

            }
        }

        private void tb_confirmpass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_confirmpass.ForeColor = Color.White;
                lb_err_confirmpass.Visible = false;
            }
            catch
            {

            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            bool isIntString = tb_sdt.Text.ToString().All(char.IsDigit);
            if (tb_sdt.Text == "" || tb_sdt.Text == "Enter  phone number" || !isIntString)
            {
                lb_err_sdt.Visible = true;

                tb_sdt.Focus();
                return;
            }
            else if (tb_name.Text == "" || tb_name.Text == "Enter name")
            {
                lb_err_name.Visible = true;
                tb_name.Focus();
                return;
            }
            else if (tb_pass.Text == "" || tb_pass.Text == "Enter name")
            {
                lb_err_pass.Visible = true;
                tb_pass.Focus();
                return;
            }
            else if (tb_confirmpass.Text == "" || tb_confirmpass.Text == "Enter name")
            {
                lb_err_confirmpass.Visible = true;
                tb_confirmpass.Focus();
                return;
            }
            else if (tb_confirmpass.Text != tb_pass.Text)
            {
                lb_err_confirmpass.Visible = true;
                tb_confirmpass.Focus();
                lb_err_pass.Visible = true;
                tb_pass.Focus();
            }
            else
            {
                String sdt = tb_sdt.Text.ToString();
                String name = tb_sdt.Text.ToString();
                int diemtl = 0;
                String pass = tb_pass.Text.ToString();
                bool check = KhachHangBUS.Instance.InsertAccountKhachHang(sdt, name, diemtl, pass);
                if (check)
                {
                    MessageBox.Show("ok");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void linklb_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void tb_sdt_Click(object sender, EventArgs e)
        {
            tb_sdt.SelectAll();
        }

        private void tb_name_Click(object sender, EventArgs e)
        {
            tb_name.SelectAll();
        }

        private void tb_pass_Click(object sender, EventArgs e)
        {
            tb_pass.SelectAll();
        }

        private void tb_confirmpass_Click(object sender, EventArgs e)
        {
            tb_confirmpass.SelectAll();
        }
    }
}
