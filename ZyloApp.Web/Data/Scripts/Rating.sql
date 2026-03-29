SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[Id] [nvarchar](450) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Expiration] [datetime2](7) NOT NULL,
	[InstructorId] [int] NOT NULL,
	[TrainingId] [int] NOT NULL,
	[Created] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdated] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_Reviews_InstructorId] ON [dbo].[Reviews]
(
	[InstructorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_Reviews_TrainingId] ON [dbo].[Reviews]
(
	[TrainingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Instructors_InstructorId] FOREIGN KEY([InstructorId])
REFERENCES [dbo].[Instructors] ([Id])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Instructors_InstructorId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Training_TrainingId] FOREIGN KEY([TrainingId])
REFERENCES [dbo].[Training] ([Id])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Training_TrainingId]
GO


CREATE TABLE [dbo].[ConsultantRatings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsAnonymous] [bit] NOT NULL,
	[RecommendToOthers] [bit] NOT NULL,
	[CourseContentScore] [tinyint] NOT NULL,
	[TimeManagementScore] [tinyint] NOT NULL,
	[GuidingApproachScore] [tinyint] NOT NULL,
	[AssignmentsQualityScore] [tinyint] NOT NULL,
	[ProjectsQualityScore] [tinyint] NOT NULL,
	[Reviewer] [nvarchar](max) NOT NULL,
	[Comments] [nvarchar](max) NOT NULL,
	[ReviewFormId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_ConsultantRatings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE NONCLUSTERED INDEX [IX_ConsultantRatings_ReviewFormId] ON [dbo].[ConsultantRatings]
(
	[ReviewFormId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ConsultantRatings]  WITH CHECK ADD  CONSTRAINT [FK_ConsultantRatings_Reviews_ReviewFormId] FOREIGN KEY([ReviewFormId])
REFERENCES [dbo].[Reviews] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ConsultantRatings] CHECK CONSTRAINT [FK_ConsultantRatings_Reviews_ReviewFormId]
GO