CREATE TABLE [dbo].[Information] (
  [Id]        INT           NOT NULL  IDENTITY(1, 1),
  [FullName]  NVARCHAR(100) NOT NULL,
  [Gender]    BIT           NOT NULL,
  [Birthday]  DATE          NOT NULL,
  [Email]     VARCHAR(100)  NOT NULL,
  [Phone]     VARCHAR(15)   NOT NULL,
  [Address]    NVARCHAR(500) NOT NULL,

  CONSTRAINT PrimaryKeyInformation  PRIMARY KEY ([Id])
)
