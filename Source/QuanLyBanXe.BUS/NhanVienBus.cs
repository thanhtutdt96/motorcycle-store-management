using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class NhanVienBus
    {
        private readonly NhanVienDao dao = new NhanVienDao();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable GetDataById(string id)
        {
            return dao.GetDataById(id);
        }

        public int Insert(NhanVienDto obj)
        {
            return dao.Insert(obj);
        }

        public int Update(NhanVienDto obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string id)
        {
            return dao.Delete(id);
        }
    }
}
