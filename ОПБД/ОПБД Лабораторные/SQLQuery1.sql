USE [master]
GO
/****** Object:  Database [ispp2114]    Script Date: 03.06.2024 15:32:03 ******/

GO
ALTER DATABASE [ispp2114] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ispp2114].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ispp2114] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ispp2114] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ispp2114] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ispp2114] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ispp2114] SET ARITHABORT OFF 
GO
ALTER DATABASE [ispp2114] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ispp2114] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ispp2114] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ispp2114] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ispp2114] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ispp2114] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ispp2114] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ispp2114] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ispp2114] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ispp2114] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ispp2114] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ispp2114] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ispp2114] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ispp2114] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ispp2114] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ispp2114] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ispp2114] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ispp2114] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ispp2114] SET  MULTI_USER 
GO
ALTER DATABASE [ispp2114] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ispp2114] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ispp2114] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ispp2114] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ispp2114] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ispp2114] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ispp2114] SET QUERY_STORE = OFF
GO
USE [ispp2114]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 03.06.2024 15:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 03.06.2024 15:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Genre] [nvarchar](10) NOT NULL,
	[Price] [decimal](6, 2) NOT NULL,
	[Weight] [decimal](4, 3) NOT NULL,
	[Pages] [smallint] NOT NULL,
	[PublicationYear] [smallint] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 03.06.2024 15:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CheapGames]    Script Date: 03.06.2024 15:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheapGames](
	[idGame] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[price] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 03.06.2024 15:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](20) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](20) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 03.06.2024 15:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[idGame] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[description] [varchar](500) NULL,
	[category] [varchar](50) NOT NULL,
	[price] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 03.06.2024 15:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[OrderDatetime] [datetime] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderList]    Script Date: 03.06.2024 15:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderList](
	[OrderId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[Amount] [tinyint] NOT NULL,
 CONSTRAINT [PK_OrderList] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PromotionalItem]    Script Date: 03.06.2024 15:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PromotionalItem](
	[PromotionId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PromotionId] ASC,
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prose]    Script Date: 03.06.2024 15:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prose](
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Price] [decimal](6, 2) NOT NULL,
	[PublicationYear] [smallint] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Author] ON 
GO
INSERT [dbo].[Author] ([AuthorId], [Surname], [Name], [Country]) VALUES (1, N'Пушкин', N'Александр', N'Россия')
GO
INSERT [dbo].[Author] ([AuthorId], [Surname], [Name], [Country]) VALUES (3, N'Роулинг', N'Джоан', N'Англия')
GO
INSERT [dbo].[Author] ([AuthorId], [Surname], [Name], [Country]) VALUES (6, N'Лермонтов', N'Михаил', N'Россия')
GO
INSERT [dbo].[Author] ([AuthorId], [Surname], [Name], [Country]) VALUES (7, N'Гоголь', N'Николай', N'Украина')
GO
INSERT [dbo].[Author] ([AuthorId], [Surname], [Name], [Country]) VALUES (9, N'Толстой', N'Лев', N'Россия')
GO
SET IDENTITY_INSERT [dbo].[Author] OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 
GO
INSERT [dbo].[Book] ([BookId], [AuthorId], [Title], [Genre], [Price], [Weight], [Pages], [PublicationYear]) VALUES (1, 3, N'Гарри Поттер', N'другое', CAST(973.20 AS Decimal(6, 2)), CAST(0.700 AS Decimal(4, 3)), 400, 1997)
GO
INSERT [dbo].[Book] ([BookId], [AuthorId], [Title], [Genre], [Price], [Weight], [Pages], [PublicationYear]) VALUES (2, 1, N'Евгений Онегин', N'другое', CAST(827.40 AS Decimal(6, 2)), CAST(0.500 AS Decimal(4, 3)), 200, 1833)
GO
INSERT [dbo].[Book] ([BookId], [AuthorId], [Title], [Genre], [Price], [Weight], [Pages], [PublicationYear]) VALUES (3, 6, N'Герой нашего времени', N'другое', CAST(790.95 AS Decimal(6, 2)), CAST(0.600 AS Decimal(4, 3)), 250, 1840)
GO
INSERT [dbo].[Book] ([BookId], [AuthorId], [Title], [Genre], [Price], [Weight], [Pages], [PublicationYear]) VALUES (5, 7, N'Мёртвые души', N'другое', CAST(863.85 AS Decimal(6, 2)), CAST(0.800 AS Decimal(4, 3)), 300, 1842)
GO
INSERT [dbo].[Book] ([BookId], [AuthorId], [Title], [Genre], [Price], [Weight], [Pages], [PublicationYear]) VALUES (6, 9, N'Война и мир', N'другое ', CAST(1046.10 AS Decimal(6, 2)), CAST(1.200 AS Decimal(4, 3)), 1000, 1869)
GO
INSERT [dbo].[Book] ([BookId], [AuthorId], [Title], [Genre], [Price], [Weight], [Pages], [PublicationYear]) VALUES (7, 1, N'Руслан и Людмила', N'поэзия', CAST(800.00 AS Decimal(6, 2)), CAST(0.400 AS Decimal(4, 3)), 150, 1820)
GO
INSERT [dbo].[Book] ([BookId], [AuthorId], [Title], [Genre], [Price], [Weight], [Pages], [PublicationYear]) VALUES (8, 6, N'Цыганы', N'другое', CAST(754.50 AS Decimal(6, 2)), CAST(0.600 AS Decimal(4, 3)), 200, 1842)
GO
INSERT [dbo].[Book] ([BookId], [AuthorId], [Title], [Genre], [Price], [Weight], [Pages], [PublicationYear]) VALUES (9, 1, N'Капитанская дочка', N'Проза', CAST(800.00 AS Decimal(6, 2)), CAST(0.000 AS Decimal(4, 3)), 0, NULL)
GO
INSERT [dbo].[Book] ([BookId], [AuthorId], [Title], [Genre], [Price], [Weight], [Pages], [PublicationYear]) VALUES (11, 1, N'Сказки о Царе Салтане', N'поэзия', CAST(400.00 AS Decimal(6, 2)), CAST(0.500 AS Decimal(4, 3)), 777, 1000)
GO
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[CheapGames] ON 
GO
INSERT [dbo].[CheapGames] ([idGame], [name], [price]) VALUES (3, N'Battlefield 4', CAST(899.40 AS Decimal(10, 2)))
GO
INSERT [dbo].[CheapGames] ([idGame], [name], [price]) VALUES (4, N'The Sims 4', CAST(15.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[CheapGames] ([idGame], [name], [price]) VALUES (5, N'Dark Souls 2', CAST(949.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[CheapGames] ([idGame], [name], [price]) VALUES (7, N'FIFA 14', CAST(699.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[CheapGames] ([idGame], [name], [price]) VALUES (8, N'Need for Speed Rivals', CAST(15.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[CheapGames] ([idGame], [name], [price]) VALUES (10, N'Dead Space 3', CAST(499.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[CheapGames] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([CustomerId], [Login], [Surname], [Name], [Address], [Phone]) VALUES (2, N'dogduck67', N'Иванов', N'Иван', N'ул. Пушкина, д.15, кв.5', N'89008007060')
GO
INSERT [dbo].[Customer] ([CustomerId], [Login], [Surname], [Name], [Address], [Phone]) VALUES (3, N'homehob1', N'Ломов', N'Руслан', N'ул. Почтовая, д.6, кв.4', N'87776663322')
GO
INSERT [dbo].[Customer] ([CustomerId], [Login], [Surname], [Name], [Address], [Phone]) VALUES (4, N'ilony234789', N'Громов', N'Артур', N'ул. Кедрова, д.11, кв.46', N'85476536655')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Games] ON 
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (1, N'SimCity', N'Градостроительный симулятор снова с вами! Создайте город своей мечты', N'2', CAST(3599.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (2, N'TITANFALL', N'Эта игра перенесет вас во вселенную, где малое противопоставляется большому, природа – индустрии, а человек – машине', N'1', CAST(2499.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (3, N'Battlefield 4', N'Battlefield 4 – это определяющий для жанра, полный экшена боевик, известный своей разрушаемостью, равных которой нет', N'1', CAST(1099.40 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (4, N'The Sims 4', N'В реальности каждому человеку дано прожить лишь одну жизнь. Но с помощью The Sims 4 это ограничение можно снять! Вам решать — где, как и с кем жить, чем заниматься, чем украшать и обустраивать свой дом', N'2', CAST(2115.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (5, N'Dark Souls 2', N'Продолжение знаменитого ролевого экшена вновь заставит игроков пройти через сложнейшие испытания. Dark Souls II предложит нового героя, новую историю и новый мир. Лишь одно неизменно – выжить в мрачной вселенной Dark Souls очень непросто', N'3', CAST(949.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (6, N'The Elder Scrolls V: Skyrim', N'После убийства короля Скайрима империя оказалась на грани катастрофы. Вокруг претендентов на престол сплотились новые союзы, и разгорелся конфликт', N'3', CAST(1399.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (7, N'FIFA 14', N'Достоверный, красивый, эмоциональный футбол! Проверенный временем геймплей FIFA стал ещё лучше благодаря инновациям, поощряющим творческую игру в центре поля и позволяющим задавать её темп', N'2', CAST(2799.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (8, N'Need for Speed Rivals', N'Забудьте про стандартные режимы игры. Сотрите грань между одиночным и многопользовательским режимом в постоянном соперничестве между гонщиками и полицией', N'2', CAST(2115.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (9, N'Crysis 3', N'Действие игры разворачивается в 2047 году, а вам предстоит выступить в роли Пророка', N'1', CAST(1499.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (10, N'Dead Space 3', N'В Dead Space 3 Айзек Кларк и суровый солдат Джон Карвер отправляются в космическое путешествие, чтобы узнать о происхождении некроморфов', N'1', CAST(699.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (11, N'123', NULL, N'2', CAST(2254.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (12, N'123', NULL, N'2', CAST(2254.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Games] ([idGame], [name], [description], [category], [price]) VALUES (13, N'123', NULL, N'2', CAST(2254.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Games] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 
GO
INSERT [dbo].[Order] ([OrderId], [CustomerId], [OrderDatetime]) VALUES (1, 2, CAST(N'2024-04-04T13:59:40.717' AS DateTime))
GO
INSERT [dbo].[Order] ([OrderId], [CustomerId], [OrderDatetime]) VALUES (2, 3, CAST(N'2024-04-04T13:59:42.827' AS DateTime))
GO
INSERT [dbo].[Order] ([OrderId], [CustomerId], [OrderDatetime]) VALUES (3, 4, CAST(N'2024-04-04T13:59:44.220' AS DateTime))
GO
INSERT [dbo].[Order] ([OrderId], [CustomerId], [OrderDatetime]) VALUES (4, 2, CAST(N'2024-04-04T14:00:20.810' AS DateTime))
GO
INSERT [dbo].[Order] ([OrderId], [CustomerId], [OrderDatetime]) VALUES (5, 4, CAST(N'2024-04-04T14:01:08.623' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (1, 1, 1)
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (1, 6, 8)
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (1, 7, 1)
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (2, 1, 5)
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (2, 2, 11)
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (3, 2, 1)
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (3, 3, 1)
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (4, 3, 3)
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (4, 5, 5)
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (5, 2, 1)
GO
INSERT [dbo].[OrderList] ([OrderId], [BookId], [Amount]) VALUES (5, 3, 1)
GO
INSERT [dbo].[Prose] ([Surname], [Name], [Title], [Price], [PublicationYear]) VALUES (N'Пушкин', N'Александр', N'Капитанская дочка', CAST(300.00 AS Decimal(6, 2)), NULL)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_AuthorFullName]    Script Date: 03.06.2024 15:32:03 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_AuthorFullName] ON [dbo].[Author]
(
	[Name] ASC,
	[Surname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_CategoryTitle]    Script Date: 03.06.2024 15:32:03 ******/
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [UQ_CategoryTitle] UNIQUE NONCLUSTERED 
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_CustomerLogin]    Script Date: 03.06.2024 15:32:03 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CustomerLogin] ON [dbo].[Customer]
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Author] ADD  CONSTRAINT [DF_Author_Country]  DEFAULT (N'Россия') FOR [Country]
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_Genre]  DEFAULT (N'Проза') FOR [Genre]
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_Weight]  DEFAULT ((0)) FOR [Weight]
GO
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_Pages]  DEFAULT ((0)) FOR [Pages]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_OrderDatetime]  DEFAULT (getdate()) FOR [OrderDatetime]
GO
ALTER TABLE [dbo].[OrderList] ADD  CONSTRAINT [DF_OrderList_Amount]  DEFAULT ((1)) FOR [Amount]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([AuthorId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Author]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[OrderList]  WITH CHECK ADD  CONSTRAINT [FK_OrderList_Book] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[OrderList] CHECK CONSTRAINT [FK_OrderList_Book]
GO
ALTER TABLE [dbo].[OrderList]  WITH CHECK ADD  CONSTRAINT [FK_OrderList_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[OrderList] CHECK CONSTRAINT [FK_OrderList_Order]
GO
ALTER TABLE [dbo].[PromotionalItem]  WITH CHECK ADD  CONSTRAINT [FK_Book_PromotionalItem] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PromotionalItem] CHECK CONSTRAINT [FK_Book_PromotionalItem]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [CK_BookGenre] CHECK  (([genre]='проза' OR [genre]='поэзия' OR [genre]='другое'))
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [CK_BookGenre]
GO
ALTER TABLE [dbo].[OrderList]  WITH CHECK ADD  CONSTRAINT [CK_OrderListAmount] CHECK  (([Amount]>(0) AND [Amount]<=(100)))
GO
ALTER TABLE [dbo].[OrderList] CHECK CONSTRAINT [CK_OrderListAmount]
GO
USE [master]
GO
ALTER DATABASE [ispp2114] SET  READ_WRITE 
GO
