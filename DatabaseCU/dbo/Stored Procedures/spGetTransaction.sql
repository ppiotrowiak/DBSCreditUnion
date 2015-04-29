/* Retrieve transaction details. Data taken from this table only */
CREATE PROCEDURE spGetTransaction
	@TransactionID INTEGER
AS
BEGIN
	
		SET NOCOUNT ON;

		SELECT
			t.TransactionID,
			t.TransactionDate,
			t.TransactionType,
			t.TransactionDescription,
			t.TransactionAmount,
			t.StaffID,
			t.SourceAccountID,
			t.DestinationAccountID

		FROM tblTransactionCU t
		WHERE
			t.TransactionID = @TransactionID

END