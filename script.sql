USE [master]
GO
/****** Object:  Database [SchoolManagement]    Script Date: 12/5/2020 4:16:30 PM ******/
CREATE DATABASE [SchoolManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SchoolManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SchoolManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SchoolManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolManagement] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolManagement] SET QUERY_STORE = OFF
GO
USE [SchoolManagement]
GO
/****** Object:  Table [dbo].[Class_]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class_](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [text] NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Name] [text] NULL,
	[Age] [int] NULL,
	[ClassId] [int] NULL,
	[BirthDate] [datetime] NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [text] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject_Class_Rel]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject_Class_Rel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubjectId] [int] NOT NULL,
	[ClassId] [int] NOT NULL,
 CONSTRAINT [PK_Subject_Class_Rel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [text] NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher_Class_Rel]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher_Class_Rel](
	[Id] [int] NOT NULL,
	[TeacherId] [int] NULL,
	[ClassId] [int] NULL,
 CONSTRAINT [PK_Teacher_Class_Rel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Teacher_Class_Rel]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Class_Rel_Class_] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class_] ([Id])
GO
ALTER TABLE [dbo].[Teacher_Class_Rel] CHECK CONSTRAINT [FK_Teacher_Class_Rel_Class_]
GO
/****** Object:  StoredProcedure [dbo].[CreateNewStudent]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
     create   procedure [dbo].[CreateNewStudent] 
@Name text,
@Age int,
@Birthdate datetime

as 
begin 
insert into student (Name,Age,BirthDate) values (@Name,@Age,@Birthdate)
end
GO
/****** Object:  StoredProcedure [dbo].[CreateSubject]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[CreateSubject] 

	 @Name text 
	

as 
begin 
declare @newid INT 

insert into Subject (Name) values (@Name)

select @newid  = max(Id)   FROM Subject
return @newid 

end 
GO
/****** Object:  StoredProcedure [dbo].[DeleteStudent]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create   procedure [dbo].[DeleteStudent] 


	 @Id int 
	
as 
begin 
delete  Student
where Id=@Id
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteSubject]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   CREATE    procedure [dbo].[DeleteSubject] 


	 @Id int 
	
as 
begin 
delete  Subject
where Id=@Id;

delete Subject_Class_Rel  where SubjectId =@Id
end
GO
/****** Object:  StoredProcedure [dbo].[GetStudentByID]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
     create   procedure [dbo].[GetStudentByID] 


	 @Id int 
as 
begin 
select * from Student where Id=@Id
end
GO
/****** Object:  StoredProcedure [dbo].[GetSubjectById]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create      procedure [dbo].[GetSubjectById] 
   
	 @ClassId int 
	
as 
begin 
select * from   Subject
where Id=@ClassId;

select Class_.Id,  Class_.Name

from Subject_Class_Rel  r, Class_   where 
r.SubjectId = @ClassId
and Class_.Id= r.ClassId


end
GO
/****** Object:  StoredProcedure [dbo].[GetTeacherByID]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create         procedure [dbo].[GetTeacherByID] 


  @Id int 
  as 
begin 
select * from teacher where Id=@Id


end
GO
/****** Object:  StoredProcedure [dbo].[GetTeachersAll]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE       procedure [dbo].[GetTeachersAll] 

  as 
begin 
select * from teacher


end
GO
/****** Object:  StoredProcedure [dbo].[InsertSubjectClassRelRecord]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[InsertSubjectClassRelRecord] 

	 @ClassId int,
	 @SubjectId int 

as 
begin 

insert into  [dbo].[Subject_Class_Rel] (SubjectId,ClassId) values (@SubjectId,@ClassId)

end 

GO
/****** Object:  StoredProcedure [dbo].[SelectAllClasses]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   procedure [dbo].[SelectAllClasses] 


as 
begin 

select * from [dbo].[Class_]  

end 

GO
/****** Object:  StoredProcedure [dbo].[SelectStudentsByClass]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SelectStudentsByClass]  @classID int 
AS
SELECT * FROM Student WHERE ClassId=@classID order by Student.Id
GO
/****** Object:  StoredProcedure [dbo].[SelectSubjectsByClass]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SelectSubjectsByClass] 

	 @Id int 	
as 
begin 
select s.Id, s.Name from Subject  s
inner join  Subject_Class_Rel sr

on  s.Id = sr.Id
and sr.ClassId = @Id

end 
GO
/****** Object:  StoredProcedure [dbo].[UpdateStudent]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
     create   procedure [dbo].[UpdateStudent] 


	 @Id int ,
	 @Name text,
	 @Age int,
	 @BirthDate datetime
as 
begin 
update Student set Name=@Name,
Age=@Age,
BirthDate=@BirthDate
where Id=@Id
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateSubject]    Script Date: 12/5/2020 4:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create       procedure [dbo].[UpdateSubject] 


	 @Id int ,
	 @Name text
	
as 
begin 
update   Subject set Name=@Name
where Id=@Id;

end
GO
USE [master]
GO
ALTER DATABASE [SchoolManagement] SET  READ_WRITE 
GO
