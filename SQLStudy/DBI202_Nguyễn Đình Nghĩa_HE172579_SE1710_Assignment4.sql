create database QUANLY_NHANGHI_HOTENSV
ON PRIMARY ( name = QUANLY_NHANGHI_HOTENSV, filename = 'D:\Coding Project\SQLStudy\QUANLY_NHANGHI_HOTENSV.mdf', size = 1mb, maxsize = 5mb, filegrowth = 1mb )
log on ( name = quanly_nhanghi_hotensvlog, filename = 'D:\Coding Project\SQLStudy\QUANLY_NHANGHI_HOTENSV_log.mdf', size = 1mb, maxsize = 2mb, filegrowth = 1mb )

---- Buoc 2: Tao bang ----
---- Cac buoc tao bang: KHACHHANG -> PHONG -> DATPHONG -> DONGIA
create table KHACHHANG ([MAKH] [int] not null primary key,
						[HOTEN] [nvarchar](50),
						[DIACHI] [nvarchar](200),
						[DIENTHOAI] [varchar](10)
						)

insert into KHACHHANG values (201, N'Nguyễn Văn Oan', N'Thanh Xuân, Hà Nội', '986773837'),
						     (202, N'Hoàng Hữu Thế', N'Quận 9, Tp HCM', '986773839'),
							 (203, N'Nguyễn Thế Toàn', N'Kinh Môn, Hải Dương', '986893837'),
							 (204, N'Lê Minh Tuân', N'Gang Thép, Thái Nguyên', '985673837')

create table PHONG([MAPHONG] [int] not null primary key,
				   [TENPHONG] [int]
				   )

insert into PHONG values (101 , 101),
						 (102 , 102),
						 (103 , 103),
						 (104 , 104),
						 (201 , 201),
						 (202 , 202),
						 (301 , 301),
						 (303 , 303),
						 (401 , 401),
						 (404 , 404)

create table DATPHONG([MAPHONG] [int] not null  FOREIGN KEY REFERENCES PHONG(MAPHONG),
					  [NGAYDAT] [date],
					  [NGAYSD] [date],
					  [MAKH] [int] not null  FOREIGN KEY REFERENCES KHACHHANG(MAKH),
					  )

insert into DATPHONG values (101, '2020-12-15', '2020-12-16', 202),
							(101, '2020-12-17', '2020-12-20', 202),
							(401, '2020-12-15', '2020-12-16', 204),
							(202, '2020-12-13', '2020-12-18', 203),
							(301, '2020-12-12', '2020-12-19', 201)
					
create table DONGIA([MAPHONG] [int] not null FOREIGN KEY REFERENCES PHONG(MAPHONG),
					[GIA] [int]
					)

insert into DONGIA values    (101 , 180000),
							 (102 , 180000),
							 (103 , 180000),
							 (104 , 170000),
							 (201 , 200000),
							 (202 , 210000),
							 (301 , 350000),
							 (303 , 350000),
							 (401 , 180000),
							 (404 , 350000)
---- Thu thu xoa bang: DONGIA -> DATPHONG -> PHONG -> KHACHHANG
drop table DONGIA
drop table DATPHONG
drop table PHONG
drop table KHACHHANG

----- Buoc 3: Tra loi cau hoi -----		
-- Câu 4: Hiển thị thông tin khách hàng đặt phòng ngày 17/12/2020 ---
-- Cach 1:
With a as (select * from DATPHONG where NGAYDAT = '2020-12-17')
select KHACHHANG.MAKH , HOTEN, DIACHI, DIENTHOAI from KHACHHANG
Inner Join a
on KHACHHANG.MAKH = a.MAKH
-- Cach 2: Tham chieu cot
select * from KHACHHANG where MAKH = (select MAKH from DATPHONG where NGAYDAT = '2020-12-17')

--- Câu 5: Đưa ra thông tin đặt phòng khách sử dụng ngày 18/12/2020 ---
select * from DATPHONG where NGAYSD = '2020-12-18'

--- Câu 6: Sửa lại giá phòng 301 thành 380.000đ ---
Update DONGIA 
set GIA = 380000 where  MAPHONG = 301

--- Câu 7: . Hiển thị thông tin phòng có giá từ 150.000đ đến 200.000đ ---
With b as (select * from DONGIA where GIA between 150000 and 200000)
select PHONG.MAPHONG, PHONG.TENPHONG, b.GIA from  PHONG 
Inner join b
on PHONG.MAPHONG = b.MAPHONG

--- Câu 8: Sắp xếp danh sách đơn giá của phòng theo thứ tự tăng dần ---
select * from DONGIA 
order by GIA ASC

--- Câu 9: Đưa ra thông tin khách hàng có tên là Toàn ---
select * from KHACHHANG where (HOTEN like N'%Toàn%')

--- Câu 10: Cho biết thông tin của khách hàng có địa chỉ tại Thái Nguyên đã đặt phòng ---
-- Cach 1: Dung inner join
With c as (select MAKH from DATPHONG)
select KHACHHANG.MAKH, HOTEN, DIACHI, DIENTHOAI from KHACHHANG
inner join c
on KHACHHANG.MAKH = c.MAKH
where (DIACHI like N'%Thái Nguyên%')
-- Cach 2: THam chieu cot
select * from DATPHONG where MAKH = (select MAKH from KHACHHANG where (DIACHI like N'%Thái Nguyên%'))