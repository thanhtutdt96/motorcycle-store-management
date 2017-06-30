using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class HoaDonDichVuBus
    {
        HoaDonDichVuDao dao = new HoaDonDichVuDao();

        public int Insert(HoaDonDichVuDto obj)
        {
            return dao.Insert(obj);
        }

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public int GetHoaDonDichVuId()
        {
            return dao.GetHoaDonDichVuId();
        }
    }
}
