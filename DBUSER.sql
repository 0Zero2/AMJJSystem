USE DBuser

CREATE TABLE TBL_Login(
User_ID int PRIMARY KEY,
Username varchar(255) NOT NULL,
Password varchar (255) NOT NULL)

ALTER TABLE TBL_Login
ADD UNIQUE (Username);

ALTER TABLE TBL_Login
ADD UNIQUE (Password);

CREATE TABLE TBL_Register(
Register_ID int,
First_Name varchar(255) NOT NULL,
Last_Name varchar (255) NOT NULL,
Phone_Number int,
Username varchar(255) NOT NULL,
Password varchar (255) NOT NULL)

ALTER TABLE TBL_Register
ADD UNIQUE (Username);

ALTER TABLE TBL_Register
ADD UNIQUE (Password);

ALTER TABLE TBL_Register
      ADD CONSTRAINT fk_TBL_Register_TBL_Login
      FOREIGN KEY (Register_ID) REFERENCES TBL_Login(User_ID)
