DROP TABLE [SiteSections];

ALTER TABLE [Sections] ADD [Enabled] bit NOT NULL DEFAULT CAST(0 AS bit);

ALTER TABLE [Sections] ADD [Order] int NOT NULL DEFAULT 0;

ALTER TABLE [Sections] ADD [SiteId] nvarchar(450) NULL;

CREATE INDEX [IX_Sections_SiteId] ON [Sections] ([SiteId]);

ALTER TABLE [Sections] ADD CONSTRAINT [FK_Sections_Sites_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Sites] ([Id]);