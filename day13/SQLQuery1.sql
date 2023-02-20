USE Market;
GO

ALTER TABLE dbo.Customers ADD CustomerName VARCHAR(100);

ALTER TABLE dbo.Customers DROP COLUMN CustomerName;

SELECT * FROM dbo.Customers;

ALTER TABLE dbo.Customers ALTER COLUMN customerBirthday DATE;