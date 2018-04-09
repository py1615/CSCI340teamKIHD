CREATE PROCEDURE login (@id varchar(20), @password varchar(255))
AS
BEGIN
SET NOCOUNT ON;
SELECT id, employee_password, user_type
FROM dbo.employee
WHERE id = @id and employee_password = @password
END
GO

CREATE PROCEDURE cancel (@policy_number varchar(30))
AS
BEGIN
SET NOCOUNT ON;
