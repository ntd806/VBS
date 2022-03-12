USE [1781006u1]
GO
/****** Object:  Table [dbo].[category]    Script Date: 3/12/2022 4:34:26 PM ******/
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
/****** Object:  Table [dbo].[customer]    Script Date: 3/12/2022 4:34:26 PM ******/
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
/****** Object:  Table [dbo].[issue]    Script Date: 3/12/2022 4:34:26 PM ******/
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
/****** Object:  Table [dbo].[order]    Script Date: 3/12/2022 4:34:26 PM ******/
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
/****** Object:  Table [dbo].[order_description]    Script Date: 3/12/2022 4:34:26 PM ******/
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
/****** Object:  Table [dbo].[permition]    Script Date: 3/12/2022 4:34:26 PM ******/
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
/****** Object:  Table [dbo].[product]    Script Date: 3/12/2022 4:34:26 PM ******/
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
/****** Object:  Table [dbo].[receipt]    Script Date: 3/12/2022 4:34:26 PM ******/
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
/****** Object:  Table [dbo].[script]    Script Date: 3/12/2022 4:34:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[script](
	[column1] [nvarchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[warehouse]    Script Date: 3/12/2022 4:34:26 PM ******/
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
/****** Object:  Table [dbo].[waybill]    Script Date: 3/12/2022 4:34:26 PM ******/
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
INSERT [dbo].[customer] ([id], [name], [address], [username], [password], [permition_id], [phone]) VALUES (1, N'Nguyen tien dat', N'Ho Chi Minh', N'tiendat', N'E10ADC3949BA59ABBE56E057F20F883E', 1, N'0983455604')
GO
INSERT [dbo].[script] ([column1]) VALUES (N'USE [VB]')
INSERT [dbo].[script] ([column1]) VALUES (N'GO')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[category]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'SET ANSI_NULLS ON')
INSERT [dbo].[script] ([column1]) VALUES (N'SET QUOTED_IDENTIFIER ON')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[category](')
INSERT [dbo].[script] ([column1]) VALUES (N'[id] [bigint] NOT NULL,')
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
INSERT [dbo].[script] ([column1]) VALUES (N'[permition_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[phone] [varchar](50) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N') ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[issue]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[issue](')
INSERT [dbo].[script] ([column1]) VALUES (N'[name] [nvarchar](max) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[order_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[warehouse_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[user_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[created_at] [timestamp] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[update_at] [datetime] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_issue] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[order]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[order](')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[order_description]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[order_description](')
INSERT [dbo].[script] ([column1]) VALUES (N'[id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[product_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[amount] [bigint] NULL')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[permition]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[permition](')
INSERT [dbo].[script] ([column1]) VALUES (N'[type] [tinyint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_permition] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[product]    Script Date: 2/27/2022 10:19:27 AM ******/')
GO
INSERT [dbo].[script] ([column1]) VALUES (N'GO')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[product](')
INSERT [dbo].[script] ([column1]) VALUES (N'[id] [bigint] NOT NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[cate_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[price] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[name] [varchar](max) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[size] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[height] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[width] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[weight] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[created_at] [timestamp] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[update_at] [datetime] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'(')
INSERT [dbo].[script] ([column1]) VALUES (N'[id] ASC')
INSERT [dbo].[script] ([column1]) VALUES (N')WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]')
INSERT [dbo].[script] ([column1]) VALUES (N') ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[receipt]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'SET ANSI_NULLS ON')
INSERT [dbo].[script] ([column1]) VALUES (N'SET QUOTED_IDENTIFIER ON')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[receipt](')
INSERT [dbo].[script] ([column1]) VALUES (N'[name] [nvarchar](max) NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[order_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[user_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[warehouse_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_receipt] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[warehouse]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[warehouse](')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_warehouse] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N'/****** Object:  Table [dbo].[waybill]    Script Date: 2/27/2022 10:19:27 AM ******/')
INSERT [dbo].[script] ([column1]) VALUES (N'CREATE TABLE [dbo].[waybill](')
INSERT [dbo].[script] ([column1]) VALUES (N'[origin_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'[destination_id] [bigint] NULL,')
INSERT [dbo].[script] ([column1]) VALUES (N'CONSTRAINT [PK_waybill] PRIMARY KEY CLUSTERED')
INSERT [dbo].[script] ([column1]) VALUES (N') ON [PRIMARY]')
GO
