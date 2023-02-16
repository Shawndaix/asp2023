---create table Customer


USE Market;
GO

CREATE TABLE Customers
(
    customerID int IDENTITY(10, 1) PRIMARY KEY NOT NULL,
    customerContact varchar(50) NOT NULL,
    customerCity varchar(50) NOT NULL,
    customerBirthday datetime
);
GO