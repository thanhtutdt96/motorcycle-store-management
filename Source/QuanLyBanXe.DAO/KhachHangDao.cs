using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class KhachHangDao
    {
        private readonly DataProvider provider=new DataProvider();

        public DataTable GetData()
        {
            return provider.GetData("KhachHang_Select_All", null);
        }

        public int Insert(KhachHangDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TenKH", obj.TenKhachHang),
                new SqlParameter("DiaChi", obj.DiaChi),
                new SqlParameter("SDT", obj.Sdt)
                
            };
            return provider.ExecuteSQL("KhachHang_Insert", para);
        }

        public int Update(KhachHangDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH", obj.MaKhachHang),
                new SqlParameter("TenKH", obj.TenKhachHang),
                new SqlParameter("DiaChi", obj.DiaChi),
                new SqlParameter("SDT", obj.Sdt)
            };
            return provider.ExecuteSQL("KhachHang_Update", para);
        }

        public int Delete(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH", id)
            };
            return provider.ExecuteSQL("KhachHang_Delete", para);
        }
    }
}
