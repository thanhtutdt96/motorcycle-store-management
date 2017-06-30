using System;
using System.Windows.Forms;
using QuanLyBanXe.DAO;

namespace GUI
{
    /**
     * This class represent the feature log in
     * @author Pham Thanh Tu
     * 
     */
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private readonly DataProvider provider=new DataProvider();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                /* Check id and pass in database */
                FrmHoaDon.Id = FrmQuanLy.Id = txtUser.Text;
                string sql = "select * from TaiKhoan where ID = '" + txtUser.Text.Trim() + "' and MatKhau = '" + txtPass.Text.Trim() + "'";
                if (txtUser.Text.Trim() != string.Empty || txtPass.Text.Trim() != string.Empty)
                {
                    if (provider.GetData(sql).Rows.Count != 0)
                    {
                        /* Log in successful */
                        MessageBox.Show("Đăng nhập thành công. Chào mừng " + txtUser.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmQuanLy.Quyen = provider.GetData("select QuyenHan from TaiKhoan where ID = '" + txtUser.Text.Trim() + "'").Rows[0][0].ToString().Trim();
                        FrmHoaDon.MaNhanVien = provider.GetData("select MaNV from TaiKhoan where ID = '" + txtUser.Text.Trim() + "'").Rows[0][0].ToString().Trim();
                        this.Hide();
                        FrmQuanLy frm = new FrmQuanLy();
                        frm.Show();
                    }
                }
                else
                {
                    /* Log in fail */
                    MessageBox.Show("Sai tên hoặc mật khẩu! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Clear();
                    txtPass.Clear();
                    txtUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*Remember id and password */
            if (cbRemember.Checked)
            {
                Properties.Settings.Default.user = txtUser.Text;
                Properties.Settings.Default.pass = txtPass.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.user = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.Save();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /* Clear the textbox for new input */
            txtPass.Clear();
            txtUser.Clear();
            txtUser.Focus();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            /* Save id and pass for next log in */
            txtUser.Text = Properties.Settings.Default.user;
            txtPass.Text = Properties.Settings.Default.pass;
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
