/* This procedure updates account overdraft limit */
CREATE PROCEDURE spUpdateAccountOverdraftLimit
		@AccountID INTEGER,
		@NewOverdraftLimit INTEGER,
		@RowsAffected INTEGER OUTPUT
AS
BEGIN
	UPDATE
		tblAccountCU
	SET
		AccountOverdraftLimit = @NewOverdraftLimit
	WHERE
		AccountID = @AccountID
	SELECT @RowsAffected = @@ROWCOUNT
END