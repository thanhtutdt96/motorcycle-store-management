using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class TaiKhoanBus
    {
        private readonly TaiKhoanDao dao = new TaiKhoanDao();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable GetDataById(string id)
        {
            return dao.GetDataById(id);
        }

        public int Insert(TaiKhoanDto obj)
        {
            return dao.Insert(obj);
        }

        public int Update(TaiKhoanDto obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string id)
        {
            return dao.Delete(id);
        }

        public DataTable GetDataNhanVien()
        {
            return dao.GetDataNhanVien();
        }
    }
}
