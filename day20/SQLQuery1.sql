
USE MASTER;
GO

CREATE DATABASE Market
ON
    (
        NAME = Cst_Market_dat,
        FILENAME = 'c:\sqldata\Cst_Market.mdf',
        SIZE = 10MB,
        MAXSIZE = 50MB,
        FILEGROWTH = 5MB
    )
LOG ON
    (
        NAME = Cst_Market_log,
        FILENAME = 'c:\sqldata\Cst_Market.ldf',
        SIZE = 5MB,
        MAXSIZE = 25MB,
        FILEGROWTH = 5MB
    )
GO