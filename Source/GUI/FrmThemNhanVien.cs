using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DTO;

namespace GUI
{
    /**
     * This class use for add new employee to database
     * @author Pham Thanh Tu
     * 
     */
    public partial class FrmThemNhanVien : XtraForm
    {
        private readonly FrmNhanVien nv;
        public FrmThemNhanVien(FrmNhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
        }
        public bool isInsert = false;
        public EventHandler refresh; // refresh the gridView when value is added or edited
        public string Id = string.Empty;
        NhanVienDto obj = new NhanVienDto();
        NhanVienBus bus = new NhanVienBus();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /* Add new value to the database */
            obj.Ten = txtTen.Text;
            obj.NgaySinh = dtNgaySinh.Value;
            obj.Cmnd = txtCMND.Text;
            obj.Luong = int.Parse(spinLuong.Text);
            obj.DiaChi = txtDiaChi.Text;
            obj.ChucVu =txtChucVu.Text;
            obj.NgayTuyen = dtNgayTuyen.Value;
            try
            {
                bus.Insert(obj);
                XtraMessageBox.Show("Thêm thành công");
                nv.Display();
                this.Close();
            }
            catch
            {
                XtraMessageBox.Show("Không thêm được", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtCMND.Text = string.Empty;
            txtChucVu.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtTen.Text = string.Empty;
            spinLuong.Text = string.Empty;
            dtNgaySinh.Value = DateTime.Today;
            dtNgayTuyen.Value = DateTime.Today;
        }
    }
}