use DB_ClientCompany;

CREATE TABLE TBL_ClientCompany(
Company_Id int IDENTITY (1,1) PRIMARY KEY NOT NULL,
Name_of_Company varchar(255) NOT NULL,
Company_Number int,
Contact_Person varchar (255) NOT NULL,
Phone_Number int,
Driver varchar (255) NOT NULL,
Contact_Number int,
Plate_Number int
);
