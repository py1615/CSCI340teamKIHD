--drop procedure get_login
--drop procedure cancel
--drop procedure register_user
--drop procedure search
--drop procedure search_on_click
--drop procedure register_policy
--drop procedure add_beneficiary
--drop procedure calculation_data
--drop procedure get_inflation_rate
--drop procedure claim
--drop procedure get_payments
--drop procedure set_delinquent

CREATE PROCEDURE get_login (
@id NUMERIC(20),
@password VARCHAR(255))
AS
BEGIN
SET NOCOUNT ON;
SELECT user_type
FROM employee
WHERE id = @id and employee_password = @password
END
GO

CREATE PROCEDURE cancel (
@policy_number NUMERIC(30))
AS
BEGIN
SET NOCOUNT ON;
UPDATE client_policy
SET policy_status = 'C'
WHERE policy_number = @policy_number
END
GO

CREATE PROCEDURE register_user (
@username VARCHAR(20),
@first_name VARCHAR(100),
@last_name VARCHAR(100),
@password VARCHAR(255),
@user_type VARCHAR(1),
@department VARCHAR(50))
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
SELECT SCOPE_IDENTITY() AS agent_id;
END
GO

CREATE PROCEDURE search (
@policy_number NUMERIC(30),
@first_name VARCHAR(100),
@last_name VARCHAR(100),
@agent_id NUMERIC(20))
AS
BEGIN
SET NOCOUNT ON;
SELECT policy_number, policy_holder.first_name, policy_holder.last_name, agent_id, dob, policy_start, payoff_amount, monthly_premium, policy_status, employee.first_name, employee.last_name
FROM client_policy FULL OUTER JOIN policy_holder ON client_policy.policy_holder_id = policy_holder.policy_holder_id FULL OUTER JOIN employee ON agent_id = id
WHERE policy_number = @policy_number OR policy_holder.first_name = @first_name OR policy_holder.last_name = @last_name OR agent_id = @agent_id
END
GO

CREATE PROCEDURE search_on_click (
@policy_number NUMERIC(30))
AS
BEGIN
SET NOCOUNT ON;
SELECT *
FROM client_policy FULL OUTER JOIN policy_holder ON client_policy.policy_holder_id = policy_holder.policy_holder_id
WHERE policy_number = @policy_number
END
GO

CREATE PROCEDURE register_policy (
@first_name VARCHAR(100),
@last_name VARCHAR(100),
@street_address VARCHAR(30),
@city_address VARCHAR(20),
@state_address VARCHAR(2),
@zip_address VARCHAR(9),

@dob DATE,
@fathers_age_of_death VARCHAR(5),
@mothers_age_of_death VARCHAR(5),
@cigs_day NUMERIC(5),
@smoking_history VARCHAR(5),
@systolic_blood_pressure NUMERIC(4),
@avg_grams_fat_day NUMERIC(5),
@heart_disease BIT,
@cancer BIT,
@hospitalized BIT,
@dangerous_activities VARCHAR(255),
@agent_id NUMERIC(20),
@payoff_amount NUMERIC(10,2),
@monthly_premium NUMERIC(10,2))
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO policy_holder (
first_name,
last_name,
street_address,
city_address,
state_address,
zip_address)
VALUES (
@first_name,
@last_name,
@street_address,
@city_address,
@state_address,
@zip_address);
INSERT INTO client_policy (
policy_holder_id,
dob,
fathers_age_of_death,
mothers_age_of_death,
cigs_day,
smoking_history,
systolic_blood_pressure,
avg_grams_fat_day,
heart_disease,
cancer,
hospitalized,
dangerous_activities,
policy_start,
agent_id,
payoff_amount,
monthly_premium,
policy_status)
VALUES (
SCOPE_IDENTITY(),
@dob,
@fathers_age_of_death,
@mothers_age_of_death,
@cigs_day,
@smoking_history,
@systolic_blood_pressure,
@avg_grams_fat_day,
@heart_disease,
@cancer,
@hospitalized,
@dangerous_activities,
GETDATE(),
@agent_id,
@payoff_amount,
@monthly_premium,
'A');
SELECT SCOPE_IDENTITY() AS policy_number
END
GO

CREATE PROCEDURE add_beneficiary (
@policy_number NUMERIC(30),
@first_name VARCHAR(100),
@last_name VARCHAR(100))
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO beneficiary (
policy_number,
first_name,
last_name)
VALUES (
@policy_number,
@first_name,
@last_name)
END
GO

CREATE PROCEDURE calculation_data
AS
BEGIN
SET NOCOUNT ON;
SELECT dob, fathers_age_of_death, mothers_age_of_death, cigs_day, smoking_history, systolic_blood_pressure, avg_grams_fat_day, heart_disease, cancer, hospitalized, dangerous_activities, policy_end
FROM client_policy FULL OUTER JOIN policy_holder ON client_policy.policy_holder_id = policy_holder.policy_holder_id FULL OUTER JOIN payments ON client_policy.policy_number = payments.policy_number
WHERE payment_type = 'C'
END
GO

CREATE PROCEDURE get_inflation_rate (
@date_recorded DATE)
AS
BEGIN
SET NOCOUNT ON;
SELECT inflation
FROM inflation
WHERE date_recorded = @date_recorded
OR date_recorded = DATEADD(MONTH, -1, @date_recorded)
OR date_recorded = DATEADD(MONTH, -1, @date_recorded)
OR date_recorded = DATEADD(MONTH, -1, @date_recorded)
OR date_recorded = DATEADD(MONTH, -1, @date_recorded)
OR date_recorded = DATEADD(MONTH, -1, @date_recorded)
ORDER BY date_recorded ASC
END
GO

CREATE PROCEDURE claim (
@policy_number NUMERIC(30))
AS
BEGIN
SET NOCOUNT ON;
UPDATE client_policy
SET policy_status = 'I'
WHERE policy_number = @policy_number
DECLARE @total NUMERIC(10,2) = (SELECT SUM(amount) FROM payments)
DECLARE @payoff_amount NUMERIC(10,2) = (SELECT SUM(payoff_amount) FROM client_policy WHERE policy_number = @policy_number)
INSERT INTO payments (
date_paid,
policy_number,
amount,
payment_type)
SELECT
GETDATE(),
@policy_number,
@payoff_amount,
'C'
WHERE @total < @payoff_amount
END
GO

CREATE PROCEDURE get_payments (
@policy_number NUMERIC(30))
AS
BEGIN
SET NOCOUNT ON;
SELECT date_paid, amount
FROM payments
WHERE policy_number = @policy_number AND payment_type = 'P'
DECLARE @total NUMERIC(10,2) = (SELECT SUM(amount) FROM payments)
DECLARE @monthly_premium NUMERIC(10,2) = (SELECT SUM(Monthly_premium) FROM client_policy WHERE policy_number = @policy_number)
DECLARE @number_of_months NUMERIC(8) = (SELECT DATEDIFF(MONTH, policy_start, GETDATE()) FROM client_policy WHERE policy_number = @policy_number)
INSERT INTO delinquent (
policy_number,
delinquency_date)
SELECT
@policy_number,
GETDATE()
WHERE @total < monthly_premium * @number_of_months
END
GO