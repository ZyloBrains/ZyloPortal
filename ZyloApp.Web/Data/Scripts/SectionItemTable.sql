BEGIN TRANSACTION;
DROP TABLE [SectionWidgets];

CREATE TABLE [SectionItems] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Content] nvarchar(max) NOT NULL,
    [Order] int NOT NULL,
    [Enabled] bit NOT NULL,
    [SectionId] int NOT NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_SectionItems] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SectionItems_Sections_SectionId] FOREIGN KEY ([SectionId]) REFERENCES [Sections] ([Id]) ON DELETE CASCADE
);

CREATE INDEX [IX_SectionItems_SectionId] ON [SectionItems] ([SectionId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260207182304_AddSectionItemTable', N'10.0.1');

COMMIT;
GO

