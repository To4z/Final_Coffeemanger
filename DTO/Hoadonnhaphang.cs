using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoadonnhaphang
    {
        private String ma_hd_nh;
        private String sdt_nv;
        private String sdt_ncc;
        private DateTime ngay_nh;
        private int thanhtien;

        public Hoadonnhaphang()
        {
        }

        public Hoadonnhaphang(DataRow row)
        {
            this.ma_hd_nh = row["ma_hd_nh "].ToString();
            this.Sdt_nv = row["sdt_nv"].ToString();
            this.sdt_ncc = row["sdt_ncc"].ToString();
            this.ngay_nh = (DateTime)row["ngayhdnh"];
            this.thanhtien = (int)row["thanhtien"];
        }

        public Hoadonnhaphang(string ma_hd_nh, string sdt_nv, string sdt_ncc, DateTime ngay_nh, int thanhtien)
        {
            this.ma_hd_nh = ma_hd_nh;
            this.sdt_nv = sdt_nv;
            this.sdt_ncc = sdt_ncc;
            this.ngay_nh = ngay_nh;
            this.thanhtien = thanhtien;
        }

        public string Ma_hd_nh { get => ma_hd_nh; set => ma_hd_nh = value; }
        public string Sdt_nv { get => sdt_nv; set => sdt_nv = value; }
        public string Sdt_ncc { get => sdt_ncc; set => sdt_ncc = value; }
        public DateTime Ngay_nh { get => ngay_nh; set => ngay_nh = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
