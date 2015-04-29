/* This procedure updates account balance based on AccountID */
CREATE PROCEDURE spUpdateAccountBalance
		@AccountID INTEGER,
		@NewBalance INTEGER,
		@RowsAffected INTEGER OUTPUT
AS
BEGIN
	UPDATE
		tblAccountCU
	SET
		AccountBalance = @NewBalance
	WHERE
		AccountID = @AccountID
	SELECT @RowsAffected = @@ROWCOUNT

END

/* Drop if exists */
DROP PROCEDURE spEditAllAccountHolderDetails