using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class HangHoaBUS
    {
        private static HangHoaBUS instance;
        public static HangHoaBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HangHoaBUS();
                }
                return instance;
            }

        }

        public HangHoaBUS()
        {

        }



        public List<Hanghoa> fillterHH(List<Hanghoa> list)
        {
            List<Hanghoa> lists = new List<Hanghoa>();

            foreach (Hanghoa hh in list)
            {
                if (hh.Trangthai.Equals("HOAT DONG"))
                {
                    lists.Add(hh);
                }
            }

            return lists;
        }

        public List<Hanghoa> getAllProducts()
        {
            List<Hanghoa> lists = null;
            lists = SanPhamDAO.Instance.getAllProducts();
            return fillterHH(lists);
        }

        public List<Hanghoa> getFULL()
        {
            List<Hanghoa> lists = null;
            lists = SanPhamDAO.Instance.getAllProducts();
            return lists;
        }

        public List<Hanghoa> getAllProducts(String para)
        {
            List<Hanghoa> lists = null;
            lists = SanPhamDAO.Instance.getAllProductsBylikeName(para);
            return fillterHH(lists);
        }

        public bool deleteProduct(string id)
        {
            return SanPhamDAO.Instance.deleteProduct(id);
        }

        public List<Hanghoa> gethanghoabyTENLOAIHANG(string id)
        {
            return fillterHH(SanPhamDAO.Instance.getHangHoaByLikeTENLOAIHANG(id));
        }

        public void insertPRODUCT(String ma_hanghoa, String ten_hanghoa, String ma_loaihoang, String hinh_anh, String sdt_ncc, int soluong, int giasp, String trangthai)
        {
            SanPhamDAO.Instance.insertPRODUCT(ma_hanghoa, ten_hanghoa, ma_loaihoang, hinh_anh, sdt_ncc, soluong, giasp, trangthai);
        }

        public void updateProduct(String ma_hanghoa, String ten_hanghoa, String ma_loaihoang, String hinh_anh, String sdt_ncc, int soluong, int giasp, String trangthai)
        {
            SanPhamDAO.Instance.updateProduct(ma_hanghoa, ten_hanghoa, ma_loaihoang, hinh_anh, sdt_ncc, soluong, giasp, trangthai);
        }
        


    }
}
