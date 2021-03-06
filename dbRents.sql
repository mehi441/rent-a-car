USE [master]
GO
/****** Object:  Database [WinFormLayiheDB]    Script Date: 17-May-20 23:51:20 ******/
CREATE DATABASE [WinFormLayiheDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WinFormLayiheDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WinFormLayiheDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WinFormLayiheDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WinFormLayiheDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WinFormLayiheDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WinFormLayiheDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WinFormLayiheDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WinFormLayiheDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WinFormLayiheDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WinFormLayiheDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WinFormLayiheDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET RECOVERY FULL 
GO
ALTER DATABASE [WinFormLayiheDB] SET  MULTI_USER 
GO
ALTER DATABASE [WinFormLayiheDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WinFormLayiheDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WinFormLayiheDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WinFormLayiheDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WinFormLayiheDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WinFormLayiheDB', N'ON'
GO
ALTER DATABASE [WinFormLayiheDB] SET QUERY_STORE = OFF
GO
USE [WinFormLayiheDB]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 17-May-20 23:51:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Phone] [nvarchar](20) NULL,
	[Email] [nvarchar](40) NULL,
	[Password] [nvarchar](250) NULL,
	[Birth] [datetime] NULL,
	[AdedDate] [datetime] NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 17-May-20 23:51:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 17-May-20 23:51:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BrandId] [int] NULL,
	[ModelId] [int] NULL,
	[Number] [nvarchar](15) NULL,
	[Price] [money] NULL,
	[Year] [int] NULL,
	[PassportNumber] [nvarchar](50) NULL,
	[AddedDate] [datetime] NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 17-May-20 23:51:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Surname] [nvarchar](20) NULL,
	[RealId] [nvarchar](20) NULL,
	[DrivingLicence] [nvarchar](20) NULL,
	[Phone] [nvarchar](20) NULL,
	[Email] [nvarchar](30) NULL,
	[Birth] [datetime] NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Models]    Script Date: 17-May-20 23:51:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Models](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BrandId] [int] NULL,
	[Name] [nvarchar](30) NULL,
 CONSTRAINT [PK_Models] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rents]    Script Date: 17-May-20 23:51:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NULL,
	[ClientId] [int] NULL,
	[SellDate] [datetime] NULL,
	[PromiseDate] [datetime] NULL,
	[ReceiveDate] [datetime] NULL,
	[Price] [money] NULL,
	[PenaltyPrice] [money] NULL,
	[AdminId] [int] NULL,
	[ReceiveAdminID] [int] NULL,
 CONSTRAINT [PK_Rents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([Id], [FullName], [Phone], [Email], [Password], [Birth], [AdedDate]) VALUES (1, N'Cavad Babayev', N'051 7070707', N'a', N'as', CAST(N'2020-05-05T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Admins] ([Id], [FullName], [Phone], [Email], [Password], [Birth], [AdedDate]) VALUES (2, N'Qasim Zakirov', N'055 8080808', N'qasim', N'qasim123', CAST(N'1997-04-03T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Admins] ([Id], [FullName], [Phone], [Email], [Password], [Birth], [AdedDate]) VALUES (3, N'Tural Eliyev', N'070 4040404', N'tural', N'tural123', CAST(N'1995-03-03T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Admins] ([Id], [FullName], [Phone], [Email], [Password], [Birth], [AdedDate]) VALUES (4, N'Resid Agayev', N'099 3080808', N's', N's', CAST(N'1985-09-09T00:00:00.000' AS DateTime), CAST(N'2020-05-05T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Admins] OFF
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([Id], [Name]) VALUES (1, N'Hyundai')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (2, N'LADA')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (3, N'Toyota')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (4, N'Nissan')
SET IDENTITY_INSERT [dbo].[Brands] OFF
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (1, 1, 1, N'10-HS-101', 120.0000, 2013, N'5d4f21d5fd2fvd2f1', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (2, 1, 2, N'10-HE-102', 70.0000, 2014, N'sdvs4d5fd1d2', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (3, 1, 3, N'10-HG-103', 140.0000, 2014, N'scsr5df4s548744dc', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (4, 1, 4, N'10-HA-104', 150.0000, 2018, N'94554fd8452s2d', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (5, 1, 7, N'10-HT-107', 100.0000, 2017, N'45s4sfs45s87954s', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (6, 2, 8, N'10-LN-201', 60.0000, 2019, N'89745sds4', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (7, 2, 9, N'10-LP-202', 30.0000, 2010, N'8ed74ff98s4f5', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (8, 2, 8, N'90-LN-201', 40.0000, 2012, N'dfcse945479s4', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (9, 2, 10, N'10-L0-203', 50.0000, 2012, N'sefcdfsd85787sd4cs', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (10, 3, 11, N'10-TC-301', 110.0000, 2014, N'897456sd8cfdc4', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (11, 3, 11, N'90-TC-301', 150.0000, 2020, N'8df5df8d54dfef8', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (12, 3, 13, N'10-TP-303', 100.0000, 2011, N's5s8f5s4cs84f', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (13, 3, 13, N'90-TP-303', 140.0000, 2017, N'8sd4fsd94d9f45sd4', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (14, 3, 15, N'10-TA-304', 90.0000, 2010, N'd87845sd8s7d5s4d', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (15, 4, 16, N'10-NA-401', 80.0000, 2008, N'8s7df45s8d7f5', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (16, 4, 17, N'10-NM-402', 70.0000, 2009, N'987e4das984d5d7', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (17, 4, 18, N'10-NN-403', 130.0000, 2015, N'8d4c5s84cds4', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (18, 4, 19, N'10-NS-404', 75.0000, 2010, N'8as4s84fs5c', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (19, 4, 20, N'10-NT-405', 55.0000, 1013, N'2a45s4dad5s45s', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (36, 2, 10, N'10-CC-007', 50.0000, 2012, N'd4d54fc007', CAST(N'2020-05-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (37, 2, 30, N'10-CC-006', 40.0000, 2012, N'd4d54fc006', CAST(N'2020-05-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Cars] ([Id], [BrandId], [ModelId], [Number], [Price], [Year], [PassportNumber], [AddedDate]) VALUES (38, 3, 15, N'10-YY-085', 200.0000, 2020, N'8585858', CAST(N'2020-05-17T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Cars] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [Name], [Surname], [RealId], [DrivingLicence], [Phone], [Email], [Birth]) VALUES (1, N'Eli', N'Qasimov', N'AA 15412546', N'874519646', N'050 807 78 75', N'adksp@com.az', CAST(N'1980-12-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [RealId], [DrivingLicence], [Phone], [Email], [Birth]) VALUES (2, N'Nicat', N'Haciyev', N'AA 87454976', N'218454161', N'070 705 05 05', N'sdjsd@gmail.com', CAST(N'1994-08-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [RealId], [DrivingLicence], [Phone], [Email], [Birth]) VALUES (3, N'Ravil', N'Eliyev', N'AA 42464166', N'219749425', N'050 505 04 06', N'iosjdlksdmv@gmail.com', CAST(N'1991-07-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [RealId], [DrivingLicence], [Phone], [Email], [Birth]) VALUES (4, N'Elcan', N'Yolcuyev', N'AA 23941444', N'577164415', N'099 456 12 45', N'jybfjgu@gmail.com', CAST(N'1995-04-27T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [RealId], [DrivingLicence], [Phone], [Email], [Birth]) VALUES (5, N'Yusif', N'Cebiyev', N'AA 65141248', N'215653454', N'040 594 85 47', N'sdvcsdc@gmail.com', CAST(N'2000-07-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [RealId], [DrivingLicence], [Phone], [Email], [Birth]) VALUES (6, N'Tofiq', N'Caniyev', N'AA 64554842', N'815468121', N'050 454 26 36', N'sdcsdv@gmail.com', CAST(N'1994-05-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Clients] ([Id], [Name], [Surname], [RealId], [DrivingLicence], [Phone], [Email], [Birth]) VALUES (7, N'Zakir', N'Qasimov', N'AA 49546586', N'15145313', N'051 451 15 26', N'sdvcsc@gmail.com', CAST(N'1973-01-18T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Models] ON 

INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (1, 1, N'Sonata')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (2, 1, N'Elantra')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (3, 1, N'Genesis')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (4, 1, N'Azera')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (5, 1, N'Accent')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (6, 1, N'Santa Fe')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (7, 1, N'Tucson')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (8, 2, N'Niva')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (9, 2, N'Priora')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (10, 2, N'2107')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (11, 3, N'Camry')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (12, 3, N'Corolla')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (13, 3, N'Prado')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (14, 3, N'Prius')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (15, 3, N'Avalon')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (16, 4, N'Altima')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (17, 4, N'Maxima')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (18, 4, N'Navara')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (19, 4, N'Sunny')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (20, 4, N'Teana')
INSERT [dbo].[Models] ([Id], [BrandId], [Name]) VALUES (30, 2, N'2106')
SET IDENTITY_INSERT [dbo].[Models] OFF
SET IDENTITY_INSERT [dbo].[Rents] ON 

INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (43, 1, 6, CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2020-05-16T00:00:00.000' AS DateTime), CAST(N'2020-05-16T00:00:00.000' AS DateTime), 120.0000, 0.0000, 4, 4)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (45, 1, 2, CAST(N'2020-05-13T00:00:00.000' AS DateTime), CAST(N'2020-05-15T00:00:00.000' AS DateTime), CAST(N'2020-05-16T00:00:00.000' AS DateTime), 120.0000, 144.0000, 4, 1)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (46, 1, 6, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-19T00:00:00.000' AS DateTime), 120.0000, 288.0000, 4, 4)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (47, 2, 5, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-18T00:00:00.000' AS DateTime), NULL, 70.0000, NULL, 1, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (48, 3, 4, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-19T00:00:00.000' AS DateTime), NULL, 140.0000, NULL, 4, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (49, 4, 1, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-19T00:00:00.000' AS DateTime), NULL, 150.0000, NULL, 4, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (50, 5, 1, CAST(N'2020-05-20T00:00:00.000' AS DateTime), CAST(N'2020-05-21T00:00:00.000' AS DateTime), NULL, 100.0000, NULL, 4, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (51, 6, 4, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-21T00:00:00.000' AS DateTime), NULL, 60.0000, NULL, 3, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (52, 7, 5, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-23T00:00:00.000' AS DateTime), NULL, 30.0000, NULL, 4, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (53, 9, 7, CAST(N'2020-05-19T00:00:00.000' AS DateTime), CAST(N'2020-05-22T00:00:00.000' AS DateTime), NULL, 50.0000, NULL, 2, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (54, 10, 7, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-17T00:00:00.000' AS DateTime), NULL, 110.0000, NULL, 3, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (55, 11, 4, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-27T00:00:00.000' AS DateTime), NULL, 150.0000, NULL, 4, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (56, 12, 2, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-20T00:00:00.000' AS DateTime), CAST(N'2020-05-23T00:00:00.000' AS DateTime), 100.0000, 360.0000, 4, 3)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (57, 14, 1, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-20T00:00:00.000' AS DateTime), CAST(N'2020-05-20T00:00:00.000' AS DateTime), 90.0000, 0.0000, 4, 4)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (58, 15, 2, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-21T00:00:00.000' AS DateTime), NULL, 80.0000, NULL, 4, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (59, 18, 7, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-20T00:00:00.000' AS DateTime), NULL, 75.0000, NULL, 1, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (60, 36, 2, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-21T00:00:00.000' AS DateTime), NULL, 50.0000, NULL, 4, NULL)
INSERT [dbo].[Rents] ([Id], [CarId], [ClientId], [SellDate], [PromiseDate], [ReceiveDate], [Price], [PenaltyPrice], [AdminId], [ReceiveAdminID]) VALUES (61, 37, 7, CAST(N'2020-05-17T00:00:00.000' AS DateTime), CAST(N'2020-05-19T00:00:00.000' AS DateTime), NULL, 40.0000, NULL, 4, NULL)
SET IDENTITY_INSERT [dbo].[Rents] OFF
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Brands] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Brands]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Models] FOREIGN KEY([ModelId])
REFERENCES [dbo].[Models] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Models]
GO
ALTER TABLE [dbo].[Models]  WITH CHECK ADD  CONSTRAINT [FK_Models_Brands] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([Id])
GO
ALTER TABLE [dbo].[Models] CHECK CONSTRAINT [FK_Models_Brands]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_Rents_Admins] FOREIGN KEY([AdminId])
REFERENCES [dbo].[Admins] ([Id])
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_Rents_Admins]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_Rents_Admins1] FOREIGN KEY([ReceiveAdminID])
REFERENCES [dbo].[Admins] ([Id])
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_Rents_Admins1]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_Rents_Cars] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([Id])
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_Rents_Cars]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_Rents_Clients] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_Rents_Clients]
GO
USE [master]
GO
ALTER DATABASE [WinFormLayiheDB] SET  READ_WRITE 
GO
