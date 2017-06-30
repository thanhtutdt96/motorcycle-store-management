using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class NhaCungCapBus
    {
        NhaCungCapDao dao = new NhaCungCapDao();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable GetDataById(string id)
        {
            return dao.GetDataById(id);
        }

        public int Insert(NhaCungCapDto obj)
        {
            return dao.Insert(obj);
        }

        public int Update(NhaCungCapDto obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string id)
        {
            return dao.Delete(id);
        }
    }
}
