CREATE TABLE tblAccountCU 
( 
	AccountID INTEGER PRIMARY KEY IDENTITY(10000001,1) NOT NULL, 
	AccountType NVARCHAR(10) NOT NULL, 
	AccountSortCode INTEGER NOT NULL, 
	AccountBalance BIGINT NOT NULL, 
	AccountOverdraftLimit BIGINT, 
	AccountInterestRate INTEGER, 
	AccountHolderID INTEGER NOT NULL, 
	CONSTRAINT FK_AAccountHolderID FOREIGN KEY (AccountHolderID)  
		REFERENCES tblAccountHolderCU (AccountHolderID) 
);