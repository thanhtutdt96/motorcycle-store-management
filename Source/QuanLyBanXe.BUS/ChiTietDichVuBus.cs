using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class ChiTietDichVuBus
    {
        private ChiTietDichVuDao dao = new ChiTietDichVuDao();
        public int Insert(ChiTietDichVuDto obj)
        {
            return dao.Insert(obj);
        }
    }
}
