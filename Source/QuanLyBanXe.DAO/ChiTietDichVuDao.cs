using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class ChiTietDichVuDao
    {
        private readonly DataProvider provider = new DataProvider();

        public int Insert(ChiTietDichVuDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHDDV", obj.MaHoaDon),
                new SqlParameter("MaDV", obj.MaDichVu),
                new SqlParameter("DonGia", obj.DonGia),
            };
            return provider.ExecuteSQL("ChiTietDichVu_Insert", para);
        }
    }
}
