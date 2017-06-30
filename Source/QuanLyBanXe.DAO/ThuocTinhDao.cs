using System.Data;
using System.Data.SqlClient;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.DAO
{
    public class ThuocTinhDao
    {
        DataProvider provider = new DataProvider();

        public DataTable GetData()
        {
            return provider.GetData("ThuocTinh_Select_All", null);
        }

        public DataTable GetDataByThuocTinh(string id, string mauSac)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", id),
                new SqlParameter("MauSac", mauSac), 
            };
            return provider.GetData("ThuocTinh_Select_ByThuocTinh", para);
        }

        public DataTable GetDataById(string id)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", id)
            };
            return provider.GetData("ThuocTinh_Select_ByMaXe", para);
        }

        public int Insert(ThuocTinhDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", obj.MaXe),
                new SqlParameter("MauSac",obj.MauSac),
                new SqlParameter("DungTich",obj.DungTich),
                new SqlParameter("SoLuong", obj.SoLuong),
                new SqlParameter("DonGia", obj.DonGia)
            };
            return provider.ExecuteSQL("ThuocTinh_Insert", para);
        }

        public int Update(ThuocTinhDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", obj.MaXe),
                new SqlParameter("MauSac",obj.MauSac),
                new SqlParameter("DungTich",obj.DungTich),
                new SqlParameter("SoLuong", obj.SoLuong),
                new SqlParameter("DonGia", obj.DonGia)
            };
            return provider.ExecuteSQL("ThuocTinh_Update", para);
        }

        public int Update_SoLuong(ThuocTinhDto obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", obj.MaXe),
                new SqlParameter("MauSac", obj.MauSac),
                new SqlParameter("SoLuong", obj.SoLuong),
            };
            return provider.ExecuteSQL("ThuocTinh_Update_SoLuong", para);
        }

        public int Delete(string id, string mauSac)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaXe", id),
                new SqlParameter("MauSac", mauSac)
            };
            return provider.ExecuteSQL("ThuocTinh_Delete", para);
        }

        public DataTable GetDataXe()
        {
            return provider.GetData("Xe_Select_All", null);
        }
    }
}
