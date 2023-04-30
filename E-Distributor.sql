CREATE DATABASE E_Distributor;
GO

USE E_Distributor;
GO

CREATE TABLE Account
(
	AccountId VARCHAR(10) NOT NULL PRIMARY KEY,
	Username NVARCHAR(30) NOT NULL,
	Password NVARCHAR(30) NOT NULL,
	Role NVARCHAR(30) NOT NULL
)

CREATE TABLE Accountant (
	AccountantId VARCHAR(10) NOT NULL PRIMARY KEY
	, Name NVARCHAR(50) NOT NULL
	, Department NVARCHAR(50) NOT NULL
	, Certification NVARCHAR(50) NOT NULL
	, AccountId VARCHAR(10) NOT NULL
	, CONSTRAINT FkAccountant_AccountId FOREIGN KEY (AccountId) REFERENCES Account(AccountId)
	);

CREATE TABLE WarehouseStaff (
	WarehouseStaffId VARCHAR(10) NOT NULL PRIMARY KEY
	, Name NVARCHAR(50) NOT NULL
	, WarehouseLocation NVARCHAR(50) NOT NULL
	, AccountId VARCHAR(10) NOT NULL
	, CONSTRAINT FkWarehouseStaff_AccountId FOREIGN KEY (AccountId) REFERENCES Account(AccountId)
	);

CREATE TABLE WarehouseReceipt (
	WarehouseReceiptId INT NOT NULL PRIMARY KEY IDENTITY(1, 1)
	, TotalQuantity INT NOT NULL
	, TotalPrice INT NOT NULL
	, CreatedAt DATE NOT NULL
	, WarehouseStaffId VARCHAR(10)
	, AccountantId VARCHAR(10)
	, CONSTRAINT FkWarehouseReceipt_WarehouseStaffId FOREIGN KEY (WarehouseStaffId) REFERENCES WarehouseStaff(WarehouseStaffId)
	, CONSTRAINT FkWarehouseReceipt_AccountantId FOREIGN KEY (AccountantId) REFERENCES Accountant(AccountantId)
	);

CREATE TABLE Item (
	ItemId INT NOT NULL PRIMARY KEY IDENTITY(1, 1)
	, Name NVARCHAR(50) NOT NULL
	, Price INT NOT NULL
	, Quantity INT NOT NULL
	,
	);

CREATE TABLE IncludeImportedItems
(
  Quantity INT NOT NULL,
  TotalPrice INT NOT NULL,
  WarehouseReceiptId INT NOT NULL,
  ItemId INT NOT NULL,
  CONSTRAINT PkIncludeImportedItems PRIMARY KEY (WarehouseReceiptId, ItemId),
  CONSTRAINT FkIncludeImportedItems_WarehouseReceiptId FOREIGN KEY (WarehouseReceiptId) REFERENCES WarehouseReceipt(WarehouseReceiptId),
  CONSTRAINT FkIncludeImportedItems_ItemId FOREIGN KEY (ItemId) REFERENCES Item(ItemId)
);

INSERT INTO Account
VALUES
('A1001', 'account1', 'a1sakuragi', 'Accountant'),
('A1002', 'account2', 'a2kaede', 'Accountant'),
('A1003', 'account3', 'ws1john', 'WarehouseStaff'),
('A1004', 'account4', 'ws2silly', 'WarehouseStaff')

INSERT INTO WarehouseStaff
VALUES
('WS1', 'John Michael', 'Paris', 'A1003'),
('WS2', 'Silly Dell', 'London', 'A1004')

INSERT INTO Accountant
VALUES
('A1', 'Hanamichi Sakuragi', 'A001', 'College Degree', 'A1001'),
('A2', 'Rukawa Kaede', 'A002', 'High School', 'A1002')

-- uncomment if you want to reset auto increment number
--DBCC CHECKIDENT ('Item', RESEED, 0);
--DBCC CHECKIDENT ('WarehouseReceipt', RESEED, 0)
