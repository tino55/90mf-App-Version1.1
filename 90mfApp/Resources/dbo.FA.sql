CREATE TABLE [dbo].[FA] (
    [Id]        INT        NOT NULL IDENTITY,
    [Name]      NCHAR (10) NULL,
    [Min Rep]   NCHAR (10) NULL,
    [Max Rep]   NCHAR (10) NULL,
    [Min Prize] NCHAR (10) NULL,
    [Max Prize] NCHAR (10) NULL,
    [Members]   NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

