using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienBUS();
                }
                return instance;
            }

        }

        public NhanVienBUS()
        {

        }
     


        public Nhanvien getAccountNhanvien(string sdt, string pass)
        {
            Nhanvien nhanvien = null;
            nhanvien = DAO.NhanVienDAO.Instance.getAccountNhanvien(sdt, pass);
            return nhanvien;
        }

        public List<Nhanvien> getAllNHANVien()
        {
            return NhanVienDAO.Instance.getAllNV();
        }

        
    }
}
