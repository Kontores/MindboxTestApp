
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](20) NOT NULL
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (1, 'Drinks')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (2, 'SeaFood')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (3, 'Alcohol')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (4, 'Milk')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (5, 'Vegetables')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (6, 'Electronics')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductCategories] ON 
GO
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (1, 1, 1)
GO
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (2, 2, 6)
GO
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (3, 3, 1)
GO
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (4, 3, 3)
GO
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (5, 4, 1)
GO
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (6, 4, 4)
GO
INSERT [dbo].[ProductCategories] ([Id], [ProductId], [CategoryId]) VALUES (7, 5, 2)
GO
SET IDENTITY_INSERT [dbo].[ProductCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Id], [ProductName]) VALUES (1, 'Sprite')
GO
INSERT [dbo].[Products] ([Id], [ProductName]) VALUES (2, 'Samsung Galaxy')
GO
INSERT [dbo].[Products] ([Id], [ProductName]) VALUES (3, 'Lager Beer')
GO
INSERT [dbo].[Products] ([Id], [ProductName]) VALUES (4, 'The Best Milk')
GO
INSERT [dbo].[Products] ([Id], [ProductName]) VALUES (5, 'Crab')
GO
INSERT [dbo].[Products] ([Id], [ProductName]) VALUES (6, 'Mentos')
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO

