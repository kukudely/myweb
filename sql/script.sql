USE [master]
GO
/****** Object:  Database [mywebsql]    Script Date: 2018/6/19 12:32:48 ******/
CREATE DATABASE [mywebsql] ON  PRIMARY 
( NAME = N'mywebsql', FILENAME = N'E:\asp.net\0608\0608\sql\mywebsql.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mywebsql_log', FILENAME = N'E:\asp.net\0608\0608\sql\mywebsql_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mywebsql].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mywebsql] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mywebsql] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mywebsql] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mywebsql] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mywebsql] SET ARITHABORT OFF 
GO
ALTER DATABASE [mywebsql] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [mywebsql] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mywebsql] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mywebsql] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mywebsql] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mywebsql] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mywebsql] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mywebsql] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mywebsql] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mywebsql] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mywebsql] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mywebsql] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mywebsql] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mywebsql] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mywebsql] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mywebsql] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mywebsql] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mywebsql] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [mywebsql] SET  MULTI_USER 
GO
ALTER DATABASE [mywebsql] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mywebsql] SET DB_CHAINING OFF 
GO
USE [mywebsql]
GO
/****** Object:  Table [dbo].[UserEssay]    Script Date: 2018/6/19 12:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserEssay](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nchar](20) NOT NULL,
	[author] [nvarchar](16) NOT NULL,
	[textpath] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserEssay] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogin]    Script Date: 2018/6/19 12:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](16) NOT NULL,
	[nick] [nchar](10) NULL,
	[pwd] [nvarchar](16) NOT NULL,
	[year] [nchar](10) NULL,
	[mouth] [nchar](10) NULL,
	[day] [nchar](10) NULL,
	[sex] [char](10) NOT NULL,
	[head] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserLogin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserEssay] ON 

INSERT [dbo].[UserEssay] ([id], [title], [author], [textpath]) VALUES (4, N't2                  ', N'xiaoming', N'/txt/t1.txt')
INSERT [dbo].[UserEssay] ([id], [title], [author], [textpath]) VALUES (5, N't3                  ', N'bob', N'/txt/t1.txt')
INSERT [dbo].[UserEssay] ([id], [title], [author], [textpath]) VALUES (7, N't1                  ', N'admin', N'/txt/t1.txt')
INSERT [dbo].[UserEssay] ([id], [title], [author], [textpath]) VALUES (11, N't4                  ', N'admin', N'/txt/t1.txt')
INSERT [dbo].[UserEssay] ([id], [title], [author], [textpath]) VALUES (12, N't5                  ', N'bob', N'/txt/t1.txt')
INSERT [dbo].[UserEssay] ([id], [title], [author], [textpath]) VALUES (13, N't6                  ', N'xiaoming', N'/txt/t1.txt')
INSERT [dbo].[UserEssay] ([id], [title], [author], [textpath]) VALUES (15, N't4                  ', N'admin', N'/txt/t1.txt')
INSERT [dbo].[UserEssay] ([id], [title], [author], [textpath]) VALUES (16, N't66                 ', N'admin', N'/txt/t1.txt')
INSERT [dbo].[UserEssay] ([id], [title], [author], [textpath]) VALUES (19, N'京东定增获得谷歌5.5亿美元入股    ', N'admin', N'/txt/t1.txt')
SET IDENTITY_INSERT [dbo].[UserEssay] OFF
SET IDENTITY_INSERT [dbo].[UserLogin] ON 

INSERT [dbo].[UserLogin] ([id], [UserName], [nick], [pwd], [year], [mouth], [day], [sex], [head]) VALUES (1, N'admin', N'123       ', N'123', N'1997      ', N'12        ', N'12        ', N'男        ', N'/img/touxiang.png')
INSERT [dbo].[UserLogin] ([id], [UserName], [nick], [pwd], [year], [mouth], [day], [sex], [head]) VALUES (9, N'xiaoming', N'mmm       ', N'123', N'1997      ', N'1         ', N'1         ', N'女        ', N'/img/girl.png')
INSERT [dbo].[UserLogin] ([id], [UserName], [nick], [pwd], [year], [mouth], [day], [sex], [head]) VALUES (10, N'bob', N'bob       ', N'123', N'1999      ', N'9         ', N'9         ', N'男        ', N'/img/boy.png')
SET IDENTITY_INSERT [dbo].[UserLogin] OFF
ALTER TABLE [dbo].[UserLogin] ADD  CONSTRAINT [DF_UserLogin_head]  DEFAULT (N'/img/touxiang.png') FOR [head]
GO
USE [master]
GO
ALTER DATABASE [mywebsql] SET  READ_WRITE 
GO
