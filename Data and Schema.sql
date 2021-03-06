USE [master]
GO
/****** Object:  Database [WardrobeMVC]    Script Date: 8/6/2017 11:48:53 PM ******/
CREATE DATABASE [WardrobeMVC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WardrobeMVC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\WardrobeMVC.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WardrobeMVC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\WardrobeMVC_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WardrobeMVC] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WardrobeMVC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WardrobeMVC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WardrobeMVC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WardrobeMVC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WardrobeMVC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WardrobeMVC] SET ARITHABORT OFF 
GO
ALTER DATABASE [WardrobeMVC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WardrobeMVC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WardrobeMVC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WardrobeMVC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WardrobeMVC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WardrobeMVC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WardrobeMVC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WardrobeMVC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WardrobeMVC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WardrobeMVC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WardrobeMVC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WardrobeMVC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WardrobeMVC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WardrobeMVC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WardrobeMVC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WardrobeMVC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WardrobeMVC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WardrobeMVC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WardrobeMVC] SET  MULTI_USER 
GO
ALTER DATABASE [WardrobeMVC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WardrobeMVC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WardrobeMVC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WardrobeMVC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WardrobeMVC] SET DELAYED_DURABILITY = DISABLED 
GO
USE [WardrobeMVC]
GO
/****** Object:  Table [dbo].[Accessories]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessories](
	[AccessoryID] [int] IDENTITY(1,1) NOT NULL,
	[AccessoryName] [nvarchar](100) NOT NULL,
	[AccessoryPhoto] [nvarchar](200) NULL,
	[AccessoryTypeID] [int] NOT NULL,
	[AccessoryColorID] [int] NOT NULL,
	[AccessorySeasonID] [int] NOT NULL,
	[AccessoryOccassionID] [int] NOT NULL,
 CONSTRAINT [PK_Accessories] PRIMARY KEY CLUSTERED 
(
	[AccessoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessories2]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessories2](
	[Accessory2ID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory2Name] [nvarchar](100) NULL,
	[Accessory2Photo] [nvarchar](200) NULL,
	[Accessory2TypeID] [int] NULL,
	[Accessory2ColorID] [int] NULL,
	[Accessory2SeasonID] [int] NULL,
	[Accessory2OccassionID] [int] NULL,
 CONSTRAINT [PK_Accessories2] PRIMARY KEY CLUSTERED 
(
	[Accessory2ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessories3]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessories3](
	[Accessory3ID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory3Name] [nvarchar](100) NULL,
	[Accessory3Photo] [nvarchar](200) NULL,
	[Accessory3TypeID] [int] NULL,
	[Accessory3ColorID] [int] NULL,
	[Accessory3SeasonID] [int] NULL,
	[Accessory3OccassionID] [int] NULL,
 CONSTRAINT [PK_Accessories3] PRIMARY KEY CLUSTERED 
(
	[Accessory3ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessories4]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessories4](
	[Accessory4ID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory4Name] [nvarchar](100) NULL,
	[Accessory4Photo] [nvarchar](200) NULL,
	[Accessory4TypeID] [int] NULL,
	[Accessory4ColorID] [int] NULL,
	[Accessory4SeasonID] [int] NULL,
	[Accessory4OccassionID] [int] NULL,
 CONSTRAINT [PK_Accessories4] PRIMARY KEY CLUSTERED 
(
	[Accessory4ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessories5]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessories5](
	[Accessory5ID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory5Name] [nvarchar](100) NULL,
	[Accessory5Photo] [nvarchar](200) NULL,
	[Accessory5TypeID] [int] NULL,
	[Accessory5ColorID] [int] NULL,
	[Accessory5SeasonID] [int] NULL,
	[Accessory5OccassionID] [int] NULL,
 CONSTRAINT [PK_Accessories5] PRIMARY KEY CLUSTERED 
(
	[Accessory5ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory2Colors]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory2Colors](
	[Accessory2ColorID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory2ColorName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory2Colors] PRIMARY KEY CLUSTERED 
(
	[Accessory2ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory2Occassions]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory2Occassions](
	[Accessory2OccassionID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory2OccassionName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory2Occassions] PRIMARY KEY CLUSTERED 
(
	[Accessory2OccassionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory2Seasons]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory2Seasons](
	[Accessory2SeasonID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory2SeasonName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory2Seasons] PRIMARY KEY CLUSTERED 
(
	[Accessory2SeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory2Types]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory2Types](
	[Accessory2TypeID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory2TypeName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory2Types] PRIMARY KEY CLUSTERED 
(
	[Accessory2TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory3Colors]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory3Colors](
	[Accessory3ColorID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory3ColorName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory3Colors] PRIMARY KEY CLUSTERED 
(
	[Accessory3ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory3Occassions]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory3Occassions](
	[Accessory3OccassionID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory3OccassionName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory3Occassions] PRIMARY KEY CLUSTERED 
(
	[Accessory3OccassionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory3Seasons]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory3Seasons](
	[Accessory3SeasonID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory3SeasonsName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory3Seasons] PRIMARY KEY CLUSTERED 
(
	[Accessory3SeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory3Types]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory3Types](
	[Accessory3TypeID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory3TypeName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessorie3Types] PRIMARY KEY CLUSTERED 
(
	[Accessory3TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory4Colors]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory4Colors](
	[Accessory4ColorID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory4ColorName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory4Colors] PRIMARY KEY CLUSTERED 
(
	[Accessory4ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory4Occassions]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory4Occassions](
	[Accessory4OccassionID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory4OccassionName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory4Occassions] PRIMARY KEY CLUSTERED 
(
	[Accessory4OccassionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory4Seasons]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory4Seasons](
	[Accessory4SeasonID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory4SeasonName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory4Seasons] PRIMARY KEY CLUSTERED 
(
	[Accessory4SeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory4Types]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory4Types](
	[Accessory4TypeID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory4TypeName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory4Types] PRIMARY KEY CLUSTERED 
(
	[Accessory4TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory5Colors]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory5Colors](
	[Accessory5ColorID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory5ColorName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory5Colors] PRIMARY KEY CLUSTERED 
(
	[Accessory5ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory5Occassions]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory5Occassions](
	[Accessory5OccassionID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory5OccassionName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory5Occassions] PRIMARY KEY CLUSTERED 
(
	[Accessory5OccassionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory5Seasons]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory5Seasons](
	[Accessory5SeasonID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory5SeasonName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory5Seasons] PRIMARY KEY CLUSTERED 
(
	[Accessory5SeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accessory5Types]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory5Types](
	[Accessory5TypeID] [int] IDENTITY(1,1) NOT NULL,
	[Accessory5TypeName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accessory5Types] PRIMARY KEY CLUSTERED 
(
	[Accessory5TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AccessoryColors]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessoryColors](
	[AccessoryColorID] [int] IDENTITY(1,1) NOT NULL,
	[AccessoryColorName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_AccessoryColors] PRIMARY KEY CLUSTERED 
(
	[AccessoryColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AccessoryOccasions]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessoryOccasions](
	[AccessoryOccasionID] [int] IDENTITY(1,1) NOT NULL,
	[AccessoryOccasionName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_AccessoryOccasions] PRIMARY KEY CLUSTERED 
(
	[AccessoryOccasionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AccessorySeason]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessorySeason](
	[AccessorySeasonID] [int] IDENTITY(1,1) NOT NULL,
	[AccessorySeasonName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_AccessorySeason] PRIMARY KEY CLUSTERED 
(
	[AccessorySeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AccessoryTypes]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessoryTypes](
	[AccessoryTypeID] [int] IDENTITY(1,1) NOT NULL,
	[AccessoryTypeName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_AccessoryTypes] PRIMARY KEY CLUSTERED 
(
	[AccessoryTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bottoms]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bottoms](
	[BottomID] [int] IDENTITY(1,1) NOT NULL,
	[BottomName] [nvarchar](100) NOT NULL,
	[BottomPhoto] [nvarchar](200) NULL,
	[BottomTypeID] [int] NOT NULL,
	[BottomColorID] [int] NOT NULL,
	[BottomSeasonID] [int] NOT NULL,
	[BottomOccasionID] [int] NOT NULL,
 CONSTRAINT [PK_Bottoms] PRIMARY KEY CLUSTERED 
(
	[BottomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BottomsColors]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BottomsColors](
	[BottomsColorID] [int] IDENTITY(1,1) NOT NULL,
	[BottomsColorName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_BottomsColors] PRIMARY KEY CLUSTERED 
(
	[BottomsColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BottomsOccasions]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BottomsOccasions](
	[BottomsOccasionID] [int] IDENTITY(1,1) NOT NULL,
	[BottomsOccasionName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_BottomsOccasions] PRIMARY KEY CLUSTERED 
(
	[BottomsOccasionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BottomsSeasons]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BottomsSeasons](
	[BottomsSeasonID] [int] IDENTITY(1,1) NOT NULL,
	[BottomsSeasonName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_BottomsSeasons] PRIMARY KEY CLUSTERED 
(
	[BottomsSeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BottomsTypes]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BottomsTypes](
	[BottomsTypeID] [int] IDENTITY(1,1) NOT NULL,
	[BottomsTypeName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_BottomsTypes] PRIMARY KEY CLUSTERED 
(
	[BottomsTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Outerwear]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Outerwear](
	[OuterwearID] [int] IDENTITY(1,1) NOT NULL,
	[OuterwearName] [nvarchar](100) NULL,
	[OuterwearPhoto] [nvarchar](200) NULL,
	[OuterwearTypeID] [int] NULL,
	[OuterwearColorID] [int] NULL,
	[OuterwearSeasonID] [int] NULL,
	[OuterwearOccassionID] [int] NULL,
 CONSTRAINT [PK_Outerwear] PRIMARY KEY CLUSTERED 
(
	[OuterwearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OuterwearColors]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OuterwearColors](
	[OuterwearColorID] [int] IDENTITY(1,1) NOT NULL,
	[OuterwearColorName] [nvarchar](100) NULL,
 CONSTRAINT [PK_OuterwearColors] PRIMARY KEY CLUSTERED 
(
	[OuterwearColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OuterwearOccassions]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OuterwearOccassions](
	[OuterwearOccassionID] [int] IDENTITY(1,1) NOT NULL,
	[OuterwearOccassionName] [nvarchar](100) NULL,
 CONSTRAINT [PK_OuterwearOccassions] PRIMARY KEY CLUSTERED 
(
	[OuterwearOccassionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OuterwearSeasons]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OuterwearSeasons](
	[OuterwearSeasonID] [int] IDENTITY(1,1) NOT NULL,
	[OuterwearSeasonName] [nvarchar](100) NULL,
 CONSTRAINT [PK_OuterwearSeasons] PRIMARY KEY CLUSTERED 
(
	[OuterwearSeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OuterwearTypes]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OuterwearTypes](
	[OuterwearTypeID] [int] IDENTITY(1,1) NOT NULL,
	[OuterwearTypeName] [nvarchar](100) NULL,
 CONSTRAINT [PK_OuterwearTypes] PRIMARY KEY CLUSTERED 
(
	[OuterwearTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OutfitID]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutfitID](
	[OutfitID] [int] IDENTITY(1,1) NOT NULL,
	[OutfitName] [nvarchar](100) NOT NULL,
	[TopID] [int] NULL,
	[SecondLayerTopID] [int] NULL,
	[OuterwearID] [int] NULL,
	[BottomID] [int] NULL,
	[ShoesID] [int] NULL,
	[AccessoryID] [int] NULL,
	[Accessory2ID] [int] NULL,
	[Accessory3ID] [int] NULL,
	[Accessory4ID] [int] NULL,
	[Accessory5ID] [int] NULL,
 CONSTRAINT [PK_OutfitID] PRIMARY KEY CLUSTERED 
(
	[OutfitName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SecondLayerTopColors]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SecondLayerTopColors](
	[SecondLayerTopColorID] [int] IDENTITY(1,1) NOT NULL,
	[SecondLayerTopColorName] [nvarchar](100) NULL,
 CONSTRAINT [PK_SecondLayerTopColors] PRIMARY KEY CLUSTERED 
(
	[SecondLayerTopColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SecondLayerTopOccasions]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SecondLayerTopOccasions](
	[SecondLayerTopOccasionID] [int] IDENTITY(1,1) NOT NULL,
	[SecondLayerTopOccasionName] [nvarchar](100) NULL,
 CONSTRAINT [PK_SecondLayerTopOccasions] PRIMARY KEY CLUSTERED 
(
	[SecondLayerTopOccasionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SecondLayerTops]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SecondLayerTops](
	[SecondLayerTopID] [int] IDENTITY(1,1) NOT NULL,
	[SecondLayerTopName] [nvarchar](100) NULL,
	[SecondLayerTopPhoto] [nvarchar](200) NULL,
	[SecondLayerTopTypeID] [int] NULL,
	[SecondLayerTopColorID] [int] NULL,
	[SecondLayerTopSeasonID] [int] NULL,
	[SecondLayerTopOccassionID] [int] NULL,
 CONSTRAINT [PK_SecondLayerTops] PRIMARY KEY CLUSTERED 
(
	[SecondLayerTopID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SecondLayerTopSeasons]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SecondLayerTopSeasons](
	[SecondLayerTopSeasonID] [int] IDENTITY(1,1) NOT NULL,
	[SecondLayerTopSeasonName] [nvarchar](100) NULL,
 CONSTRAINT [PK_SecondLayerTopSeasons] PRIMARY KEY CLUSTERED 
(
	[SecondLayerTopSeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SecondLayerTopTypes]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SecondLayerTopTypes](
	[SecondLayerTopTypeID] [int] IDENTITY(1,1) NOT NULL,
	[SecondLayerTopName] [nvarchar](100) NULL,
 CONSTRAINT [PK_SecondLayerTopTypes] PRIMARY KEY CLUSTERED 
(
	[SecondLayerTopTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ShoeColors]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoeColors](
	[ShoeColorID] [int] IDENTITY(1,1) NOT NULL,
	[ShoeColorName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ShoeColors] PRIMARY KEY CLUSTERED 
(
	[ShoeColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ShoeOccasions]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoeOccasions](
	[ShoeOccasionID] [int] IDENTITY(1,1) NOT NULL,
	[ShoeOccassionName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ShoeOccasions] PRIMARY KEY CLUSTERED 
(
	[ShoeOccasionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shoes]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shoes](
	[ShoesID] [int] IDENTITY(1,1) NOT NULL,
	[ShoeName] [nvarchar](100) NOT NULL,
	[ShoePhoto] [nvarchar](200) NULL,
	[ShoeTypeID] [int] NOT NULL,
	[ShoeColorID] [int] NOT NULL,
	[ShoeSeasonID] [int] NOT NULL,
	[ShoeOccassionID] [int] NOT NULL,
 CONSTRAINT [PK_Shoes] PRIMARY KEY CLUSTERED 
(
	[ShoesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ShoeSeasons]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoeSeasons](
	[ShoeSeasonID] [int] IDENTITY(1,1) NOT NULL,
	[ShoeSeasonName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ShoeSeasons] PRIMARY KEY CLUSTERED 
(
	[ShoeSeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ShoeTypes]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoeTypes](
	[ShoeTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ShoeTypeName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ShoeTypes] PRIMARY KEY CLUSTERED 
(
	[ShoeTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Top]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Top](
	[TopID] [int] IDENTITY(1,1) NOT NULL,
	[TopName] [nvarchar](100) NOT NULL,
	[TopPhoto] [nvarchar](200) NULL,
	[TopTypeID] [int] NOT NULL,
	[TopColorID] [int] NOT NULL,
	[TopSeasonID] [int] NOT NULL,
	[TopOccasionID] [int] NOT NULL,
 CONSTRAINT [PK_Tops] PRIMARY KEY CLUSTERED 
(
	[TopID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TopColors]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopColors](
	[TopColorID] [int] IDENTITY(1,1) NOT NULL,
	[TopColorName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TopColors] PRIMARY KEY CLUSTERED 
(
	[TopColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TopOccassions]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopOccassions](
	[TopOccassionID] [int] IDENTITY(1,1) NOT NULL,
	[TopOccassionName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TopOccassions] PRIMARY KEY CLUSTERED 
(
	[TopOccassionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TopSeasons]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopSeasons](
	[TopSeasonID] [int] IDENTITY(1,1) NOT NULL,
	[TopSeasonName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TopSeasons] PRIMARY KEY CLUSTERED 
(
	[TopSeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TopTypes]    Script Date: 8/6/2017 11:48:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopTypes](
	[TopTypeID] [int] IDENTITY(1,1) NOT NULL,
	[TopTypeName] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_TopTypes] PRIMARY KEY CLUSTERED 
(
	[TopTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Accessory2Colors] ON 

INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (1, N'White')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (2, N'Black')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (3, N'Red')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (4, N'Navy')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (5, N'Natural')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (6, N'Striped')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (7, N'Polka Dot')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (8, N'Orange')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (9, N'Green')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (10, N'Sage')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (11, N'Rust')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (12, N'Maroon')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (13, N'Brown')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (14, N'Multicolored')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (15, N'Silver')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (16, N'Gold')
INSERT [dbo].[Accessory2Colors] ([Accessory2ColorID], [Accessory2ColorName]) VALUES (17, N'Rose Gold')
SET IDENTITY_INSERT [dbo].[Accessory2Colors] OFF
SET IDENTITY_INSERT [dbo].[Accessory2Occassions] ON 

INSERT [dbo].[Accessory2Occassions] ([Accessory2OccassionID], [Accessory2OccassionName]) VALUES (1, N'Work')
INSERT [dbo].[Accessory2Occassions] ([Accessory2OccassionID], [Accessory2OccassionName]) VALUES (2, N'Date Night')
INSERT [dbo].[Accessory2Occassions] ([Accessory2OccassionID], [Accessory2OccassionName]) VALUES (3, N'Weekend')
INSERT [dbo].[Accessory2Occassions] ([Accessory2OccassionID], [Accessory2OccassionName]) VALUES (4, N'Workout')
INSERT [dbo].[Accessory2Occassions] ([Accessory2OccassionID], [Accessory2OccassionName]) VALUES (5, N'Formal')
INSERT [dbo].[Accessory2Occassions] ([Accessory2OccassionID], [Accessory2OccassionName]) VALUES (6, N'Casual')
SET IDENTITY_INSERT [dbo].[Accessory2Occassions] OFF
SET IDENTITY_INSERT [dbo].[Accessory2Seasons] ON 

INSERT [dbo].[Accessory2Seasons] ([Accessory2SeasonID], [Accessory2SeasonName]) VALUES (1, N'Spring/Summer')
INSERT [dbo].[Accessory2Seasons] ([Accessory2SeasonID], [Accessory2SeasonName]) VALUES (2, N'Resort')
INSERT [dbo].[Accessory2Seasons] ([Accessory2SeasonID], [Accessory2SeasonName]) VALUES (3, N'Fall/Winter')
INSERT [dbo].[Accessory2Seasons] ([Accessory2SeasonID], [Accessory2SeasonName]) VALUES (4, N'Holiday')
SET IDENTITY_INSERT [dbo].[Accessory2Seasons] OFF
SET IDENTITY_INSERT [dbo].[Accessory2Types] ON 

INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (1, N'Neck Tie/Bow Tie/Ascot')
INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (2, N'Necklace')
INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (3, N'Scarf')
INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (4, N'Belt/Suspenders/Braces')
INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (5, N'Socks')
INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (6, N'Watch')
INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (7, N'Bracelet')
INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (8, N'Ring')
INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (9, N'Hat')
INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (10, N'Bag/Backpack')
INSERT [dbo].[Accessory2Types] ([Accessory2TypeID], [Accessory2TypeName]) VALUES (11, N'Pocket Square')
SET IDENTITY_INSERT [dbo].[Accessory2Types] OFF
SET IDENTITY_INSERT [dbo].[Accessory3Colors] ON 

INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (1, N'White')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (2, N'Black')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (3, N'Red')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (4, N'Navy')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (5, N'Natural')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (6, N'Striped')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (7, N'Polka Dot')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (8, N'Orange')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (9, N'Green')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (10, N'Sage')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (11, N'Rust')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (12, N'Maroon')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (13, N'Brown')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (14, N'Multicolored')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (15, N'Silver')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (16, N'Gold')
INSERT [dbo].[Accessory3Colors] ([Accessory3ColorID], [Accessory3ColorName]) VALUES (17, N'Rose Gold')
SET IDENTITY_INSERT [dbo].[Accessory3Colors] OFF
SET IDENTITY_INSERT [dbo].[Accessory3Occassions] ON 

INSERT [dbo].[Accessory3Occassions] ([Accessory3OccassionID], [Accessory3OccassionName]) VALUES (1, N'Work')
INSERT [dbo].[Accessory3Occassions] ([Accessory3OccassionID], [Accessory3OccassionName]) VALUES (2, N'Date Night')
INSERT [dbo].[Accessory3Occassions] ([Accessory3OccassionID], [Accessory3OccassionName]) VALUES (3, N'Weekend')
INSERT [dbo].[Accessory3Occassions] ([Accessory3OccassionID], [Accessory3OccassionName]) VALUES (4, N'Workout')
INSERT [dbo].[Accessory3Occassions] ([Accessory3OccassionID], [Accessory3OccassionName]) VALUES (5, N'Formal')
INSERT [dbo].[Accessory3Occassions] ([Accessory3OccassionID], [Accessory3OccassionName]) VALUES (6, N'Casual')
SET IDENTITY_INSERT [dbo].[Accessory3Occassions] OFF
SET IDENTITY_INSERT [dbo].[Accessory3Seasons] ON 

INSERT [dbo].[Accessory3Seasons] ([Accessory3SeasonID], [Accessory3SeasonsName]) VALUES (1, N'Spring/Summer')
INSERT [dbo].[Accessory3Seasons] ([Accessory3SeasonID], [Accessory3SeasonsName]) VALUES (2, N'Resort')
INSERT [dbo].[Accessory3Seasons] ([Accessory3SeasonID], [Accessory3SeasonsName]) VALUES (3, N'Fall/Winter')
INSERT [dbo].[Accessory3Seasons] ([Accessory3SeasonID], [Accessory3SeasonsName]) VALUES (4, N'Holiday')
SET IDENTITY_INSERT [dbo].[Accessory3Seasons] OFF
SET IDENTITY_INSERT [dbo].[Accessory3Types] ON 

INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (1, N'Neck Tie/Bow Tie/Ascot')
INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (2, N'Necklace')
INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (3, N'Scarf')
INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (4, N'Belt/Suspenders/Braces')
INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (5, N'Socks')
INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (6, N'Watch')
INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (7, N'Bracelet')
INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (8, N'Ring')
INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (9, N'Hat')
INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (10, N'Bag/Backpack')
INSERT [dbo].[Accessory3Types] ([Accessory3TypeID], [Accessory3TypeName]) VALUES (11, N'Pocket Square')
SET IDENTITY_INSERT [dbo].[Accessory3Types] OFF
SET IDENTITY_INSERT [dbo].[Accessory4Colors] ON 

INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (1, N'White')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (2, N'Black')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (3, N'Red')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (4, N'Navy')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (5, N'Natural')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (6, N'Striped')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (7, N'Polka Dot')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (8, N'Orange')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (9, N'Green')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (10, N'Sage')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (11, N'Rust')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (12, N'Maroon')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (13, N'Brown')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (14, N'Multicolored')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (15, N'Silver')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (16, N'Gold')
INSERT [dbo].[Accessory4Colors] ([Accessory4ColorID], [Accessory4ColorName]) VALUES (17, N'Rose Gold')
SET IDENTITY_INSERT [dbo].[Accessory4Colors] OFF
SET IDENTITY_INSERT [dbo].[Accessory4Occassions] ON 

INSERT [dbo].[Accessory4Occassions] ([Accessory4OccassionID], [Accessory4OccassionName]) VALUES (1, N'Work')
INSERT [dbo].[Accessory4Occassions] ([Accessory4OccassionID], [Accessory4OccassionName]) VALUES (2, N'Date Night')
INSERT [dbo].[Accessory4Occassions] ([Accessory4OccassionID], [Accessory4OccassionName]) VALUES (3, N'Weekend')
INSERT [dbo].[Accessory4Occassions] ([Accessory4OccassionID], [Accessory4OccassionName]) VALUES (4, N'Workout')
INSERT [dbo].[Accessory4Occassions] ([Accessory4OccassionID], [Accessory4OccassionName]) VALUES (5, N'Formal')
INSERT [dbo].[Accessory4Occassions] ([Accessory4OccassionID], [Accessory4OccassionName]) VALUES (6, N'Casual')
SET IDENTITY_INSERT [dbo].[Accessory4Occassions] OFF
SET IDENTITY_INSERT [dbo].[Accessory4Seasons] ON 

INSERT [dbo].[Accessory4Seasons] ([Accessory4SeasonID], [Accessory4SeasonName]) VALUES (1, N'Spring/Summer')
INSERT [dbo].[Accessory4Seasons] ([Accessory4SeasonID], [Accessory4SeasonName]) VALUES (2, N'Resort')
INSERT [dbo].[Accessory4Seasons] ([Accessory4SeasonID], [Accessory4SeasonName]) VALUES (3, N'Fall/Winter')
INSERT [dbo].[Accessory4Seasons] ([Accessory4SeasonID], [Accessory4SeasonName]) VALUES (4, N'Holiday')
SET IDENTITY_INSERT [dbo].[Accessory4Seasons] OFF
SET IDENTITY_INSERT [dbo].[Accessory4Types] ON 

INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (1, N'Neck Tie/Bow Tie/Ascot')
INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (2, N'Necklace')
INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (3, N'Scarf')
INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (4, N'Belt/Suspenders/Braces')
INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (5, N'Socks')
INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (6, N'Watch')
INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (7, N'Bracelet')
INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (8, N'Ring')
INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (9, N'Hat')
INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (10, N'Bag/Backpack')
INSERT [dbo].[Accessory4Types] ([Accessory4TypeID], [Accessory4TypeName]) VALUES (11, N'Pocket Square')
SET IDENTITY_INSERT [dbo].[Accessory4Types] OFF
SET IDENTITY_INSERT [dbo].[Accessory5Colors] ON 

INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (1, N'White')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (2, N'Black')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (3, N'Red')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (4, N'Navy')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (5, N'Natural')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (6, N'Striped')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (7, N'Polka Dot')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (8, N'Orange')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (9, N'Green')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (10, N'Sage')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (11, N'Rust')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (12, N'Maroon')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (13, N'Brown')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (14, N'Multicolored')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (15, N'Silver')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (16, N'Gold')
INSERT [dbo].[Accessory5Colors] ([Accessory5ColorID], [Accessory5ColorName]) VALUES (17, N'Rose Gold')
SET IDENTITY_INSERT [dbo].[Accessory5Colors] OFF
SET IDENTITY_INSERT [dbo].[Accessory5Occassions] ON 

INSERT [dbo].[Accessory5Occassions] ([Accessory5OccassionID], [Accessory5OccassionName]) VALUES (1, N'Work')
INSERT [dbo].[Accessory5Occassions] ([Accessory5OccassionID], [Accessory5OccassionName]) VALUES (2, N'Date Night')
INSERT [dbo].[Accessory5Occassions] ([Accessory5OccassionID], [Accessory5OccassionName]) VALUES (3, N'Weekend')
INSERT [dbo].[Accessory5Occassions] ([Accessory5OccassionID], [Accessory5OccassionName]) VALUES (4, N'Workout')
INSERT [dbo].[Accessory5Occassions] ([Accessory5OccassionID], [Accessory5OccassionName]) VALUES (5, N'Formal')
INSERT [dbo].[Accessory5Occassions] ([Accessory5OccassionID], [Accessory5OccassionName]) VALUES (6, N'Casual')
SET IDENTITY_INSERT [dbo].[Accessory5Occassions] OFF
SET IDENTITY_INSERT [dbo].[Accessory5Seasons] ON 

INSERT [dbo].[Accessory5Seasons] ([Accessory5SeasonID], [Accessory5SeasonName]) VALUES (1, N'Spring/Summer')
INSERT [dbo].[Accessory5Seasons] ([Accessory5SeasonID], [Accessory5SeasonName]) VALUES (2, N'Resort')
INSERT [dbo].[Accessory5Seasons] ([Accessory5SeasonID], [Accessory5SeasonName]) VALUES (3, N'Fall/Winter')
INSERT [dbo].[Accessory5Seasons] ([Accessory5SeasonID], [Accessory5SeasonName]) VALUES (4, N'Holiday')
SET IDENTITY_INSERT [dbo].[Accessory5Seasons] OFF
SET IDENTITY_INSERT [dbo].[Accessory5Types] ON 

INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (1, N'Neck Tie/Bow Tie/Ascot')
INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (2, N'Necklace')
INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (3, N'Scarf')
INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (4, N'Belt/Suspenders/Braces')
INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (5, N'Socks')
INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (6, N'Watch')
INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (7, N'Bracelet')
INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (8, N'Ring')
INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (9, N'Hat')
INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (10, N'Bag/Backpack')
INSERT [dbo].[Accessory5Types] ([Accessory5TypeID], [Accessory5TypeName]) VALUES (11, N'Pocket Square')
SET IDENTITY_INSERT [dbo].[Accessory5Types] OFF
SET IDENTITY_INSERT [dbo].[AccessoryColors] ON 

INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (1, N'White')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (2, N'Black')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (3, N'Red')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (4, N'Navy')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (5, N'Natural')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (6, N'Striped')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (7, N'Polka Dot')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (8, N'Orange')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (9, N'Green')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (10, N'Sage')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (11, N'Rust')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (12, N'Maroon')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (13, N'Brown')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (14, N'Multicolored')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (15, N'Silver')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (16, N'Gold')
INSERT [dbo].[AccessoryColors] ([AccessoryColorID], [AccessoryColorName]) VALUES (17, N'Rose Gold')
SET IDENTITY_INSERT [dbo].[AccessoryColors] OFF
SET IDENTITY_INSERT [dbo].[AccessoryOccasions] ON 

INSERT [dbo].[AccessoryOccasions] ([AccessoryOccasionID], [AccessoryOccasionName]) VALUES (1, N'Work')
INSERT [dbo].[AccessoryOccasions] ([AccessoryOccasionID], [AccessoryOccasionName]) VALUES (2, N'Date Night')
INSERT [dbo].[AccessoryOccasions] ([AccessoryOccasionID], [AccessoryOccasionName]) VALUES (3, N'Weekend')
INSERT [dbo].[AccessoryOccasions] ([AccessoryOccasionID], [AccessoryOccasionName]) VALUES (4, N'Workout')
INSERT [dbo].[AccessoryOccasions] ([AccessoryOccasionID], [AccessoryOccasionName]) VALUES (5, N'Formal')
INSERT [dbo].[AccessoryOccasions] ([AccessoryOccasionID], [AccessoryOccasionName]) VALUES (6, N'Casual')
SET IDENTITY_INSERT [dbo].[AccessoryOccasions] OFF
SET IDENTITY_INSERT [dbo].[AccessorySeason] ON 

INSERT [dbo].[AccessorySeason] ([AccessorySeasonID], [AccessorySeasonName]) VALUES (1, N'Spring/Summer')
INSERT [dbo].[AccessorySeason] ([AccessorySeasonID], [AccessorySeasonName]) VALUES (2, N'Resort')
INSERT [dbo].[AccessorySeason] ([AccessorySeasonID], [AccessorySeasonName]) VALUES (3, N'Fall/Winter')
INSERT [dbo].[AccessorySeason] ([AccessorySeasonID], [AccessorySeasonName]) VALUES (4, N'Holiday')
SET IDENTITY_INSERT [dbo].[AccessorySeason] OFF
SET IDENTITY_INSERT [dbo].[AccessoryTypes] ON 

INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (1, N'Neck Tie/BowTie/Ascot')
INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (3, N'Necklace')
INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (4, N'Scarf')
INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (6, N'Belt/Suspenders/Braces')
INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (7, N'Socks')
INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (8, N'Watch')
INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (9, N'Bracelet')
INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (10, N'Ring')
INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (11, N'Hat')
INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (12, N'Bag/Backpack')
INSERT [dbo].[AccessoryTypes] ([AccessoryTypeID], [AccessoryTypeName]) VALUES (13, N'Pocket Square')
SET IDENTITY_INSERT [dbo].[AccessoryTypes] OFF
SET IDENTITY_INSERT [dbo].[BottomsColors] ON 

INSERT [dbo].[BottomsColors] ([BottomsColorID], [BottomsColorName]) VALUES (1, N'Stonewashed Denim')
INSERT [dbo].[BottomsColors] ([BottomsColorID], [BottomsColorName]) VALUES (2, N'Raw Denim')
INSERT [dbo].[BottomsColors] ([BottomsColorID], [BottomsColorName]) VALUES (3, N'British Khaki')
INSERT [dbo].[BottomsColors] ([BottomsColorID], [BottomsColorName]) VALUES (4, N'Grey')
INSERT [dbo].[BottomsColors] ([BottomsColorID], [BottomsColorName]) VALUES (5, N'Navy')
INSERT [dbo].[BottomsColors] ([BottomsColorID], [BottomsColorName]) VALUES (6, N'Black')
INSERT [dbo].[BottomsColors] ([BottomsColorID], [BottomsColorName]) VALUES (7, N'Charcoal')
INSERT [dbo].[BottomsColors] ([BottomsColorID], [BottomsColorName]) VALUES (8, N'Olive')
SET IDENTITY_INSERT [dbo].[BottomsColors] OFF
SET IDENTITY_INSERT [dbo].[BottomsOccasions] ON 

INSERT [dbo].[BottomsOccasions] ([BottomsOccasionID], [BottomsOccasionName]) VALUES (1, N'Work')
INSERT [dbo].[BottomsOccasions] ([BottomsOccasionID], [BottomsOccasionName]) VALUES (2, N'Date Night')
INSERT [dbo].[BottomsOccasions] ([BottomsOccasionID], [BottomsOccasionName]) VALUES (3, N'Weekend')
INSERT [dbo].[BottomsOccasions] ([BottomsOccasionID], [BottomsOccasionName]) VALUES (4, N'Workout')
INSERT [dbo].[BottomsOccasions] ([BottomsOccasionID], [BottomsOccasionName]) VALUES (5, N'Formal')
INSERT [dbo].[BottomsOccasions] ([BottomsOccasionID], [BottomsOccasionName]) VALUES (6, N'Casual')
SET IDENTITY_INSERT [dbo].[BottomsOccasions] OFF
SET IDENTITY_INSERT [dbo].[BottomsSeasons] ON 

INSERT [dbo].[BottomsSeasons] ([BottomsSeasonID], [BottomsSeasonName]) VALUES (1, N'Spring/Summer')
INSERT [dbo].[BottomsSeasons] ([BottomsSeasonID], [BottomsSeasonName]) VALUES (2, N'Resort')
INSERT [dbo].[BottomsSeasons] ([BottomsSeasonID], [BottomsSeasonName]) VALUES (3, N'Fall/Winter')
INSERT [dbo].[BottomsSeasons] ([BottomsSeasonID], [BottomsSeasonName]) VALUES (4, N'Holiday')
SET IDENTITY_INSERT [dbo].[BottomsSeasons] OFF
SET IDENTITY_INSERT [dbo].[BottomsTypes] ON 

INSERT [dbo].[BottomsTypes] ([BottomsTypeID], [BottomsTypeName]) VALUES (1, N'Chino Pant')
INSERT [dbo].[BottomsTypes] ([BottomsTypeID], [BottomsTypeName]) VALUES (2, N'Denim Pant')
INSERT [dbo].[BottomsTypes] ([BottomsTypeID], [BottomsTypeName]) VALUES (3, N'Board Short')
INSERT [dbo].[BottomsTypes] ([BottomsTypeID], [BottomsTypeName]) VALUES (4, N'Athletic Short')
INSERT [dbo].[BottomsTypes] ([BottomsTypeID], [BottomsTypeName]) VALUES (5, N'Jogger')
INSERT [dbo].[BottomsTypes] ([BottomsTypeID], [BottomsTypeName]) VALUES (6, N'Sweatpants')
INSERT [dbo].[BottomsTypes] ([BottomsTypeID], [BottomsTypeName]) VALUES (7, N'Dress Slack/Suit Pant')
SET IDENTITY_INSERT [dbo].[BottomsTypes] OFF
SET IDENTITY_INSERT [dbo].[OuterwearColors] ON 

INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (1, N'White')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (2, N'Black')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (3, N'Red')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (4, N'Navy')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (5, N'Natural')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (6, N'Striped')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (7, N'Polka Dot')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (8, N'Orange')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (9, N'Green')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (10, N'Sage')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (11, N'Rust')
INSERT [dbo].[OuterwearColors] ([OuterwearColorID], [OuterwearColorName]) VALUES (12, N'Maroon')
SET IDENTITY_INSERT [dbo].[OuterwearColors] OFF
SET IDENTITY_INSERT [dbo].[OuterwearOccassions] ON 

INSERT [dbo].[OuterwearOccassions] ([OuterwearOccassionID], [OuterwearOccassionName]) VALUES (1, N'Work')
INSERT [dbo].[OuterwearOccassions] ([OuterwearOccassionID], [OuterwearOccassionName]) VALUES (2, N'Date Night')
INSERT [dbo].[OuterwearOccassions] ([OuterwearOccassionID], [OuterwearOccassionName]) VALUES (3, N'Weekend')
INSERT [dbo].[OuterwearOccassions] ([OuterwearOccassionID], [OuterwearOccassionName]) VALUES (4, N'Workout')
INSERT [dbo].[OuterwearOccassions] ([OuterwearOccassionID], [OuterwearOccassionName]) VALUES (5, N'Formal')
INSERT [dbo].[OuterwearOccassions] ([OuterwearOccassionID], [OuterwearOccassionName]) VALUES (6, N'Casual')
SET IDENTITY_INSERT [dbo].[OuterwearOccassions] OFF
SET IDENTITY_INSERT [dbo].[OuterwearSeasons] ON 

INSERT [dbo].[OuterwearSeasons] ([OuterwearSeasonID], [OuterwearSeasonName]) VALUES (1, N'Spring/Summer')
INSERT [dbo].[OuterwearSeasons] ([OuterwearSeasonID], [OuterwearSeasonName]) VALUES (2, N'Resort')
INSERT [dbo].[OuterwearSeasons] ([OuterwearSeasonID], [OuterwearSeasonName]) VALUES (3, N'Fall/Winter')
INSERT [dbo].[OuterwearSeasons] ([OuterwearSeasonID], [OuterwearSeasonName]) VALUES (4, N'Holiday')
SET IDENTITY_INSERT [dbo].[OuterwearSeasons] OFF
SET IDENTITY_INSERT [dbo].[OuterwearTypes] ON 

INSERT [dbo].[OuterwearTypes] ([OuterwearTypeID], [OuterwearTypeName]) VALUES (1, N'Windbreaker')
INSERT [dbo].[OuterwearTypes] ([OuterwearTypeID], [OuterwearTypeName]) VALUES (2, N'Denim Jacket')
INSERT [dbo].[OuterwearTypes] ([OuterwearTypeID], [OuterwearTypeName]) VALUES (3, N'Vest')
INSERT [dbo].[OuterwearTypes] ([OuterwearTypeID], [OuterwearTypeName]) VALUES (4, N'Trench Coat')
INSERT [dbo].[OuterwearTypes] ([OuterwearTypeID], [OuterwearTypeName]) VALUES (5, N'Parka')
INSERT [dbo].[OuterwearTypes] ([OuterwearTypeID], [OuterwearTypeName]) VALUES (6, N'Car Coat')
INSERT [dbo].[OuterwearTypes] ([OuterwearTypeID], [OuterwearTypeName]) VALUES (7, N'Varsity Coat')
INSERT [dbo].[OuterwearTypes] ([OuterwearTypeID], [OuterwearTypeName]) VALUES (8, N'Bomber')
SET IDENTITY_INSERT [dbo].[OuterwearTypes] OFF
SET IDENTITY_INSERT [dbo].[SecondLayerTopColors] ON 

INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (1, N'White')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (2, N'Black')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (3, N'Red')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (4, N'Navy')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (5, N'Natural')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (6, N'Striped')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (7, N'Polka Dot')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (8, N'Orange')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (9, N'Green')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (10, N'Sage')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (11, N'Rust')
INSERT [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID], [SecondLayerTopColorName]) VALUES (12, N'Maroon')
SET IDENTITY_INSERT [dbo].[SecondLayerTopColors] OFF
SET IDENTITY_INSERT [dbo].[SecondLayerTopOccasions] ON 

INSERT [dbo].[SecondLayerTopOccasions] ([SecondLayerTopOccasionID], [SecondLayerTopOccasionName]) VALUES (1, N'Work')
INSERT [dbo].[SecondLayerTopOccasions] ([SecondLayerTopOccasionID], [SecondLayerTopOccasionName]) VALUES (2, N'Date Night')
INSERT [dbo].[SecondLayerTopOccasions] ([SecondLayerTopOccasionID], [SecondLayerTopOccasionName]) VALUES (3, N'Weekend')
INSERT [dbo].[SecondLayerTopOccasions] ([SecondLayerTopOccasionID], [SecondLayerTopOccasionName]) VALUES (4, N'Workout')
INSERT [dbo].[SecondLayerTopOccasions] ([SecondLayerTopOccasionID], [SecondLayerTopOccasionName]) VALUES (5, N'Formal')
INSERT [dbo].[SecondLayerTopOccasions] ([SecondLayerTopOccasionID], [SecondLayerTopOccasionName]) VALUES (7, N'Casual')
SET IDENTITY_INSERT [dbo].[SecondLayerTopOccasions] OFF
SET IDENTITY_INSERT [dbo].[SecondLayerTopSeasons] ON 

INSERT [dbo].[SecondLayerTopSeasons] ([SecondLayerTopSeasonID], [SecondLayerTopSeasonName]) VALUES (1, N'Spring/Summer')
INSERT [dbo].[SecondLayerTopSeasons] ([SecondLayerTopSeasonID], [SecondLayerTopSeasonName]) VALUES (2, N'Resort')
INSERT [dbo].[SecondLayerTopSeasons] ([SecondLayerTopSeasonID], [SecondLayerTopSeasonName]) VALUES (3, N'Fall/Winter')
INSERT [dbo].[SecondLayerTopSeasons] ([SecondLayerTopSeasonID], [SecondLayerTopSeasonName]) VALUES (4, N'Holiday')
SET IDENTITY_INSERT [dbo].[SecondLayerTopSeasons] OFF
SET IDENTITY_INSERT [dbo].[SecondLayerTopTypes] ON 

INSERT [dbo].[SecondLayerTopTypes] ([SecondLayerTopTypeID], [SecondLayerTopName]) VALUES (1, N'Crewneck Sweatshirt')
INSERT [dbo].[SecondLayerTopTypes] ([SecondLayerTopTypeID], [SecondLayerTopName]) VALUES (2, N'Hooded Sweatshirt')
INSERT [dbo].[SecondLayerTopTypes] ([SecondLayerTopTypeID], [SecondLayerTopName]) VALUES (3, N'Sweater')
INSERT [dbo].[SecondLayerTopTypes] ([SecondLayerTopTypeID], [SecondLayerTopName]) VALUES (4, N'Cardigan')
SET IDENTITY_INSERT [dbo].[SecondLayerTopTypes] OFF
SET IDENTITY_INSERT [dbo].[ShoeColors] ON 

INSERT [dbo].[ShoeColors] ([ShoeColorID], [ShoeColorName]) VALUES (1, N'White')
INSERT [dbo].[ShoeColors] ([ShoeColorID], [ShoeColorName]) VALUES (2, N'Black')
INSERT [dbo].[ShoeColors] ([ShoeColorID], [ShoeColorName]) VALUES (3, N'Red')
INSERT [dbo].[ShoeColors] ([ShoeColorID], [ShoeColorName]) VALUES (4, N'Navy')
INSERT [dbo].[ShoeColors] ([ShoeColorID], [ShoeColorName]) VALUES (5, N'Natural')
INSERT [dbo].[ShoeColors] ([ShoeColorID], [ShoeColorName]) VALUES (6, N'Brown')
SET IDENTITY_INSERT [dbo].[ShoeColors] OFF
SET IDENTITY_INSERT [dbo].[ShoeOccasions] ON 

INSERT [dbo].[ShoeOccasions] ([ShoeOccasionID], [ShoeOccassionName]) VALUES (1, N'Work')
INSERT [dbo].[ShoeOccasions] ([ShoeOccasionID], [ShoeOccassionName]) VALUES (2, N'Date Night')
INSERT [dbo].[ShoeOccasions] ([ShoeOccasionID], [ShoeOccassionName]) VALUES (3, N'Weekend')
INSERT [dbo].[ShoeOccasions] ([ShoeOccasionID], [ShoeOccassionName]) VALUES (4, N'Workout')
INSERT [dbo].[ShoeOccasions] ([ShoeOccasionID], [ShoeOccassionName]) VALUES (5, N'Formal')
INSERT [dbo].[ShoeOccasions] ([ShoeOccasionID], [ShoeOccassionName]) VALUES (6, N'Casual')
SET IDENTITY_INSERT [dbo].[ShoeOccasions] OFF
SET IDENTITY_INSERT [dbo].[ShoeSeasons] ON 

INSERT [dbo].[ShoeSeasons] ([ShoeSeasonID], [ShoeSeasonName]) VALUES (1, N'Spring/Summer')
INSERT [dbo].[ShoeSeasons] ([ShoeSeasonID], [ShoeSeasonName]) VALUES (2, N'Resort')
INSERT [dbo].[ShoeSeasons] ([ShoeSeasonID], [ShoeSeasonName]) VALUES (3, N'Fall/Winter')
INSERT [dbo].[ShoeSeasons] ([ShoeSeasonID], [ShoeSeasonName]) VALUES (4, N'Holiday')
SET IDENTITY_INSERT [dbo].[ShoeSeasons] OFF
SET IDENTITY_INSERT [dbo].[ShoeTypes] ON 

INSERT [dbo].[ShoeTypes] ([ShoeTypeID], [ShoeTypeName]) VALUES (1, N'Oxford')
INSERT [dbo].[ShoeTypes] ([ShoeTypeID], [ShoeTypeName]) VALUES (2, N'Boot')
INSERT [dbo].[ShoeTypes] ([ShoeTypeID], [ShoeTypeName]) VALUES (3, N'Casual Sneaker')
INSERT [dbo].[ShoeTypes] ([ShoeTypeID], [ShoeTypeName]) VALUES (4, N'Athletic Sneaker')
INSERT [dbo].[ShoeTypes] ([ShoeTypeID], [ShoeTypeName]) VALUES (5, N'Sandal')
SET IDENTITY_INSERT [dbo].[ShoeTypes] OFF
SET IDENTITY_INSERT [dbo].[TopColors] ON 

INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (1, N'White')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (2, N'Black')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (3, N'Red')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (4, N'Navy')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (5, N'Natural')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (6, N'Striped')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (7, N'Polka Dot')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (8, N'Orange')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (9, N'Green')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (10, N'Sage')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (11, N'Rust')
INSERT [dbo].[TopColors] ([TopColorID], [TopColorName]) VALUES (12, N'Maroon')
SET IDENTITY_INSERT [dbo].[TopColors] OFF
SET IDENTITY_INSERT [dbo].[TopOccassions] ON 

INSERT [dbo].[TopOccassions] ([TopOccassionID], [TopOccassionName]) VALUES (1, N'Work')
INSERT [dbo].[TopOccassions] ([TopOccassionID], [TopOccassionName]) VALUES (2, N'Date Night')
INSERT [dbo].[TopOccassions] ([TopOccassionID], [TopOccassionName]) VALUES (3, N'Weekend')
INSERT [dbo].[TopOccassions] ([TopOccassionID], [TopOccassionName]) VALUES (4, N'Workout')
INSERT [dbo].[TopOccassions] ([TopOccassionID], [TopOccassionName]) VALUES (5, N'Formal')
INSERT [dbo].[TopOccassions] ([TopOccassionID], [TopOccassionName]) VALUES (6, N'Casual')
SET IDENTITY_INSERT [dbo].[TopOccassions] OFF
SET IDENTITY_INSERT [dbo].[TopSeasons] ON 

INSERT [dbo].[TopSeasons] ([TopSeasonID], [TopSeasonName]) VALUES (1, N'Spring/Summer')
INSERT [dbo].[TopSeasons] ([TopSeasonID], [TopSeasonName]) VALUES (2, N'Resort')
INSERT [dbo].[TopSeasons] ([TopSeasonID], [TopSeasonName]) VALUES (3, N'Fall/Winter')
INSERT [dbo].[TopSeasons] ([TopSeasonID], [TopSeasonName]) VALUES (4, N'Holiday')
SET IDENTITY_INSERT [dbo].[TopSeasons] OFF
SET IDENTITY_INSERT [dbo].[TopTypes] ON 

INSERT [dbo].[TopTypes] ([TopTypeID], [TopTypeName]) VALUES (1, N'T-Shirt')
INSERT [dbo].[TopTypes] ([TopTypeID], [TopTypeName]) VALUES (2, N'SS Buttondown')
INSERT [dbo].[TopTypes] ([TopTypeID], [TopTypeName]) VALUES (3, N'LS Buttondown')
INSERT [dbo].[TopTypes] ([TopTypeID], [TopTypeName]) VALUES (4, N'A-Shirt/Tank Top')
INSERT [dbo].[TopTypes] ([TopTypeID], [TopTypeName]) VALUES (5, N'Polo')
SET IDENTITY_INSERT [dbo].[TopTypes] OFF
ALTER TABLE [dbo].[Accessories]  WITH CHECK ADD  CONSTRAINT [FK_Accessories_AccessoryColors] FOREIGN KEY([AccessoryColorID])
REFERENCES [dbo].[AccessoryColors] ([AccessoryColorID])
GO
ALTER TABLE [dbo].[Accessories] CHECK CONSTRAINT [FK_Accessories_AccessoryColors]
GO
ALTER TABLE [dbo].[Accessories]  WITH CHECK ADD  CONSTRAINT [FK_Accessories_AccessoryOccasions] FOREIGN KEY([AccessoryOccassionID])
REFERENCES [dbo].[AccessoryOccasions] ([AccessoryOccasionID])
GO
ALTER TABLE [dbo].[Accessories] CHECK CONSTRAINT [FK_Accessories_AccessoryOccasions]
GO
ALTER TABLE [dbo].[Accessories]  WITH CHECK ADD  CONSTRAINT [FK_Accessories_AccessorySeason] FOREIGN KEY([AccessorySeasonID])
REFERENCES [dbo].[AccessorySeason] ([AccessorySeasonID])
GO
ALTER TABLE [dbo].[Accessories] CHECK CONSTRAINT [FK_Accessories_AccessorySeason]
GO
ALTER TABLE [dbo].[Accessories]  WITH CHECK ADD  CONSTRAINT [FK_Accessories_AccessoryTypes] FOREIGN KEY([AccessoryTypeID])
REFERENCES [dbo].[AccessoryTypes] ([AccessoryTypeID])
GO
ALTER TABLE [dbo].[Accessories] CHECK CONSTRAINT [FK_Accessories_AccessoryTypes]
GO
ALTER TABLE [dbo].[Accessories2]  WITH CHECK ADD  CONSTRAINT [FK_Accessories2_Accessory2Colors] FOREIGN KEY([Accessory2ColorID])
REFERENCES [dbo].[Accessory2Colors] ([Accessory2ColorID])
GO
ALTER TABLE [dbo].[Accessories2] CHECK CONSTRAINT [FK_Accessories2_Accessory2Colors]
GO
ALTER TABLE [dbo].[Accessories2]  WITH CHECK ADD  CONSTRAINT [FK_Accessories2_Accessory2Occassions] FOREIGN KEY([Accessory2OccassionID])
REFERENCES [dbo].[Accessory2Occassions] ([Accessory2OccassionID])
GO
ALTER TABLE [dbo].[Accessories2] CHECK CONSTRAINT [FK_Accessories2_Accessory2Occassions]
GO
ALTER TABLE [dbo].[Accessories2]  WITH CHECK ADD  CONSTRAINT [FK_Accessories2_Accessory2Seasons] FOREIGN KEY([Accessory2SeasonID])
REFERENCES [dbo].[Accessory2Seasons] ([Accessory2SeasonID])
GO
ALTER TABLE [dbo].[Accessories2] CHECK CONSTRAINT [FK_Accessories2_Accessory2Seasons]
GO
ALTER TABLE [dbo].[Accessories2]  WITH CHECK ADD  CONSTRAINT [FK_Accessories2_Accessory2Types] FOREIGN KEY([Accessory2TypeID])
REFERENCES [dbo].[Accessory2Types] ([Accessory2TypeID])
GO
ALTER TABLE [dbo].[Accessories2] CHECK CONSTRAINT [FK_Accessories2_Accessory2Types]
GO
ALTER TABLE [dbo].[Accessories3]  WITH CHECK ADD  CONSTRAINT [FK_Accessories3_Accessorie3Types] FOREIGN KEY([Accessory3TypeID])
REFERENCES [dbo].[Accessory3Types] ([Accessory3TypeID])
GO
ALTER TABLE [dbo].[Accessories3] CHECK CONSTRAINT [FK_Accessories3_Accessorie3Types]
GO
ALTER TABLE [dbo].[Accessories3]  WITH CHECK ADD  CONSTRAINT [FK_Accessories3_Accessory3Colors] FOREIGN KEY([Accessory3ColorID])
REFERENCES [dbo].[Accessory3Colors] ([Accessory3ColorID])
GO
ALTER TABLE [dbo].[Accessories3] CHECK CONSTRAINT [FK_Accessories3_Accessory3Colors]
GO
ALTER TABLE [dbo].[Accessories3]  WITH CHECK ADD  CONSTRAINT [FK_Accessories3_Accessory3Occassions] FOREIGN KEY([Accessory3OccassionID])
REFERENCES [dbo].[Accessory3Occassions] ([Accessory3OccassionID])
GO
ALTER TABLE [dbo].[Accessories3] CHECK CONSTRAINT [FK_Accessories3_Accessory3Occassions]
GO
ALTER TABLE [dbo].[Accessories3]  WITH CHECK ADD  CONSTRAINT [FK_Accessories3_Accessory3Seasons] FOREIGN KEY([Accessory3SeasonID])
REFERENCES [dbo].[Accessory3Seasons] ([Accessory3SeasonID])
GO
ALTER TABLE [dbo].[Accessories3] CHECK CONSTRAINT [FK_Accessories3_Accessory3Seasons]
GO
ALTER TABLE [dbo].[Accessories4]  WITH CHECK ADD  CONSTRAINT [FK_Accessories4_Accessory4Colors] FOREIGN KEY([Accessory4ColorID])
REFERENCES [dbo].[Accessory4Colors] ([Accessory4ColorID])
GO
ALTER TABLE [dbo].[Accessories4] CHECK CONSTRAINT [FK_Accessories4_Accessory4Colors]
GO
ALTER TABLE [dbo].[Accessories4]  WITH CHECK ADD  CONSTRAINT [FK_Accessories4_Accessory4Occassions] FOREIGN KEY([Accessory4OccassionID])
REFERENCES [dbo].[Accessory4Occassions] ([Accessory4OccassionID])
GO
ALTER TABLE [dbo].[Accessories4] CHECK CONSTRAINT [FK_Accessories4_Accessory4Occassions]
GO
ALTER TABLE [dbo].[Accessories4]  WITH CHECK ADD  CONSTRAINT [FK_Accessories4_Accessory4Seasons] FOREIGN KEY([Accessory4SeasonID])
REFERENCES [dbo].[Accessory4Seasons] ([Accessory4SeasonID])
GO
ALTER TABLE [dbo].[Accessories4] CHECK CONSTRAINT [FK_Accessories4_Accessory4Seasons]
GO
ALTER TABLE [dbo].[Accessories4]  WITH CHECK ADD  CONSTRAINT [FK_Accessories4_Accessory4Types] FOREIGN KEY([Accessory4TypeID])
REFERENCES [dbo].[Accessory4Types] ([Accessory4TypeID])
GO
ALTER TABLE [dbo].[Accessories4] CHECK CONSTRAINT [FK_Accessories4_Accessory4Types]
GO
ALTER TABLE [dbo].[Accessories5]  WITH CHECK ADD  CONSTRAINT [FK_Accessories5_Accessory5Colors] FOREIGN KEY([Accessory5ColorID])
REFERENCES [dbo].[Accessory5Colors] ([Accessory5ColorID])
GO
ALTER TABLE [dbo].[Accessories5] CHECK CONSTRAINT [FK_Accessories5_Accessory5Colors]
GO
ALTER TABLE [dbo].[Accessories5]  WITH CHECK ADD  CONSTRAINT [FK_Accessories5_Accessory5Occassions] FOREIGN KEY([Accessory5OccassionID])
REFERENCES [dbo].[Accessory5Occassions] ([Accessory5OccassionID])
GO
ALTER TABLE [dbo].[Accessories5] CHECK CONSTRAINT [FK_Accessories5_Accessory5Occassions]
GO
ALTER TABLE [dbo].[Accessories5]  WITH CHECK ADD  CONSTRAINT [FK_Accessories5_Accessory5Seasons] FOREIGN KEY([Accessory5SeasonID])
REFERENCES [dbo].[Accessory5Seasons] ([Accessory5SeasonID])
GO
ALTER TABLE [dbo].[Accessories5] CHECK CONSTRAINT [FK_Accessories5_Accessory5Seasons]
GO
ALTER TABLE [dbo].[Accessories5]  WITH CHECK ADD  CONSTRAINT [FK_Accessories5_Accessory5Types] FOREIGN KEY([Accessory5TypeID])
REFERENCES [dbo].[Accessory5Types] ([Accessory5TypeID])
GO
ALTER TABLE [dbo].[Accessories5] CHECK CONSTRAINT [FK_Accessories5_Accessory5Types]
GO
ALTER TABLE [dbo].[Bottoms]  WITH CHECK ADD  CONSTRAINT [FK_Bottoms_BottomsColors] FOREIGN KEY([BottomColorID])
REFERENCES [dbo].[BottomsColors] ([BottomsColorID])
GO
ALTER TABLE [dbo].[Bottoms] CHECK CONSTRAINT [FK_Bottoms_BottomsColors]
GO
ALTER TABLE [dbo].[Bottoms]  WITH CHECK ADD  CONSTRAINT [FK_Bottoms_BottomsOccasions] FOREIGN KEY([BottomOccasionID])
REFERENCES [dbo].[BottomsOccasions] ([BottomsOccasionID])
GO
ALTER TABLE [dbo].[Bottoms] CHECK CONSTRAINT [FK_Bottoms_BottomsOccasions]
GO
ALTER TABLE [dbo].[Bottoms]  WITH CHECK ADD  CONSTRAINT [FK_Bottoms_BottomsSeasons] FOREIGN KEY([BottomSeasonID])
REFERENCES [dbo].[BottomsSeasons] ([BottomsSeasonID])
GO
ALTER TABLE [dbo].[Bottoms] CHECK CONSTRAINT [FK_Bottoms_BottomsSeasons]
GO
ALTER TABLE [dbo].[Bottoms]  WITH CHECK ADD  CONSTRAINT [FK_Bottoms_BottomsTypes] FOREIGN KEY([BottomTypeID])
REFERENCES [dbo].[BottomsTypes] ([BottomsTypeID])
GO
ALTER TABLE [dbo].[Bottoms] CHECK CONSTRAINT [FK_Bottoms_BottomsTypes]
GO
ALTER TABLE [dbo].[Outerwear]  WITH CHECK ADD  CONSTRAINT [FK_Outerwear_OuterwearColors] FOREIGN KEY([OuterwearColorID])
REFERENCES [dbo].[OuterwearColors] ([OuterwearColorID])
GO
ALTER TABLE [dbo].[Outerwear] CHECK CONSTRAINT [FK_Outerwear_OuterwearColors]
GO
ALTER TABLE [dbo].[Outerwear]  WITH CHECK ADD  CONSTRAINT [FK_Outerwear_OuterwearOccassions] FOREIGN KEY([OuterwearOccassionID])
REFERENCES [dbo].[OuterwearOccassions] ([OuterwearOccassionID])
GO
ALTER TABLE [dbo].[Outerwear] CHECK CONSTRAINT [FK_Outerwear_OuterwearOccassions]
GO
ALTER TABLE [dbo].[Outerwear]  WITH CHECK ADD  CONSTRAINT [FK_Outerwear_OuterwearSeasons] FOREIGN KEY([OuterwearSeasonID])
REFERENCES [dbo].[OuterwearSeasons] ([OuterwearSeasonID])
GO
ALTER TABLE [dbo].[Outerwear] CHECK CONSTRAINT [FK_Outerwear_OuterwearSeasons]
GO
ALTER TABLE [dbo].[Outerwear]  WITH CHECK ADD  CONSTRAINT [FK_Outerwear_OuterwearTypes] FOREIGN KEY([OuterwearTypeID])
REFERENCES [dbo].[OuterwearTypes] ([OuterwearTypeID])
GO
ALTER TABLE [dbo].[Outerwear] CHECK CONSTRAINT [FK_Outerwear_OuterwearTypes]
GO
ALTER TABLE [dbo].[OutfitID]  WITH CHECK ADD  CONSTRAINT [FK_OutfitID_Accessories] FOREIGN KEY([AccessoryID])
REFERENCES [dbo].[Accessories] ([AccessoryID])
GO
ALTER TABLE [dbo].[OutfitID] CHECK CONSTRAINT [FK_OutfitID_Accessories]
GO
ALTER TABLE [dbo].[OutfitID]  WITH CHECK ADD  CONSTRAINT [FK_OutfitID_Accessories2] FOREIGN KEY([Accessory2ID])
REFERENCES [dbo].[Accessories2] ([Accessory2ID])
GO
ALTER TABLE [dbo].[OutfitID] CHECK CONSTRAINT [FK_OutfitID_Accessories2]
GO
ALTER TABLE [dbo].[OutfitID]  WITH CHECK ADD  CONSTRAINT [FK_OutfitID_Accessories3] FOREIGN KEY([Accessory3ID])
REFERENCES [dbo].[Accessories3] ([Accessory3ID])
GO
ALTER TABLE [dbo].[OutfitID] CHECK CONSTRAINT [FK_OutfitID_Accessories3]
GO
ALTER TABLE [dbo].[OutfitID]  WITH CHECK ADD  CONSTRAINT [FK_OutfitID_Accessories4] FOREIGN KEY([Accessory4ID])
REFERENCES [dbo].[Accessories4] ([Accessory4ID])
GO
ALTER TABLE [dbo].[OutfitID] CHECK CONSTRAINT [FK_OutfitID_Accessories4]
GO
ALTER TABLE [dbo].[OutfitID]  WITH CHECK ADD  CONSTRAINT [FK_OutfitID_Accessories5] FOREIGN KEY([Accessory5ID])
REFERENCES [dbo].[Accessories5] ([Accessory5ID])
GO
ALTER TABLE [dbo].[OutfitID] CHECK CONSTRAINT [FK_OutfitID_Accessories5]
GO
ALTER TABLE [dbo].[OutfitID]  WITH CHECK ADD  CONSTRAINT [FK_OutfitID_Bottoms] FOREIGN KEY([BottomID])
REFERENCES [dbo].[Bottoms] ([BottomID])
GO
ALTER TABLE [dbo].[OutfitID] CHECK CONSTRAINT [FK_OutfitID_Bottoms]
GO
ALTER TABLE [dbo].[OutfitID]  WITH CHECK ADD  CONSTRAINT [FK_OutfitID_Outerwear] FOREIGN KEY([OuterwearID])
REFERENCES [dbo].[Outerwear] ([OuterwearID])
GO
ALTER TABLE [dbo].[OutfitID] CHECK CONSTRAINT [FK_OutfitID_Outerwear]
GO
ALTER TABLE [dbo].[OutfitID]  WITH CHECK ADD  CONSTRAINT [FK_OutfitID_SecondLayerTops] FOREIGN KEY([SecondLayerTopID])
REFERENCES [dbo].[SecondLayerTops] ([SecondLayerTopID])
GO
ALTER TABLE [dbo].[OutfitID] CHECK CONSTRAINT [FK_OutfitID_SecondLayerTops]
GO
ALTER TABLE [dbo].[OutfitID]  WITH CHECK ADD  CONSTRAINT [FK_OutfitID_Shoes] FOREIGN KEY([ShoesID])
REFERENCES [dbo].[Shoes] ([ShoesID])
GO
ALTER TABLE [dbo].[OutfitID] CHECK CONSTRAINT [FK_OutfitID_Shoes]
GO
ALTER TABLE [dbo].[OutfitID]  WITH CHECK ADD  CONSTRAINT [FK_OutfitID_Top] FOREIGN KEY([TopID])
REFERENCES [dbo].[Top] ([TopID])
GO
ALTER TABLE [dbo].[OutfitID] CHECK CONSTRAINT [FK_OutfitID_Top]
GO
ALTER TABLE [dbo].[SecondLayerTops]  WITH CHECK ADD  CONSTRAINT [FK_SecondLayerTops_SecondLayerTopColors] FOREIGN KEY([SecondLayerTopColorID])
REFERENCES [dbo].[SecondLayerTopColors] ([SecondLayerTopColorID])
GO
ALTER TABLE [dbo].[SecondLayerTops] CHECK CONSTRAINT [FK_SecondLayerTops_SecondLayerTopColors]
GO
ALTER TABLE [dbo].[SecondLayerTops]  WITH CHECK ADD  CONSTRAINT [FK_SecondLayerTops_SecondLayerTopOccasions] FOREIGN KEY([SecondLayerTopOccassionID])
REFERENCES [dbo].[SecondLayerTopOccasions] ([SecondLayerTopOccasionID])
GO
ALTER TABLE [dbo].[SecondLayerTops] CHECK CONSTRAINT [FK_SecondLayerTops_SecondLayerTopOccasions]
GO
ALTER TABLE [dbo].[SecondLayerTops]  WITH CHECK ADD  CONSTRAINT [FK_SecondLayerTops_SecondLayerTopSeasons] FOREIGN KEY([SecondLayerTopSeasonID])
REFERENCES [dbo].[SecondLayerTopSeasons] ([SecondLayerTopSeasonID])
GO
ALTER TABLE [dbo].[SecondLayerTops] CHECK CONSTRAINT [FK_SecondLayerTops_SecondLayerTopSeasons]
GO
ALTER TABLE [dbo].[SecondLayerTops]  WITH CHECK ADD  CONSTRAINT [FK_SecondLayerTops_SecondLayerTopTypes] FOREIGN KEY([SecondLayerTopTypeID])
REFERENCES [dbo].[SecondLayerTopTypes] ([SecondLayerTopTypeID])
GO
ALTER TABLE [dbo].[SecondLayerTops] CHECK CONSTRAINT [FK_SecondLayerTops_SecondLayerTopTypes]
GO
ALTER TABLE [dbo].[Shoes]  WITH CHECK ADD  CONSTRAINT [FK_Shoes_ShoeColors] FOREIGN KEY([ShoeColorID])
REFERENCES [dbo].[ShoeColors] ([ShoeColorID])
GO
ALTER TABLE [dbo].[Shoes] CHECK CONSTRAINT [FK_Shoes_ShoeColors]
GO
ALTER TABLE [dbo].[Shoes]  WITH CHECK ADD  CONSTRAINT [FK_Shoes_ShoeOccasions] FOREIGN KEY([ShoeOccassionID])
REFERENCES [dbo].[ShoeOccasions] ([ShoeOccasionID])
GO
ALTER TABLE [dbo].[Shoes] CHECK CONSTRAINT [FK_Shoes_ShoeOccasions]
GO
ALTER TABLE [dbo].[Shoes]  WITH CHECK ADD  CONSTRAINT [FK_Shoes_ShoeSeasons] FOREIGN KEY([ShoeSeasonID])
REFERENCES [dbo].[ShoeSeasons] ([ShoeSeasonID])
GO
ALTER TABLE [dbo].[Shoes] CHECK CONSTRAINT [FK_Shoes_ShoeSeasons]
GO
ALTER TABLE [dbo].[Shoes]  WITH CHECK ADD  CONSTRAINT [FK_Shoes_ShoeTypes] FOREIGN KEY([ShoeTypeID])
REFERENCES [dbo].[ShoeTypes] ([ShoeTypeID])
GO
ALTER TABLE [dbo].[Shoes] CHECK CONSTRAINT [FK_Shoes_ShoeTypes]
GO
ALTER TABLE [dbo].[Top]  WITH CHECK ADD  CONSTRAINT [FK_Tops_TopColors] FOREIGN KEY([TopColorID])
REFERENCES [dbo].[TopColors] ([TopColorID])
GO
ALTER TABLE [dbo].[Top] CHECK CONSTRAINT [FK_Tops_TopColors]
GO
ALTER TABLE [dbo].[Top]  WITH CHECK ADD  CONSTRAINT [FK_Tops_TopOccassions] FOREIGN KEY([TopOccasionID])
REFERENCES [dbo].[TopOccassions] ([TopOccassionID])
GO
ALTER TABLE [dbo].[Top] CHECK CONSTRAINT [FK_Tops_TopOccassions]
GO
ALTER TABLE [dbo].[Top]  WITH CHECK ADD  CONSTRAINT [FK_Tops_TopSeasons] FOREIGN KEY([TopSeasonID])
REFERENCES [dbo].[TopSeasons] ([TopSeasonID])
GO
ALTER TABLE [dbo].[Top] CHECK CONSTRAINT [FK_Tops_TopSeasons]
GO
ALTER TABLE [dbo].[Top]  WITH CHECK ADD  CONSTRAINT [FK_Tops_TopTypes] FOREIGN KEY([TopTypeID])
REFERENCES [dbo].[TopTypes] ([TopTypeID])
GO
ALTER TABLE [dbo].[Top] CHECK CONSTRAINT [FK_Tops_TopTypes]
GO
USE [master]
GO
ALTER DATABASE [WardrobeMVC] SET  READ_WRITE 
GO
