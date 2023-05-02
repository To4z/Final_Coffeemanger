using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LichSuMuaHangBUS
    {
        private static LichSuMuaHangBUS instance;
        public static LichSuMuaHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichSuMuaHangBUS();
                }
                return instance;
            }

        }

        private LichSuMuaHangBUS()
        {
            
        }

        public void insert(String mahd, String tensp, String phone, int soluong, int tongtien, String ngay)
        {
            LichSuMuHangDAO.Instance.insertLSMUAHANG(mahd, tensp, phone, soluong, tongtien, ngay);
        }

        public List<LichSuMuaHang> getAll(String phone)
        {
            return LichSuMuHangDAO.Instance.getAll(phone);
        }

    }
}
