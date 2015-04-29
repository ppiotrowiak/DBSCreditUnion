/* Procedure to add new account holder */
CREATE PROCEDURE spAddAccountHolder
		@AHFirstName		NVARCHAR(256),
		@AHSurname			NVARCHAR(256),
		@AHEmail			NVARCHAR(256),
		@AHPhone			NVARCHAR(256),
		@AHAddress1			NVARCHAR(256),
		@AHAddress2			NVARCHAR(256),
		@AHCity				NVARCHAR(256),
		@AHCounty			NVARCHAR(256),
		@AccountHolderID	INTEGER OUTPUT
AS
BEGIN
	INSERT INTO tblAccountHolderCU
				(
					AHFirstName,
					AHSurname,
					AHEmail,
					AHPhone,
					AHAddress1,
					AHAddress2,
					AHCity,
					AHCounty
				)
		VALUES
				(
					@AHFirstName,
					@AHSurname,
					@AHEmail,
					@AHPhone,
					@AHAddress1,
					@AHAddress2,
					@AHCity,
					@AHCounty
				)
		SELECT @AccountHolderID = @@IDENTITY
END