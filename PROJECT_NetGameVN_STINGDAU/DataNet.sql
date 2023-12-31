USE [master]
GO
/****** Object:  Database [NetGameVN]    Script Date: 26/10/2023 4:26:58 CH ******/
CREATE DATABASE [NetGameVN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NetGameVN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MAYAO\MSSQL\DATA\NetGameVN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NetGameVN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MAYAO\MSSQL\DATA\NetGameVN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [NetGameVN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NetGameVN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NetGameVN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NetGameVN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NetGameVN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NetGameVN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NetGameVN] SET ARITHABORT OFF 
GO
ALTER DATABASE [NetGameVN] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [NetGameVN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NetGameVN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NetGameVN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NetGameVN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NetGameVN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NetGameVN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NetGameVN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NetGameVN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NetGameVN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NetGameVN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NetGameVN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NetGameVN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NetGameVN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NetGameVN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NetGameVN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NetGameVN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NetGameVN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NetGameVN] SET  MULTI_USER 
GO
ALTER DATABASE [NetGameVN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NetGameVN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NetGameVN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NetGameVN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NetGameVN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NetGameVN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'NetGameVN', N'ON'
GO
ALTER DATABASE [NetGameVN] SET QUERY_STORE = OFF
GO
USE [NetGameVN]
GO
/****** Object:  Table [dbo].[tbAdmins]    Script Date: 26/10/2023 4:26:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAdmins](
	[Id_admin] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NOT NULL,
	[fullname] [nvarchar](10) NULL,
	[GroupUser] [nvarchar](30) NULL,
	[isLock] [bit] NULL,
 CONSTRAINT [PK_tbAdmins] PRIMARY KEY CLUSTERED 
(
	[Id_admin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbClient]    Script Date: 26/10/2023 4:26:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbClient](
	[ClientName] [varchar](30) NOT NULL,
	[GroupClientName] [varchar](30) NULL,
	[StatusClient] [nvarchar](50) NULL,
	[Note] [nvarchar](100) NULL,
	[Start] [datetime] NULL,
	[Endtime] [datetime] NULL,
 CONSTRAINT [PK_tbClient] PRIMARY KEY CLUSTERED 
(
	[ClientName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbDichVu]    Script Date: 26/10/2023 4:26:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDichVu](
	[Madv] [int] NOT NULL,
	[Tendv] [nvarchar](50) NULL,
	[Giatien] [float] NULL,
	[soluong] [int] NULL,
	[ngaynhap] [datetime] NULL,
 CONSTRAINT [PK_tbDichVu] PRIMARY KEY CLUSTERED 
(
	[Madv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbdichvunuoc]    Script Date: 26/10/2023 4:26:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbdichvunuoc](
	[MASP] [int] NOT NULL,
	[TENSP] [nvarchar](50) NULL,
	[SOLUONG] [int] NULL,
	[NGAYNHAP] [datetime] NULL,
 CONSTRAINT [PK_tbdichvunuoc] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbGroupClient]    Script Date: 26/10/2023 4:26:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbGroupClient](
	[GroupName] [nvarchar](30) NOT NULL,
	[Discription] [nvarchar](120) NULL,
 CONSTRAINT [PK_GroupClient] PRIMARY KEY CLUSTERED 
(
	[GroupName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbGroupUser]    Script Date: 26/10/2023 4:26:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbGroupUser](
	[GroupName] [nvarchar](30) NOT NULL,
	[TypeName] [varchar](30) NULL,
 CONSTRAINT [PK_tbGroupUser] PRIMARY KEY CLUSTERED 
(
	[GroupName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbLoginUsers]    Script Date: 26/10/2023 4:26:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLoginUsers](
	[MemberID] [int] NOT NULL,
	[ClientName] [varchar](30) NOT NULL,
	[StartTime] [time](7) NULL,
	[UseTime] [time](7) NULL,
	[LeftTime] [time](7) NULL,
 CONSTRAINT [PK_LoginUsers] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC,
	[ClientName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbMembers]    Script Date: 26/10/2023 4:26:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbMembers](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](30) NULL,
	[Password] [varchar](30) NULL,
	[Phone] [char](10) NULL,
	[GroupUser] [nvarchar](30) NULL,
	[CurrentTime] [time](7) NULL,
	[CurrentMoney] [float] NULL,
	[StatusAccount] [nvarchar](20) NULL,
	[Fullname] [nvarchar](50) NULL,
	[Birthday] [datetime] NULL,
 CONSTRAINT [PK_tbMembers] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbAdmins] ON 

INSERT [dbo].[tbAdmins] ([Id_admin], [UserName], [Password], [fullname], [GroupUser], [isLock]) VALUES (3, N'Nghia', N'admin', N'Duy Nghĩa', N'Admin', 0)
INSERT [dbo].[tbAdmins] ([Id_admin], [UserName], [Password], [fullname], [GroupUser], [isLock]) VALUES (4, N'Long', N'admin', N'Du Long', N'Admin', 0)
INSERT [dbo].[tbAdmins] ([Id_admin], [UserName], [Password], [fullname], [GroupUser], [isLock]) VALUES (5, N'Vinh', N'admin', N'Hữu Vinh', N'Admin', 0)
INSERT [dbo].[tbAdmins] ([Id_admin], [UserName], [Password], [fullname], [GroupUser], [isLock]) VALUES (6, N'Duy', N'staff', N'Nhân Duy', N'Staff', 1)
SET IDENTITY_INSERT [dbo].[tbAdmins] OFF
GO
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-1', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-10', N'Máy Lanh', N'USING', N'máy phòng máy l?nh', CAST(N'2023-10-26T03:16:08.780' AS DateTime), NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-11', N'Máy Lanh', N'USING', N'máy phòng máy l?nh', CAST(N'2023-10-26T03:16:13.267' AS DateTime), NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-12', N'Máy Lanh', N'USING', N'máy phòng máy l?nh', CAST(N'2023-10-26T03:16:20.027' AS DateTime), NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-13', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-14', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-15', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-16', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-17', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-18', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-19', N'Máy Lanh', N'USING', N'máy phòng máy l?nh', CAST(N'2023-10-26T13:38:16.653' AS DateTime), NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-2', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-20', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-3', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-4', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-5', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-6', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-7', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-8', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY-9', N'Máy Lanh', N'DISCONNECT', N'máy phòng máy l?nh', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY1', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY10', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY11', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY12', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY13', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY14', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY15', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY16', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY17', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY18', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY19', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY2', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY20', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY3', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY4', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY5', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY6', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY7', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY8', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAY9', N'Mac Dinh', N'DISCONNECT', N'máy phòng thu?ng', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-1', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-10', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-11', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-12', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-13', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-14', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-15', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-2', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-3', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-4', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-5', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-6', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-7', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-8', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
INSERT [dbo].[tbClient] ([ClientName], [GroupClientName], [StatusClient], [Note], [Start], [Endtime]) VALUES (N'MAYVIP-9', N'VIP', N'DISCONNECT', N'máy phòng VIP', NULL, NULL)
GO
INSERT [dbo].[tbDichVu] ([Madv], [Tendv], [Giatien], [soluong], [ngaynhap]) VALUES (1, N'sting dau', 15000, 150, CAST(N'2023-10-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tbDichVu] ([Madv], [Tendv], [Giatien], [soluong], [ngaynhap]) VALUES (2, N'coca', 12000, 20, NULL)
INSERT [dbo].[tbDichVu] ([Madv], [Tendv], [Giatien], [soluong], [ngaynhap]) VALUES (3, N'Pepsi', 12000, 15, NULL)
INSERT [dbo].[tbDichVu] ([Madv], [Tendv], [Giatien], [soluong], [ngaynhap]) VALUES (4, N'Mirinda', 15000, 10, NULL)
GO
INSERT [dbo].[tbGroupClient] ([GroupName], [Discription]) VALUES (N'Mac Đinh', N'Phòng máy thường')
INSERT [dbo].[tbGroupClient] ([GroupName], [Discription]) VALUES (N'Máy Lanh', N'Phòng máy lạnh')
INSERT [dbo].[tbGroupClient] ([GroupName], [Discription]) VALUES (N'Thi Đấu', N'Phòng máy dành cho giải đấu Game')
INSERT [dbo].[tbGroupClient] ([GroupName], [Discription]) VALUES (N'VIP', N'Phòng vip')
GO
INSERT [dbo].[tbGroupUser] ([GroupName], [TypeName]) VALUES (N'Admin', N'Quan Lý')
INSERT [dbo].[tbGroupUser] ([GroupName], [TypeName]) VALUES (N'Hội viên', N'Member')
INSERT [dbo].[tbGroupUser] ([GroupName], [TypeName]) VALUES (N'Khách vãng lai', N'Guest')
INSERT [dbo].[tbGroupUser] ([GroupName], [TypeName]) VALUES (N'Staff', N'Nhân viên')
GO
SET IDENTITY_INSERT [dbo].[tbMembers] ON 

INSERT [dbo].[tbMembers] ([MemberID], [UserName], [Password], [Phone], [GroupUser], [CurrentTime], [CurrentMoney], [StatusAccount], [Fullname], [Birthday]) VALUES (26, N'dulong', N'123', N'0912345678', NULL, CAST(N'03:30:00' AS Time), 35000, NULL, NULL, NULL)
INSERT [dbo].[tbMembers] ([MemberID], [UserName], [Password], [Phone], [GroupUser], [CurrentTime], [CurrentMoney], [StatusAccount], [Fullname], [Birthday]) VALUES (27, N'huuvinh', N'123', N'0812345678', NULL, CAST(N'01:24:00' AS Time), 14000, NULL, NULL, NULL)
INSERT [dbo].[tbMembers] ([MemberID], [UserName], [Password], [Phone], [GroupUser], [CurrentTime], [CurrentMoney], [StatusAccount], [Fullname], [Birthday]) VALUES (28, N'duynghia', N'123', N'0712345678', NULL, CAST(N'06:00:00' AS Time), 60000, NULL, NULL, NULL)
INSERT [dbo].[tbMembers] ([MemberID], [UserName], [Password], [Phone], [GroupUser], [CurrentTime], [CurrentMoney], [StatusAccount], [Fullname], [Birthday]) VALUES (29, N'chua1lanbigank', N'123', N'0612345678', NULL, CAST(N'07:30:00' AS Time), 75000, NULL, NULL, NULL)
INSERT [dbo].[tbMembers] ([MemberID], [UserName], [Password], [Phone], [GroupUser], [CurrentTime], [CurrentMoney], [StatusAccount], [Fullname], [Birthday]) VALUES (30, N'nghialilom', N'123', N'0412345678', NULL, CAST(N'04:30:00' AS Time), 45000, NULL, N'nghiabui', NULL)
SET IDENTITY_INSERT [dbo].[tbMembers] OFF
GO
ALTER TABLE [dbo].[tbAdmins]  WITH CHECK ADD  CONSTRAINT [FK_tbAdmins_tbGroupUser] FOREIGN KEY([GroupUser])
REFERENCES [dbo].[tbGroupUser] ([GroupName])
GO
ALTER TABLE [dbo].[tbAdmins] CHECK CONSTRAINT [FK_tbAdmins_tbGroupUser]
GO
ALTER TABLE [dbo].[tbLoginUsers]  WITH CHECK ADD  CONSTRAINT [FK_tbLoginUsers_tbClient] FOREIGN KEY([ClientName])
REFERENCES [dbo].[tbClient] ([ClientName])
GO
ALTER TABLE [dbo].[tbLoginUsers] CHECK CONSTRAINT [FK_tbLoginUsers_tbClient]
GO
ALTER TABLE [dbo].[tbLoginUsers]  WITH CHECK ADD  CONSTRAINT [FK_tbLoginUsers_tbMembers] FOREIGN KEY([MemberID])
REFERENCES [dbo].[tbMembers] ([MemberID])
GO
ALTER TABLE [dbo].[tbLoginUsers] CHECK CONSTRAINT [FK_tbLoginUsers_tbMembers]
GO
ALTER TABLE [dbo].[tbMembers]  WITH CHECK ADD  CONSTRAINT [FK_tbMembers_tbGroupUser1] FOREIGN KEY([GroupUser])
REFERENCES [dbo].[tbGroupUser] ([GroupName])
GO
ALTER TABLE [dbo].[tbMembers] CHECK CONSTRAINT [FK_tbMembers_tbGroupUser1]
GO
USE [master]
GO
ALTER DATABASE [NetGameVN] SET  READ_WRITE 
GO
