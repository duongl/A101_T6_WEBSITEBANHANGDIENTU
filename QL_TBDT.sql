USE [fix]
GO
/****** Object:  Table [dbo].[account]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[displayName] [nvarchar](100) NULL,
	[userName] [varchar](100) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bill]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idAccount] [int] NOT NULL,
	[status] [int] NOT NULL,
	[datepay] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[billInfo]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[billInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idLaptop] [int] NOT NULL,
	[counts] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id] [nchar](10) NOT NULL,
	[name] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[phone] [nchar](50) NULL,
	[sex] [nchar](3) NULL,
	[email] [nchar](20) NULL,
	[idAccount] [int] NULL,
 CONSTRAINT [PK_cilent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[laptop]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[laptop](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
	[productCompany] [nvarchar](100) NOT NULL,
	[monitor] [float] NOT NULL,
	[CPU] [nvarchar](100) NOT NULL,
	[RAM] [nvarchar](100) NOT NULL,
	[Image] [nvarchar](100) NOT NULL,
	[GPU] [nvarchar](100) NULL,
	[HardDisk] [nvarchar](100) NULL,
	[quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[laptopCategory]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[laptopCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staff]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staff](
	[id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Sex] [nchar](3) NULL,
	[Phone] [nchar](50) NULL,
	[idAccount] [int] NULL,
 CONSTRAINT [PK_staff] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier](
	[id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[phone] [int] NULL,
	[email] [nchar](10) NULL,
	[idWareHouse] [int] NULL,
 CONSTRAINT [PK_supplier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transport]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transport](
	[id] [int] NOT NULL,
	[dateship] [date] NULL,
	[address] [nchar](20) NULL,
	[customer] [nvarchar](50) NULL,
	[idBill] [int] NULL,
 CONSTRAINT [PK_transport] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ware house]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ware house](
	[id] [int] NOT NULL,
	[import] [nvarchar](50) NULL,
	[export] [nvarchar](50) NULL,
	[update] [nchar](100) NULL,
	[id transport] [int] NULL,
 CONSTRAINT [PK_ware house] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT ((0)) FOR [type]
GO
ALTER TABLE [dbo].[bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[bill] ADD  DEFAULT (getdate()) FOR [datepay]
GO
ALTER TABLE [dbo].[billInfo] ADD  DEFAULT ((0)) FOR [counts]
GO
ALTER TABLE [dbo].[laptop] ADD  DEFAULT (N'chưa đặt tên') FOR [Name]
GO
ALTER TABLE [dbo].[laptop] ADD  CONSTRAINT [default_quantity]  DEFAULT ((0)) FOR [quantity]
GO
ALTER TABLE [dbo].[bill]  WITH CHECK ADD FOREIGN KEY([idAccount])
REFERENCES [dbo].[account] ([id])
GO
ALTER TABLE [dbo].[billInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[bill] ([id])
GO
ALTER TABLE [dbo].[billInfo]  WITH CHECK ADD FOREIGN KEY([idLaptop])
REFERENCES [dbo].[laptop] ([id])
GO
ALTER TABLE [dbo].[customer]  WITH CHECK ADD  CONSTRAINT [FK_cilent_account] FOREIGN KEY([idAccount])
REFERENCES [dbo].[account] ([id])
GO
ALTER TABLE [dbo].[customer] CHECK CONSTRAINT [FK_cilent_account]
GO
ALTER TABLE [dbo].[laptop]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[laptopCategory] ([id])
GO
ALTER TABLE [dbo].[staff]  WITH CHECK ADD  CONSTRAINT [FK_staff_account] FOREIGN KEY([idAccount])
REFERENCES [dbo].[account] ([id])
GO
ALTER TABLE [dbo].[staff] CHECK CONSTRAINT [FK_staff_account]
GO
ALTER TABLE [dbo].[supplier]  WITH CHECK ADD  CONSTRAINT [FK_supplier_ware house] FOREIGN KEY([idWareHouse])
REFERENCES [dbo].[ware house] ([id])
GO
ALTER TABLE [dbo].[supplier] CHECK CONSTRAINT [FK_supplier_ware house]
GO
ALTER TABLE [dbo].[transport]  WITH CHECK ADD  CONSTRAINT [FK_transport_bill] FOREIGN KEY([idBill])
REFERENCES [dbo].[bill] ([id])
GO
ALTER TABLE [dbo].[transport] CHECK CONSTRAINT [FK_transport_bill]
GO
ALTER TABLE [dbo].[ware house]  WITH CHECK ADD  CONSTRAINT [FK_ware house_transport] FOREIGN KEY([id transport])
REFERENCES [dbo].[transport] ([id])
GO
ALTER TABLE [dbo].[ware house] CHECK CONSTRAINT [FK_ware house_transport]
GO
/****** Object:  StoredProcedure [dbo].[PCD_searchLaptop]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PCD_searchLaptop] @txt_search nvarchar(50)
as
begin 
	select * from laptop where Name like '%'+@txt_search+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[USP_tongLaptop]    Script Date: 12/7/2023 8:15:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_tongLaptop] @soLuong int out
as
begin 
	select @soLuong =  count(*) from laptop
end
GO
