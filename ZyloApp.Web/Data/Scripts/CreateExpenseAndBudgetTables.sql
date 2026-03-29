BEGIN TRANSACTION;
GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'5d1773ee-b17b-4e68-abef-1501f1681fb4' AND [UserId] = N'e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'5e76db83-6a65-428e-b0ce-d6e4499f7048' AND [UserId] = N'e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'e60d7dcb-9bb3-411a-9f7c-fe5306dcf586' AND [UserId] = N'e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'5d1773ee-b17b-4e68-abef-1501f1681fb4';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'5e76db83-6a65-428e-b0ce-d6e4499f7048';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'e60d7dcb-9bb3-411a-9f7c-fe5306dcf586';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e';
SELECT @@ROWCOUNT;

GO

CREATE TABLE [Expenses] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [Amount] real NOT NULL,
    [ExpenseType] int NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Expenses] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'3f9a2312-2e00-4365-a0b3-5d6fbc3e7948', N'3f9a2312-2e00-4365-a0b3-5d6fbc3e7948', N'SuperAdmin', N'SUPERADMIN'),
(N'64d9897d-8f09-4945-bc3d-f01f7bc847fe', N'64d9897d-8f09-4945-bc3d-f01f7bc847fe', N'Trainee', N'TRAINEE'),
(N'66aa88b4-c31d-4ebe-8b26-5912d8ceb778', N'66aa88b4-c31d-4ebe-8b26-5912d8ceb778', N'Admin', N'ADMIN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa', 0, N'ede86e36-d51d-4114-aeaa-ee879272f24c', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEGDI5OzEK/w6FAeDg/f7xOuRGwwIC+9wWmatw6TzI77twMCQdmZ1MOUIMGYa1x+M0w==', NULL, CAST(0 AS bit), N'4bf7fe05-c8c4-4b34-8be9-d71a3da25167', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-05-06T22:26:44.6010845+05:45'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-06T22:26:44.6010862+05:45'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-06T22:26:44.6010864+05:45'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-06T22:26:44.6010866+05:45'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-06T22:26:44.6010868+05:45'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-06T22:26:44.6010870+05:45'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-06T22:26:44.6010871+05:45'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'3f9a2312-2e00-4365-a0b3-5d6fbc3e7948', N'c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa'),
(N'64d9897d-8f09-4945-bc3d-f01f7bc847fe', N'c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa'),
(N'66aa88b4-c31d-4ebe-8b26-5912d8ceb778', N'c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240506164145_CreateExpenseTable', N'8.0.4');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'3f9a2312-2e00-4365-a0b3-5d6fbc3e7948' AND [UserId] = N'c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'64d9897d-8f09-4945-bc3d-f01f7bc847fe' AND [UserId] = N'c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'66aa88b4-c31d-4ebe-8b26-5912d8ceb778' AND [UserId] = N'c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'3f9a2312-2e00-4365-a0b3-5d6fbc3e7948';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'64d9897d-8f09-4945-bc3d-f01f7bc847fe';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'66aa88b4-c31d-4ebe-8b26-5912d8ceb778';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa';
SELECT @@ROWCOUNT;

GO

CREATE TABLE [BatchBudgets] (
    [Id] int NOT NULL IDENTITY,
    [BudgetType] int NOT NULL,
    [Allocation] real NOT NULL,
    [Amount] real NOT NULL,
    [Notes] nvarchar(max) NULL,
    [BatchId] int NOT NULL,
    CONSTRAINT [PK_BatchBudgets] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BatchBudgets_Batches_BatchId] FOREIGN KEY ([BatchId]) REFERENCES [Batches] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'450dc6cf-81f2-4ea1-9ac9-9e337d5a69f7', N'450dc6cf-81f2-4ea1-9ac9-9e337d5a69f7', N'Admin', N'ADMIN'),
(N'bc7d8682-0811-4485-bd18-cb75edf7b627', N'bc7d8682-0811-4485-bd18-cb75edf7b627', N'SuperAdmin', N'SUPERADMIN'),
(N'e9f31735-cc6a-4e5f-8d44-8c7316187d80', N'e9f31735-cc6a-4e5f-8d44-8c7316187d80', N'Trainee', N'TRAINEE');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'30cb352f-d79a-4464-94b5-3ccfedb04e50', 0, N'50edc872-2345-46c8-8101-d138ae252c82', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEPYjjKrZ94+F3CP5LOmB1Bpt4N55P1AKHC2dfG2VeIg7DGk6EEi6yhx35o5zYjmhiA==', NULL, CAST(0 AS bit), N'b9d42617-13da-4063-bdfa-051e99d183e8', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-05-10T15:58:14.0589103+05:45'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-10T15:58:14.0589124+05:45'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-10T15:58:14.0589127+05:45'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-10T15:58:14.0589129+05:45'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-10T15:58:14.0589132+05:45'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-10T15:58:14.0589134+05:45'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-05-10T15:58:14.0589137+05:45'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'450dc6cf-81f2-4ea1-9ac9-9e337d5a69f7', N'30cb352f-d79a-4464-94b5-3ccfedb04e50'),
(N'bc7d8682-0811-4485-bd18-cb75edf7b627', N'30cb352f-d79a-4464-94b5-3ccfedb04e50'),
(N'e9f31735-cc6a-4e5f-8d44-8c7316187d80', N'30cb352f-d79a-4464-94b5-3ccfedb04e50');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

CREATE INDEX [IX_BatchBudgets_BatchId] ON [BatchBudgets] ([BatchId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240510101318_CreateBatchBudget', N'8.0.4');
GO

COMMIT;
GO

