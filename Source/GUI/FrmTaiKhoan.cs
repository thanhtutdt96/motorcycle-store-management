using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DTO;

namespace GUI
{
    /**
     * This class use for manage the log in account
     * @author Pham Thanh Tu
     * 
     */
    public partial class FrmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private readonly TaiKhoanBus bus = new TaiKhoanBus();
        private TaiKhoanDto dto = new TaiKhoanDto();
        private readonly TaiKhoanDto obj=new TaiKhoanDto();
        private bool isInsert; // determine whether add feature or update feature is choosen

        public void LockControl()
        {
            /* Lock the button and textbox when load form */
            cbbNhanVien.Enabled = false;
            txtID.Enabled = false;
            cbbChucVu.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            layoutControlItem9.Visibility = LayoutVisibility.Never;
        }

        public void UnlockControl()
        {
            /* Unlock the locked button and textbox */
            cbbNhanVien.Enabled = true;
            txtID.Enabled = true;
            cbbChucVu.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            layoutControlItem9.Visibility = LayoutVisibility.Always;
        }

        public void ClearField()
        {
            txtID.Text = string.Empty;
            cbbNhanVien.EditValue = null;
            cbbChucVu.EditValue = null;
        }

        public void Display()
        {
            /* Load data for the gridView */
            gridTaiKhoan.DataSource = bus.GetData();
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            LockControl();
            Display();
            /* Display the value for the combobox NhanVien */
            cbbNhanVien.Properties.DataSource = bus.GetDataNhanVien();
            cbbNhanVien.Properties.ValueMember = "MaNhanVien";
            cbbNhanVien.Properties.DisplayMember = "Ten";
        }
        
        private void gridTaiKhoan_Click(object sender, EventArgs e)
        {
            /* Display the value of the clicked row to the textbox */
            try
            {
                txtID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["ID"]).ToString();
                cbbNhanVien.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaNhanVien"]).ToString();
                cbbChucVu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["PhanQuyen"]).ToString();
                txtPass.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MatKhau"]).ToString();
            }
            catch
            {
                // ignored}
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /* Add new value to the database */
            UnlockControl();
            isInsert = true;
            ClearField();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            /* Edit the existing value in database */
            UnlockControl();
            txtID.Enabled = false;
            cbbNhanVien.Enabled = false;
            isInsert = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /* Save new value to the database or update the existing value */
            obj.Id = txtID.Text;
            obj.MaNhanVien = cbbNhanVien.EditValue.ToString();
            obj.MatKhau = txtPass.Text;
            obj.QuyenHan = cbbChucVu.EditValue.ToString();
            if (isInsert)
            {
                try
                {
                    bus.Insert(obj);
                    ClearField();
                    Display();
                    LockControl();
                }
                catch
                {
                    XtraMessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    bus.Update(obj);
                    ClearField();
                    Display();
                    LockControl();
                }
                catch
                {
                    XtraMessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* Delete the unecessary value */
            if (XtraMessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    bus.Delete(txtID.Text);
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
    }
}