USE [Commerce]
GO

/****** Object:  Table [dbo].[ProductReview]    Script Date: 9/7/2017 8:23:01 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductReview](
	[ID] [int] NOT NULL,
	[AuthorEmail] [nvarchar](50) NULL,
	[AuthorName] [nvarchar](50) NULL,
	[ProductID] [int] NOT NULL,
	[ReviewBody] [nvarchar](max) NULL,
	[ReviewDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


