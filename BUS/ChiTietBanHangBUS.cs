using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietBanHangBUS
    {
        private static ChiTietBanHangBUS instance;
        public static ChiTietBanHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietBanHangBUS();
                }
                return instance;
            }

        }

        private ChiTietBanHangBUS()
        {

        }

        public void insertchitietbanhang(String mahd, String masanpham, int soluong, int tongtien, String sdt)
        {
            ChiTietBanHangDAO.Instance.insertChitietbanhang(mahd, masanpham, soluong, tongtien, sdt);
        }

        public void insertchitietbanhang_online(String mahd, String masanpham, int soluong, int tongtien, String trangthai, String ngaygiao, String giogiao, String diachi, String sodienthoai)
        {
            ChiTietBanHangDAO.Instance.insertChitietbanhang_online(mahd, masanpham, soluong, tongtien, trangthai, ngaygiao, giogiao, diachi, sodienthoai);
        }

        public List<Chitietbanhang> getCTBH(String mahd)
        {
            return ChiTietBanHangDAO.Instance.getCHItiet(mahd);
        }
    }
}
