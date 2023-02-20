USE Market;
GO

CREATE TABLE userInfo
(
	UserID INT PRIMARY KEY IDENTITY(10,1) NOT NULL,
	UserName VARCHAR(50) NOT NULL,
	UserPassword VARCHAR(100) NOT NULL,
	UserAge TINYINT,
	UserEmail VARCHAR(30),
	UserMobile VARCHAR(10),
	CreateDate DATETIME,
	LastLogin DATETIME,
	LastErrdateTime DATETIME,
	DelFlag TINYINT DEFAULT 0

)

INSERT dbo.userInfo
(
    UserName,
    UserPassword,
    UserAge,
    UserEmail,
    UserMobile,
    CreateDate,
    LastLogin,
    LastErrdateTime,
    DelFlag
)
VALUES
(   'Tom',     -- UserName - varchar(50)
    '123456',     -- UserPassword - varchar(100)
    23,   -- UserAge - tinyint
    NULL,   -- UserEmail - varchar(30)
    NULL,   -- UserMobile - varchar(10)
    NULL,   -- CreateDate - datetime
    NULL,   -- LastLogin - datetime
    NULL,   -- LastErrdateTime - datetime
    DEFAULT -- DelFlag - tinyint
    );

SELECT * FROM dbo.userInfo;

SELECT * FROM dbo.userInfo WHERE UserName='Tom';


select COUNT(*) from dbo.userInfo where username = 'Tom' and UserPassword ='123456';


