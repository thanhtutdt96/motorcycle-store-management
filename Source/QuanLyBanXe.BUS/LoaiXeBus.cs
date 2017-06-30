using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class LoaiXeBus
    {
        LoaiXeDao dao = new LoaiXeDao();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable GetDataById(string id)
        {
            return dao.GetDataById(id);
        }

        public int Insert(LoaiXeDto obj)
        {
            return dao.Insert(obj);
        }

        public int Update(LoaiXeDto obj)
        {
            return dao.Update(obj);
        }

        public int Delete(string id)
        {
            return dao.Delete(id);
        }
    }       
}
