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

CREATE PROCEDURE search (@policy_number varchar(30), @first_name varchar(100), @last_name varchar(100), @agent_id varchar(20))
AS
BEFIN
SET NOCOUNT ON;
SELECT * FROM client_policy
WHERE policy_number = @policy_number OR first_name = @first_name OR last_name = @last_name OR agent_id = @agent_id
END
GO
