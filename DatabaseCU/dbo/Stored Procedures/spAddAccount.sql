/* This adds a new account */
CREATE PROCEDURE spAddAccount
		
		@AccountType				NVARCHAR(256),
		@AccountSortCode			INTEGER,
		@AccountBalance				INTEGER,
		@AccountOverdraftLimit		INTEGER,
		@AccountInterestRate		INTEGER,
		@AccountHolderID			INTEGER,
		@AccountID					INTEGER OUTPUT
AS
BEGIN
	INSERT INTO tblAccountCU
			(
				AccountType,
				AccountSortCode,
				AccountBalance,
				AccountOverdraftLimit,
				AccountInterestRate,
				AccountHolderID		
			)
		VALUES
			(
				@AccountType,
				@AccountSortCode,
				@AccountBalance,
				@AccountOverdraftLimit,
				@AccountInterestRate,
				@AccountHolderID		
			)
		SELECT
				@AccountID = @@IDENTITY
END