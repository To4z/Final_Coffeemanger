using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BuyOnline
    {
        public BuyOnline() { }
        private String mahang;
        private int soluong;
        private String tenkh;
        private String sodienthoai;
        private String diachi;
        private String ngaygiao;
        private String giogiao;


        public BuyOnline(DataRow row)
        {
            this.mahang = row["mahang"].ToString();
            this.soluong = (int)row["soluong"];
            this.tenkh = row["tenkh"].ToString();
            this.sodienthoai = row["sodienthoai"].ToString();
            this.diachi = row["diachi"].ToString();
            this.ngaygiao = row["ngaygiao"].ToString();
            this.giogiao = row["giogiao"].ToString();
        }

        public string Mahang { get => mahang; set => mahang = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Ngaygiao { get => ngaygiao; set => ngaygiao = value; }
        public string Giogiao { get => giogiao; set => giogiao = value; }
    }
}
