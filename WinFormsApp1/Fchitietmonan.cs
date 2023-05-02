using BUS;
using DAO;
using DTO;
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
    public partial class Fchitietmonan : Form
    {
        public Fchitietmonan()
        {
            InitializeComponent();
        }

        private String mahh;
        private List<Chitietbanhang> list = new List<Chitietbanhang>();

        public string Mahh { get => mahh; set => mahh = value; }

        private void Fchitietmonan_Load(object sender, EventArgs e)
        {
            label_maDH.Text = mahh;
            list = ChiTietBanHangDAO.Instance.getCHItiet(mahh);
            dataGridView_list.Controls.Clear();
            dataGridView_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_list.DataSource = null;
            BindingList<Chitietbanhang> bindingList = new BindingList<Chitietbanhang>(list);
            dataGridView_list.DataSource = bindingList;
        }
    }
}
