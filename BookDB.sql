USE [master]
GO
/****** Object:  Database [BookDB]    Script Date: 2022/7/28 21:32:56 ******/
CREATE DATABASE [BookDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookDB', FILENAME = N'G:\SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookDB_log', FILENAME = N'G:\SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BookDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BookDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BookDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookDB] SET  MULTI_USER 
GO
ALTER DATABASE [BookDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BookDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BookDB] SET QUERY_STORE = OFF
GO
USE [BookDB]
GO
/****** Object:  Table [dbo].[AdminInfo]    Script Date: 2022/7/28 21:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdminID] [nvarchar](50) NOT NULL,
	[AdminPwd] [char](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookBorrowReturnInfo]    Script Date: 2022/7/28 21:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookBorrowReturnInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [nvarchar](50) NULL,
	[ReaderID] [nvarchar](50) NULL,
	[BorrowTime] [datetime] NULL,
	[ReturnTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookCategory]    Script Date: 2022/7/28 21:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookCategory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[ParentID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookInfo]    Script Date: 2022/7/28 21:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookInfo](
	[Name] [nvarchar](50) NOT NULL,
	[CategoryType] [int] NULL,
	[Author] [nvarchar](50) NOT NULL,
	[Money] [money] NOT NULL,
	[BookID] [nvarchar](16) NOT NULL,
	[State] [int] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookState]    Script Date: 2022/7/28 21:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookState](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BookState] [int] NOT NULL,
	[Description] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReaderInfo]    Script Date: 2022/7/28 21:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReaderInfo](
	[ReaderID] [nvarchar](50) NOT NULL,
	[ReadName] [nvarchar](50) NOT NULL,
	[EMail] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminInfo] ON 

INSERT [dbo].[AdminInfo] ([ID], [AdminID], [AdminPwd]) VALUES (1, N'ling', N'7faa66a04798497dd188f52bb56987db')
SET IDENTITY_INSERT [dbo].[AdminInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[BookBorrowReturnInfo] ON 

INSERT [dbo].[BookBorrowReturnInfo] ([ID], [BookID], [ReaderID], [BorrowTime], [ReturnTime]) VALUES (5, N'bk002', N'r001', CAST(N'2022-07-21T08:40:23.000' AS DateTime), NULL)
INSERT [dbo].[BookBorrowReturnInfo] ([ID], [BookID], [ReaderID], [BorrowTime], [ReturnTime]) VALUES (6, N'bk003', N'r001', CAST(N'2022-07-21T08:42:53.000' AS DateTime), CAST(N'2022-07-21T09:23:07.000' AS DateTime))
INSERT [dbo].[BookBorrowReturnInfo] ([ID], [BookID], [ReaderID], [BorrowTime], [ReturnTime]) VALUES (7, N'bk004', N'r001', CAST(N'2022-07-21T08:58:30.000' AS DateTime), CAST(N'2022-07-21T09:23:07.000' AS DateTime))
INSERT [dbo].[BookBorrowReturnInfo] ([ID], [BookID], [ReaderID], [BorrowTime], [ReturnTime]) VALUES (10, N'bk002', N'r002', CAST(N'2022-07-21T09:58:52.000' AS DateTime), CAST(N'2022-07-21T09:59:01.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[BookBorrowReturnInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[BookCategory] ON 

INSERT [dbo].[BookCategory] ([ID], [CategoryID], [CategoryName], [ParentID]) VALUES (1, 1, N'编程类', 0)
INSERT [dbo].[BookCategory] ([ID], [CategoryID], [CategoryName], [ParentID]) VALUES (2, 2, N'科学类', 0)
INSERT [dbo].[BookCategory] ([ID], [CategoryID], [CategoryName], [ParentID]) VALUES (4, 3, N'文学类', 0)
INSERT [dbo].[BookCategory] ([ID], [CategoryID], [CategoryName], [ParentID]) VALUES (5, 4, N'高级语言系列', 1)
INSERT [dbo].[BookCategory] ([ID], [CategoryID], [CategoryName], [ParentID]) VALUES (6, 5, N'数据库系列', 1)
INSERT [dbo].[BookCategory] ([ID], [CategoryID], [CategoryName], [ParentID]) VALUES (7, 6, N'web开发系列', 1)
INSERT [dbo].[BookCategory] ([ID], [CategoryID], [CategoryName], [ParentID]) VALUES (8, 7, N'自然科学系列', 2)
INSERT [dbo].[BookCategory] ([ID], [CategoryID], [CategoryName], [ParentID]) VALUES (9, 8, N'社会科学系列', 2)
INSERT [dbo].[BookCategory] ([ID], [CategoryID], [CategoryName], [ParentID]) VALUES (10, 9, N'儿童文学系列', 3)
INSERT [dbo].[BookCategory] ([ID], [CategoryID], [CategoryName], [ParentID]) VALUES (11, 10, N'历史文学系列', 3)
SET IDENTITY_INSERT [dbo].[BookCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[BookInfo] ON 

INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'C#从入门到入土', 4, N'别问', 6.0000, N'bk001', 1, 1)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'java从入门到入土', 4, N'别问', 6.0000, N'bk002', 0, 2)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'ASP.NET MVC从入门到入狱', 6, N'别问', 6.0000, N'bk003', 1, 3)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'SqlServer建库到删库跑路', 5, N'别问', 6.0000, N'bk004', 1, 4)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'啥玩意是自然科学呀', 7, N'别问', 6.0000, N'bk005', 0, 5)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'社会科学是什么东西？', 8, N'别问', 6.0000, N'bk006', 0, 6)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'七个白雪公主大战女巫', 9, N'别问', 6.0000, N'bk007', 0, 7)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'大红帽和废物狼', 9, N'别问', 6.0000, N'bk008', 0, 8)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'奥特曼和秦始皇那些事', 10, N'别问', 6.0000, N'bk009', 1, 9)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'假面骑士七进七出救刘备的废物儿子那件事', 10, N'别问', 6.0000, N'bk010', 1, 10)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'爬虫从入门到入狱', 4, N'别问', 1.0000, N'bk011', 0, 13)
INSERT [dbo].[BookInfo] ([Name], [CategoryType], [Author], [Money], [BookID], [State], [ID]) VALUES (N'测试', 4, N'别问', 3.0000, N'bk012', 0, 15)
SET IDENTITY_INSERT [dbo].[BookInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[BookState] ON 

INSERT [dbo].[BookState] ([ID], [BookState], [Description]) VALUES (1, 0, N'未借出')
INSERT [dbo].[BookState] ([ID], [BookState], [Description]) VALUES (2, 1, N'已借出')
SET IDENTITY_INSERT [dbo].[BookState] OFF
GO
SET IDENTITY_INSERT [dbo].[ReaderInfo] ON 

INSERT [dbo].[ReaderInfo] ([ReaderID], [ReadName], [EMail], [Address], [Mobile], [ID]) VALUES (N'r001', N'路人a', NULL, NULL, NULL, 1)
INSERT [dbo].[ReaderInfo] ([ReaderID], [ReadName], [EMail], [Address], [Mobile], [ID]) VALUES (N'r002', N'路人b', N'', N'', N'', 2)
INSERT [dbo].[ReaderInfo] ([ReaderID], [ReadName], [EMail], [Address], [Mobile], [ID]) VALUES (N'r003', N'路人c', NULL, NULL, NULL, 3)
INSERT [dbo].[ReaderInfo] ([ReaderID], [ReadName], [EMail], [Address], [Mobile], [ID]) VALUES (N'r004', N'路人d', N'', N'', N'', 5)
INSERT [dbo].[ReaderInfo] ([ReaderID], [ReadName], [EMail], [Address], [Mobile], [ID]) VALUES (N'r005', N'路人e', N'2842084118@qq.com', N'无名', N'18977528702', 6)
SET IDENTITY_INSERT [dbo].[ReaderInfo] OFF
GO
/****** Object:  Index [UQ__BookCate__19093A2A5E5D5063]    Script Date: 2022/7/28 21:32:57 ******/
ALTER TABLE [dbo].[BookCategory] ADD UNIQUE NONCLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__BookStat__76EF21E577FDD96C]    Script Date: 2022/7/28 21:32:57 ******/
ALTER TABLE [dbo].[BookState] ADD UNIQUE NONCLUSTERED 
(
	[BookState] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BookInfo] ADD  DEFAULT ((0)) FOR [State]
GO
ALTER TABLE [dbo].[BookInfo]  WITH CHECK ADD FOREIGN KEY([CategoryType])
REFERENCES [dbo].[BookCategory] ([CategoryID])
GO
ALTER TABLE [dbo].[BookInfo]  WITH CHECK ADD FOREIGN KEY([State])
REFERENCES [dbo].[BookState] ([BookState])
GO
USE [master]
GO
ALTER DATABASE [BookDB] SET  READ_WRITE 
GO
