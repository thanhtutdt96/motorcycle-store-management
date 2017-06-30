namespace GUI
{
    partial class FrmQuanLy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLy));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiSP = new DevExpress.XtraBars.BarButtonItem();
            this.btnSanPham = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThuocTinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnNCC = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnXemHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.txtChucVu = new DevExpress.XtraBars.BarStaticItem();
            this.txtId = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem3 = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDichVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoaDonDv = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btnNhaCC = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnNhanVien,
            this.btnLoaiSP,
            this.btnSanPham,
            this.skinRibbonGalleryBarItem1,
            this.btnTaiKhoan,
            this.btnDangXuat,
            this.btnThuocTinh,
            this.btnNCC,
            this.btnHoaDon,
            this.skinRibbonGalleryBarItem2,
            this.btnXemHoaDon,
            this.txtChucVu,
            this.txtId,
            this.barHeaderItem1,
            this.barHeaderItem2,
            this.barHeaderItem3,
            this.barStaticItem1,
            this.barStaticItem2,
            this.btnKhachHang,
            this.btnDichVu,
            this.btnHoaDonDv});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(842, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Danh sách nhân viên";
            this.btnNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Glyph")));
            this.btnNhanVien.Id = 1;
            this.btnNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.LargeGlyph")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.Caption = "Danh sách loại xe";
            this.btnLoaiSP.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLoaiSP.Glyph")));
            this.btnLoaiSP.Id = 2;
            this.btnLoaiSP.LargeGlyph = global::GUI.Properties.Resources.wheel1;
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnLoaiSP_ItemClick);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Caption = "Danh sách xe";
            this.btnSanPham.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSanPham.Glyph")));
            this.btnSanPham.Id = 4;
            this.btnSanPham.LargeGlyph = global::GUI.Properties.Resources.motor_scooter__22_1;
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSanPham_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Id = 6;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Caption = "Tài khoản";
            this.btnTaiKhoan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Glyph")));
            this.btnTaiKhoan.Id = 7;
            this.btnTaiKhoan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.LargeGlyph")));
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiKhoan_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Glyph")));
            this.btnDangXuat.Id = 8;
            this.btnDangXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.LargeGlyph")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnThuocTinh
            // 
            this.btnThuocTinh.Caption = "Danh sách thuộc tính";
            this.btnThuocTinh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThuocTinh.Glyph")));
            this.btnThuocTinh.Id = 9;
            this.btnThuocTinh.LargeGlyph = global::GUI.Properties.Resources.colors_32;
            this.btnThuocTinh.Name = "btnThuocTinh";
            this.btnThuocTinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThuocTinh_ItemClick);
            // 
            // btnNCC
            // 
            this.btnNCC.Caption = "Danh sách nhà cung cấp";
            this.btnNCC.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNCC.Glyph")));
            this.btnNCC.Id = 10;
            this.btnNCC.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNCC.LargeGlyph")));
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNCC_ItemClick);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Caption = "Lập hóa đơn";
            this.btnHoaDon.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Glyph")));
            this.btnHoaDon.Id = 12;
            this.btnHoaDon.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.LargeGlyph")));
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoaDon_ItemClick_1);
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "skinRibbonGalleryBarItem2";
            this.skinRibbonGalleryBarItem2.Id = 13;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.Caption = "Xem hóa đơn";
            this.btnXemHoaDon.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXemHoaDon.Glyph")));
            this.btnXemHoaDon.Id = 14;
            this.btnXemHoaDon.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXemHoaDon.LargeGlyph")));
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemHoaDon_ItemClick);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtChucVu.Caption = "barStaticItem1";
            this.txtChucVu.Id = 15;
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtId
            // 
            this.txtId.Caption = "barStaticItem2";
            this.txtId.Id = 16;
            this.txtId.Name = "txtId";
            this.txtId.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Chức vụ";
            this.barHeaderItem1.Id = 17;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Caption = "Tài khoản:";
            this.barHeaderItem2.Id = 18;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // barHeaderItem3
            // 
            this.barHeaderItem3.Caption = "Chức vụ";
            this.barHeaderItem3.Id = 19;
            this.barHeaderItem3.Name = "barHeaderItem3";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "Chức vụ:";
            this.barStaticItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.Glyph")));
            this.barStaticItem1.Id = 20;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Tài khoản";
            this.barStaticItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem2.Glyph")));
            this.barStaticItem2.Id = 21;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Danh sách khách hàng";
            this.btnKhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Glyph")));
            this.btnKhachHang.Id = 22;
            this.btnKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.LargeGlyph")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Caption = "Danh sách dịch vụ";
            this.btnDichVu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDichVu.Glyph")));
            this.btnDichVu.Id = 23;
            this.btnDichVu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDichVu.LargeGlyph")));
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDichVu_ItemClick);
            // 
            // btnHoaDonDv
            // 
            this.btnHoaDonDv.Caption = "Hóa đơn dịch vụ";
            this.btnHoaDonDv.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDonDv.Glyph")));
            this.btnHoaDonDv.Id = 24;
            this.btnHoaDonDv.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDonDv.LargeGlyph")));
            this.btnHoaDonDv.Name = "btnHoaDonDv";
            this.btnHoaDonDv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoaDonDv_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNCC);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý thông tin";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLoaiSP);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSanPham);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThuocTinh);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý sản phẩm";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHoaDon);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnXemHoaDon);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Tính tiền";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDichVu);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnHoaDonDv);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Dịch vụ";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Hệ thống";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTaiKhoan);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Quản lý đăng nhập";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinRibbonGalleryBarItem2);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thay đổi skin";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.txtChucVu);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar.ItemLinks.Add(this.txtId);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(842, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.Caption = "Danh sách nhà cung cấp";
            this.btnNhaCC.Id = 5;
            this.btnNhaCC.Name = "btnNhaCC";
            // 
            // FrmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 606);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmQuanLy";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý cửa hàng xe máy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuanLy_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmQuanLy_FormClosed);
            this.Load += new System.EventHandler(this.FrmQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnLoaiSP;
        private DevExpress.XtraBars.BarButtonItem btnSanPham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnThuocTinh;
        private DevExpress.XtraBars.BarButtonItem btnNhaCC;
        private DevExpress.XtraBars.BarButtonItem btnNCC;
        private DevExpress.XtraBars.BarButtonItem btnHoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnXemHoaDon;
        private DevExpress.XtraBars.BarStaticItem txtChucVu;
        private DevExpress.XtraBars.BarStaticItem txtId;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnDichVu;
        private DevExpress.XtraBars.BarButtonItem btnHoaDonDv;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}