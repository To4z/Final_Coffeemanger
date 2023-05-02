using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public  class CalamviecDAO
    {
        private static CalamviecDAO instance;

        public static CalamviecDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CalamviecDAO();
                }
                return instance;
            }

        }

        private CalamviecDAO()
        {

        }

        public List<Calamviec> getAllBan()
        {
            String query = "select * from calamviec";
            List<Calamviec> listban = new List<Calamviec>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Calamviec hh = new Calamviec(item);
                listban.Add(hh);
            }

            return listban;
        }

        public bool delete(string ma_clv)
        {
            String query = "delete from calamviec where ma_clv = @ma_clv";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ma_clv });
            return true;
        }

        public bool insert(string ma_clv , string ten_clv  ,int  gio_BD , int gio_kt   , int sotien)
        {
            String query = "insertclv @ma_clv , @ten_clv  , @gio_BD , @gio_kt   , @sotien";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ma_clv, ten_clv, gio_BD, gio_kt, sotien });
            return true;
        }

        public bool update(string ma_clv, string ten_clv, int gio_BD, int gio_kt, int sotien)
        {
            String query = "updateCLV @ma_clv , @ten_clv  , @gio_BD , @gio_kt   , @sotien";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ma_clv, ten_clv, gio_BD, gio_kt, sotien });
            return true;
        }
    }
}
