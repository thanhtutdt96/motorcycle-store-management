using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class DichVuDao
    {
        private readonly DataProvider provider = new DataProvider();

        public DataTable GetData()
        {
            return provider.GetData("DichVu_Select_All", null);
        }

        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDV", id)
            };
            return provider.GetData("DichVu_Select_ByMaDV", para);
        }

        public int Insert(DichVuDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TenDV", obj.TenDichVu),
                new SqlParameter("LoaiDV", obj.LoaiDichVu),
                new SqlParameter("DonGia", obj.DonGia)
            };
            return provider.ExecuteSQL("DichVu_Insert", para);
        }

        public int Update(DichVuDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDV", obj.MaDichVu),
                new SqlParameter("TenDV", obj.TenDichVu),
                new SqlParameter("LoaiDV", obj.LoaiDichVu),
                new SqlParameter("DonGia", obj.DonGia)
            };
            return provider.ExecuteSQL("DichVu_Update", para);
        }

        public int Delete(int id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDV", id)
            };
            return provider.ExecuteSQL("DichVu_Delete", para);
        }
    }
}
