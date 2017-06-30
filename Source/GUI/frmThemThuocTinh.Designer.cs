namespace GUI
{
    partial class FrmThemThuocTinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemThuocTinh));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbbDungTich = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnNhapLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.spinDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.spinSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.cbbMauSac = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbXe = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDungTich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMauSac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbDungTich);
            this.layoutControl1.Controls.Add(this.btnNhapLai);
            this.layoutControl1.Controls.Add(this.btnLuu);
            this.layoutControl1.Controls.Add(this.spinDonGia);
            this.layoutControl1.Controls.Add(this.spinSoLuong);
            this.layoutControl1.Controls.Add(this.cbbMauSac);
            this.layoutControl1.Controls.Add(this.cbbXe);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(394, 0, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(349, 166);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbDungTich
            // 
            this.cbbDungTich.Location = new System.Drawing.Point(64, 60);
            this.cbbDungTich.Name = "cbbDungTich";
            this.cbbDungTich.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbDungTich.Properties.Items.AddRange(new object[] {
            "110cc",
            "125cc",
            "135cc",
            "150cc"});
            this.cbbDungTich.Size = new System.Drawing.Size(273, 20);
            this.cbbDungTich.StyleController = this.layoutControl1;
            this.cbbDungTich.TabIndex = 10;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapLai.Image")));
            this.btnNhapLai.Location = new System.Drawing.Point(99, 132);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(75, 22);
            this.btnNhapLai.StyleController = this.layoutControl1;
            this.btnNhapLai.TabIndex = 9;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(12, 132);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 22);
            this.btnLuu.StyleController = this.layoutControl1;
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // spinDonGia
            // 
            this.spinDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDonGia.Location = new System.Drawing.Point(64, 108);
            this.spinDonGia.Name = "spinDonGia";
            this.spinDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinDonGia.Size = new System.Drawing.Size(273, 20);
            this.spinDonGia.StyleController = this.layoutControl1;
            this.spinDonGia.TabIndex = 7;
            // 
            // spinSoLuong
            // 
            this.spinSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSoLuong.Location = new System.Drawing.Point(64, 84);
            this.spinSoLuong.Name = "spinSoLuong";
            this.spinSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSoLuong.Size = new System.Drawing.Size(273, 20);
            this.spinSoLuong.StyleController = this.layoutControl1;
            this.spinSoLuong.TabIndex = 6;
            // 
            // cbbMauSac
            // 
            this.cbbMauSac.Location = new System.Drawing.Point(64, 36);
            this.cbbMauSac.Name = "cbbMauSac";
            this.cbbMauSac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMauSac.Properties.Items.AddRange(new object[] {
            "Màu đỏ đen",
            "Màu vàng",
            "Màu xanh ngọc",
            "Màu xanh đậm",
            "Màu đen",
            "Màu trắng",
            "Màu cam"});
            this.cbbMauSac.Size = new System.Drawing.Size(273, 20);
            this.cbbMauSac.StyleController = this.layoutControl1;
            this.cbbMauSac.TabIndex = 5;
            // 
            // cbbXe
            // 
            this.cbbXe.Location = new System.Drawing.Point(64, 12);
            this.cbbXe.Name = "cbbXe";
            this.cbbXe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbXe.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaXe", "Mã xe"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenXe", "Tên xe")});
            this.cbbXe.Properties.NullText = "";
            this.cbbXe.Size = new System.Drawing.Size(273, 20);
            this.cbbXe.StyleController = this.layoutControl1;
            this.cbbXe.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(349, 166);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(166, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(163, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbbXe;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2);
            this.layoutControlItem1.Size = new System.Drawing.Size(329, 24);
            this.layoutControlItem1.Text = "Xe";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbbMauSac;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(329, 24);
            this.layoutControlItem2.Text = "Màu sắc";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinSoLuong;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2);
            this.layoutControlItem3.Size = new System.Drawing.Size(329, 24);
            this.layoutControlItem3.Text = "Số lượng";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spinDonGia;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(329, 24);
            this.layoutControlItem4.Text = "Đơn giá";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnLuu;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(87, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnNhapLai;
            this.layoutControlItem6.Location = new System.Drawing.Point(87, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(79, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbbDungTich;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2);
            this.layoutControlItem7.Size = new System.Drawing.Size(329, 24);
            this.layoutControlItem7.Text = "Dung tích";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(45, 13);
            // 
            // FrmThemThuocTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 166);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThemThuocTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thuộc tính";
            this.Load += new System.EventHandler(this.frmThemThuocTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbDungTich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMauSac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnNhapLai;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SpinEdit spinDonGia;
        private DevExpress.XtraEditors.SpinEdit spinSoLuong;
        private DevExpress.XtraEditors.ComboBoxEdit cbbMauSac;
        private DevExpress.XtraEditors.LookUpEdit cbbXe;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.ComboBoxEdit cbbDungTich;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}