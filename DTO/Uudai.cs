using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Uudai
    {
        private String tenuudai;
        private String trangthai;
        private int tiengiamgia;

        public Uudai(DataRow row)
        {
            this.tenuudai = row["tenuudai"].ToString();
            this.trangthai = row["trangthai"].ToString();
            this.Tiengiamgia = Int32.Parse(row["tiengiamgia"].ToString());

        }

        public Uudai()
        {

        }

        public Uudai(string tenuudai, string trangthai, int tiengiamgia)
        {
            this.tenuudai = tenuudai;
            this.trangthai = trangthai;
            this.tiengiamgia = tiengiamgia;
        }

        public string Tenuudai { get => tenuudai; set => tenuudai = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int Tiengiamgia { get => tiengiamgia; set => tiengiamgia = value; }
    }
}
