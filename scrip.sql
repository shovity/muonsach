USE [master]
GO
/****** Object:  Database [muonsach]    Script Date: 20-Dec-17 16:15:51 ******/
CREATE DATABASE [muonsach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'muonsach', FILENAME = N'C:\SQLServer2016Media\MSSQL13.SQLEXPRESS\MSSQL\DATA\muonsach.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'muonsach_log', FILENAME = N'C:\SQLServer2016Media\MSSQL13.SQLEXPRESS\MSSQL\DATA\muonsach_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [muonsach] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [muonsach].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [muonsach] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [muonsach] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [muonsach] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [muonsach] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [muonsach] SET ARITHABORT OFF 
GO
ALTER DATABASE [muonsach] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [muonsach] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [muonsach] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [muonsach] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [muonsach] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [muonsach] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [muonsach] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [muonsach] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [muonsach] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [muonsach] SET  DISABLE_BROKER 
GO
ALTER DATABASE [muonsach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [muonsach] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [muonsach] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [muonsach] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [muonsach] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [muonsach] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [muonsach] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [muonsach] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [muonsach] SET  MULTI_USER 
GO
ALTER DATABASE [muonsach] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [muonsach] SET DB_CHAINING OFF 
GO
ALTER DATABASE [muonsach] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [muonsach] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [muonsach] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [muonsach] SET QUERY_STORE = OFF
GO
USE [muonsach]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [muonsach]
GO
/****** Object:  Table [dbo].[binh_luan]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[binh_luan](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[path] [nvarchar](50) NULL,
	[ma_nguoi_dung] [int] NULL,
	[binh_luan] [nvarchar](50) NULL,
	[thoi_gian] [datetime] NULL,
 CONSTRAINT [PK_binh_luan] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[muon_nhieu]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[muon_nhieu](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ma_sach] [nvarchar](50) NULL,
	[tong] [int] NULL,
	[ngay] [int] NULL,
	[tuan] [int] NULL,
	[thang] [int] NULL,
	[nam] [int] NULL,
	[hien_tai] [date] NULL,
 CONSTRAINT [PK_muon_nhieu] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[muon_sach]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[muon_sach](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ma_sach] [nvarchar](50) NULL,
	[ma_nguoi_dung] [int] NULL,
	[ngay_muon] [date] NULL,
	[ngay_tra] [date] NULL,
	[trang_thai] [nvarchar](50) NULL,
	[tien] [int] NULL,
 CONSTRAINT [PK_muon_sach] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nguoi_dung]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nguoi_dung](
	[ma_nguoi_dung] [int] IDENTITY(1,1) NOT NULL,
	[ten_dang_nhap] [nvarchar](50) NULL,
	[mat_khau] [nvarchar](50) NULL,
	[ma_nhan_dang] [nvarchar](50) NULL,
 CONSTRAINT [PK_nguoi_dung] PRIMARY KEY CLUSTERED 
(
	[ma_nguoi_dung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhan_vien]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhan_vien](
	[ma_nhan_vien] [int] IDENTITY(1,1) NOT NULL,
	[ten_dang_nhap] [nvarchar](50) NULL,
	[mat_khau] [nvarchar](50) NULL,
	[ma_nhan_dang] [nvarchar](50) NULL,
 CONSTRAINT [PK_nhan_vien] PRIMARY KEY CLUSTERED 
(
	[ma_nhan_vien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nxb]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nxb](
	[ma_nxb] [int] IDENTITY(1,1) NOT NULL,
	[ten_nxb] [nvarchar](50) NULL,
 CONSTRAINT [PK_nxb] PRIMARY KEY CLUSTERED 
(
	[ma_nxb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sach]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sach](
	[ma_sach] [nvarchar](50) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[anh] [nvarchar](50) NULL,
	[ma_tac_gia] [int] NULL,
	[ma_nxb] [int] NULL,
	[so_trang] [int] NULL,
	[gia] [int] NULL,
	[gia_thue] [int] NULL,
	[loai] [nvarchar](50) NULL,
	[mo_ta] [nvarchar](50) NULL,
	[nam_xb] [date] NULL,
	[ngay_nhap] [datetime] NULL,
 CONSTRAINT [PK_sach] PRIMARY KEY CLUSTERED 
(
	[ma_sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tac_gia]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tac_gia](
	[ma_tac_gia] [int] IDENTITY(1,1) NOT NULL,
	[ten_tac_gia] [nvarchar](50) NULL,
 CONSTRAINT [PK_tac_gia] PRIMARY KEY CLUSTERED 
(
	[ma_tac_gia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thong_tin_nguoi_dung]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thong_tin_nguoi_dung](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ma_nguoi_dung] [int] NULL,
	[ho] [nvarchar](50) NULL,
	[ten] [nvarchar](50) NULL,
	[tuoi] [int] NULL,
	[gioi_tinh] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[dia_chia] [nvarchar](50) NULL,
	[so_dien_thoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_thong_tin_nguoi_dung] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thong_tin_nhan_vien]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thong_tin_nhan_vien](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ma_nhan_vien] [int] NULL,
	[so_dien_thoai] [nvarchar](50) NULL,
	[dia_chi] [nvarchar](50) NULL,
	[chuc_vua] [nvarchar](50) NULL,
	[ngay_vao_lam] [date] NULL,
 CONSTRAINT [PK_thong_tin_nhan_vien] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[truy_cap]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[truy_cap](
	[trang] [nvarchar](50) NULL,
	[tong] [int] NULL,
	[ngay] [int] NULL,
	[tuan] [int] NULL,
	[thang] [int] NULL,
	[nam] [int] NULL,
	[hien_tai] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yeu_thich]    Script Date: 20-Dec-17 16:15:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yeu_thich](
	[ma] [nvarchar](50) NOT NULL,
	[ma_sach] [int] NULL,
	[tong] [int] NULL,
	[ngay] [int] NULL,
	[tuan] [int] NULL,
	[thang] [int] NULL,
	[nam] [int] NULL,
	[hien_tai] [date] NULL,
 CONSTRAINT [PK_yeu_thich] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[binh_luan]  WITH CHECK ADD  CONSTRAINT [FK_binh_luan_nguoi_dung] FOREIGN KEY([ma_nguoi_dung])
REFERENCES [dbo].[nguoi_dung] ([ma_nguoi_dung])
GO
ALTER TABLE [dbo].[binh_luan] CHECK CONSTRAINT [FK_binh_luan_nguoi_dung]
GO
ALTER TABLE [dbo].[muon_nhieu]  WITH CHECK ADD  CONSTRAINT [FK_muon_nhieu_sach] FOREIGN KEY([ma_sach])
REFERENCES [dbo].[sach] ([ma_sach])
GO
ALTER TABLE [dbo].[muon_nhieu] CHECK CONSTRAINT [FK_muon_nhieu_sach]
GO
ALTER TABLE [dbo].[muon_sach]  WITH CHECK ADD  CONSTRAINT [FK_muon_sach_nguoi_dung] FOREIGN KEY([ma_nguoi_dung])
REFERENCES [dbo].[nguoi_dung] ([ma_nguoi_dung])
GO
ALTER TABLE [dbo].[muon_sach] CHECK CONSTRAINT [FK_muon_sach_nguoi_dung]
GO
ALTER TABLE [dbo].[muon_sach]  WITH CHECK ADD  CONSTRAINT [FK_muon_sach_sach] FOREIGN KEY([ma_sach])
REFERENCES [dbo].[sach] ([ma_sach])
GO
ALTER TABLE [dbo].[muon_sach] CHECK CONSTRAINT [FK_muon_sach_sach]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_nxb] FOREIGN KEY([ma_nxb])
REFERENCES [dbo].[nxb] ([ma_nxb])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_nxb]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_tac_gia] FOREIGN KEY([ma_tac_gia])
REFERENCES [dbo].[tac_gia] ([ma_tac_gia])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_tac_gia]
GO
ALTER TABLE [dbo].[thong_tin_nguoi_dung]  WITH CHECK ADD  CONSTRAINT [FK_thong_tin_nguoi_dung_nguoi_dung] FOREIGN KEY([ma_nguoi_dung])
REFERENCES [dbo].[nguoi_dung] ([ma_nguoi_dung])
GO
ALTER TABLE [dbo].[thong_tin_nguoi_dung] CHECK CONSTRAINT [FK_thong_tin_nguoi_dung_nguoi_dung]
GO
ALTER TABLE [dbo].[thong_tin_nhan_vien]  WITH CHECK ADD  CONSTRAINT [FK_thong_tin_nhan_vien_nhan_vien] FOREIGN KEY([ma_nhan_vien])
REFERENCES [dbo].[nhan_vien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[thong_tin_nhan_vien] CHECK CONSTRAINT [FK_thong_tin_nhan_vien_nhan_vien]
GO
ALTER TABLE [dbo].[yeu_thich]  WITH CHECK ADD  CONSTRAINT [FK_yeu_thich_sach] FOREIGN KEY([ma])
REFERENCES [dbo].[sach] ([ma_sach])
GO
ALTER TABLE [dbo].[yeu_thich] CHECK CONSTRAINT [FK_yeu_thich_sach]
GO
USE [master]
GO
ALTER DATABASE [muonsach] SET  READ_WRITE 
GO
