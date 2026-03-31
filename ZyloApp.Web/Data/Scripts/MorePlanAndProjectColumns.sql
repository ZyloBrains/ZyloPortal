BEGIN TRANSACTION;
ALTER TABLE [Projects] ADD [AllocatedBudget] real NOT NULL DEFAULT CAST(0 AS real);

ALTER TABLE [Projects] ADD [BusinessDomain] int NOT NULL DEFAULT 0;

ALTER TABLE [Projects] ADD [LeadId] nvarchar(450) NULL;

ALTER TABLE [Projects] ADD [OrganizationId] int NOT NULL DEFAULT 0;

ALTER TABLE [Projects] ADD [ProgressStatus] int NOT NULL DEFAULT 0;

ALTER TABLE [Projects] ADD [SpentBudget] real NULL;

CREATE INDEX [IX_Projects_LeadId] ON [Projects] ([LeadId]);

CREATE INDEX [IX_Projects_OrganizationId] ON [Projects] ([OrganizationId]);

ALTER TABLE [Projects] ADD CONSTRAINT [FK_Projects_Organizations_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [Organizations] ([Id]);

ALTER TABLE [Projects] ADD CONSTRAINT [FK_Projects_Users_LeadId] FOREIGN KEY ([LeadId]) REFERENCES [Users] ([Id]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260330181307_AddMoreProjectColumns', N'10.0.1');

COMMIT;
GO

BEGIN TRANSACTION;
ALTER TABLE [Tags] DROP CONSTRAINT [FK_Tags_Training_TrainingId];

DROP INDEX [IX_Tags_TrainingId] ON [Tags];

DECLARE @var nvarchar(max);
SELECT @var = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tags]') AND [c].[name] = N'TrainingId');
IF @var IS NOT NULL EXEC(N'ALTER TABLE [Tags] DROP CONSTRAINT ' + @var + ';');
ALTER TABLE [Tags] DROP COLUMN [TrainingId];

CREATE TABLE [TrainingTags] (
    [TagsId] int NOT NULL,
    [TrainingId] int NOT NULL,
    CONSTRAINT [PK_TrainingTags] PRIMARY KEY ([TagsId], [TrainingId]),
    CONSTRAINT [FK_TrainingTags_Tags_TagsId] FOREIGN KEY ([TagsId]) REFERENCES [Tags] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TrainingTags_Training_TrainingId] FOREIGN KEY ([TrainingId]) REFERENCES [Training] ([Id]) ON DELETE CASCADE
);

CREATE INDEX [IX_TrainingTags_TrainingId] ON [TrainingTags] ([TrainingId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260331142323_AddTrainingTags', N'10.0.1');

COMMIT;
GO

