CREATE TABLE [dbo].[tblMatchesWrestlers]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Match] INT NULL, 
    [Wrestler] INT NULL, 
    CONSTRAINT [FK_tblMatchesWrestlers_ToTableMatches] FOREIGN KEY ([Match]) REFERENCES [tblMatches]([Id]), 
    CONSTRAINT [FK_tblMatchesWrestlers_ToTableWrestlers] FOREIGN KEY ([Wrestler]) REFERENCES [tblWrestlers]([Id])
)
