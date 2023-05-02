using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaccBUS
    {
        private static NhaccBUS instance;
        public static NhaccBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaccBUS();
                }
                return instance;
            }

        }

        private NhaccBUS()
        {

        }

        public List<Nhacungcap> getallncc()
        {
            return NhaCungCapDAO.Instance.getAllncc();
        }

    }
}
