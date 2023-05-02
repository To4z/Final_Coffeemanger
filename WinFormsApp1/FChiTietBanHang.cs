using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Coffee
{
    public partial class FChiTietBanHang : Form
    {
        public FChiTietBanHang()
        {
            InitializeComponent();
        }

        List<Chitietbanhang> list = new List<Chitietbanhang>();
        private List<Hanghoa> listHH = null;

        public List<Chitietbanhang> List { get => list; set => list = value; }
        public List<Hanghoa> ListHH { get => listHH; set => listHH = value; }

        private void FChiTietBanHang_Load(object sender, EventArgs e)
        {

            load();

        }

        private void load()
        {
            label_maDH.Text = list[0].Ma_hd_bh.ToString();
            dataGridView_list.Controls.Clear();
            dataGridView_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_list.DataSource = null;
            BindingList<Chitietbanhang> bindingList = new BindingList<Chitietbanhang>(list);
            dataGridView_list.DataSource = bindingList;


            listHH = HangHoaBUS.Instance.getAllProducts();
            comboBox_danhsachmonan.DataSource = listHH;
            comboBox_danhsachmonan.DisplayMember = "ten_hanghoa";
        }

        private void iconButton_cangiao_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton_themMon_Click(object sender, EventArgs e)
        {
            String tenmonan = comboBox_danhsachmonan.Text.ToString();

            foreach(Hanghoa h in listHH)
            {
                if (tenmonan.Equals(h.Ten_hanghoa))
                {

                    DateTime today = DateTime.Today;
                    String ma_hd = dataGridView_list.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
                    String sdt = dataGridView_list.SelectedCells[0].OwningRow.Cells["Sodienthoai"].Value.ToString();
                    ChiTietBanHangBUS.Instance.insertchitietbanhang(ma_hd, h.Ma_hanghoa, 1, h.Gia, sdt);
                    if (!sdt.Equals(""))
                    {
                        LichSuMuaHangBUS.Instance.insert(ma_hd, h.Ma_hanghoa, sdt, 1, h.Gia, today.ToString());
                    }


                    load();
                    break;
                }
            }

        }

        private void comboBox_danhsachmonan_SelectedValueChanged(object sender, EventArgs e)
        {
            String tenmonan = comboBox_danhsachmonan.Text.ToString();
            foreach (Hanghoa h in listHH)
            {
                if (tenmonan.Equals(h.Ten_hanghoa))
                {

                    label_maloaihang.Text = h.Ma_hanghoa;


                    break;
                }
            }
            
        }
    }
}
