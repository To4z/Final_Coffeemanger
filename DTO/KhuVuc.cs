using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuVuc
    {
        private String makhuvuc;
        private String tenkhuvuc;
        private String trangthai;

  

        public KhuVuc(string makhuvuc, string tenkhuvuc, string trangthai)
        {
            this.makhuvuc = makhuvuc;
            this.tenkhuvuc = tenkhuvuc;
            this.trangthai = trangthai;
        }
        public KhuVuc(DataRow row)
        {
            this.makhuvuc = row["makhuvuc"].ToString();
            this.tenkhuvuc = row["tenkhuvuc"].ToString();
            this.trangthai = row["trangthai"].ToString();
        }
        public KhuVuc() { }

        public string Makhuvuc { get => makhuvuc; set => makhuvuc = value; }
        public string Tenkhuvuc { get => tenkhuvuc; set => tenkhuvuc = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }

    }
}
