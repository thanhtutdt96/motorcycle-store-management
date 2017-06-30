using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class KhachHangBus
    {
        private readonly KhachHangDao dao = new KhachHangDao();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public int Insert(KhachHangDto obj)
        {
            return dao.Insert(obj);
        }

        public int Update(KhachHangDto obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string id)
        {
            return dao.Delete(id);
        }
    }
}
