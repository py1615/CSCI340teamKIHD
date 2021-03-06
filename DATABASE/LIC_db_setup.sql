--drop table inflation
--drop table beneficiary
--drop table payments
--drop table delinquent
--drop table client_policy
--drop table policy_holder
--drop table employee

--INSERT DUMMY EMPLOYEES ARE AT THE BOTTOM OF THIS PAGE!

CREATE TABLE employee (
id NUMERIC(20) NOT NULL IDENTITY PRIMARY KEY,
username varchar(20),
first_name VARCHAR(100),
last_name VARCHAR(100),
employee_password VARCHAR(255),
user_type VARCHAR(1),
department VARCHAR(50));

CREATE TABLE policy_holder (
policy_holder_id NUMERIC(20) NOT NULL IDENTITY PRIMARY KEY,
first_name VARCHAR(100),
last_name VARCHAR(100),
street_address VARCHAR(30),
city_address VARCHAR(20),
state_address VARCHAR(2),
zip_address VARCHAR(9));

CREATE TABLE client_policy (
policy_number NUMERIC(30) NOT NULL IDENTITY PRIMARY KEY,
policy_holder_id NUMERIC(20),
dob DATE,
fathers_age_of_death VARCHAR(5),
mothers_age_of_death VARCHAR(5),
cigs_day NUMERIC(5),
smoking_history VARCHAR(5),
systolic_blood_pressure NUMERIC(4),
avg_grams_fat_day NUMERIC(5),
--USE A 1 FOR 'Y' AND A 0 FOR 'N'
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

CREATE TABLE delinquent (
policy_number NUMERIC(30) NOT NULL PRIMARY KEY,
delinquency_date DATE
FOREIGN KEY (policy_number) REFERENCES client_policy(policy_number));

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
CONSTRAINT PK_beneficiary PRIMARY KEY (policy_number, first_name, last_name),
FOREIGN KEY (policy_number) REFERENCES client_policy(policy_number));

CREATE TABLE inflation (
date_recorded DATE NOT NULL PRIMARY KEY,
inflation NUMERIC(8,4));

--AGENT LEVEL USER!
--set identity_insert employee on; insert into employee (id, employee_password, user_type) values (0, '0', 'A'); set identity_insert employee off;

--MANAGER LEVEL USER!
--set identity_insert employee on; insert into employee (id, employee_password, user_type) values (1, '1', 'M'); set identity_insert employee off;
