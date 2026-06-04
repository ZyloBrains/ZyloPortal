BEGIN TRANSACTION;
EXEC sp_rename N'[Projects].[SpentBudget]', N'AmcCost', 'COLUMN';

EXEC sp_rename N'[Projects].[AllocatedBudget]', N'InitialCost', 'COLUMN';

ALTER TABLE [Revenues] ADD [IsActive] bit NOT NULL DEFAULT CAST(0 AS bit);

ALTER TABLE [Revenues] ADD [ProjectId] int NULL;

CREATE INDEX [IX_Revenues_ProjectId] ON [Revenues] ([ProjectId]);

ALTER TABLE [Revenues] ADD CONSTRAINT [FK_Revenues_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([Id]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260531082355_RevenueAndProjectChanges', N'10.0.1');

COMMIT;
GO

BEGIN TRANSACTION;
CREATE TABLE [Quotations] (
    [Id] int NOT NULL IDENTITY,
    [QuoteNumber] nvarchar(max) NOT NULL,
    [ClientName] nvarchar(max) NOT NULL,
    [ClientAddress] nvarchar(max) NULL,
    [ClientEmail] nvarchar(max) NULL,
    [ClientPhone] nvarchar(max) NULL,
    [ProjectName] nvarchar(max) NOT NULL,
    [Currency] nvarchar(max) NOT NULL,
    [QuoteDate] datetime2 NOT NULL,
    [ValidUntil] datetime2 NULL,
    [PaymentTerms] nvarchar(max) NULL,
    [Notes] nvarchar(max) NULL,
    [DiscountPercent] real NULL,
    [TaxPercent] real NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Quotations] PRIMARY KEY ([Id])
);

CREATE TABLE [QuotationItems] (
    [Id] int NOT NULL IDENTITY,
    [QuotationId] int NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [Category] nvarchar(max) NULL,
    [Quantity] int NOT NULL,
    [UnitPrice] real NOT NULL,
    [SortOrder] int NOT NULL,
    CONSTRAINT [PK_QuotationItems] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_QuotationItems_Quotations_QuotationId] FOREIGN KEY ([QuotationId]) REFERENCES [Quotations] ([Id]) ON DELETE CASCADE
);

CREATE INDEX [IX_QuotationItems_QuotationId] ON [QuotationItems] ([QuotationId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260601042843_AddQuotation', N'10.0.1');

COMMIT;
GO

