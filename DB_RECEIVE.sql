CREATE DATABASE DB_Receive;
USE DB_Receive;

CREATE TABLE TBL_Receive(
Receive_From varchar (255) NOT NULL,
Received_By varchar (255) NOT NULL,
Plate_Number int,
Name_of_Client_Company varchar (255) NOT NULL,
Phone_Number_of_Client int,
Date_and_Time datetime,
Name_of_Item varchar (255) NOT NULL,
Quantity int,
Size float,
Weight float,
Remarks varchar (255))