BEGIN TRANSACTION;
CREATE TABLE [Invoices] (
    [Id] int NOT NULL IDENTITY,
    [InvoiceNumber] nvarchar(max) NOT NULL,
    [ClientName] nvarchar(max) NOT NULL,
    [ClientAddress] nvarchar(max) NULL,
    [ClientEmail] nvarchar(max) NULL,
    [ClientPhone] nvarchar(max) NULL,
    [CompanyName] nvarchar(max) NOT NULL,
    [CompanyAddress] nvarchar(max) NULL,
    [CompanyPhone] nvarchar(max) NULL,
    [CompanyEmail] nvarchar(max) NULL,
    [CompanyPan] nvarchar(max) NULL,
    [BankName] nvarchar(max) NULL,
    [BankAccountNumber] nvarchar(max) NULL,
    [BankAccountHolder] nvarchar(max) NULL,
    [Currency] nvarchar(max) NOT NULL,
    [InvoiceDate] datetime2 NOT NULL,
    [DueDate] datetime2 NULL,
    [DiscountPercent] real NULL,
    [TaxPercent] real NULL,
    [PaymentStatus] nvarchar(max) NOT NULL,
    [PaymentTerms] nvarchar(max) NULL,
    [Notes] nvarchar(max) NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Invoices] PRIMARY KEY ([Id])
);

CREATE TABLE [InvoiceItems] (
    [Id] int NOT NULL IDENTITY,
    [InvoiceId] int NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [Category] nvarchar(max) NULL,
    [Quantity] int NOT NULL,
    [UnitPrice] real NOT NULL,
    [SortOrder] int NOT NULL,
    CONSTRAINT [PK_InvoiceItems] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_InvoiceItems_Invoices_InvoiceId] FOREIGN KEY ([InvoiceId]) REFERENCES [Invoices] ([Id]) ON DELETE CASCADE
);

CREATE INDEX [IX_InvoiceItems_InvoiceId] ON [InvoiceItems] ([InvoiceId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260605075350_AddInvoice', N'10.0.1');

COMMIT;
GO
