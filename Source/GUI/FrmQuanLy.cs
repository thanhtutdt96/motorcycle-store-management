using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace GUI
{
    /**
     * This class use for managing the feature of the software
     * @author Pham Thanh Tu
     * 
     */
    public partial class FrmQuanLy : RibbonForm
    {
        public FrmQuanLy()
        {
            InitializeComponent();
        }

        /* Data imported from log in */
        public static string Quyen;
        public static string Id;

        /* Check form type */
        Form CheckForm(Type fType)
        {
            foreach (var f in MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }
       
        private void mnLoaiSP_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Display LoaiSanPham form in tabbed */
            Form lsp = CheckForm(typeof(FrmDichVu));
            if (lsp != null)
            {
                lsp.Activate();
            }
            else
            {
                var form = new FrmDichVu {MdiParent = this};
                form.Show();
            }
        }

        private void btnSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Display SanPham form in tabbed */
            Form sp = CheckForm(typeof(FrmXe));
            if (sp != null)
            {
                sp.Activate();
            }
            else
            {
                var form = new FrmXe { MdiParent = this };
                form.Show();
            }
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Display NhanVien form in tabbed */
            Form nv = CheckForm(typeof(FrmNhanVien));
            if (nv != null)
            {
                nv.Activate();
            }
            else
            {
                var form = new FrmNhanVien { MdiParent = this };
                form.Show();
            }
        }

        private void btnNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Display NhaCungCap form in tabbed */
            Form ncc = CheckForm(typeof(FrmNhaCungCap));
            if (ncc != null)
            {
                ncc.Activate();
            }
            else
            {
                var form = new FrmNhaCungCap { MdiParent = this };
                form.Show();
            }
        }
       
        private void btnThuocTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Display ThuocTinh form in tabbed */
            Form tt = CheckForm(typeof(FrmThuocTinh));
            if (tt != null)
            {
                tt.Activate();
            }
            else
            {
                var form = new FrmThuocTinh { MdiParent = this };
                form.Show();
            }
        }

        private void btnHoaDon_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            /* Display HoaDon form in tabbed */
            Form hd = CheckForm(typeof(FrmHoaDon));
            if (hd != null)
            {
                hd.Activate();
            }
            else
            {
                var form = new FrmHoaDon { MdiParent = this };
                form.Show();
            }
        }

        private void btnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Display TaiKhoan form in tabbed */
            Form hd = CheckForm(typeof(FrmTaiKhoan));
            if (hd != null)
            {
                hd.Activate();
            }
            else
            {
                var form = new FrmTaiKhoan { MdiParent = this };
                form.Show();
            }
        }

        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            /* Decentralize for manager and sale employee */
            txtId.Caption = Id;
            if (Quyen == "Quản lý")
            {
                btnHoaDon.Visibility = BarItemVisibility.Never;
                btnHoaDonDv.Visibility = BarItemVisibility.Never;
                txtChucVu.Caption = Quyen;
            }
            if (Quyen == "Bán hàng")
            {
                btnNhanVien.Visibility = BarItemVisibility.Never;
                btnNhaCC.Visibility = BarItemVisibility.Never;
                btnTaiKhoan.Visibility = BarItemVisibility.Never;
                txtChucVu.Caption = Quyen;
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Log out of the software */
            DialogResult dr = XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                FrmDangNhap frm = new FrmDangNhap();
                this.Dispose();
                this.Close();
                frm.ShowDialog();
            }
        }

        private void FrmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* Display the message confirm when close button clicked */
            DialogResult dr = XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnXemHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Display XemHoaDon form in tabbed */
            Form hd = CheckForm(typeof(FrmXemHoaDon));
            if (hd != null)
            {
                hd.Activate();
            }
            else
            {
                var form = new FrmXemHoaDon { MdiParent = this };
                form.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Display KhachHang form in tabbed */
            Form hd = CheckForm(typeof(FrmKhachHang));
            if (hd != null)
            {
                hd.Activate();
            }
            else
            {
                var form = new FrmKhachHang { MdiParent = this };
                form.Show();
            }
        }

        private void btnDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Display DichVu form in tabbed */
            Form dv = CheckForm(typeof(FrmDsDichVu));
            if (dv != null)
            {
                dv.Activate();
            }
            else
            {
                var form = new FrmDsDichVu { MdiParent = this };
                form.Show();
            }
        }

        private void btnHoaDonDv_ItemClick(object sender, ItemClickEventArgs e)
        {
            /* Display HoaDonDichVu form in tabbed */
            Form dv = CheckForm(typeof(FrmHoaDonDichVu));
            if (dv != null)
            {
                dv.Activate();
            }
            else
            {
                var form = new FrmHoaDonDichVu { MdiParent = this };
                form.Show();
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}