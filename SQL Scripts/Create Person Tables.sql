/****** Object:  Table [dbo].[Person]    Script Date: 4/19/2017 10:55:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[PersonTypeId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonType]    Script Date: 4/19/2017 10:55:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonType](
	[id] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PersonType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Email], [Phone], [PersonTypeId]) VALUES (N'ca8f78c3-7f30-480c-b0a4-ac316bb74cbc', N'Clint', N'Eastwood', N'clint@eastwood.com', N'', N'10648d54-6cb2-4f75-8698-026fdd729c34')
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Email], [Phone], [PersonTypeId]) VALUES (N'00a1f351-a856-4516-8542-bebaab22b54a', N'Eli', N'Wallach', N'eli@wallach.com', N'', N'20b0d11d-1c91-4783-84cd-171c9329e06c')
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Email], [Phone], [PersonTypeId]) VALUES (N'c291929d-2170-437e-95e2-e0749daba797', N'Lee', N'Van Cleef', N'lee@vancleef.com', N'', N'c784b001-4080-4d6e-a0d5-d39f5d93d3f9')
INSERT [dbo].[PersonType] ([id], [Description]) VALUES (N'10648d54-6cb2-4f75-8698-026fdd729c34', N'Good')
INSERT [dbo].[PersonType] ([id], [Description]) VALUES (N'20b0d11d-1c91-4783-84cd-171c9329e06c', N'Bad')
INSERT [dbo].[PersonType] ([id], [Description]) VALUES (N'c784b001-4080-4d6e-a0d5-d39f5d93d3f9', N'Ugly')
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_FirstName]  DEFAULT ('') FOR [FirstName]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_LastName]  DEFAULT ('') FOR [LastName]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_Email]  DEFAULT ('') FOR [Email]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_Phone]  DEFAULT ('') FOR [Phone]
GO
ALTER TABLE [dbo].[PersonType] ADD  CONSTRAINT [DF_PersonType_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[PersonType] ADD  CONSTRAINT [DF_PersonType_Description]  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [fk_PersonType_Person] FOREIGN KEY([PersonTypeId])
REFERENCES [dbo].[PersonType] ([id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [fk_PersonType_Person]
GO
USE [master]
GO
ALTER DATABASE [DockerSample] SET  READ_WRITE 
GO
