/* This procedure returns details of all accounts and Account holder related to them */
CREATE PROCEDURE spGetAllAccounts

AS
BEGIN

	SET NOCOUNT ON;

	SELECT
			ah.AccountHolderID,
			ah.AHFirstName,
			ah.AHSurname,
			a.AccountType,
			a.AccountSortCode,
			a.AccountBalance,
			a.AccountOverdraftLimit,
			a.AccountInterestRate,
			a.AccountID
	FROM
		tblAccountCU
	as	a LEFT JOIN tblAccountHolderCU as ah ON ah.AccountHolderID = a.AccountHolderID
END