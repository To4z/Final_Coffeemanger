using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chitietluongnhanvien
    {
        private String ma_clv;
        private String sdt_nv;
        private int tongcalamviectrongthang;
        private int thanhtien;


        public Chitietluongnhanvien()
        {
        }

        public Chitietluongnhanvien(DataRow row)
        {
            this.Ma_clv = row["ma_clv"].ToString();
            this.Sdt_nv = row["sdt_nv"].ToString();
            this.Tongcalamviectrongthang = (int)row["tongcalamtrongthang"];
            this.Thanhtien = (int)row["thanhtien"];
        }

        public Chitietluongnhanvien(string ma_clv, string sdt_nv, int tongcalamviectrongthang, int thanhtien)
        {
            this.Ma_clv = ma_clv;
            this.Sdt_nv = sdt_nv;
            this.Tongcalamviectrongthang = tongcalamviectrongthang;
            this.Thanhtien = thanhtien;
        }

        public string Ma_clv { get => ma_clv; set => ma_clv = value; }
        public string Sdt_nv { get => sdt_nv; set => sdt_nv = value; }
        public int Tongcalamviectrongthang { get => tongcalamviectrongthang; set => tongcalamviectrongthang = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }

    }
}
