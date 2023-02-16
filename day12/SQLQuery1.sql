USE Market;
GO

INSERT INTO dbo.Customers
(
    customerContact,
    customerCity,
    customerBirthday
)
VALUES
(   'Joey',  -- customerContact - varchar(50)
    'Brampton',  -- customerCity - varchar(50)
    '1980-01-01 00:00:00.000' -- customerBirthday - datetime
    );

SELECT * FROM dbo.Customers;