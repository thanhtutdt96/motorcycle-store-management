using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class ChiTietHoaDonDao
    {
        private readonly DataProvider provider = new DataProvider();

        public int Insert(ChiTietHoaDonDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD", obj.MaHoaDon),
                new SqlParameter("MaXe", obj.MaXe),
                new SqlParameter("MauSac", obj.MauSac),
                new SqlParameter("SoLuong", obj.SoLuong),
                new SqlParameter("DonGia", obj.DonGia),
            };
            return provider.ExecuteSQL("ChiTietHoaDon_Insert", para);
        }

        public int Delete(string id, string maXe, string mauSac)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD", id),
                new SqlParameter("MaXe", maXe),
                new SqlParameter("MauSac", mauSac),

            };
            return provider.ExecuteSQL("ChiTietHoaDon_Delete", para);
        }

        public int DeleteById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD", id),
            };
            return provider.ExecuteSQL("ChiTietHoaDon_Delete_ById", para);
        }

        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD", id)
            };
            return provider.GetData("ChiTietHoaDon_Select_ByMaHD", para);
        }
    }
}
