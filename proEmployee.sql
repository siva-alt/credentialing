create procedure  proemployee
@EmployeeID int ,
@EmployeeName VARCHAR(50),
@EmployeeAddress VARCHAR(50),
@EmployeeGender TINYINT
AS
	IF @EmployeeID=0
	BEGIN
		INSERT INTO [dbo].[Employee]
           ([EmployeeName]
           ,[EmployeeAddress]
           ,[EmployeeGender])
	   VALUES
           (@EmployeeName,
           @EmployeeAddress,
           @EmployeeGender)

	END
	ELSE 
	BEGIN
		
	UPDATE [dbo].[Employee]
		SET [EmployeeName] = @EmployeeName
		,[EmployeeAddress]=  @EmployeeAddress
		,[EmployeeGender] = @EmployeeGender
	 WHERE EmployeeID=@EmployeeID



	END


--CREATE PROCEDURE ViewAllEmployee
--AS
--	SELECT * FROM dbo.Employee

	CREATE PROCEDURE EmployeeViesByID
	@EmployeeID INT
AS
	SELECT * FROM dbo.Employee WHERE EmployeeID=@EmployeeID

	proemployee --> INSERT AND UPDATE

		CREATE PROCEDURE EmployeeDeleteByID
	@EmployeeID INT
AS
	DELETE FROM dbo.Employee WHERE EmployeeID=@EmployeeID