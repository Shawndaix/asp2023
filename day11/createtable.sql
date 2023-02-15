USE Cst_student;
GO

CREATE TABLE studentinfo
(
    ID int PRIMARY KEY,
    Name varchar(60),
    Age int,
    Decsription varchar(255),
    DateofBirth date
);
GO