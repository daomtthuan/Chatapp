CREATE TABLE [dbo].[User] (
  [Id]            INT           NOT NULL  IDENTITY(1, 1),
  [Username]      VARCHAR(100)  NOT NULL,
  [Password]      VARCHAR(72)   NOT NULL,
  [InformationId] INT           NOT NULL,

  CONSTRAINT PrimaryKeyUser             PRIMARY KEY ([Id]),
  CONSTRAINT UniqueUser                 UNIQUE      ([Username]),
  CONSTRAINT ForeignKeyUserInformation  FOREIGN KEY ([InformationId]) REFERENCES [dbo].[Information] ([Id])
)
