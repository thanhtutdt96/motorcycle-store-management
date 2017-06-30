using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class HoaDonBus
    {
        HoaDonDao dao = new HoaDonDao();

        public int Insert(HoaDonDto obj)
        {
            return dao.Insert(obj);
        }

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public int GetHoaDonId()
        {
            return dao.GetHoaDonId();
        }

        public int Delete(string id)
        {
            return dao.Delete(id);
        }
    }
}
