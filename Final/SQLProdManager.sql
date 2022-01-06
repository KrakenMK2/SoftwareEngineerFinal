USE master
GO
IF not exists(
	select name from sys.databases
	where name = 'ProdManager'
)

create database [ProdManager]
go
use [ProdManager]


CREATE TABLE Customers
(
	CustomerID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CustomerName varchar(50) NOT NULL,
	email varchar(50) not null,
	passwords varchar(50) not null
);

create table Orders(
	OrderID INT identity(1,1) PRIMARY KEY,
	CustomerID int not null,
	OrderStatus varchar(50) not null,
	Payment varchar(50) not null,
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
)

create table Products(
	ProductID int identity(1,1) primary key,
	ProductName varchar(50) not null,
	Price int not null,
	LastStocked date not null
)

create table OrderDetails(
	ID int identity(1,1) primary key,
	OrderID int not null,
	ProductID int not null,
	Quantity int not null,
	FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
)


insert into Customers(CustomerName,email,passwords) values('Jack','jck@mail','jacko');
insert into Customers(CustomerName,email,passwords) values('Sonia','soni@mail','sonarica');
insert into Customers(CustomerName,email,passwords) values('Jane','jan@mail','janebon');
insert into Customers(CustomerName,email,passwords) values('John','josh@mail','johmsmith');

insert into Products(ProductName,Price,LastStocked) values('TV',300,'2000-10-4');
insert into Products(ProductName,Price,LastStocked) values('Laptop',500,'2000-10-4');
insert into Products(ProductName,Price,LastStocked) values('Phone',100,'2000-10-4');
insert into Products(ProductName,Price,LastStocked) values('Refrigirator',250,'2000-10-4');
insert into Products(ProductName,Price,LastStocked) values('Fan',30,'2000-10-4');
insert into Products(ProductName,Price,LastStocked) values('AC',400,'2000-10-4');
insert into Products(ProductName,Price,LastStocked) values('Lights',15,'2000-10-4');
insert into Products(ProductName,Price,LastStocked) values('Washing Machine',150,'2000-10-4');
insert into Products(ProductName,Price,LastStocked) values('Watch',45,'2000-10-4');
insert into Products(ProductName,Price,LastStocked) values('Calculator',5,'2000-10-4');


