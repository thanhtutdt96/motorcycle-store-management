using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DAO;
using QuanLyBanXe.DTO;

namespace GUI
{
    /// <summary>
    /// This class use for viewing the saved pay bill in database
    /// </summary>
    public partial class FrmHoaDon : XtraForm
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private NhanVienBus nhanVienBus = new NhanVienBus();
        private XeBus xeBus = new XeBus();
        private HoaDonBus hoaDonBus = new HoaDonBus();
        private ThuocTinhBus thuocTinhBus = new ThuocTinhBus();
        private KhachHangBus khachHangBus = new KhachHangBus();
        private ChiTietHoaDonBus cthdBus = new ChiTietHoaDonBus();
        private KhachHangDto khach = new KhachHangDto();
        private HoaDonDto hoadon = new HoaDonDto();
        private ChiTietHoaDonDto cthd = new ChiTietHoaDonDto();
        private XeDto xe = new XeDto();
        private ThuocTinhDto thuoctinh = new ThuocTinhDto();
        DataTable table = new DataTable();
        private int count = 0;
        private int tien = 0;
        private int demSoLanXoa = 0;

        /* Data taken from log in */
        public static string Id;
        public static string ChucVu;
        public static string MaNhanVien;

        public void LockControl()
        {
            /* Lock the button when load form */
            btnThem.Enabled = false;
            btnThanhToan.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;
        }

        public void UnlockControl()
        {
            /* Unlock the locked button */
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnThanhToan.Enabled = true;
            btnLamMoi.Enabled = true;
        }
        public void DisplayXe()
        {
            /* Load data from table Xe and display in gridView */
            gridXe.DataSource = xeBus.GetData();
            gridView1.ExpandAllGroups();
        }
        public void DisplayThuocTinh()
        {
            /* Load data from table ThuocTinh and display in gridView */
            string maXe = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaXe"]).ToString();
            gridThuocTinh.DataSource = thuocTinhBus.GetDataById(maXe);
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LockControl();
            DisplayXe();
            /* Display the value for the combobox NhanVien */
            cbbNhanVien.Properties.DataSource = nhanVienBus.GetDataById(MaNhanVien);
            cbbNhanVien.Properties.ValueMember = "MaNV";
            cbbNhanVien.Properties.DisplayMember = "TenNV"; // Name of NhanVien
            cbbNhanVien.EditValue = cbbNhanVien.Properties.GetDataSourceValue(cbbNhanVien.Properties.ValueMember, 0);
            /* Display the value for the combobox KhachHang */
            cbbKhachHang.Properties.DataSource = khachHangBus.GetData();
            cbbKhachHang.Properties.ValueMember = "MaKH";
            cbbKhachHang.Properties.DisplayMember = "TenKH"; // Name of NhanVien
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
            string maXe = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaXe"]).ToString();
            string tenXe = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenXe"]).ToString();
            string mauSac = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["MauSac"]).ToString();
            string dungTich = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["DungTich"]).ToString();
            int donGia = int.Parse(gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["DonGia"]).ToString());
            int soLuong = int.Parse(spinSoLuong.Text);
            int thanhTien = soLuong * donGia;
            int luongTon = int.Parse(gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["SoLuong"]).ToString());
            int luongTonXe = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["LuongTon"]).ToString());
            table.Rows.Add(maXe, tenXe, mauSac, dungTich, donGia, soLuong, thanhTien, luongTon, luongTonXe);
            gridThanhToan.DataSource = table;

            for (int i = count; i < gridView2.RowCount; i++)
            {
                tien = tien + int.Parse(gridView2.GetRowCellValue(i, "ThanhTien").ToString());
                if (gridView2.RowCount == 0)
                {
                    tien = 0;
                }
            }
            count++;
            txtTongTien.Text = tien.ToString();
        }

        private void gridSanPham_Click(object sender, EventArgs e)
        {
            /* Display the value of the clicked row to the textbox */
            try
            {
                DisplayThuocTinh();
                btnThem.Enabled = true;
                txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenXe"]).ToString();
                txtNCC.Text =
                    gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenNCC"]).ToString();
            }
            catch
            {
                // ignored
            }
        }

        private void gridThanhToan_Load(object sender, EventArgs e)
        {
            /* Load data from both table Xe and ThuocTinh and display in gridView */
            table.Columns.Add("MaXe", typeof(string));
            table.Columns.Add("TenXe", typeof(string));
            table.Columns.Add("MauSac", typeof(string));
            table.Columns.Add("DungTich", typeof(string));
            table.Columns.Add("DonGia", typeof(int));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("ThanhTien", typeof(int));
            table.Columns.Add("LuongTon", typeof(int));
            table.Columns.Add("LuongTonXe", typeof(int));
            gridThanhToan.DataSource = table;
        }

        private void gridThuocTinh_Click(object sender, EventArgs e)
        {
            /* Display data ThuocTinh in each Xe */
            try
            {
                txtDungTich.Text =
                    gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["DungTich"]).ToString();
                txtMauSac.Text =
                    gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["MauSac"]).ToString();
            }
            catch
            {
                // ignored
            }
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
                tien = tien + int.Parse(gridView2.GetRowCellValue(k, "ThanhTien").ToString());
            }
            txtTongTien.Text = tien.ToString();
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
        }

        public void Print()
        {
            /* Print receipt */
            DataProvider provider = new DataProvider();
            DataTable table = new DataTable();
            table = provider.GetData("select * from Reports where MaHD = '" + hoaDonBus.GetHoaDonId() + "'");
            XtraReport report = new XtraReport();
            report.DataSource = table;
            report.ShowPreviewDialog();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            /* Clear the gridView ThanhToan */
            DialogResult dr = XtraMessageBox.Show("Bạn có muốn xóa hết xe và tạo hóa đơn mới không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Clear();
            }
            else
            {

            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có chắc chắn thanh toán hóa đơn này không?", "Xác nhận thanh toán",
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
                hoadon.MaNhanVien = MaNhanVien;
                hoadon.NgayLap = DateTime.Today;
                hoadon.MaKhachHang = int.Parse(cbbKhachHang.EditValue.ToString());
                hoadon.TongTien = int.Parse(txtTongTien.Text);
                /* Print receipt implement */
                if (hoaDonBus.Insert(hoadon) > 0)
                {
                    DialogResult tt = XtraMessageBox.Show("Hóa đơn đã được lưu. Bạn có muốn in phiếu thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (tt == DialogResult.Yes)
                    {
                        try
                        {
                            for (int i = 0; i < gridView2.RowCount; i++)
                            {
                                /* Save data ChiTietHoaDon */
                                cthd.MaHoaDon = hoaDonBus.GetHoaDonId();
                                cthd.MaXe = gridView2.GetRowCellValue(i, gridView2.Columns["MaXe"]).ToString();
                                cthd.MauSac = gridView2.GetRowCellValue(i, gridView2.Columns["MauSac"]).ToString();
                                cthd.SoLuong =
                                    int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoLuong"]).ToString());
                                cthd.DonGia = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["DonGia"]).ToString());
                                cthdBus.Insert(cthd);

                                /* Update number of product attribute after paying bill */
                                int a = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["LuongTon"]).ToString());
                                int b = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoLuong"]).ToString());
                                thuoctinh.MaXe =
                                    gridView2.GetRowCellValue(i, gridView2.Columns["MaXe"]).ToString();
                                thuoctinh.SoLuong = a - b;
                                thuoctinh.MauSac = gridView2.GetRowCellValue(i, gridView2.Columns["MauSac"]).ToString();
                                thuocTinhBus.Update_SoLuong(thuoctinh);

                                /* Update number of product after paying bill */
                                int c = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["LuongTonXe"]).ToString());
                                xe.LuongTon = c - b;
                                xe.MaXe =
                                    gridView2.GetRowCellValue(i, gridView2.Columns["MaXe"]).ToString();
                                xeBus.Update_SoLuong(xe);
                            }
                            /* Print receipt */
                            Print();
                            /* Refresh the database in gridView after purchased */
                            DisplayThuocTinh();
                            DisplayXe();
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
                                cthd.MaHoaDon = hoaDonBus.GetHoaDonId();
                                cthd.MaXe = gridView2.GetRowCellValue(i, gridView2.Columns["MaXe"]).ToString();
                                cthd.MauSac = gridView2.GetRowCellValue(i, gridView2.Columns["MauSac"]).ToString();
                                cthd.SoLuong =
                                    int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoLuong"]).ToString());
                                cthd.DonGia = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["DonGia"]).ToString());
                                cthdBus.Insert(cthd);

                                /* Update number of product attribute after paying bill */
                                int a = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["LuongTon"]).ToString());
                                int b = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoLuong"]).ToString());
                                thuoctinh.MaXe =
                                    gridView2.GetRowCellValue(i, gridView2.Columns["MaXe"]).ToString();
                                thuoctinh.SoLuong = a - b;
                                thuoctinh.MauSac = gridView2.GetRowCellValue(i, gridView2.Columns["MauSac"]).ToString();
                                thuocTinhBus.Update_SoLuong(thuoctinh);

                                /* Update number of product after paying bill */
                                int c = int.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["LuongTon"]).ToString());
                                int d = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoLuong"]).ToString());
                                xe.LuongTon = c - d;
                                xe.MaXe =
                                    gridView2.GetRowCellValue(i, gridView2.Columns["MaXe"]).ToString();
                                xeBus.Update_SoLuong(xe);
                            }
                            /* Refresh the database in gridView after paying */
                            DisplayThuocTinh();
                            DisplayXe();
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