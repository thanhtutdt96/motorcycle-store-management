using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DTO;

namespace GUI
{
    public partial class FrmDsDichVu : DevExpress.XtraEditors.XtraForm
    {
        public FrmDsDichVu()
        {
            InitializeComponent();
        }
        private DichVuDto obj = new DichVuDto();
        private DichVuBus bus = new DichVuBus();
        private bool isInsert; // determine whether add feature or update feature is choosen

        public void LockControl()
        {
            /* Lock the button and textbox when load form */
            txtTen.Enabled = false;
            cbbLoai.Enabled = false;
            spinDonGia.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }

        public void UnlockControl()
        {
            /* Unlock the locked button and textbox */
            txtTen.Enabled = true;
            cbbLoai.Enabled = true;
            spinDonGia.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
        }

        public void Display()
        {
            /* Load data for the gridView */
            gridControl1.DataSource = bus.GetData();
            gridView1.ExpandAllGroups();
        }

        public void ClearField()
        {
            txtTen.Text = string.Empty;
            cbbLoai.EditValue = null;
            spinDonGia.Text = string.Empty;
        }

        private void FrmDsDichVu_Load(object sender, EventArgs e)
        {
            LockControl();
            Display();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /* Add new value to the database */
            UnlockControl();
            isInsert = true;
            ClearField();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            /* Display the value of the clicked row to the textbox */
            LockControl();
            try
            {
                txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenDV"]).ToString();
                cbbLoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["LoaiDV"]).ToString();
                spinDonGia.Text =
                    gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DonGia"]).ToString();
            }
            catch
            {
                // ignored
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            /* Save new value to the database or update the existing value */
            obj.TenDichVu = txtTen.Text;
            obj.LoaiDichVu = cbbLoai.EditValue.ToString();
            obj.DonGia = int.Parse(spinDonGia.Text);
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
                    XtraMessageBox.Show("Thêm không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    obj.MaDichVu = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaDV"]).ToString());
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            /* Edit the existing value in database */
            UnlockControl();
            isInsert = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* Delete the unecessary value */
            if (XtraMessageBox.Show("Bạn có muốn xóa dịch vụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    bus.Delete(int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaDV"]).ToString()));
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