USE [Commerce]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 9/7/2017 8:22:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NULL,
	[Description] [nvarchar](50) NULL,
	[DiscountAmount] [decimal](18, 0) NULL,
	[DiscountPercent] [decimal](18, 0) NULL,
	[LargePhotoFile] [nvarchar](max) NULL,
	[ListPrice] [decimal](18, 0) NULL,
	[Name] [nvarchar](50) NULL,
	[SummaryDescription] [nvarchar](max) NULL,
	[ThumbnailFileName] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


