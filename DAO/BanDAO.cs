using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BanDAO
    {
        private static BanDAO instance;

        public static BanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BanDAO();
                }
                return instance;
            }

        }

        private BanDAO()
        {

        }

        public List<Ban> getAllBan()
        {
            String query = "select * from ban";
            List<Ban> listban = new List<Ban>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Ban hh = new Ban(item);
                listban.Add(hh);
            }

            return listban;
        }

        public List<infoDanhSachHoaDonTheoBan> getInfoHD_Ban(String maban)
        {
            String query = "infoHDtheoBan @maban";
            List<infoDanhSachHoaDonTheoBan> listban = new List<infoDanhSachHoaDonTheoBan>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maban });
            foreach (DataRow item in data.Rows)
            {
                infoDanhSachHoaDonTheoBan hh = new infoDanhSachHoaDonTheoBan(item);
                listban.Add(hh);
            }

            return listban;
        }

        public List<Ban> getBanTang1()
        {
            List<Ban> listban = new List<Ban>();
            List<Ban> listbanTang1 = new List<Ban>();
            listban = getAllBan();

            foreach(Ban ban in listban)
            {
                if (ban.Makhuvuc.Equals("kv1"))
                {
                    listbanTang1.Add(ban);
                }
            }

            return listbanTang1;
        }

        public List<Ban> getBanTang2()
        {
            List<Ban> listban = new List<Ban>();
            List<Ban> listbanTang1 = new List<Ban>();
            listban = getAllBan();

            foreach (Ban ban in listban)
            {
                if (ban.Makhuvuc.Equals("kv2"))
                {
                    listbanTang1.Add(ban);
                }
            }

            return listbanTang1;
        }

        public List<Ban> getBanTang3()
        {
            List<Ban> listban = new List<Ban>();
            List<Ban> listbanTang1 = new List<Ban>();
            listban = getAllBan();

            foreach (Ban ban in listban)
            {
                if (ban.Makhuvuc.Equals("kv3"))
                {
                    listbanTang1.Add(ban);
                }
            }

            return listbanTang1;
        }

        public bool changeStt(String maban, String trangthai)
        {
            String query = "changeSTTBan @maban , @trangthai";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maban, trangthai });
            return true;

        }
        
        public bool HandleGopBan(String mahdxoa, String mahdgop, String maban)
        {
            String query = "deleteGopBan @mahdxoa , @mahdgop , @maban";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahdxoa, mahdgop, maban });
            return true;
        }

        public bool deleteban( String maban)
        {
            String query = "delete ban where maban = @maban";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {  maban });
            return true;
        }

        public bool insert(String maban , String tenban , String makhuvuc , String trangthai)
        {
            String query = "insert_ban @maban , @tenban , @makhuvuc , @trangthai";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maban, tenban, makhuvuc, trangthai });
            return true;
        }

        public bool update(String maban, String tenban, String makhuvuc, String trangthai)
        {
            String query = "update_ban @maban , @tenban , @makhuvuc , @trangthai";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maban, tenban, makhuvuc, trangthai });
            return true;
        }


        public void chuyenban(String maban1, String maban2, String mahd)
        {
            String query = "ucp_updateChuyenBan @maban1 , @maban2 , @mahd";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maban1, maban2, mahd });
        }

        public List<KhuVuc> getAllKhuVuc()
        {
            String query = "select * from khuvuc";
            List<KhuVuc> listban = new List<KhuVuc>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhuVuc hh = new KhuVuc(item);
                listban.Add(hh);
            }

            return listban;
        }
    }
}
