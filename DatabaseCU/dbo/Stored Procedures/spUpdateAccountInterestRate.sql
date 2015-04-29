/* This procedure updates account overdraft limit */
CREATE PROCEDURE spUpdateAccountInterestRate
		@AccountID INTEGER,
		@NewInterestRate INTEGER,
		@RowsAffected INTEGER OUTPUT
AS
BEGIN
	UPDATE
		tblAccountCU
	SET
		AccountInterestRate = @NewInterestRate
	WHERE
		AccountID = @AccountID
	SELECT @RowsAffected = @@ROWCOUNT
END