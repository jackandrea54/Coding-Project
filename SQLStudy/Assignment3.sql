create database QUANLY_SINHVIEN_HPC

create table KHOA (MAKHOA int PRIMARY KEY identity (1, 1) not null, 
				   TENKHOA nvarchar(50)
				   )

create table LOP (
					MALOP char(10) PRIMARY KEY not null , 
					TENLOP nvarchar(50), 
					KHOAHOC char(10),
					MAKHOA int FOREIGN KEY REFERENCES KHOA(MAKHOA) 
					)

create table SINHVIEN (
					MASV int PRIMARY KEY identity (1, 1) not null, 
					HODEM nvarchar(50),
					TEN nvarchar(50),
					NGAYSINH date,
					NOISINH nvarchar(50),
					MALOP char(10) FOREIGN KEY REFERENCES LOP(MALOP) 
					)

insert into KHOA values (N'NGÔN NGỮ VÀ VĂN HOA HÀN QUỐC'),
						(N'CÔNG NGHỆ THÔNG TIN'),
						(N'NGÔN NGỮ VÀ VĂN HOA NHẬT BẢN'),
						(N'ĐIỆN - ĐIỆN TỬ');

insert into LOP values ('19EL1',N'K19.EL3.01', '2019-2022', 1),
					   ('19IT1',N'K19.IT3.01', '2019-2022', 2),
					   ('19IT2',N'K19.IT3.02', '2019-2022', 3),
					   ('19IT3',N'K19.IT3.03', '2019-2022', 4),
					   ('19IT4',N'K19.IT3.04', '2019-2022', 3),
					   ('19JP1',N'K19.JP3.01', '2019-2022', 2),
					   ('KR01',N'K19.KR3...', '2019-2022', 1);

insert into SINHVIEN values (N'NGUYỄN VĂN', N'AN', '2001-08-22', N'HÀ NỘI', '19IT2'),
							(N'NGUYỄN BÁ',N'BÌNH', '2000-07-22', N'HÀ NAM', '19IT2'),
							(N'TRẦN VĂN', N'TUẤN', '2000-08-25', N'HÀ NỘI', '19IT2');

-- Câu 1: Đưa ra danh sách sinh viên có họ đệm là Văn ---
select * from SINHVIEN where (SINHVIEN.HODEM like N'%VĂN');
-- Câu 2: Đưa ra danh sách sinh viên có họ đệm đứng trước tên đệm "VĂN" là 5 kí tự ---
select * from SINHVIEN where (SINHVIEN.HODEM like N'_____VĂN');
-- Câu 3: Đưa ra danh sách sinh viên nơi sinh có chuỗi "Hà Nội" ---
select * from SINHVIEN where (NOISINH like N'HÀ NỘI');
-- Câu 4: Đưa ra danh sách MaSV là 2 và 4 và đưa ra danh sách Masv không thuộc 2 và 4 ---
select * from SINHVIEN where (MASV = 2 or MASV = 4);
select * from SINHVIEN where (MASV <> 2 and MASV != 4); ---2 cach ghi dau khac nhau : <>, !=
-- Câu 5: Đưa ra danh sách sinh viên có MaSV từ 2 cho đến 4 ---
select * from SINHVIEN where MASV between 2 and 4;
-- Câu 6: Đưa ra danh sách lớp có tên lớp là 'K19.IT3.01' và có khóa học là 2019-2022  ---
select * from LOP where TENLOP = 'K19.IT3.01' and KHOAHOC = '2019-2022' ;
-- Câu 7: Lấy danh sách thứ tự các lớp là 2 ký tự cuối của tên lớp trong bảng lớp  ---
SELECT * FROM LOP
ORDER BY RIGHT(TENLOP,2)
--- Câu 8: Đưa ra danh sách ngày sinh của sinh viên trong bảng sinh viên ---
select NGAYSINH from SINHVIEN 