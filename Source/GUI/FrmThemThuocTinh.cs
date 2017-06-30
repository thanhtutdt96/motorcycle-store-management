using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DTO;

namespace GUI
{
    /**
   * This class use for add new attribute to database
   * @author Pham Thanh Tu
   * 
   */
    public partial class FrmThemThuocTinh : DevExpress.XtraEditors.XtraForm
    {
        public FrmThemThuocTinh()
        {
            InitializeComponent();
        }
        public bool isInsert;
        public EventHandler refresh; // refresh the gridView when value is added or edited
        public string Id = string.Empty;
        public string MauSac = string.Empty;
        private readonly ThuocTinhDto obj = new ThuocTinhDto();
        private readonly ThuocTinhBus bus = new ThuocTinhBus();
        private void frmThemThuocTinh_Load(object sender, EventArgs e)
        {
            /* Display the value for the combobox Xe */
            cbbXe.Properties.DataSource = bus.GetDataXe();
            cbbXe.Properties.ValueMember = "MaXe";
            cbbXe.Properties.DisplayMember = "TenXe";
            if (isInsert == false)
            {
                DataTable table = new DataTable();
                table = bus.GetDataByThuocTinh(Id,MauSac);
                cbbXe.EditValue = Id;
                cbbMauSac.EditValue = MauSac;
                cbbDungTich.EditValue = table.Rows[0]["DungTich"].ToString();
                spinSoLuong.Text = table.Rows[0]["SoLuong"].ToString();
                spinDonGia.Text= table.Rows[0]["DonGia"].ToString();
                cbbXe.Enabled = false;
                cbbMauSac.Enabled = false;
                btnNhapLai.Hide();                
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /* Add new value to the database */
            obj.MaXe = cbbXe.EditValue.ToString();
            obj.MauSac = cbbMauSac.EditValue.ToString();
            obj.DungTich = cbbDungTich.EditValue.ToString();
            obj.SoLuong = int.Parse(spinSoLuong.Text);
            obj.DonGia = int.Parse(spinDonGia.Text);
            if(isInsert)
            {
                try
                {
                    bus.Insert(obj);
                    if (refresh != null)
                    {
                        refresh(sender, e);
                    }
                    this.Close();
                }
                catch
                {
                    XtraMessageBox.Show("Xe và thuộc tính bị trùng. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbXe.Focus();
                }
            }
            else
            {
                bus.Update(obj);
                if (refresh != null)
                {
                    refresh(sender, e);
                }
                this.Close();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            /* Clear the value input */
            cbbXe.EditValue = null;
            cbbMauSac.EditValue = null;
            cbbDungTich.EditValue = null;
            spinSoLuong.Text = string.Empty;
            spinDonGia.Text = string.Empty;
        }
    }
}