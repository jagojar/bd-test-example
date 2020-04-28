CREATE TABLE [dbo].[RegressionTable] (
    [Id]    INT           NOT NULL,
    [Name]  NVARCHAR (50) NOT NULL,
    [Value] FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_RegressionTable] PRIMARY KEY CLUSTERED ([Id] ASC)
);

