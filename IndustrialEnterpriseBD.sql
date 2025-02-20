USE [master]
GO
/****** Object:  Database [IndustrialEnterprise]    Script Date: 16.02.2025 19:04:38 ******/
CREATE DATABASE [IndustrialEnterprise]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IndustrialEnterprise', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\IndustrialEnterprise.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'IndustrialEnterprise_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\IndustrialEnterprise_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [IndustrialEnterprise] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IndustrialEnterprise].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IndustrialEnterprise] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET ARITHABORT OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IndustrialEnterprise] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IndustrialEnterprise] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IndustrialEnterprise] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IndustrialEnterprise] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IndustrialEnterprise] SET  MULTI_USER 
GO
ALTER DATABASE [IndustrialEnterprise] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IndustrialEnterprise] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IndustrialEnterprise] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IndustrialEnterprise] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [IndustrialEnterprise] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [IndustrialEnterprise] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [IndustrialEnterprise] SET QUERY_STORE = ON
GO
ALTER DATABASE [IndustrialEnterprise] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [IndustrialEnterprise]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 16.02.2025 19:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[employee_name] [nvarchar](max) NULL,
	[employee_lastname] [nvarchar](max) NULL,
	[employee_position] [nvarchar](max) NULL,
	[employee_email] [nvarchar](max) NULL,
	[employee_qualifications] [nvarchar](max) NULL,
	[plant_id] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PowerPlants]    Script Date: 16.02.2025 19:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PowerPlants](
	[plant_id] [int] IDENTITY(1,1) NOT NULL,
	[plant_name] [nvarchar](max) NULL,
	[plant_geolocation] [nvarchar](max) NULL,
	[plant_into] [nvarchar](max) NULL,
	[plant_image] [nvarchar](max) NULL,
 CONSTRAINT [PK_PowerPlants] PRIMARY KEY CLUSTERED 
(
	[plant_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 16.02.2025 19:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 16.02.2025 19:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [nvarchar](max) NULL,
	[user_lastname] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[role_id] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([employee_id], [employee_name], [employee_lastname], [employee_position], [employee_email], [employee_qualifications], [plant_id]) VALUES (1, N'Иван', N'Иванов', N'Инженер', N'ivan.ivanov@example.com', N'Высшее техническое', 1)
INSERT [dbo].[Employees] ([employee_id], [employee_name], [employee_lastname], [employee_position], [employee_email], [employee_qualifications], [plant_id]) VALUES (2, N'Петр', N'Петров', N'Электрик', N'petr.petrov@example.com', N'Среднее специально', 1)
INSERT [dbo].[Employees] ([employee_id], [employee_name], [employee_lastname], [employee_position], [employee_email], [employee_qualifications], [plant_id]) VALUES (3, N'Анна', N'Сидорова', N'Механик', N'anna.sidorova@example.com', N'Высшее техническое', 2)
INSERT [dbo].[Employees] ([employee_id], [employee_name], [employee_lastname], [employee_position], [employee_email], [employee_qualifications], [plant_id]) VALUES (4, N'Елена', N'Козлова', N'Инженер-энергетик', N'elena.kozlova@example.com', N'Высшее техническое', 3)
INSERT [dbo].[Employees] ([employee_id], [employee_name], [employee_lastname], [employee_position], [employee_email], [employee_qualifications], [plant_id]) VALUES (16, N'Михаил', N'Смирнов', N'Оператор', N'makhail.smirnov@example.com', N'Среднее', 4)
INSERT [dbo].[Employees] ([employee_id], [employee_name], [employee_lastname], [employee_position], [employee_email], [employee_qualifications], [plant_id]) VALUES (17, N'Ольга', N'Кузнецова', N'Инженер по ТБ', N'olga.kuznetsova@example.com', N'Высшее', 5)
INSERT [dbo].[Employees] ([employee_id], [employee_name], [employee_lastname], [employee_position], [employee_email], [employee_qualifications], [plant_id]) VALUES (18, N'Алексей', N'Иванов', N'Слесарь', N'alexey.ivanov@example.com', N'Среднее специальное', 6)
INSERT [dbo].[Employees] ([employee_id], [employee_name], [employee_lastname], [employee_position], [employee_email], [employee_qualifications], [plant_id]) VALUES (19, N'Дмитрий', N'Морозов', N'Машинист', N'dmitry.morozov@example.com', N'Среднее специальное', 2)
INSERT [dbo].[Employees] ([employee_id], [employee_name], [employee_lastname], [employee_position], [employee_email], [employee_qualifications], [plant_id]) VALUES (20, N'Наталья', N'Соколова', N'Диспетчер', N'natalya.sokolova@example.com', N'Среднее', 3)
INSERT [dbo].[Employees] ([employee_id], [employee_name], [employee_lastname], [employee_position], [employee_email], [employee_qualifications], [plant_id]) VALUES (23, N'Сергей', N'Васильев', N'Электрик-наладчик', N'sergey.vasiliev@example.com', N'Среднее специальное', 4)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[PowerPlants] ON 

INSERT [dbo].[PowerPlants] ([plant_id], [plant_name], [plant_geolocation], [plant_into], [plant_image]) VALUES (1, N'Иркутская ГЭС', N'IrklinGES', N'Гидроэлектростанция', N'D:\C#Project\IndustrialEnterpriseWPF\IndustrialEnterpriseWPF\images\img1.jpg')
INSERT [dbo].[PowerPlants] ([plant_id], [plant_name], [plant_geolocation], [plant_into], [plant_image]) VALUES (2, N'Братская ГЭС', N'BratskGES', N'Гидроэлектростанция', N'D:\C#Project\IndustrialEnterpriseWPF\IndustrialEnterpriseWPF\images\img2.jpg')
INSERT [dbo].[PowerPlants] ([plant_id], [plant_name], [plant_geolocation], [plant_into], [plant_image]) VALUES (3, N'Воложская ГЭС', N'VolgaGES', N'Гидроэлектростанция', N'D:\C#Project\IndustrialEnterpriseWPF\IndustrialEnterpriseWPF\images\img3.jpg')
INSERT [dbo].[PowerPlants] ([plant_id], [plant_name], [plant_geolocation], [plant_into], [plant_image]) VALUES (4, N'Рыбинская ГЭС', N'Rybinsk', N'Гидроэлектростанция', N'D:\C#Project\IndustrialEnterpriseWPF\IndustrialEnterpriseWPF\images\img4.jpg')
INSERT [dbo].[PowerPlants] ([plant_id], [plant_name], [plant_geolocation], [plant_into], [plant_image]) VALUES (5, N'Нурекская ГЭС', N'NurekGES', N'Гидроэлектростанция', N'D:\C#Project\IndustrialEnterpriseWPF\IndustrialEnterpriseWPF\images\img5.jpg')
INSERT [dbo].[PowerPlants] ([plant_id], [plant_name], [plant_geolocation], [plant_into], [plant_image]) VALUES (6, N'Ондская ГЭС', N'OnGES', N'Гидроэлектростанция', N'D:\C#Project\IndustrialEnterpriseWPF\IndustrialEnterpriseWPF\images\img6.jpg')
SET IDENTITY_INSERT [dbo].[PowerPlants] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([role_id], [role_name]) VALUES (1, N'user')
INSERT [dbo].[Roles] ([role_id], [role_name]) VALUES (2, N'admin')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([user_id], [user_name], [user_lastname], [email], [password], [role_id]) VALUES (1, N'Иван', N'Иванов', N'ivan.ivanov@examle.com', N'$b$05$5TqvGn8s7u', 1)
INSERT [dbo].[Users] ([user_id], [user_name], [user_lastname], [email], [password], [role_id]) VALUES (2, N'Алексей', N'Суханов', N'aleksei@sukhanov.com', N'$b$05$AZUC4WJez', 2)
INSERT [dbo].[Users] ([user_id], [user_name], [user_lastname], [email], [password], [role_id]) VALUES (3, N'test', N'user', N'test@user.com', N'111', 2)
INSERT [dbo].[Users] ([user_id], [user_name], [user_lastname], [email], [password], [role_id]) VALUES (4, N'name', N'lastname', N'email@test.ru', N'$b$05$Cob1B2YJK', 1)
INSERT [dbo].[Users] ([user_id], [user_name], [user_lastname], [email], [password], [role_id]) VALUES (8, N'Вэном', N'Вэном', N'venom@venom.com', N'venom', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_PowerPlants1] FOREIGN KEY([plant_id])
REFERENCES [dbo].[PowerPlants] ([plant_id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_PowerPlants1]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([role_id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [IndustrialEnterprise] SET  READ_WRITE 
GO
