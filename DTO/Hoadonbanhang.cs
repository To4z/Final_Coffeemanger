using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoadonbanhang
    {
        private String ma_hd_bh;
        private String sdt_nv;
        private String sdt_kh;
        private String maban;
        private DateTime ngay_hd_bh;
        private int tongtien;
        private int diemtl;
        private int giamgia;

        private String trangthai;

        public Hoadonbanhang()
        {
        }

        public Hoadonbanhang(DataRow row)
        {
            this.Ma_hd_bh = row["ma_hd_bh"].ToString();
            this.Sdt_nv = row["sdt_nv"].ToString();
            this.Sdt_kh = row["sdt_kh"].ToString();
            this.Maban = row["maban"].ToString();
            this.Ngay_hd_bh = (DateTime)row["ngay_hd_bh_check_in"];
            this.Tongtien = (int)row["tongtien"];
            this.Diemtl = 0;
            this.Giamgia = 0;
            this.Trangthai = row["trangthai"].ToString();    
        }

        public Hoadonbanhang(string ma_hd_bh, string sdt_nv, string sdt_kh, string maban, DateTime ngay_hd_bh, int tongtien, int diemtl, int giamgia, String trangthai)
        {
            this.Ma_hd_bh = ma_hd_bh;
            this.Sdt_nv = sdt_nv;
            this.Sdt_kh = sdt_kh;
            this.Maban = maban;
            this.Ngay_hd_bh = ngay_hd_bh;
            this.Tongtien = tongtien;
            this.Diemtl = diemtl;
            this.Giamgia = giamgia;
            this.Trangthai = trangthai;
        }

        public string Ma_hd_bh { get => ma_hd_bh; set => ma_hd_bh = value; }
        public string Sdt_nv { get => sdt_nv; set => sdt_nv = value; }
        public string Sdt_kh { get => sdt_kh; set => sdt_kh = value; }
        public string Maban { get => maban; set => maban = value; }
        public DateTime Ngay_hd_bh { get => ngay_hd_bh; set => ngay_hd_bh = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public int Diemtl { get => diemtl; set => diemtl = value; }
        public int Giamgia { get => giamgia; set => giamgia = value; }

        public String Trangthai { get => trangthai; set => trangthai = value; }
    }
}
