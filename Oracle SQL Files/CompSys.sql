DROP TABLE ESTPARTS;
DROP TABLE ESTIMATES;
DROP TABLE Repairs;
DROP TABLE PARTS;
DROP TABLE Customers;
DROP TABLE Staff;


DROP VIEW TOTAL_REPAIRS;

CREATE TABLE Customers (
	Cust_ID numeric(9),
	Surname varchar(50) NOT NULL,
	Forename varchar(100) NOT NULL,
	DOB DATE NOT NULL,
	Address1 varchar(100) NOT NULL,
	Address2 varchar(100),
	Town varchar(30) NOT NULL,
	County varchar(9) NOT NULL,
	Telephone varchar(15) NOT NULL,
	Email varchar(500) NOT NULL,
	Cust_Type varchar(20) CHECK (Cust_Type IN ('Normal', 'Student', 'OAP')) NOT NULL,
	RegDate date DEFAULT SYSDATE,
	Status char(2) DEFAULT 'A',
  CONSTRAINT uq_Cust_email UNIQUE (Email),
  CONSTRAINT uq_Cust_tel UNIQUE (Telephone),
CONSTRAINT pk_Customers PRIMARY KEY (Cust_ID));


CREATE TABLE Staff (
	Staff_ID numeric(9),
	Surname varchar(50) NOT NULL,
	Forename varchar(100) NOT NULL,
	DOB date NOT NULL,
	Address1 varchar(100) NOT NULL,
	Address2 varchar(100),
	Town varchar(30) NOT NULL,
	County varchar(9) NOT NULL,
	Telephone char(15) NOT NULL,
	Email varchar(500) NOT NULL,
	Staff_Type varchar(7) CHECK (Staff_Type IN ('Manager', 'Staff', 'Intern')) NOT NULL,
	RegDate date DEFAULT SYSDATE,
	Status char(2) DEFAULT 'A',
	username varchar(20) NOT NULL,
	password varchar(20) NOT NULL,
  CONSTRAINT uq_Staff_Username UNIQUE (username),
  CONSTRAINT uq_Staff_email UNIQUE (Email),
  CONSTRAINT uq_Staff_tel UNIQUE (Telephone),
CONSTRAINT pk_Staff PRIMARY KEY (Staff_ID));


CREATE TABLE Repairs (
	Rep_ID numeric(9),
	Cust_ID numeric(9) NOT NULL,
	Staff_ID numeric(9) NOT NULL,
	Description varchar(1000) NOT NULL,
	DeviceType char(20) CHECK (DeviceType IN ('Laptop', 'Desktop', 'Printer', 'Other')) NOT NULL,
	Brand varchar(50) NOT NULL,
	Model varchar(50) NOT NULL,
	OS varchar(20) CHECK (OS IN ('Windows 7', 'Windows 8', 'Windows Vista', 'Windows Older', 'MacOS X', 'Linux', 'Other')) NOT NULL,
	RepairDate date DEFAULT SYSDATE,
	CollectionDate date,
	Status varchar(30) DEFAULT 'New' CHECK (Status IN ('New', 'Estimated', 'Validated', 'Fixing', 'Resolved', 'Invoiced', 'Paid')),
	CONSTRAINT pk_Repairs PRIMARY KEY (Rep_ID),
	CONSTRAINT fk_Repairs_Cust FOREIGN KEY (Cust_ID) REFERENCES Customers,
CONSTRAINT fk_Repairs_Staff FOREIGN KEY (Staff_ID) REFERENCES Staff);


CREATE TABLE Estimates (
	Rep_ID numeric(9) NOT NULL,
	Staff_ID numeric(9) NOT NULL,
	EstimateDate date DEFAULT SYSDATE,
	VAT decimal(4,2),
	Discount decimal(4,2),
	Total decimal(9,2) NOT NULL,
	CONSTRAINT pk_EstiSHOmates PRIMARY KEY (Rep_ID),
  CONSTRAINT fk_Estimates_Staff FOREIGN KEY (Staff_ID) REFERENCES Staff,
CONSTRAINTS fk_Estimates_Repairs FOREIGN KEY (Rep_ID) REFERENCES Repairs);


CREATE TABLE Parts (
	Part_ID numeric(9),
	Part_Name varchar(40) NOT NULL,
	Description varchar(500) NOT NULL,
	Vendor varchar(50) NOT NULL,
	Condition varchar(11) CHECK (Condition IN ('New', 'Refurbished', 'Used')),
	TotalStock numeric(5) NOT NULL,
	ShopPrice decimal(6,2) NOT NULL,
CONSTRAINT pk_Parts PRIMARY KEY (Part_ID));


CREATE TABLE EstParts (
  Rep_ID numeric(9),
	Part_ID numeric(9),
	Quantity numeric(4) NOT NULL,
	RetailPrice decimal(6,2) NOT NULL,
	CONSTRAINT pk_EstParts PRIMARY KEY (Rep_ID, Part_ID),
	CONSTRAINT fk_esp_part FOREIGN KEY (Part_ID) REFERENCES Parts,
CONSTRAINT fk_esp_est FOREIGN KEY (Rep_ID) REFERENCES Estimates);


CREATE VIEW Total_Repairs AS
  SELECT Status, COUNT(*) AS Total
  FROM Repairs
  WHERE EXTRACT(YEAR FROM RepairDate) = EXTRACT(YEAR FROM sysdate)
  GROUP BY Status;