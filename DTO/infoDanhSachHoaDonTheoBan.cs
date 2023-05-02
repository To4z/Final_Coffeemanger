using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class infoDanhSachHoaDonTheoBan
    {
        private String ma_hd_bh;
        private String sdt_kh;
        private int tongtien;

        public infoDanhSachHoaDonTheoBan()
        {

        }

        public infoDanhSachHoaDonTheoBan(DataRow row)
        {
            this.ma_hd_bh = row["ma_hd_bh"].ToString();
            this.tongtien = (int)row["tongtien"];
            this.sdt_kh = row["sdt_kh"].ToString();

        }

        public infoDanhSachHoaDonTheoBan(string ma_hd_bh, string sdt_kh, int tongtien)
        {
            this.ma_hd_bh = ma_hd_bh;
            this.sdt_kh = sdt_kh;
            this.tongtien = tongtien;
        }

        public string Ma_hd_bh { get => ma_hd_bh; set => ma_hd_bh = value; }
        public string Sdt_kh { get => sdt_kh; set => sdt_kh = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
