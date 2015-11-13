CREATE TABLE [dbo].[PortfolioAssoc]
(
	[Portfolio] INT NOT NULL, 
    [Bond] INT NOT NULL, 
    [BondCoupon] INT NOT NULL, 
	[BondQuantity] INT NOT NULL,
    [Stock] INT NOT NULL, 
    [StockPriceHistory] INT NOT NULL, 
	[StockQuantity] INT NOT NULL
	CONSTRAINT FK_PortfolioAssoc_Portfolio FOREIGN KEY (Portfolio)
    REFERENCES [dbo].[Portfolio] ([Id]) 
    ON DELETE CASCADE
    ON UPDATE CASCADE, 
	CONSTRAINT FK_PortfolioAssoc_Bond FOREIGN KEY (Bond, BondCoupon)
    REFERENCES [dbo].[Bond] ([Id], [Coupon]) 
    ON DELETE CASCADE
    ON UPDATE CASCADE, 
    CONSTRAINT FK_PortfolioAssoc_Stock FOREIGN KEY (Stock, StockPriceHistory)
    REFERENCES [dbo].[Stock] ([Id], [PriceHistory]) 
    ON DELETE NO ACTION
    ON UPDATE NO ACTION, 
    PRIMARY KEY ([Portfolio], [Bond], [BondCoupon], [Stock], [StockPriceHistory])
)
