USE Market;
GO

DECLARE @i int = 0;
DECLARE @strName varchar(100) = '';
DECLARE @strEmail varchar(100) = '';

WHILE @i < 100
BEGIN
    --get diffrent names and Emails with Numbers.
    --str() as int to string.
    --replace() as eliminate the space in the string.
    --concat() as make two strings into one string.

    SET @strName = CONCAT('Tom', REPLACE(STR(@i), ' ', ''));
    SET @strEmail = CONCAT(@strName, '@cstcollege.com');
    INSERT INTO dbo.userInfo
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
    (   @strName,     -- UserName - varchar(50)
        '123456',     -- UserPassword - varchar(100)
        22,           -- UserAge - tinyint
        @strEmail,    -- UserEmail - varchar(30)
        '6748338666', -- UserMobile - varchar(10)
        GETDATE(),    -- CreateDate - datetime
        NULL,         -- LastLogin - datetime
        NULL,         -- LastErrdateTime - datetime
        DEFAULT       -- DelFlag - tinyint
    );
    SET @i += 1
END

SELECT COUNT(*)
FROM UserInfo;
SELECT *
FROM UserInfo;
