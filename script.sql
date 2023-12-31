USE [master]
GO
/****** Object:  Database [teste]    Script Date: 06/10/2023 18:28:33 ******/
CREATE DATABASE [teste]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'teste', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\teste.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'teste_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\teste_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [teste] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [teste].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [teste] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [teste] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [teste] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [teste] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [teste] SET ARITHABORT OFF 
GO
ALTER DATABASE [teste] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [teste] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [teste] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [teste] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [teste] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [teste] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [teste] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [teste] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [teste] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [teste] SET  DISABLE_BROKER 
GO
ALTER DATABASE [teste] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [teste] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [teste] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [teste] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [teste] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [teste] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [teste] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [teste] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [teste] SET  MULTI_USER 
GO
ALTER DATABASE [teste] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [teste] SET DB_CHAINING OFF 
GO
ALTER DATABASE [teste] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [teste] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [teste] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [teste] SET QUERY_STORE = OFF
GO
USE [teste]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 06/10/2023 18:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cnpj] [varchar](20) NOT NULL,
	[Nome] [varchar](max) NOT NULL,
	[DataFundacao] [datetime2](7) NOT NULL,
	[IdGrupo] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gerente]    Script Date: 06/10/2023 18:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gerente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](max) NOT NULL,
	[Email] [varchar](70) NULL,
	[Nivel] [int] NOT NULL,
 CONSTRAINT [PK_Gerente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grupo]    Script Date: 06/10/2023 18:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](70) NULL,
 CONSTRAINT [PK_Grupo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [Cnpj], [Nome], [DataFundacao], [IdGrupo]) VALUES (2, N'55.555.555-5555/55', N'ghjghj', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 3)
INSERT [dbo].[Cliente] ([Id], [Cnpj], [Nome], [DataFundacao], [IdGrupo]) VALUES (4, N'45.645.645-6456/45', N'fghfgh', CAST(N'2023-10-06T14:18:34.1903512' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Gerente] ON 

INSERT [dbo].[Gerente] ([Id], [Nome], [Email], [Nivel]) VALUES (2, N'gerente1', N'gerente1@gmail.com', 1)
INSERT [dbo].[Gerente] ([Id], [Nome], [Email], [Nivel]) VALUES (3, N'gerente2', N'gerente2@gmail.com', 2)
SET IDENTITY_INSERT [dbo].[Gerente] OFF
GO
SET IDENTITY_INSERT [dbo].[Grupo] ON 

INSERT [dbo].[Grupo] ([Id], [Nome]) VALUES (1, N'grupo1')
INSERT [dbo].[Grupo] ([Id], [Nome]) VALUES (3, N'grupo2')
SET IDENTITY_INSERT [dbo].[Grupo] OFF
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Grupo] FOREIGN KEY([IdGrupo])
REFERENCES [dbo].[Grupo] ([Id])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Grupo]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Gerente', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1-Nivel1, 2-Nivel2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Gerente', @level2type=N'COLUMN',@level2name=N'Nivel'
GO
USE [master]
GO
ALTER DATABASE [teste] SET  READ_WRITE 
GO
