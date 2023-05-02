using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CalamviecBUS
    {
        private static CalamviecBUS instance;
        public static CalamviecBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CalamviecBUS();
                }
                return instance;
            }

        }

        private CalamviecBUS()
        {

        }

        public List<Calamviec> getall()
        {
            return CalamviecDAO.Instance.getAllBan();
        }
    }
}
