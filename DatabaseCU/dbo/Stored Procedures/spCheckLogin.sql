CREATE PROCEDURE [dbo].[spCheckLogin]

		@user	NVARCHAR(256),

		@pass	NVARCHAR(256)

AS
BEGIN

		SET NOCOUNT ON

		SELECT

			*

		FROM

			tblStaffCU a

		WHERE 

			a.StaffName = @user AND a.StaffPassword = @pass

END