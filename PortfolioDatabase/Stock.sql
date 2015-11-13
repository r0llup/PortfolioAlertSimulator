CREATE TABLE [dbo].[Stock]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PriceHistory] INT NOT NULL
	CONSTRAINT FK_Stock_PriceHistory FOREIGN KEY (PriceHistory)
    REFERENCES [dbo].[PriceHistory] ([Id]) 
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
