using BUS;
using Coffee;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;
namespace CoffeeOngBau
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban có chắc chắn muốn thoát chương trình không? ", "Warning", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (tbxAcc.Text == "" || tbxAcc.Text == "Enter  phone number")
            {
                lb_err_sdt.Visible = true;
                tbxAcc.Focus();
                return;
            }
            else if (tbxPass.Text == "" || tbxPass.Text == "")
            {
                lb_err_pass.Visible = true;
                tbxPass.Focus();
                return;
            }
            else
            {
                String sdt = tbxAcc.Text.ToString();
                String pass = tbxPass.Text.ToString();
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

        //bool checkLogin(string sdt, string pass)
        //{
        //   return StaffDAO.Instance.checkLogin(sdt.Trim(), pass);
        //}

        private void tbxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}