/* This procedure returns last AccountID value */
CREATE PROCEDURE spGetMaxAccountID
--parameters not needed
AS
BEGIN
	SELECT MAX(AccountID) FROM tblAccountCU
END