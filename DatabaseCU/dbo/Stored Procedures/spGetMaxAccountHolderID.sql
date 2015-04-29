/* This procedure returns last AccountID value */
CREATE PROCEDURE spGetMaxAccountHolderID
--parameters not needed
AS
BEGIN
	SELECT MAX(AccountHolderID) FROM tblAccountHolderCU
END