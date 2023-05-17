USE DBuser

CREATE TABLE TBL_Register(
User_ID int PRIMARY KEY,
First_Name varchar(255) NOT NULL,
Last_Name varchar (255) NOT NULL,
Phone_Number int,
Username varchar(255) NOT NULL,
Password varchar (255) NOT NULL)

ALTER TABLE TBL_Register
ADD UNIQUE (Username);

ALTER TABLE TBL_Register
ADD UNIQUE (Password);


