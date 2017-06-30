using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DTO;

namespace GUI
{
    /**
     * This class use for manage the product's provider
     * @author Pham Thanh Tu
     * 
     */
    public partial class FrmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        KhachHangDto obj = new KhachHangDto();
        KhachHangBus bus = new KhachHangBus();
        private bool isInsert = false; // determine add feature or update feature is choosen

        public void LockControl()
        {
            /* Lock the button and textbox when load form */
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }

        public void UnlockControl()
        {
            /* Unlock the locked button and textbox */
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
        }

        void Display()
        {
            // Load data for the gridView
            gridKhachHang.DataSource = bus.GetData();
        }

        void ClearField()
        {
            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
        }
      
        private void btnThem_Click(object sender, EventArgs e)
        {
            /* Add new value to the database */
            UnlockControl();
            isInsert = true;
            txtMa.Enabled = false;
            ClearField();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /* Save new value to the database or update the existing value */
            if (isInsert)
            {
                try
                {
                    obj.TenKhachHang = txtTen.Text;
                    obj.DiaChi = txtDiaChi.Text;
                    obj.Sdt = txtDienThoai.Text;
                    bus.Insert(obj);
                    ClearField();
                    Display();
                    LockControl();
                }
                catch
                {
                    XtraMessageBox.Show("Thêm không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    obj.MaKhachHang = int.Parse(txtMa.Text);
                    obj.TenKhachHang = txtTen.Text;
                    obj.DiaChi = txtDiaChi.Text;
                    obj.Sdt = txtDienThoai.Text;
                    bus.Update(obj);
                    ClearField();
                    Display();
                    LockControl();
                }
                catch
                {
                    XtraMessageBox.Show("Sửa không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            /* Edit the clicked value in gridView */
            UnlockControl();
            txtMa.Enabled = false;
            isInsert = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* Delete the unecessary value */
            if (XtraMessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    bus.Delete(txtMa.Text);
                    ClearField();
                    LockControl();
                    Display();
                }
                catch
                {
                    XtraMessageBox.Show("Xóa không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmKhachHang_Load_1(object sender, EventArgs e)
        {
            LockControl();
            Display();
        }

        private void gridKhachHang_Click(object sender, EventArgs e)
        {
            LockControl();
            try
            {
                /* Display the value of the clicked row to the textbox */
                txtMa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaKH"]).ToString();
                txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenKH"]).ToString();
                txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DiaChi"]).ToString();
                txtDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["SDT"]).ToString();
            }
            catch
            {
                // ignored
            }
        }
    }
}