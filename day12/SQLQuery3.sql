CREATE DATABASE Market
ON
    (
        NAME = 'Market',
        SIZE = 8MB,
        FILEGROWTH = 64MB,
        FILENAME = 'C:\sqldata\Market_dat.mdf'
    )
LOG ON
    (
        NAME = 'log',
        SIZE = 8MB,
        FILEGROWTH = 8MB,
        FILENAME = 'C:\sqldata\Market_log.ldf'
    );