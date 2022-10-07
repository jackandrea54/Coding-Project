create database [QL_DUAN]
--- Cau 1: Tạo bảng, và ràng buộc theo sơ đồ ---
create table PHONG ([MAPHONG] [int] primary key not null IDENTITY (1,1), 
					[TENPHONG] [nvarchar](50) default 'Ten phong',
					)

create table DUAN ([MADUAN] [int] primary key not null IDENTITY (1,1), 
					[TENDUAN] [nvarchar](50) default 'Ten du an',
					[MAPHONG] [int] not null,
					)

create table NHANVIEN ([MANV] [int] primary key not null IDENTITY (1,1), 
					   [HOTEN] [nvarchar](50) default 'Ho va ten',
					   [TUOI] [int] CHECK (TUOI >= 18),
					   [GIOITINH] [nvarchar](10),
					   [LUONG] [int],
					   [MAPHONG] [int] not null,
					   )

---- Cau 2: Nhập dữ liệu theo phụ lục bảng dưới đây ----
SET IDENTITY_INSERT [dbo].[PHONG] ON
insert into PHONG(MAPHONG,TENPHONG) values (101, N'Phòng Hành chính'),
										   (102, N'Phòng Kỹ thuật'),
										   (103, N'Phòng Kỹ thuật điện'),
										   (104, N'Phòng Kế toán'),
										   (105, N'Phòng Điều hành kỹ thuật')
SET IDENTITY_INSERT [dbo].[PHONG] OFF
---------------------------------------------
SET IDENTITY_INSERT [dbo].[DUAN] ON
insert into DUAN(MADUAN,TENDUAN,MAPHONG) values (201, N'Dự án Xây dựng HTM cho khoa CNTT', 102),
												(202, N'Dự án Xây dựng Website bán hàng Hải Anh', 104),
												(203, N'Dự án Phần mềm quản lý Đào tạo HPC', 102),
												(204, N'Dự án Phần mềm quản lý văn bản ESOFT', 101)
		
SET IDENTITY_INSERT [dbo].[DUAN] OFF
---------------------------------------------
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON
insert into NHANVIEN(MANV,HOTEN,TUOI,GIOITINH,LUONG,MAPHONG) values (1011, N'Nguyễn Thành Long',18,N'Nam',5000000,101),
																	(1012, N'Nguyễn Thị Nhàn',27,N'Nữ',5000000,104),
																	(1013, N'Hoàng Anh Tú',18,N'Nam',5000000,101),
																	(1014, N'Lê Đức Quang Huy',36,N'Nam',5000000,104),
																	(1015, N'Lê Đức Phước Long',45,N'Nam',5000000,102)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
---------------------------------------------
--- Them foreign key ---
ALTER TABLE DUAN ADD CONSTRAINT FK_DUAN_MAPHONG FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG)
ALTER TABLE NHANVIEN ADD CONSTRAINT FK_NHANVIEN_MAPHONG FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG)
go
--- Câu 3: Hiển thị các dự án do MAPHONG ‘102’ quản lý  ---
select * from DUAN where(DUAN.MAPHONG = 102)

--- Câu 4: Hiển thị thông tin nhân viên làm việc tại phòng ‘102’ ----
select * from NHANVIEN where(NHANVIEN.MAPHONG = 102)

--- Câu 5 : Đưa ra thông tin nhân viên có tên là Nhàn ----
select * from NHANVIEN where(NHANVIEN.HOTEN like '%Nhàn%')