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
    public partial class FDanhSachSanPhamSapHET : Form
    {
        public FDanhSachSanPhamSapHET()
        {
            InitializeComponent();
        }

        private List<Hanghoa> listHH = new List<Hanghoa>();

        public List<Hanghoa> ListHH { get => listHH; set => listHH = value; }

        private void FDanhSachSanPhamSapHET_Load(object sender, EventArgs e)
        {
            List<Hanghoa> ListHHH = new List<Hanghoa>();
            foreach (Hanghoa hh in listHH)
            {
                if(hh.Soluong <= 8)
                {
                    ListHHH.Add(hh);
                }
            }
            dataGridView_list.Controls.Clear();
            dataGridView_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_list.DataSource = null;
            BindingList<Hanghoa> bindingList = new BindingList<Hanghoa>(ListHHH);
            dataGridView_list.DataSource = bindingList;
        }

        private void iconButton_cangiao_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
