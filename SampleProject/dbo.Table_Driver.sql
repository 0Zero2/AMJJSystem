CREATE TABLE [dbo].[Table_Delivery] (
    [DriverID]          BIGINT       NOT NULL,
    [ProductID]     BIGINT NULL,
    [Name of Deliver]     VARCHAR(50)   NULL,
    [Date of Received]     NCHAR (10)   NULL
	FOREIGN KEY (DriverID) REFERENCES [dbo].[Table_Driver](DriverID), 
	FOREIGN KEY (ProductID) REFERENCES [dbo].[Table_Product](ProductID),
    [Time of Received] NCHAR(10) NULL,
)

