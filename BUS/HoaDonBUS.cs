using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonBUS();
                }
                return instance;
            }

        }

        private HoaDonBUS()
        {

        }

        public void insertHD(String mahd, String sdtkh, String maban, int tongtien, String trangthai)
        {
            HoaDonBanHangDAO.Instance.insertHoaDonBanHang(mahd,sdtkh, maban, tongtien, trangthai);
        }

        public List<Hoadonbanhang> dhbh_stt(String trangthai)
        {
            return HoaDonBanHangDAO.Instance.getHDBH_TT(trangthai);
        }

        public void deleteHD(String mahd,String sdt)
        {
            HoaDonBanHangDAO.Instance.deleteHD(mahd, sdt);
        }

        public void updateHDBH(String stt, String mahd)
        {
            HoaDonBanHangDAO.Instance.updateHDBH(stt,mahd);

        }
    }
}
