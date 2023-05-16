use Delivery_System;

CREATE TABLE TBL_Company(Company_ID int PRIMARY KEY,
Name_of_Company varchar(255) NOT NULL,
Company_Information varchar(255) NOT NULL,
Driver_ID int,
Contact_ID int);

ALTER TABLE TBL_Company
DROP COLUMN Name_of_Company;

ALTER TABLE TBL_Company
ADD Company_Name varchar (255) NOT NULL PRIMARY KEY;

ALTER TABLE TBL_Company
      ADD CONSTRAINT fk_TBL_Companny_TBL_Users
      FOREIGN KEY (Username) REFERENCES TBL_Users(Username)

ALTER TABLE TBL_Company DROP fk_TBL_Companny_TBL_Users;

CREATE TABLE TBL_Driver(Driver_ID int PRIMARY KEY, 
First_Name varchar(255) NOT NULL, 
Last_Name varchar(255) NOT NULL,
Contact_ID int);

ALTER TABLE TBL_Driver
ADD Driver_Information varchar(255) NOT NULL;

ALTER TABLE TBL_Driver
DROP COLUMN Driver_Information;


CREATE TABLE TBL_Contact(Contact_ID int PRIMARY KEY,
Cellphone_Number int,
Driver_ID int,
Company_ID int);

ALTER TABLE TBL_Contact
      ADD CONSTRAINT fk_TBL_Contact_TBL_Driver
      FOREIGN KEY (Driver_ID) REFERENCES TBL_Driver(Driver_ID)

ALTER TABLE TBL_Delivery
      ADD CONSTRAINT fk_TBL_Delivery_TBL_Vehicle
      FOREIGN KEY (Plate_Number) REFERENCES TBL_Vehicle(Plate_Number)


ALTER TABLE TBL_Company
      ADD CONSTRAINT fk_TBL_Company_TBL_Driver
      FOREIGN KEY (Driver_ID) REFERENCES TBL_Driver(Driver_ID)

ALTER TABLE TBL_Contact
      ADD CONSTRAINT fk_TBL_Contact_TBL_Company
      FOREIGN KEY (Company_ID) REFERENCES TBL_Company(Company_ID)

ALTER TABLE TBL_Contact DROP fk_TBL_Contact_TBL_Company;


CREATE TABLE TBL_Vehicle(Vehicle_ID int,
Vehicle_Information varchar (255)NOT NULL,
Plate_Number int PRIMARY KEY);

ALTER TABLE TBL_Vehicle
DROP PK_Vehicle_ID;

CREATE TABLE TBL_Item(Item_ID int PRIMARY KEY,
Name_of_Item varchar(255)NOT NULL,
Quantity int,
Size int,
Weight int,
Driver_ID int,
Company_ID int);

ALTER TABLE TBL_Item
      ADD CONSTRAINT fk_TBL_Item_TBL_Driver
      FOREIGN KEY (Driver_ID) REFERENCES TBL_Driver(Driver_ID)

ALTER TABLE TBL_Item
      ADD CONSTRAINT fk_TBL_Item_TBL_Company
      FOREIGN KEY (Company_ID) REFERENCES TBL_Company(Company_ID)

ALTER TABLE TBL_Item DROP fk_TBL_Item_TBL_Company;



CREATE TABLE TBL_Delivery (Deliver_ID int PRIMARY KEY,
Name_of_Delivery varchar(255)NOT NULL,
Date_of_Delivered datetime,
Time_of_Delivered datetime,
Remarks_Note varchar(255)NOT NULL,
Driver_ID int,
Company_ID int);

ALTER TABLE TBL_Delivery
      ADD CONSTRAINT fk_TBL_Delivery_TBL_Driver
      FOREIGN KEY (Driver_ID) REFERENCES TBL_Driver(Driver_ID)

ALTER TABLE TBL_Delivery DROP fk_TBL_Delivery_TBL_Driver;

ALTER TABLE TBL_Delivery
      ADD CONSTRAINT fk_TBL_Delivery_TBL_Company
      FOREIGN KEY (Company_ID) REFERENCES TBL_Company(Company_ID)

ALTER TABLE TBL_Delivery DROP fk_TBL_Delivery_TBL_Company;

ALTER TABLE TBL_Delivery
ADD Plate_Number int;

CREATE TABLE TBL_Pickup(Pickup_ID int PRIMARY KEY,
Name_of_Pickup varchar (255)NOT NULL,
Date_of_Pickup datetime,
Time_of_Pickup datetime,
Remarks_Note varchar (255)NOT NULL,
Driver_ID int,
Company_ID int);

ALTER TABLE TBL_Pickup
      ADD CONSTRAINT fk_TBL_Pickup_TBL_Driver
      FOREIGN KEY (Driver_ID) REFERENCES TBL_Driver(Driver_ID)

ALTER TABLE TBL_Pickup
      ADD CONSTRAINT fk_TBL_Pickup_TBL_Company
      FOREIGN KEY (Company_ID) REFERENCES TBL_Company(Company_ID)

ALTER TABLE TBL_Pickup DROP fk_TBL_Pickup_TBL_Company;

ALTER TABLE TBL_Pickup
ADD Delivery_Address varchar(255) NOT NULL, Contact_Person varchar (255) NOT NULL;

ALTER TABLE TBL_Pickup
      ADD CONSTRAINT fk_TBL_Pickup_TBL_Vehicle
      FOREIGN KEY (Plate_Number) REFERENCES TBL_Vehicle(Plate_Number)

ALTER TABLE TBL_Pickup
ADD Plate_Number int;

CREATE TABLE TBL_Receive(Receive_ID int PRIMARY KEY,
Name_of_Receiver varchar (255)NOT NULL,
Date_of_Receiver datetime,
Time_of_Receiver datetime,
Remarks_Note varchar (255)NOT NULL,
Driver_ID int,
Company_ID int);

ALTER TABLE TBL_Receive
      ADD CONSTRAINT fk_TBL_Receive_TBL_Driver
      FOREIGN KEY (Driver_ID) REFERENCES TBL_Driver(Driver_ID)

ALTER TABLE TBL_Receive
      ADD CONSTRAINT fk_TBL_Receive_TBL_Company
      FOREIGN KEY (Company_ID) REFERENCES TBL_Company(Company_ID)

ALTER TABLE TBL_Receive DROP fk_TBL_Receive_TBL_Company;

ALTER TABLE TBL_Receive
ADD Delivery_Address varchar(255) NOT NULL, Contact_Person varchar (255) NOT NULL;

ALTER TABLE TBL_Receive
ADD Plate_Number int;

ALTER TABLE TBL_Receive
      ADD CONSTRAINT fk_TBL_Receive_TBL_Vehicle
      FOREIGN KEY (Plate_Number) REFERENCES TBL_Vehicle(Plate_Number)


ALTER TABLE TBL_Employees
      ADD CONSTRAINT fk_TBL_Employees_TBL_Driver
      FOREIGN KEY (Driver_ID) REFERENCES TBL_Driver(Driver_ID)

ALTER TABLE TBL_Contact
ADD Company_Name varchar(255) NOT NULL;

ALTER TABLE TBL_Delivery
      ADD CONSTRAINT fk_TBL_Delivery_TBL_Company
      FOREIGN KEY (Company_Name) REFERENCES TBL_Company(Company_Name)


