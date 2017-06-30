using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class NhaCungCapDao
    {
        private readonly DataProvider provider = new DataProvider();

        public DataTable GetData()
        {
            return provider.GetData("NCC_Select_All", null);
        }

        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC", id)
            };
            return provider.GetData("NCC_Select_ByMaNCC", para);
        }

        public int Insert(NhaCungCapDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC", obj.MaNcc),
                new SqlParameter("TenNCC", obj.TenNcc),
                new SqlParameter("DiaChi",obj.DiaChi),
                new SqlParameter("DienThoai",obj.Sdt)
            };
            return provider.ExecuteSQL("NCC_Insert", para);
        }

        public int Update(NhaCungCapDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC", obj.MaNcc),
                new SqlParameter("TenNCC", obj.TenNcc),
                new SqlParameter("DiaChi",obj.DiaChi),
                new SqlParameter("DienThoai",obj.Sdt)
            };
            return provider.ExecuteSQL("NCC_Update", para);
        }

        public int Delete(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC", id)
            };
            return provider.ExecuteSQL("NCC_Delete", para);
        }
    }
}
