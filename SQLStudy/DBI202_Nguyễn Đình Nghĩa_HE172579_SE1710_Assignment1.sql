create database [Assignment1]
go
create table Students ([StudentID] [int] primary key not null IDENTITY (1,1) , 
						[Name] [nvarchar](50) default 'Ho Va Ten',
						[Address] [nvarchar](200), 
						[Gender] [char](1) CHECK (Gender = 'F' OR Gender = 'M'),
						)

create table Teachers([TeacherID] [int] not null IDENTITY(1,1),
					 [Name] [nvarchar](50),
					 [Address] [nvarchar](200),
					 [Gender] [char](1) CHECK (Gender = 'F' OR Gender = 'M'),
					 CONSTRAINT PK_Teachers_TeacherID primary key (TeacherID))

create table Classes ([ClassID] [int] not null IDENTITY (1,1),
					 [year] [int],
					 [Semester] [char](10),
					 [NoCredits] [int],
					 [courseID] [char](6),
					 [GroupID] [char](6),
					 [TeacherID] [int] not null FOREIGN KEY REFERENCES Teachers(TeacherID),
					 CONSTRAINT PK_Classes_ClassID primary key (ClassID))
					 	
create table Attend ([Slot] [int] ,
					 [Date] [date] ,
					 [Attend] [bit],
					 [StudentID] [int] not null FOREIGN KEY REFERENCES Students(StudentID),
					 [ClassID] [int] not null FOREIGN KEY REFERENCES Classes(ClassID),
					 PRIMARY KEY(Slot, Date, StudentID, ClassID)
					 )
 -- Bang rieng cho moi quan he nhieu-nhieu thi phai bo sung khoa chinh gom khoa chinh tu 2 bang (StudentID), (ClassID) --


