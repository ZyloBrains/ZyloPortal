CREATE TABLE [Sections] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Content] nvarchar(max) NULL,
    CONSTRAINT [PK_Sections] PRIMARY KEY ([Id])
);

CREATE TABLE [Sites] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Domain] nvarchar(max) NULL,
    [Client] nvarchar(max) NULL,
    [Content] nvarchar(max) NULL,
    [Created] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [LastUpdated] datetime2 NULL,
    [LastUpdatedBy] nvarchar(max) NULL,
    CONSTRAINT [PK_Sites] PRIMARY KEY ([Id])
);

CREATE TABLE [SectionWidgets] (
    [SectionId] int NOT NULL,
    [WidgetId] int NOT NULL,
    [Order] int NOT NULL,
    [Enabled] bit NOT NULL,
    CONSTRAINT [PK_SectionWidgets] PRIMARY KEY ([SectionId], [WidgetId]),
    CONSTRAINT [FK_SectionWidgets_Sections_SectionId] FOREIGN KEY ([SectionId]) REFERENCES [Sections] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SectionWidgets_Widgets_WidgetId] FOREIGN KEY ([WidgetId]) REFERENCES [Widgets] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [SiteSections] (
    [SiteId] nvarchar(450) NOT NULL,
    [SectionId] int NOT NULL,
    [Order] int NOT NULL,
    [Enabled] bit NOT NULL,
    CONSTRAINT [PK_SiteSections] PRIMARY KEY ([SectionId], [SiteId]),
    CONSTRAINT [FK_SiteSections_Sections_SectionId] FOREIGN KEY ([SectionId]) REFERENCES [Sections] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSections_Sites_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Sites] ([Id]) ON DELETE CASCADE
);

CREATE INDEX [IX_SectionWidgets_WidgetId] ON [SectionWidgets] ([WidgetId]);

CREATE INDEX [IX_SiteSections_SiteId] ON [SiteSections] ([SiteId]);