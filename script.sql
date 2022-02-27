USE [VB]
GO
/****** Object:  Table [dbo].[category]    Script Date: 2/27/2022 10:19:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id] [bigint] NOT NULL,
	[name] [varchar](50) NULL,
	[tpye] [tinyint] NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 2/27/2022 10:19:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id] [bigint] NOT NULL,
	[name] [varchar](50) NULL,
	[address] [varchar](max) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[permition_id] [bigint] NULL,
	[phone] [varchar](50) NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[issue]    Script Date: 2/27/2022 10:19:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[issue](
	[id] [bigint] NOT NULL,
	[name] [nvarchar](max) NULL,
	[order_id] [bigint] NULL,
	[warehouse_id] [bigint] NULL,
	[user_id] [bigint] NULL,
	[created_at] [timestamp] NULL,
	[update_at] [datetime] NULL,
 CONSTRAINT [PK_issue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 2/27/2022 10:19:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[id] [bigint] NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_description]    Script Date: 2/27/2022 10:19:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_description](
	[id] [bigint] NULL,
	[order_id] [bigint] NULL,
	[product_id] [bigint] NULL,
	[amount] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permition]    Script Date: 2/27/2022 10:19:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permition](
	[id] [bigint] NOT NULL,
	[name] [varchar](50) NULL,
	[type] [tinyint] NULL,
 CONSTRAINT [PK_permition] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 2/27/2022 10:19:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [bigint] NOT NULL,
	[cate_id] [bigint] NULL,
	[price] [bigint] NULL,
	[name] [varchar](max) NULL,
	[size] [bigint] NULL,
	[height] [bigint] NULL,
	[width] [bigint] NULL,
	[weight] [bigint] NULL,
	[created_at] [timestamp] NULL,
	[update_at] [datetime] NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receipt]    Script Date: 2/27/2022 10:19:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipt](
	[id] [bigint] NOT NULL,
	[name] [nvarchar](max) NULL,
	[order_id] [bigint] NULL,
	[user_id] [bigint] NULL,
	[warehouse_id] [bigint] NULL,
	[created_at] [timestamp] NULL,
	[update_at] [datetime] NULL,
 CONSTRAINT [PK_receipt] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[warehouse]    Script Date: 2/27/2022 10:19:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[warehouse](
	[id] [bigint] NOT NULL,
	[name] [varchar](max) NULL,
 CONSTRAINT [PK_warehouse] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[waybill]    Script Date: 2/27/2022 10:19:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[waybill](
	[id] [bigint] NOT NULL,
	[origin_id] [bigint] NULL,
	[destination_id] [bigint] NULL,
	[user_id] [bigint] NULL,
	[order_id] [bigint] NULL,
	[created_at] [timestamp] NULL,
	[update_at] [datetime] NULL,
 CONSTRAINT [PK_waybill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
