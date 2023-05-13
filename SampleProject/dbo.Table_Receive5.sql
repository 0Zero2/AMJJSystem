CREATE TABLE [dbo].[Table_Received]
(
	[DriverID] BIGINT NOT NULL , 
    [Name of Deliver] VARCHAR(50) NULL, 
    [Date of Received] NCHAR(10) NULL, 
    [Time of Received] NCHAR(10) NULL, 
    [ProductID] BIGINT NULL
	FOREIGN KEY (ProductID) REFERENCES [dbo].[Table_Product] (ProductID),
	FOREIGN KEY (DriverID) REFERENCES [dbo].[Table_Driver] (DriverID),
)
