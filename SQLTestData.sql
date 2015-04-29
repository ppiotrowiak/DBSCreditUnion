/* Put some stuff in but drop and create tables first(!) */
INSERT INTO tblStaffCU VALUES ('Prem', '1234');
INSERT INTO tblStaffCU VALUES ('Krys', '1234');
INSERT INTO tblStaffCU VALUES ('Bran', '1234');


INSERT INTO tblAccountHolderCU VALUES ('Donald', 'Duck', 'dduck@disney.com', '1234', '10 The Paddocks', 'Clontarf', 'Dublin', 'Dublin');
INSERT INTO tblAccountHolderCU VALUES ('Mickey', 'Mouse', 'mmous@disney.com', '4567', '5 Seaview', 'Raheny', 'Dublin', 'Dublin');
INSERT INTO tblAccountHolderCU VALUES ('Minnie', 'Mouse', 'mmous@disney.com', '9876', '2 Fairview Park', 'Fairview', 'Dublin', 'Dublin');

INSERT INTO tblAccountCU VALUES ('CURRENT','101010','100','400','','2');
INSERT INTO tblAccountCU VALUES ('SAVINGS','101010','150','','123','2');
INSERT INTO tblAccountCU VALUES ('CURRENT','101010','200','500','','3');
INSERT INTO tblAccountCU VALUES ('SAVINGS','101010','250','','123','3');
INSERT INTO tblAccountCU VALUES ('CURRENT','101010','300','600','','4');
INSERT INTO tblAccountCU VALUES ('SAVINGS','101010','350','','123','4');


INSERT INTO tblTransactionCU VALUES ('2015-02-03', 'TRANSFER', 'For movies', '1000', '1', '2', '3');
INSERT INTO tblTransactionCU VALUES ('2015-03-03', 'TRANSFER', 'For cigarrettes', '2000', '2', '2', '4');
INSERT INTO tblTransactionCU VALUES ('2015-02-15', 'TRANSFER', 'Payback', '3000', '3', '4', '2');
