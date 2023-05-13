CREATE TABLE [dbo].[Table_2]
(
	[CompanyID] BIGINT NOT NULL PRIMARY KEY, 
    [Name of Company] VARCHAR(50) NULL, 
    [Name of Driver] NCHAR(10) NULL, 
    [DriverID] BIGINT NULL, 
    [DeliveryID] BIGINT NULL, 
    [Name of Deliver] VARCHAR(50) NULL
	FOREIGN KEY (DriverID) REFERENCES [dbo].[Table] (DriverID),
	FOREIGN KEY (DeliveryID) REFERENCES [dbo].[Table_1] (DeliveryID),
)
