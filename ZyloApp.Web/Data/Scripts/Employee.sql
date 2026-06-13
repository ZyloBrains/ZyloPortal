BEGIN TRANSACTION;
CREATE TABLE [Employees] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Phone] nvarchar(max) NULL,
    [Designation] nvarchar(max) NULL,
    [Department] nvarchar(max) NULL,
    [ProfilePath] nvarchar(max) NULL,
    [Publish] bit NOT NULL,
    [MonthlyBasic] decimal(18,2) NULL,
    [Currency] nvarchar(max) NULL,
    [BankAccountDetails] nvarchar(max) NULL,
    [OtherDetails] nvarchar(max) NULL,
    [ReportsToId] int NULL,
    [ApplicationUserId] nvarchar(450) NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Employees_Employees_ReportsToId] FOREIGN KEY ([ReportsToId]) REFERENCES [Employees] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Employees_Users_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [Users] ([Id])
);

CREATE INDEX [IX_Employees_ApplicationUserId] ON [Employees] ([ApplicationUserId]);

CREATE INDEX [IX_Employees_ReportsToId] ON [Employees] ([ReportsToId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260612064837_EmployeeDetails', N'10.0.1');

COMMIT;
GO

BEGIN TRANSACTION;
ALTER TABLE [Users] ADD [Address] nvarchar(max) NULL;

ALTER TABLE [Users] ADD [Country] nvarchar(max) NULL;

ALTER TABLE [Users] ADD [Dob] datetime2 NULL;

ALTER TABLE [Users] ADD [FullName] nvarchar(max) NULL;

ALTER TABLE [Users] ADD [Gender] int NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260612090028_AppUserDetails', N'10.0.1');

COMMIT;
GO

