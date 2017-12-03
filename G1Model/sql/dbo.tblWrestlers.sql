CREATE TABLE [dbo].[tblWrestlers]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Wreslter_Name] NVARCHAR(MAX) NOT NULL, 
    [Wreslter_Points] INT NOT NULL, 
    [Wreslter_Block] CHAR(1) NOT NULL 
)
