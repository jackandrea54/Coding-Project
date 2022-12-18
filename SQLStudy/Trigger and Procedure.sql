-- ban chat Trigger: hien thi mot thong bao hoac mot bay 15i khi insert
CREATE DATABASE SINHVIEN
GO

USE SINHVIEN

CREATE TABLE DIEMSV(
MASV INT idENTITY PRIMARY KEY,
TENSV NVARCHAR (20),
DIEMTOAN FLOAT,
DIEMVAN FLOAT,
DIEMHOA FLOAT,
TONGDIEM FLOAT,
TRUNGBINH FLOAT
)

SELECT * FROM DIEMSV

drop table DIEMSV

SELECT * FROM DIEMSV

insert into DIEMSV(TENSV, DIEMTOAN,DIEMVAN,DIEMHOA) values (N'Hai', 7, 2, 9)

insert into DIEMSV(TENSV,DIEMTOAN,DIEMVAN,DIEMHOA) values (N'Hoa',7 , 11, 9)

insert into DIEMSV(TENSV, DIEMTOAN, DIEMVAN, DIEMHOA) values
(N'Hoa',7,1,9),
(N'Hanh' ,3,6,9),
(N'Huong',7,7,7),
(N'Hai',6,1,9),
(N'Minh',7,3,3),
(N'Ding' ,7,2,9)

-- trigger 1: THONG BAO
create trigger TG1 on DIEMSV for insert
as
declare @x int
set @x=(select Count(*) from inserted)
	print N'Ban vua nhap thanh cong ' + cast (@x as varchar(2)) + ' dong';

drop trigger TG1

insert into DIEMSV(TENSV, DIEMTOAN, DIEMVAN, DIEMHOA) values
(N'Hoa' ,7,20,9),
(N'Hanh' ,3,6,9),
(N'Huong' ,7,7,7),
(N'Hai' ,6,1,9),
(N'Minh' ,7,3,3),
(N'Diing' ,7,2,9)

-- trigger 2: BAY LOI--
-- (neu nhap diem x >10 thi tra ve mot CANH BAO)
-- Chu y: chi dung cho 1 ban ghi) ---
go
CREATE TRIGGER Diemvan_max ON DIEMSV for INSERT, update
AS
if (select DIEMVAN from inserted) < 1 or (select DIEMVAN from inserted) > 10
BEGIN print N'Diem van phai nam trong khoang tu 1 dén 10'
ROLLback transaction
END

drop TRIGGER Diemvan_max

insert into DIEMSV(TENSV, DIEMTOAN, DIEMVAN, DIEMHOA) values
(N'Hoa',7,1,9),
(N'Hanh' ,3,8,9)

SELECT * FROM DIEMSV

-- trigger 3---gioi han so luong 1 lan insert

go
CREATE TRIGGER DIEMSV_SL ON DIEMSV for INSERT
AS
if (select COUNT(*) from inserted) >5
BEGIN print N'vugt s6 lugng 1 lan insert max 1a 5 ban ghi'
ROLLback transaction
END

drop TRIGGER DIEMSV_SL

insert into DIEMSV(TENSV,DIEMTOAN, DIEMVAN,DIEMHOA) values
(N'Hoa' ,7,1,9),
(N'Hanh' ,3,6,9),
(N'Huong' ,7,7,7),
(N'HAi',6,1,9),
(N'Minh' ,7,3,3),
(N'Ding' ,7,2,9)

 

----trigger 4 --Giam sat so luong sv trong lop (ghi chu: xoa bang sé xéa trigger)

select * from DIEMSV

CREATE TRIGGER DIEMSV_LOP ON DIEMSV for INSERT
AS
if (select COUNT(*) from DIEMSV)>20
BEGIN
print N'Vuot so luong sv trong lop'
ROLLback transaction
END

drop TRIGGER DIEMSV_LOP

insert into DIEMSV(TENSV, DIEMTOAN, OLEMVAN,OIEMHOA) values
(N'Hoa' ,7,1,9)

drop table DIEMSV

select * from DIEMSV
--khi xoa bang se xoa Trigger

CREATE TABLE DIEMSV(
MASV INT idENTITY PRIMARY KEY,
TENSV NVARCHAR (20),
DIEMTOAN FLOAT,
DIEMVAN FLOAT,
DIEMHOA FLOAT,
TONGDIEM FLOAT,
TRUNGBINH FLOAT
)

SELECT * FROM DIEMSV

go
-- CHU Y:  KHI XOA BANG THI TRIGGER CUNG BI XOA THEO

CREATE TRIGGER DIEMSV_SLSV4 ON DIEMSV for INSERT
AS
if (select Count(*) from DIEMSV ) > 5
BEGIN
print N'Vuot so luong Sv trong lop la 5'
Rollback transaction
END
		
-- Khi insert du lieu
insert into DIEMSV(TENSV, DIEMTOAN, DIEMVAN,DIEMHOA) values
(N'Hoa' ,7,1,9),
(N'Hanh' ,3,6,9),
(N'Huong' ,7,7,7),
(N'HAi',6,1,9),
(N'Minh' ,7,3,3),
(N'Ding' ,7,2,9)

drop TRIGGER DIEMSV_SLSV4

-- Trigger 5--- DUNG DE UPDATE DATA -update tong diem---
-- CHI TAC DUNG VOI 1 BAN GHI/ INSERT 1 BAN GHI (do tac dung cua lenh update)

go
create trigger UPDATE_DiemSV5 on DIEMSV for INSERT
										as
										update DIEMSV set TONGDIEM = DIEMTOAN+DIEMVAN+DIEMHOA
										where Masv = (select MaSv from inserted)

insert into DIEMSV(TENSV, DIEMTOAN, DIEMVAN,DIEMHOA) values
(N'Hoa' ,7,1,9),
(N'Hanh' ,3,6,9),
(N'Huong' ,7,7,7),
(N'HAi',6,1,9),
(N'Minh' ,7,3,3),
(N'Dung' ,7,2,9)

select * from DIEMSV

drop trigger UPDATE_DiemSV5

--- Trigger 6: Update 2 cot
-- Chi tac dung voi 1 ban ghi/ insert 1 ban ghi (do tac dung cua lenh update)
create trigger UPDATE_DIEMSV6 on DIEMSV for insert
										as
										update DIEMSV set TONGDIEM = DIEMTOAN+DIEMVAN+DIEMHOA
										update DIEMSV set TRUNGBINH = (DIEMTOAN+DIEMVAN+DIEMHOA)/3
										where Masv = (select MaSv from inserted)

drop trigger UPDATE_DIEMSV6

insert into DIEMSV(TENSV, DIEMTOAN, DIEMVAN,DIEMHOA) values
(N'Hoa' ,7,1,9),
(N'Hanh' ,3,6,9),
(N'Huong' ,7,7,7),
(N'HAi',6,1,9),
(N'Minh' ,7,3,3),
(N'Dung' ,7,2,9)

select * from DIEMSV

:--2: PROCEDURE
  -- bán chät procedure: tao hàm, khai báo bién, tao dau ra;
  ---chay ra ket quá khi goi hàm
--procedure 1// хет diem 1 SV
 go
 USE SINHVIEN
 go
                                               I
create procedure proc_XemDiem (@A int)
as
begin
select * from DIEMSV where MASV = @A
end

 Drop procedure proc_XemDiem

-----Test chay chuong trinh, хет diem sinh vien со ma so =7
 select * from DIEMSV
 exec proc XemDiem 7

 drop procedure proc_XemDiem

------- Procedure 2// хет diem nhieu SV

 







 


 


 
 

 

 

