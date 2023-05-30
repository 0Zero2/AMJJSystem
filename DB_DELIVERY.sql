CREATE DATABASE DB_DeliveryPickup;
use DB_DeliveryPickup

CREATE TABLE TBL_Delivery (
Delivery_ID int NOT NULL PRIMARY KEY,
Name_of_Driver varchar (255) NOT NULL,
Plate_Number int,
Address varchar (255) NOT NULL,
Phone_Number_of_Driver int,
Name_of_Client_Company varchar (255) NOT NULL,
Name_of_Client varchar (255) NOT NULL,
Phone_Number_of_Client int,
Date_and_Time datetime,
Name_of_Item varchar (255) NOT NULL,
Quantity int,
Size float,
Weight float,
Remarks varchar (255),
Status varchar (255))
