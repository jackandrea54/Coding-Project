create database AP
go
use AP
go
create table KHOA 
(
	MAKH varchar(4) primary key (MAKH) not null,
	TENKH nvarchar(50) not null,
	SLSV int identity(1,1)
	
)
go
create table SINHVIEN
(
	MASV varchar(4) primary key (MASV) not null,
	HOSV nvarchar(30) null,
	TENSV nvarchar(10) not null,
	PHAI nvarchar(4) not null CONSTRAINT CHK_Gender CHECK (PHAI=N'NỮ' OR PHAI='NAM'),
	NGSINH datetime,
	NOISINH nvarchar(30) null,
	MAKH varchar(4) not null constraint pk_MAKH foreign key references KHOA(MAKH),
	HOCBONG money,
	CONSTRAINT CK_khoa_hocbong CHECK(( MAKH= 'CNPM' AND HocBong >= 0) OR (MAKH <> 'CNPM')),
	DIEMTB numeric(4,2),
)

go
create table MONHOC
(
	MAMH varchar(4) primary key (MAMH),
	TENMH nvarchar(35) not null,
	SOTIET tinyint check (SOTIET >=30)not null
)
go
create table KETQUA
(
	MASV varchar(4) FOREIGN KEY REFERENCES SINHVIEN(MASV),
	MAMH varchar(4) foreign key references MONHOC(MAMH),
	LANTHI tinyint not null,
	DIEM numeric(4,2) not null,
	KQ varchar(1),
	primary key (MASV, MAMH, LANTHI),
)

insert into KHOA(MAKH, TENKH)
values 
	('HTTT', N'Hệ thống thông tin'),
	('MANG', N'Mạng và truyền thông'),
	('CNPM', N'Công nghệ phần mền'),
	('KTMT', N'Kỹ thuật máy tính'),
	('KHMT', N'Khoa học máy tính');

insert into	MONHOC (MAMH, TENMH, SOTIET)
values
	('CSDL', N'Cơ sở dữ liệu', '45'),
	('TTNT', N'Trí tuệ nhân tạo', '45'),
	('MMT', N'Mạng máy tinh', '45'),
	('DHMT', N'Đồ họa máy tính', '60'),
	('CTDL', N'Cấu trúc dữ liệu', '60');

insert into SINHVIEN (MASV, HOSV, TENSV, PHAI, NGSINH, NOISINH, MAKH, HOCBONG)
values
	('SV01', N'Lê Kim', N'Lan', N'NỮ', '1990-02-23', N'Hà Nội', 'HTTT', '130000'),
	('SV02', N'Trần Minh', N'Chánh', 'NAM', '1992-12-24', N'Bình Định', 'MANG', '150000'),
	('SV03', N'Lê An', N'Tuyết', N'NỮ', '1991-02-11', N'Hải Phòng', 'HTTT', '170000'),
	('SV04', N'Trần Anh', N'Tuấn', 'NAM', '1993-12-20', N'TpHCM', 'MANG', '80000'),
	('SV05', N'Trần Thị', N'Mai', N'NỮ', '1991-08-12', N'TpHCM', 'CNPM', '0'),
	('SV06', N'Lê Thị Thu', N'Thủy', N'NỮ', '1991-01-02', N'An Giang', 'HTTT', '0'),
	('SV07', N'Nguyễn Kim', N'Thư', N'NỮ', '1990-02-02', N'Hà Nội', 'CNPM', '180000'),
	('SV08', N'Lê Văn', N'Long', 'NAM', '1992-12-08', N'TpHCM', 'HTTT', '130000');

insert into KETQUA (MASV, MAMH, LANTHI, DIEM)
values
	('SV01', 'CSDL', '1' ,'3'),
	('SV01', 'CSDL', '2' ,'6'),
	('SV01', 'TTNT', '1' ,'5.5'),
	('SV01', 'TTNT', '2' ,'6'),
	('SV01', 'MMT',	'1' ,'5'),
	('SV02', 'CSDL', '1' ,'4.5'),
	('SV02', 'CSDL', '2' ,'7'),
	('SV02', 'MMT',	'1'	,'10'),
	('SV02', 'CTDL', '1' ,'9'),
	('SV03', 'CSDL', '1' ,'2'),
	('SV03', 'CSDL', '2' ,'5'),
	('SV03', 'MMT',	'1' ,'2.5'),
	('SV03', 'MMT',	'2' ,'4'),
	('SV04', 'CSDL', '1' ,'4.5'),
	('SV04', 'CTDL', '1' ,'10'),
	('SV05', 'CSDL', '1' ,'7'),
	('SV05', 'MMT',	'1'	,'2.5'),
	('SV05', 'MMT',	'2'	,'5'),
	('SV06', 'TTNT', '1' ,'6'),
	('SV06', 'DHMT', '1' ,'10');

