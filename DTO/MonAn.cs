using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAn
    {
        private String ma_hanghoa;
        private String ten_hanghoa;
        private int thanhtien;
        private String maloaihang;

        public MonAn()
        {

        }

        public MonAn(string ma_hanghoa, string ten_hanghoa,   int thanhtien, String maloaihang)
        {
            Ma_hanghoa = ma_hanghoa;
            Ten_hanghoa = ten_hanghoa;
            Thanhtien = thanhtien;
            Maloaihang= maloaihang;
        }

        public string Ma_hanghoa { get => ma_hanghoa; set => ma_hanghoa = value; }
        public string Ten_hanghoa { get => ten_hanghoa; set => ten_hanghoa = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Maloaihang { get => maloaihang; set => maloaihang = value; }
    }
}
