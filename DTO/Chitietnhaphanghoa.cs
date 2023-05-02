using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chitietnhaphanghoa
    {
        private String ma_hd_nh;
        private String ma_hh;
        private int soluong;
        private int thanhtien;

        public Chitietnhaphanghoa()
        {
        }

        public Chitietnhaphanghoa(DataRow row)
        {
            this.Ma_hd_nh = row["ma_hd_nh"].ToString();
            this.Ma_hh = row["ma_hanghoa"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Thanhtien = (int)row["thanhtien"];
        }

        public Chitietnhaphanghoa(string ma_hd_nh, string ma_hh, int soluong, int thanhtien)
        {
            this.Ma_hd_nh = ma_hd_nh;
            this.Ma_hh = ma_hh;
            this.Soluong = soluong;
            this.Thanhtien = thanhtien;
        }

        public string Ma_hd_nh { get => ma_hd_nh; set => ma_hd_nh = value; }
        public string Ma_hh { get => ma_hh; set => ma_hh = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
