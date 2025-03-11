CREATE DATABASE SchoolDB;

USE SchoolDB;
GO

CREATE TABLE Contact (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NULL,
    Surname NVARCHAR(100) NULL
);

SELECT * FROM Contact;

CREATE TABLE Address (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ContactId INT NOT NULL,
    Street NVARCHAR(100),
    City NVARCHAR(50),
    PostalCode NVARCHAR(10),
    FOREIGN KEY (ContactId) REFERENCES Contact(Id) ON DELETE CASCADE
);

SELECT * FROM Address;