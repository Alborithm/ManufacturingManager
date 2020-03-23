CREATE TABLE [dbo].[Disponibility]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Operation] INT NOT NULL, 
    [Disponible] BIT NOT NULL, 
    [TimeUpdated] DATETIME2 NULL DEFAULT getutcdate()
	FOREIGN KEY (Operation) REFERENCES OPERATION(Id)
)
