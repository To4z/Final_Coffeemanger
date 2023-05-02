using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamDAO();
                }
                return instance;
            }

        }

        private SanPhamDAO()
        {
        }

        public List<Hanghoa> getAllProducts()
        {

            List < Hanghoa > listProducts =  null;

            listProducts = DataProvider.Instance.getAllProdcuts();
            return listProducts;

        }

        public List<Hanghoa> getAllProductsBylikeName(String para)
        {

            List<Hanghoa> listProducts = null;
            listProducts = DataProvider.Instance.getHangHoaByLikeName(para);
            return listProducts;

        }

        public bool deleteProduct(string id)
        {
            return DataProvider.Instance.deleteProduct(id);
        }

        public void insertPRODUCT(String ma_hanghoa, String ten_hanghoa, String ma_loaihoang, String hinh_anh, String sdt_ncc,int soluong, int giasp, String trangthai)
        {
            
                String query = "exec inserthh @ma_hanghoa , @ten_hanghoa , @ma_loaihoang , @hinh_anh , @sdt_ncc , @soluong , @giasp , @trangthai";
                int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ma_hanghoa, ten_hanghoa, ma_loaihoang, hinh_anh, sdt_ncc, soluong, giasp, trangthai });
        }

        public void updateProduct(String ma_hanghoa, String ten_hanghoa, String ma_loaihoang, String hinh_anh, String sdt_ncc, int soluong, int giasp, String trangthai)
        {

            String query = "exec updateHH @ma_hanghoa , @ten_hanghoa , @ma_loaihoang , @hinh_anh , @sdt_ncc , @soluong , @giasp , @trangthai";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ma_hanghoa, ten_hanghoa, ma_loaihoang, hinh_anh, sdt_ncc, soluong, giasp, trangthai });
        }

        public List<Hanghoa> getHangHoaByLikeTENLOAIHANG(String para)
        {
            List<Hanghoa> Hanghoas = null;
            String query = "exec usp_selectbyLOAIHANG @name";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { para });
            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    Hanghoa hh = new Hanghoa(item);
                    Hanghoas.Add(hh);
                }
            }
            return Hanghoas;
        }
    }
}
