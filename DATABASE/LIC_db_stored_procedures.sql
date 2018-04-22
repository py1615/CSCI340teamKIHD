CREATE PROCEDURE get_login (@id varchar(20), @password varchar(255))
AS
BEGIN
SET NOCOUNT ON;
SELECT user_type
FROM dbo.employee
WHERE id = @id and employee_password = @password
END
GO

CREATE PROCEDURE cancel (@policy_number varchar(30))
AS
BEGIN
SET NOCOUNT ON;

END
GO

CREATE PROCEDURE register_user (@policy_number varchar(30))
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO dbo.employee (id,
first_name,
last_name,
user_type,
department,
employee_password)

END
GO