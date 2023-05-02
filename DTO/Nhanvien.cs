using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhanvien
    {
        private String sdt;
        private String ten_nv;
        private bool gioitinh;
        private String chucvu;
        private DateTime ngayvaolam;
        private String diachi;
        private bool trangthai;
        private bool phanquen;
        private String matkhau;
        private String calam;

        public Nhanvien(string sdt, string ten_nv, bool gioitinh, string chucvu, DateTime ngayvaolam, string diachi, bool phanquen, string matkhau, String calam)
        {
            this.sdt = sdt;
            this.ten_nv = ten_nv;
            this.gioitinh = gioitinh;
            this.chucvu = chucvu;
            this.ngayvaolam = ngayvaolam;
            this.phanquen = phanquen;
            this.matkhau = matkhau;
            this.calam = calam;
        }

        public Nhanvien(DataRow row)
        {
            this.sdt = row["sdt"].ToString();
            this.ten_nv = row["ten_nv"].ToString();
            this.gioitinh = (bool)row["gioitinh"];
            this.chucvu = row["chucvu"].ToString();
            this.ngayvaolam = (DateTime)row["ngayvaolam"];
            this.phanquen = (bool)row["phanquyen"];
            this.matkhau = row["matkhau"].ToString();
            this.calam = row["calam"].ToString();
            this.Diachi = row["diachi"].ToString();
        }

        public Nhanvien()
        {

        }



        public string Sdt { get => sdt; set => sdt = value; }
        public string Ten_nv { get => ten_nv; set => ten_nv = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public DateTime Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
        public bool Phanquyen { get => phanquen; set => phanquen = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Calam { get => calam; set => calam = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}