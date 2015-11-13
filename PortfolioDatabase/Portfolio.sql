CREATE TABLE [dbo].[Portfolio]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Time] DATETIME NOT NULL, 
    [Bond] INT NOT NULL, 
    [BondQuantity] INT NOT NULL,
	[Stock] INT NOT NULL, 
    [StockQuantity] INT NOT NULL
	CONSTRAINT FK_Portfolio_Bond FOREIGN KEY (Bond)
    REFERENCES [dbo].[Bond] ([Id]) 
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
    CONSTRAINT FK_Portfolio_Stock FOREIGN KEY (Stock)
    REFERENCES [dbo].[Stock] ([Id]) 
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
)
