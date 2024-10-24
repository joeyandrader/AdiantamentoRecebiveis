USE [master]
GO
/****** Object:  Database [testedb]    Script Date: 22/10/2024 18:19:42 ******/
CREATE DATABASE [testedb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'testedb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\testedb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'testedb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\testedb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [testedb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [testedb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [testedb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [testedb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [testedb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [testedb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [testedb] SET ARITHABORT OFF 
GO
ALTER DATABASE [testedb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [testedb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [testedb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [testedb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [testedb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [testedb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [testedb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [testedb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [testedb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [testedb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [testedb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [testedb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [testedb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [testedb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [testedb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [testedb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [testedb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [testedb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [testedb] SET  MULTI_USER 
GO
ALTER DATABASE [testedb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [testedb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [testedb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [testedb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [testedb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [testedb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [testedb] SET QUERY_STORE = ON
GO
ALTER DATABASE [testedb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [testedb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 22/10/2024 18:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cart]    Script Date: 22/10/2024 18:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cart](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CorporateId] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_cart] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cartNf]    Script Date: 22/10/2024 18:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cartNf](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NotasFiscaisId] [int] NOT NULL,
	[CartId] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_cartNf] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[corporates]    Script Date: 22/10/2024 18:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[corporates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](max) NOT NULL,
	[Cnpj] [nvarchar](max) NOT NULL,
	[FaturamentoMensal] [decimal](18, 2) NOT NULL,
	[TipoRamo] [int] NOT NULL,
	[Limite] [decimal](18, 2) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_corporates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notasFiscais]    Script Date: 22/10/2024 18:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notasFiscais](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NULL,
	[ValorBruto] [decimal](18, 2) NOT NULL,
	[DataVencimento] [datetime2](7) NOT NULL,
	[ValorLiquido] [decimal](18, 2) NOT NULL,
	[CorporateId] [int] NULL,
	[CreatedAt] [datetime2](7) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[Taxa] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_notasFiscais] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_cart_CorporateId]    Script Date: 22/10/2024 18:19:43 ******/
CREATE NONCLUSTERED INDEX [IX_cart_CorporateId] ON [dbo].[cart]
(
	[CorporateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_cartNf_CartId]    Script Date: 22/10/2024 18:19:43 ******/
CREATE NONCLUSTERED INDEX [IX_cartNf_CartId] ON [dbo].[cartNf]
(
	[CartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_cartNf_NotasFiscaisId]    Script Date: 22/10/2024 18:19:43 ******/
CREATE NONCLUSTERED INDEX [IX_cartNf_NotasFiscaisId] ON [dbo].[cartNf]
(
	[NotasFiscaisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_notasFiscais_CorporateId]    Script Date: 22/10/2024 18:19:43 ******/
CREATE NONCLUSTERED INDEX [IX_notasFiscais_CorporateId] ON [dbo].[notasFiscais]
(
	[CorporateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[notasFiscais] ADD  DEFAULT ((0.0)) FOR [ValorLiquido]
GO
ALTER TABLE [dbo].[notasFiscais] ADD  DEFAULT ((0.0)) FOR [Taxa]
GO
ALTER TABLE [dbo].[cart]  WITH CHECK ADD  CONSTRAINT [FK_cart_corporates_CorporateId] FOREIGN KEY([CorporateId])
REFERENCES [dbo].[corporates] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cart] CHECK CONSTRAINT [FK_cart_corporates_CorporateId]
GO
ALTER TABLE [dbo].[cartNf]  WITH CHECK ADD  CONSTRAINT [FK_cartNf_cart_CartId] FOREIGN KEY([CartId])
REFERENCES [dbo].[cart] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cartNf] CHECK CONSTRAINT [FK_cartNf_cart_CartId]
GO
ALTER TABLE [dbo].[cartNf]  WITH CHECK ADD  CONSTRAINT [FK_cartNf_notasFiscais_NotasFiscaisId] FOREIGN KEY([NotasFiscaisId])
REFERENCES [dbo].[notasFiscais] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cartNf] CHECK CONSTRAINT [FK_cartNf_notasFiscais_NotasFiscaisId]
GO
ALTER TABLE [dbo].[notasFiscais]  WITH CHECK ADD  CONSTRAINT [FK_notasFiscais_corporates_CorporateId] FOREIGN KEY([CorporateId])
REFERENCES [dbo].[corporates] ([Id])
GO
ALTER TABLE [dbo].[notasFiscais] CHECK CONSTRAINT [FK_notasFiscais_corporates_CorporateId]
GO
USE [master]
GO
ALTER DATABASE [testedb] SET  READ_WRITE 
GO
