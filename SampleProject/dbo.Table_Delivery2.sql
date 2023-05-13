CREATE TABLE [dbo].[Table_Company] (
    [CompanyID]       BIGINT       NOT NULL,
    [Name of Company] VARCHAR (50) NULL,
    [DriverID]        BIGINT       NULL,
    [Name of Driver]      VARCHAR(50)       NULL,
	FOREIGN KEY (DriverID) REFERENCES [dbo].[Table](DriverID),
    PRIMARY KEY CLUSTERED ([CompanyID] ASC)
);

