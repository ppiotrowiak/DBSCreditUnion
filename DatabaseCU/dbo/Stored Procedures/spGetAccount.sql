/* This procedure returns account details */
CREATE PROCEDURE spGetAccount
		@AccountID	INTEGER
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		a.AccountID,
		a.AccountType,
		a.AccountSortCode,
		a.AccountBalance,
		a.AccountOverdraftLimit,
		a.AccountInterestRate,
		a.AccountHolderID

	FROM	
		tblAccountCU a
	WHERE
		a.AccountID = @AccountID
END



IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAllAccounts]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAllAccounts]