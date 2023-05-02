using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Calamviec
    {
        private String ma_clv;
        private String ten_clv;
        private int giobatdau;
        private int gioketthuc;
        private int sotien;

        public Calamviec()
        {
        }

        public Calamviec(DataRow row)
        {
            this.Ma_clv = row["ma_clv"].ToString();
            this.Ten_clv = row["ten_clv"].ToString();
            this.Giobatdau = (int)row["gio_BD"];
            this.Gioketthuc = (int)row["gio_kt"];
            this.Sotien = (int)row["sotien"];
        }

        public Calamviec(string ma_clv, string ten_clv, int giobatdau, int gioketthuc, int sotien)
        {
            this.Ma_clv = ma_clv;
            this.Ten_clv = ten_clv;
            this.Giobatdau = giobatdau;
            this.Gioketthuc = gioketthuc;
            this.Sotien = sotien;
        }

        public string Ma_clv { get => ma_clv; set => ma_clv = value; }
        public string Ten_clv { get => ten_clv; set => ten_clv = value; }
        public int Giobatdau { get => giobatdau; set => giobatdau = value; }
        public int Gioketthuc { get => gioketthuc; set => gioketthuc = value; }
        public int Sotien { get => sotien; set => sotien = value; }
    }
}
