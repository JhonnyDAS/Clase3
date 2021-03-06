USE [master]
GO
/****** Object:  Database [pruebaDB_1]    Script Date: 27/03/2018 17:57:23 ******/
CREATE DATABASE [pruebaDB_1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pruebaDB_1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\pruebaDB_1.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'pruebaDB_1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\pruebaDB_1_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pruebaDB_1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pruebaDB_1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pruebaDB_1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pruebaDB_1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pruebaDB_1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pruebaDB_1] SET ARITHABORT OFF 
GO
ALTER DATABASE [pruebaDB_1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pruebaDB_1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pruebaDB_1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pruebaDB_1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pruebaDB_1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pruebaDB_1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pruebaDB_1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pruebaDB_1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pruebaDB_1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pruebaDB_1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pruebaDB_1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pruebaDB_1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pruebaDB_1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pruebaDB_1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pruebaDB_1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pruebaDB_1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pruebaDB_1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pruebaDB_1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pruebaDB_1] SET  MULTI_USER 
GO
ALTER DATABASE [pruebaDB_1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pruebaDB_1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pruebaDB_1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pruebaDB_1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [pruebaDB_1]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 27/03/2018 17:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Ci] [nvarchar](15) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](100) NULL,
	[Genero] [nvarchar](5) NULL,
	[Celular] [int] NULL,
	[Direccion] [nvarchar](200) NULL,
	[FechaNac] [date] NULL,
	[Profesion] [nvarchar](100) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[Ci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 27/03/2018 17:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Codigo] [int] NOT NULL,
	[Nombre] [nvarchar](250) NULL,
	[Descripcion] [nvarchar](250) NULL,
	[Precio] [float] NULL,
	[FechaVenc] [date] NULL,
	[Cantidad] [int] NULL,
	[Procedencia] [nvarchar](20) NULL,
	[Proveedor] [nvarchar](100) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Persona] ([Ci], [Nombre], [Apellido], [Genero], [Celular], [Direccion], [FechaNac], [Profesion]) VALUES (N'1234567', N'Juan', N'Lopez Mamani', N'Varon', 73647384, N'Av. Brasil y Ejercito', CAST(N'1989-12-12' AS Date), N'Estudiante')
INSERT [dbo].[Persona] ([Ci], [Nombre], [Apellido], [Genero], [Celular], [Direccion], [FechaNac], [Profesion]) VALUES (N'1523652', N'Maria', N'Figueroa', N'Mujer', 72635243, N'Calle 1', CAST(N'1992-02-03' AS Date), N'Licencida')
INSERT [dbo].[Persona] ([Ci], [Nombre], [Apellido], [Genero], [Celular], [Direccion], [FechaNac], [Profesion]) VALUES (N'7654321', N'Carlos', N'Mamani', N'Varon', 73647483, N'Por ahi', CAST(N'1999-01-01' AS Date), N'Vago')
USE [master]
GO
ALTER DATABASE [pruebaDB_1] SET  READ_WRITE 
GO
