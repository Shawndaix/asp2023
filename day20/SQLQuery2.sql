USE Market;
GO

CREATE TABLE UserInfo
(
    UserID int IDENTITY PRIMARY KEY NOT NULL,
    UserName varchar(50) NOT NULL,
    UserPassword varchar(100) NOT NULL,
    UserAge tinyint,
    USerEmail varchar(30),
    UserMobile varchar(10),
    CreateDate datetime,
    LastLogin datetime,
    LastErrDateTime datetime,
    DelFlag tinyint
        DEFAULT 0,
);
GO
SELECT *
FROM UserInfo;