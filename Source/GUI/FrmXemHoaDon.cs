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

namespace GUI
{
    /// <summary>
    /// This class use for viewing the saved pay bill in database
    /// </summary>
    public partial class FrmXemHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public FrmXemHoaDon()
        {
            InitializeComponent();
        }

        private HoaDonBus hoaDonBus = new HoaDonBus();
        private ChiTietHoaDonBus cthdBus = new ChiTietHoaDonBus();
        private XeBus xeBus = new XeBus();

        public void LockControl()
        {
            /* Lock the button when load form */
            btnXoa.Enabled = true;
            btnLamMoi.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
        }

        public void UnlockControl()
        {
            /* Unlock the locked button */
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
        }

        public void DisplayHoaDon()
        {
            /* Load data from table HoaDon and display in gridView */
            gridHoaDon.DataSource = hoaDonBus.GetData();
            gridView1.ExpandAllGroups();
        }

        public void DisplayChiTiet()
        {
            /* Load data from table ChiTietHoaDon and display in gridView */
            try
            {
                string maHoaDon =
                    gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaHD"]).ToString();
                gridChiTiet.DataSource = cthdBus.GetDataById(maHoaDon);
            }
            catch
            {
                // ignored
            }
        }

        public void ClearFieldChiTiet()
        {
            /* Clear the data in textbox and spin */
            cbbXe.EditValue = null;
            txtMauSac.Text = string.Empty;
            txtDungTich.Text = string.Empty;
            spinSoLuong.Text = string.Empty;
            spinDonGia.Text = string.Empty;
        }

        public void ClearFieldHoaDon()
        {
            /* Clear the data in textbox and combobox */
            txtNhanVien.Text = string.Empty;
            txtKhachHang.Text = string.Empty;
            spinTongTien.Text = string.Empty;
            dtNgayLap.Value = DateTime.Today;
        }

        private void FrmXemHoaDon_Load(object sender, EventArgs e)
        {
            LockControl();
            DisplayHoaDon();
        }

        private void gridHoaDon_Click(object sender, EventArgs e)
        {
            LockControl();
            DisplayChiTiet();
            /* Display the value of the clicked row to the textbox */
            try
            {
                dtNgayLap.Value =
                    DateTime.Parse(
                        gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["NgayLap"]).ToString());
                spinTongTien.Text =
                    gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TongTien"]).ToString();
                txtKhachHang.Text =
                    gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenKH"]).ToString();
                txtNhanVien.Text =
                    gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenNV"]).ToString();
            }
            catch
            {
                // ignored
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            /* Refresh the data in gridView HoaDon */
            DisplayHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* Delete the unecessary value */
            if (XtraMessageBox.Show("Bạn có muốn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (gridView2.RowCount != 0)
                    {
                        cthdBus.DeleteById(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["MaHD"]).ToString());
                        hoaDonBus.Delete(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaHD"]).ToString());
                        ClearFieldHoaDon();
                        ClearFieldChiTiet();
                        DisplayHoaDon();
                        DisplayChiTiet();
                    }
                    else
                    {
                        hoaDonBus.Delete(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaHD"]).ToString());
                        ClearFieldHoaDon();
                        ClearFieldChiTiet();
                        DisplayHoaDon();
                        DisplayChiTiet();
                    }

                }
                catch
                {
                    XtraMessageBox.Show("Xóa không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* Delete the unecessary value */
            if (XtraMessageBox.Show("Bạn có muốn xóa chi tiết này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    cthdBus.Delete(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["MaHD"]).ToString(), gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["MaXe"]).ToString(), gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["MauSac"]).ToString());
                    ClearFieldChiTiet();
                    DisplayChiTiet();
                }
                catch
                {
                    XtraMessageBox.Show("Xóa không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gridChiTiet_Click(object sender, EventArgs e)
        {
            /* Display the value of the clicked row to the textbox */
            try
            {
                UnlockControl();
                txtMauSac.Text =
                    gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["MauSac"]).ToString();
                txtDungTich.Text =
                    gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["DungTich"]).ToString();
                spinSoLuong.Text =
                    gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["SoLuong"]).ToString();
                spinDonGia.Text =
                    gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["DonGia"]).ToString();
                /* Display the value for the combobox Xe */
                cbbXe.Properties.DataSource =
                    xeBus.GetDataById(
                        gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["MaXe"]).ToString());
                cbbXe.Properties.ValueMember = "MaXe";
                cbbXe.Properties.DisplayMember = "TenXe"; // Name of NhanVien
                cbbXe.EditValue = cbbXe.Properties.GetDataSourceValue(cbbXe.Properties.ValueMember, 0);
            }
            catch
            {
                // ignored
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            /* Delete all the value in gridView ChiTietHoaDon */
            if (XtraMessageBox.Show("Bạn có muốn xóa hết chi tiết không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    cthdBus.DeleteById(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["MaHD"]).ToString());
                    ClearFieldChiTiet();
                    DisplayChiTiet();
                }
                catch
                {
                    XtraMessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}