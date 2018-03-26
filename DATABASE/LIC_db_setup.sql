create table employee (
ID varchar(20) NOT NULL,
first_name varchar(100),
last_name varchar(100),
user_type varchar(1),
department varchar(50),
employee_password varchar(255),
PRIMARY KEY (ID)
);

create table payments (
policy_number varchar(30) NOT NULL,
date_paid datetime NOT NULL,
amount varchar(10),
payment_type varchar(1),
CONSTRAINT PK_payments PRIMARY KEY (policy_number, date_paid),
FOREIGN KEY date_paid REFERENCES client_policy(payments)
);

create table client_policy (
policy_number varchar(30) NOT NULL,
first_name varchar(100),
last_name varchar(100),
dob date,
fathers_aod date,
mothers_aod date,
cigs_day varchar(5),
smoking_history date,
sbp varchar(4),
avg_grams_fat_day varchar(5),
heart_disease varchar(1),
cancer varchar(1),
hospitalized varchar(1),
dangerous_activities varchar(255),
policy_start date,
policy_end date,
agent_id varchar(20),
payoff_amount varchar(10),
monthly_premium varchar(10),
PRIMARY KEY (policy_number),
FOREIGN KEY agent_id REFERENCES employee(agent_id)
);

create table beneficiary (
policy_number varchar(20) NOT NULL,
first_name varchar(100),
last_name varchar(100),
PRIMARY KEY (policy_number),
FOREIGN KEY (policy_number) REFERENCES client_policy(policy_number)
);