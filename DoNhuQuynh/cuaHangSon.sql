Create Database CuaHangSon
Use CuaHangSon
DROP database CuaHangSon
-- TAO BANG NhanVien
create table NhanVien
(
	MaNV			varchar(6),
	TenNV			nvarchar (50),
	SoDienThoaiNV	varchar (20),
	DiaChiNV		nvarchar (150),
	primary key (MaNV)
)
--TAO BANG Hang
create table Hang
(
	MaHH	varchar (6),
	MaMau	varchar (6),
	TenHang nvarchar (20),
	SoLuong int,
	DonGiaNhap int,
	DonGiaBan int,
	primary key (MaHH)
)
--TAO BANG KhachHang
create table KhachHang
(
	MaKH		varchar (6),
	TenKH		nvarchar (50),
	DiaChiKH	nvarchar (100),
	SoDienThoaiKH varchar(15),
	primary key (MaKH)
)
--Tao NCC
create table NhaCungCap
(
	MaNCC		varchar (10),
	TenNCC		nvarchar (50),
	DiaChiNCC	nvarchar (100),
	SoDienThoaiNCC varchar(15),
	primary key (MaNCC)
)
-- TAO BANG Nhap
create table Nhap
(
	MaDNH		varchar (6),
	MaNV		varchar (6), 
	NgayNhap	date,
	Tong		int,
	TongCong	int,
	MaNCC		varchar (10),
	ChietKhau			varchar(20), 
	primary key (MaDNH),
	foreign key (MaNV) references NhanVien,
	foreign key (MaNCC) references NhaCungCap
)

--TAO BANG Nhap_ChiTiet
create table Nhap_ChiTiet
(
	MaDNH	varchar (6),
	MaHH	varchar (6),
	SoLuongNhap int,
	ThanhTien int,
	primary key (MaDNH, MaHH),
	foreign key (MaHH) references Hang,
	foreign key (MaDNH) references Nhap
)
--TAO BANG Xuat
create table Xuat 
( 
	MaDBH		varchar (6),
	MaKH		varchar (6),
	MaNV		varchar (6), 
	Tong		int,
	NgayBan		date,
	primary key (MaDBH),
	foreign key (MaKH) references KhachHang,
	foreign key (MaNV) references NhanVien
)
--TAO BANG Xuat_ChiTiet
create table Xuat_ChiTiet
(
	MaDBH		varchar (6),
	MaHH		varchar (6),
	SoLuongBan		int,
	ThanhTien	int,
	primary key (MaDBH, MaHH),
	foreign key (MaHH) references Hang,
	foreign key (MaDBH) references Xuat,
)

-- INSERT DATA
insert into NhanVien values
	('NV01', N'Nguyễn Thanh Thảo', '0899310465', N'Điện Bàn - Quảng Nam'),
	('NV02', N'Nguyễn Hồ Anh Thư', '0899310465', N'Lạch Giá - Quảng Ngãi'),
	('NV03', N'Đỗ Như Quỳnh', '0899310465', N'Quận 3 - Đà Nẵng'),
	('NV04', N'Mai Thùy Chiêu', '0899310465', N'Thanh Khê - Đà Nẵng')
select * from NhanVien

insert into Hang values
	('001', 'A01', N'Sơn chống thấm 20 kg', 20, 1643000, 1700000),
	('002', 'A02', N'Sơn chống thấm 6 kg', 12, 541000, 600000),
	('003', 'B01', N'Sơn kiềm SPT 18L', 12, 1060000, 1100000),
	('004', 'B02', N'Sơn kiềm SPT 5L', 12, 301000, 350000),
	('005', 'C01', N'Sơn Topsill 1L', 24, 89000, 100000),
	('006', 'D01', N'Sơn Nano Shield 1L', 12, 184000, 200000),
	('007', 'D02', N'Sơn Nano Shield 5L', 6, 987000, 1000000),
	('008', 'E00', N'Bột nội', 6, 185000, 200000),
	('009', 'F00', N'Bột ngoại', 50, 200000, 230000)
select * from Hang

insert into NhaCungCap values 
	('NCC01', N'Phạm Đức Mẹo', N'Thôn La Bông, Xã Hòa Tiến, Hòa Vang, TP Đà Nẵng', '0935185581')
select * from NhaCungCap

insert into KhachHang values 
	('KH01', N'Nguyễn Thành Thủy', N'Quận 3, Đà Nẵng', '0999999999'),
	('KH02', N'Trần Trình', N'Điện Thắng Nam, Điện Bàn, Quảng Nam', '0999999998'),
	('KH03', N'Nguyễn Huy Hoàng', N'Điện Thắng Bắc, Điện Bàn, Quảng Nam', '0905999998'),
	('KH04', N'Nguyễn Thảo Nguyên', N'Nam Phước, Điện Bàn, Quảng Nam', '0899886433'),
	('KH05', N'Đồng Thị Tứ', N'Điện Ngọc, Điện Bàn, Quảng Nam', '0931906808')
select * from KhachHang

insert into Xuat (MaDBH, MaKH, MaNV, NgayBan)
values 
	('HDB01', 'KH01', 'NV01', '2021/01/15'),
	('HDB02', 'KH02', 'NV02', '2021/02/25'),
	('HDB03', 'KH03', 'NV03', '2021/01/10'),
	('HDB04', 'KH04', 'NV04', '2021/03/11'),
	('HDB05', 'KH05', 'NV02', '2021/03/03')
select * from Xuat

insert into Xuat_ChiTiet (MaDBH,MaHH,SoLuongBan)
values 
	('HDB01', '001', 2),
	('HDB02', '003', 1),
	('HDB03', '005', 3),
	('HDB04', '006', 4),
	('HDB05', '001', 5)
select * from Xuat_ChiTiet

insert into Nhap (MaDNH, MaNV, NgayNhap, MaNCC, ChietKhau)
values 
	('HDN01', 'NV01', '2021/01/01', 'NCC01', 0.05),
	('HDN02', 'NV01', '2021/02/01', 'NCC01', 0.05),
	('HDN03', 'NV01', '2021/03/01', 'NCC01', 0.05)
select * from Nhap

insert into Nhap_ChiTiet (MaDNH, MaHH, SoLuongNhap) 
values 
	('HDN01', '001', 10 ),
	('HDN02', '001', 10 ),
	('HDN03', '008', 10)
select * from Nhap_ChiTiet
--Tao bang tai khoan
CREATE TABLE TaiKhoan
(
	TaiKhoan varchar(20),
	MatKhau varchar (50),
	KieuTK char(1),
	primary key (TaiKhoan)
)

insert into TaiKhoan (TaiKhoan, MatKhau, KieuTK)
values
	(N'thuychieu', N'1234', 0),
	(N'nhuquynh', N'1234', 0),
	(N'thanhthao', N'1234', 0),
	(N'anhthu', N'1234', 0),
	(N'quanly', N'1234', 1),
	(N'nhanvien', N'1234', 0)

--- Tinh thanh tien , tong tien
update Xuat_ChiTiet
set ThanhTien=SoLuongBan*DonGiaBan
FROM Xuat_ChiTiet JOIN Hang ON Xuat_ChiTiet.MaHH=Hang.MaHH
select*from Nhap
update Xuat
set Tong = (select sum(ThanhTien)from Xuat_ChiTiet Where MaDBH=Xuat.MaDBH)
select * from Nhap
update Nhap_ChiTiet
set ThanhTien=SoLuongNhap*DonGiaNhap
from Nhap_ChiTiet join Hang on Nhap_ChiTiet.MaHH=Hang.MaHH
update Nhap
set Tong=(select sum(ThanhTien)from Nhap_ChiTiet Where MaDNH=Nhap.MaDNH)
update Nhap
set TongCong=Tong*(1-Cast(ChietKhau as float))

--index 
Go
Create NonClustered Index idx_TenHang on HANG(TenHang) 
Go
Create NonClustered Index idx_SoLuong on HANG(SoLuong)
Go



