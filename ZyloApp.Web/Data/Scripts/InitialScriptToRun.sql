IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Batches] (
    [Id] int NOT NULL IDENTITY,
    [Start] datetime2 NOT NULL,
    [End] datetime2 NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Batches] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Colleges] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Location] nvarchar(max) NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Colleges] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [FinAccounts] (
    [Id] int NOT NULL IDENTITY,
    [FeeAmount] real NOT NULL,
    [Discount] real NOT NULL,
    [PaidAmount] real NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_FinAccounts] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Instructors] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Role] nvarchar(max) NOT NULL,
    [Resume] nvarchar(max) NOT NULL,
    [ProfilePath] nvarchar(max) NULL,
    [Publish] bit NOT NULL,
    CONSTRAINT [PK_Instructors] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Projects] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Requirements] nvarchar(max) NOT NULL,
    [RepoUrl] nvarchar(max) NULL,
    [BoardUrl] nvarchar(max) NULL,
    CONSTRAINT [PK_Projects] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Roles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Tags] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NULL,
    [ColorCode] nvarchar(max) NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Tags] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [TechPrograms] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Affliation] nvarchar(max) NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_TechPrograms] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Users] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Widgets] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [HtmlContent] nvarchar(max) NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Widgets] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Teams] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Avatar] nvarchar(max) NULL,
    [BatchId] int NULL,
    [ProjectId] int NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Teams] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Teams_Batches_BatchId] FOREIGN KEY ([BatchId]) REFERENCES [Batches] ([Id]),
    CONSTRAINT [FK_Teams_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([Id])
);
GO

CREATE TABLE [RoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_RoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_RoleClaims_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [InstructorTag] (
    [InstructorId] int NOT NULL,
    [TagsId] int NOT NULL,
    CONSTRAINT [PK_InstructorTag] PRIMARY KEY ([InstructorId], [TagsId]),
    CONSTRAINT [FK_InstructorTag_Instructors_InstructorId] FOREIGN KEY ([InstructorId]) REFERENCES [Instructors] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_InstructorTag_Tags_TagsId] FOREIGN KEY ([TagsId]) REFERENCES [Tags] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_UserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserClaims_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_UserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_UserLogins_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserRole] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_UserRole] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_UserRole_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserRole_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_UserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_UserTokens_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [TagWidget] (
    [TagsId] int NOT NULL,
    [WidgetsId] int NOT NULL,
    CONSTRAINT [PK_TagWidget] PRIMARY KEY ([TagsId], [WidgetsId]),
    CONSTRAINT [FK_TagWidget_Tags_TagsId] FOREIGN KEY ([TagsId]) REFERENCES [Tags] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TagWidget_Widgets_WidgetsId] FOREIGN KEY ([WidgetsId]) REFERENCES [Widgets] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Students] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Phone] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [GeneralProgramming] int NOT NULL,
    [WebExperience] int NOT NULL,
    [DbExperience] int NOT NULL,
    [FormSubmitted] datetime2 NULL,
    [Status] int NOT NULL,
    [ProfileImagePath] nvarchar(max) NULL,
    [CollegeId] int NOT NULL,
    [TechProgramId] int NOT NULL,
    [FinAccountId] int NULL,
    [TeamId] int NULL,
    [BatchId] int NULL,
    [ApplicationUserId] nvarchar(450) NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Students_Batches_BatchId] FOREIGN KEY ([BatchId]) REFERENCES [Batches] ([Id]),
    CONSTRAINT [FK_Students_Colleges_CollegeId] FOREIGN KEY ([CollegeId]) REFERENCES [Colleges] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Students_FinAccounts_FinAccountId] FOREIGN KEY ([FinAccountId]) REFERENCES [FinAccounts] ([Id]),
    CONSTRAINT [FK_Students_Teams_TeamId] FOREIGN KEY ([TeamId]) REFERENCES [Teams] ([Id]),
    CONSTRAINT [FK_Students_TechPrograms_TechProgramId] FOREIGN KEY ([TechProgramId]) REFERENCES [TechPrograms] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Students_Users_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [Users] ([Id])
);
GO

CREATE TABLE [Attendances] (
    [Id] int NOT NULL IDENTITY,
    [Date] date NOT NULL,
    [PunchIn] time NULL,
    [PunchOut] time NULL,
    [WorkLog] nvarchar(max) NULL,
    [StudentId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_Attendances] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Attendances_Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Students] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Location', N'Name') AND [object_id] = OBJECT_ID(N'[Colleges]'))
    SET IDENTITY_INSERT [Colleges] ON;
INSERT INTO [Colleges] ([Id], [Created], [CreatedBy], [LastUpdated], [LastUpdatedBy], [Location], [Name])
VALUES (1, '2024-02-06T20:04:26.2242488-05:00', NULL, NULL, NULL, N'Bhadrapur, Jhapa', N'Mechi Multiple Campus'),
(2, '2024-02-06T20:04:26.2242510-05:00', NULL, NULL, NULL, N'Dhankuta', N'Dhankuta Multiple Campus'),
(3, '2024-02-06T20:04:26.2242511-05:00', NULL, NULL, NULL, N'Dharan', N'Central Campus of Technology'),
(4, '2024-02-06T20:04:26.2242512-05:00', NULL, NULL, NULL, N'Biratnagar', N'Mahendra Morang Adarsha Multiple Campus'),
(5, '2024-02-06T20:04:26.2242513-05:00', NULL, NULL, NULL, N'Rajbiraj', N'Mahendra Bindeshwori Multiple Campus'),
(6, '2024-02-06T20:04:26.2242515-05:00', NULL, NULL, NULL, N'Siraha', N'Surya Narayan Satya Na. Mo. Yadav Campus'),
(7, '2024-02-06T20:04:26.2242516-05:00', NULL, NULL, NULL, N'Janakpur', N'Ramsorup Ramsagar Multiple Campus'),
(8, '2024-02-06T20:04:26.2242517-05:00', NULL, NULL, NULL, N'Birgunj', N'Thakur Ram Multiple Campus'),
(9, '2024-02-06T20:04:26.2242518-05:00', NULL, NULL, NULL, N'Bharatpur', N'Birendra Multiple Campus'),
(10, '2024-02-06T20:04:26.2242519-05:00', NULL, NULL, NULL, N'Pokhara', N'Prithivi Narayan Multiple Campus'),
(11, '2024-02-06T20:04:26.2242520-05:00', NULL, NULL, NULL, N'Mahendranagar', N'SidhaNath Science Campus'),
(12, '2024-02-06T20:04:26.2242521-05:00', NULL, NULL, NULL, N'Nepalgunj', N'Mahendra Multiple Campus'),
(13, '2024-02-06T20:04:26.2242522-05:00', NULL, NULL, NULL, N'Butwal', N'Butwal Multiple Campus'),
(14, '2024-02-06T20:04:26.2242523-05:00', NULL, NULL, NULL, N'Palpa', N'Tribhuvan Multiple Campus'),
(15, '2024-02-06T20:04:26.2242524-05:00', NULL, NULL, NULL, N'Ghantaghar', N'Tri-Chandra Multiple Campus'),
(16, '2024-02-06T20:04:26.2242525-05:00', NULL, NULL, NULL, N'Lainchour', N'Amrit Science Campus'),
(17, '2024-02-06T20:04:26.2242526-05:00', NULL, NULL, NULL, N'Patan', N'Patan Multiple Campus'),
(18, '2024-02-06T20:04:26.2242527-05:00', NULL, NULL, NULL, N'Bhaktapur', N'Bhaktapur Multiple Campus'),
(19, '2024-02-06T20:04:26.2242528-05:00', NULL, NULL, NULL, N'Bagbazar', N'Padma Kanya Multiple Campus'),
(20, '2024-02-06T20:04:26.2242529-05:00', NULL, NULL, NULL, N'Ghorahi, Dang', N'Mahendra Multiple Campus'),
(21, '2024-02-06T20:04:26.2242530-05:00', NULL, NULL, NULL, N'Baglung', N'Dhaulagiri Campus'),
(22, '2024-02-06T20:04:26.2242531-05:00', NULL, NULL, NULL, N'Gorkha', N'Gorkha Campus'),
(23, '2024-02-06T20:04:26.2242532-05:00', NULL, NULL, NULL, N'Bhairahawa', N'Bhairahawa Multiple Campus'),
(24, '2024-02-06T20:04:26.2242533-05:00', NULL, NULL, NULL, N'Biratnagar', N'Degree Campus');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Location', N'Name') AND [object_id] = OBJECT_ID(N'[Colleges]'))
    SET IDENTITY_INSERT [Colleges] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'32fd450f-ab5e-4b63-a7dc-38f5e30e502c', N'32fd450f-ab5e-4b63-a7dc-38f5e30e502c', N'Trainee', N'TRAINEE'),
(N'3d7bc476-9cdd-4eb8-899f-2c313ec71e73', N'3d7bc476-9cdd-4eb8-899f-2c313ec71e73', N'SuperAdmin', N'SUPERADMIN'),
(N'9fa4ba00-c6a1-487b-a6c4-f56fb276bd67', N'9fa4ba00-c6a1-487b-a6c4-f56fb276bd67', N'Admin', N'ADMIN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Affliation', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Name') AND [object_id] = OBJECT_ID(N'[TechPrograms]'))
    SET IDENTITY_INSERT [TechPrograms] ON;
INSERT INTO [TechPrograms] ([Id], [Affliation], [Created], [CreatedBy], [LastUpdated], [LastUpdatedBy], [Name])
VALUES (1, N'TU', '2024-02-06T20:04:26.2242913-05:00', NULL, NULL, NULL, N'BCA'),
(2, N'PU', '2024-02-06T20:04:26.2242918-05:00', NULL, NULL, NULL, N'BCA'),
(3, N'TU', '2024-02-06T20:04:26.2242919-05:00', NULL, NULL, NULL, N'BIT'),
(4, N'PU', '2024-02-06T20:04:26.2242920-05:00', NULL, NULL, NULL, N'BIT'),
(5, N'TU', '2024-02-06T20:04:26.2242921-05:00', NULL, NULL, NULL, N'BIM'),
(6, N'TU', '2024-02-06T20:04:26.2242922-05:00', NULL, NULL, NULL, N'BScIT'),
(7, N'PU', '2024-02-06T20:04:26.2242923-05:00', NULL, NULL, NULL, N'BScIT');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Affliation', N'Created', N'CreatedBy', N'LastUpdated', N'LastUpdatedBy', N'Name') AND [object_id] = OBJECT_ID(N'[TechPrograms]'))
    SET IDENTITY_INSERT [TechPrograms] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'08e4ff02-9df1-415c-ab49-892c539a689b', 0, N'4d6c5e2a-3981-4764-af81-07e4e6b1d0f6', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEMXZQToP7v66Y+cWWQGENKbKu2mcOvH4kemxkuFg97K4ms2RfWmrqOtgi2lYFxgkTQ==', NULL, CAST(0 AS bit), N'09e416de-8a5d-46a4-aa2b-1b79bed5c8db', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Created', N'CreatedBy', N'Description', N'HtmlContent', N'LastUpdated', N'LastUpdatedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Widgets]'))
    SET IDENTITY_INSERT [Widgets] ON;
INSERT INTO [Widgets] ([Id], [Created], [CreatedBy], [Description], [HtmlContent], [LastUpdated], [LastUpdatedBy], [Title])
VALUES (1, '2024-02-06T20:04:26.2242975-05:00', N'Seed', N'An display item in home page', N'Welcome to AppTechnoSoft! An initiative for students and freshers.', NULL, NULL, N'CarouselItem'),
(2, '2024-02-06T20:04:26.2242979-05:00', N'Seed', N'An display item in home page', N'Bridging the gap between academia and industry!', NULL, NULL, N'CarouselItem'),
(3, '2024-02-06T20:04:26.2242981-05:00', N'Seed', N'An display item in home page', N'We guide you on software R&D and SDLC to kickstart your career!', NULL, NULL, N'CarouselItem'),
(4, '2024-02-06T20:04:26.2242983-05:00', N'Seed', N'An display item in home page', N'Replacement Opportunities!', NULL, NULL, N'CarouselItem'),
(5, '2024-02-06T20:04:26.2242985-05:00', N'Seed', N'An display item in home page', N'From basics to professional touches!', NULL, NULL, N'CarouselItem'),
(6, '2024-02-06T20:04:26.2242988-05:00', N'Seed', N'GIT and GitHub Essentials', N'todo', NULL, NULL, N'Module'),
(7, '2024-02-06T20:04:26.2242990-05:00', N'Seed', N'Training + Internship Combo', N'todo', NULL, NULL, N'HomeIntro');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Created', N'CreatedBy', N'Description', N'HtmlContent', N'LastUpdated', N'LastUpdatedBy', N'Title') AND [object_id] = OBJECT_ID(N'[Widgets]'))
    SET IDENTITY_INSERT [Widgets] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'3d7bc476-9cdd-4eb8-899f-2c313ec71e73', N'08e4ff02-9df1-415c-ab49-892c539a689b');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

CREATE INDEX [IX_Attendances_StudentId] ON [Attendances] ([StudentId]);
GO

CREATE INDEX [IX_InstructorTag_TagsId] ON [InstructorTag] ([TagsId]);
GO

CREATE INDEX [IX_RoleClaims_RoleId] ON [RoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [Roles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_Students_ApplicationUserId] ON [Students] ([ApplicationUserId]);
GO

CREATE INDEX [IX_Students_BatchId] ON [Students] ([BatchId]);
GO

CREATE INDEX [IX_Students_CollegeId] ON [Students] ([CollegeId]);
GO

CREATE INDEX [IX_Students_FinAccountId] ON [Students] ([FinAccountId]);
GO

CREATE INDEX [IX_Students_TeamId] ON [Students] ([TeamId]);
GO

CREATE INDEX [IX_Students_TechProgramId] ON [Students] ([TechProgramId]);
GO

CREATE INDEX [IX_TagWidget_WidgetsId] ON [TagWidget] ([WidgetsId]);
GO

CREATE INDEX [IX_Teams_BatchId] ON [Teams] ([BatchId]);
GO

CREATE INDEX [IX_Teams_ProjectId] ON [Teams] ([ProjectId]);
GO

CREATE INDEX [IX_UserClaims_UserId] ON [UserClaims] ([UserId]);
GO

CREATE INDEX [IX_UserLogins_UserId] ON [UserLogins] ([UserId]);
GO

CREATE INDEX [IX_UserRole_RoleId] ON [UserRole] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [Users] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [Users] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240206141926_Initial', N'8.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Students] DROP CONSTRAINT [FK_Students_FinAccounts_FinAccountId];
GO

DROP INDEX [IX_Students_FinAccountId] ON [Students];
GO

DELETE FROM [Roles]
WHERE [Id] = N'32fd450f-ab5e-4b63-a7dc-38f5e30e502c';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'9fa4ba00-c6a1-487b-a6c4-f56fb276bd67';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'3d7bc476-9cdd-4eb8-899f-2c313ec71e73' AND [UserId] = N'08e4ff02-9df1-415c-ab49-892c539a689b';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'3d7bc476-9cdd-4eb8-899f-2c313ec71e73';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'08e4ff02-9df1-415c-ab49-892c539a689b';
SELECT @@ROWCOUNT;

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'FinAccountId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Students] DROP COLUMN [FinAccountId];
GO

ALTER TABLE [FinAccounts] ADD [StudentId] nvarchar(450) NOT NULL DEFAULT N'';
GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 8;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 9;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 10;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 11;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 12;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 13;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 14;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 15;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 16;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 17;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 18;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 19;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 20;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 21;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 22;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 23;
SELECT @@ROWCOUNT;

GO

UPDATE [Colleges] SET [Created] = NULL
WHERE [Id] = 24;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'52a1c35a-e1c5-4466-8879-953a975a3bb1', N'52a1c35a-e1c5-4466-8879-953a975a3bb1', N'Admin', N'ADMIN'),
(N'86b30e13-0c78-4436-b297-3993f840ba12', N'86b30e13-0c78-4436-b297-3993f840ba12', N'Trainee', N'TRAINEE'),
(N'999556a0-4c04-45ad-84cc-811814e7a580', N'999556a0-4c04-45ad-84cc-811814e7a580', N'SuperAdmin', N'SUPERADMIN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

UPDATE [TechPrograms] SET [Created] = NULL
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = NULL
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = NULL
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = NULL
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = NULL
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = NULL
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [TechPrograms] SET [Created] = NULL
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'21e10d3e-51e3-4f5f-ab21-7249ea386de9', 0, N'42bba37d-b489-40d0-a28d-a590ceac5775', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEHqHch1v92ttjXAvWaX/EKEe6Rs/QFwTfG98yL/JwQLRfYf5jPWxxBGzcA8lyWXeqw==', NULL, CAST(0 AS bit), N'93b7aca7-b0e5-4b3f-a2dc-7823632cd996', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-02-08T14:06:52.5881678-05:00'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-08T14:06:52.5881704-05:00'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-08T14:06:52.5881706-05:00'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-08T14:06:52.5881708-05:00'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-08T14:06:52.5881709-05:00'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-08T14:06:52.5881711-05:00'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-08T14:06:52.5881713-05:00'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'999556a0-4c04-45ad-84cc-811814e7a580', N'21e10d3e-51e3-4f5f-ab21-7249ea386de9');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

CREATE UNIQUE INDEX [IX_FinAccounts_StudentId] ON [FinAccounts] ([StudentId]);
GO

ALTER TABLE [FinAccounts] ADD CONSTRAINT [FK_FinAccounts_Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Students] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240208082153_FinAccount', N'8.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [Roles]
WHERE [Id] = N'52a1c35a-e1c5-4466-8879-953a975a3bb1';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'86b30e13-0c78-4436-b297-3993f840ba12';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'999556a0-4c04-45ad-84cc-811814e7a580' AND [UserId] = N'21e10d3e-51e3-4f5f-ab21-7249ea386de9';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'999556a0-4c04-45ad-84cc-811814e7a580';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'21e10d3e-51e3-4f5f-ab21-7249ea386de9';
SELECT @@ROWCOUNT;

GO

ALTER TABLE [FinAccounts] ADD [Enabled] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'29148e4d-ec64-4b47-85c8-b18e75169eb3', N'29148e4d-ec64-4b47-85c8-b18e75169eb3', N'Admin', N'ADMIN'),
(N'2a7568fb-3f0f-4b18-a12f-16aa900b2d50', N'2a7568fb-3f0f-4b18-a12f-16aa900b2d50', N'Trainee', N'TRAINEE'),
(N'96c26fad-8f6d-4342-b59d-0c1717a876be', N'96c26fad-8f6d-4342-b59d-0c1717a876be', N'SuperAdmin', N'SUPERADMIN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'67f95be8-a3a9-4fef-aa39-8a9dc41be743', 0, N'f36d959e-f3aa-4dd1-9c6a-ee5f3e175cc4', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEJvTzw2CPVwae7wMdIX7SIgHpilwq9P5qDI6xwOS9pU2SenTWXM3cblqXNAYBEyx4g==', NULL, CAST(0 AS bit), N'22b12efd-04d7-4428-92ef-51f732657df6', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-02-10T10:05:21.9931410-05:00'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-10T10:05:21.9931431-05:00'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-10T10:05:21.9931433-05:00'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-10T10:05:21.9931435-05:00'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-10T10:05:21.9931436-05:00'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-10T10:05:21.9931438-05:00'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-02-10T10:05:21.9931440-05:00'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'96c26fad-8f6d-4342-b59d-0c1717a876be', N'67f95be8-a3a9-4fef-aa39-8a9dc41be743');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240210042022_FinAccountEnabled', N'8.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [Roles]
WHERE [Id] = N'29148e4d-ec64-4b47-85c8-b18e75169eb3';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'2a7568fb-3f0f-4b18-a12f-16aa900b2d50';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'96c26fad-8f6d-4342-b59d-0c1717a876be' AND [UserId] = N'67f95be8-a3a9-4fef-aa39-8a9dc41be743';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'96c26fad-8f6d-4342-b59d-0c1717a876be';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'67f95be8-a3a9-4fef-aa39-8a9dc41be743';
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'14131e25-2a6a-4ff1-9cc1-c1d761d56d3c', N'14131e25-2a6a-4ff1-9cc1-c1d761d56d3c', N'SuperAdmin', N'SUPERADMIN'),
(N'9730035d-aade-47fb-ac77-1ef1c3f397d1', N'9730035d-aade-47fb-ac77-1ef1c3f397d1', N'Trainee', N'TRAINEE'),
(N'9d23edfe-95ff-4c72-b2e9-1303b5aa4a72', N'9d23edfe-95ff-4c72-b2e9-1303b5aa4a72', N'Admin', N'ADMIN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'068eb185-9fbc-4f03-82ec-1a2b91bd590c', 0, N'294fe060-9787-4db0-b94b-8b3e7c781ce1', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEOKeEpOj3n4dR+v6s+JUXuJs9q8mZCv4AGgmCttyq/J2erjeohxa6DNmspQ8sdup/Q==', NULL, CAST(0 AS bit), N'611af537-ec36-4291-8996-9398bf01092f', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:01:53.1441605-05:00'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:01:53.1441631-05:00'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:01:53.1441634-05:00'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:01:53.1441636-05:00'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:01:53.1441639-05:00'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:01:53.1441641-05:00'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:01:53.1441644-05:00'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'14131e25-2a6a-4ff1-9cc1-c1d761d56d3c', N'068eb185-9fbc-4f03-82ec-1a2b91bd590c'),
(N'9730035d-aade-47fb-ac77-1ef1c3f397d1', N'068eb185-9fbc-4f03-82ec-1a2b91bd590c'),
(N'9d23edfe-95ff-4c72-b2e9-1303b5aa4a72', N'068eb185-9fbc-4f03-82ec-1a2b91bd590c');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240309041654_ClassSchedule', N'8.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'14131e25-2a6a-4ff1-9cc1-c1d761d56d3c' AND [UserId] = N'068eb185-9fbc-4f03-82ec-1a2b91bd590c';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'9730035d-aade-47fb-ac77-1ef1c3f397d1' AND [UserId] = N'068eb185-9fbc-4f03-82ec-1a2b91bd590c';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'9d23edfe-95ff-4c72-b2e9-1303b5aa4a72' AND [UserId] = N'068eb185-9fbc-4f03-82ec-1a2b91bd590c';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'14131e25-2a6a-4ff1-9cc1-c1d761d56d3c';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'9730035d-aade-47fb-ac77-1ef1c3f397d1';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'9d23edfe-95ff-4c72-b2e9-1303b5aa4a72';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'068eb185-9fbc-4f03-82ec-1a2b91bd590c';
SELECT @@ROWCOUNT;

GO

CREATE TABLE [ClassSchedules] (
    [Id] int NOT NULL IDENTITY,
    [ClassStart] datetime2 NOT NULL,
    [DurationHours] real NOT NULL,
    [MeetingDetails] nvarchar(max) NULL,
    [BatchId] int NOT NULL,
    [WidgetId] int NULL,
    [InstructorId] int NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_ClassSchedules] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ClassSchedules_Batches_BatchId] FOREIGN KEY ([BatchId]) REFERENCES [Batches] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ClassSchedules_Instructors_InstructorId] FOREIGN KEY ([InstructorId]) REFERENCES [Instructors] ([Id]),
    CONSTRAINT [FK_ClassSchedules_Widgets_WidgetId] FOREIGN KEY ([WidgetId]) REFERENCES [Widgets] ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'90309be9-e358-45db-b947-648d05b07d16', N'90309be9-e358-45db-b947-648d05b07d16', N'Admin', N'ADMIN'),
(N'c83ad093-89aa-49a6-baaa-087cf8301438', N'c83ad093-89aa-49a6-baaa-087cf8301438', N'Trainee', N'TRAINEE'),
(N'd7556600-7150-46ea-862d-e3cbe8e98030', N'd7556600-7150-46ea-862d-e3cbe8e98030', N'SuperAdmin', N'SUPERADMIN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'290e55b7-1959-4d73-bb4f-667e402ee595', 0, N'4b298eaf-35dd-4265-8ea8-47e4767d1f8a', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEP8NssvQVXDwdH0yiavbQ53A3Df7DW3Ov4fzpto7tC3h9XRLDstijbpJd0yIjgIwlA==', NULL, CAST(0 AS bit), N'055ba833-9383-47f9-b3ff-9368ede7918c', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:06:55.3107519-05:00'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:06:55.3107551-05:00'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:06:55.3107553-05:00'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:06:55.3107555-05:00'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:06:55.3107557-05:00'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:06:55.3107558-05:00'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-09T10:06:55.3107560-05:00'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'90309be9-e358-45db-b947-648d05b07d16', N'290e55b7-1959-4d73-bb4f-667e402ee595'),
(N'c83ad093-89aa-49a6-baaa-087cf8301438', N'290e55b7-1959-4d73-bb4f-667e402ee595'),
(N'd7556600-7150-46ea-862d-e3cbe8e98030', N'290e55b7-1959-4d73-bb4f-667e402ee595');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

CREATE INDEX [IX_ClassSchedules_BatchId] ON [ClassSchedules] ([BatchId]);
GO

CREATE INDEX [IX_ClassSchedules_InstructorId] ON [ClassSchedules] ([InstructorId]);
GO

CREATE INDEX [IX_ClassSchedules_WidgetId] ON [ClassSchedules] ([WidgetId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240309042155_ClassScheduleTable', N'8.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'90309be9-e358-45db-b947-648d05b07d16' AND [UserId] = N'290e55b7-1959-4d73-bb4f-667e402ee595';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'c83ad093-89aa-49a6-baaa-087cf8301438' AND [UserId] = N'290e55b7-1959-4d73-bb4f-667e402ee595';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'd7556600-7150-46ea-862d-e3cbe8e98030' AND [UserId] = N'290e55b7-1959-4d73-bb4f-667e402ee595';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'90309be9-e358-45db-b947-648d05b07d16';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'c83ad093-89aa-49a6-baaa-087cf8301438';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'd7556600-7150-46ea-862d-e3cbe8e98030';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'290e55b7-1959-4d73-bb4f-667e402ee595';
SELECT @@ROWCOUNT;

GO

ALTER TABLE [Instructors] ADD [ApplicationUserId] nvarchar(450) NULL;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'3ee98990-870d-4830-bab9-e5a4e8d950e1', N'3ee98990-870d-4830-bab9-e5a4e8d950e1', N'SuperAdmin', N'SUPERADMIN'),
(N'b4c44029-0b6f-4014-a2ec-329898cfea21', N'b4c44029-0b6f-4014-a2ec-329898cfea21', N'Trainee', N'TRAINEE'),
(N'e47118c4-578e-4492-8d49-2984b544a344', N'e47118c4-578e-4492-8d49-2984b544a344', N'Admin', N'ADMIN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'199a4fbe-5997-445c-95e0-a1c07450ab54', 0, N'62303d91-bd47-45ee-92cc-b1c77cbc99c7', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEJXfI7MbRGFJGiL5AhEHVGRTkpTyJYJ3YaCA+Qzn3yuLtBCI+X/pE9Jz4mxVUcknbA==', NULL, CAST(0 AS bit), N'0c2b9784-e586-407b-b412-baa490ba53cc', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-03-15T18:16:26.1009552-04:00'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T18:16:26.1009569-04:00'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T18:16:26.1009571-04:00'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T18:16:26.1009572-04:00'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T18:16:26.1009574-04:00'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T18:16:26.1009575-04:00'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T18:16:26.1009577-04:00'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'3ee98990-870d-4830-bab9-e5a4e8d950e1', N'199a4fbe-5997-445c-95e0-a1c07450ab54'),
(N'b4c44029-0b6f-4014-a2ec-329898cfea21', N'199a4fbe-5997-445c-95e0-a1c07450ab54'),
(N'e47118c4-578e-4492-8d49-2984b544a344', N'199a4fbe-5997-445c-95e0-a1c07450ab54');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

CREATE INDEX [IX_Instructors_ApplicationUserId] ON [Instructors] ([ApplicationUserId]);
GO

ALTER TABLE [Instructors] ADD CONSTRAINT [FK_Instructors_Users_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [Users] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240315123126_InstructorAddAppUser', N'8.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'3ee98990-870d-4830-bab9-e5a4e8d950e1' AND [UserId] = N'199a4fbe-5997-445c-95e0-a1c07450ab54';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'b4c44029-0b6f-4014-a2ec-329898cfea21' AND [UserId] = N'199a4fbe-5997-445c-95e0-a1c07450ab54';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'e47118c4-578e-4492-8d49-2984b544a344' AND [UserId] = N'199a4fbe-5997-445c-95e0-a1c07450ab54';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'3ee98990-870d-4830-bab9-e5a4e8d950e1';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'b4c44029-0b6f-4014-a2ec-329898cfea21';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'e47118c4-578e-4492-8d49-2984b544a344';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'199a4fbe-5997-445c-95e0-a1c07450ab54';
SELECT @@ROWCOUNT;

GO

ALTER TABLE [Instructors] ADD [Email] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Instructors] ADD [Organization] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [Instructors] ADD [Phone] nvarchar(max) NOT NULL DEFAULT N'';
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'0834d198-cd95-48fd-a418-95f073fddb11', N'0834d198-cd95-48fd-a418-95f073fddb11', N'SuperAdmin', N'SUPERADMIN'),
(N'5b852d07-5fff-4f70-a74c-113c83d84026', N'5b852d07-5fff-4f70-a74c-113c83d84026', N'Admin', N'ADMIN'),
(N'8672b3de-8cad-4a2f-9d1e-d13466cd3a80', N'8672b3de-8cad-4a2f-9d1e-d13466cd3a80', N'Trainee', N'TRAINEE');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'6dab2695-1ee3-44d2-b017-5050d3059bd0', 0, N'417f9183-8100-4140-a35d-54fed8ac770e', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAECX5fxxLWB3+GwKDBkTmt+neHqstbnYINqpGXjd1F5v4cBkSpP8JzMoaqXcJdLNshw==', NULL, CAST(0 AS bit), N'bdeab9c6-a9fb-4fc7-a0b5-19a2ba5d5764', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-03-15T22:25:00.1617434-04:00'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T22:25:00.1617466-04:00'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T22:25:00.1617469-04:00'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T22:25:00.1617471-04:00'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T22:25:00.1617474-04:00'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T22:25:00.1617477-04:00'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-15T22:25:00.1617479-04:00'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'0834d198-cd95-48fd-a418-95f073fddb11', N'6dab2695-1ee3-44d2-b017-5050d3059bd0'),
(N'5b852d07-5fff-4f70-a74c-113c83d84026', N'6dab2695-1ee3-44d2-b017-5050d3059bd0'),
(N'8672b3de-8cad-4a2f-9d1e-d13466cd3a80', N'6dab2695-1ee3-44d2-b017-5050d3059bd0');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240315164000_InstructorColumnsAdded', N'8.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'0834d198-cd95-48fd-a418-95f073fddb11' AND [UserId] = N'6dab2695-1ee3-44d2-b017-5050d3059bd0';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'5b852d07-5fff-4f70-a74c-113c83d84026' AND [UserId] = N'6dab2695-1ee3-44d2-b017-5050d3059bd0';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'8672b3de-8cad-4a2f-9d1e-d13466cd3a80' AND [UserId] = N'6dab2695-1ee3-44d2-b017-5050d3059bd0';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'0834d198-cd95-48fd-a418-95f073fddb11';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'5b852d07-5fff-4f70-a74c-113c83d84026';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'8672b3de-8cad-4a2f-9d1e-d13466cd3a80';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'6dab2695-1ee3-44d2-b017-5050d3059bd0';
SELECT @@ROWCOUNT;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Instructors]') AND [c].[name] = N'Phone');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Instructors] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Instructors] ALTER COLUMN [Phone] nvarchar(max) NULL;
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Instructors]') AND [c].[name] = N'Organization');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Instructors] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Instructors] ALTER COLUMN [Organization] nvarchar(max) NULL;
GO

ALTER TABLE [Instructors] ADD [OtherDetails] nvarchar(max) NULL;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'1f0d7250-9135-4491-ad3b-e9256a0c72ad', N'1f0d7250-9135-4491-ad3b-e9256a0c72ad', N'Admin', N'ADMIN'),
(N'7298c143-63b6-4b78-84c6-ef6f1755095b', N'7298c143-63b6-4b78-84c6-ef6f1755095b', N'Trainee', N'TRAINEE'),
(N'f493ecc2-b7e7-4d2c-a8c9-345ab1ad1e54', N'f493ecc2-b7e7-4d2c-a8c9-345ab1ad1e54', N'SuperAdmin', N'SUPERADMIN');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'bab647d0-ee25-4f51-9063-ecea16ade071', 0, N'6ee5883b-9218-4012-a2de-16e833c70234', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEDKJSPN5oMXIlAdEHZ2hBw/ZOfXgXeDGnjHquIO2jDjBr4v1R7DV94hKdknLMgrLsg==', NULL, CAST(0 AS bit), N'52c53066-3129-487e-86ce-51da71aa6bbf', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-03-22T04:12:07.0373378-04:00'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-22T04:12:07.0373481-04:00'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-22T04:12:07.0373486-04:00'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-22T04:12:07.0373490-04:00'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-22T04:12:07.0373494-04:00'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-22T04:12:07.0373498-04:00'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-22T04:12:07.0373502-04:00'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'1f0d7250-9135-4491-ad3b-e9256a0c72ad', N'bab647d0-ee25-4f51-9063-ecea16ade071'),
(N'7298c143-63b6-4b78-84c6-ef6f1755095b', N'bab647d0-ee25-4f51-9063-ecea16ade071'),
(N'f493ecc2-b7e7-4d2c-a8c9-345ab1ad1e54', N'bab647d0-ee25-4f51-9063-ecea16ade071');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240322081208_InstrcutorOtherDetails', N'8.0.3');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'1f0d7250-9135-4491-ad3b-e9256a0c72ad' AND [UserId] = N'bab647d0-ee25-4f51-9063-ecea16ade071';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'7298c143-63b6-4b78-84c6-ef6f1755095b' AND [UserId] = N'bab647d0-ee25-4f51-9063-ecea16ade071';
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserRole]
WHERE [RoleId] = N'f493ecc2-b7e7-4d2c-a8c9-345ab1ad1e54' AND [UserId] = N'bab647d0-ee25-4f51-9063-ecea16ade071';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'1f0d7250-9135-4491-ad3b-e9256a0c72ad';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'7298c143-63b6-4b78-84c6-ef6f1755095b';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Roles]
WHERE [Id] = N'f493ecc2-b7e7-4d2c-a8c9-345ab1ad1e54';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Users]
WHERE [Id] = N'bab647d0-ee25-4f51-9063-ecea16ade071';
SELECT @@ROWCOUNT;

GO

CREATE TABLE [TraineeTimelines] (
    [Id] int NOT NULL IDENTITY,
    [Order] int NULL,
    [Date] nvarchar(max) NOT NULL,
    [Stage] nvarchar(max) NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [Details] nvarchar(max) NULL,
    CONSTRAINT [PK_TraineeTimelines] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'1a2a72f4-3119-4f7f-a302-4303e2e271e5', N'1a2a72f4-3119-4f7f-a302-4303e2e271e5', N'Admin', N'ADMIN'),
(N'a9ea3935-c0a3-480f-9c1a-d1a8e836ca75', N'a9ea3935-c0a3-480f-9c1a-d1a8e836ca75', N'SuperAdmin', N'SUPERADMIN'),
(N'e93eaea3-8888-4794-89fa-683e4a79175e', N'e93eaea3-8888-4794-89fa-683e4a79175e', N'Trainee', N'TRAINEE');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'd0b78234-8e98-421c-be5f-a0e9f1347b49', 0, N'8991c6a1-f4e3-4fc5-8500-463ce033db31', N'rawal.bishnu@live.com', CAST(1 AS bit), CAST(0 AS bit), NULL, NULL, N'RAWAL.BISHNU@LIVE.COM', N'AQAAAAIAAYagAAAAEPDOhcFJaz9ww7B9rVhq2pqqmX5tPmZJ0AL87Wa/NOcuO3fv/H2NZZnbmCOXNrRr1g==', NULL, CAST(0 AS bit), N'942cb5bf-ec8b-4f05-b0cd-4abfc7b0571d', CAST(0 AS bit), N'rawal.bishnu@live.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

UPDATE [Widgets] SET [Created] = '2024-03-26T20:17:01.9789400-04:00'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-26T20:17:01.9789422-04:00'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-26T20:17:01.9789425-04:00'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-26T20:17:01.9789427-04:00'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-26T20:17:01.9789430-04:00'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-26T20:17:01.9789433-04:00'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [Widgets] SET [Created] = '2024-03-26T20:17:01.9789435-04:00'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] ON;
INSERT INTO [UserRole] ([RoleId], [UserId])
VALUES (N'1a2a72f4-3119-4f7f-a302-4303e2e271e5', N'd0b78234-8e98-421c-be5f-a0e9f1347b49'),
(N'a9ea3935-c0a3-480f-9c1a-d1a8e836ca75', N'd0b78234-8e98-421c-be5f-a0e9f1347b49'),
(N'e93eaea3-8888-4794-89fa-683e4a79175e', N'd0b78234-8e98-421c-be5f-a0e9f1347b49');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[UserRole]'))
    SET IDENTITY_INSERT [UserRole] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240326143203_TableTimeline', N'8.0.3');
GO

COMMIT;
GO

