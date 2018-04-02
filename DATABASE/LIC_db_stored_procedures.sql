CREATE PROCEDURE login (@id varchar(30), @password varchar(255))
AS
BEGIN
SET NOCOUNT ON;
SELECT id, employee_password
FROM dbo.employee
WHERE id = @id and employee_password = @password
END
GO
