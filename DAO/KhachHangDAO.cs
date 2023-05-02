using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {

        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new KhachHangDAO();
                }
                return instance;
            }

        }

        private KhachHangDAO()
        {

        }

        public Khachhang getAccountKhachHang(String sdt, String pass)
        {
            Khachhang khachhang = null;
            khachhang = DataProvider.Instance.ecuxeProcedure_getKHACHHANG(sdt, pass);
            return khachhang;
        }

        public bool InsertAccountKhachHang(string sdt, string name, int diemtl, string pass)
        {
            bool check = false;
            check = DataProvider.Instance.InsertAccountKhachHang( sdt,  name,  diemtl,  pass);
            return check;
        }

        public void updateKH(String name, String sdt, String diachi, String pass)
        {
            String query = "updateKH_up @name , @sdt , @diachi , @pass";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, sdt, diachi, pass });
        }

        public List<Khachhang> getAllKH()
        {
            List<Khachhang> khachhang = new List<Khachhang>();
            khachhang = DataProvider.Instance.getAllKH();
            return khachhang;
        }
    }
}
