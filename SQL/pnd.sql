USE [master]
GO
/****** Object:  Database [QLThueXe]    Script Date: 10/14/2023 11:19:37 PM ******/
CREATE DATABASE [QLThueXe]
GO
ALTER DATABASE [QLThueXe] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLThueXe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLThueXe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLThueXe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLThueXe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLThueXe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLThueXe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLThueXe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLThueXe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLThueXe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLThueXe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLThueXe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLThueXe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLThueXe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLThueXe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLThueXe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLThueXe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLThueXe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLThueXe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLThueXe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLThueXe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLThueXe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLThueXe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLThueXe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLThueXe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLThueXe] SET  MULTI_USER 
GO
ALTER DATABASE [QLThueXe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLThueXe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLThueXe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLThueXe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLThueXe] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLThueXe]
GO
/****** Object:  Table [dbo].[ChiTietThue]    Script Date: 10/14/2023 11:19:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietThue](
	[MaCTThue] [nchar](10) NOT NULL,
	[TenTK] [varchar](23) NOT NULL,
	[NgayThue] [datetime] NOT NULL,
	[NgayTra] [datetime] NOT NULL,
	[MaXe] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ChiTietThue] PRIMARY KEY CLUSTERED 
(
	[MaCTThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/14/2023 11:19:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[MaXe] [nchar](10) NOT NULL,
	[TongTien] [numeric](18, 0) NOT NULL,
	[TenTK] [varchar](23) NOT NULL,
	[NgayThanhToan] [datetime] NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 10/14/2023 11:19:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](max) NOT NULL,
	[SDTKH] [char](10) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 10/14/2023 11:19:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[MaLoai] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiXe] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 10/14/2023 11:19:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTK] [varchar](23) NOT NULL,
	[MatKhau] [varchar](23) NOT NULL,
	[email] [varchar](50) NULL,
	[TenNguoiDung] [nvarchar](max) NOT NULL,
	[SDT] [char](20) NOT NULL,
	[GioiTinh] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 10/14/2023 11:19:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [nchar](10) NOT NULL,
	[TenXe] [nvarchar](max) NOT NULL,
	[Mau] [nvarchar](50) NOT NULL,
	[DonGia] [numeric](18, 0) NOT NULL,
	[MaLoai] [nchar](10) NOT NULL,
	[HinhAnh] [nvarchar](max) NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChiTietThue]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThue_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[ChiTietThue] CHECK CONSTRAINT [FK_ChiTietThue_KhachHang]
GO
ALTER TABLE [dbo].[ChiTietThue]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThue_TaiKhoan] FOREIGN KEY([TenTK])
REFERENCES [dbo].[TaiKhoan] ([TenTK])
GO
ALTER TABLE [dbo].[ChiTietThue] CHECK CONSTRAINT [FK_ChiTietThue_TaiKhoan]
GO
ALTER TABLE [dbo].[ChiTietThue]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThue_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietThue] CHECK CONSTRAINT [FK_ChiTietThue_Xe]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Xe]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_LoaiXe] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiXe] ([MaLoai])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_LoaiXe]
GO
USE [master]
GO
ALTER DATABASE [QLThueXe] SET  READ_WRITE 
GO
