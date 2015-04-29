/* Adding a new transaction - used for debugging only */
CREATE PROCEDURE spAddTransaction
	@Date				DATETIME,
	@Type				NVARCHAR(10),
	@Description		NVARCHAR(256),
	@Amount				BIGINT,
	@StaffID			INTEGER,
	@SourceAccountID	INTEGER,
	@DestinationAccountID		INTEGER,
	@TransactionID		INTEGER OUTPUT
AS
BEGIN
	INSERT INTO tblTransactionCU
			(
				TransactionDate,
				TransactionType,
				TransactionDescription,
				TransactionAmount,
				StaffID,
				SourceAccountID,
				DestinationAccountID
			)
	VALUES
			(
				@Date,
				@Type,
				@Description,
				@Amount,
				@StaffID,
				@SourceAccountID,
				@DestinationAccountID
			)
	SELECT
				@TransactionID = @@IDENTITY
END