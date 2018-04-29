--drop procedure get_login
--drop procedure cancel
--drop procedure register_user
--drop procedure search
--drop procedure search_on_click
--drop procedure register_policy
--drop procedure add_beneficiary
--drop procedure calculation_data

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
SELECT policy_number, first_name, last_name, agent_id, dob, policy_start, payoff_amount, monthly_premium
FROM client_policy FULL OUTER JOIN policy_holder ON client_policy.policy_holder_id = policy_holder.policy_holder_id
WHERE policy_number = @policy_number OR first_name = @first_name OR last_name = @last_name OR agent_id = @agent_id
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
@cigs_day VARCHAR(5),
@smoking_history VARCHAR(5),
@systolic_blood_pressure VARCHAR(4),
@avg_grams_fat_day VARCHAR(5),
@heart_disease BIT,
@cancer BIT,
@hospitalized BIT,
@dangerous_activities VARCHAR(255),
@agent_id NUMERIC(20))
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
@agent_id);
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
FROM client_policy FULL OUTER JOIN policy_holder ON client_policy.policy_holder_id = policy_holder.policy_holder_id FULL OUT JOIN payments ON client_policy.policy_number = payments.policy_number
WHERE payment_type = 'C'
END
GO