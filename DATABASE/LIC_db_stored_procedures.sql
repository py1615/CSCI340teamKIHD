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
INSERT INTO delinquent (policy_number,
first_name,
last_name,
dob,
fathers_age_of_death,
mothers_afe_of_death,
cigs_day,
smoking_history,
systolic_blood_pressure,
avg_grams_fat_day,
heart_disease,
cancer,
hospitalized,
dangerous_activities,
policy_start,
policy_end,
agent_id,
payoff_amount,
monthly_premium)
SELECT *
FROM dbo.policy
WHERE policy_number = @policy_number
END
GO
