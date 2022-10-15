--Buoc 1: Tao co so du lieu --
create database DBLab_HPC1
ON PRIMARY ( name = DBLab_HPC1, filename = 'D:\Coding Project\SQLStudy\DBLab_HPC1.mdf', size = 3mb, maxsize = 5mb, filegrowth = 1mb )
log on ( name = DBLab_HPC1log, filename = 'D:\Coding Project\SQLStudy\DBLab_HPC1_log.mdf', size = 1mb, maxsize = 2mb, filegrowth = 1mb )

---- Buoc 2: Tao Bang ----
-- Thu tu tao Bang: Student -> Test -> StudentTest
create table Student([ID] [int] not null PRIMARY KEY IDENTITY(1,1),
					 [Name] [varchar](30),
					 [Age] [tinyint]
					)

insert into Student values ('Nguyen Thi Nhan', 20),
						   ('Tran Van Tuan', 30),
						   ('Le Duc Cuong', 25),
						   ('Tran Van Hung', 23),
						   ('Nguyen Thi Hong', 30)

create table Test([TestID] [int] not null PRIMARY KEY IDENTITY(1,1),
				  [Tname] [varchar](30)
				 )

insert into Test values ('SQL Server'),
						('Access'),
						('Java'),
						('EPC')

create table StudentTest([ID] [int] not null FOREIGN KEY REFERENCES Student(ID),
						 [TestID] [int] not null FOREIGN KEY REFERENCES Test(TestID),
						 [DateTest] [date],
						 [Mark] [float]
						)

insert into StudentTest values (1, 1, '2020-4-19',8),		
							   (1, 2, '2020-4-20',9),	
							   (1, 3, '2020-4-19',7),	
							   (2, 1, '2020-4-19',4),	
							   (2, 2, '2020-4-20',6),	
							   (3, 3, '2020-4-22',8),	
							   (3, 1, '2020-4-21',1)				 

-- Thu tu Xoa Bang: StudentTest -> Test -> Student
drop table StudentTest
drop table Test
drop table Student
----- Buoc 3: Tra loi cau hoi -----
--- Cau 1: Đưa ra điểm của học viên dưới dạng 4 chữ số, sau dấu phẩy 2 chữ số ---
select Student.ID, CONVERT(numeric(4,2), Mark) AS Mark from Student INNER JOIN StudentTest on Student.ID = StudentTest.ID
-- Cau 2: Hiển thị học viên có tuổi >25 ---
select * from Student where Age > 25
-- Cau 3: Hiển thị danh sách học viên có tuổi là 20 hoặc 25 --
select * from Student where Age = 20 or Age = 25
-- Cau 4: Hiển thị những môn học có tên là ký tự ‘s’ --
select * from Test where (Tname COLLATE Latin1_General_BIN like '%s%') -- COLLATE Latin1_General_BIN la de check case-sensitive ----
-- Cau 5: Hiển thị danh sách học viên có điểm >5 ---
select Student.ID, Name, Age, TestID, Mark from Student INNER JOIN StudentTest on Student.ID = StudentTest.ID where Mark > 5
-- Cau 6: Thêm cột Status (Varchar (10)) mặc định có tên là ‘Young’ vào bảng Student --
ALTER TABLE Student
ADD [Status] [varchar](10) not null DEFAULT 'Young';
-- Cau 7: Đưa ra điểm trung bình của các học viên --
select ID, AVG(Mark) as AverageMark from StudentTest GROUP BY ID