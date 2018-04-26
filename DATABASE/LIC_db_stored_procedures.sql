CREATE PROCEDURE get_login (@id NUMERIC(20), @password VARCHAR(255))
AS
BEGIN
SET NOCOUNT ON;
SELECT user_type
FROM employee
WHERE id = @id and employee_password = @password
END
GO

CREATE PROCEDURE cancel (@policy_number NUMERIC(30))
AS
BEGIN
SET NOCOUNT ON;
UPDATE client_policy
SET policy_status = 'C'
WHERE policy_number = @policy_number
END
GO

CREATE PROCEDURE register_user (@username VARCHAR(20), @first_name VARCHAR(100), @last_name VARCHAR(100), @password VARCHAR(255), @user_type VARCHAR(1), @department VARCHAR(50))
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO employee (
username,
first_name,
last_name,
employee_password,
user_type,
department)
VALUES (
@username,
@first_name,
@last_name,
@password,
@user_type,
@department)
END
GO

CREATE PROCEDURE search (@policy_number NUMERIC(30), @first_name VARCHAR(100), @last_name VARCHAR(100), @agent_id NUMERIC(20))
AS
BEGIN
SET NOCOUNT ON;
SELECT policy_number, first_name, last_name, agent_id, dob, policy_start, payoff_amount, monthly_premium
FROM client_policy FULL OUTER JOIN policy_holder ON client_policy.policy_holder_id = policy_holder.policy_holder_id
WHERE policy_number = @policy_number OR first_name = @first_name OR last_name = @last_name OR agent_id = @agent_id
END
GO

CREATE PROCEDURE search_on_click (@policy_number NUMERIC(30))
AS
BEGIN
SET NOCOUNT ON;
SELECT *
FROM client_policy FULL OUTER JOIN policy_holder ON client_policy.policy_holder_id = policy_holder.policy_holder_id
WHERE policy_number = @policy_number
END
GO