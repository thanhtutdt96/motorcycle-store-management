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
using DevExpress.XtraReports.UI;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace GUI
{
    public partial class FrmHoaDonDichVu : XtraForm
    {
        public FrmHoaDonDichVu()
        {
            InitializeComponent();
        }

        private HoaDonDichVuDto hddv = new HoaDonDichVuDto();
        private ChiTietDichVuDto ctdv = new ChiTietDichVuDto();
        private DichVuBus dichVuBus = new DichVuBus();
        private NhanVienBus nhanVienBus = new NhanVienBus();
        private KhachHangBus khachHangBus = new KhachHangBus();
        private HoaDonDichVuBus hddvBus = new HoaDonDichVuBus();
        private ChiTietDichVuBus ctdvBus = new ChiTietDichVuBus();
        DataTable table = new DataTable();
        private int count = 0;
        private int tien = 0;
        private int demSoLanXoa = 0;

        public void LockControl()
        {
            /* Lock the button when load form */
            btnThem.Enabled = false;
            btnThanhToan.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void UnlockControl()
        {
            /* Unlock the locked button */
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnThanhToan.Enabled = true;
        }

        public void DisplayDichVu()
        {
            /* Load data from table Xe and display in gridView */
            gridDichVu.DataSource = dichVuBus.GetData();
            gridView1.ExpandAllGroups();
        }
        public void Clear()
        {
            /* Clear thanh toan gridView after paying successful*/
            while (gridView2.RowCount != 0)
            {
                gridView2.SelectAll();
                gridView2.DeleteSelectedRows();
            }
            cbbKhachHang.EditValue = null;
            txtTongTien.Text = string.Empty;
            gridView1.Focus();
        }
        public void Print()
        {
            /* Print receipt */
            DataProvider provider = new DataProvider();
            DataTable table = new DataTable();
            table = provider.GetData("select * from ReportDV where MaHDDV = '" + hddvBus.GetHoaDonDichVuId() + "'");
            XtraReportDV report = new XtraReportDV();
            report.DataSource = table;
            report.ShowPreviewDialog();
        }

        private void FrmHoaDonDichVu_Load(object sender, EventArgs e)
        {
            LockControl();
            DisplayDichVu();
            /* Display the value for the combobox NhanVien */
             
            cbbNhanVien.Properties.DataSource = nhanVienBus.GetDataById(FrmHoaDon.MaNhanVien);
            cbbNhanVien.Properties.ValueMember = "MaNV";
            cbbNhanVien.Properties.DisplayMember = "TenNV"; // Name of NhanVien
            cbbNhanVien.EditValue = cbbNhanVien.Properties.GetDataSourceValue(cbbNhanVien.Properties.ValueMember, 0);
            /* Display the value for the combobox KhachHang */
            cbbKhachHang.Properties.DataSource = khachHangBus.GetData();
            cbbKhachHang.Properties.ValueMember = "MaKH";
            cbbKhachHang.Properties.DisplayMember = "TenKH"; // Name of NhanVien
        }

        private void gridDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                btnThem.Enabled = true;
                txtDichVu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenDV"]).ToString();
                spinDonGia.Text =
                    gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DonGia"]).ToString();
            }
            catch
            {
                // ignored
            }
        }

        private void gridThanhToan_Load(object sender, EventArgs e)
        {
            /* Load data DichVu and display in gridView */
            table.Columns.Add("MaDV", typeof(int));
            table.Columns.Add("TenDV", typeof(string));
            table.Columns.Add("LoaiDV", typeof(string));
            table.Columns.Add("DonGia", typeof(int));
            gridThanhToan.DataSource = table;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (demSoLanXoa != 0)
            {
                tien = 0;
                count = 0;
            }
            /* Transfer the item choosen from gridView Xe to pay bill */
            UnlockControl();
            string maDv = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaDV"]).ToString();
            string tenDv = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenDV"]).ToString();
            string loaiDv = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["LoaiDV"]).ToString();
            int donGia = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DonGia"]).ToString());
            table.Rows.Add(maDv, tenDv, loaiDv, donGia);
            gridThanhToan.DataSource = table;

            for (int i = count; i < gridView2.RowCount; i++)
            {
                tien = tien + int.Parse(gridView2.GetRowCellValue(i, "DonGia").ToString());
                if (gridView2.RowCount == 0)
                {
                    tien = 0;
                }
            }
            count++;
            txtTongTien.Text = tien.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            demSoLanXoa++;
            int tien = 0;
            /* Delete value in gridView Thanh Toan */
            int index = gridView2.FocusedRowHandle;
            table.Rows.RemoveAt(index);
            gridThanhToan.DataSource = table;
            for (int k = 0; k < gridView2.RowCount; k++)
            {
                tien = tien + int.Parse(gridView2.GetRowCellValue(k, "DonGia").ToString());
            }
            txtTongTien.Text = tien.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn thanh toán hóa đơn dịch vụ này không?", "Xác nhận thanh toán",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                /* Remind user to choose customer */
                if (cbbKhachHang.Text == string.Empty)
                {
                    XtraMessageBox.Show("Bạn chưa chọn khách hàng thanh toán", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                tien = 0;
                count = 0;
                /* Save data HoaDon */
                hddv.MaNhanVien = FrmHoaDon.MaNhanVien;
                hddv.NgayLap = DateTime.Today;
                hddv.MaKhachHang = int.Parse(cbbKhachHang.EditValue.ToString());
                hddv.TongTien = int.Parse(txtTongTien.Text);
                /* Print receipt implement */
                if (hddvBus.Insert(hddv) > 0)
                {
                    DialogResult tt = XtraMessageBox.Show("Hóa đơn đã được lưu. Bạn có muốn in phiếu thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (tt == DialogResult.Yes)
                    {
                        try
                        {
                            for (int i = 0; i < gridView2.RowCount; i++)
                            {
                                /* Save data ChiTietHoaDon */
                                ctdv.MaHoaDon = hddvBus.GetHoaDonDichVuId();
                                ctdv.MaDichVu = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["MaDV"]).ToString());
                                ctdv.DonGia = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["DonGia"]).ToString());
                                ctdvBus.Insert(ctdv);
                            }
                            /* Print receipt */
                            Print();
                            Clear();
                            LockControl();
                            btnThem.Enabled = true;
                            XtraMessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        try
                        {
                            tien = 0;
                            count = 0;
                            for (int i = 0; i < gridView2.RowCount; i++)
                            {
                                /* Save data ChiTietHoaDon */
                                ctdv.MaHoaDon = hddvBus.GetHoaDonDichVuId();
                                ctdv.MaDichVu = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["MaDV"]).ToString());
                                ctdv.DonGia = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["DonGia"]).ToString());
                                ctdvBus.Insert(ctdv);
                            }
                            Clear();
                            LockControl();
                            btnThem.Enabled = true;
                            XtraMessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            FrmKhachHang kh = new FrmKhachHang();
            kh.ShowInTaskbar = false; // Hide windows icon in taskbar
            kh.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            /* Refresh value for the combobox KhachHang */
            cbbKhachHang.Properties.DataSource = khachHangBus.GetData();
        }
    }
}