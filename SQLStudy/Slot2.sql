create database FALL2022
ON PRIMARY ( name = fall2022, filename = 'D:\Coding Project\SQLStudy\DBI202.mdf', size = 10mb, maxsize = 20mb, filegrowth = 2mb )
log on ( name = fall2022log, filename = 'D:\Coding Project\SQLStudy\DBI202_log.mdf', size = 5mb, maxsize = 7mb, filegrowth = 1mb )


drop database FALL2022 

alter database FALL2022 modify file (name = fall2022, size = 15MB ) /*Thay doi size CSDL */

use FALL2022; /*Goi CSDL Fall2022*/

create table SinhVien (MaSV int not null identity (1,1), 
						HoTen nvarchar(30) default 'Ho Va Ten', NgaySinh datetime, 
						constraint PK_SinhVien_MaSV primary key (MaSV) )
						
drop table SinhVien  

select * from SinhVien

Alter table SinhVien add GPA int  -- thay doi bang, them cot thuoc tinh GPA--

drop table SinhVien 

create table SinhVien (MaSV char (5) not null, HoTen nvarchar(30) default 'Ho Va Ten',
NgaySinh date, DiemTB int, HanhKiem nvarchar (3), constraint PK_SinhVien_MaSV primary key (MaSV)) 

insert into SinhVien values ('HE112', N'Trương Phi', '2000-09-13', 4, N'Tot'),
							('HE113', N'Trieu Tu Long', '1000-09-13', 6, N'Kha'),
							('HE114', N'Quan Vân Trường', '2000-08-12', 5.5, N'Kem');
insert into SinhVien values ('HE172', N'Nguyễn Đình Nghĩa', '2003-08-17',9.5,'Tot'); --Thêm 'N' trước string để nhập dữ liệu Unicode có dấu--

select * from SinhVien
--Thêm cột
alter table SinhVien add SoThich nvarchar(20) --So thich co the bo trong va default la NULL

select * from SinhVien

-- Update du lieu tai ban ghi
update SinhVien set SoThich = N'Đánh nhau' where MaSV = 'HE112'
update SinhVien set SoThich = N'Đánh bằng giáo' where HoTen = N'Trieu Tu Long'
update SinhVien set SoThich = N'Đánh bằng đại đao' where MaSV = 'HE114'

-- /* Lệnh hiển thị một phần bảng */ --

select MaSV, HoTen as 'Ho va Ten', NgaySinh, HanhKiem from SinhVien

-- Tạo file view--

create view XemSV1 as select * from SinhVien where DiemTB < 5 

select * from XemSV1

drop view XemSV1

-- Bai tap thay doi bang: Sua, xoa: cot, dong, thay doi hoac update 1 gia tri bat ky --
select * from SinhVien
--Thay doi thuoc tinh cot--
alter table SinhVien
alter column MaSV Nchar
--Thay doi/ update mot gia tri bat ky
update SinhVien set SoThich = N'Đánh bằng mâu' where MaSV = 'HE112' /*Lệnh điền giá trị*/
update SinhVien set HanhKiem = N'Kém' where MaSV = 'HE112'

--Xoa dong
delete from SinhVien where SinhVien.MaSV = 'HE113'
--Xoa cot
Alter table SinhVien drop column HanhKiem

Alter table SinhVien /* Thay doi bang */

Alter column HanhKiem nvarchar (3);

use FALL2022 /*Goi lai bang*/
select * from SinhVien

select HoTen, MaSV from SinhVien where DiemTB>=5 

--Phep gán --
with a as (select * from SinhVien where DiemTB > 4)
select MaSV from a

-- Tich đề các --
