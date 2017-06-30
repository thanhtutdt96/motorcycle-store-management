using System.Data;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace QuanLyBanXe.BUS
{
    public class ThuocTinhBus
    {
        ThuocTinhDao dao = new ThuocTinhDao();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable GetDataById(string id)
        {
            return dao.GetDataById(id);
        }

        public DataTable GetDataByThuocTinh(string id, string thuocTinh)
        {
            return dao.GetDataByThuocTinh(id, thuocTinh);
        }
        public int Insert(ThuocTinhDto obj)
        {
            return dao.Insert(obj);
        }

        public int Update(ThuocTinhDto obj)
        {
            return dao.Update(obj);
        }

        public int Update_SoLuong(ThuocTinhDto obj)
        {
            return dao.Update_SoLuong(obj);
        }

        public int Delete(string id, string thuoctinh)
        {
            return dao.Delete(id, thuoctinh);
        }

        public DataTable GetDataXe()
        {
            return dao.GetDataXe();
        }
    }
}
