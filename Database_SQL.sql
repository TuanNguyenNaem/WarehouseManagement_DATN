

CREATE DATABASE Warehouse_Management
GO
USE Warehouse_Management
GO

CREATE TABLE Account
(
	AccountID int PRIMARY KEY IDENTITY,
	UserName varchar(20) UNIQUE NOT NULL,
	[Password] varchar(15) NOT NULL,
	[Role] nvarchar(30) NOT NULL
)

CREATE TABLE Employee
(
	EmployeeID int PRIMARY KEY,
	EmployeeName nvarchar(50) NOT NULL,
	BirthDate date NOT NULL,
	[Address] nvarchar(100) NOT NULL,
	HireDate date NOT NULL,
	PhoneNumber varchar(11),
	Gender nvarchar(5),
	[Status] nvarchar(15) NOT NULL,
	Notes nvarchar(100)
)
ALTER TABLE Employee ADD CONSTRAINT fk_e_a FOREIGN KEY(EmployeeID) REFERENCES Account(AccountID)


CREATE TABLE VIP
(
	VIPID int PRIMARY KEY IDENTITY,
	VIPName varchar(5) UNIQUE NOT NULL,
	Accumulation money NOT NULL,
	ReduceInvoice tinyint NOT NULL,
	Unit varchar(6) NOT NULL
)

CREATE TABLE Customer
(
	CustomerID int PRIMARY KEY,
	CustomerName nvarchar(50) NOT NULL,
	BirthDate date,
	Gender nvarchar(5),
	[Address] nvarchar(100) NOT NULL,
	PhoneNumber varchar(11) NOT NULL,
	AccountNumber varchar(40) NOT NULL,
	TaxCode varchar(20) NOT NULL,
	Accumulation money NOT NULL,
	VIPID int NOT NULL,
	Area nvarchar(100) NOT NULL,
	Email varchar(50),
	Notes nvarchar(100)
)
ALTER TABLE Customer ADD CONSTRAINT fk_c_v FOREIGN KEY(VIPID) REFERENCES VIP(VIPID)

CREATE TABLE Supplier
(
	SupplierID int PRIMARY KEY IDENTITY,
	SupplierName nvarchar(100) NOT NULL,
	[Address] nvarchar(100) NOT NULL,
	PhoneNumber varchar(11) NOT NULL,
	AccountNumber varchar(40) NOT NULL,
	TaxCode varchar(20) NOT NULL,
	Area nvarchar(100) NOT NULL,
	Email varchar(50),
	Notes nvarchar(100)
)

CREATE TABLE [Order]
(
	OrderID int PRIMARY KEY IDENTITY,
	EmployeeID int NOT NULL,
	CustomerID int NOT NULL,
	CreateDate date NOT NULL,
	DeliveryDate date NOT NULL,
	[Status] nvarchar(15) NOT NULL,
	Notes nvarchar(100)
)
ALTER TABLE [Order] ADD CONSTRAINT fk_o_e FOREIGN KEY(EmployeeID) REFERENCES Employee(EmployeeID)
ALTER TABLE [Order] ADD CONSTRAINT fk_o_c FOREIGN KEY(CustomerID) REFERENCES Customer(CustomerID)

CREATE TABLE Category
(
	CategoryID int PRIMARY KEY IDENTITY,
	CategoryName nvarchar(50) NOT NULL,
	Notes nvarchar(100)
)

CREATE TABLE Product
(
	ProductID int PRIMARY KEY IDENTITY,
	CategoryID int NOT NULL,
	SupplierID int NOT NULL,
	ProductName nvarchar(100) NOT NULL,
	Color nvarchar(40) NOT NULL,
	Size varchar(4) NOT NULL,
	ImportPrice money NOT NULL,
	Retail money NOT NULL,
	Wholesale money NOT NULL,
	Notes nvarchar(100)
)
ALTER TABLE Product ADD CONSTRAINT fk_p_c FOREIGN KEY(CategoryID) REFERENCES Category(CategoryID)
ALTER TABLE Product ADD CONSTRAINT fk_p_s FOREIGN KEY(SupplierID) REFERENCES Supplier(SupplierID)

CREATE TABLE OrderDetail
(
	OrderID int NOT NULL,
	ProductID int NOT NULL,
	Quantity int NOT NULL,
	Notes nvarchar(100)
)
ALTER TABLE OrderDetail ADD CONSTRAINT pk_ob PRIMARY KEY(OrderID, ProductID)
ALTER TABLE OrderDetail ADD CONSTRAINT fk_od_b FOREIGN KEY(OrderID) REFERENCES [Order](OrderID)
ALTER TABLE OrderDetail ADD CONSTRAINT fk_od_p FOREIGN KEY(ProductID) REFERENCES Product(ProductID)

CREATE TABLE Warehouse
(
	ProductID int PRIMARY KEY,
	Quantity int NOT NULL,
	QuantityExactly int NOT NUll
)
ALTER TABLE Warehouse ADD CONSTRAINT fk_w_p FOREIGN KEY(ProductID) REFERENCES Product(ProductID)

CREATE TABLE OutWarehouse
(
	OutWarehouseID int PRIMARY KEY,
	OutDate date NOT NULL,
	EmployeeID int NOT NULL,
	[Status] nvarchar(15) NOT NULL,
	Notes nvarchar(100)
)
ALTER TABLE OutWarehouse ADD CONSTRAINT fk_ex_o FOREIGN KEY(OutWarehouseID) REFERENCES [Order](OrderID)
ALTER TABLE OutWarehouse ADD CONSTRAINT fk_ex_e FOREIGN KEY(EmployeeID) REFERENCES Employee(EmployeeID)

CREATE TABLE [Contract]
(
	ContractID int PRIMARY KEY IDENTITY,
	EmployeeID int NOT NULL,
	SupplierID int NOT NULL,
	CreateDate date NOT NULL,
	DeliveryDate date NOT NULL,
	[Status] nvarchar(15) NOT NULL,
	Notes nvarchar(100)
)
ALTER TABLE [Contract] ADD CONSTRAINT fk_ct_e FOREIGN KEY(EmployeeID) REFERENCES Employee(EmployeeID)
ALTER TABLE [Contract] ADD CONSTRAINT fk_ct_s FOREIGN KEY(SupplierID) REFERENCES Supplier(SupplierID)

CREATE TABLE ContractDetail
(
	ContractID int NOT NULL,
	ProductID int NOT NULL,
	Quantity int NOT NULL,
	Notes nvarchar(100) NOT NULL
)
ALTER TABLE ContractDetail ADD CONSTRAINT pk_cd PRIMARY KEY(ContractID, ProductID)
ALTER TABLE ContractDetail ADD CONSTRAINT fk_cd_ct FOREIGN KEY(ContractID) REFERENCES [Contract](ContractID)
ALTER TABLE ContractDetail ADD CONSTRAINT fk_cd_p FOREIGN KEY(ProductID) REFERENCES Product(ProductID)

CREATE TABLE EnterWarehouse
(
	EnterWarehouseID int PRIMARY KEY,
	EnterDate date NOT NULL,
	EmployeeID int NOT NULL,
	[Status] nvarchar(15) NOT NULL,
	Notes nvarchar(100)
)
ALTER TABLE EnterWarehouse ADD CONSTRAINT fk_ew_ct FOREIGN KEY(EnterWarehouseID) REFERENCES [Contract](ContractID)
ALTER TABLE EnterWarehouse ADD CONSTRAINT fk_ew_e FOREIGN KEY(EmployeeID) REFERENCES Employee(EmployeeID)