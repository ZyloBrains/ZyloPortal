BEGIN TRANSACTION;
ALTER TABLE [Students] DROP CONSTRAINT [FK_Students_Colleges_CollegeId];

DROP TABLE [Colleges];

DECLARE @var nvarchar(max);
SELECT @var = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'DbExperience');
IF @var IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var + ';');
ALTER TABLE [Students] DROP COLUMN [DbExperience];

DECLARE @var1 nvarchar(max);
SELECT @var1 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'GeneralProgramming');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var1 + ';');
ALTER TABLE [Students] DROP COLUMN [GeneralProgramming];

DECLARE @var2 nvarchar(max);
SELECT @var2 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'WebExperience');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var2 + ';');
ALTER TABLE [Students] DROP COLUMN [WebExperience];

ALTER TABLE [Revenues] ADD [Frequency] int NOT NULL DEFAULT 0;

ALTER TABLE [Expenses] ADD [BillImagePath] nvarchar(max) NULL;

ALTER TABLE [Expenses] ADD [Date] datetime2 NULL;

ALTER TABLE [Expenses] ADD [Frequency] int NOT NULL DEFAULT 0;

ALTER TABLE [Students] ADD CONSTRAINT [FK_Students_Organizations_CollegeId] FOREIGN KEY ([CollegeId]) REFERENCES [Organizations] ([Id]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260411143903_AddExpenseColumnsAnd', N'10.0.1');

COMMIT;
GO

