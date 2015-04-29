/* This procedure allows to edit ALL account details except the AccountID */
CREATE PROCEDURE spEditAllAccountHolderDetails
		@AccountHolderID	INTEGER,
		@AHFirstName		NVARCHAR(256),
		@AHSurname			NVARCHAR(256),
		@AHEmail			NVARCHAR(256),
		@AHPhone			NVARCHAR(256),
		@AHAddress1			NVARCHAR(256),
		@AHAddress2			NVARCHAR(256),
		@AHCity				NVARCHAR(256),
		@AHCounty			NVARCHAR(256),
		@RowsAffected		INTEGER OUTPUT
AS
BEGIN
UPDATE
		tblAccountHolderCU
SET
		AHFirstName = @AHFirstName,
		AHSurname = @AHSurname,
		AHEmail = @AHEmail,
		AHPhone = @AHPhone,
		AHAddress1 = @AHAddress1,
		AHAddress2 = @AHAddress2,
		AHCity = @AHCity,
		AHCounty = @AHCounty
WHERE
		AccountHolderID = @AccountHolderID;
SELECT 
		@RowsAffected = @@ROWCOUNT
END