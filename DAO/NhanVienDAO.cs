using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {

        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new NhanVienDAO();
                }
                return instance;
            }

        }

        private NhanVienDAO()
        {

        }

        public Nhanvien getAccountNhanvien(String sdt, String pass)
        {
            Nhanvien nhanvien = null;
            nhanvien = DataProvider.Instance.ecuxeProcedure_getNhanVien(sdt, pass);
            return nhanvien;
        }

        public void insertnv(String sdt , String ten_nv , bool gioitinh , String chucvu  ,bool phanquyen , DateTime ngayvaolam , String matkhau  , String calam)
        {

            String query = "insertnv @sdt , @ten_nv , @gioitinh , @chucvu  , @phanquyen , @ngayvaolam , @matkhau  , @calam";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdt, ten_nv, gioitinh, chucvu, phanquyen, ngayvaolam, matkhau, calam });

        }

        public void updatenv(String sdt, String ten_nv, bool gioitinh, String chucvu, bool phanquyen, DateTime ngayvaolam, String matkhau, String calam)
        {

            String query = "updateNV @sdt , @ten_nv , @gioitinh , @chucvu  , @phanquyen , @ngayvaolam , @matkhau  , @calam";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdt, ten_nv, gioitinh, chucvu, phanquyen, ngayvaolam, matkhau, calam });

        }

        public List<Nhanvien> getAllNV()
        {
            String query = "select * from nhanvien";
            List<Nhanvien> listProducts = new List<Nhanvien>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Nhanvien hh = new Nhanvien(item);
                listProducts.Add(hh);
            }

            return listProducts;
        }

        


    }
}
