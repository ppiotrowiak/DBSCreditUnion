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