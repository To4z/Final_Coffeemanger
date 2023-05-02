using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietBanHangDAO
    {
        private static ChiTietBanHangDAO instance;

        public static ChiTietBanHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietBanHangDAO();
                }
                return instance;
            }

        }

        private ChiTietBanHangDAO()
        {

        }

        public void insertChitietbanhang(String mahd, String masanpham, int soluong, int tongtien, String sdt)
        {

            String query = "insertchitietbanhang @ma_hd_bh , @ma_hanghoa , @soluong ,  @thanhtien , @sdt";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahd, masanpham, soluong, tongtien, sdt });

        }

        public void insertChitietbanhang_online(String mahd, String masanpham, int soluong, int tongtien, String trangthai, String ngaygiao, String giogiao, String diachi, String sodienthoai)
        {

            String query = "insertchitietbanhang_online @ma_hd_bh , @ma_hanghoa , @soluong , @thanhtien , @trangthai , @ngaygiao , @diachi , @sodienthoai , @giogiao ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahd, masanpham, soluong, tongtien,  trangthai,  ngaygiao,  giogiao,  diachi,  sodienthoai });

        }

        public List<Chitietbanhang> getCHItiet(String ma)
        {
            String query = "select * from chitietbanhang where ma_hd_bh = @ma";
            List<Chitietbanhang> listban = new List<Chitietbanhang>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ma });
            foreach (DataRow item in data.Rows)
            {
                Chitietbanhang hh = new Chitietbanhang(item);
                listban.Add(hh);
            }

            return listban;
        }

        public bool deleteUudai(String tenuudai)
        {
            String query = "delete uudai where tenuudai = @tenuudai";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenuudai });
            return true;
        }

        public bool insertuudai(String tenuudai,int tiengiamgia, String trangthai)
        {
            String query = "insert_uudai @tenuudai , @tiengiamgia , @trangthai";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenuudai, tiengiamgia, trangthai });
            return true;
        }

        public bool updateuudai(String tenuudai, int tiengiamgia, String trangthai)
        {
            String query = "update_uudai @tenuudai , @tiengiamgia , @trangthai";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenuudai, tiengiamgia, trangthai });
            return true;
        }



        public List<Uudai> getAllUudai()
        {
            String query = "select * from uudai";
            List<Uudai> listban = new List<Uudai>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Uudai hh = new Uudai(item);
                listban.Add(hh);
            }

            return listban;
        }
    }
}
