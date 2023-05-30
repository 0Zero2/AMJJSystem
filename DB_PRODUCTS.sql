use DB_Products;

CREATE TABLE TBL_Products (
Item_ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
Name_of_Item varchar (255) NOT NULL,
Size int,
Weight int,
);

