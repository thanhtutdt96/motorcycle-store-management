using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class XeBus
    {
        XeDao dao = new XeDao();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable GetDataById(string id)
        {
            return dao.GetDataById(id);
        }

        public int Insert(XeDto obj)
        {
            return dao.Insert(obj);
        }

        public int Update(XeDto obj)
        {
            return dao.Update(obj);
        }

        public int Update_SoLuong(XeDto obj)
        {
            return dao.Update_SoLuong(obj);
        }

        public int Delete(string id)
        {
            return dao.Delete(id);
        }

        public DataTable GetDataNcc()
        {
            return dao.GetDataNcc();
        }

        public DataTable GetDataLoaiSp()
        {
            return dao.GetDataLoaiSp();
        }
    }
}
