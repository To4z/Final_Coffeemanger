using BUS;
using DTO;
using DAO;
using System.ComponentModel;
using System.Globalization;

namespace Coffee
{
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private List<Hanghoa> list_hanghoa = new List<Hanghoa>();
        private List<Loaihanghoa> list_loaihanghoa = new List<Loaihanghoa>();
        private List<Nhacungcap> list_ncc = new List<Nhacungcap>();
        private List<Khachhang> list_khachhang = new List<Khachhang>(); 
        private List<Nhanvien> list_Nhanvien= new List<Nhanvien>();
        private List<Calamviec> list_Calamviec = new List<Calamviec>();
        private List<Nhacungcap> list_Nhacungcap = new List<Nhacungcap>();
        private List<Ban> list_ban= new List<Ban>();
        private List<KhuVuc> list_khuvuc = new List<KhuVuc>();

        public List<Hanghoa> List_hanghoa { get => list_hanghoa; set => list_hanghoa = value; }
        public List<Loaihanghoa> List_loaihanghoa { get => list_loaihanghoa; set => list_loaihanghoa = value; }
        public List<Nhacungcap> List_ncc { get => list_ncc; set => list_ncc = value; }
        public List<Khachhang> List_khachhang { get => list_khachhang; set => list_khachhang = value; }
        public List<Nhanvien> List_Nhanvien { get => list_Nhanvien; set => list_Nhanvien = value; }
        public List<Calamviec> List_Calamviec { get => list_Calamviec; set => list_Calamviec = value; }
        public List<Nhacungcap> List_Nhacungcap { get => list_Nhacungcap; set => list_Nhacungcap = value; }
        public List<Ban> List_ban { get => list_ban; set => list_ban = value; }
        public List<KhuVuc> List_khuvuc { get => list_khuvuc; set => list_khuvuc = value; }
        public List<Uudai> List_uudai1 { get => List_uudai; set => List_uudai = value; }
        public List<Hoadonbanhang> List_Hoadon { get => list_Hoadon; set => list_Hoadon = value; }

        private List<Uudai> List_uudai = new List<Uudai>();
        private List<Hoadonbanhang> list_Hoadon = new List<Hoadonbanhang>();
        private void FAdmin_Load(object sender, EventArgs e)
        {
            
            panel_quanlybanhang.Visible = true;
            panel_quanlybanhang.Parent = panel_body;
            panel_quanlybanhang.Location = new Point(3, 2);
            panel_quanlybanhang.Height = 699;
            panel_quanlybanhang.Width = 1197;

            panel_quanlykhachhang.Visible = false;
            panel_quanlykhachhang.Parent = panel_body;
            panel_quanlykhachhang.Location = new Point(3, 2);
            panel_quanlykhachhang.Height = 699;
            panel_quanlykhachhang.Width = 1197;

            panel_quanlynhanvien.Visible = false;
            panel_quanlynhanvien.Parent = panel_body;
            panel_quanlynhanvien.Location = new Point(3, 2);
            panel_quanlynhanvien.Height = 699;
            panel_quanlynhanvien.Width = 1197;

            
            panel_quanlycalam.Visible = false;
            panel_quanlycalam.Parent = panel_body;
            panel_quanlycalam.Location = new Point(3, 2);
            panel_quanlycalam.Height = 699;
            panel_quanlycalam.Width = 1197;

            panel_qlnhacungcap.Visible = false;
            panel_qlnhacungcap.Parent = panel_body;
            panel_qlnhacungcap.Location = new Point(3, 2);
            panel_qlnhacungcap.Height = 699;
            panel_quanlycalam.Width = 1197;

            panel_quanlyban.Visible = false;
            panel_quanlyban.Parent = panel_body;
            panel_quanlyban.Location = new Point(3, 2);
            panel_quanlyban.Height = 699;
            panel_quanlyban.Width = 1197;

            panel_uudai.Visible = false;
            panel_uudai.Parent = panel_body;
            panel_uudai.Location = new Point(3, 2);
            panel_uudai.Height = 699;
            panel_uudai.Width = 1197;

            panel_thongke.Visible = false;
            panel_thongke.Parent = panel_body;
            panel_thongke.Location = new Point(3, 2);
            panel_thongke.Height = 699;
            panel_thongke.Width = 1197; 


            form_load();
            form_load_qlhh();

            
        }

        private void form_load()
        {
            List_hanghoa = HangHoaBUS.Instance.getFULL();
            List_loaihanghoa = LoaiHangHoaBUS.Instance.getAll();
            List_ncc = NhaccBUS.Instance.getallncc();
            list_khachhang = KhachHangBUS.Instance.getAllKH();
            list_Nhanvien = NhanVienBUS.Instance.getAllNHANVien();
            List_Calamviec = CalamviecBUS.Instance.getall();
            List_Nhacungcap = NhaccBUS.Instance.getallncc();
            List_khuvuc = BanDAO.Instance.getAllKhuVuc();
            List_ban = BanDAO.Instance.getAllBan();
            List_uudai = ChiTietBanHangDAO.Instance.getAllUudai();
            List_Hoadon = HoaDonBanHangDAO.Instance.getall();
        }

        private List<Hoadonbanhang> handele_baocao(String type)
        {

            DateTime tn = this.dateTimePicker_tungay.Value.Date;

            int day_tn = tn.Day;
            int month_tn = tn.Month;
            int year_tn = tn.Year;


            DateTime dn = this.dateTimePicker_denngay.Value.Date;
            int day_dn = tn.Day;
            int month_dn = tn.Month;
            int year_dn = tn.Year;

            List<Hoadonbanhang> list_hdbh = new List<Hoadonbanhang>();
            int tongtien = 0;
            if (type.Equals("Ngày"))
            {
                foreach(Hoadonbanhang hd in list_Hoadon)
                {
                    int result = DateTime.Compare(hd.Ngay_hd_bh, tn);
                    if (result == 0)
                    {
                        list_hdbh.Add(hd);
                        tongtien += hd.Tongtien;

                    }
                }
                
            }

            if (type.Equals("Tháng"))
            {
                foreach (Hoadonbanhang hd in list_Hoadon)
                {
                    int nam = hd.Ngay_hd_bh.Year;
                    int thang = hd.Ngay_hd_bh.Month;
                    if (nam == year_tn && thang == month_tn)
                    {
                        list_hdbh.Add(hd);
                        tongtien += hd.Tongtien;

                    }
                }
            }

            if (type.Equals("Năm"))
            {
                foreach (Hoadonbanhang hd in list_Hoadon)
                {
                    int nam = hd.Ngay_hd_bh.Year;
                    if (nam == year_tn)
                    {
                        list_hdbh.Add(hd);
                        tongtien += hd.Tongtien;

                    }
                }
            }

            if (type.Equals("Tùy Chỉnh"))
            {
                foreach (Hoadonbanhang hd in list_Hoadon)
                {
                    int result = DateTime.Compare(hd.Ngay_hd_bh, tn);
                    int result1 = DateTime.Compare(hd.Ngay_hd_bh, dn);
                    if (result > 0 && result1 < 0)
                    {
                        list_hdbh.Add(hd);
                        tongtien += hd.Tongtien;

                    }
                }
            }
            label_tongtien.Text = tongtien.ToString();
            return list_hdbh;
        }

        private void form_load_baocao()
        {
            form_load();
            String type = comboBox_kybaocao.Text.ToString();
            List<Hoadonbanhang> list =  handele_baocao(type);
            dataGridView_listbaoca.Controls.Clear();
            dataGridView_listbaoca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_listbaoca.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_listbaoca.DataSource = null;
            BindingList<Hoadonbanhang> bindingList = new BindingList<Hoadonbanhang>(list);
            dataGridView_listbaoca.DataSource = bindingList;
        }

        private void form_load_uudai()
        {
            form_load();
            dataGridView_danhsachuudai.Controls.Clear();
            dataGridView_danhsachuudai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_danhsachuudai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_danhsachuudai.DataSource = null;
            BindingList<Uudai> bindingList = new BindingList<Uudai>(List_uudai);
            dataGridView_danhsachuudai.DataSource = bindingList;
        }

        private void form_load_ban()
        {
            form_load();
            dataGridView3.Controls.Clear();
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView3.DataSource = null;
            BindingList<Ban> bindingList = new BindingList<Ban>(List_ban);
            dataGridView3.DataSource = bindingList;

            comboBox1.DataSource = List_khuvuc;
            comboBox1.DisplayMember = "tenkhuvuc";

        }

        private void Form_load_nhacungcap()
        {
            form_load();
            dataGridView_qlncc_list.Controls.Clear();
            dataGridView_qlncc_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_qlncc_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_qlncc_list.DataSource = null;
            BindingList<Nhacungcap> bindingList = new BindingList<Nhacungcap>(List_Nhacungcap);
            dataGridView_qlncc_list.DataSource = bindingList;

            

        }

        private void form_load_calamviec()
        {
            form_load();
            dataGridView_qlcl_listcalam.Controls.Clear();
            dataGridView_qlcl_listcalam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_qlcl_listcalam.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_qlcl_listcalam.DataSource = null;
            BindingList<Calamviec> bindingList = new BindingList<Calamviec>(List_Calamviec);
            dataGridView_qlcl_listcalam.DataSource = bindingList;
        }

        private void form_load_NhanVien()
        {
            form_load();
            dataGridView_qlnv_listnv.Controls.Clear();
            dataGridView_qlnv_listnv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_qlnv_listnv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_qlnv_listnv.DataSource = null;
            BindingList<Nhanvien> bindingList = new BindingList<Nhanvien>(list_Nhanvien);
            dataGridView_qlnv_listnv.DataSource = bindingList;

            comboBox__qlnv_calam.DataSource = List_Calamviec;
            comboBox__qlnv_calam.DisplayMember = "ma_clv";
        }

        private void form_load_khachhang()
        {
            form_load();
            dataGridView_qlkh_listkhachhang.Controls.Clear();
            dataGridView_qlkh_listkhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_qlkh_listkhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_qlkh_listkhachhang.DataSource = null;
            BindingList<Khachhang> bindingList = new BindingList<Khachhang>(list_khachhang);
            dataGridView_qlkh_listkhachhang.DataSource = bindingList;
        }

        private void form_load_qlhh()
        {
            form_load();
            dataGridView_qlhh_danhsachsanpham.Controls.Clear();
            dataGridView_qlhh_danhsachsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_qlhh_danhsachsanpham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_qlhh_danhsachsanpham.DataSource = null;
            BindingList<Hanghoa> bindingList = new BindingList<Hanghoa>(List_hanghoa);
            dataGridView_qlhh_danhsachsanpham.DataSource = bindingList;

            comboBox_qlhh_loaisanpham.DataSource = List_loaihanghoa;
            comboBox_qlhh_loaisanpham.DisplayMember = "tenloaihang";

            comboBox_qlhh_sdtncc.DataSource = List_ncc;
            comboBox_qlhh_sdtncc.DisplayMember = "sdt";


        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton_quanlyhanghoa_Click(object sender, EventArgs e)
        {
            form_load_qlhh();
            panel_quanlybanhang.Visible = true;
            panel_quanlykhachhang.Visible = false;
            panel_quanlynhanvien.Visible = false;
            panel_quanlycalam.Visible = false;
            panel_qlnhacungcap.Visible = false;
            panel_quanlyban.Visible = false;
            panel_thongke.Visible = false;
            panel_uudai.Visible = false;
            label_main_name.Text = "QUẢN LÝ BÁN HÀNG";
        }

        private void iconButton_khachhang_Click(object sender, EventArgs e)
        {
            panel_quanlybanhang.Visible = false;
            panel_quanlykhachhang.Visible = true;
            panel_quanlynhanvien.Visible = false;
            panel_quanlycalam.Visible = false;
            panel_qlnhacungcap.Visible = false;
            panel_thongke.Visible = false;
            panel_quanlyban.Visible = false;
            panel_uudai.Visible = false;
            label_main_name.Text = "QUẢN LÝ KHÁCH HÀNG";
            form_load_khachhang();
        }

        private void iconButton_nhanvien_Click(object sender, EventArgs e)
        {
            panel_quanlybanhang.Visible = false;
            panel_quanlykhachhang.Visible = false;
            panel_quanlynhanvien.Visible = true;
            panel_uudai.Visible = false;
            panel_thongke.Visible = false;
            panel_quanlycalam.Visible = false;
            panel_qlnhacungcap.Visible = false;
            panel_quanlyban.Visible = false;
            label_main_name.Text = "QUẢN LÝ NHÂN VIÊN";
            form_load_NhanVien();
        }

        private void iconButton_calam_Click(object sender, EventArgs e)
        {
            panel_quanlybanhang.Visible = false;
            panel_quanlykhachhang.Visible = false;
            panel_quanlynhanvien.Visible = false;
            panel_uudai.Visible = false;
            panel_thongke.Visible = false;
            panel_quanlycalam.Visible = true;
            panel_qlnhacungcap.Visible = false;
            panel_quanlyban.Visible = false;
            label_main_name.Text = "QUẢN LÝ CA LÀM";
            form_load_calamviec();
        }

        private void iconButton_ncc_Click(object sender, EventArgs e)
        {
            panel_quanlybanhang.Visible = false;
            panel_quanlykhachhang.Visible = false;
            panel_uudai.Visible = false;
            panel_quanlynhanvien.Visible = false;
                panel_thongke.Visible = false; 
            panel_quanlycalam.Visible = false;
            panel_qlnhacungcap.Visible = true;
            panel_quanlyban.Visible = false;
            label_main_name.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            Form_load_nhacungcap();
        }

        private void iconButton_thongkebaocao_Click(object sender, EventArgs e)
        {
            panel_quanlybanhang.Visible = false;
            panel_quanlykhachhang.Visible = false;
            panel_quanlynhanvien.Visible = false;
            panel_uudai.Visible = false;
            panel_quanlycalam.Visible = false;
            panel_qlnhacungcap.Visible = false;
            panel_quanlyban.Visible = false;
            panel_thongke.Visible = true;
            label_main_name.Text = "THỐNG KÊ VÀ BÁO CÁO";
            
        }

        private void iconButton_ban_Click(object sender, EventArgs e)
        {
            panel_quanlybanhang.Visible = false;
            panel_quanlykhachhang.Visible = false;
            panel_quanlynhanvien.Visible = false;
            panel_quanlycalam.Visible = false;
            panel_thongke.Visible = false;
            panel_quanlyban.Visible = true;
            panel_uudai.Visible = false;
            label_main_name.Text = "QUẢN LÝ BÀN";
            panel_qlnhacungcap.Visible = false;
            form_load_ban();
        }

        private void iconButton_uudai_Click(object sender, EventArgs e)
        {
            panel_quanlybanhang.Visible = false;
            panel_quanlykhachhang.Visible = false;
            panel_quanlynhanvien.Visible = false;
            panel_quanlycalam.Visible = false;
            panel_uudai.Visible = true;
            panel_qlnhacungcap.Visible = false;
            panel_quanlyban.Visible = false;
            label_main_name.Text = "QUẢN LÝ ƯU ĐÃI";
            form_load_uudai();
        }

        private void dataGridView_qlhh_danhsachsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Ma_hanghoa = dataGridView_qlhh_danhsachsanpham.SelectedCells[0].OwningRow.Cells["Ma_hanghoa"].Value.ToString();
            String Ten_hanghoa = dataGridView_qlhh_danhsachsanpham.SelectedCells[0].OwningRow.Cells["Ten_hanghoa"].Value.ToString();
            String Ma_loaihang = dataGridView_qlhh_danhsachsanpham.SelectedCells[0].OwningRow.Cells["Ma_loaihang"].Value.ToString();
            String Hinhanh = dataGridView_qlhh_danhsachsanpham.SelectedCells[0].OwningRow.Cells["Hinhanh"].Value.ToString();
            String Sdt_ncc = dataGridView_qlhh_danhsachsanpham.SelectedCells[0].OwningRow.Cells["Sdt_ncc"].Value.ToString();
            String Gia = dataGridView_qlhh_danhsachsanpham.SelectedCells[0].OwningRow.Cells["Gia"].Value.ToString();
            String Soluong = dataGridView_qlhh_danhsachsanpham.SelectedCells[0].OwningRow.Cells["Soluong"].Value.ToString();
            String Trangthai = dataGridView_qlhh_danhsachsanpham.SelectedCells[0].OwningRow.Cells["Trangthai"].Value.ToString();

            textBox_qlhh_gia.Text = Gia;
           textBox_qlhh_masanpham.Text = Ma_hanghoa;
            textBox_qlhh_hinhanh.Text = Hinhanh;
            textBox_qlhh_soluong.Text = Soluong;
            textBox_qlhh_tensanpham.Text = Ten_hanghoa;
            if(Trangthai.Equals("HOAT DONG"))
            {
                radioButton_qlhh_hoatdong.Checked= true;
            }else if (Trangthai.Equals("NGUNG HOAT DONG"))
            {
                radioButton_qlhh_ngunghoatdong.Checked = true;
            }

            foreach(Loaihanghoa lhh in List_loaihanghoa)
            {
                if (lhh.Maloaihang.Equals(Ma_loaihang))
                {
                    comboBox_qlhh_loaisanpham.Text = lhh.Tenloaihang;
                }
            }

            foreach (Nhacungcap lhh in List_ncc)
            {
                if (lhh.Sdt.Equals(Sdt_ncc))
                {
                    comboBox_qlhh_sdtncc.Text = lhh.Sdt;
                }
            }

        }

        private void iconButton_qlhh_xoa_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton_qlhh_them_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                String masanpham = "HH_" + now.ToString().Replace(" ", "");
                String tensanpham = textBox_qlhh_tensanpham.Text.ToString();
                String sdtncc = comboBox_qlhh_sdtncc.Text.ToString();
                String loaihang = "";
                String Hinhanh = textBox_qlhh_hinhanh.Text.ToString();
                int gia = Int32.Parse( textBox_qlhh_gia.Text);
                int soluong = Int32.Parse(textBox_qlhh_soluong.Text);
                String trangthai = "";
                
                if (radioButton_qlhh_hoatdong.Checked)
                {
                    trangthai = "HOAT DONG";
                }
                else if (radioButton_qlhh_ngunghoatdong.Checked)
                {
                    trangthai = "NGUNG HOAT DONG";
                }

                String tenloaihang = comboBox_qlhh_loaisanpham.Text.ToString();
                foreach (Loaihanghoa lhh in List_loaihanghoa)
                {
                    if (lhh.Tenloaihang.Equals(tenloaihang))
                    {
                        loaihang = lhh.Maloaihang;
                        break;
                    }
                }

                HangHoaBUS.Instance.insertPRODUCT(masanpham, tensanpham, loaihang, Hinhanh, sdtncc, soluong, gia, trangthai);

                MessageBox.Show("Success!");
                form_load_qlhh();
                textBox_qlhh_gia.Text = "";
                textBox_qlhh_masanpham.Text = "";
                textBox_qlhh_hinhanh.Text = "";
                textBox_qlhh_soluong.Text = "";
                textBox_qlhh_tensanpham.Text = "";



            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton_qlhh_sua_Click(object sender, EventArgs e)
        {
            try
            {
                String masanpham = textBox_qlhh_masanpham.Text.ToString();
                String tensanpham = textBox_qlhh_tensanpham.Text.ToString();
                String sdtncc = comboBox_qlhh_sdtncc.Text.ToString();
                String loaihang = "";
                String Hinhanh = textBox_qlhh_hinhanh.Text.ToString();
                int gia = Int32.Parse(textBox_qlhh_gia.Text);
                int soluong = Int32.Parse(textBox_qlhh_soluong.Text);
                String trangthai = "";

                if (radioButton_qlhh_hoatdong.Checked)
                {
                    trangthai = "HOAT DONG";
                }
                else if (radioButton_qlhh_ngunghoatdong.Checked)
                {
                    trangthai = "NGUNG HOAT DONG";
                }

                String tenloaihang = comboBox_qlhh_loaisanpham.Text.ToString();
                foreach (Loaihanghoa lhh in List_loaihanghoa)
                {
                    if (lhh.Tenloaihang.Equals(tenloaihang))
                    {
                        loaihang = lhh.Maloaihang;
                        break;
                    }
                }

                HangHoaBUS.Instance.updateProduct(masanpham, tensanpham, loaihang, Hinhanh, sdtncc, soluong, gia, trangthai);

                MessageBox.Show("Success!");
                form_load_qlhh();

            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView_qlkh_listkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String Sdt = dataGridView_qlkh_listkhachhang.SelectedCells[0].OwningRow.Cells["Sdt"].Value.ToString();
                String Ten_kh = dataGridView_qlkh_listkhachhang.SelectedCells[0].OwningRow.Cells["Ten_kh"].Value.ToString();
                String Diemtl = dataGridView_qlkh_listkhachhang.SelectedCells[0].OwningRow.Cells["Diemtl"].Value.ToString();
                String Password = dataGridView_qlkh_listkhachhang.SelectedCells[0].OwningRow.Cells["Password"].Value.ToString();
                String Diachi = dataGridView_qlkh_listkhachhang.SelectedCells[0].OwningRow.Cells["Diachi"].Value.ToString();

                textBox_qlkh_diachi.Text = Diachi;
                textBox_qlkh_matkhau.Text = Password;
                textBox_qlkh_tenkh.Text = Ten_kh;
                textBox_qlkh_sdt.Text = Sdt;
                textBox_lkh_diemtl.Text = Diemtl;
            }
            catch(Exception ex)
            {

            }
        }

        private void iconButton_qlkh_them_Click(object sender, EventArgs e)
        {
            try
            {

                String Diachi = textBox_qlkh_diachi.Text.ToString();
                String Password = textBox_qlkh_matkhau.Text.ToString();
                String Ten_kh = textBox_qlkh_tenkh.Text.ToString();
                String Sdt = textBox_qlkh_sdt.Text.ToString();
                int Diemtl = Int32.Parse(textBox_lkh_diemtl.Text);

                KhachHangBUS.Instance.InsertAccountKhachHang(Sdt, Ten_kh, Diemtl, Password);
                KhachHangBUS.Instance.updateKH(Ten_kh,Sdt,Diachi, Password);

                MessageBox.Show("Success!");
                form_load_khachhang();

            }
            catch(Exception ex)
            {

            }
        }

        private void iconButton_qlkh_sua_Click(object sender, EventArgs e)
        {
            try
            {

                String Diachi = textBox_qlkh_diachi.Text.ToString();
                String Password = textBox_qlkh_matkhau.Text.ToString();
                String Ten_kh = textBox_qlkh_tenkh.Text.ToString();
                String Sdt = textBox_qlkh_sdt.Text.ToString();
                int Diemtl = Int32.Parse(textBox_lkh_diemtl.Text);
                KhachHangBUS.Instance.updateKH(Ten_kh, Sdt, Diachi, Password);

                MessageBox.Show("Success!");
                form_load_khachhang();

            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView_qlnv_listnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String Sdt = dataGridView_qlnv_listnv.SelectedCells[0].OwningRow.Cells["Sdt"].Value.ToString();
                String Ten_nv = dataGridView_qlnv_listnv.SelectedCells[0].OwningRow.Cells["Ten_nv"].Value.ToString();
                String Chucvu = dataGridView_qlnv_listnv.SelectedCells[0].OwningRow.Cells["Chucvu"].Value.ToString();
                String Matkhau = dataGridView_qlnv_listnv.SelectedCells[0].OwningRow.Cells["Matkhau"].Value.ToString();
                String Calam = dataGridView_qlnv_listnv.SelectedCells[0].OwningRow.Cells["Calam"].Value.ToString();
                String diachi = dataGridView_qlnv_listnv.SelectedCells[0].OwningRow.Cells["Diachi"].Value.ToString();
                textBox_ngayvaolam.Text = dataGridView_qlnv_listnv.SelectedCells[0].OwningRow.Cells["Ngayvaolam"].Value.ToString();
                bool Gioitinh = (bool)dataGridView_qlnv_listnv.SelectedCells[0].OwningRow.Cells["Gioitinh"].Value;
                bool phanquyen = (bool)dataGridView_qlnv_listnv.SelectedCells[0].OwningRow.Cells["Phanquyen"].Value;

                textBox_qlnv_sdt.Text = Sdt;
                textBox_qlnv_ten.Text = Ten_nv;
                textBox__qlnv_chucvu.Text = Chucvu;
                textBox__qlnv_matkhau.Text = Matkhau;
                textBox_diachi.Text = diachi;



                foreach (Calamviec lhh in List_Calamviec)
                {
                    if (lhh.Ma_clv.Equals(Calam))
                    {
                        comboBox__qlnv_calam.Text = lhh.Ma_clv;
                    }
                }

                if(Gioitinh)
                {
                    radioButton_qlnv_nam.Checked = true;
                    radioButton_qlnv_nu.Checked = false;
                }
                else
                {
                    radioButton_qlnv_nu.Checked = true;
                    radioButton_qlnv_nam.Checked = false;
                }

                if (phanquyen)
                {
                    radioButton_qlnv_quanly.Checked = true;
                    radioButton_qlnv_nhanvien.Checked = false;
                }
                else
                {
                    radioButton_qlnv_nhanvien.Checked = true;
                    radioButton_qlnv_quanly.Checked = false;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton_qlnv_them_Click(object sender, EventArgs e)
        {



            try
            {
                String sdt = textBox_qlnv_sdt.Text.ToString();
                String ten = textBox_qlnv_ten.Text.ToString();
                String chucvu = textBox__qlnv_chucvu.Text.ToString();
                String diachi = textBox_diachi.Text.ToString();
                String matkhau = textBox__qlnv_matkhau.Text.ToString();
                String calam = comboBox__qlnv_calam.Text.ToString();
                Boolean gioitinh = true;
                Boolean phanquyen = false;
                DateTime ngayvaolam = DateTime.ParseExact(textBox_ngayvaolam.Text.ToString(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                if (radioButton_qlnv_nam.Checked)
                {
                    gioitinh = true;

                }
                else
                {

                    gioitinh = false;
                }

                if (radioButton_qlnv_quanly.Checked)
                {
                    phanquyen = true;

                }
                else
                {

                    phanquyen = false;
                }
                NhanVienDAO.Instance.insertnv(sdt, ten, gioitinh, chucvu, phanquyen, ngayvaolam, matkhau, calam);
                MessageBox.Show("Success!");
                form_load_NhanVien();
            }catch(Exception ex)
            {

            }
        }

        private void iconButton__qlnv_sua_Click(object sender, EventArgs e)
        {
            try
            {
                String sdt = textBox_qlnv_sdt.Text.ToString();
                String ten = textBox_qlnv_ten.Text.ToString();
                String chucvu = textBox__qlnv_chucvu.Text.ToString();
                String diachi = textBox_diachi.Text.ToString();
                String matkhau = textBox__qlnv_matkhau.Text.ToString();
                String calam = comboBox__qlnv_calam.Text.ToString();
                Boolean gioitinh = true;
                Boolean phanquyen = false;
                DateTime ngayvaolam = DateTime.ParseExact(textBox_ngayvaolam.Text.ToString(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                if (radioButton_qlnv_nam.Checked)
                {
                    gioitinh = true;

                }
                else
                {

                    gioitinh = false;
                }

                if (radioButton_qlnv_quanly.Checked)
                {
                    phanquyen = true;

                }
                else
                {

                    phanquyen = false;
                }
                NhanVienDAO.Instance.updatenv(sdt, ten, gioitinh, chucvu, phanquyen, ngayvaolam, matkhau, calam);
                MessageBox.Show("Success!");
                form_load_NhanVien();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView_qlcl_listcalam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String maca = dataGridView_qlcl_listcalam.SelectedCells[0].OwningRow.Cells["Ma_clv"].Value.ToString();
                String tenca = dataGridView_qlcl_listcalam.SelectedCells[0].OwningRow.Cells["Ten_clv"].Value.ToString();
                int giobd  = Int32.Parse(dataGridView_qlcl_listcalam.SelectedCells[0].OwningRow.Cells["Giobatdau"].Value.ToString());
                int  giokt = Int32.Parse(dataGridView_qlcl_listcalam.SelectedCells[0].OwningRow.Cells["Gioketthuc"].Value.ToString());
                int tien = Int32.Parse(dataGridView_qlcl_listcalam.SelectedCells[0].OwningRow.Cells["Sotien"].Value.ToString());

                textBox_qlcl_maca.Text = maca;
                textBox__qlcl_tenca.Text = tenca;
                textBox__qlcl_giobd.Text = giobd.ToString();
                textBox_qlcl_kt.Text = giokt.ToString();
                textBox__qlcl_tien.Text = tien.ToString();



            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton_qlcl_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                CalamviecDAO.Instance.delete(textBox_qlcl_maca.Text.ToString());
                MessageBox.Show("Success!");
                form_load_calamviec();
            }
            catch(Exception ex)
            {

            }
        }

        private void iconButton_qlcl_them_Click(object sender, EventArgs e)
        {

            try
            {
                String maca = textBox_qlcl_maca.Text.ToString();
                String tenca = textBox__qlcl_tenca.Text.ToString();
                int giobd = Int32.Parse(textBox__qlcl_giobd.Text.ToString());
                int giokt = Int32.Parse(textBox_qlcl_kt.Text.ToString());
                int tien = Int32.Parse(textBox__qlcl_tien.Text.ToString());

                CalamviecDAO.Instance.insert(maca, tenca, giobd, giokt, tien);
                MessageBox.Show("Success");
                form_load_calamviec();
            }
            catch(Exception ex)
            {

            }


        }

        private void iconButton_qlcl_sua_Click(object sender, EventArgs e)
        {
            try
            {
                String maca = textBox_qlcl_maca.Text.ToString();
                String tenca = textBox__qlcl_tenca.Text.ToString();
                int giobd = Int32.Parse(textBox__qlcl_giobd.Text.ToString());
                int giokt = Int32.Parse(textBox_qlcl_kt.Text.ToString());
                int tien = Int32.Parse(textBox__qlcl_tien.Text.ToString());

                CalamviecDAO.Instance.update(maca, tenca, giobd, giokt, tien);
                MessageBox.Show("Success");
                form_load_calamviec();
            }
            catch(Exception ex)
            {

            }
        }

        private void dataGridView_qlncc_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String Sdt = dataGridView_qlncc_list.SelectedCells[0].OwningRow.Cells["Sdt"].Value.ToString();
                String Ten_ncc = dataGridView_qlncc_list.SelectedCells[0].OwningRow.Cells["Ten_ncc"].Value.ToString();
                String Diachi = dataGridView_qlncc_list.SelectedCells[0].OwningRow.Cells["Diachi"].Value.ToString();
                String Trangthai = dataGridView_qlncc_list.SelectedCells[0].OwningRow.Cells["Trangthai"].Value.ToString();

                textBox_qlncc_sdt.Text = Sdt;
                textBox_qlncc__ten.Text = Ten_ncc;
                textBox_qlncc_diachi.Text = Diachi;

                if (Trangthai.Equals("HOP TAC"))
                {
                    radioButton_qlncc_hoptac.Checked= true;
                }
                else
                {
                    radioButton_ngunghoptac.Checked = true;
                }

            }
            catch(Exception ex)
            {

            }

        }

        private void iconButton_qlncc_them_Click(object sender, EventArgs e)
        {
            try
            {
                String sdt = textBox_qlncc_sdt.Text.ToString();
                String ten = textBox_qlncc__ten.Text.ToString();
                String diachi = textBox_qlncc_diachi.Text.ToString();
                String trangthai = "";

                if (radioButton_qlncc_hoptac.Checked)
                {
                    trangthai = "HOP TAC";
                }
                else
                {
                    trangthai = "NGUNG HOP TAC";
                }


                NhaCungCapDAO.Instance.insert(sdt,ten,diachi,trangthai);
                MessageBox.Show("Success");
                Form_load_nhacungcap();
            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton_qlncc_sua_Click(object sender, EventArgs e)
        {
            try
            {
                String sdt = textBox_qlncc_sdt.Text.ToString();
                String ten = textBox_qlncc__ten.Text.ToString();
                String diachi = textBox_qlncc_diachi.Text.ToString();
                String trangthai = "";

                if (radioButton_qlncc_hoptac.Checked)
                {
                    trangthai = "HOP TAC";
                }
                else
                {
                    trangthai = "NGUNG HOP TAC";
                }


                NhaCungCapDAO.Instance.update(sdt, ten, diachi, trangthai);
                MessageBox.Show("Success");
                Form_load_nhacungcap();
            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = textBox_maban.Text.ToString();
                String ten = textBox_tenban.Text.ToString();
                String makhuvuc = comboBox_khuvuc.Text.ToString();
                String trangthai = "";

                foreach (KhuVuc kv in List_khuvuc)
                {
                    if (kv.Tenkhuvuc.Equals(makhuvuc))
                    {
                        makhuvuc  = kv.Makhuvuc.ToString();
                        break;
                    }
                }

                if (radioButton_dangcokhach.Checked)
                {
                    trangthai = "0";
                }
                else
                {
                    trangthai = "1";
                }


                BanDAO.Instance.insert(ma,ten,makhuvuc,trangthai);
                MessageBox.Show("Success");
                form_load_ban();
            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = textBox_maban.Text.ToString();
                String ten = textBox_tenban.Text.ToString();
                String makhuvuc = comboBox_khuvuc.Text.ToString();
                String trangthai = "";

                foreach (KhuVuc kv in List_khuvuc)
                {
                    if (kv.Tenkhuvuc.Equals(makhuvuc))
                    {
                        makhuvuc = kv.Makhuvuc.ToString();
                        break;
                    }
                }

                if (radioButton_dangcokhach.Checked)
                {
                    trangthai = "0";
                }
                else
                {
                    trangthai = "1";
                }


                BanDAO.Instance.update(ma, ten, makhuvuc, trangthai);
                MessageBox.Show("Success");
                form_load_ban();
            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            try
            {
                String thuoctinh = dataGridView_danhsachban.SelectedCells[0].OwningRow.Cells["Thuoctinh"].Value.ToString();
                if (thuoctinh.Equals("0"))
                {
                    MessageBox.Show("Bàn Này Đang Có Khách và Chưa được thanh toán nên không thể xóa!");
                    return;
                }
                String maban = dataGridView_danhsachban.SelectedCells[0].OwningRow.Cells["Maban"].Value.ToString();

                BanDAO.Instance.deleteban(maban);
                MessageBox.Show("Success");
                form_load_ban();

            }
            catch (Exception ex) { }
        }

        private void dataGridView_danhsachban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String maban = dataGridView_danhsachban.SelectedCells[0].OwningRow.Cells["Maban"].Value.ToString();
                String thuoctinh = dataGridView_danhsachban.SelectedCells[0].OwningRow.Cells["Thuoctinh"].Value.ToString();
                String makhuvuc = dataGridView_danhsachban.SelectedCells[0].OwningRow.Cells["Makhuvuc"].Value.ToString();
                String tenban = dataGridView_danhsachban.SelectedCells[0].OwningRow.Cells["Tenban"].Value.ToString();

                textBox_maban.Text = maban;
                textBox_tenban.Text = tenban;

                foreach (KhuVuc kv in List_khuvuc)
                {
                    if(kv.Makhuvuc.Equals(makhuvuc))
                    {
                        comboBox_khuvuc.Text = kv.Tenkhuvuc.ToString();
                    }
                }

                if (thuoctinh.Equals("1"))
                {
                    radioButton_trong.Checked = true;
                }
                else
                {
                    radioButton_dangcokhach.Checked = true;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            try
            {
                String thuoctinh = dataGridView3.SelectedCells[0].OwningRow.Cells["Thuoctinh"].Value.ToString();
                if (thuoctinh.Equals("0"))
                {
                    MessageBox.Show("Bàn Này Đang Có Khách và Chưa được thanh toán nên không thể xóa!");
                    return;
                }
                String maban = dataGridView3.SelectedCells[0].OwningRow.Cells["Maban"].Value.ToString();

                BanDAO.Instance.deleteban(maban);
                MessageBox.Show("Success");
                form_load_ban();

            }
            catch (Exception ex) { }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = textBox10.Text.ToString();
                String ten = textBox9.Text.ToString();
                String makhuvuc = comboBox1.Text.ToString();
                String trangthai = "";

                foreach (KhuVuc kv in List_khuvuc)
                {
                    if (kv.Tenkhuvuc.Equals(makhuvuc))
                    {
                        makhuvuc = kv.Makhuvuc.ToString();
                        break;
                    }
                }

                if (radioButton4.Checked)
                {
                    trangthai = "0";
                }
                else
                {
                    trangthai = "1";
                }


                BanDAO.Instance.insert(ma, ten, makhuvuc, trangthai);
                MessageBox.Show("Success");
                form_load_ban();
            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            try
            {
                String ma = textBox10.Text.ToString();
                String ten = textBox9.Text.ToString();
                String makhuvuc = comboBox1.Text.ToString();
                String trangthai = "";

                foreach (KhuVuc kv in List_khuvuc)
                {
                    if (kv.Tenkhuvuc.Equals(makhuvuc))
                    {
                        makhuvuc = kv.Makhuvuc.ToString();
                        break;
                    }
                }

                if (radioButton4.Checked)
                {
                    trangthai = "0";
                }
                else
                {
                    trangthai = "1";
                }


                BanDAO.Instance.update(ma, ten, makhuvuc, trangthai);
                MessageBox.Show("Success");
                form_load_ban();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView3_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String maban = dataGridView3.SelectedCells[0].OwningRow.Cells["Maban"].Value.ToString();
                String thuoctinh = dataGridView3.SelectedCells[0].OwningRow.Cells["Thuoctinh"].Value.ToString();
                String makhuvuc = dataGridView3.SelectedCells[0].OwningRow.Cells["Makhuvuc"].Value.ToString();
                String tenban = dataGridView3.SelectedCells[0].OwningRow.Cells["Tenban"].Value.ToString();

                textBox10.Text = maban;
                textBox9.Text = tenban;

                foreach (KhuVuc kv in List_khuvuc)
                {
                    if (kv.Makhuvuc.Equals(makhuvuc))
                    {
                        comboBox1.Text = kv.Tenkhuvuc.ToString();
                    }
                }

                if (thuoctinh.Equals("1"))
                {
                    radioButton3.Checked = true;
                }
                else
                {
                    radioButton4.Checked = true;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView_danhsachuudai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String ten = dataGridView_danhsachuudai.SelectedCells[0].OwningRow.Cells["Tenuudai"].Value.ToString();
                String trangthai = dataGridView_danhsachuudai.SelectedCells[0].OwningRow.Cells["Trangthai"].Value.ToString();
                int tien = Int32.Parse(dataGridView_danhsachuudai.SelectedCells[0].OwningRow.Cells["Tiengiamgia"].Value.ToString());
                

                textBox_tenuudai.Text = ten;
                textBox_sotiengiam.Text = tien.ToString();

                

                if (trangthai.Equals("1"))
                {
                    radioButton_dangdienra.Checked = true;
                }
                else
                {
                    radioButton_ketthuc.Checked = true;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton_uudaixoa_Click(object sender, EventArgs e)
        {
            try
            {
                String thuoctinh = dataGridView_danhsachuudai.SelectedCells[0].OwningRow.Cells["Tenuudai"].Value.ToString();
                ChiTietBanHangDAO.Instance.deleteUudai(thuoctinh);
                MessageBox.Show("Success");
                form_load_uudai();

            }
            catch (Exception ex) { }
        }

        private void iconButton_uudaithem_Click(object sender, EventArgs e)
        {
            try
            {
                String ten = textBox_tenuudai.Text.ToString();
                String trangthai = "";
                int tien = Int32.Parse(textBox_sotiengiam.Text.ToString());



                if (radioButton_dangdienra.Checked)
                {
                    trangthai = "1";
                }
                else
                {
                    trangthai = "0";
                }


                ChiTietBanHangDAO.Instance.insertuudai(ten,tien,trangthai);
                MessageBox.Show("Success");
                form_load_uudai();
            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton_uudaisua_Click(object sender, EventArgs e)
        {
            try
            {
                String ten = textBox_tenuudai.Text.ToString();
                String trangthai = "";
                int tien = Int32.Parse(textBox_sotiengiam.Text.ToString());



                if (radioButton_dangdienra.Checked)
                {
                    trangthai = "1";
                }
                else
                {
                    trangthai = "0";
                }


                ChiTietBanHangDAO.Instance.updateuudai(ten, tien, trangthai);
                MessageBox.Show("Success");
                form_load_uudai();
            }
            catch (Exception ex)
            {

            }
        }

        private void iconButton_danhsachsanphamsaphethang_Click(object sender, EventArgs e)
        {
            List<Hanghoa> list = HangHoaBUS.Instance.getFULL();
            FDanhSachSanPhamSapHET formm = new FDanhSachSanPhamSapHET();
            formm.ListHH = list;
            formm.ShowDialog();
        }

        private void iconButton_xembaocao_Click(object sender, EventArgs e)
        {
            form_load_baocao();
        }

        private void iconButton_xemchitietdonhang_Click(object sender, EventArgs e)
        {
            try
            {
                String mahd = dataGridView_listbaoca.SelectedCells[0].OwningRow.Cells["Ma_hd_bh"].Value.ToString();
                Fchitietmonan f = new Fchitietmonan();
               
                f.Mahh = mahd;
                f.ShowDialog();
            }
            catch(Exception ec)
            {

            }
        }

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý học sinh";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {



                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                worksheet.Cells[dataGridView1.RowCount-1 + 2, 0 + 1] = "Tổng Tiền :";
                worksheet.Cells[dataGridView1.RowCount-1 + 2, 1 + 1] = label_tongtien.Text.ToString();
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void iconButton_xuatfile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataGridView_listbaoca, saveFileDialog1.FileName);
            }
        }
    }
}
