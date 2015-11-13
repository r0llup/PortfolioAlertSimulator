CREATE TABLE [dbo].[Bond]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PriceHistory] INT NOT NULL, 
    [Coupon] INT NOT NULL
	CONSTRAINT FK_Bond_PriceHistory FOREIGN KEY (PriceHistory)
    REFERENCES [dbo].[PriceHistory] ([Id]) 
    ON DELETE CASCADE
    ON UPDATE CASCADE,
	CONSTRAINT FK_Bond_Coupon FOREIGN KEY (Coupon)
    REFERENCES [dbo].[Coupon] ([Id]) 
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
