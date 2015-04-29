/* Procedure to return all account holders */
CREATE PROCEDURE spGetAllAccountHolders
AS
BEGIN
	SET NOCOUNT ON;
SELECT
	*
FROM tblAccountHolderCU
END