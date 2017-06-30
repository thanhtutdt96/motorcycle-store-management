using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class XeDao
    {
        DataProvider provider = new DataProvider();

        public DataTable GetData()
        {
            return provider.GetData("Xe_Select_All", null);
        }

        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", id)
            };
            return provider.GetData("Xe_Select_ByMaXe", para);
        }

        public int Insert(XeDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", obj.MaXe),
                new SqlParameter("TenXe", obj.TenXe),
                new SqlParameter("LuongTon", obj.LuongTon),
                new SqlParameter("MaLoai", obj.MaLoai),
                new SqlParameter("MaNCC", obj.MaNcc)
            };
            return provider.ExecuteSQL("Xe_Insert", para);
        }

        public int Update(XeDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", obj.MaXe),
                new SqlParameter("TenXe", obj.TenXe),
                new SqlParameter("LuongTon", obj.LuongTon),
                new SqlParameter("MaLoai", obj.MaLoai),
                new SqlParameter("MaNCC", obj.MaNcc)
            };
            return provider.ExecuteSQL("Xe_Update", para);
        }

        public int Update_SoLuong(XeDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", obj.MaXe),
                new SqlParameter("LuongTon", obj.LuongTon),
            };
            return provider.ExecuteSQL("Xe_Update_SoLuong", para);
        }

        public int Delete(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", id)
            };
            return provider.ExecuteSQL("Xe_Delete", para);
        }

        public DataTable GetDataNcc()
        {
            return provider.GetData("NCC_Select_All", null);
        }

        public DataTable GetDataLoaiSp()
        {
            return provider.GetData("LoaiXe_Select_All", null);
        }
    }
}
