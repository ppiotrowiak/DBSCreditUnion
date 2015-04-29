/* Retrieve all transactions details. Data taken from this table only */
CREATE PROCEDURE spGetAllTransactions
	
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
END