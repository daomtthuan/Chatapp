CREATE TABLE [dbo].[Admin]
(
	[Id]			INT				NOT NULL	IDENTITY(1, 1),
	[Username]		VARCHAR(100)	NOT NULL,
	[Password]		VARCHAR(72)		NOT NULL,
	[InformationId]	INT				NOT NULL,

	CONSTRAINT PrimaryKeyAdmin PRIMARY KEY ([Id]),
	CONSTRAINT UniqueAdmin UNIQUE ([Username]),
	CONSTRAINT ForeignKeyAdminInformation FOREIGN KEY ([InformationId]) REFERENCES [dbo].[Information] ([Id])
)
