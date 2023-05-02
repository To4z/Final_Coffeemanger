using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hanghoa
    {
        private String ma_hanghoa;
        private String ten_hanghoa;
        private String ma_loaihang;
        private String hinhanh;
        private String sdt_ncc;
        private int gia;
        private int soluong;
        private String trangthai;

        public Hanghoa()
        {
        }

        public Hanghoa(string ma_hanghoa, string ten_hanghoa, string ma_loaihang, string hinhanh, string sdt_ncc, int gia, int soluong, String trangthai)
        {
            this.Ma_hanghoa = ma_hanghoa;
            this.Ten_hanghoa = ten_hanghoa;
            this.Ma_loaihang = ma_loaihang;
            this.Hinhanh = hinhanh;
            this.Sdt_ncc = sdt_ncc;
            this.Gia = gia;
            this.Soluong = soluong;
            this.Trangthai = trangthai;
        }

        public Hanghoa(DataRow row)
        {
            this.Ma_hanghoa = row["ma_hanghoa"].ToString();
            this.Ten_hanghoa = row["ten_hanghoa"].ToString();
            this.Ma_loaihang = row["ma_loaihoang"].ToString();
            this.Hinhanh = row["hinh_anh"].ToString();
            this.Sdt_ncc = row["sdt_ncc"].ToString();
            this.Gia = (int)row["giasp"];
            this.Soluong = (int)row["soluong"];
            this.trangthai = row["trangthai"].ToString();
        }

        public string Ma_hanghoa { get => ma_hanghoa; set => ma_hanghoa = value; }
        public string Ten_hanghoa { get => ten_hanghoa; set => ten_hanghoa = value; }
        public string Ma_loaihang { get => ma_loaihang; set => ma_loaihang = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Sdt_ncc { get => sdt_ncc; set => sdt_ncc = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
