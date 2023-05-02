using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LichSuMuHangDAO
    {

        private static LichSuMuHangDAO instance;

        public static LichSuMuHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichSuMuHangDAO();
                }
                return instance;
            }

        }

        private LichSuMuHangDAO()
        {

        }

        public void insertLSMUAHANG(String mahd, String tensp, String phone, int soluong, int tongtien, String ngay)
        {

            String query = "lichSumuaHangKH_UP_insert @mahoadon , @TenSanPham , @phoneNumber , @soluong , @Gia , @Ngay";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahd, tensp, phone, soluong, tongtien, ngay });
        }

        public List<LichSuMuaHang> getAll(String phoneNumber)
        {
            List<LichSuMuaHang> list = new List<LichSuMuaHang>();

            String query = "getALLlichSumuaHangKH_UP @phoneNumber";


            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phoneNumber });
            foreach (DataRow item in data.Rows)
            {
                LichSuMuaHang hh = new LichSuMuaHang(item);
                list.Add(hh);
            }



            return list;
        }
    }
}
