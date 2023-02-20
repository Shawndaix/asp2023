USE Market;
GO

DECLARE @cnt INT = 0;
DECLARE @str VARCHAR(100) ='';

WHILE @cnt < 500 -- loop 
BEGIN
	--get diffrent name with Number.
	--str() as int to string.
	--replace() as eliminate the space in the string.
	--concat() as make two strings into one string.

	SET @str = CONCAT('Tom',REPLACE(STR(@cnt),' ',''));
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
	(   @str,     -- UserName - varchar(50)
		'123456',     -- UserPassword - varchar(100)
		NULL,   -- UserAge - tinyint
		NULL,   -- UserEmail - varchar(30)
		NULL,   -- UserMobile - varchar(10)
		GETDATE(),   -- CreateDate - datetime
		NULL,   -- LastLogin - datetime
		NULL,   -- LastErrdateTime - datetime
		DEFAULT -- DelFlag - tinyint
		) ;
	SET @cnt=@cnt+1; -- add 1 more.
END

-- finished note.
	PRINT	'Insert Finished!!!';
GO	

SELECT * FROM dbo.userInfo;
SELECT COUNT(*) FROM dbo.userInfo;

DELETE FROM dbo.userInfo WHERE  UserID>11;