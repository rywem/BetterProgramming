USE [Commerce]
GO

/****** Object:  Table [dbo].[Category]    Script Date: 9/7/2017 8:22:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ParentID] [int] NULL,
	[SubCategories] [nvarchar](50) NULL
) ON [PRIMARY]
GO


