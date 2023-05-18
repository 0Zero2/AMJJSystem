use DB_Delivery

CREATE TABLE TBL_Delivery(
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
Remarks varchar (255))
