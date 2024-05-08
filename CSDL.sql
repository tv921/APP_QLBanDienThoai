CREATE DATABASE CHBDT;
go 
use CHBDT
go
-- Tạo bảng KHACHHANG
CREATE TABLE KHACHHANG (
  MAKH NVARCHAR(50) NOT NULL,
  TENKH NVARCHAR(50) NULL,
  DIENTHOAI NVARCHAR(50)  NULL,
  DIACHI NVARCHAR(100)  NULL,
  PRIMARY KEY (MAKH)
);
--Thêm dữ liệu vào bảng KHACHHANG
INSERT INTO KHACHHANG (MAKH, TENKH, DIACHI, DIENTHOAI)
VALUES
('KH01', N'Nguyễn Quốc Khánh', N'So 910, quan 1, TP.VL', '0909223453'),
('KH02', N'Nguyễn Thị Hân Hân', N'So 220, quan 2, TP.HCM', '0922255576'),
('KH03', N'Trần Văn Cất', N'So 01, Nhi Long, Cang Long, TP.TV', '0935645679'),
('KH04', N'Nguyễn Hoàng Thương', N'Ap Hieu Trung, Xa Hieu Nghia, TP.VL', '0234023499'),
('KH05', N'Lê Thị Khởi', N'Ap Ro 1, Nhi Long, Cang Long, TP.TV', '0962212345'),
('KH06', N'Trần Nhật Huy', N'So 01, Nhi Long, Cang Long, TP.TV', '0932645667'),
('KH07', N'Nguyễn Hoàng Khoa', N'So 880, quan Go Vap, TP.HCM', '0934774513'),
('KH08', N'Nguyễn Thị Hoàng Hoa', N'So 220, quan 2, TP.HCM', '092755576'),
('KH09', N'Lê Thị Hóa', N'Ap Phu Nhuan, Vung Liem, TP.VL', '0935645679')

-- T?o b?ng HANGHOA
CREATE TABLE DIENTHOAI (
  MADT NVARCHAR(50) NOT NULL,
  TENDT NVARCHAR(100)  NULL,
  MANCC NVARCHAR(50) NULL,
  SOLUONG Int NULL,
  GIANHAP Int NULL,
  GIABAN Int NULL,
  PRIMARY KEY (MADT)
);
--Thêm dữ liệu vào bảng HANGHOA
INSERT INTO DIENTHOAI (MADT, TENDT, MANCC, SOLUONG, GIANHAP, GIABAN)
VALUES
('DT01', N'SamSung A32', 'NCC09', '10', '30124727','30524727'),
('DT02', N'Motorola Moto G Stylus', 'NCC05', '10', '180000000','189000000'),
('DT03', N'Vivo V20', 'NCC05', '10', '189000000','190000000'),
('DT04', N'HTC Desire 20 Plus', 'NCC02', '10', '41324000','47456200'),
('DT05', N'Asus Zenfone Max Pro M2 ', 'NCC04', '10', '55000000','56000000'),
('DT06', N'Lenovo Legion Duel', 'NCC05', '10', '148000000', '149000000'),
('DT07', N'Asus Rog Phone', 'NCC04', '10', '56000000','57700000'),
('DT08', N'ZTE Nubia Red Magic 6 Pro', 'NCC02', '10', '36612000','40508600'),
('DT09', N'SamSung A71', 'NCC05', '10', '420000000','421000000'),
('DT10', N'Huawei Nova 7i', 'NCC01', '10', '48000000','54466000'),
('DT11', N'Blackberry Key One', 'NCC01', '10', '139000000','150016000'),
('DT12', N'iPhone 11 64GB', 'NCC03', '10', '51190000','57815500'),
('DT13', N'Xiaomi Redmi 7', 'NCC04', '10', '56000000','57700000'),
('DT14', N'Vsmart 5', 'NCC02', '10', '36612000','40508600')


-- T?o b?ng DONHHANG
CREATE TABLE DONHANG (
  MADH NVARCHAR(50) NOT NULL,
  MAKH NVARCHAR(50) NULL,
  MANV NVARCHAR(50) NULL,
  MADT NVARCHAR(50) NULL,
  SOLUONG Int  NULL,
  GIAMGIA Int  NULL,
  NGAYBAN DATETIME NOT NULL,
  TONGTIEN Int NOT NULL,
  MANCC NVARCHAR(50) NULL,
  PRIMARY KEY (MADH)
);
INSERT INTO DONHANG (MADH, MAKH, MANV, MADT, SOLUONG,GIAMGIA,  NGAYBAN, TONGTIEN, MANCC)
VALUES
('DH01','KH01' , 'NV01', 'DT01', '1','6', '06-01-2023','3052472', 'NCC09'),  
('DH02','KH02' , 'NV02', 'DT05', '1','6', '04-01-2024','5600000', 'NCC04'),--  
('DH03','KH03' , 'NV02', 'DT11', '1','6','04-06-2023','5446600', 'NCC01'),  
('DH04','KH04' , 'NV02', 'DT05', '1','6','10-01-2023','18900000', 'NCC04'),  
('DH05','KH05' , 'NV02', 'DT07', '1','6', '12-09-2023','4112400', 'NCC04'),  
('DH06','KH06' , 'NV02', 'DT08', '1','6', '2023-11-08','14900000', 'NCC02')    
   
-- T?o b?ng Nhanvien
CREATE TABLE NHANVIEN (
  MANV NVARCHAR(50) NOT NULL,
  TENNV NVARCHAR(50) NULL,
  GIOITINH NVARCHAR(50) NULL,
  NAMSINH NVARCHAR(50) NULL,
  DIENTHOAI NVARCHAR(50) NULL,
  DIACHI VARCHAR(100) NULL,
  PRIMARY KEY (MANV)
);
-- Thêm dữ liệu vào bảng Nhanvien
INSERT INTO NHANVIEN (MANV, TENNV, GIOITINH, NAMSINH, DIENTHOAI, DIACHI)
VALUES
('NV01', N'Nguyễn Văn An', N'Nam', '1997', '0909123456', N'So 09, đường A2, Phường 1, TP.TV'),
('NV02', N'Nguyễn Thị Bình', N'Nữ', '2002', '0919234567', N'So 20, duong SS, Khom 2, Vinh Long'),
('NV03', N'Trần Văn Cung', N'Nam', '1998', '0929345678', N'So 340B, duong PQR, Phuong 3, TP.TV'),
('NV04', N'Nguyễn Văn Hoài An', N'Nam', '2002', '0909109456', N'So 309, duong b5, Phuong 9, TP.TV'),
('NV05', N'Nguyễn Thị Bích Tuyền', N'Nữ', '1998', '0976676567', N'Đuong An Hung, Khom 2, An Giang'),
('NV06', N'Trần Văn Công Hưng', N'Nam', '2003', '0989345555', N'So 40B, duong An Loi, Ap 3, TP.Ca Mau')

CREATE TABLE NHACUNGCAP (
  MANCC NVARCHAR(50) NOT NULL,
  TENNCC NVARCHAR(100) NOT NULL,
  DIENTHOAI NVARCHAR(11) NOT NULL,
  DIACHI NVARCHAR(100) NOT NULL,
  PRIMARY KEY (MANCC)
);
--Thêm dữ liệu vào bảng NHACUNGCAP
INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIENTHOAI, DIACHI)
VALUES
('NCC01', N'NOKIA', '02943842888', N'So 403, duong Nguyen Đang, Phuong 6, TP.Tra Vinh'),
('NCC02', N'SONY', '0939991259', N'So 320, duong Nguyen Thi Minh Khai, Phuong 7, TP.Tra Vinh'),
('NCC03', N'VIVO', '0938223215', N'2A, duong Pho Quang, Phuong 2, Tan Binh, TP.HCM'),
('NCC04', N'SAMSUNG', '287776383', N'So 177A, duong Phan Đang Luu, Phuong 1, Phu Nhuan, TP.HCM'),
('NCC05', N'MOTOROLA', '0903875007', N'52B QL1A, Khu Vuc I, Cai Rang, TP.Can Tho'),
('NCC06', N'APPLE', '02342842888', N'So 403, duong Nguyen Đang, Phuong 6, TP.Tra Vinh'),
('NCC07', N'LENOVO', '0974291259', N'So 320, duong Nguyen Thi Minh Khai, Phuong 7, TP.Tra Vinh'),
('NCC08', N'HUAWEI', '0938231215', N'2A, duong Pho Quang, Phuong 2, Tan Binh, TP.HCM'),
('NCC09', N'VSMART', '0287747214', N'So 177A, duong Phan Đang Luu, Phuong 1, Phu Nhuan, TP.HCM'),
('NCC010', N'XIAOMI', '0934275007', N'52B QL1A, Khu Vuc I, Cai Rang, TP.Can Tho')

ALTER TABLE DONHANG

ALTER COLUMN NGAYBAN date
DROP DATABASE CHBDT;
