USE [master]
GO
/****** Object:  Database [RentACar]    Script Date: 12.09.2023 14:11:34 ******/
CREATE DATABASE [RentACar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentACar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\RentACar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentACar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\RentACar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RentACar] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentACar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentACar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentACar] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentACar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentACar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentACar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentACar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentACar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentACar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentACar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentACar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentACar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentACar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentACar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentACar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentACar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentACar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentACar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentACar] SET  MULTI_USER 
GO
ALTER DATABASE [RentACar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentACar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentACar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentACar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentACar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RentACar] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RentACar] SET QUERY_STORE = ON
GO
ALTER DATABASE [RentACar] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RentACar]
GO
/****** Object:  Table [dbo].[Branches]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[BranchId] [int] IDENTITY(1,1) NOT NULL,
	[BranchName] [varchar](50) NULL,
	[NumberOfEmployees] [int] NULL,
	[Endorsement] [money] NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[BranchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarId] [int] IDENTITY(1,1) NOT NULL,
	[Price] [money] NULL,
	[Plate] [varchar](50) NULL,
	[Brand] [varchar](50) NULL,
	[Model] [varchar](50) NULL,
	[Year] [int] NULL,
	[Engine] [varchar](50) NULL,
	[Color] [varchar](50) NULL,
	[StockAmount] [int] NULL,
	[Gear] [varchar](50) NULL,
	[BranchId] [int] NULL,
	[RentId] [int] NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Age] [int] NULL,
	[Budget] [money] NULL,
	[Depozit] [money] NULL,
	[BranchId] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personnels]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personnels](
	[PersonnelId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Title] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Salary] [money] NULL,
	[BranchId] [int] NULL,
	[Username] [varchar](50) NULL,
	[UserPassword] [varchar](50) NULL,
 CONSTRAINT [PK_Personnels] PRIMARY KEY CLUSTERED 
(
	[PersonnelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rents]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rents](
	[RentId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[CarId] [int] NULL,
	[BranchId] [int] NULL,
	[RentalDate] [date] NULL,
	[RentalPeriod] [int] NULL,
 CONSTRAINT [PK_CustomersAndCars] PRIMARY KEY CLUSTERED 
(
	[RentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Branches] ON 

INSERT [dbo].[Branches] ([BranchId], [BranchName], [NumberOfEmployees], [Endorsement]) VALUES (1, N'Beþiktaþ', 15, 100000.0000)
INSERT [dbo].[Branches] ([BranchId], [BranchName], [NumberOfEmployees], [Endorsement]) VALUES (2, N'Ataþehir', 20, 250000.0000)
INSERT [dbo].[Branches] ([BranchId], [BranchName], [NumberOfEmployees], [Endorsement]) VALUES (3, N'Kadýköy', 40, 500000.0000)
SET IDENTITY_INSERT [dbo].[Branches] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([CarId], [Price], [Plate], [Brand], [Model], [Year], [Engine], [Color], [StockAmount], [Gear], [BranchId], [RentId]) VALUES (4, 300.0000, N'67abc711', N'suzuki', N'vitara', 2018, N'1.6', N'gray', 1, N'auto', 1, 1)
INSERT [dbo].[Cars] ([CarId], [Price], [Plate], [Brand], [Model], [Year], [Engine], [Color], [StockAmount], [Gear], [BranchId], [RentId]) VALUES (5, 700.0000, N'34fb1907', N'audi', N'rs6', 2022, N'1.6', N'black', 1, N'auto', 1, 3)
INSERT [dbo].[Cars] ([CarId], [Price], [Plate], [Brand], [Model], [Year], [Engine], [Color], [StockAmount], [Gear], [BranchId], [RentId]) VALUES (6, 500.0000, N'34dfl014', N'bmw', N'3.20', 2033, N'2.0', N'white', 1, N'auto', 1, NULL)
INSERT [dbo].[Cars] ([CarId], [Price], [Plate], [Brand], [Model], [Year], [Engine], [Color], [StockAmount], [Gear], [BranchId], [RentId]) VALUES (7, 999.0000, N'34otv53', N'audi', N'A8 Long', 2022, N'2.0', N'black', 1, N'auto', 2, 2)
INSERT [dbo].[Cars] ([CarId], [Price], [Plate], [Brand], [Model], [Year], [Engine], [Color], [StockAmount], [Gear], [BranchId], [RentId]) VALUES (9, 250.0000, N'34dfl014', N'togg', N'5.20', 2033, N'2.0', N'white', 1, N'auto', 3, 0)
INSERT [dbo].[Cars] ([CarId], [Price], [Plate], [Brand], [Model], [Year], [Engine], [Color], [StockAmount], [Gear], [BranchId], [RentId]) VALUES (10, 750.0000, N'-', N'Tesla', N'Model Y', 2022, N'Electrical', N'-', 1, N'auto', 2, NULL)
INSERT [dbo].[Cars] ([CarId], [Price], [Plate], [Brand], [Model], [Year], [Engine], [Color], [StockAmount], [Gear], [BranchId], [RentId]) VALUES (12, 400.0000, N'-', N'Nissan', N'Qashqai', 2019, N'1.4', N'white', 1, N'auto', 3, 10)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [FullName], [Phone], [Age], [Budget], [Depozit], [BranchId]) VALUES (6, N'Ali Candan', N'-', 27, 3.0000, 1.0000, 1)
INSERT [dbo].[Customers] ([CustomerId], [FullName], [Phone], [Age], [Budget], [Depozit], [BranchId]) VALUES (7, N'Süleyman Çakýr', N'-', 30, 5.0000, 2.0000, 2)
INSERT [dbo].[Customers] ([CustomerId], [FullName], [Phone], [Age], [Budget], [Depozit], [BranchId]) VALUES (8, N'Duran Emmi', N'-', 60, 10.0000, 5.0000, 1)
INSERT [dbo].[Customers] ([CustomerId], [FullName], [Phone], [Age], [Budget], [Depozit], [BranchId]) VALUES (10, N'Onur Atalay', N'-', 24, 1.0000, 0.0000, 1)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Personnels] ON 

INSERT [dbo].[Personnels] ([PersonnelId], [FullName], [Gender], [Phone], [Title], [Mail], [Salary], [BranchId], [Username], [UserPassword]) VALUES (1, N'Onur Atalay', N'Male', N'5059881057', N'CTO', N'onur@gmail.com', 100000.0000, 1, N'admin', N'admin')
INSERT [dbo].[Personnels] ([PersonnelId], [FullName], [Gender], [Phone], [Title], [Mail], [Salary], [BranchId], [Username], [UserPassword]) VALUES (2, N'Deniz Atalay', N'Female', N'5555555555', N'CEO', N'deniz@gmail.com', 100000.0000, 2, N'deniz', N'deniz')
INSERT [dbo].[Personnels] ([PersonnelId], [FullName], [Gender], [Phone], [Title], [Mail], [Salary], [BranchId], [Username], [UserPassword]) VALUES (3, N'Elmas Atalay', N'Female', N'-', N'CTO', N'elmas@gmail.com', 100000.0000, 1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Personnels] OFF
GO
SET IDENTITY_INSERT [dbo].[Rents] ON 

INSERT [dbo].[Rents] ([RentId], [CustomerId], [CarId], [BranchId], [RentalDate], [RentalPeriod]) VALUES (1, 6, 4, 1, CAST(N'2012-10-13' AS Date), 5)
INSERT [dbo].[Rents] ([RentId], [CustomerId], [CarId], [BranchId], [RentalDate], [RentalPeriod]) VALUES (2, 7, 7, 2, CAST(N'2020-05-21' AS Date), 3)
INSERT [dbo].[Rents] ([RentId], [CustomerId], [CarId], [BranchId], [RentalDate], [RentalPeriod]) VALUES (3, 8, 5, 1, CAST(N'2022-12-17' AS Date), 7)
INSERT [dbo].[Rents] ([RentId], [CustomerId], [CarId], [BranchId], [RentalDate], [RentalPeriod]) VALUES (8, 10, 9, 3, CAST(N'2023-09-11' AS Date), 30)
INSERT [dbo].[Rents] ([RentId], [CustomerId], [CarId], [BranchId], [RentalDate], [RentalPeriod]) VALUES (10, 10, 12, 3, CAST(N'2023-09-12' AS Date), 7)
SET IDENTITY_INSERT [dbo].[Rents] OFF
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Branches] FOREIGN KEY([BranchId])
REFERENCES [dbo].[Branches] ([BranchId])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Branches]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Branches] FOREIGN KEY([BranchId])
REFERENCES [dbo].[Branches] ([BranchId])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Branches]
GO
ALTER TABLE [dbo].[Personnels]  WITH CHECK ADD  CONSTRAINT [FK_Personnels_Branches] FOREIGN KEY([BranchId])
REFERENCES [dbo].[Branches] ([BranchId])
GO
ALTER TABLE [dbo].[Personnels] CHECK CONSTRAINT [FK_Personnels_Branches]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_CustomersAndCars_Branches] FOREIGN KEY([BranchId])
REFERENCES [dbo].[Branches] ([BranchId])
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_CustomersAndCars_Branches]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_CustomersAndCars_Cars] FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([CarId])
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_CustomersAndCars_Cars]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_CustomersAndCars_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_CustomersAndCars_Customers]
GO
/****** Object:  StoredProcedure [dbo].[GetCarsWithBranchName]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetCarsWithBranchName]
@BranchId int
AS BEGIN
SELECT * FROM Cars
WHERE Cars.BranchId = @BranchId
END
GO
/****** Object:  StoredProcedure [dbo].[GetCustomers]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetCustomers]
AS BEGIN
SELECT * FROM Customers
END
GO
/****** Object:  StoredProcedure [dbo].[GetNonRentalCars]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetNonRentalCars]
@BranchId int
AS BEGIN
SELECT Branches.BranchId,CarId,Plate,Brand,Model,Year,Color,Gear,Engine,Price FROM Cars
JOIN Branches ON Cars.BranchId = Branches.BranchId
WHERE (Cars.RentId IS NULL OR Cars.RentId = 0) AND Cars.BranchId = @BranchId
END
GO
/****** Object:  StoredProcedure [dbo].[GetPersonnelsWithBranchName]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetPersonnelsWithBranchName]
@BranchId int
AS BEGIN
SELECT Personnels.PersonnelId,FullName,Personnels.BranchId,Branches.BranchName,Gender,Phone,
Title,Mail,Salary,Username, UserPassword
FROM Personnels LEFT JOIN Branches ON Personnels.BranchId = Branches.BranchId
WHERE Personnels.BranchId = @BranchId
END
GO
/****** Object:  StoredProcedure [dbo].[GetRentalCars]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetRentalCars]
@BranchId int
AS BEGIN
SELECT Cars.RentId,Rents.CarId,Cars.BranchId,RentalDate,RentalPeriod,Customers.FullName,Customers.Age,Customers.Phone,
Customers.Depozit,Cars.Plate,Cars.Brand,Cars.Model,
Cars.Year,Cars.Color,Cars.Gear,Cars.Engine,Cars.Price FROM Rents
JOIN Cars ON Rents.CarId = Cars.CarId 
JOIN Customers ON Rents.CustomerId = Customers.CustomerId
WHERE (Cars.RentId IS NOT NULL AND Cars.RentId > 0) AND  Cars.BranchId = @BranchId
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateRentId]    Script Date: 12.09.2023 14:11:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateRentId]
@RentId int
AS BEGIN
UPDATE Cars SET
RentId = @RentId
FROM Cars JOIN Rents ON Cars.CarId = Rents.CarId
WHERE (Cars.RentId IS NULL OR Cars.RentId = 0) AND Rents.CarId = Cars.CarId 
END
GO
USE [master]
GO
ALTER DATABASE [RentACar] SET  READ_WRITE 
GO
