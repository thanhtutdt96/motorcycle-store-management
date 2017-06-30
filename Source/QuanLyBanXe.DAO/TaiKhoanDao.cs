using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class TaiKhoanDao
    {
        DataProvider provider = new DataProvider();

        public DataTable GetData()
        {
            return provider.GetData("TaiKhoan_Select_All", null);
        }

        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ID", id)
            };
            return provider.GetData("TaiKhoan_Select_ById", para);
        }

        public int Insert(TaiKhoanDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ID", obj.Id),
                new SqlParameter("MaNhanVien", obj.MaNhanVien),
                new SqlParameter("MatKhau", obj.MatKhau),
                new SqlParameter("QuyenHan", obj.QuyenHan)
            };
            return provider.ExecuteSQL("TaiKhoan_Insert", para);
        }

        public int Update(TaiKhoanDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ID", obj.Id),
                new SqlParameter("MatKhau", obj.MatKhau),
                new SqlParameter("QuyenHan", obj.QuyenHan)
            };
            return provider.ExecuteSQL("TaiKhoan_Update", para);
        }

        public int Delete(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("ID", id)
            };
            return provider.ExecuteSQL("TaiKhoan_Delete", para);
        }

        public DataTable GetDataNhanVien()
        {
            return provider.GetData("NhanVien_Select_All", null);
        }
    }
}
