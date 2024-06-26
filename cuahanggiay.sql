CREATE DATABASE cuahang_bangiay
CREATE TABLE TaiKhoan (
 MaTaiKhoan INT NOT NULL,
 HoTen NVARCHAR(50) NOT NULL,
 TaiKhoan NVARCHAR(50) NOT NULL,
 MatKhau NVARCHAR(50) NOT NULL,
 Quyen INT NOT NULL,
 TrangThai INT NOT NULL,
 PRIMARY KEY (MaTaiKhoan)
);
INSERT INTO TaiKhoan (MaTaiKhoan, HoTen, TaiKhoan, MatKhau, Quyen, TrangThai) VALUES
(1, N'Đoàn Tuấn Khanh', 'tuankhanh', '123', 1, 1),
(2, N'Huỳnh Ngọc Sơn', 'ngocson', '123', 2, 1);
CREATE TABLE NhanVien (
 MaNV INT NOT NULL,
 HoNV NVARCHAR(50) NOT NULL,
 TenNV NVARCHAR(50) NOT NULL,
 DCHI NVARCHAR(50) NOT NULL,
 TaiKhoan NVARCHAR(50) NOT NULL,
 MatKhau NVARCHAR(50) NOT NULL,
 NgayVaoLam Date Not null,
 MaChucVu INT NOT NULL,
 TrangThai INT NOT NULL,
 PRIMARY KEY (MaNV)
);
INSERT INTO NhanVien (MaNV, HoNV, TenNV, DCHI, TaiKhoan,MatKhau,NgayVaoLam,MaChucVu, TrangThai) VALUES
(1, N'Nguyễn', N'Vân Anh', N'139 Nguyễn Hữu Cầu,Q10,HCM','vananh', '12345','2/3/2003',1,1),
(2, N'Trần', N'Văn Bình', N'189 Đặng Thùy Trâm,Q9,HCM','vanbinh', '12345','4/8/2010',2,1);
CREATE TABLE LoaiGiay (
    MaTheLoai INT PRIMARY KEY ,
    TenTheLoai NVARCHAR(255) NOT NULL,
	TrangThai INT NOT NULL,
);
INSERT INTO LoaiGiay (MaTheLoai, TenTheLoai, TrangThai)
VALUES (1, N'Giày Thể Thao', 1),
 (2, N'Giày Sneaker ', 1),
 (3, N'Giày Adidas', 1);
CREATE TABLE Giay (
    MaGiay INT PRIMARY KEY ,
    TenGiay NVARCHAR(255) NOT NULL,
    Size INT NOT NULL,
    Gia INT NOT NULL,
    MaNCC int NOT NULL,
    Hinh NVARCHAR(255) NULL,
    MaLoai INT NOT NULL,
	TrangThai INT NOT NULL,
);

INSERT INTO Giay (MaGiay, TenGiay, Size, Gia, MaNCC, Hinh, MaLoai, TrangThai)
VALUES (1,N'NIke',38,700000,4,'giay.jpg',8,1),
(2,N'Gucci',42,799000,6,'Gucci.jpg',9,1),
(3,N'Dior',35,990000,4,'dior.jpg',10,1);

 select * from giay
CREATE TABLE ChucVu (
    MaChucVu INT PRIMARY KEY ,
    TenChucVu NVARCHAR(255) NOT NULL,
	TrangThai INT NOT NULL,
);
CREATE TABLE HoaDon (
    MaHD INT NOT NULL,
	NgayLap date Not null,
	 MaNhanVien INT NOT NULL,
	 TrangThai INT NOT NULL,
	 TongTien int not null,
	 TenKhachHang nvarchar(50) not null,
	PRIMARY KEY (MaHD)
 );
 INSERT INTO HoaDon(MaHD, NgayLap, MaNhanVien, TrangThai, TongTien, TenKhachHang)
VALUES (1,'9/5/2023',2,1,3000000,N'Nguyễn Văn A'),
(2,'5/9/2023',3,0,2000000,N'Nguyễn Văn B'),
(3,'10/5/2023',1,1,1000000,N'Nguyễn Thị Tốt');
select * from HoaDon
 drop table HoaDon
 CREATE TABLE ChiTietHoaDon (
	 MaCTHD int not null,
	 MaHD INT NOT NULL,
	 MaGiay int Not null,
	 Size INT NOT NULL,
	 SoLuong INT NOT NULL,
	 DonGia int not null,
	 GiaGoc int not null,
	 KhuyenMai int not null,
	 ThanhTien int not null,
	PRIMARY KEY (MaHD,MaGiay)
 );
  INSERT INTO ChiTietHoaDon(MaCTHD, MaHD, MaGiay, Size, SoLuong, DonGia,GiaGoc, KhuyenMai,ThanhTien)
VALUES (1,3,3,38,10,230000,200000,10000,300000),
(2,2,4,42,10,250000,210000,20000,400000),
(3,1,5,44,10,250000,210000,30000,400000);
drop table ChiTietHoaDon
 CREate table NhaCungCap(
    MANCC int not null,
	TenNCC nvarchar(50) not null,
	 DCHI NVARCHAR(50) NOT NULL,
	 SDT NVARCHAR(50) NOT NULL,
	 MAIL NVARCHAR(50) NOT NULL,
	 TrangThai INT NOT NULL,
	PRIMARY KEY (MANCC)
 );
INSERT INTO  NhaCungCap(MANCC,TenNCC, DCHI, SDT,  MAIL, TrangThai)
VALUES (1,'Gucci',N'192 Phú Nhuận Q5 HCM','0362764222','haohan@gmail.com',1),
(9,'Dior',N'123 Tân Quy Q7 HCM','0367754222','dior@gmail.com',1),
(4,'LV',N'133 Tân Kiểng Q7 HCM','0857366332','lv@gmail.com',1);
select * from NhaCungCap
 select * from nhanvien

