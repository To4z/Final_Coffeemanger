using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiHangHoaBUS
    {
        private static LoaiHangHoaBUS instance;
        public static LoaiHangHoaBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiHangHoaBUS();
                }
                return instance;
            }

        }

        public LoaiHangHoaBUS()
        {

        }

        public List<Loaihanghoa> getAll()
        {
            return LoaiHangHoaDAO.Instance.getAll();
        }
    }
}
