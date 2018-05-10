--drop procedure get_login
--drop procedure cancel
--drop procedure register_user
--drop procedure search
--drop procedure search_on_click
--drop procedure get_beneficiary
--drop procedure register_policy
--drop procedure add_beneficiary
--drop procedure calculation_data
--drop procedure get_inflation_rate
--drop procedure claim
--drop procedure get_payments

CREATE PROCEDURE get_login (
@id VARCHAR(20),
@password VARCHAR(255))
AS
BEGIN
SET NOCOUNT ON;

SELECT user_type
FROM employee
WHERE id = CONVERT(NUMERIC(20), @id) AND employee_password = @password;

END
GO

CREATE PROCEDURE cancel (
@policy_number VARCHAR(30))
AS
BEGIN
SET NOCOUNT ON;

UPDATE client_policy
SET policy_status = 'C'
WHERE policy_number = CONVERT(NUMERIC(30), @policy_number);

UPDATE client_policy
SET policy_end = GETDATE()
WHERE policy_number = CONVERT(NUMERIC(30), @policy_number);

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
@department);

SELECT CONVERT(VARCHAR(20), SCOPE_IDENTITY()) AS id;

END
GO

CREATE PROCEDURE search (
@policy_number VARCHAR(30),
@first_name VARCHAR(100),
@last_name VARCHAR(100),
@agent_first VARCHAR(100),
@agent_last VARCHAR(100),
@agent_id VARCHAR(20))
AS
BEGIN
SET NOCOUNT ON;

SELECT
CONVERT(VARCHAR(30), policy_number) AS policy_number,
policy_holder.first_name AS policy_holder_first_name,
policy_holder.last_name AS policy_holder_last_name,
CONVERT(VARCHAR(20), agent_id) AS agent_id,
dob,
policy_start,
payoff_amount,
monthly_premium,
policy_status,
employee.first_name AS agent_first_name,
employee.last_name AS agent_last_name
FROM client_policy FULL OUTER JOIN policy_holder ON client_policy.policy_holder_id = policy_holder.policy_holder_id FULL OUTER JOIN employee ON agent_id = id
WHERE --policy_number = @policy_number or agent_id = @agent_id or policy_holder.first_name = @first_name or policy_holder.last_name = @last_name
--or employee.first_name = @agent_first or employee.last_name = @agent_last

(id = CONVERT(VARCHAR(20), @agent_id) OR ISNULL(@agent_id, '') = '') AND

policy_number = CONVERT(NUMERIC(30), @policy_number)
OR ((policy_number = CONVERT(NUMERIC(30), @policy_number) OR ISNULL(@policy_number, '') = '')
AND (agent_id = CONVERT(VARCHAR(20), @agent_id) OR ISNULL(@agent_id, '') = '')
AND ((policy_holder.first_name = @first_name AND policy_holder.last_name = @last_name)
OR (policy_holder.first_name = @first_name AND ISNULL(@last_name, '') = '')
OR (ISNULL(@first_name, '') = '' AND policy_holder.last_name = @last_name)
OR (ISNULL(@first_name, '') = '' AND ISNULL(@last_name, '') = '')));

END
GO

CREATE PROCEDURE search_on_click (
@policy_number VARCHAR(30))
AS
BEGIN
SET NOCOUNT ON;

SELECT
CONVERT(VARCHAR(20), policy_holder.policy_holder_id) AS policy_holder_id,
policy_holder.first_name AS policy_holder_first_name,
policy_holder.last_name AS policy_holder_last_name,
street_address,
city_address,
state_address,
zip_address,
CONVERT(VARCHAR(30), policy_number) AS policy_number,

dob,
fathers_age_of_death,
mothers_age_of_death,
cigs_day,
smoking_history,
systolic_blood_pressure,
avg_grams_fat_day,
heart_disease,
cancer ,
hospitalized,
dangerous_activities,
policy_start,
policy_end,
CONVERT(VARCHAR(20), agent_id) AS agent_id,
payoff_amount,
monthly_premium,
policy_status,
username,
employee.first_name AS agent_first_name,
employee.last_name AS agent_last_name,
user_type,
department
FROM client_policy FULL OUTER JOIN policy_holder ON client_policy.policy_holder_id = policy_holder.policy_holder_id FULL OUTER JOIN employee ON agent_id = id
WHERE policy_number = CONVERT(NUMERIC(30), @policy_number);

END
GO

CREATE PROCEDURE get_beneficiary (
@policy_number VARCHAR(30))
AS
BEGIN
SET NOCOUNT ON;

SELECT *
FROM beneficiary
WHERE policy_number = CONVERT(NUMERIC(30), @policy_number);

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
@agent_id VARCHAR(20),
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
CONVERT(NUMERIC(20), @agent_id),
@payoff_amount,
@monthly_premium,
'A');

SELECT CONVERT(VARCHAR(30), SCOPE_IDENTITY()) AS policy_number;

END
GO

CREATE PROCEDURE add_beneficiary (
@policy_number VARCHAR(30),
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
CONVERT(NUMERIC(30), @policy_number),
@first_name,
@last_name);

END
GO

CREATE PROCEDURE calculation_data
AS
BEGIN
SET NOCOUNT ON;

SELECT
dob,
fathers_age_of_death,
mothers_age_of_death,
cigs_day, smoking_history,
systolic_blood_pressure,
avg_grams_fat_day,
heart_disease, cancer,
hospitalized,
dangerous_activities,
policy_end
FROM client_policy FULL OUTER JOIN policy_holder ON client_policy.policy_holder_id = policy_holder.policy_holder_id
FULL OUTER JOIN payments ON client_policy.policy_number = payments.policy_number
WHERE payment_type = 'C';

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
ORDER BY date_recorded ASC;

END
GO

CREATE PROCEDURE claim (
@policy_number VARCHAR(30))
AS
BEGIN
SET NOCOUNT ON;

UPDATE client_policy
SET policy_status = 'I'
WHERE policy_number = CONVERT(NUMERIC(30), @policy_number);

UPDATE client_policy
SET policy_end = GETDATE()
WHERE policy_number = CONVERT(NUMERIC(30), @policy_number);

DECLARE @total NUMERIC = (SELECT SUM(amount / inflation) FROM payments
FULL OUTER JOIN inflation ON date_paid > date_recorded AND date_paid <= DATEADD(MONTH, 1, date_recorded) WHERE policy_number = CONVERT(NUMERIC(30), @policy_number))
DECLARE @payoff_amount NUMERIC = (SELECT SUM(payoff_amount) FROM client_policy WHERE policy_number = CONVERT(NUMERIC(30), @policy_number))
DECLARE @current_inflation NUMERIC = (SELECT SUM(inflation) FROM inflation WHERE GETDATE() >= date_recorded AND GETDATE() < DATEADD(MONTH, 1, date_recorded))
DECLARE @total_with_inflation NUMERIC = @total * @current_inflation
INSERT INTO payments (
date_paid,
policy_number,
amount,
payment_type)
SELECT
GETDATE(),
CONVERT(NUMERIC(30), @policy_number),
@payoff_amount,
'C'
WHERE @payoff_amount < 0.05 * @payoff_amount + @total_with_inflation;

SELECT @total_with_inflation, @payoff_amount
FROM payments
WHERE policy_number = CONVERT(NUMERIC(30), @policy_number);

END
GO

CREATE PROCEDURE get_payments (
@policy_number VARCHAR(30))
AS
BEGIN
SET NOCOUNT ON;

SELECT date_paid, amount
FROM payments
WHERE policy_number = CONVERT(NUMERIC(30), @policy_number) AND payment_type = 'P';

DECLARE @total NUMERIC = (SELECT SUM(amount) FROM payments WHERE policy_number = CONVERT(NUMERIC(30), @policy_number))
DECLARE @monthly_premium NUMERIC = (SELECT SUM(monthly_premium) FROM client_policy WHERE policy_number = CONVERT(NUMERIC(30), @policy_number))
DECLARE @number_of_months NUMERIC = (SELECT DATEDIFF(MONTH, policy_start, GETDATE()) FROM client_policy WHERE policy_number = CONVERT(NUMERIC(30), @policy_number))
INSERT INTO delinquent (
policy_number,
delinquency_date)
SELECT
CONVERT(NUMERIC(30), @policy_number),
GETDATE()
WHERE @total < @monthly_premium * @number_of_months;

UPDATE client_policy
SET policy_status = 'D'
WHERE policy_number = CONVERT(NUMERIC(30), @policy_number);

END
GO