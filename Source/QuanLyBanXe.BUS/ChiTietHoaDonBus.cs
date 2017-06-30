using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class ChiTietHoaDonBus
    {
        private ChiTietHoaDonDao dao = new ChiTietHoaDonDao();
        public int Insert(ChiTietHoaDonDto obj)
        {
            return dao.Insert(obj);
        }

        public int Delete(string id, string maXe, string mauSac)
        {
            return dao.Delete(id, maXe, mauSac);
        }

        public int DeleteById(string id)
        {
            return dao.DeleteById(id);
        }

        public DataTable GetDataById(string id)
        {
            return dao.GetDataById(id);
        }
    }
}
