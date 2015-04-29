-- ===============================================
-- 5. Procedures to perform transactions
-- ===============================================
/* Procedure to execute transfer of funds between two internal accounts */

CREATE PROCEDURE spPerformTransfer
	@SourceID INTEGER,
	@DestinationID INTEGER,
	@Type NVARCHAR(256),
	@Amount	INTEGER,
	@StaffID INTEGER,
	@Description NVARCHAR(256),
	@Status INTEGER OUTPUT,
	@TransactionID INTEGER OUTPUT

AS
-- Start the transaction
BEGIN TRANSACTION
	DECLARE @BALORG INTEGER
	DECLARE @BALNEW INTEGER

-- Substract the amount from source account
	SET @BALORG = ( SELECT top(1) AccountBalance FROM tblAccountCU WHERE AccountID = @SourceID);
	SET @BALNEW = @BALORG - @Amount
-- Update source account balance
	UPDATE tblAccountCU
		SET AccountBalance = @BALNEW
		WHERE AccountID = @SourceID

-- Rollback the transaction if there were any errors
IF @@ERROR <> 0
 BEGIN
    -- Rollback the transaction
    ROLLBACK
	SET @Status = 1
    -- Raise an error and return
    RAISERROR ('Error in updating source account ballance.', 16, 1)
    RETURN
 END

-- Increase the destination account ballance
-- Add the amount to the destination account
	SET @BALORG = ( SELECT top(1) AccountBalance FROM tblAccountCU WHERE AccountID = @DestinationID);
	SET @BALNEW = @BALORG + @Amount
-- Update destination account balance
	UPDATE tblAccountCU
		SET AccountBalance = @BALNEW
		WHERE AccountID = @DestinationID
-- Rollback the transaction if there were any errors
IF @@ERROR <> 0
 BEGIN
    -- Rollback the transaction
    ROLLBACK
	SET @Status = 2
    -- Raise an error and return
    RAISERROR ('Error in updating destination account ballance.', 16, 1)
    RETURN
 END

 -- store a transaction record in the database
 INSERT INTO tblTransactionCU VALUES ( GETDATE(), @Type, @Description, @Amount, @StaffID, @SourceID, @DestinationID)
 
	SELECT
				@TransactionID = @@IDENTITY
 IF @@ERROR <> 0
 BEGIN
    -- Rollback the transaction
    ROLLBACK
	SET @Status = 3
    -- Raise an error and return
    RAISERROR ('Error in saving the transaction.', 16, 1)
    RETURN
 END
 
 SET @Status = 0
--         Commit the transaction....
COMMIT