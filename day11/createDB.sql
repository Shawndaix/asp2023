USE master;
GO

CREATE DATABASE Cst_student
ON
    (
        NAME = Cst_student_dat,
        FILENAME = 'c:\sqldata\Cst_student.mdf',
        SIZE = 10MB,
        MAXSIZE = 50MB,
        FILEGROWTH = 5MB
    )
LOG ON
    (
        NAME = Cst_student_log,
        FILENAME = 'c:\sqldata\Cst_student.ldf',
        SIZE = 5MB,
        MAXSIZE = 25MB,
        FILEGROWTH = 5MB
    )
GO