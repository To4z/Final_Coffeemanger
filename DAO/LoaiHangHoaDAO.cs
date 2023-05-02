using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiHangHoaDAO
    {
        private static LoaiHangHoaDAO instance;

        public static LoaiHangHoaDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiHangHoaDAO();
                }
                return instance;
            }

        }

        private LoaiHangHoaDAO()
        {

        }

        public List<Loaihanghoa> getAll()
        {
            String query = "select * from loaihanghoa";
            List<Loaihanghoa> listban = new List<Loaihanghoa>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Loaihanghoa hh = new Loaihanghoa(item);
                listban.Add(hh);
            }

            return listban;
        }
    }
}
