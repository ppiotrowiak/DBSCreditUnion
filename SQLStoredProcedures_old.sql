-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<PPiotrowiak>
-- Create date: <Create Date,,>
-- Description:	<>
-- =============================================

-- =============================================

-- 1. Procedures to work with the account holder 

-- =============================================
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spAddAccountHolder]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spAddAccountHolder]
GO
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
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAccountHolder]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAccountHolder]
GO

/* This procedure returns account holder details */
CREATE PROCEDURE spGetAccountHolder
	@AccountHolderId INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
			a.AHFirstName,
			a.AHSurname,
			a.AHEmail,
			a.AHPhone,
			a.AHAddress1,
			a.AHAddress2,
			a.AHCity,
			a.AHCounty
	FROM 
			tblAccountHolderCU a
	WHERE a.AccountHolderID=@AccountHolderId
END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetMaxAccountHolderID]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetMaxAccountHolderID]
GO
/* This procedure returns last AccountID value */
CREATE PROCEDURE spGetMaxAccountHolderID
--parameters not needed
AS
BEGIN
	SELECT MAX(AccountHolderID) FROM tblAccountHolderCU
END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAllAccountHolders]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAllAccountHolders]
GO
/* Procedure to return all account holders */
CREATE PROCEDURE spGetAllAccountHolders
AS
BEGIN
	SET NOCOUNT ON;
SELECT
	*
FROM tblAccountHolderCU
END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spEditAllAccountHolderDetails]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spEditAllAccountHolderDetails]
GO
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
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spEditContactDetails]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spEditContactDetails]
GO
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
GO




-- =============================================

-- 2. Procedures to work with accounts

-- =============================================
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spAddAccount]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spAddAccount]
GO
/* This adds a new account */
CREATE PROCEDURE spAddAccount
		
		@AccountType				NVARCHAR(256),
		@AccountSortCode			INTEGER,
		@AccountBalance				INTEGER,
		@AccountOverdraftLimit		INTEGER,
		@AccountInterestRate		INTEGER,
		@AccountHolderID			INTEGER,
		@AccountID					INTEGER OUTPUT
AS
BEGIN
	INSERT INTO tblAccountCU
			(
				AccountType,
				AccountSortCode,
				AccountBalance,
				AccountOverdraftLimit,
				AccountInterestRate,
				AccountHolderID		
			)
		VALUES
			(
				@AccountType,
				@AccountSortCode,
				@AccountBalance,
				@AccountOverdraftLimit,
				@AccountInterestRate,
				@AccountHolderID		
			)
		SELECT
				@AccountID = @@IDENTITY
END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetMaxAccountID]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetMaxAccountID]
GO
/* This procedure returns last AccountID value */
CREATE PROCEDURE spGetMaxAccountID
--parameters not needed
AS
BEGIN
	SELECT MAX(AccountID) FROM tblAccountCU
END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAccount]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAccount]
GO
/* This procedure returns account details */
CREATE PROCEDURE spGetAccount
		@AccountID	INTEGER
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		a.AccountID,
		a.AccountType,
		a.AccountSortCode,
		a.AccountBalance,
		a.AccountOverdraftLimit,
		a.AccountInterestRate,
		a.AccountHolderID

	FROM	
		tblAccountCU a
	WHERE
		a.AccountID = @AccountID
END

/* Drop if exists */
DROP PROCEDURE spAddAccount
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAllAccounts]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAllAccounts]
GO
/* This procedure returns details of all accounts and Account holder related to them */
CREATE PROCEDURE spGetAllAccounts

AS
BEGIN

	SET NOCOUNT ON;

	SELECT
			ah.AccountHolderID,
			ah.AHFirstName,
			ah.AHSurname,
			a.AccountType,
			a.AccountSortCode,
			a.AccountBalance,
			a.AccountOverdraftLimit,
			a.AccountInterestRate,
			a.AccountID
	FROM
		tblAccountCU
	as	a LEFT JOIN tblAccountHolderCU as ah ON ah.AccountHolderID = a.AccountHolderID
END
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spUpdateAccountBalance]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spUpdateAccountBalance]
GO
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
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spUpdateAccountOverdraftLimit]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spUpdateAccountOverdraftLimit]
GO
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
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spUpdateAccountInterestRate]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spUpdateAccountInterestRate]
GO
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
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAllAccountsV2]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAllAccountsV2]
GO
CREATE PROCEDURE spGetAllAccountsV2

AS
BEGIN

SET NOCOUNT ON;

SELECT tblAccountHolderCU.AccountHolderID,
        tblAccountHolderCU.AHFirstName, 
        tblAccountHolderCU.AHSurname,
        tblAccountCU.AccountID, 
        tblAccountCU.AccountType, 
        tblAccountCU.AccountBalance,
        tblAccountCU.AccountInterestRate,
        tblAccountCU.AccountOverdraftLimit 
        
FROM tblAccountCU
INNER JOIN tblAccountHolderCU
ON tblAccountCU.AccountHolderID = tblAccountHolderCU.AccountHolderID

END
GO

-- =============================================

-- 3. Procedures to work with transactions

-- =============================================

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spAddTransaction]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spAddTransaction]
GO
/* Adding a new transaction */
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
GO

-- =============================================

-- 3. Procedures to work with transactions

-- =============================================

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spAddTransaction]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spAddTransaction]
GO
/* Adding a new transaction */
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
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetTransaction]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetTransaction]
GO
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
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAllTransactions]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAllTransactions]
GO
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
GO

-- ==============================================

-- 4. Procedures to work with Staff details

-- ==============================================

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetStaffID]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetStaffID]
GO
/*  Procedure for logging staff, returns staff id if found */
CREATE PROCEDURE spGetStaffID
		@StaffName		NVARCHAR(256),
		@StaffPassword	NVARCHAR(256)
AS
BEGIN
		SET NOCOUNT ON

		SELECT
			a.StaffID
		FROM
			tblStaffCU a
		WHERE 
			a.StaffName = @StaffName AND a.StaffPassword = @StaffPassword
END
GO