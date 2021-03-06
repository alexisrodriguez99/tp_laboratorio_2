USE [master]
GO
/****** Object:  Database [tabla_productos]    Script Date: 22/11/2020 23:59:01 ******/
CREATE DATABASE [tabla_productos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tabla_productos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\tabla_productos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tabla_productos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\tabla_productos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [tabla_productos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tabla_productos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tabla_productos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tabla_productos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tabla_productos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tabla_productos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tabla_productos] SET ARITHABORT OFF 
GO
ALTER DATABASE [tabla_productos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tabla_productos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tabla_productos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tabla_productos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tabla_productos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tabla_productos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tabla_productos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tabla_productos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tabla_productos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tabla_productos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tabla_productos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tabla_productos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tabla_productos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tabla_productos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tabla_productos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tabla_productos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tabla_productos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tabla_productos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [tabla_productos] SET  MULTI_USER 
GO
ALTER DATABASE [tabla_productos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tabla_productos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tabla_productos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tabla_productos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tabla_productos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tabla_productos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [tabla_productos] SET QUERY_STORE = OFF
GO
USE [tabla_productos]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 22/11/2020 23:59:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[producto] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[talle] [int] NOT NULL,
	[precio] [float] NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[producto] ON 

INSERT [dbo].[producto] ([id], [producto], [modelo], [talle], [precio]) VALUES (1, N'pantalon(hombre)', N'modelo1', 40, 23)
SET IDENTITY_INSERT [dbo].[producto] OFF
GO
USE [master]
GO
ALTER DATABASE [tabla_productos] SET  READ_WRITE 
GO
