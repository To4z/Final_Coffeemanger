using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonBanHangDAO
    {

        private static HoaDonBanHangDAO instance;

        public static HoaDonBanHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonBanHangDAO();
                }
                return instance;
            }

        }

        private HoaDonBanHangDAO()
        {

        }

        public void insertHoaDonBanHang(String mahd, String sdtkh, String maban, int tongtien, String trangthai )
        {

            String query = "proc_hoadonbanhang @ma_hd_bh , @sdtkh , @maban , @tongtien , @trangthai";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahd, sdtkh, maban,tongtien , trangthai });
            
        }

        public List<Hoadonbanhang> getHDBH_TT(String trangthai)
        {
            String query = "select * from hoadonbanhang where trangthai = @trangthai";

            List<Hoadonbanhang> dh = new List<Hoadonbanhang>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { trangthai });

            foreach (DataRow item in data.Rows)
            {
                Hoadonbanhang hh = new Hoadonbanhang(item);
                dh.Add(hh);
            }

            return dh;
        }


        public Hoadonbanhang getHD_theoten(String trangthai)
        {
            String query = "select * from hoadonbanhang where ma_hd_bh = @trangthai";

            List<Hoadonbanhang> dh = new List<Hoadonbanhang>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { trangthai });

            foreach (DataRow item in data.Rows)
            {
                Hoadonbanhang hh = new Hoadonbanhang(item);
                dh.Add(hh);
            }

            return dh[0];
        }

        public List<Hoadonbanhang> getall()
        {
            String query = "select * from hoadonbanhang";

            List<Hoadonbanhang> dh = new List<Hoadonbanhang>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Hoadonbanhang hh = new Hoadonbanhang(item);
                dh.Add(hh);
            }

            return dh;
        }

        public void deleteHD(String mahd, String sdt)
        {
            String query = "deleteHoaDon @mahd";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahd});

            String query1 = "delete from lichSumuaHangKH where mahoadon = @mahd and phoneNumber = @sdt";
            int data1 = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { mahd , sdt});

        }

        public void updateHDBH(String stt, String mahd)
        {
            String query = "update hoadonbanhang set trangthai = @stt where ma_hd_bh = @mahd";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { stt, mahd });

            String query1 = "update hoadonbanhang set maban = @maban where ma_hd_bh = @mahd";
            int data1 = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { "OFF_MANGVE", mahd });

        }
    }
}
