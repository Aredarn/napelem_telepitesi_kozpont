USE [master]
GO
/****** Object:  Database [napelem_rendszer]    Script Date: 2023. 02. 26. 13:29:48 ******/
CREATE DATABASE [napelem_rendszer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'napelem_rendszer', FILENAME = N'E:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\napelem_rendszer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'napelem_rendszer_log', FILENAME = N'E:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\napelem_rendszer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [napelem_rendszer] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [napelem_rendszer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [napelem_rendszer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [napelem_rendszer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [napelem_rendszer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [napelem_rendszer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [napelem_rendszer] SET ARITHABORT OFF 
GO
ALTER DATABASE [napelem_rendszer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [napelem_rendszer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [napelem_rendszer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [napelem_rendszer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [napelem_rendszer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [napelem_rendszer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [napelem_rendszer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [napelem_rendszer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [napelem_rendszer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [napelem_rendszer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [napelem_rendszer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [napelem_rendszer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [napelem_rendszer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [napelem_rendszer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [napelem_rendszer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [napelem_rendszer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [napelem_rendszer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [napelem_rendszer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [napelem_rendszer] SET  MULTI_USER 
GO
ALTER DATABASE [napelem_rendszer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [napelem_rendszer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [napelem_rendszer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [napelem_rendszer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [napelem_rendszer] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [napelem_rendszer] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [napelem_rendszer] SET QUERY_STORE = ON
GO
ALTER DATABASE [napelem_rendszer] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 2023. 02. 26. 13:29:49 ******/
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 2023. 02. 26. 13:29:49 ******/
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLTELEMETRY$SQLEXPRESS01]    Script Date: 2023. 02. 26. 13:29:49 ******/
CREATE LOGIN [NT SERVICE\SQLTELEMETRY$SQLEXPRESS01] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT Service\MSSQL$SQLEXPRESS01]    Script Date: 2023. 02. 26. 13:29:49 ******/
CREATE LOGIN [NT Service\MSSQL$SQLEXPRESS01] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 2023. 02. 26. 13:29:49 ******/
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [DESKTOP-EBBB9JL\DirrDurrKandúr]    Script Date: 2023. 02. 26. 13:29:49 ******/
CREATE LOGIN [DESKTOP-EBBB9JL\DirrDurrKandúr] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [BUILTIN\Felhasználók]    Script Date: 2023. 02. 26. 13:29:49 ******/
CREATE LOGIN [BUILTIN\Felhasználók] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 2023. 02. 26. 13:29:49 ******/
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'7uX+hUWUgE+vypUNdXjCcorxzuQLJMaK3O96skY07DE=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 2023. 02. 26. 13:29:49 ******/
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'oflNKAfBthhRNblZyGmBJQwN5e7Zq7EWkI7x2KjZpf0=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQL$SQLEXPRESS01]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [DESKTOP-EBBB9JL\DirrDurrKandúr]
GO
USE [napelem_rendszer]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 2023. 02. 26. 13:29:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[itemname] [nvarchar](50) NOT NULL,
	[price] [int] NOT NULL,
	[maxOnShelf] [int] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[itemname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 2023. 02. 26. 13:29:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[projectManager] [varchar](50) NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[projectID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[projectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTOitems]    Script Date: 2023. 02. 26. 13:29:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTOitems](
	[projectID] [int] NOT NULL,
	[itemName] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservedItems]    Script Date: 2023. 02. 26. 13:29:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservedItems](
	[item] [nvarchar](50) NOT NULL,
	[projectID] [int] NOT NULL,
	[numberOfItems] [int] NOT NULL,
 CONSTRAINT [PK_ReservedItems] PRIMARY KEY CLUSTERED 
(
	[item] ASC,
	[projectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shelves]    Script Date: 2023. 02. 26. 13:29:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shelves](
	[Row] [int] NOT NULL,
	[Column] [int] NOT NULL,
	[Level] [int] NOT NULL,
	[Item] [nvarchar](50) NOT NULL,
	[Shelf]  AS (([Row]-(1))*(25)+(([Column]-(1))*(5)+[Level])),
	[ItemsInShelf] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 2023. 02. 26. 13:29:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusName] [nvarchar](50) NOT NULL,
	[StatusInfo] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2023. 02. 26. 13:29:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[name] [varchar](50) NOT NULL,
	[password] [binary](50) NOT NULL,
	[role] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Status] ([StatusName], [StatusInfo]) VALUES (N'Completed', N'a projekt sikeresen megvalósult.')
INSERT [dbo].[Status] ([StatusName], [StatusInfo]) VALUES (N'Draft', N'a helyszíni felmérés folyamatban van, a terv még nem került véglegesítésre.')
INSERT [dbo].[Status] ([StatusName], [StatusInfo]) VALUES (N'Failed', N'a projekt megvalósítása nem sikerült.')
INSERT [dbo].[Status] ([StatusName], [StatusInfo]) VALUES (N'InProgress', N'a projekt megvalósítása megkezdodött, amelynek elso lépése az alkatrészek raktárból való kivételezése.')
INSERT [dbo].[Status] ([StatusName], [StatusInfo]) VALUES (N'New', N'a projekt létrehozásra került, de még nem történt meg a helyszíni felmérés.')
INSERT [dbo].[Status] ([StatusName], [StatusInfo]) VALUES (N'Scheduled', N'árkalkuláció elkészült, a projekt a megvalósításra várakozik.')
INSERT [dbo].[Status] ([StatusName], [StatusInfo]) VALUES (N'Wait', N'a helyszíni felmérés megtörtént, de az árkalkulációt nem lehetett befejezni, mert volt olyan alkatrész, amely nincs a raktárban, így az ára nem ismert.')
GO
INSERT [dbo].[Users] ([name], [password], [role]) VALUES (N'Alice', 0x9B8769A4A742959A2D0298C36FB70623F2DFACDA8436237DF08D8DFD5B37374C000000000000000000000000000000000000, 1)
INSERT [dbo].[Users] ([name], [password], [role]) VALUES (N'Bob', 0xE6BAA8A460CC15A544C61E976EAE8A7D848408CE1A79DB696334E54EB41B6B11000000000000000000000000000000000000, 2)
INSERT [dbo].[Users] ([name], [password], [role]) VALUES (N'Charlie', 0xC6D70D25AF5B6188D55FF98B068B5D835CE5F680DDD488E40B222D749B022BEC000000000000000000000000000000000000, 3)
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_Status] FOREIGN KEY([status])
REFERENCES [dbo].[Status] ([StatusName])
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_Projects_Status]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_Users] FOREIGN KEY([projectManager])
REFERENCES [dbo].[Users] ([name])
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_Projects_Users]
GO
ALTER TABLE [dbo].[ProjectTOitems]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTOitems_Items] FOREIGN KEY([itemName])
REFERENCES [dbo].[Items] ([itemname])
GO
ALTER TABLE [dbo].[ProjectTOitems] CHECK CONSTRAINT [FK_ProjectTOitems_Items]
GO
ALTER TABLE [dbo].[ProjectTOitems]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTOitems_Projects] FOREIGN KEY([projectID])
REFERENCES [dbo].[Projects] ([projectID])
GO
ALTER TABLE [dbo].[ProjectTOitems] CHECK CONSTRAINT [FK_ProjectTOitems_Projects]
GO
ALTER TABLE [dbo].[ReservedItems]  WITH CHECK ADD  CONSTRAINT [FK_ReservedItems_Items] FOREIGN KEY([item])
REFERENCES [dbo].[Items] ([itemname])
GO
ALTER TABLE [dbo].[ReservedItems] CHECK CONSTRAINT [FK_ReservedItems_Items]
GO
ALTER TABLE [dbo].[ReservedItems]  WITH CHECK ADD  CONSTRAINT [FK_ReservedItems_Projects] FOREIGN KEY([projectID])
REFERENCES [dbo].[Projects] ([projectID])
GO
ALTER TABLE [dbo].[ReservedItems] CHECK CONSTRAINT [FK_ReservedItems_Projects]
GO
ALTER TABLE [dbo].[Shelves]  WITH CHECK ADD  CONSTRAINT [FK_Shelves_Items] FOREIGN KEY([Item])
REFERENCES [dbo].[Items] ([itemname])
GO
ALTER TABLE [dbo].[Shelves] CHECK CONSTRAINT [FK_Shelves_Items]
GO
USE [master]
GO
ALTER DATABASE [napelem_rendszer] SET  READ_WRITE 
GO
