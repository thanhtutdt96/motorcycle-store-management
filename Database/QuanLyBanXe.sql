create database QuanLyBanXe
go
use QuanLyBanXe
go
create table LoaiXe
(
	MaLoai varchar(10) primary key,
	TenLoai nvarchar(25)
)
create table NCC
(
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(25),
	DiaChi nvarchar(50),
	SDT varchar(15)
)
create table LoaiDV
(
	MaLDV varchar(10) primary key,
	TenLDV nvarchar(25),
)
create table Xe 
(
	MaXe varchar(10) primary key,
	TenXe nvarchar(25),
	LuongTon int,
	MaLoai varchar(10) foreign key references LoaiXe(MaLoai),
	MaNCC varchar(10) foreign key references NCC(MaNCC)
)
create table ThuocTinh(
	MaXe varchar(10) foreign key references Xe(MaXe),
	MauSac nvarchar(20),
	DungTich varchar(20),
	SoLuong int,
	DonGia int
	primary key(MaXe,MauSac)
)
create table NhanVien
(
	MaNV int identity(1,1) primary key,	
	TenNV nvarchar(30),
	NgaySinh date,
	DiaChi nvarchar(30),
	CMND varchar(12),
	ChucVu nvarchar(30),
	LuongCoBan int,
	NgayTuyen date,
)
create table KhachHang
(
	MaKH int identity(5000,1) primary key,
	TenKH nvarchar(30),
	DiaChi nvarchar(50),
	SDT varchar(15)
)
create table PhieuNhap
(
	MaPN varchar(10) primary key,
	MaNV int foreign key references NhanVien(MaNV),
	NgayLap date,
	ThanhTien int
)
create table HoaDon
(
	MaHD int identity(10000,1) primary key,
	MaKH int foreign key references KhachHang(MaKH),
	MaNV int foreign key references NhanVien(MaNV),
	NgayLap date,
	TongTien int
)
create table ChiTietPhieuNhap
(
	MaPN varchar(10) foreign key references PhieuNhap(MaPN),
	MaXe varchar(10) foreign key references Xe(MaXe),
	SoLuong int,
	DonGia int,
	primary key(MaPN,MaXe)
)
create table ChiTietHoaDon
(
	MaHD int foreign key references HoaDon(MaHD),
	MaXe varchar(10),
	MauSac nvarchar(20),
	foreign key (MaXe,MauSac) references ThuocTinh(MaXe,MauSac),
	SoLuong int,
	DonGia int,
	primary key(MaHD,MaXe,MauSac)
)
create table TaiKhoan(
	ID varchar(15) primary key,
	MaNV int foreign key references NhanVien(MaNV),
	MatKhau varchar(20),
	QuyenHan nvarchar(20)
)
create table DichVu(
	MaDV int identity(1,1) primary key,
	TenDV nvarchar(30),
	LoaiDV nvarchar(30),
	DonGia int
)
create table HoaDonDichVu(
	MaHDDV int identity(800,1) primary key,
	MaKH int foreign key references KhachHang(MaKH),
	MaNV int foreign key references NhanVien(MaNV),
	NgayLap date,
	TongTien int
)
create table ChiTietDichVu(
	MaHDDV int foreign key references HoaDonDichVu(MaHDDV),
	MaDV int foreign key references DichVu(MaDV),
	DonGia int,
	primary key(MaHDDV,MaDV)
)

insert into LoaiXe values('XTG',N'Xe Tay Ga')
insert into LoaiXe values('XS',N'Xe Số')
insert into LoaiXe values('XTC',N'Xe Tay Côn')
insert into LoaiXe values('PKL',N'MôTô Phân Khối Lớn')

insert into NCC values('HD',N'Honda',N'Tokyo, Nhật Bản','08 3990 7920')
insert into NCC values('YM',N'Yamaha',N'Hamamatsu, Nhật Bản','08 3990 3213')
insert into NCC values('SZ',N'Suzuki',N'Shizuaka, Nhật Bản','08 3142 3632')

insert into LoaiDV values('BT',N'Bảo Trì')
insert into LoaiDV values('SC',N'Sửa Chữa')

insert into Xe values('HW','Wave RSX',70,'XS','HD')
insert into Xe values('HB','Blade',70,'XS','HD')
insert into Xe values('HS','SH 150i',50,'XTG','HD')
insert into Xe values('SA','Axelo',40,'XTC','SZ')
insert into Xe values('EX','Exciter 2016',80,'XTC','YM')

insert into ThuocTinh values('HW',N'Đỏ Đen','110cc',30,22000000)
insert into ThuocTinh values('HW',N'Cam','110cc',30,21500000)
insert into ThuocTinh values('HB',N'Trắng','110cc',30,19500000)
insert into ThuocTinh values('HB',N'Xanh ngọc','110cc',10,19500000)
insert into ThuocTinh values('HS',N'Đỏ','150cc',30,89000000)
insert into ThuocTinh values('HS',N'Trắng','150cc',20,88000000)
insert into ThuocTinh values('SA',N'Xanh','125cc',40,30000000)
insert into ThuocTinh values('EX',N'Trắng','150cc',50,55000000)
insert into ThuocTinh values('EX',N'Xanh','135cc',30,49000000)

insert into NhanVien values(N'Nguyễn Ngọc Hữu Khương','05/09/1996',N'Quận 7','025663353',N'Nhân viên bán hàng',5000000,'02/04/2015')
insert into NhanVien values(N'Phạm Thanh Tú','04/09/1996',N'Quận 5','025642355',N'Trưởng phòng',4000000,'02/04/2015')
insert into NhanVien values(N'Nguyễn Mạnh Cường','04/10/1996',N'Quận 10','02553575',N'Nhân viên quét dọn',4000000,'02/04/2015')

insert into KhachHang values(N'Thanh Tú',N'TpHCM','0294929')
insert into KhachHang values(N'Hồng Hà Nhi',N'Bắc Kinh','3542929')
insert into KhachHang values(N'Tập Cận Bình',N'New York','534634')

insert into TaiKhoan values('tu',1,'123',N'Quản lý')
insert into TaiKhoan values('khuong',2,'123',N'Bán hàng')

insert into DichVu values(N'Thay nhớt',N'Bảo trì', 100000)
insert into DichVu values(N'Kiểm tra định kỳ',N'Bảo trì', 0)
insert into DichVu values(N'Thay sên',N'Sửa chữa', 75000)
insert into DichVu values(N'Sửa cổ phuộc',N'Sửa chữa', 250000)

GO

create view Reports
as
select * from ChiTietHoaDon

GO

create view ReportDV
as
select ChiTietDichVu.*,DichVu.TenDV,DichVu.LoaiDV from ChiTietDichVu,DichVu where ChiTietDichVu.MaDV=DichVu.MaDV
