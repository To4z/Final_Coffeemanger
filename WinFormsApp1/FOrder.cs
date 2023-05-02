using DTO;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FOrder : Form
    {
        public FOrder()
        {
            InitializeComponent();
        }
        private Order order;
        private List<Order> orders;
        private Khachhang khachhang;

        public Order Order { get => order; set => order = value; }
        public List<Order> Orders { get => orders; set => orders = value; }
        public Khachhang Khachhang { get => khachhang; set => khachhang = value; }

        private void FOrder_Load(object sender, EventArgs e)
        {
            lb_gia.Text = order.Price.ToString();
            lb_ten.Text = order.Name.ToString();
            lb_thanhtien.Text = order.Price.ToString();
            numberic_soluong.Value = 1;

         }

        private void numberic_soluong_ValueChanged(object sender, EventArgs e)
        {
            int soluong = (int)numberic_soluong.Value;
            int gia = (int)order.Price;
            int total = soluong * gia;
            lb_thanhtien.Text = total.ToString();


            foreach(Order o in orders)
            {
                if (o.Id.Equals(order.Id.ToString()))
                {
                    o.Count = soluong;
                    o.Total = total;
                    return;
                }
            }


        }


        private void button_luu_Click(object sender, EventArgs e)
        {
            FUser fUser =   new FUser();
            fUser.Listorder = orders;
            fUser.CheckShow = true;
            fUser.Khachhang = khachhang;
            fUser.Show();
            this.Close();
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            foreach (Order o in orders)
            {
                if (o.Id.Equals(order.Id.ToString()))
                {
                    FUser fUser = new FUser();
                    orders.Remove(o);
                    fUser.Listorder = orders;
                    fUser.CheckShow = true;
                    fUser.Khachhang = khachhang;
                    fUser.Show();
                    this.Close();
                    return;
                }
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            FUser fUser = new FUser();
            fUser.Listorder = orders;
            fUser.CheckShow = true;
            fUser.Khachhang = khachhang;
            fUser.Show();
            this.Hide();
        }
    }
}
