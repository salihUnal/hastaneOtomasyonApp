USE [Cht_StokTakip]
GO
/****** Object:  Table [dbo].[Stoklar]    Script Date: 05/15/2011 18:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Stoklar](
	[StokKayitNo] [int] IDENTITY(1,1) NOT NULL,
	[StokKodu] [varchar](50) NULL,
	[StokAdi] [varchar](50) NULL,
	[VergiOrani] [float] NULL,
 CONSTRAINT [PK_Stoklar] PRIMARY KEY CLUSTERED 
(
	[StokKayitNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StokGC]    Script Date: 05/15/2011 18:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StokGC](
	[StokGCKayitNo] [int] IDENTITY(1,1) NOT NULL,
	[StokGCTipi] [int] NULL,
	[StokGCTarih] [datetime] NULL,
	[StokGCEvrakNo] [int] NULL,
	[StokGCSatirNo] [int] NULL,
	[StokGCMusteriKodu] [varchar](50) NULL,
	[StokGCMusteriAdresNo] [int] NULL,
	[StokGCStokKodu] [varchar](50) NULL,
	[StokGCStokFiyatNo] [int] NULL,
	[StokGCStokFiyati] [float] NULL,
	[StokGCStokMiktari] [float] NULL,
	[StokGCStokVergi] [float] NULL,
	[StokGCStokTutar] [float] NULL,
 CONSTRAINT [PK_StokGC] PRIMARY KEY CLUSTERED 
(
	[StokGCKayitNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StokFiyatlari]    Script Date: 05/15/2011 18:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StokFiyatlari](
	[StokFiyatKayitNo] [int] IDENTITY(1,1) NOT NULL,
	[StokFiyatStokKodu] [varchar](50) NULL,
	[StokFiyatNo] [int] NULL,
	[StokFiyatFiyati] [float] NULL,
 CONSTRAINT [PK_StokFiyatlari_1] PRIMARY KEY CLUSTERED 
(
	[StokFiyatKayitNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 05/15/2011 18:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriKayitNo] [int] IDENTITY(1,1) NOT NULL,
	[MusteriKodu] [varchar](50) NOT NULL,
	[MusteriUnvani] [varchar](50) NULL,
	[MusteriYetkilisi] [varchar](50) NULL,
	[MusteriVergiDairesi] [varchar](50) NULL,
	[MusteriVergiNo] [varchar](50) NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[MusteriKayitNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MusteriAdresleri]    Script Date: 05/15/2011 18:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MusteriAdresleri](
	[MusteriAdresKayitNo] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdresMusteriKodu] [varchar](50) NULL,
	[MusteriAdresNo] [int] NULL,
	[MusteriAdresCadde] [varchar](50) NULL,
	[MusteriAdresSokak] [varchar](50) NULL,
	[MusteriAdresIlce] [varchar](50) NULL,
	[MusteriAdresIl] [varchar](50) NULL,
	[MusteriAdresTelefon] [varchar](50) NULL,
 CONSTRAINT [PK_MusteriAdresleri] PRIMARY KEY CLUSTERED 
(
	[MusteriAdresKayitNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
