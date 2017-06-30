using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DTO;

namespace GUI
{
    /**
     * This class use for manage the product
     * @author Pham Thanh Tu
     * 
     */
    public partial class FrmXe : XtraForm
    {
        public FrmXe()
        {
            InitializeComponent();
        }

        private readonly XeBus bus = new XeBus();
        private readonly XeDto obj = new XeDto();
        public void Display()
        {
            /* Load data for the gridView */
            gridSanPham.DataSource = bus.GetData();
            gridView1.ExpandAllGroups();            
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LockControl();
            Display();
            /* Display the value for the combobox Loai */
            cbbLoai.Properties.DataSource = bus.GetDataLoaiSp();
            cbbLoai.Properties.ValueMember = "MaLoai";
            cbbLoai.Properties.DisplayMember = "TenLoai"; // Name of Loai

            /* Display the value for the combobox NhaCungCap */
            cbbNCC.Properties.DataSource = bus.GetDataNcc();
            cbbNCC.Properties.ValueMember = "MaNCC";
            cbbNCC.Properties.DisplayMember = "TenNCC"; // Name of NhaCungCap
        }

        public void LockControl()
        {
            /* Lock the button and textbox when load form */
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            cbbLoai.Enabled = false;
            cbbNCC.Enabled = false;
            spinLuongTon.Enabled = false;

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
            cbbLoai.Enabled = true;
            cbbNCC.Enabled = true;
            spinLuongTon.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
        }

        public void ClearField()
        {
            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty;
            cbbLoai.EditValue= null;
            cbbNCC.EditValue = null;
            spinLuongTon.Text = string.Empty;
        }

        private void gridSanPham_Click(object sender, EventArgs e)
        {
            LockControl();
            try
            {
                /* Display the value of the clicked row to the textbox */
                txtMa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaXe"]).ToString();
                txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenXe"]).ToString();
                cbbLoai.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaLoai"]).ToString();
                cbbNCC.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaNCC"]).ToString();
                spinLuongTon.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["LuongTon"]).ToString();
            }
            catch
            {
                // ignored
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /* Add new value to the database */
            FrmThemXe tsp = new FrmThemXe(this) { IsInsert = true };
            tsp.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* Delete the unecessary value */
            if (XtraMessageBox.Show("Bạn có muốn xóa xe này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
            obj.MaXe = txtMa.Text;
            obj.TenXe = txtTen.Text;
            obj.MaLoai = cbbLoai.EditValue.ToString();
            obj.MaNcc = cbbNCC.EditValue.ToString();
            obj.LuongTon = int.Parse(spinLuongTon.Text);
            bus.Update(obj);
            ClearField();
            Display();
            LockControl();
        }
    }
}