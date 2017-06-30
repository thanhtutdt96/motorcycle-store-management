using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanXe.BUS;

namespace GUI
{
    /**
     * This class use for manage the attribute
     * @author Pham Thanh Tu
     * 
     */
    public partial class FrmThuocTinh : DevExpress.XtraEditors.XtraForm
    {
        public FrmThuocTinh()
        {
            InitializeComponent();
        }
        ThuocTinhBus bus = new ThuocTinhBus();

        public void LockControl()
        {
            /* Lock the button when load form */
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHienThi.Enabled = true;
        }

        public void UnlockControl()
        {
            /* Unock the locked button */
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnHienThi.Enabled = false;
        }

        public void Display()
        {
            /* Load data for the gridView */
            gridThuocTinh.DataSource = bus.GetData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            /* Add new value to the database */
            FrmThemThuocTinh ttt = new FrmThemThuocTinh();
            ttt.isInsert = true;
            ttt.refresh += new EventHandler(btnHienThi_Click);
            ttt.ShowInTaskbar = false;
            ttt.ShowDialog();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            /* Display data in the gridView */
            Display();
            UnlockControl();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* Delete the unecessary value */
            if (XtraMessageBox.Show("Bạn có muốn xóa thuộc tính này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaXe"]).ToString();
                    string mauSac = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MauSac"]).ToString();
                    bus.Delete(id, mauSac);
                    gridThuocTinh.DataSource = bus.GetData();
                }
                catch
                {
                    XtraMessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gridThuocTinh_DoubleClick(object sender, EventArgs e)
        {
            /* Edit the choosen value in gridView */
            FrmThemThuocTinh ttt = new FrmThemThuocTinh();
            ttt.isInsert = false;
            ttt.Id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaXe"]).ToString();
            ttt.MauSac = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MauSac"]).ToString();
            ttt.refresh += new EventHandler(btnHienThi_Click);
            ttt.ShowInTaskbar = false;
            ttt.ShowDialog();
        }

        private void frmThuocTinh_Load(object sender, EventArgs e)
        {
            LockControl();
        }
    }
}