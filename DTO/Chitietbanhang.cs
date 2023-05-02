using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chitietbanhang
    {
        private String ma_hd_bh;
        private String ma_hanghoa;
        private int soluong;
        private int thanhtien;
        private String trangthai;
        private String ngaygiao;
        private String giogiao;
        private String diachi;
        private String sodienthoai;


        public Chitietbanhang()
        {
        }

        public Chitietbanhang(string ma_hd_bh, string ma_hanghoa, int soluong, int thanhtien)
        {
            this.Ma_hd_bh = ma_hd_bh;
            this.Ma_hanghoa = ma_hanghoa;
            this.Soluong = soluong;
            this.Thanhtien = thanhtien;
        }


        public Chitietbanhang(DataRow row)
        {
            this.Ma_hd_bh = row["ma_hd_bh"].ToString();
            this.Ma_hanghoa = row["ma_hanghoa"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Thanhtien = (int)row["thanhtien"];

            this.trangthai = row["trangthai"].ToString();
            this.ngaygiao = row["ngaygiao"].ToString();
            this.giogiao = row["giogiao"].ToString();
            this.diachi = row["diachi"].ToString();
            this.sodienthoai = row["sodienthoai"].ToString();

        }

        public Chitietbanhang(string ma_hd_bh, string ma_hanghoa, int soluong, int thanhtien, string trangthai, string ngaygiao, string giogiao, string diachi, string sodienthoai)
        {
            this.ma_hd_bh = ma_hd_bh;
            this.ma_hanghoa = ma_hanghoa;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
            this.trangthai = trangthai;
            this.ngaygiao = ngaygiao;
            this.giogiao = giogiao;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
        }


        public string Ma_hd_bh { get => ma_hd_bh; set => ma_hd_bh = value; }
        public string Ma_hanghoa { get => ma_hanghoa; set => ma_hanghoa = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Ngaygiao { get => ngaygiao; set => ngaygiao = value; }
        public string Giogiao { get => giogiao; set => giogiao = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
    }
}
