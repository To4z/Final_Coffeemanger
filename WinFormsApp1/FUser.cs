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
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Coffee
{
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
            panel_sanpham.Parent = panel_batbantruoc;
            panel_order.Parent = panel_batbantruoc;
            panel_ban.Parent = panel_batbantruoc;
            panel_batbantruoc.Visible = false;
            
        }



        #region Attributes
        private List<Ban> bans = new List<Ban>();
        private List<Loaihanghoa> loaihanghoas = new List<Loaihanghoa>();
        private List<Hanghoa> list_duocMua = new List<Hanghoa>();
        private List<MonAn> list_monan = new List<MonAn>();
        private List<Order> listorder = new List<Order>();
        private List<LichSuMuaHang> listLichSuMuaHang = new List<LichSuMuaHang>();
        private Khachhang khachhang;
        public List<Order> Listorder { get => listorder; set => listorder = value; }
        public Khachhang Khachhang { get => khachhang; set => khachhang = value; }
        public bool CheckShow { get => checkShow; set => checkShow = value; }
        public List<LichSuMuaHang> ListLichSuMuaHang { get => listLichSuMuaHang; set => listLichSuMuaHang = value; }

        private Boolean checkShow = false;
        int tien = 0;
        #endregion

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

                Button button = new Button()
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

        public void insertInforTable(Button button, Ban ban)
        {
            if (ban.Thuoctinh.Equals("1"))
            {
                button.BackColor = System.Drawing.Color.CornflowerBlue;
                button.Enabled = true;
            }
            else
            {
                button.BackColor = System.Drawing.Color.IndianRed;
                button.Enabled = false;
            }
            button.Text = ban.Tenban.ToString();
            button.Name = ban.Maban.ToString();
        }

        private void LoadLichSuMuaHang()
        {
            listLichSuMuaHang = LichSuMuaHangBUS.Instance.getAll(Khachhang.Sdt);
            dataGridView_lichsumuahang.Controls.Clear();
            dataGridView_lichsumuahang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_lichsumuahang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_lichsumuahang.DataSource = null;
            BindingList<LichSuMuaHang> bindingList = new BindingList<LichSuMuaHang>(listLichSuMuaHang);
            dataGridView_lichsumuahang.DataSource = bindingList;
        }

        

        private void loadInfoUser()
        {
            textBox_info_diachi.Text = Khachhang.Diachi.ToString();
            textBox_info_matkhau.Text = Khachhang.Password.ToString();
            textBox_info_name.Text= khachhang.Ten_kh.ToString();
            textBox_info_sdt.Text = khachhang.Sdt.ToString();
            //label_diemtich.Text = khachhang.Diemtl.ToString();
            label_diemtich.Text = khachhang.Diemtl.ToString();
    

            label_solanmuahang.Text = listLichSuMuaHang.Count.ToString();


        }

        private void FUser_Load(object sender, EventArgs e)
        {
            




            panel_sanpham.Parent = panel_batbantruoc;
            panel_order.Parent = panel_batbantruoc;
            panel_ban.Parent = panel_batbantruoc;
            panel_batbantruoc.Visible = false;
            panel_batbantruoc.Location = new Point(280, 47);
            panel_batbantruoc.Width = 1694;
            panel_batbantruoc.Height = 824;

            panel_dathangonline.Visible = true;
            panel_dathangonline.Location = new Point(280, 47);
            panel_dathangonline.Width = 1694;
            panel_dathangonline.Height = 824;


            panel_taikhoan.Visible = false;
            panel_taikhoan.Location = new Point(280, 47);
            panel_taikhoan.Width = 1694;
            panel_taikhoan.Height = 721;

            textBox_online_sodienthoai.Text = khachhang.Sdt;
            textBox_online_hovaten.Text = Khachhang.Ten_kh;
           



            load();

            if(checkShow == true)
            {
                panel_batbantruoc.Visible = true;
                panel_dathangonline.Visible = false;
            }

            customTextbox();

            int tien = 0;
            foreach (Order  i in listorder)
            {
                tien += i.Total;
            }
            textBox_thanhtien.Text = tien.ToString();

            listorder.Clear();
            loadListorder(listorder);
            loadListorderonline(listorder);
            loadInfoHD();
        }

        private void load()
        {
            loadLoaiHang();
            loadListorder(listorder);

            list_duocMua = HangHoaBUS.Instance.getAllProducts();

            foreach (Hanghoa hanghoa in list_duocMua)
            {
                MonAn mon = new MonAn();
                mon.Ma_hanghoa = hanghoa.Ma_hanghoa;
                mon.Ten_hanghoa = hanghoa.Ten_hanghoa;
                mon.Thanhtien = hanghoa.Gia;
                mon.Maloaihang = hanghoa.Ma_loaihang;
                list_monan.Add(mon);
            }
            loadFullSanPham(list_monan);

            bans = BanBUS.Instance.getAll1();
            loadBan(bans);


            loadInfoHD();
            loadProduct1(list_duocMua);
        }

        private void loadInfoHD()
        {
            DateTime now = DateTime.Now;
            textBox_hoadon.Text = "HD" + now.ToString().Replace(" ", "");
            textBox_online_mahoadon.Text = "HD_on" + now.ToString().Replace(" ", "");
        }

        private void loadbill()
        {
            int thanhtien = 0;
            foreach (Order order in listorder)
            {
                thanhtien += order.Total;

            }
            textBox_thanhtien.Text = thanhtien.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button p = sender as Button;
            // identify which button was clicked and perform necessary actions
            textBox_ban.Text = p.Text.ToString();
            label_nameBan.Name = p.Name;
        }

        private void loadListorder(List<Order> list_monan)
        {

            dataGridView_order.Controls.Clear();
            dataGridView_order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_order.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_order.DataSource = null;
            BindingList<Order> bindingList = new BindingList<Order>(list_monan);
            dataGridView_order.DataSource = bindingList;


        }
        


            private void loadListorderonline(List<Order> list_monan)
        {

            dataGridView_onlineorder.Controls.Clear();
            dataGridView_onlineorder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_onlineorder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_onlineorder.DataSource = null;
            BindingList<Order> bindingList = new BindingList<Order>(list_monan);
            dataGridView_onlineorder.DataSource = bindingList;


        }


        private void loadFullSanPham(List<MonAn> list_monan)
        {
            dataGridView_listsanpham.Controls.Clear();
            dataGridView_listsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_listsanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_listsanpham.DataSource = null;
            BindingList<MonAn> bindingList = new BindingList<MonAn>(list_monan);
            dataGridView_listsanpham.DataSource = bindingList;
        }

        private void loadLoaiHang()
        {
            loaihanghoas = LoaiHangHoaBUS.Instance.getAll();
            comboBox_loaiHang.Items.Clear();
            comboBox_loaiHang.DataSource = loaihanghoas;
            comboBox_loaiHang.DisplayMember = "tenloaihang";
        }




        private void iconButton_DatBanTruoc_Click(object sender, EventArgs e)
        {
            panel_batbantruoc.Visible = true;
            panel_dathangonline.Visible = false;
            panel_taikhoan.Visible = false;
            label_main_name.Text = "ĐẶT BÀN TRƯỚC";
            listorder.Clear();
            loadListorder(listorder);
            loadListorderonline(listorder);
            loadInfoHD();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            if ((checkBox_online.Checked & checkBox_taiquay.Checked) || (!checkBox_online.Checked & !checkBox_taiquay.Checked))
            {
                MessageBox.Show("Error! try again!");
                return;
            }


            if (checkBox_taiquay.Checked)
            {

                try
                {
                        String mahoadon = textBox_hoadon.Text.ToString();
                    String maban = label_nameBan.Name.ToString();
                    int tien = Int32.Parse(textBox_thanhtien.Text.ToString());
                    int tienkm = Int32.Parse(textBox_tienkm.Text.ToString());
                    String sdtkh = khachhang.Sdt;

                    HoaDonBUS.Instance.insertHD(mahoadon, sdtkh, maban, tien, "DATBAN");
                    BanBUS.Instance.changeStt(maban, "0");
                    foreach (Order order in Listorder)
                    {
                        ChiTietBanHangBUS.Instance.insertchitietbanhang(mahoadon, order.Id, order.Count, order.Total, khachhang.Sdt);
                        LichSuMuaHangBUS.Instance.insert(mahoadon, order.Name, khachhang.Sdt, order.Count, order.Total, today.ToString());
                    }

                    HoaDonReport report = new HoaDonReport();
                    report.Tienkhachdua = -1;
                    report.Hoadonbanhang = HoaDonBanHangDAO.Instance.getHD_theoten(mahoadon);
                    report.ShowDialog();

                    Listorder.Clear();

                    loadListorder(listorder);
                    panel_listban.Controls.Clear();
                    bans = BanBUS.Instance.getAll1();
                    loadBan(bans);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error!");
                    return;
                }




            }
            else if (checkBox_online.Checked)
            {

                try
                {
                    String mahoadon = textBox_hoadon.Text.ToString();
                    String maban = label_nameBan.Name.ToString();
                    int tien = Int32.Parse(textBox_thanhtien.Text.ToString());
                    int tienkm = Int32.Parse(textBox_tienkm.Text.ToString());
                    if(khachhang.Sdt == null)
                    {
                        MessageBox.Show("fill full information!");
                        return;
                    }
                    String sdtkh = khachhang.Sdt;

                    FPayOnline home = new FPayOnline();
                    home.ShowDialog();
                    HoaDonBUS.Instance.insertHD(mahoadon, sdtkh, maban, tien, "DATBAN");
                    BanBUS.Instance.changeStt(maban, "0");
                    foreach (Order order in Listorder)
                    {
                        ChiTietBanHangBUS.Instance.insertchitietbanhang(mahoadon, order.Id, order.Count, order.Total,khachhang.Sdt);
                        LichSuMuaHangBUS.Instance.insert(mahoadon, order.Name, khachhang.Sdt, order.Count, order.Total, today.ToString());
                    }
                    //this.Show();
                    HoaDonReport report = new HoaDonReport();
                    report.Tienkhachdua = -1;
                    report.Hoadonbanhang = HoaDonBanHangDAO.Instance.getHD_theoten(mahoadon);
                    report.ShowDialog();
                    Listorder.Clear();
                    loadListorder(listorder);
                    panel_listban.Controls.Clear();
                    bans = BanBUS.Instance.getAll1();
                    loadBan(bans);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error!");
                    return;
                }

            }
            bans = BanBUS.Instance.getAll1();
            loadBan(bans);
        }

        private void button_tim_Click_1(object sender, EventArgs e)
        {
            List<MonAn> lists = new List<MonAn>();
            String text = textBox_tim.Text.ToString();
            foreach (MonAn an in list_monan)
            {
                if (an.Ten_hanghoa.Contains(text, StringComparison.OrdinalIgnoreCase))
                {
                    lists.Add(an);
                }
            }
            loadFullSanPham(lists);
        }

        private void dataGridView_listsanpham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String id = dataGridView_listsanpham.SelectedCells[0].OwningRow.Cells["Ma_hanghoa"].Value.ToString();
                String ten = dataGridView_listsanpham.SelectedCells[0].OwningRow.Cells["Ten_hanghoa"].Value.ToString();
                String tien = dataGridView_listsanpham.SelectedCells[0].OwningRow.Cells["Thanhtien"].Value.ToString();

                Order order = new Order();
                order.Name = ten;
                order.Price = Int32.Parse(tien);
                order.Id = id;
                order.Count = 1;
                order.Total = Int32.Parse(tien);

                Listorder.Add(order);
                loadListorder(Listorder);
                loadbill();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView_order_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String id = dataGridView_order.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                String ten = dataGridView_order.SelectedCells[0].OwningRow.Cells["Name"].Value.ToString();
                String tien = dataGridView_order.SelectedCells[0].OwningRow.Cells["Price"].Value.ToString();
                String soluong = dataGridView_order.SelectedCells[0].OwningRow.Cells["Count"].Value.ToString();
                String tong = dataGridView_order.SelectedCells[0].OwningRow.Cells["Total"].Value.ToString();

                Order order = new Order();
                order.Name = ten;
                order.Price = Int32.Parse(tien);
                order.Id = id;
                order.Count = Int32.Parse(soluong);
                order.Total = Int32.Parse(tong);

                FOrder fOrder = new FOrder();
                fOrder.Khachhang = Khachhang;
                fOrder.Order = order;
                fOrder.Orders = Listorder;
                fOrder.ShowDialog();
                this.Hide();
            }
            catch(Exception ex)
            {

            }
        }

        private void button_tang1_Click_1(object sender, EventArgs e)
        {
            tentang.Text = "Tầng 1";
            panel_listban.Controls.Clear();
            bans = BanBUS.Instance.getAll1();
            loadBan(bans);
        }

        private void button_tang2_Click_1(object sender, EventArgs e)
        {
            tentang.Text = "Tầng 2";
            panel_listban.Controls.Clear();
            bans = BanBUS.Instance.getAll2();
            loadBan(bans);
        }

        private void button_tang3_Click_1(object sender, EventArgs e)
        {
            tentang.Text = "Tầng 3";
            panel_listban.Controls.Clear();
            bans = BanBUS.Instance.getAll3();
            loadBan(bans);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

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

                Panel panel = new Panel()
                {
                    Width = 202,
                    Height = 202
                };
                panel.BackColor = System.Drawing.Color.LightYellow;
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
                panel_onlinelistsp.Controls.Add(panel);
                panel.Parent = panel_onlinelistsp;
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            // identify which button was clicked and perform necessary actions
            String ma = p.Name.ToString();

            foreach (Hanghoa o in list_duocMua)
            {
                if (o.Ma_hanghoa.Equals(ma))
                {

                    Order order = new Order();
                    order.Id = o.Ma_hanghoa;
                    order.Price = o.Gia;
                    order.Name = o.Ten_hanghoa;
                    order.Count = 1;
                    order.Total = o.Gia;
                    if (!checkExit(listorder, order))
                    {
                        listorder.Add(order);
                    }
                    tien += order.Total;
                    break;
                }
            }

            loadListorderonline(listorder);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = System.Drawing.Color.LightYellow; // Set the background color to transparent when the mouse leaves the panel
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = System.Drawing.Color.YellowGreen; // Set the background color to blue when the mouse enters the panel
        }
        private void loadinforProduct(Panel mypanel, Hanghoa product)
        {
            mypanel.Name = product.Ma_hanghoa.ToString();
            Label priceProduct = new Label();
            Label NameProduct = new Label();
            PictureBox imageProduct = new PictureBox();

            priceProduct.Location = new Point(122, 3);
            priceProduct.BackColor = System.Drawing.Color.Yellow;
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

        private Boolean checkExit(List<Order> listorder, Order order)
        {
            foreach (Order o in listorder)
            {
                if (o.Id.Equals(order.Id))
                {
                    o.Count++;
                    o.Total = o.Price * o.Count;
                    return true;
                }
            }
            return false;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Panel parentPanel = (Panel)pictureBox.Parent;

            String ma = parentPanel.Name.ToString();

            foreach (Hanghoa o in list_duocMua)
            {
                if (o.Ma_hanghoa.Equals(ma))
                {
                    Order order = new Order();
                    order.Id = o.Ma_hanghoa;
                    order.Price = o.Gia;
                    order.Name = o.Ten_hanghoa;
                    order.Count = 1;
                    order.Total = o.Gia;
                    if (!checkExit(listorder, order))
                    {
                        listorder.Add(order);
                    }
                    tien += order.Total;
                    textBox_online_thanhtien.Text = tien.ToString();
                    break;
                }
            }

            loadListorderonline(listorder);

        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Panel parentPanel = (Panel)pictureBox.Parent;
            parentPanel.BackColor = System.Drawing.Color.YellowGreen;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Panel parentPanel = (Panel)pictureBox.Parent;
            parentPanel.BackColor = System.Drawing.Color.LightYellow;
        }

        private void iconButton_DatHangOnline_Click(object sender, EventArgs e)
        {
            panel_batbantruoc.Visible = false;
            panel_dathangonline.Visible = true;
            panel_taikhoan.Visible = false;
            label_main_name.Text = "ĐẶT HÀNG ONLINE";
            DateTime today = DateTime.Today;
            textBox_ngayNhanHang.Text = today.ToString("dd/MM/yyyy");
            textBox_online_gionhanhang.Text = DateTime.Now.ToString("HH:mm"); ;
            listorder.Clear();
            loadListorder(listorder);
            loadListorderonline(listorder);
            loadInfoHD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((checkBox_thanhtoanonline.Checked & checkBox_thanhtoankhinhanhang.Checked) || (!checkBox_thanhtoankhinhanhang.Checked & !checkBox_thanhtoanonline.Checked))
            {
                MessageBox.Show("Error! try again!");
                return;
            }

            DateTime today = DateTime.Today;
            if (checkBox_thanhtoankhinhanhang.Checked)
            {
                
                try
                {
                    String mahoadon = textBox_online_mahoadon.Text.ToString();
                    int tien = 0;
                    foreach(Order order in Listorder)
                    {
                        tien += order.Total;
                    }
                    String sdtkh = khachhang.Sdt;

                    String ten = textBox_online_hovaten.Text.ToString();
                    String sdt = textBox_online_sodienthoai.Text.ToString();
                    String diachi = textBox_online_diachi.Text.ToString();
                    String ngaygiao = textBox_ngayNhanHang.Text.ToString();
                    String giogiao = textBox_online_gionhanhang.Text.ToString();

                    HoaDonBUS.Instance.insertHD(mahoadon, sdtkh, "online", tien, "online");
                    
                    foreach (Order order in Listorder)
                    {
                        ChiTietBanHangBUS.Instance.insertchitietbanhang_online(mahoadon, order.Id, order.Count, order.Total, "online", ngaygiao ,giogiao, diachi, sdtkh);
                        LichSuMuaHangBUS.Instance.insert(mahoadon, order.Name, khachhang.Sdt, order.Count, order.Total, today.ToString());
                    }


                    HoaDonReport report = new HoaDonReport();
                    report.Tienkhachdua = -1;
                    report.Hoadonbanhang = HoaDonBanHangDAO.Instance.getHD_theoten(mahoadon);
                    report.ShowDialog();

                    listorder.Clear();
                    loadListorderonline(listorder);
                    textBox_online_thanhtien.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error!");
                    return;
                }




            }
            else if (checkBox_thanhtoanonline.Checked)
            {

                try
                {
                    String mahoadon = textBox_online_mahoadon.Text.ToString();
                    int tien = 0;
                    foreach (Order order in Listorder)
                    {
                        tien += order.Total;
                    }
                    String sdtkh = khachhang.Sdt;

                    String ten = textBox_online_hovaten.Text.ToString();
                    String sdt = textBox_online_sodienthoai.Text.ToString();
                    String diachi = textBox_online_diachi.Text.ToString();
                    String ngaygiao = textBox_ngayNhanHang.Text.ToString();
                    String giogiao = textBox_online_gionhanhang.Text.ToString();

                    HoaDonBUS.Instance.insertHD(mahoadon, sdtkh, "online", tien, "online");
                    //BanBUS.Instance.changeStt(maban, "0");
                    foreach (Order order in Listorder)
                    {
                        ChiTietBanHangBUS.Instance.insertchitietbanhang_online(mahoadon, order.Id, order.Count, order.Total, "online", ngaygiao, giogiao, diachi, sdtkh);
                        LichSuMuaHangBUS.Instance.insert(mahoadon, order.Name, khachhang.Sdt, order.Count, order.Total, today.ToString());
                    }

                    FPayOnline home = new FPayOnline();
                    home.ShowDialog();

                    HoaDonReport report = new HoaDonReport();
                    report.Tienkhachdua = -1;
                    report.Hoadonbanhang = HoaDonBanHangDAO.Instance.getHD_theoten(mahoadon);
                    report.ShowDialog();

                    listorder.Clear();
                    loadListorderonline(listorder);
                    textBox_online_thanhtien.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error!");
                    return;
                }
                

            }
            loadInfoHD();
            tien = 0;
        }

        private void dataGridView_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton_ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            panel_batbantruoc.Visible = false;
            panel_dathangonline.Visible = false;
            panel_taikhoan.Visible = true;
            label_main_name.Text = "TÀI KHOẢN";
            LoadLichSuMuaHang();
            loadListorder(listorder);
            loadListorderonline(listorder);
            loadInfoUser();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox_info_name.Text.ToString();
                String sdt = textBox_info_sdt.Text.ToString();
                String diachi = textBox_info_diachi.Text.ToString();
                String pass = textBox_info_matkhau.Text.ToString();
                KhachHangBUS.Instance.updateKH(name, sdt, diachi, pass);
                MessageBox.Show("Success!");
            }
            catch
            {

            }
        }


        private void customTextbox()
        {
            textBox_info_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_info_diachi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_info_sdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox_info_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            var label1 = new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = System.Drawing.Color.Purple
            };
            var label2 = new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = System.Drawing.Color.Purple
            };
            var label3 = new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = System.Drawing.Color.Purple
            };
            var label4 = new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = System.Drawing.Color.Purple
            };
            textBox_info_name.Controls.Add(label1);
            textBox_info_diachi.Controls.Add(label2);
            textBox_info_sdt.Controls.Add(label3);
            textBox_info_matkhau.Controls.Add(label4);
        }

        private List<Order> DeleteHangHoa(String id, List<Order> lists)
        {
            var item = lists.SingleOrDefault(x => x.Id.Equals(id));
            if (item != null)
            {
                lists.Remove(item);
                //int tien = Int32.Parse(textBox_online_thanhtien.Text.ToString());
                tien -= item.Total;
                textBox_online_thanhtien.Text = tien.ToString();
            }
                
            
            return lists;
        }

        private void iconButton_delete_Click(object sender, EventArgs e)
        {
            try
            {
                String id = dataGridView_onlineorder.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                listorder = DeleteHangHoa(id, listorder);

                // list_duocMua.RemoveAt(rowindex);
                loadListorderonline(listorder);
            }
            catch
            {

            }
        }
    }
}
