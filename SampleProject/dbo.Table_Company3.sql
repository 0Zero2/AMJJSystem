CREATE TABLE [dbo].[Table_Product]
(
	[ProductID] BIGINT NOT NULL PRIMARY KEY, 
    [DriverID] BIGINT NULL, 
    [Name of Product] VARCHAR(50) NULL, 
    [Quantity] NCHAR(10) NULL, 
    [Size] NCHAR(10) NULL, 
    [Weight] NCHAR(10) NULL
	FOREIGN KEY (DriverID) REFERENCES [dbo].[Table_Driver] (DriverID), 
	FOREIGN KEY (CompanyID) REFERENCES [dbo].[Table_Company] (CompanyID),
    [CompanyID] BIGINT NULL,
)
