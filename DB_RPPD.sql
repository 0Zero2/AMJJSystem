CREATE DATABASE DB_RPPD;

USE DB_RPPD;

CREATE TABLE TBL_Receive(
Receive_From varchar(255) NOT NULL,
Received_By varchar(255) NOT NULL,
Plate_Number varchar(50) NOT NULL, 
Name_of_Client varchar(255) NOT NULL,
Phone_Number int NOT NULL,
Date_and_Time datetime NOT NULL,
Item_Name varchar(255) NOT NULL,
Quantity int NOT NULL,
Size float NOT NULL, 
Weight float NOT NULL, 
Remarks varchar (255) NOT NULL
);

CREATE TABLE TBL_Products(
Item_ID varchar(50) NOT NULL,
Item_Name varchar(255) NOT NULL,
Size float NOT NULL,
Weight float NOT NULL
);

CREATE TABLE TBL_Pickup(
Driver_Name varchar(200) NOT NULL,
Plate_Number varchar(50) NOT NULL, 
Address varchar(255) NOT NULL,
Contact_Number_of_Driver int NOT NULL,
Client_Name varchar(200) NOT NULL,
Contact_Number_of_Client int NOT NULL, 
Date_and_Time datetime NOT NULL,
Item_Name varchar(255) NOT NULL,
Quantity int NOT NULL,
Size float NOT NULL,
Weight float NOT NULL,
Remarks varchar(255) NOT NULL
);

CREATE TABLE TBL_Deliver(
Driver_Name varchar(200) NOT NULL,
Plate_Number varchar(50) NOT NULL, 
Address varchar(255) NOT NULL,
Contact_Number_of_Driver int NOT NULL,
Client_Name varchar(200) NOT NULL,
Contact_Number_of_Client int NOT NULL, 
Date_and_Time datetime NOT NULL,
Item_Name varchar(255) NOT NULL,
Quantity int NOT NULL,
Size float NOT NULL,
Weight float NOT NULL,
Remarks varchar(255) NOT NULL
);