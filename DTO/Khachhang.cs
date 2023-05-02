using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khachhang
    {
        private String sdt;
        private String ten_kh;
        private int diemtl;
        private String matkhau;
        private String diachi;


        public Khachhang(string sdt, string ten_kh, int diemtl, string password, String diachi)
        {
            this.sdt = sdt;
            this.ten_kh = ten_kh;
            this.diemtl = diemtl;
            this.matkhau = password;
            this.Diachi = diachi;
            

        }

        public Khachhang(DataRow row)
        {
            this.Sdt = row["sdt"].ToString();
            this.Ten_kh = row["ten_kh"].ToString();
            this.Diemtl = (int)row["diemtl"];
            this.Password = row["matkhau"].ToString();
            this.Diachi = row["diachi"].ToString();

        }

        public Khachhang()
        {
        }

        public string Sdt { get => sdt; set => sdt = value; }
        public string Ten_kh { get => ten_kh; set => ten_kh = value; }
        public int Diemtl { get => diemtl; set => diemtl = value; }
        public string Password { get => matkhau; set => matkhau = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
