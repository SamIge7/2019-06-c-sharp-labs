drop table if exists Tasks
drop database if exists taskDB
drop table if exists Catagories
go

create database taskDB

create table Catagories
(
	CatagoryID INT IDENTITY PRIMARY KEY,
	CatagoryName nvarchar (50) NOT NULL,
)

create table Tasks
(
	TaskID INT IDENTITY PRIMARY KEY,
	Description nvarchar (50) NULL,
	Done BIT NULL,
	CatagoryID INT NULL,
	FOREIGN KEY (CatagoryID) REFERENCES Catagories (CatagoryID)
)