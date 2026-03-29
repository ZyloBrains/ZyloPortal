CREATE TABLE [dbo].[Loans] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Borrower]       NVARCHAR (MAX) NOT NULL,
    [Lender]         NVARCHAR (MAX) NOT NULL,
    [Principal]      REAL           NOT NULL,
    [RepaymentDate]  DATETIME2 (7)  NULL,
    [Created]        DATETIME2 (7)  NULL,
    [CreatedBy]      NVARCHAR (MAX) NULL,
    [LastUpdated]    DATETIME2 (7)  NULL,
    [LastUpdatedBy]  NVARCHAR (MAX) NULL,
    [IssueDate]      DATETIME2 (7)  NULL,
    [InterestRate]   REAL           NOT NULL,
    [CompanyLending] BIT            NOT NULL
);
