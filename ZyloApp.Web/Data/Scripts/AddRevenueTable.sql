ALTER TABLE [StudentAssignments] ADD [TurnInDate] datetime2 NULL;

CREATE TABLE [Revenues] (
          [Id] int NOT NULL IDENTITY,
          [Source] int NOT NULL,
          [Particulars] nvarchar(max) NOT NULL,
          [Amount] real NOT NULL,
          [Date] datetime2 NULL,
          [Created] datetime2 NULL,
          [CreatedBy] nvarchar(max) NULL,
          [LastUpdated] datetime2 NULL,
          [LastUpdatedBy] nvarchar(max) NULL,
          CONSTRAINT [PK_Revenues] PRIMARY KEY ([Id])
      );
