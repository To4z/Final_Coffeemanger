using BUS;
using Coffee;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_sdt.Text == "" || tb_sdt.Text == "Enter  phone number")
            {
                lb_err_sdt.Visible = true;
                tb_sdt.Focus();
                return;
            }
            else if (tb_password.Text == "" || tb_password.Text == "")
            {
                lb_err_pass.Visible = true;
                tb_password.Focus();
                return;
            }
            else
            {
                String sdt = tb_sdt.Text.ToString();
                String pass = tb_password.Text.ToString();
                Khachhang khachhang = null;
                Nhanvien nhanvien = null;
                nhanvien = NhanVienBUS.Instance.getAccountNhanvien(sdt, pass);
                khachhang = KhachHangBUS.Instance.getAccountKhachHang(sdt, pass);
                if (khachhang != null)
                {
                    FUser home = new FUser();
                    home.Khachhang = khachhang;
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    if (nhanvien != null)
                    {

                        if (nhanvien.Phanquyen)
                        {
                            FAdmin home = new FAdmin();
                            this.Hide();
                            home.ShowDialog();
                            this.Show();
                            this.WindowState = FormWindowState.Minimized;
                        }
                        else
                        {
                            FHomeMenu home = new FHomeMenu();
                            this.Hide();
                            home.Nhanvien = nhanvien;
                            home.ShowDialog();
                            this.Show();
                            this.WindowState = FormWindowState.Minimized;
                        }


                    }
                    else
                    {
                        MessageBox.Show("error! try again!");
                    }
                }
            }
        }

        private void linklb_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRegister fRegister = new FRegister();
            this.Hide();
            fRegister.ShowDialog();
            this.Show();
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

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_sdt.ForeColor = Color.White;
                lb_err_pass.Visible = false;
            }
            catch
            {

            }
        }

        private void tb_sdt_Click(object sender, EventArgs e)
        {
            tb_sdt.SelectAll();
        }

        private void tb_password_Click(object sender, EventArgs e)
        {
            tb_password.SelectAll();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void lb_err_sdt_Click(object sender, EventArgs e)
        {

        }
    }
}