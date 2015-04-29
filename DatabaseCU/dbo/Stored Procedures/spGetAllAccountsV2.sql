CREATE PROCEDURE spGetAllAccountsV2

AS
BEGIN

SET NOCOUNT ON;

SELECT tblAccountHolderCU.AccountHolderID,
        tblAccountHolderCU.AHFirstName, 
        tblAccountHolderCU.AHSurname,
        tblAccountCU.AccountID, 
        tblAccountCU.AccountType, 
        tblAccountCU.AccountBalance,
        tblAccountCU.AccountInterestRate,
        tblAccountCU.AccountOverdraftLimit 
        
FROM tblAccountCU
INNER JOIN tblAccountHolderCU
ON tblAccountCU.AccountHolderID = tblAccountHolderCU.AccountHolderID

END