/* This procedure allows to edit contact details except the AccountID */
CREATE PROCEDURE spEditContactDetails
		@AccountHolderID	INTEGER,
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