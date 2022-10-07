use QuanLyBanXe
GO
-- Loại xe PROCEDURES--
CREATE PROC LoaiXe_Insert
@MaLoai VARCHAR(10),
@TenLoai NVARCHAR(25)
AS
BEGIN
INSERT INTO LoaiXe values (@MaLoai,@TenLoai)
END

GO

CREATE PROC LoaiXe_Update
@MaLoai VARCHAR(10),
@TenLoai NVARCHAR(25)
AS
BEGIN
UPDATE LoaiXe 
SET TenLoai = @TenLoai 
WHERE MaLoai = @MaLoai
END

GO

CREATE PROC LoaiXe_Delete
@MaLoai VARCHAR(10)
AS
BEGIN
DELETE FROM LoaiXe WHERE MaLoai = @MaLoai
END

GO

CREATE PROC LoaiXe_Select_All
AS
BEGIN
SELECT * FROM LoaiXe
END

GO

CREATE PROC LoaiXe_Select_ByMaLoai
@MaLoai VARCHAR(10)
AS
BEGIN
SELECT * FROM LoaiXe WHERE MaLoai=@MaLoai
END

GO

-- Xe PROCEDURES--
CREATE PROC Xe_Insert
@MaXe VARCHAR(10),
@TenXe NVARCHAR(20),
@LuongTon INT,
@MaLoai VARCHAR(10),
@MaNCC VARCHAR(10)
AS
BEGIN
INSERT INTO Xe values (@MaXe,@TenXe,@LuongTon,@MaLoai,@MaNCC)
END

GO

CREATE PROC Xe_Update
@MaXe VARCHAR(10),
@TenXe NVARCHAR(20),
@LuongTon INT,
@MaLoai VARCHAR(10),
@MaNCC VARCHAR(10)
AS
BEGIN
UPDATE Xe 
SET TenXe=@TenXe,
	LuongTon=@LuongTon,
	MaLoai=@MaLoai,
	MaNCC=@MaNCC 
WHERE MaXe = @MaXe
END

GO

CREATE PROC Xe_Update_SoLuong
@MaXe VARCHAR(10),
@LuongTon INT
AS
BEGIN
UPDATE Xe
SET LuongTon=@LuongTon
WHERE MaXe = @MaXe
END


GO

CREATE PROC Xe_Delete
@MaXe NVARCHAR(10)
AS
BEGIN
DELETE FROM Xe WHERE MaXe = @MaXe
END

GO

CREATE PROC Xe_Select_All
AS
BEGIN
SELECT
	Xe.MaXe,
	Xe.MaLoai,
    LoaiXe.TenLoai,
    Xe.TenXe,
    Xe.LuongTon,
	Xe.MaNCC,
    NCC.TenNCC
FROM 
    Xe,LoaiXe,NCC 
WHERE Xe.MaLoai=LoaiXe.MaLoai and Xe.MaNCC=NCC.MaNCC
END

GO

CREATE PROC Xe_Select_ByMaXe
@MaXe NVARCHAR(10)
AS
BEGIN
SELECT * FROM Xe WHERE MaXe=@MaXe
END

GO

-- Thuộc tính PROCEDURES--
CREATE PROC ThuocTinh_Insert
@MaXe VARCHAR(10),
@MauSac NVARCHAR(20),
@DungTich VARCHAR(20),
@SoLuong INT,
@DonGia INT
AS
BEGIN
INSERT INTO ThuocTinh values (@MaXe,@MauSac,@DungTich,@SoLuong,@DonGia)
END

GO

CREATE PROC ThuocTinh_Update
@MaXe VARCHAR(10),
@MauSac NVARCHAR(20),
@DungTich VARCHAR(20),
@SoLuong INT,
@DonGia INT
AS
BEGIN
UPDATE ThuocTinh 
SET DungTich=@DungTich,
	SoLuong=@SoLuong,
	DonGia=@DonGia 
WHERE @MaXe = @MaXe and MauSac = @MauSac
END

GO

CREATE PROC ThuocTinh_Delete
@MaXe VARCHAR(10),
@MauSac NVARCHAR(20)
AS
BEGIN
DELETE FROM ThuocTinh WHERE MaXe = @MaXe and MauSac=@MauSac
END

GO

CREATE PROC ThuocTinh_Select_All
AS
BEGIN
SELECT ThuocTinh.*,Xe.TenXe 
FROM ThuocTinh,Xe 
WHERE ThuocTinh.MaXe=Xe.MaXe
END

GO

CREATE PROC ThuocTinh_Select_ByMaXe
@MaXe NVARCHAR(10)
AS
BEGIN
SELECT * FROM ThuocTinh WHERE MaXe = @MaXe
END

GO

CREATE PROC ThuocTinh_Select_ByThuocTinh
@MaXe VARCHAR(10),
@MauSac NVARCHAR(20)
AS
BEGIN
SELECT * FROM ThuocTinh WHERE MaXe = @MaXe and MauSac=@MauSac
END

GO

CREATE PROC ThuocTinh_Update_SoLuong
@MaXe VARCHAR(10),
@MauSac NVARCHAR(20),
@SoLuong INT
AS
BEGIN
UPDATE ThuocTinh 
SET SoLuong=@SoLuong
WHERE MaXe = @MaXe and MauSac=@MauSac
END

GO

-- Nhà cung cấp PROCEDURES--
CREATE PROC NCC_Insert
@MaNCC VARCHAR(10),
@TenNCC NVARCHAR(25),
@DiaChi NVARCHAR(50),
@SDT VARCHAR(15)
AS
BEGIN
INSERT INTO NCC values (@MaNCC,@TenNCC,@DiaChi,@SDT)
END

GO

CREATE PROC NCC_Update
@MaNCC VARCHAR(10),
@TenNCC NVARCHAR(25),
@DiaChi NVARCHAR(50),
@SDT VARCHAR(15)
AS
BEGIN
UPDATE NCC 
SET TenNCC=@TenNCC,
	DiaChi=@DiaChi,
	SDT=@SDT
WHERE MaNCC = @MaNCC
END

GO

CREATE PROC NCC_Delete
@MaNCC VARCHAR(10)
AS
BEGIN
DELETE FROM NCC WHERE MaNCC = @MaNCC
END

GO

CREATE PROC NCC_Select_All
AS
BEGIN
SELECT * FROM NCC
END

GO

CREATE PROC NCC_Select_ByMaNCC
@MaNCC VARCHAR(10)
AS
BEGIN
SELECT * FROM NCC WHERE MaNCC = @MaNCC
END

GO

-- Nhân viên PROCEDURES--
CREATE PROC NhanVien_Insert
@TenNV NVARCHAR(30),
@NgaySinh DATE,
@DiaChi NVARCHAR(30),
@CMND VARCHAR(12),
@ChucVu NVARCHAR(30),
@LuongCoBan INT,
@NgayTuyen DATE
AS
BEGIN
INSERT INTO NhanVien values (@TenNV,@NgaySinh,@DiaChi,@CMND,@ChucVu,@LuongCoBan,@NgayTuyen)
END

GO

CREATE PROC NhanVien_Update
@MaNV INT,
@TenNV NVARCHAR(30),
@NgaySinh DATE,
@DiaChi NVARCHAR(30),
@CMND VARCHAR(12),
@ChucVu NVARCHAR(30),
@LuongCoBan INT,
@NgayTuyen DATE
AS
BEGIN
UPDATE NhanVien 
SET TenNV=@TenNV,
	NgaySinh=@NgaySinh,
	DiaChi=@DiaChi,
	CMND=@CMND,
	ChucVu=@ChucVu,
	LuongCoBan=@LuongCoBan,
	NgayTuyen=@NgayTuyen 
WHERE MaNV = @MaNV
END

GO

CREATE PROC NhanVien_Delete
@MaNV INT
AS
BEGIN
DELETE FROM NhanVien WHERE MaNV = @MaNV
END

GO

CREATE PROC NhanVien_Select_All
AS
BEGIN
SELECT * FROM NhanVien
END

GO

CREATE PROC NhanVien_Select_ByMaNV
@MaNV INT
AS
BEGIN
SELECT * FROM NhanVien WHERE MaNV = @MaNV
END

GO

-- Tài khoản PROCEDURES--
CREATE PROC TaiKhoan_Insert
@ID VARCHAR(15),
@MaNV VARCHAR(10),
@MatKhau VARCHAR(20),
@QuyenHan NVARCHAR(20)
AS
BEGIN
INSERT INTO TaiKhoan values (@ID,@MaNV,@MatKhau,@QuyenHan)
END

GO

CREATE PROC TaiKhoan_Update
@ID VARCHAR(15),
@MatKhau VARCHAR(20),
@QuyenHan NVARCHAR(20)
AS
BEGIN
UPDATE TaiKhoan 
SET MatKhau=@MatKhau,
	QuyenHan=@QuyenHan
WHERE ID = @ID
END

GO

CREATE PROC TaiKhoan_Delete
@ID NVARCHAR(10)
AS
BEGIN
DELETE FROM TaiKhoan WHERE ID = @ID
END

GO

CREATE PROC TaiKhoan_Select_All
AS
BEGIN
SELECT * FROM TaiKhoan
END

GO

CREATE PROC TaiKhoan_Select_ById
@ID NVARCHAR(10)
AS
BEGIN
SELECT * FROM TaiKhoan WHERE ID=@ID
END

GO

-- Chi tiết hóa đơn PROCEDURES--
CREATE PROC ChiTietHoaDon_Insert
@MaHD VARCHAR(10),
@MaXe VARCHAR(10),
@MauSac NVARCHAR(20),
@SoLuong INT,
@DonGia INT
AS
BEGIN
INSERT INTO ChiTietHoaDon values (@MaHD,@MaXe,@MauSac,@SoLuong,@DonGia)
END

GO

CREATE PROC ChiTietHoaDon_Select_ByMaHD
@MaHD VARCHAR(10)
AS
BEGIN
SELECT ChiTietHoaDon.*,Xe.TenXe,ThuocTinh.DungTich 
FROM ChiTietHoaDon,Xe,ThuocTinh 
WHERE MaHD=@MaHD and ChiTietHoaDon.MaXe=Xe.MaXe and ChiTietHoaDon.MaXe=ThuocTinh.MaXe and ChiTietHoaDon.MauSac=ThuocTinh.MauSac
END

GO

CREATE PROC ChiTietHoaDon_Delete
@MaHD VARCHAR(10),
@MaXe VARCHAR(10),
@MauSac NVARCHAR(20)
AS
BEGIN
DELETE FROM ChiTietHoaDon WHERE MaHD=@MaHD and MaXe=@MaXe and MauSac=@MauSac
END

GO

CREATE PROC ChiTietHoaDon_Delete_ById
@MaHD int
AS
BEGIN
DELETE FROM ChiTietHoaDon WHERE MaHD=@MaHD
END

GO

-- Khách hàng PROCEDURES--
CREATE PROC KhachHang_Insert
@TenKH NVARCHAR(30),
@DiaChi NVARCHAR(50),
@SDT VARCHAR(15)
AS
BEGIN
INSERT INTO KhachHang values (@TenKH,@DiaChi,@SDT)
END

GO

CREATE PROC KhachHang_Update
@MaKH INT,
@TenKH NVARCHAR(30),
@DiaChi NVARCHAR(50),
@SDT VARCHAR(15)
AS
BEGIN
UPDATE KhachHang
SET TenKH=@TenKH,
	DiaChi=@DiaChi,
	SDT=@SDT
WHERE MaKH=@MaKH
END

GO

CREATE PROC KhachHang_Delete
@MaKH INT
AS
BEGIN
DELETE FROM KhachHang WHERE MaKH=@MaKH
END

GO

CREATE PROC KhachHang_Select_All
AS
BEGIN
SELECT * FROM KhachHang
END

GO

-- Hóa đơn PROCEDURES--
CREATE PROC HoaDon_Insert
@MaKH INT,
@MaNV VARCHAR(10),
@NgayLap DATE,
@TongTien INT
AS
BEGIN
INSERT INTO HoaDon values (@MaKH,@MaNV,@NgayLap,@TongTien)
END

GO

CREATE PROC HoaDon_Delete
@MaHD INT
AS
BEGIN
DELETE FROM HoaDon WHERE MaHD = @MaHD
END

GO

CREATE PROC HoaDon_Select_All
AS
BEGIN
SELECT HoaDon.*,KhachHang.TenKH,NhanVien.TenNV
FROM HoaDon,KhachHang,NhanVien
WHERE HoaDon.MaKH=KhachHang.MaKH and HoaDon.MaNV=NhanVien.MaNV
END

GO

-- Dịch vụ PROCEDURES--
CREATE PROC DichVu_Insert
@TenDV NVARCHAR(30),
@LoaiDV NVARCHAR(30),
@DonGia INT
AS
BEGIN
INSERT INTO DichVu values (@TenDV,@LoaiDV,@DonGia)
END

GO

CREATE PROC DichVu_Update
@MaDV INT,
@TenDV NVARCHAR(30),
@LoaiDV NVARCHAR(30),
@DonGia INT
AS
BEGIN
UPDATE DichVu 
SET TenDV = @TenDV,LoaiDV=@LoaiDV,DonGia=@DonGia 
WHERE MaDV = @MaDV
END

GO

CREATE PROC DichVu_Delete
@MaDV INT
AS
BEGIN
DELETE FROM DichVu WHERE MaDV = @MaDV
END

GO

CREATE PROC DichVu_Select_All
AS
BEGIN
SELECT * FROM DichVu
END

GO

CREATE PROC DichVu_Select_ByMaDV
@MaDV VARCHAR(10)
AS
BEGIN
SELECT * FROM DichVu WHERE MaDV=@MaDV
END

GO

-- Hóa đơn dịch vụ PROCEDURES--
CREATE PROC HoaDonDichVu_Insert
@MaKH INT,
@MaNV VARCHAR(10),
@NgayLap DATE,
@TongTien INT
AS
BEGIN
INSERT INTO HoaDonDichVu values (@MaKH,@MaNV,@NgayLap,@TongTien)
END

GO

-- Chi tiết dịch vụ PROCEDURES--
CREATE PROC ChiTietDichVu_Insert
@MaHDDV INT,
@MaDV INT,
@DonGia INT
AS
BEGIN
INSERT INTO ChiTietDichVu values (@MaHDDV,@MaDV,@DonGia)
END