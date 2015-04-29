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