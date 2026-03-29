BEGIN TRANSACTION;
GO

ALTER TABLE [Students] DROP CONSTRAINT [FK_Students_Colleges_CollegeId];
GO

ALTER TABLE [Students] DROP CONSTRAINT [FK_Students_TechPrograms_TechProgramId];
GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'0a590499-6c8b-4962-ab5b-517a3a1af452' AND [UserId] = N'1f95d999-700e-424b-9dc8-e876f3589f99';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'224643d1-dd33-4069-916d-c3fcbeea4ad3' AND [UserId] = N'1f95d999-700e-424b-9dc8-e876f3589f99';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'fc566747-f92d-4db9-b251-4c4659f167f0' AND [UserId] = N'1f95d999-700e-424b-9dc8-e876f3589f99';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'0a590499-6c8b-4962-ab5b-517a3a1af452';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'224643d1-dd33-4069-916d-c3fcbeea4ad3';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'fc566747-f92d-4db9-b251-4c4659f167f0';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'1f95d999-700e-424b-9dc8-e876f3589f99';
SELECT @@ROWCOUNT;

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'TechProgramId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Students] ALTER COLUMN [TechProgramId] int NULL;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'CollegeId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Students] ALTER COLUMN [CollegeId] int NULL;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'6d092d67-be01-49e9-a8e1-f2a8977ae592', N'6d092d67-be01-49e9-a8e1-f2a8977ae592', N'SuperAdmin', N'SUPERADMIN'),
(N'8453e6fc-6c42-470e-a602-f3263b60ac30', N'8453e6fc-6c42-470e-a602-f3263b60ac30', N'Trainee', N'TRAINEE'),
(N'c9998673-0fd7-4ead-ab18-b0ea8a22999c', N'c9998673-0fd7-4ead-ab18-b0ea8a22999c', N'Admin', N'ADMIN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'd5d1c1bc-b50f-4835-998d-04fd98833154', 0, N'e2010785-619f-4edb-a5b4-fa6db2850812', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAED5lBz8Dgt3AdLyMC0N0uzUWPxB5vN1AKeF/HXKTIgHE5sOACP0gbRMj+2x2RXDOYA==', NULL, CAST(0 AS bit), N'c11a13df-e734-41c2-9ef8-5d52026d4851', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-05-28T21:49:11.3471903+05:45'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-28T21:49:11.3471923+05:45'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-28T21:49:11.3471927+05:45'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-28T21:49:11.3471930+05:45'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-28T21:49:11.3471932+05:45'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-28T21:49:11.3471935+05:45'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-28T21:49:11.3471937+05:45'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'6d092d67-be01-49e9-a8e1-f2a8977ae592', N'd5d1c1bc-b50f-4835-998d-04fd98833154'),
(N'8453e6fc-6c42-470e-a602-f3263b60ac30', N'd5d1c1bc-b50f-4835-998d-04fd98833154'),
(N'c9998673-0fd7-4ead-ab18-b0ea8a22999c', N'd5d1c1bc-b50f-4835-998d-04fd98833154');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

ALTER TABLE [Students] ADD CONSTRAINT [FK_Students_Colleges_CollegeId] FOREIGN KEY ([CollegeId]) REFERENCES [Colleges] ([Id]);
GO

ALTER TABLE [Students] ADD CONSTRAINT [FK_Students_TechPrograms_TechProgramId] FOREIGN KEY ([TechProgramId]) REFERENCES [TechPrograms] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240528160414_StudentNullables', N'8.0.4');
GO

COMMIT;
GO

