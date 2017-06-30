using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class HoaDonDichVuDao
    {
        DataProvider provider = new DataProvider();
        public DataTable GetData()
        {
            return provider.GetData("HoaDonDichVu_Select_All", null);
        }
        
        public int Insert(HoaDonDichVuDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV", obj.MaNhanVien),
                new SqlParameter("MaKH", obj.MaKhachHang),
                new SqlParameter("NgayLap", obj.NgayLap),
                new SqlParameter("TongTien", obj.TongTien)
            };
            return provider.ExecuteSQL("HoaDonDichVu_Insert", para);
        }

        public int GetHoaDonDichVuId()
        {
            return int.Parse(provider.GetData("select max(MaHDDV) from HoaDonDichVu").Rows[0][0].ToString());
        }
    }
}
