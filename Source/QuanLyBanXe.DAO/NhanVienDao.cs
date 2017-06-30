using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class NhanVienDao
    {
        private readonly DataProvider provider = new DataProvider();

        public DataTable GetData()
        {
            return provider.GetData("NhanVien_Select_All", null);
        }

        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV", id)
            };
            return provider.GetData("NhanVien_Select_ByMaNV", para);
        }

        public int Insert(NhanVienDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TenNV", obj.Ten),
                new SqlParameter("NgaySinh",obj.NgaySinh),
                new SqlParameter("DiaChi",obj.DiaChi),
                new SqlParameter("CMND",obj.Cmnd),
                new SqlParameter("ChucVu",obj.ChucVu),
                new SqlParameter("LuongCoBan",obj.Luong),
                new SqlParameter("NgayTuyen",obj.NgayTuyen)
            };
            return provider.ExecuteSQL("NhanVien_Insert", para);
        }

        public int Update(NhanVienDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV", obj.MaNhanVien),
                new SqlParameter("TenNV", obj.Ten),
                new SqlParameter("NgaySinh",obj.NgaySinh),
                new SqlParameter("DiaChi",obj.DiaChi),
                new SqlParameter("CMND",obj.Cmnd),
                new SqlParameter("ChucVu",obj.ChucVu),
                new SqlParameter("LuongCoBan",obj.Luong),
                new SqlParameter("NgayTuyen",obj.NgayTuyen)
            };
            return provider.ExecuteSQL("NhanVien_Update", para);
        }

        public int Delete(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV", id)
            };
            return provider.ExecuteSQL("NhanVien_Delete", para);
        }
    }
}
