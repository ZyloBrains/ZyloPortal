
GO

ALTER TABLE [Students] ADD [TrainingId] int NULL;
GO

ALTER TABLE [dbo].[Batches] ADD [TrainingId] int NULL;
ALTER TABLE [dbo].[Batches]
    ADD CONSTRAINT [FK_Batches_Training_TrainingId] FOREIGN KEY ([TrainingId]) REFERENCES [dbo].[Training] ([Id]);
GO

CREATE TABLE [CourseQuotes] (
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [PricePerUnit] real NOT NULL,
    CONSTRAINT [PK_CourseQuotes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Organizations] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Details] nvarchar(max) NOT NULL,
    [OrganizationType] int NOT NULL,
    CONSTRAINT [PK_Organizations] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [CourseQuoteModules] (
    [CourseQuoteId] int NOT NULL,
    [ModulesId] int NOT NULL,
    CONSTRAINT [PK_CourseQuoteModules] PRIMARY KEY ([CourseQuoteId], [ModulesId]),
    CONSTRAINT [FK_CourseQuoteModules_CourseQuotes_CourseQuoteId] FOREIGN KEY ([CourseQuoteId]) REFERENCES [CourseQuotes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CourseQuoteModules_Widgets_ModulesId] FOREIGN KEY ([ModulesId]) REFERENCES [Widgets] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Training] (
    [Id] int NOT NULL IDENTITY,
    [Hash]  nvarchar(max) NULL,
    [Status] int NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [DurationHours] real NOT NULL,
    [DiscountPercentage] real NOT NULL,
    [OrganizationId] int NOT NULL,
    [CourseQuoteId] int NOT NULL,
    [InstructorId] int NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Training] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Training_CourseQuotes_CourseQuoteId] FOREIGN KEY ([CourseQuoteId]) REFERENCES [CourseQuotes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Training_Instructors_InstructorId] FOREIGN KEY ([InstructorId]) REFERENCES [Instructors] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Training_Organizations_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [Organizations] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Students_TrainingId] ON [Students] ([TrainingId]);
GO

CREATE INDEX [IX_CourseQuoteModules_ModulesId] ON [CourseQuoteModules] ([ModulesId]);
GO

CREATE INDEX [IX_Training_CourseQuoteId] ON [Training] ([CourseQuoteId]);
GO

CREATE INDEX [IX_Training_InstructorId] ON [Training] ([InstructorId]);
GO

CREATE INDEX [IX_Training_OrganizationId] ON [Training] ([OrganizationId]);
GO

ALTER TABLE [Students] ADD CONSTRAINT [FK_Students_Training_TrainingId] FOREIGN KEY ([TrainingId]) REFERENCES [Training] ([Id]);
GO

CREATE TABLE [TrainingAssignments] (
    [AssignmentsId] int NOT NULL,
    [TrainingId] int NOT NULL,
    CONSTRAINT [PK_TrainingAssignments] PRIMARY KEY ([AssignmentsId], [TrainingId]),
    CONSTRAINT [FK_TrainingAssignments_Assignments_AssignmentsId] FOREIGN KEY ([AssignmentsId]) REFERENCES [Assignments] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TrainingAssignments_Training_TrainingId] FOREIGN KEY ([TrainingId]) REFERENCES [Training] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [TrainingProjects] (
    [ProjectsId] int NOT NULL,
    [TrainingId] int NOT NULL,
    CONSTRAINT [PK_TrainingProjects] PRIMARY KEY ([ProjectsId], [TrainingId]),
    CONSTRAINT [FK_TrainingProjects_Projects_ProjectsId] FOREIGN KEY ([ProjectsId]) REFERENCES [Projects] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TrainingProjects_Training_TrainingId] FOREIGN KEY ([TrainingId]) REFERENCES [Training] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_TrainingAssignments_TrainingId] ON [TrainingAssignments] ([TrainingId]);
GO

CREATE INDEX [IX_TrainingProjects_TrainingId] ON [TrainingProjects] ([TrainingId]);
GO

COMMIT;
GO
