--drop table beneficiary
--drop table payments
--drop table client_policy
--drop table policy_holder
--drop table employee

CREATE TABLE employee (
id NUMERIC(20) NOT NULL IDENTITY PRIMARY KEY,
username varchar(20),
first_name VARCHAR(100),
last_name VARCHAR(100),
employee_password VARCHAR(255),
user_type VARCHAR(1),
department VARCHAR(50));

CREATE TABLE policy_holder (
policy_holder_id NUMERIC(30) NOT NULL IDENTITY PRIMARY KEY,
first_name VARCHAR(100),
last_name VARCHAR(100),
street_address VARCHAR(30),
city_address VARCHAR(20),
state_address VARCHAR(2),
zip_address VARCHAR(9));

CREATE TABLE client_policy (
policy_number NUMERIC(30) NOT NULL IDENTITY PRIMARY KEY,
policy_holder_id NUMERIC(30),
dob DATE,
fathers_age_of_death VARCHAR(5),
mothers_age_of_death VARCHAR(5),
cigs_day VARCHAR(5),
smoking_history VARCHAR(5),
systolic_blood_pressure VARCHAR(4),
avg_grams_fat_day VARCHAR(5),
heart_disease BIT,
cancer BIT,
hospitalized BIT,
dangerous_activities VARCHAR(255),
policy_start DATE,
policy_end DATE,
agent_id NUMERIC(20),
payoff_amount NUMERIC(10,2),
monthly_premium NUMERIC(10,2),
policy_status VARCHAR(1),
FOREIGN KEY (policy_holder_id) REFERENCES policy_holder(policy_holder_id),
FOREIGN KEY (agent_id) REFERENCES employee(id));

CREATE TABLE payments (
date_paid DATETIME NOT NULL,
policy_number NUMERIC(30) NOT NULL,
amount NUMERIC(10,2),
payment_type VARCHAR(1),
CONSTRAINT PK_payments PRIMARY KEY (policy_number, date_paid),
FOREIGN KEY (policy_number) REFERENCES client_policy(policy_number));

CREATE TABLE beneficiary (
policy_number NUMERIC(30) NOT NULL,
first_name VARCHAR(100),
last_name VARCHAR(100),
PRIMARY KEY (policy_number),
FOREIGN KEY (policy_number) REFERENCES client_policy(policy_number));