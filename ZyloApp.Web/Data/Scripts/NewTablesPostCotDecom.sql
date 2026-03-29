-- Gathering
CREATE TABLE [dbo].[Gatherings] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [Title]            NVARCHAR (MAX)   NOT NULL,
    [Agenda]           NVARCHAR (MAX)   NOT NULL,
    [Quote]            REAL             NOT NULL,
    [QuotePerAttendee] BIT              NOT NULL,
    [MaxAttendees]     INT              NOT NULL,
    [Type]             INT              NOT NULL,
    [Created]          DATETIME2 (7)    NULL,
    [CreatedBy]        NVARCHAR (MAX)   NULL,
    [LastUpdated]      DATETIME2 (7)    NULL,
    [LastUpdatedBy]    NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_Gatherings] PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Gathering requests
CREATE TABLE [dbo].[GatheringRequests] (
    [Id]             INT              IDENTITY (1, 1) NOT NULL,
    [UserName]       NVARCHAR (MAX)   NOT NULL,
    [Phone]          NVARCHAR (MAX)   NOT NULL,
    [When]           DATETIME2 (7)    NOT NULL,
    [RequestedDate]  DATETIME2 (7)    NOT NULL,
    [GatheringId]    UNIQUEIDENTIFIER NOT NULL,
    [OrganizationId] INT              NOT NULL,
    CONSTRAINT [PK_GatheringRequests] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_GatheringRequests_Gatherings_GatheringId] FOREIGN KEY ([GatheringId]) REFERENCES [dbo].[Gatherings] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_GatheringRequests_Organizations_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organizations] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_GatheringRequests_GatheringId]
    ON [dbo].[GatheringRequests]([GatheringId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_GatheringRequests_OrganizationId]
    ON [dbo].[GatheringRequests]([OrganizationId] ASC);

-- Gathering Calendars
CREATE TABLE [dbo].[GatheringCalendars] (
    [Id]                  INT              IDENTITY (1, 1) NOT NULL,
    [StartDate]           DATETIME2 (7)    NOT NULL,
    [EndDate]             DATETIME2 (7)    NOT NULL,
    [DurationHoursPerDay] INT              NOT NULL,
    [Status]              INT              NOT NULL,
    [RequestedDate]       DATETIME2 (7)    NOT NULL,
    [RequestedBy]         NVARCHAR (MAX)   NOT NULL,
    [GatheringId]         UNIQUEIDENTIFIER NOT NULL,
    [OrganizationId]      INT              NOT NULL,
    CONSTRAINT [PK_GatheringCalendars] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_GatheringCalendars_Organizations_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organizations] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_GatheringCalendars_Gatherings_GatheringId] FOREIGN KEY ([GatheringId]) REFERENCES [dbo].[Gatherings] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_GatheringCalendars_OrganizationId]
    ON [dbo].[GatheringCalendars]([OrganizationId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_GatheringCalendars_GatheringId]
    ON [dbo].[GatheringCalendars]([GatheringId] ASC);

-- Gathering Calendars and Instructors
CREATE TABLE [dbo].[GatheringCalendarInstructor] (
    [ConsultantsId]       INT NOT NULL,
    [GatheringCalendarId] INT NOT NULL,
    CONSTRAINT [PK_GatheringCalendarInstructor] PRIMARY KEY CLUSTERED ([ConsultantsId] ASC, [GatheringCalendarId] ASC),
    CONSTRAINT [FK_GatheringCalendarInstructor_GatheringCalendars_GatheringCalendarId] FOREIGN KEY ([GatheringCalendarId]) REFERENCES [dbo].[GatheringCalendars] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_GatheringCalendarInstructor_Instructors_ConsultantsId] FOREIGN KEY ([ConsultantsId]) REFERENCES [dbo].[Instructors] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_GatheringCalendarInstructor_GatheringCalendarId]
    ON [dbo].[GatheringCalendarInstructor]([GatheringCalendarId] ASC);


-- Attendees
CREATE TABLE [dbo].[Attendee] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [FullName]         NVARCHAR (MAX)   NOT NULL,
    [Phone]            NVARCHAR (MAX)   NOT NULL,
    [Email]            NVARCHAR (MAX)   NOT NULL,
    [ProfileImagePath] NVARCHAR (MAX)   NULL,
    [OrganizationId]   INT              NULL,
    CONSTRAINT [PK_Attendee] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Attendee_Organizations_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organizations] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Attendee_OrganizationId]
    ON [dbo].[Attendee]([OrganizationId] ASC);


-- Certificates

CREATE TABLE [dbo].[Certificates] (
    [Id]                  UNIQUEIDENTIFIER NOT NULL,
    [Title]               NVARCHAR (MAX)   NOT NULL,
    [Description]         NVARCHAR (MAX)   NOT NULL,
    [Signataire1]         NVARCHAR (MAX)   NOT NULL,
    [Signataire1SignPath] NVARCHAR (MAX)   NOT NULL,
    [Signataire2]         NVARCHAR (MAX)   NOT NULL,
    [Signataire2SignPath] NVARCHAR (MAX)   NOT NULL,
    [AttendeeId]          UNIQUEIDENTIFIER NOT NULL,
    [EventDate]           NVARCHAR (MAX)   DEFAULT (N'') NOT NULL,
    [IssueDate]           DATETIME2 (7)    DEFAULT ('0001-01-01T00:00:00.0000000') NOT NULL,
    CONSTRAINT [PK_Certificates] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Certificates_Attendee_AttendeeId] FOREIGN KEY ([AttendeeId]) REFERENCES [dbo].[Attendee] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Certificates_AttendeeId]
    ON [dbo].[Certificates]([AttendeeId] ASC);

