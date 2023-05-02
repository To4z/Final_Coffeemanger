using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        public static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapDAO();
                }
                return instance;
            }

        }

        private NhaCungCapDAO()
        {

        }

        public List<Nhacungcap> getAllncc()
        {
            String query = "select * from nhacungcap";
            List<Nhacungcap> listban = new List<Nhacungcap>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Nhacungcap hh = new Nhacungcap(item);
                listban.Add(hh);
            }

            return listban;
        }

        public bool insert(string sdt, string ten_nhacungcap, string diachi, string trangthai)
        {
            String query = "insert_ncc @sdt , @ten_nhacungcap , @diachi , @trangthai";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdt, ten_nhacungcap, diachi, trangthai });
            return true;
        }

        public bool update(string sdt, string ten_nhacungcap, string diachi, string trangthai)
        {
            String query = "update_ncc @sdt , @ten_nhacungcap , @diachi , @trangthai";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdt, ten_nhacungcap, diachi, trangthai });
            return true;
        }

    }
}
