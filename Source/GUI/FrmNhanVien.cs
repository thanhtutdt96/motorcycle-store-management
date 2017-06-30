using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DTO;

namespace GUI
{
    /**
     * This class use for manage the employee
     * @author Pham Thanh Tu
     * 
     */
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        NhanVienBus bus = new NhanVienBus();
        NhanVienDto obj = new NhanVienDto();
        public void LockControl()
        {
            /* Lock the button and textbox when load form */
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtCMND.Enabled = false;
            spinLuong.Enabled = false;
            txtDiaChi.Enabled = false;
            txtChucVu.Enabled = false;
            dtNgayTuyen.Enabled = false;
            
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
            dtNgaySinh.Enabled = true;
            txtCMND.Enabled = true;
            spinLuong.Enabled = true;
            txtDiaChi.Enabled = true;
            txtChucVu.Enabled = true;
            dtNgayTuyen.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
        }

        public void ClearField()
        {
            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty;
            dtNgaySinh.Value = DateTime.Now;
            txtCMND.Text = string.Empty;
            spinLuong.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtChucVu.Text = string.Empty;
            dtNgayTuyen.Value = DateTime.Now;
        }

        public void Display()
        {
            /* Load data for the gridView */
            gridNhanVien.DataSource = bus.GetData();
        }

        private void gridNhanVien_Click(object sender, EventArgs e)
        {
            /* Display the value of the clicked row to the textbox */
            txtMa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaNV"]).ToString();
            txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenNV"]).ToString();
            dtNgaySinh.Value = (DateTime)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["NgaySinh"]);
            txtCMND.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CMND"]).ToString();
            spinLuong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["LuongCoBan"]).ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DiaChi"]).ToString();
            txtChucVu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["ChucVu"]).ToString();
            dtNgayTuyen.Value = (DateTime)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["NgayTuyen"]);
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LockControl();
            Display();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /* Add new value to the database */
            FrmThemNhanVien tnv = new FrmThemNhanVien(this);
            tnv.isInsert = true;
            tnv.ShowInTaskbar = false;
            tnv.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txtMa.Enabled = false;
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* Delete the unecessary value */
            if (XtraMessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                    XtraMessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /* Save new value to the database or update the existing value */
            obj.MaNhanVien = int.Parse(txtMa.Text);
            obj.Ten = txtTen.Text;
            obj.NgaySinh = dtNgaySinh.Value;
            obj.DiaChi = txtDiaChi.Text;
            obj.ChucVu = txtChucVu.Text;
            obj.Cmnd = txtCMND.Text;
            obj.Luong = int.Parse(spinLuong.Text);
            obj.NgayTuyen = dtNgayTuyen.Value;
            bus.Update(obj);
            ClearField();
            Display();
            LockControl();
        }
    }
}