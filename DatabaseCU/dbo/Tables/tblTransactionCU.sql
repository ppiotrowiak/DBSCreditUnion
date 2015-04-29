CREATE TABLE tblTransactionCU
(

	TransactionID INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
	TransactionDate DATETIME NOT NULL,
	TransactionType NVARCHAR(10) NOT NULL,
	TransactionDescription NVARCHAR(256),
	TransactionAmount BIGINT NOT NULL,
	StaffID INTEGER NOT NULL,
	SourceAccountID INTEGER NOT NULL,
	DestinationAccountID INTEGER NOT NULL,
	CONSTRAINT FK_TStaffID FOREIGN KEY (StaffID)
		REFERENCES tblStaffCU (StaffID),
	CONSTRAINT FK_TSourceAccountID FOREIGN KEY (SourceAccountID)
		REFERENCES tblAccountCU (AccountID),
	CONSTRAINT FK_TDestinationAccount FOREIGN KEY (DestinationAccountID)
		REFERENCES tblAccountCU (AccountID)
)