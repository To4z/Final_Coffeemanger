using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BanBUS
    {
        private static BanBUS instance;
        public static BanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BanBUS();
                }
                return instance;
            }

        }

        private BanBUS()
        {

        }

        public List<Ban> getAll1()
        {
            return BanDAO.Instance.getBanTang1();
        }

        public List<Ban> getAll2()
        {
            return BanDAO.Instance.getBanTang2();
        }

        public List<Ban> getAll3()
        {
            return BanDAO.Instance.getBanTang3();
        }

        public List<Ban> getAll()
        {
            List<Ban> listAll = new List<Ban>();

            List<Ban> listAll1 = getAll3();
                List<Ban> listAll2 = getAll2();
            List<Ban> listAll3 = getAll1();
            List<Ban> mergedList = listAll1.Concat(listAll2).ToList();
            listAll = mergedList.Concat(listAll3).ToList();

            foreach(Ban ban in listAll.ToList())
            {
                if (ban.Thuoctinh.Equals("0"))
                {
                    listAll.Remove(ban);
                }
                
            }

            return listAll;
        }

        public List<Ban> getAll0()
        {
            List<Ban> listAll = new List<Ban>();

            List<Ban> listAll1 = getAll3();
            List<Ban> listAll2 = getAll2();
            List<Ban> listAll3 = getAll1();
            List<Ban> mergedList = listAll1.Concat(listAll2).ToList();
            listAll = mergedList.Concat(listAll3).ToList();

            foreach (Ban ban in listAll.ToList())
            {
                if (ban.Thuoctinh.Equals("1"))
                {
                    listAll.Remove(ban);
                }

            }

            return listAll;
        }

        public List<infoDanhSachHoaDonTheoBan> getHD_BAN(String maban)
        {
            return BanDAO.Instance.getInfoHD_Ban(maban);
        }

        public List<Ban> getAll1111()
        {
            List<Ban> listAll = new List<Ban>();

            List<Ban> listAll1 = getAll3();
            List<Ban> listAll2 = getAll2();
            List<Ban> listAll3 = getAll1();
            List<Ban> mergedList = listAll1.Concat(listAll2).ToList();
            listAll = mergedList.Concat(listAll3).ToList();

            return listAll;
        }

        public Boolean changeStt(String maban, String trangthai)
        {
            return BanDAO.Instance.changeStt(maban, trangthai);
        }

        public void chuyenban(String maban1, String maban2, String mahd)
        {
            BanDAO.Instance.chuyenban(maban1, maban2, mahd);
        }
        
        public void HandleGopBan(String mahdxoa, String mahdgop, String maban)
        {
            BanDAO.Instance.HandleGopBan(mahdxoa, mahdgop, maban);
        }
        
    }
}
