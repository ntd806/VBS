USE [master]
GO
/****** Object:  Database [1781006u1]    Script Date: 3/13/2022 1:08:12 PM ******/
CREATE DATABASE [1781006u1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'1781006u1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\1781006u1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'1781006u1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\1781006u1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [1781006u1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [1781006u1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [1781006u1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [1781006u1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [1781006u1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [1781006u1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [1781006u1] SET ARITHABORT OFF 
GO
ALTER DATABASE [1781006u1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [1781006u1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [1781006u1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [1781006u1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [1781006u1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [1781006u1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [1781006u1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [1781006u1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [1781006u1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [1781006u1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [1781006u1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [1781006u1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [1781006u1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [1781006u1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [1781006u1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [1781006u1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [1781006u1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [1781006u1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [1781006u1] SET  MULTI_USER 
GO
ALTER DATABASE [1781006u1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [1781006u1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [1781006u1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [1781006u1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [1781006u1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [1781006u1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [1781006u1] SET QUERY_STORE = OFF
GO
USE [1781006u1]
GO
/****** Object:  Table [dbo].[category]    Script Date: 3/13/2022 1:08:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[tpye] [tinyint] NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 3/13/2022 1:08:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[role] [varchar](50) NULL,
	[is_block] [int] NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[issue]    Script Date: 3/13/2022 1:08:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[issue](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[order_id] [int] NULL,
	[warehouse_id] [int] NULL,
	[user_id] [int] NULL,
	[created_at] [timestamp] NULL,
	[update_at] [datetime] NULL,
 CONSTRAINT [PK_issue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 3/13/2022 1:08:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permition]    Script Date: 3/13/2022 1:08:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permition](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[type] [tinyint] NULL,
 CONSTRAINT [PK_permition] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 3/13/2022 1:08:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cate_id] [int] NULL,
	[price] [int] NULL,
	[name] [varchar](max) NULL,
	[size] [int] NULL,
	[height] [int] NULL,
	[width] [int] NULL,
	[weight] [int] NULL,
	[created_at] [timestamp] NULL,
	[update_at] [datetime] NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receipt]    Script Date: 3/13/2022 1:08:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[order_id] [int] NULL,
	[user_id] [int] NULL,
	[warehouse_id] [int] NULL,
	[created_at] [timestamp] NULL,
	[update_at] [datetime] NULL,
 CONSTRAINT [PK_receipt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[script]    Script Date: 3/13/2022 1:08:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[warehouse]    Script Date: 3/13/2022 1:08:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[warehouse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](max) NULL,
 CONSTRAINT [PK_warehouse] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[waybill]    Script Date: 3/13/2022 1:08:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[waybill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[origin_id] [int] NULL,
	[destination_id] [int] NULL,
	[user_id] [int] NULL,
	[order_id] [int] NULL,
	[created_at] [timestamp] NULL,
	[update_at] [datetime] NULL,
 CONSTRAINT [PK_waybill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([id], [username], [password], [phone], [role], [is_block]) VALUES (2, N'tiendat', N'E10ADC3949BA59ABBE56E057F20F883E', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
INSERT [dbo].[script] ([column1]) VALUES (N'USE [VB]')
INSERT [dbo].[script] ([column1]) VALUES (N'GO')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[category]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'SET ANSI_NULLS ON')
INSERT [dbo].[script] ([column1]) VALUES (N'SET QUOTED_IDENTIFIER ON')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[category](')
INSERT [dbo].[script] ([column1]) VALUES (N'[id] [int] NOT NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[name] [varchar](50) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[tpye] [tinyint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'(')
INSERT [dbo].[script] ([column1]) VALUES (N'[id] ASC')
INSERT [dbo].[script] ([column1]) VALUES (N')WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]')
INSERT [dbo].[script] ([column1]) VALUES (N') ON [PRIMARY]')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[customer]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[customer](')
INSERT [dbo].[script] ([column1]) VALUES (N'[address] [varchar](max) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[username] [varchar](50) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[password] [varchar](50) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[permition_id] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[phone] [varchar](50) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N') ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[issue]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[issue](')
INSERT [dbo].[script] ([column1]) VALUES (N'[name] [nvarchar](max) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[order_id] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[warehouse_id] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[user_id] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[created_at] [timestamp] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[update_at] [datetime] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_issue] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[order]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[order](')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[order_description]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[order_description](')
INSERT [dbo].[script] ([column1]) VALUES (N'[id] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[product_id] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[amount] [int] NULL')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[permition]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[permition](')
INSERT [dbo].[script] ([column1]) VALUES (N'[type] [tinyint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_permition] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[product]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[product](')
INSERT [dbo].[script] ([column1]) VALUES (N'[cate_id] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[price] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[name] [varchar](max) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[size] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[height] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[width] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[weight] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[receipt]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[receipt](')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_receipt] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[warehouse]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[warehouse](')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_warehouse] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[waybill]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[waybill](')
INSERT [dbo].[script] ([column1]) VALUES (N'[origin_id] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[destination_id] [int] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_waybill] PRIMARY KEY CLUSTERED')
GO
USE [master]
GO
ALTER DATABASE [1781006u1] SET  READ_WRITE 
GO
