using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban
    {

        private String maban;
        private String tenban;
        private String makhuvuc;
        private String thuoctinh;

        public Ban(string maban, string tenban, string makhuvuc, string thuoctinh)
        {
            this.maban = maban;
            this.tenban = tenban;
            this.makhuvuc = makhuvuc;
            this.thuoctinh = thuoctinh;
        }

        public Ban(DataRow row)
        {
            this.Maban = row["maban"].ToString();
            this.Thuoctinh = row["trangthai"].ToString();
            this.Makhuvuc = row["makhuvuc"].ToString();
            this.Tenban = row["tenban"].ToString();
        }

        public Ban() { }

        public string Maban { get => maban; set => maban = value; }
        public string Thuoctinh { get => thuoctinh; set => thuoctinh = value; }
        public string Makhuvuc { get => makhuvuc; set => makhuvuc = value; }
        public string Tenban { get => tenban; set => tenban = value; }

    }
}
