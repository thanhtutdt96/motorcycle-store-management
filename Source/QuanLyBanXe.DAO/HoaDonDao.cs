using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class HoaDonDao
    {
        DataProvider provider = new DataProvider();
        public DataTable GetData()
        {
            return provider.GetData("HoaDon_Select_All", null);
        }

        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD", id)
            };
            return provider.GetData("HoaDon_Select_ByMaHD", para);
        }

        public int Insert(HoaDonDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV", obj.MaNhanVien),
                new SqlParameter("MaKH", obj.MaKhachHang),
                new SqlParameter("NgayLap", obj.NgayLap),
                new SqlParameter("TongTien", obj.TongTien)
            };
            return provider.ExecuteSQL("HoaDon_Insert", para);
        }

        public int Delete(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHD", id)
            };
            return provider.ExecuteSQL("HoaDon_Delete", para);
        }

        public int GetHoaDonId()
        {
            return int.Parse(provider.GetData("select max(MaHD) from HoaDon").Rows[0][0].ToString());
        }
    }
}
