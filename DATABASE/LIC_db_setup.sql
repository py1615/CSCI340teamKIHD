CREATE TABLE employee (
id VARCHAR(20) NOT NULL,
first_name VARCHAR(100),
last_name VARCHAR(100),
user_type VARCHAR(1),
department VARCHAR(50),
employee_password VARCHAR(255),
PRIMARY KEY (id)
);

CREATE TABLE client_policy (
policy_number VARCHAR(30) NOT NULL,
first_name VARCHAR(100),
last_name VARCHAR(100),
dob DATE,
fathers_aod VARCHAR(5),
mothers_aod VARCHAR(5),
cigs_day VARCHAR(5),
smoking_history DATE,
sbp VARCHAR(4),
avg_grams_fat_day VARCHAR(5),
heart_disease VARCHAR(1),
cancer VARCHAR(1),
hospitalized VARCHAR(1),
dangerous_activities VARCHAR(255),
policy_start DATE,
policy_end DATE,
agent_id VARCHAR(20),
payoff_amount VARCHAR(10),
monthly_premium VARCHAR(10),
PRIMARY KEY (policy_number),
FOREIGN KEY (agent_id) REFERENCES employee(id)
);

CREATE TABLE deliquent (
policy_number VARCHAR(30) NOT NULL,
first_name VARCHAR(100),
last_name VARCHAR(100),
dob DATE,
fathers_aod VARCHAR(5),
mothers_aod VARCHAR(5),
cigs_day VARCHAR(5),
smoking_history DATE,
sbp VARCHAR(4),
avg_grams_fat_day VARCHAR(5),
heart_disease VARCHAR(1),
cancer VARCHAR(1),
hospitalized VARCHAR(1),
dangerous_activities VARCHAR(255),
policy_start DATE,
policy_end DATE,
agent_id VARCHAR(20),
payoff_amount VARCHAR(10),
monthly_premium VARCHAR(10),
PRIMARY KEY (policy_number),
FOREIGN KEY (agent_id) REFERENCES employee(id)
);

CREATE TABLE payments (
policy_number VARCHAR(30) NOT NULL,
date_paid DATETIME NOT NULL,
amount VARCHAR(10),
payment_type VARCHAR(1),
CONSTRAINT PK_payments PRIMARY KEY (policy_number, date_paid),
FOREIGN KEY (policy_number) REFERENCES client_policy(policy_number)
);

CREATE TABLE beneficiary (
policy_number VARCHAR(30) NOT NULL,
first_name VARCHAR(100),
last_name VARCHAR(100),
PRIMARY KEY (policy_number),
FOREIGN KEY (policy_number) REFERENCES client_policy(policy_number)
);

CREATE TABLE policy_holder (
policy_holder_id VARCHAR(30) NOT NULL,
first_name VARCHAR(100),
last_name VARCHAR(100),
street_address VARCHAR(30),
city_address VARCHAR(20),
state_address VARCHAR(2),
zip_address VARCHAR(9),
PRIMARY KEY (policy_holder_id)
);