CREATE TABLE [dbo].[Operation]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Number] INT NOT NULL, 
    [Line] INT NOT NULL
)
