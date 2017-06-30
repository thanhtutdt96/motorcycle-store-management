using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DTO;

namespace GUI
{
    /**
    * This class use for add new product to database
    * @author Pham Thanh Tu
    * 
    */
    public partial class FrmThemXe : DevExpress.XtraEditors.XtraForm
    {
        private readonly FrmXe sp;
        public FrmThemXe(FrmXe sp)
        {
            InitializeComponent();
            this.sp = sp;
        }

        public bool IsInsert = false;
        public EventHandler refresh; // refresh the gridView when value is added or edited
        public string Id = string.Empty;

        XeDto obj = new XeDto();
        XeBus bus = new XeBus();
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            /* Add new value to the database */
            obj.MaXe = txtMa.Text;
            obj.TenXe = txtTen.Text;
            obj.MaLoai = cbbLoai.EditValue.ToString();
            obj.MaNcc = cbbNCC.EditValue.ToString();
            obj.LuongTon = int.Parse(spinLuongTon.Text);
            try
            {
                bus.Insert(obj);
                sp.Display();               
                this.Close();
            }
            catch
            {
                XtraMessageBox.Show("Không thêm được","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty;
            cbbLoai.Text = string.Empty;
            cbbNCC.Text = string.Empty;
            spinLuongTon.Text = string.Empty;
        }

        private void FrmThemSanPham_Load(object sender, EventArgs e)
        {
            /* Display the value for the combobox Loai */
            cbbLoai.Properties.DataSource = bus.GetDataLoaiSp();
            cbbLoai.Properties.ValueMember = "MaLoai";
            cbbLoai.Properties.DisplayMember = "TenLoai";

            /* Display the value for the combobox NhaCungCap */
            cbbNCC.Properties.DataSource = bus.GetDataNcc();
            cbbNCC.Properties.ValueMember = "MaNCC";
            cbbNCC.Properties.DisplayMember = "TenNCC";
        }
    }
}