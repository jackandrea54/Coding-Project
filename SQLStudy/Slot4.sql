create database SLOT4
ON PRIMARY ( name = slot4, filename = 'D:\Coding Project\SQLStudy\Slot4.mdf', size = 10mb, maxsize = 20mb, filegrowth = 2mb )
log on ( name = slot4log, filename = 'D:\Coding Project\SQLStudy\Slot4_log.mdf', size = 5mb, maxsize = 7mb, filegrowth = 1mb )

USE SLOT4;

drop database SLOT4


drop table PHONGBAN, DIADIEM

--BAI TOAN PHONG BAN VA TRUONG PHONG--------
create table PHONGBAN (TenPhong nvarchar(30), MaPhong int not null, TruongPhong nvarchar(30), NgayNhamChuc datetime)
create table DIADIEM (MaPhong int not null, DiaDiem nvarchar(30) )

insert into PHONGBAN values ('To chuc', 100, '010220191', 2020-09-12),
							('Ke Toan', 101, '010211231', 2020-09-12),
							('Dao Tao', 102, '012131230291', 2020-09-12),
							('Ky thuat', 103, '0901', 2020-09-12) 

insert into DIADIEM values (100, 'Ha Noi'),
							(101, 'Hai Phong'),
							(102, 'Da Nang'),
							(103, 'Ha Noi')
	


with tenphong as (select MaPhong from DIADIEM where DIADIEM.DiaDiem = (select DiaDiem from DIADIEM where MaPhong = 100 ))		
select * from PHONGBAN, tenphong where PHONGBAN.MaPhong = tenphong.MaPhong	



----BAI TOAN PHAN CONG NHAN VIEN----------
create table PHANCONG (MaNV nvarchar(30), MaDuAn int, STT int ,ThoiGian datetime)
create table NHANVIEN (HoNV nvarchar(10), TenLot nvarchar(10) ,TenNV nvarchar(10), MaNV nvarchar(30), NgaySinh datetime, DiaChi nvarchar(10), 
						GioiTinh nvarchar(10), Luong int, MaNguoiQL nvarchar(30), MaPhong int, PRIMARY KEY (MaNV) )

drop table NHANVIEN
drop table PHANCONG
insert into PHANCONG values ('01001002',1,1,2002-22-12),
							('01001001',1,2,2002-22-12),
							('01001003',2,4,2002-22-12)

insert into NHANVIEN values ('Le','Van','Quyet','01001001', 2003-07-08, 'Ha Noi', 'Nam', 3000, '01001001', 100),
							('To','Quang','Nam','01001002', 2003-07-08, 'Ha Nam', 'Nam', 4000, '01001001', 100),
							('Pham','Thanh','An','01001003', 2003-07-08, 'Nam Dinh', 'Nu', 7000, '01001003', 102),
							('Nguyen','Thuy','Duong','01001004', 2003-07-08, 'Vinh Phuc', 'Nu', 5000, '01001001', 101),
							('Hoang','Huyen','Thuong','01001005', 2003-07-08, 'Vinh Phuc', 'Nu', 5000, '01001001', 103)
	
--Cach 1: Cach nhanh nhat--						
select * from NHANVIEN where MaNV not in (select MaNV from PHANCONG)

--Cach 2: Dung Join ( bi null) --
SELECT * FROM NHANVIEN 
LEFT JOIN PHANCONG ON NHANVIEN.MaNV = PHANCONG.MaNV 
where PHANCONG.MaNV is null

--Cach 3:  --
with NVPC as (select NHANVIEN.MaNV from NHANVIEN,PHANCONG where NHANVIEN.MaNV = PHANCONG.MaNV)
select * from NHANVIEN where MaNV not in (select MaNV from NVPC)

--Cach 4: Su dung except--
with NVKPC as( select MaNV from NHANVIEN except select MaNV from PHANCONG)
select * from NHANVIEN where MaNV in (select * from NVKPC)