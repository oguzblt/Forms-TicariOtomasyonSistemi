USE [OtomasyonDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 9.12.2022 21:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bolges]    Script Date: 9.12.2022 21:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolges](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BolgeAd] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Bolges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategoris]    Script Date: 9.12.2022 21:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoris](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAd] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Kategoris] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteris]    Script Date: 9.12.2022 21:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteris](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](max) NULL,
	[Soyad] [nvarchar](max) NULL,
	[DogumTarihi] [nvarchar](max) NULL,
	[Telefon] [nvarchar](max) NULL,
	[Eposta] [nvarchar](max) NULL,
	[SehirId] [int] NULL,
 CONSTRAINT [PK_dbo.Musteris] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personels]    Script Date: 9.12.2022 21:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [int] NOT NULL,
	[Unvan] [nvarchar](max) NULL,
	[PersonelAd] [nvarchar](max) NULL,
	[PersonelSoyad] [nvarchar](max) NULL,
	[PersonelDogumTarihi] [nvarchar](max) NULL,
	[PersonelTelefon] [nvarchar](max) NULL,
	[PersonelEposta] [nvarchar](max) NULL,
	[SubeId] [int] NULL,
 CONSTRAINT [PK_dbo.Personels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satis]    Script Date: 9.12.2022 21:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SatisTarih] [datetime] NOT NULL,
	[MusteriId] [int] NOT NULL,
	[UrunId] [int] NOT NULL,
	[PersonelId] [int] NOT NULL,
	[Sube_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Satis] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sehirs]    Script Date: 9.12.2022 21:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sehirs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SehirAd] [nvarchar](max) NULL,
	[BolgeId] [int] NULL,
 CONSTRAINT [PK_dbo.Sehirs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subes]    Script Date: 9.12.2022 21:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubeAd] [nvarchar](max) NULL,
	[SehirId] [int] NULL,
 CONSTRAINT [PK_dbo.Subes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uruns]    Script Date: 9.12.2022 21:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uruns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UrunCode] [nvarchar](max) NULL,
	[UrunAd] [nvarchar](max) NULL,
	[UrunAdet] [int] NOT NULL,
	[UrunFiyat] [real] NOT NULL,
	[KategoriId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Uruns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Musteris]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Musteris_dbo.Sehirs_SehirId] FOREIGN KEY([SehirId])
REFERENCES [dbo].[Sehirs] ([Id])
GO
ALTER TABLE [dbo].[Musteris] CHECK CONSTRAINT [FK_dbo.Musteris_dbo.Sehirs_SehirId]
GO
ALTER TABLE [dbo].[Personels]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Personels_dbo.Subes_SubeId] FOREIGN KEY([SubeId])
REFERENCES [dbo].[Subes] ([Id])
GO
ALTER TABLE [dbo].[Personels] CHECK CONSTRAINT [FK_dbo.Personels_dbo.Subes_SubeId]
GO
ALTER TABLE [dbo].[Satis]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Satis_dbo.Musteris_MusteriId] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[Musteris] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Satis] CHECK CONSTRAINT [FK_dbo.Satis_dbo.Musteris_MusteriId]
GO
ALTER TABLE [dbo].[Satis]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Satis_dbo.Personels_PersonelId] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Personels] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Satis] CHECK CONSTRAINT [FK_dbo.Satis_dbo.Personels_PersonelId]
GO
ALTER TABLE [dbo].[Satis]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Satis_dbo.Subes_Sube_Id] FOREIGN KEY([Sube_Id])
REFERENCES [dbo].[Subes] ([Id])
GO
ALTER TABLE [dbo].[Satis] CHECK CONSTRAINT [FK_dbo.Satis_dbo.Subes_Sube_Id]
GO
ALTER TABLE [dbo].[Satis]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Satis_dbo.Uruns_UrunId] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Uruns] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Satis] CHECK CONSTRAINT [FK_dbo.Satis_dbo.Uruns_UrunId]
GO
ALTER TABLE [dbo].[Sehirs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Sehirs_dbo.Bolges_BolgeId] FOREIGN KEY([BolgeId])
REFERENCES [dbo].[Bolges] ([Id])
GO
ALTER TABLE [dbo].[Sehirs] CHECK CONSTRAINT [FK_dbo.Sehirs_dbo.Bolges_BolgeId]
GO
ALTER TABLE [dbo].[Subes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Subes_dbo.Sehirs_SehirId] FOREIGN KEY([SehirId])
REFERENCES [dbo].[Sehirs] ([Id])
GO
ALTER TABLE [dbo].[Subes] CHECK CONSTRAINT [FK_dbo.Subes_dbo.Sehirs_SehirId]
GO
ALTER TABLE [dbo].[Uruns]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Uruns_dbo.Kategoris_KategoriId] FOREIGN KEY([KategoriId])
REFERENCES [dbo].[Kategoris] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Uruns] CHECK CONSTRAINT [FK_dbo.Uruns_dbo.Kategoris_KategoriId]
GO
