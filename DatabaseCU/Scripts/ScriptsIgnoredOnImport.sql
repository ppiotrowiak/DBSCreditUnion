
-- =================================================================
-- DBS Credit Union tables desctruction, creation and initialisation
-- =================================================================

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[tblTransactionCU]') 
		AND OBJECTPROPERTY(id, N'IsTable') = 1) DROP TABLE [dbo].[tblTransactionCU]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[tblAccountCU]') 
		AND OBJECTPROPERTY(id, N'IsTable') = 1) DROP TABLE [dbo].[tblAccountCU]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[tblAccountHolderCU]') 
		AND OBJECTPROPERTY(id, N'IsTable') = 1) DROP TABLE [dbo].[tblAccountHolderCU]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[tblStaffCU]') 
		AND OBJECTPROPERTY(id, N'IsTable') = 1) DROP TABLE [dbo].[tblStaffCU]
GO

-- Creating technical account necessary for correct functioning of the solution
INSERT INTO tblAccountHolderCU VALUES ('Cashier', '', 'cashier@dbsCU.com', '+353 (0) 1 4177500', 'Dublin Business School', '13/14 Aungier Street', 'Dublin', 'Dublin');
GO

-- Creating technical account responsible for storing data about external transfers
INSERT INTO tblAccountHolderCU VALUES ('ExternalAgent', '', 'external@dbsCU.com', '+ 353 (0) 1 4177500', 'Dublin Business School', '13/14 Aungier Street', 'Dublin', 'Dublin');
GO

-- Creating technical account used for transfers to and from external accounts
INSERT INTO tblAccountCU VALUES ('CASHIER', '101010', '0', '0', '0', 1);
GO

INSERT INTO tblAccountCU VALUES ('EXTERNAL', '101010', '0', '0', '0', 2);
GO

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

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAccountHolder]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAccountHolder]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetMaxAccountHolderID]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetMaxAccountHolderID]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAllAccountHolders]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAllAccountHolders]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spEditAllAccountHolderDetails]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spEditAllAccountHolderDetails]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spEditContactDetails]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spEditContactDetails]
GO

-- =============================================

-- 2. Procedures to work with accounts

-- =============================================
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spAddAccount]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spAddAccount]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetMaxAccountID]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetMaxAccountID]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAccount]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAccount]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spUpdateAccountBalance]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spUpdateAccountBalance]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spUpdateAccountOverdraftLimit]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spUpdateAccountOverdraftLimit]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spUpdateAccountInterestRate]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spUpdateAccountInterestRate]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAllAccountsV2]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAllAccountsV2]
GO

-- =============================================

-- 3. Procedures to work with transactions

-- =============================================

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spAddTransaction]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spAddTransaction]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spAddTransaction]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spAddTransaction]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetTransaction]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetTransaction]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetAllTransactions]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetAllTransactions]
GO

-- ==============================================

-- 4. Procedures to work with Staff details

-- ==============================================

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spGetStaffID]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spGetStaffID]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spCheckLogin]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spCheckLogin]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[spPerformTransfer]') 
		AND OBJECTPROPERTY(id, N'IsProcedure') = 1) DROP PROCEDURE [dbo].[spPerformTransfer]
GO

/* Put some stuff in but drop and create tables first(!) */
INSERT INTO tblStaffCU VALUES ('Prem', '1234');
GO

INSERT INTO tblStaffCU VALUES ('Krys', '1234');
GO

INSERT INTO tblStaffCU VALUES ('Bran', '1234');
GO

INSERT INTO tblAccountHolderCU VALUES ('Donald', 'Duck', 'dduck@disney.com', '1234', '10 The Paddocks', 'Clontarf', 'Dublin', 'Dublin');
GO

INSERT INTO tblAccountHolderCU VALUES ('Mickey', 'Mouse', 'mmous@disney.com', '4567', '5 Seaview', 'Raheny', 'Dublin', 'Dublin');
GO

INSERT INTO tblAccountHolderCU VALUES ('Minnie', 'Mouse', 'mmous@disney.com', '9876', '2 Fairview Park', 'Fairview', 'Dublin', 'Dublin');
GO

INSERT INTO tblAccountCU VALUES ('CURRENT','101010','100','400','','3');
GO

INSERT INTO tblAccountCU VALUES ('SAVINGS','101010','150','','123','3');
GO

INSERT INTO tblAccountCU VALUES ('CURRENT','101010','200','500','','4');
GO

INSERT INTO tblAccountCU VALUES ('SAVINGS','101010','250','','123','4');
GO

INSERT INTO tblAccountCU VALUES ('CURRENT','101010','300','600','','5');
GO

INSERT INTO tblAccountCU VALUES ('SAVINGS','101010','350','','123','5');
GO

INSERT INTO tblTransactionCU VALUES ('2015-02-03', 'TRANSFER', 'For movies', '1000', '1', '10000003', '10000004');
GO

INSERT INTO tblTransactionCU VALUES ('2015-03-03', 'TRANSFER', 'For cigarrettes', '2000', '2', '10000004', '10000005');
GO

INSERT INTO tblTransactionCU VALUES ('2015-02-15', 'TRANSFER', 'Payback', '3000', '3', '10000003', '10000005')
GO
