CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(6, 2) , 
    [EmployeeId] INT NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastNAme] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL
)
