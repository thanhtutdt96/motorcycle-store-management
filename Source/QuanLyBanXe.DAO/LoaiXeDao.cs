using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class LoaiXeDao
    {
        private readonly DataProvider provider = new DataProvider();

        public DataTable GetData()
        {
            return provider.GetData("LoaiXe_Select_All", null);
        }

        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLoai", id)
            };
            return provider.GetData("LoaiXe_Select_ByMaLoai", para);
        }

        public int Insert(LoaiXeDto obj)
        {
            SqlParameter[] para = 
            {
                new SqlParameter("MaLoai", obj.MaLoai),
                new SqlParameter("TenLoai", obj.TenLoai)
            };
            return provider.ExecuteSQL("LoaiXe_Insert", para);
        }

        public int Update(LoaiXeDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLoai", obj.MaLoai),
                new SqlParameter("TenLoai", obj.TenLoai)
            };
            return provider.ExecuteSQL("LoaiXe_Update", para);
        }

        public int Delete(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLoai", id)
            };
            return provider.ExecuteSQL("LoaiXe_Delete", para);
        }
    }
}
