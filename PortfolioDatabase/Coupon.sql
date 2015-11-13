CREATE TABLE [dbo].[Coupon]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Value] MONEY NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [LastDate] DATETIME NOT NULL, 
    [Frequency] INT NOT NULL
)
