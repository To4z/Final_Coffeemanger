using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhacungcap
    {
        private String sdt;
        private String ten_ncc;
        private String diachi;
        private String trangthai;

        public Nhacungcap()
        {
        }

        public Nhacungcap(string sdt, string ten_ncc, string diachi, string trangthai)
        {
            this.sdt = sdt;
            this.ten_ncc = ten_ncc;
            this.diachi = diachi;
            this.Trangthai = trangthai;
        }

        public Nhacungcap(DataRow row)
        {
            this.sdt = row["sdt"].ToString();
            this.ten_ncc = row["ten_nhacungcap"].ToString();
            this.diachi = row["diachi"].ToString();
            this.Trangthai = row["trangthai"].ToString();

        }

        public string Sdt { get => sdt; set => sdt = value; }
        public string Ten_ncc { get => ten_ncc; set => ten_ncc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
