BEGIN TRANSACTION;
ALTER TABLE [Training] ADD [Format] int NOT NULL DEFAULT 0;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260405150212_TrainingFormatColumn', N'10.0.1');

COMMIT;
GO

BEGIN TRANSACTION;
DECLARE @var nvarchar(max);
SELECT @var = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Training]') AND [c].[name] = N'DurationHours');
IF @var IS NOT NULL EXEC(N'ALTER TABLE [Training] DROP CONSTRAINT ' + @var + ';');
ALTER TABLE [Training] DROP COLUMN [DurationHours];

ALTER TABLE [Training] ADD [Duration] nvarchar(max) NOT NULL DEFAULT N'';

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260405152444_TrainingDurationColumnDataType', N'10.0.1');

COMMIT;
GO

