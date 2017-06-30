using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class PhieuNhapDao
    {
        private readonly DataProvider provider = new DataProvider();

        public DataTable GetData()
        {
            return provider.GetData("PhieuNhap_Select_All", null);
        }

        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieu", id)
            };
            return provider.GetData("PhieuNhap_Select_ByMaPN", para);
        }

        public int Insert(PhieuNhapDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieuNhap", obj.MaPhieu),
                new SqlParameter("MaNhanVien", obj.MaNhanVien),
                new SqlParameter("MaNCC", obj.NgayLap)
            };
            return provider.ExecuteSQL("PhieuNhap_Insert", para);
        }

        public int Update(PhieuNhapDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieuNhap", obj.MaPhieu),
                new SqlParameter("NgayLap", obj.NgayLap)
            };
            return provider.ExecuteSQL("PhieuNhap_Update", para);
        }

        public int Delete(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPhieuNhap", id)
            };
            return provider.ExecuteSQL("PhieuNhap_Delete", para);
        }

        public DataTable GetDataNha()
        {
            return provider.GetData("NhaCungCap_Select_All", null);
        }

        public DataTable GetDataLoaiSp()
        {
            return provider.GetData("LoaiPhieuNhap_Select_All", null);
        }
    }
}
