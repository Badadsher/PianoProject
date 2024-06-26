USE [master]
GO
/****** Object:  Database [Pianoo]    Script Date: 26.04.2024 11:12:25 ******/
CREATE DATABASE [Pianoo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pianoo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Pianoo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pianoo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Pianoo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Pianoo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pianoo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pianoo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pianoo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pianoo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pianoo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pianoo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pianoo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pianoo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pianoo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pianoo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pianoo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pianoo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pianoo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pianoo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pianoo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pianoo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pianoo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pianoo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pianoo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pianoo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pianoo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pianoo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pianoo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pianoo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Pianoo] SET  MULTI_USER 
GO
ALTER DATABASE [Pianoo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pianoo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pianoo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pianoo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pianoo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Pianoo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Pianoo] SET QUERY_STORE = OFF
GO
USE [Pianoo]
GO
/****** Object:  Table [dbo].[cart]    Script Date: 26.04.2024 11:12:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cart](
	[IDCart] [int] NOT NULL,
	[PianoID] [int] NOT NULL,
	[IDUser] [int] NOT NULL,
	[PianoModel] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_cart] PRIMARY KEY CLUSTERED 
(
	[IDCart] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 26.04.2024 11:12:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[IDOrder] [int] NOT NULL,
	[IdPiano] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
	[SaleDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[IDOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Piano]    Script Date: 26.04.2024 11:12:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Piano](
	[IDPianino] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_Piano] PRIMARY KEY CLUSTERED 
(
	[IDPianino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 26.04.2024 11:12:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 26.04.2024 11:12:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IdRole] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[cart] ([IDCart], [PianoID], [IDUser], [PianoModel]) VALUES (1, 1, 3, N'Nux cherub')
GO
INSERT [dbo].[Orders] ([IDOrder], [IdPiano], [IdUser], [SaleDate]) VALUES (1, 1, 3, CAST(N'2005-09-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Orders] ([IDOrder], [IdPiano], [IdUser], [SaleDate]) VALUES (2, 2, 5, CAST(N'2024-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Orders] ([IDOrder], [IdPiano], [IdUser], [SaleDate]) VALUES (3, 1, 1, CAST(N'2024-04-26T11:10:54.353' AS DateTime))
GO
INSERT [dbo].[Piano] ([IDPianino], [Price], [Model], [Count]) VALUES (1, 89999, N'Nux cherub', 0)
INSERT [dbo].[Piano] ([IDPianino], [Price], [Model], [Count]) VALUES (2, 24999, N'Roland F701', 3)
INSERT [dbo].[Piano] ([IDPianino], [Price], [Model], [Count]) VALUES (3, 56999, N'Medeli dp280k', 3)
INSERT [dbo].[Piano] ([IDPianino], [Price], [Model], [Count]) VALUES (4, 654999, N'Artesia dp10', 3)
INSERT [dbo].[Piano] ([IDPianino], [Price], [Model], [Count]) VALUES (5, 77699, N'Nux npk10', 9)
INSERT [dbo].[Piano] ([IDPianino], [Price], [Model], [Count]) VALUES (6, 88999, N'Samick s043d', 19)
GO
INSERT [dbo].[Roles] ([ID], [Title]) VALUES (1, N'Админ')
INSERT [dbo].[Roles] ([ID], [Title]) VALUES (2, N'Менеджер')
INSERT [dbo].[Roles] ([ID], [Title]) VALUES (3, N'Юзер')
INSERT [dbo].[Roles] ([ID], [Title]) VALUES (4, N'Удален')
GO
INSERT [dbo].[Users] ([ID], [Email], [PhoneNumber], [Login], [Password], [IdRole]) VALUES (1, N'admin', 123, N'admin', N'admin', 1)
INSERT [dbo].[Users] ([ID], [Email], [PhoneNumber], [Login], [Password], [IdRole]) VALUES (2, N'mng', 123, N'mng', N'mng', 2)
INSERT [dbo].[Users] ([ID], [Email], [PhoneNumber], [Login], [Password], [IdRole]) VALUES (3, N'user', 123, N'user', N'user', 3)
INSERT [dbo].[Users] ([ID], [Email], [PhoneNumber], [Login], [Password], [IdRole]) VALUES (4, N'new@mail.ru', 123123, N'test', N'123123', 4)
INSERT [dbo].[Users] ([ID], [Email], [PhoneNumber], [Login], [Password], [IdRole]) VALUES (5, N'test@mail.ru', 111, N'userr', N'userr', 3)
INSERT [dbo].[Users] ([ID], [Email], [PhoneNumber], [Login], [Password], [IdRole]) VALUES (6, N'asdasdd', 777777, N'deleter', N'deleter', 3)
GO
ALTER TABLE [dbo].[cart]  WITH CHECK ADD  CONSTRAINT [FK_cart_Piano] FOREIGN KEY([PianoID])
REFERENCES [dbo].[Piano] ([IDPianino])
GO
ALTER TABLE [dbo].[cart] CHECK CONSTRAINT [FK_cart_Piano]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Piano] FOREIGN KEY([IdPiano])
REFERENCES [dbo].[Piano] ([IDPianino])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Piano]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [Pianoo] SET  READ_WRITE 
GO
