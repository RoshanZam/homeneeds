create database HOMENEEDS

create table tblCustomers 
(Customer_ID int identity(1,1) primary key,
Name varchar(20),
Password varchar(12),
Address varchar(100),
Phone_Number varchar(10),
Location_ID int references tblLocations(Location_ID)
)

create table tblAdmin
(Admin_ID int identity(1,1) primary key,
Name varchar(20),
Password varchar(12)
)

create table tblLocations
(Location_ID int identity(1,1) primary key,
Name varchar(20),
Pincode varchar(10),
Availablity int,
)

create table tblProducts 
(Product_ID int identity(1,1) primary key,
Name varchar(20),
Description varchar(10),
Quantity int,
Category_ID int references tblCategories(Category_ID)
)

create table tblCategories
(Category_ID int identity(1,1) primary key,
Name varchar(20)
)

create table orders(
Order_ID int identity(1,1) primary key,
Product_ID int references tblProducts(Product_ID),
Customer_ID int references tblCustomers(Customer_ID),
Purchased datetime,
Delivery_Date datetime
)


