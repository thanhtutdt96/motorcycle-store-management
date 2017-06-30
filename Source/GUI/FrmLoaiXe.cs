using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanXe.BUS;
using QuanLyBanXe.DTO;

namespace GUI
{
    /**
     * This class use for manage the product categories
     * @author Pham Thanh Tu
     * 
     */
    public partial class FrmDichVu : XtraForm
    {
        public FrmDichVu()
        {
            InitializeComponent();
        }

        private LoaiXeDto obj = new LoaiXeDto();
        private readonly LoaiXeBus bus = new LoaiXeBus();
        private bool isInsert; // determine whether add feature or update feature is choosen

        public void LockControl()
        {
            /* Lock the button and textbox when load form */
            txtID.Enabled = false;
            txtName.Enabled = false;

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        public void UnlockControl()
        {
            /* Unlock the locked button and textbox */
            txtID.Enabled = true;
            txtName.Enabled = true;

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        void Display()
        {
            /* Load data for the gridView */
            gridControl1.DataSource = bus.GetData();
        }

        void ClearField()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
        }

        private void frmLoaiXe_Load(object sender, EventArgs e)
        {
            LockControl();
            Display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* Add new value to the database */
            UnlockControl();
            isInsert = true;
            ClearField();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* Save new value to the database or update the existing value */
            obj.MaLoai = txtID.Text;
            obj.TenLoai = txtName.Text;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /* Edit the existing value in database */
            UnlockControl();
            isInsert = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* Delete the unecessary value */
            if (XtraMessageBox.Show("Bạn có muốn xóa loại xe này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        private void gridControl1_Click(object sender, EventArgs e)
        {
            /* Display the value of the clicked row to the textbox */
            LockControl();
            try
            {
                txtID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaLoai"]).ToString();
                txtName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenLoai"]).ToString();
            }
            catch
            {
                // ignored
            }
        }
    }
}