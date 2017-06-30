using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class DichVuBus
    {
        DichVuDao dao = new DichVuDao();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable GetDataById(string id)
        {
            return dao.GetDataById(id);
        }

        public int Insert(DichVuDto obj)
        {
            return dao.Insert(obj);
        }

        public int Update(DichVuDto obj)
        {
            return dao.Update(obj);
        }

        public int Delete(int id)
        {
            return dao.Delete(id);
        }
    }
}
