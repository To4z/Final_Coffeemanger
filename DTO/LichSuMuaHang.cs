using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class LichSuMuaHang
    {
        private String mahoadon;
        private String TenSanPham;
        private String phoneNumber;
        private int soluong;
        private int Gia;
        private String Ngay;

        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string TenSanPham1 { get => TenSanPham; set => TenSanPham = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia1 { get => Gia; set => Gia = value; }
        public string Ngay1 { get => Ngay; set => Ngay = value; }

        public LichSuMuaHang() { }

        public LichSuMuaHang(string mahoadon, string tenSanPham, string phoneNumber, int soluong, int gia)
        {
            this.Mahoadon = mahoadon;
            TenSanPham1 = tenSanPham;
            this.PhoneNumber = phoneNumber;
            this.Soluong = soluong;
            Gia1 = gia;
        }

        public LichSuMuaHang(DataRow row)
        {
            this.Mahoadon = row["mahoadon"].ToString();
            this.TenSanPham = row["TenSanPham"].ToString();
            this.PhoneNumber = row["phoneNumber"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Gia = (int)row["Gia"];
            this.Ngay = row["Ngay"].ToString();
        }

    }
}
