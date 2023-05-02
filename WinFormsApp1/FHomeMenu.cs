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
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
namespace Coffee
{
    public partial class FHomeMenu : Form
    {
        public FHomeMenu()
        {
            InitializeComponent();
        }

        #region Attributes
        private List<Hanghoa> list = null;
        private List<Hanghoa> list_duocMua = new List<Hanghoa>();
        private List<Ban> listban = new List<Ban>();
        private List<Order> listorder = new List<Order>();
        private Nhanvien nhanvien = new Nhanvien();
        int thanhtien = 0;
        int voucherKM = 0;
        int giamgia_km = 0;
        int tienphai_tra = 0;

        private List<Hoadonbanhang> listHDBHALL = new List<Hoadonbanhang>();
        private List<Hoadonbanhang> listHDBHALL_online = new List<Hoadonbanhang>();
        private List<Hoadonbanhang> listHDBHALL_dattruoc = new List<Hoadonbanhang>();
        private List<Ban> bans = new List<Ban>();

        public List<Hanghoa> List { get => list; set => list = value; }
        public List<Hanghoa> List_duocMua { get => list_duocMua; set => list_duocMua = value; }
        public List<Ban> Listban { get => listban; set => listban = value; }
        public List<Order> Listorder { get => listorder; set => listorder = value; }
        public Nhanvien Nhanvien { get => nhanvien; set => nhanvien = value; }
        public List<Ban> Bans { get => bans; set => bans = value; }
        private List<Uudai> list_uudai = new List<Uudai>();
        #endregion

        private void loaduudai()
        {
            list_uudai.Clear();
            list_uudai = ChiTietBanHangDAO.Instance.getAllUudai();
            List<Uudai> list_uudaitemp = new List<Uudai>();
            foreach (Uudai uudai in list_uudai)
            {
                if (uudai.Trangthai.Equals("1"))
                {
                    list_uudaitemp.Add(uudai);
                }
            }
            comboBox_tenuudai.DataSource = list_uudaitemp;
            comboBox_tenuudai.DisplayMember = "tenuudai";
        }

        private void FHomeMenu_Load(object sender, EventArgs e)
        {
            loaduudai();
            panel_datHangCuaNhanVien.Visible = true;
            panel_datHangCuaNhanVien.Location = new Point(0, 74);
            panel_datHangCuaNhanVien.Width = 1602;
            panel_datHangCuaNhanVien.Height = 653;

            panel_checkDonHangOnline.Visible = false;
            panel_checkDonHangOnline.Location = new Point(0, 74);
            panel_checkDonHangOnline.Width = 1602;
            panel_checkDonHangOnline.Height = 653;

            panel_xulyBan.Visible = false;
            panel_xulyBan.Location = new Point(0, 74);
            panel_xulyBan.Width = 1602;
            panel_xulyBan.Height = 653;



            List = HangHoaBUS.Instance.getAllProducts();
            loadProduct1(List);
            loadBan();
        }

        private void loadListorder(List<Order> list_monan)
        {

            dgv_listmonan.Controls.Clear();
            dgv_listmonan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listmonan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_listmonan.DataSource = null;
            BindingList<Order> bindingList = new BindingList<Order>(list_monan);
            dgv_listmonan.DataSource = bindingList;


            int thanhtien = 0;
            foreach (Order order in list_monan)
            {
                thanhtien += order.Total;
            }

            tb_thanhtien.Text = thanhtien.ToString();
            int thanhtien__ = Int32.Parse(tb_thanhtien.Text.ToString());
            int thiengiamgia = Int32.Parse(tb_giamgia.Text.ToString());
            thanhtien = thanhtien - thiengiamgia;
            tb_phaitra.Text = thanhtien.ToString();



        }


        private void loadBan()
        {
            Listban = BanBUS.Instance.getAll();
            CB_ban.DataSource = Listban;
            CB_ban.DisplayMember = "tenban";
        }
        private void btn_allList_Click(object sender, EventArgs e)
        {
            pnl_listsanpham.Controls.Clear();
            loadProduct1(List);
        }

        private void btn_douong_Click(object sender, EventArgs e)
        {
            pnl_douong.Visible = true;
            pnl_monan.Visible = false;
        }

        private void btn_monan_Click(object sender, EventArgs e)
        {
            pnl_douong.Visible = false;
            pnl_monan.Visible = true;
        }

        private void btn_hoaqua_Click(object sender, EventArgs e)
        {
            pnl_listsanpham.Controls.Clear();
            List<Hanghoa> lists = new List<Hanghoa>();
            lists = List.Where(product => product.Ten_hanghoa.Contains("Hoa quả", StringComparison.OrdinalIgnoreCase)).ToList();
            loadProduct1(lists);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel panel = sender as System.Windows.Forms.Panel;
            panel.BackColor = Color.YellowGreen; // Set the background color to blue when the mouse enters the panel
        }
        private List<Order> DeleteHangHoa(String id, List<Order> lists)
        {
            var item = lists.SingleOrDefault(x => x.Id.Equals(id));
            if (item != null)
                lists.Remove(item);
            return lists;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel panel = sender as System.Windows.Forms.Panel;
            panel.BackColor = Color.LightYellow; // Set the background color to transparent when the mouse leaves the panel
        }

        void LoadListSP(List<Hanghoa> lisst)
        {

            dgv_listmonan.Controls.Clear();
            dgv_listmonan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listmonan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_listmonan.DataSource = null;
            BindingList<Hanghoa> bindingList = new BindingList<Hanghoa>(lisst);
            dgv_listmonan.DataSource = bindingList;
            setInfoBill();
        }

        private void setInfoBill()
        {
            tb_thanhtien.Text = thanhtien.ToString();
            tb_voucherkm.Text = voucherKM.ToString();
            tb_giamgia.Text = giamgia_km.ToString();
            int phaitra = thanhtien - voucherKM - giamgia_km;
            tb_phaitra.Text = phaitra.ToString();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel p = sender as System.Windows.Forms.Panel;
            // identify which button was clicked and perform necessary actions
            String ma = p.Name.ToString();

            foreach (Hanghoa o in List)
            {
                if (o.Ma_hanghoa.Equals(ma))
                {

                    Order order = new Order();
                    order.Id = o.Ma_hanghoa;
                    order.Price = o.Gia;
                    order.Name = o.Ten_hanghoa;
                    order.Count = 1;
                    order.Total = o.Gia;
                    if (!checkExit(Listorder, order))
                    {
                        Listorder.Add(order);
                    }

                    break;
                }
            }

            loadListorder(Listorder);
        }

        private Boolean checkExit(List<Order> listorder, Order order)
        {
            foreach (Order o in listorder)
            {
                if (o.Id.Equals(order.Id))
                {
                    o.Count++;
                    return true;
                }
            }
            return false;
        }

        private void btn_monchinh_Click(object sender, EventArgs e)
        {
            pnl_listsanpham.Controls.Clear();
            List<Hanghoa> lists = new List<Hanghoa>();
            lists = List.Where(product => product.Ten_hanghoa.Contains("ăn chính", StringComparison.OrdinalIgnoreCase)).ToList();
            loadProduct1(lists);
        }

        private void btn_tra_Click(object sender, EventArgs e)
        {
            pnl_listsanpham.Controls.Clear();
            List<Hanghoa> lists = new List<Hanghoa>();
            lists = List.Where(product => product.Ten_hanghoa.Contains("Trà", StringComparison.OrdinalIgnoreCase)).ToList();
            loadProduct1(lists);
        }

        private void btn_spdongchai_Click(object sender, EventArgs e)
        {
            pnl_listsanpham.Controls.Clear();
            List<Hanghoa> lists = new List<Hanghoa>();
            lists = List.Where(product => product.Ten_hanghoa.Contains("đóng chai", StringComparison.OrdinalIgnoreCase)).ToList();
            loadProduct1(lists);
        }

        private void btn_latte_Click(object sender, EventArgs e)
        {
            pnl_listsanpham.Controls.Clear();
            List<Hanghoa> lists = new List<Hanghoa>();
            lists = List.Where(product => product.Ten_hanghoa.Contains("Latte", StringComparison.OrdinalIgnoreCase)).ToList();
            loadProduct1(lists);
        }

        private void btn_soda_Click(object sender, EventArgs e)
        {
            pnl_listsanpham.Controls.Clear();
            List<Hanghoa> lists = new List<Hanghoa>();
            lists = List.Where(product => product.Ten_hanghoa.Contains("Soda", StringComparison.OrdinalIgnoreCase)).ToList();
            loadProduct1(lists);
        }

        private void btn_suachua_Click(object sender, EventArgs e)
        {
            pnl_listsanpham.Controls.Clear();
            List<Hanghoa> lists = new List<Hanghoa>();
            lists = List.Where(product => product.Ten_hanghoa.Contains("Sữa chua", StringComparison.OrdinalIgnoreCase)).ToList();
            loadProduct1(lists);
        }

        private void btn_coffee_Click(object sender, EventArgs e)
        {
            pnl_listsanpham.Controls.Clear();
            List<Hanghoa> lists = new List<Hanghoa>();
            lists = List.Where(product => product.Ten_hanghoa.Contains("Cà phê", StringComparison.OrdinalIgnoreCase)).ToList();
            loadProduct1(lists);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                String id = dgv_listmonan.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                Listorder = DeleteHangHoa(id, Listorder);

                // list_duocMua.RemoveAt(rowindex);
                loadListorder(Listorder);
            }
            catch
            {

            }

        }

        private void loadProduct1(List<Hanghoa> list)
        {

            int check = 0;
            int y = 3;
            int count = list.Count;
            int countcheck = 0;
            while (true)
            {

                if (countcheck == count)
                {
                    break;
                }

                System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel()
                {
                    Width = 202,
                    Height = 202
                };
                panel.BackColor = Color.LightYellow;
                //panel.Name = i2.ToString() + 1.ToString();
                panel.MouseEnter += new EventHandler(panel1_MouseEnter);
                panel.MouseLeave += new EventHandler(panel1_MouseLeave);
                panel.Click += new EventHandler(panel_Click);
                if (check == 0)
                {
                    panel.Location = new Point(9, y);
                    check++;
                }
                else if (check == 1)
                {
                    panel.Location = new Point(9 + 202 + 10, y);
                    check++;
                }
                else
                {
                    check = 0;
                    y = y + (202 + 10);
                    continue;
                }

                loadinforProduct(panel, list[countcheck]);
                countcheck++;
                pnl_listsanpham.Controls.Add(panel);
                panel.Parent = pnl_listsanpham;
            }





        }

        private void loadinforProduct(System.Windows.Forms.Panel mypanel, Hanghoa product)
        {
            mypanel.Name = product.Ma_hanghoa.ToString();
            System.Windows.Forms.Label priceProduct = new System.Windows.Forms.Label();
            System.Windows.Forms.Label NameProduct = new System.Windows.Forms.Label();
            PictureBox imageProduct = new PictureBox();

            priceProduct.Location = new Point(122, 3);
            priceProduct.BackColor = Color.Yellow;
            //priceProduct.Width = 77;
            //priceProduct.Height = 25;


            NameProduct.Location = new Point(30, 151);
            NameProduct.Width = 200;
            NameProduct.Height = 40;
            //NameProduct.AutoSize = true;

            imageProduct.Location = new Point(26, 47);
            imageProduct.Width = 149;
            imageProduct.Height = 101;


            priceProduct.Text = product.Gia.ToString() + "đ";
            NameProduct.Text = product.Ten_hanghoa.ToString();
            imageProduct.ImageLocation = product.Hinhanh.ToString();
            imageProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            HanlePicbox(imageProduct);

            mypanel.Controls.Add(priceProduct);
            mypanel.Controls.Add(NameProduct);
            mypanel.Controls.Add(imageProduct);

        }

        private void HanlePicbox(PictureBox pictureBox)
        {
            pictureBox.MouseEnter += new EventHandler(pictureBox_MouseEnter);
            pictureBox.MouseLeave += new EventHandler(pictureBox_MouseLeave);
            pictureBox.Click += new EventHandler(pictureBox_Click);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            System.Windows.Forms.Panel parentPanel = (System.Windows.Forms.Panel)pictureBox.Parent;

            String ma = parentPanel.Name.ToString();

            foreach (Hanghoa o in List)
            {
                if (o.Ma_hanghoa.Equals(ma))
                {
                    Order order = new Order();
                    order.Id = o.Ma_hanghoa;
                    order.Price = o.Gia;
                    order.Name = o.Ten_hanghoa;
                    order.Count = 1;
                    order.Total = o.Gia;
                    if (!checkExit(Listorder, order))
                    {
                        Listorder.Add(order);
                    }

                    break;
                }
            }

            loadListorder(Listorder);

        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            System.Windows.Forms.Panel parentPanel = (System.Windows.Forms.Panel)pictureBox.Parent;
            parentPanel.BackColor = Color.YellowGreen;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            System.Windows.Forms.Panel parentPanel = (System.Windows.Forms.Panel)pictureBox.Parent;
            parentPanel.BackColor = Color.LightYellow;
        }

        private void btn_anvat_Click(object sender, EventArgs e)
        {
            pnl_listsanpham.Controls.Clear();
            List<Hanghoa> lists = new List<Hanghoa>();
            lists = List.Where(product => product.Ten_hanghoa.Contains("ăn vặt", StringComparison.OrdinalIgnoreCase)).ToList();
            loadProduct1(lists);
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (cb_momo.Checked || cb_zalopay.Checked)
            {
                FPayOnline home = new FPayOnline();
                home.ShowDialog();
                HandleThanhToan();


                listorder.Clear();
                loadListorder(Listorder);
            }
            else if (cb_tienmat.Checked)
            {
                HandleThanhToan();

                listorder.Clear();
                loadListorder(Listorder);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!");
            }
            loadBan();
        }

        private void HandleThanhToan()
        {
            DateTime now = DateTime.Now;
            String mahoaDon = "HD_OFF" + now.ToString().Replace(" ", "");
            String sodienthoaiKH = "null";
            String tenBan = CB_ban.Text.ToString();
            int tien = Int32.Parse(tb_phaitra.Text.ToString());
            String trangthai = "OFF";
            if (!tb_sdtkhachhang.Text.ToString().Equals(""))
            {
                sodienthoaiKH = tb_sdtkhachhang.Text.ToString();
            }

            String maBan = "";
            foreach (Ban ban in listban)
            {
                if (ban.Tenban.Equals(tenBan))
                {
                    maBan = ban.Maban;
                    break;
                }
            }


            if (!checkBox_mangve.Checked)
            {
                BanBUS.Instance.changeStt(maBan, "0");
                HoaDonBUS.Instance.insertHD(mahoaDon, sodienthoaiKH, maBan, tien, trangthai);
            }
            else
            {
                HoaDonBUS.Instance.insertHD(mahoaDon, sodienthoaiKH, "OFF_MANGVE", tien, trangthai);
            }



            DateTime today = DateTime.Today;
            foreach (Order order in Listorder)
            {
                ChiTietBanHangBUS.Instance.insertchitietbanhang(mahoaDon, order.Id, order.Count, order.Total, sodienthoaiKH);
                if (!sodienthoaiKH.Equals(""))
                {
                    LichSuMuaHangBUS.Instance.insert(mahoaDon, order.Name, sodienthoaiKH, order.Count, order.Total, today.ToString());
                }

            }

            HoaDonReport report = new HoaDonReport();
            report.Tienkhachdua = Int32.Parse(textBox_tienkhachdua.Text.ToString());
            report.Hoadonbanhang = HoaDonBanHangDAO.Instance.getHD_theoten(mahoaDon);
            report.ShowDialog();
        }





        private void textBox_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String tienkhachdua = textBox_tienkhachdua.Text.ToString();
                int tienkhach = Int32.Parse(tienkhachdua);
                int tienphaitrar = int.Parse(tb_phaitra.Text.ToString());

                int tienthua = tienkhach - tienphaitrar;
                tb_tienthua.Text = tienthua.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void tb_giamgia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String thanhtien = tb_thanhtien.Text.ToString();
                int tienthanhtien = Int32.Parse(thanhtien);

                String giamgia = tb_giamgia.Text.ToString();
                int tiengiamgia = Int32.Parse(giamgia);

                tb_phaitra.Text = (tienthanhtien - tiengiamgia).ToString();

                int tienphaitrar = int.Parse(tb_phaitra.Text.ToString());


            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton_dathangNV_Click(object sender, EventArgs e)
        {
            panel_checkDonHangOnline.Visible = false;
            panel_datHangCuaNhanVien.Visible = true;
            panel_xulyBan.Visible = false;
        }

        private void iconButton_danhsachdonhangon_Click(object sender, EventArgs e)
        {
            panel_checkDonHangOnline.Visible = true;
            panel_datHangCuaNhanVien.Visible = false;
            panel_xulyBan.Visible = false;
            loadDanhSachHoaDonBanHangONLINE();
            loadDanhSachHoaDonBanHangDATTRUOC();
        }

        private void loadHdTheoBan(String maban)
        {
            List<infoDanhSachHoaDonTheoBan> list = BanBUS.Instance.getHD_BAN(maban);
            dataGridView_listMonAnTaiBan.Controls.Clear();
            dataGridView_listMonAnTaiBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_listMonAnTaiBan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_listMonAnTaiBan.DataSource = null;
            BindingList<infoDanhSachHoaDonTheoBan> bindingList = new BindingList<infoDanhSachHoaDonTheoBan>(list);
            dataGridView_listMonAnTaiBan.DataSource = bindingList;

        }

        private void iconButton_xuLyBan_Click(object sender, EventArgs e)
        {
            panel_checkDonHangOnline.Visible = false;
            panel_datHangCuaNhanVien.Visible = false;
            panel_xulyBan.Visible = true;

            panel_listban.Controls.Clear();
            bans = BanBUS.Instance.getAll1111();
            loadBan(bans);
            loadbanchuyenden();
            loadgopban();
        }

        private void loadgopban()
        {
            List<Ban> listbangop1 = new List<Ban>();
            listbangop1 = BanBUS.Instance.getAll0();
            comboBox_BanMuongop1.DataSource = listbangop1;
            comboBox_BanMuongop1.DisplayMember = "Tenban";

            List<Ban> listbangop2 = new List<Ban>();
            listbangop2 = BanBUS.Instance.getAll0();
            comboBox_Banmuongop2.DataSource = listbangop2;
            comboBox_Banmuongop2.DisplayMember = "Tenban";

            List<Ban> listbangop3 = new List<Ban>();
            listbangop3 = BanBUS.Instance.getAll0();
            comboBox_gopdenBan.DataSource = listbangop3;
            comboBox_gopdenBan.DisplayMember = "Tenban";
        }

        private void loadbanchuyenden()
        {
            List<Ban> listBanchuyenDen = new List<Ban>();
            listBanchuyenDen = BanBUS.Instance.getAll();
            comboBox_banmuonchuyenden.DataSource = listBanchuyenDen;
            comboBox_banmuonchuyenden.DisplayMember = "tenban";
        }

        private void loadBan(List<Ban> list)
        {
            int check = 0;
            int countcheck = 0;
            int countBan = list.Count;
            int y = 24;
            while (true)
            {
                if (countcheck == countBan)
                {
                    break;
                }

                System.Windows.Forms.Button button = new System.Windows.Forms.Button()
                {
                    Width = 138,
                    Height = 84
                };

                button.Click += new EventHandler(button_Click);
                if (check == 0)
                {
                    button.Location = new Point(9, y);
                    check++;
                }
                else if (check == 1)
                {
                    button.Location = new Point(163, y);
                    check++;
                }
                else if (check == 2)
                {
                    button.Location = new Point(315, y);
                    check++;
                }
                else
                {
                    y = y + 110;
                    check = 0;
                    continue;
                }

                insertInforTable(button, list[countcheck]);
                countcheck++;
                panel_listban.Controls.Add(button);
                button.Parent = panel_listban;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button p = sender as System.Windows.Forms.Button;

            textBox_banCanXuly.Text = p.Text.ToString();
            textBox_banCanXuly.Name = p.Name;
            loadHdTheoBan(p.Name.ToString());
        }

        public void insertInforTable(System.Windows.Forms.Button button, Ban ban)
        {
            if (ban.Thuoctinh.Equals("1"))
            {
                button.BackColor = System.Drawing.Color.CornflowerBlue;
                button.ForeColor = System.Drawing.Color.Black;
                //button.Enabled = true;
            }
            else
            {
                button.BackColor = System.Drawing.Color.IndianRed;
                button.ForeColor = System.Drawing.Color.Black;
                //button.Enabled = false;
            }
            button.Text = ban.Tenban.ToString();
            button.Name = ban.Maban.ToString();
        }

        private void loadDanhSachHoaDonBanHangONLINE()
        {

            listHDBHALL_online = HoaDonBUS.Instance.dhbh_stt("online");

            dataGridView_donHangCanGiao.Controls.Clear();
            dataGridView_donHangCanGiao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_donHangCanGiao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_donHangCanGiao.DataSource = null;
            BindingList<Hoadonbanhang> bindingList = new BindingList<Hoadonbanhang>(listHDBHALL_online);
            dataGridView_donHangCanGiao.DataSource = bindingList;
        }

        private void loadDanhSachHoaDonBanHangDATTRUOC()
        {
            listHDBHALL_dattruoc = HoaDonBUS.Instance.dhbh_stt("DATBAN");
            dataGridView_DonHangDatTruoc.Controls.Clear();
            dataGridView_DonHangDatTruoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DonHangDatTruoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_DonHangDatTruoc.DataSource = null;
            BindingList<Hoadonbanhang> bindingList = new BindingList<Hoadonbanhang>(listHDBHALL_dattruoc);
            dataGridView_DonHangDatTruoc.DataSource = bindingList;
        }

        private void iconButton_cangiao_huy_Click(object sender, EventArgs e)
        {
            try
            {
                String id = dataGridView_donHangCanGiao.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
                String sdt = dataGridView_donHangCanGiao.SelectedCells[0].OwningRow.Cells["Sdt_kh"].Value.ToString();
                HoaDonBUS.Instance.deleteHD(id, sdt);
                loadDanhSachHoaDonBanHangONLINE();
                MessageBox.Show("SUCCESS!");
            }
            catch (Exception ec)
            {

            }
        }

        private void iconButton_dattruoc_huy_Click(object sender, EventArgs e)
        {
            try
            {
                String id = dataGridView_DonHangDatTruoc.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
                String sdt = dataGridView_donHangCanGiao.SelectedCells[0].OwningRow.Cells["Sdt_kh"].Value.ToString();
                HoaDonBUS.Instance.deleteHD(id, sdt);
                loadDanhSachHoaDonBanHangDATTRUOC();
                MessageBox.Show("SUCCESS!");
            }
            catch (Exception ec)
            {

            }
        }

        private void iconButton_cangiao_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                String id = dataGridView_donHangCanGiao.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
                HoaDonBUS.Instance.updateHDBH("DONE", id);
                loadDanhSachHoaDonBanHangONLINE();
                MessageBox.Show("SUCCESS!");
            }
            catch (Exception ec)
            {

            }
        }

        private void iconButton_datruoc_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                String id = dataGridView_DonHangDatTruoc.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
                HoaDonBUS.Instance.updateHDBH("DONE", id);
                loadDanhSachHoaDonBanHangDATTRUOC();
                MessageBox.Show("SUCCESS!");
            }
            catch (Exception ec)
            {

            }
        }

        private void iconButton_cangiao_xemchitiet_Click(object sender, EventArgs e)
        {
            String id = dataGridView_donHangCanGiao.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
            List<Chitietbanhang> list = ChiTietBanHangBUS.Instance.getCTBH(id);
            FChiTietBanHang ff = new FChiTietBanHang();
            ff.List = list;
            ff.ShowDialog();
        }

        private void iconButton_dattruoc_xemchitiet_Click(object sender, EventArgs e)
        {
            String id = dataGridView_DonHangDatTruoc.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
            List<Chitietbanhang> list = ChiTietBanHangBUS.Instance.getCTBH(id);
            FChiTietBanHang ff = new FChiTietBanHang();
            ff.List = list;
            ff.ShowDialog();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_listMonAnTaiBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String id = dataGridView_listMonAnTaiBan.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
                List<Chitietbanhang> list = ChiTietBanHangBUS.Instance.getCTBH(id);
                FChiTietBanHang ff = new FChiTietBanHang();
                ff.List = list;
                ff.ShowDialog();
            }
            catch (Exception ec)
            {

            }
        }

        private void iconButton_chuyenBan_Click(object sender, EventArgs e)
        {
            try
            {
                String mahd = dataGridView_listMonAnTaiBan.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
                String maban1 = textBox_banCanXuly.Name.ToString();
                String temp = comboBox_banmuonchuyenden.Text.ToString();
                String maban2 = "";
                List<Ban> listb = BanBUS.Instance.getAll1111();
                foreach (Ban h in listb)
                {
                    if (temp.Equals(h.Tenban))
                    {
                        maban2 = h.Maban;
                        break;
                    }
                }
                BanBUS.Instance.chuyenban(maban1, maban2, mahd);
                MessageBox.Show("Success!");
                panel_listban.Controls.Clear();
                bans = BanBUS.Instance.getAll1111();
                loadBan(bans);
                loadbanchuyenden();
            }
            catch (Exception ec)
            {

            }
        }

        private String getMaBan(String tenban)
        {
            List<Ban> listb = BanBUS.Instance.getAll1111();
            foreach (Ban h in listb)
            {
                if (tenban.Equals(h.Tenban))
                {
                    return h.Maban;

                }
            }
            return "";
        }

        private void iconButton_gopban_Click(object sender, EventArgs e)
        {
            String ban1 = getMaBan(comboBox_BanMuongop1.Text.ToString());
            String ban2 = getMaBan(comboBox_Banmuongop2.Text.ToString());
            String bangop = getMaBan(comboBox_gopdenBan.Text.ToString());




            if (!bangop.Equals(ban1) & !bangop.Equals(ban2))
            {
                MessageBox.Show("error");
                return;
            }

            String mahd1 = BanBUS.Instance.getHD_BAN(ban1)[0].Ma_hd_bh;
            String mahd2 = BanBUS.Instance.getHD_BAN(ban2)[0].Ma_hd_bh;
            String mahdbangop = BanBUS.Instance.getHD_BAN(bangop)[0].Ma_hd_bh;

            if (ban1.Equals(bangop))
            {
                List<Chitietbanhang> listctbh = ChiTietBanHangBUS.Instance.getCTBH(mahd2);
                foreach (Chitietbanhang ctbh in listctbh)
                {
                    try
                    {
                        ChiTietBanHangBUS.Instance.insertchitietbanhang(mahdbangop, ctbh.Ma_hanghoa, ctbh.Soluong, ctbh.Thanhtien, ctbh.Sodienthoai);
                    }
                    catch (Exception ec)
                    {

                    }
                    BanBUS.Instance.changeStt(ban1, "1");
                    BanBUS.Instance.changeStt(ban2, "1");
                    BanBUS.Instance.changeStt(bangop, "0");
                    BanBUS.Instance.HandleGopBan(mahd2, mahdbangop, bangop);
                }



            }
            else if (ban2.Equals(bangop))
            {
                List<Chitietbanhang> listctbh = ChiTietBanHangBUS.Instance.getCTBH(mahd1);
                foreach (Chitietbanhang ctbh in listctbh)
                {
                    try
                    {
                        ChiTietBanHangBUS.Instance.insertchitietbanhang(mahdbangop, ctbh.Ma_hanghoa, ctbh.Soluong, ctbh.Thanhtien, ctbh.Sodienthoai);
                    }
                    catch (Exception ec)
                    {

                    }
                    BanBUS.Instance.changeStt(ban1, "1");
                    BanBUS.Instance.changeStt(ban2, "1");
                    BanBUS.Instance.changeStt(bangop, "0");
                    BanBUS.Instance.HandleGopBan(mahd1, mahdbangop, bangop);
                }

            }
            panel_listban.Controls.Clear();
            bans = BanBUS.Instance.getAll1111();
            loadBan(bans);
        }

        private void iconButton_capnhatBan_Click(object sender, EventArgs e)
        {
            try
            {
                String mahd = dataGridView_listMonAnTaiBan.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
                String maban1 = textBox_banCanXuly.Name.ToString();
                BanBUS.Instance.changeStt(maban1, "1");
                HoaDonBUS.Instance.updateHDBH("DONE", mahd);
                MessageBox.Show("Success!");
                panel_listban.Controls.Clear();
                bans = BanBUS.Instance.getAll1111();
                loadBan(bans);
            }
            catch (Exception ec)
            {

            }
        }

        private void comboBox_tenuudai_SelectedValueChanged(object sender, EventArgs e)
        {
            loadtienkm();
        }

        private void loadtienkm()
        {
            String tenuu = comboBox_tenuudai.Text.ToString();
            list_uudai = ChiTietBanHangDAO.Instance.getAllUudai();
            List<Uudai> list_uudaitemp = new List<Uudai>();
            foreach (Uudai uudai in list_uudai)
            {
                if (uudai.Trangthai.Equals("1"))
                {
                    list_uudaitemp.Add(uudai);
                }
            }

            foreach (Uudai uudai in list_uudaitemp)
            {
                if (uudai.Tenuudai.Equals(tenuu))
                {
                    tb_giamgia.Text = uudai.Tiengiamgia.ToString();
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel_datHangCuaNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel_listban_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_checkDonHangOnline_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

