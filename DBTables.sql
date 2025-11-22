use LendingSystem


IF OBJECT_ID('dbo.TRANSACTIONS', 'U') IS NOT NULL DROP TABLE dbo.TRANSACTIONS;
IF OBJECT_ID('dbo.LOANS', 'U') IS NOT NULL DROP TABLE dbo.LOANS;
IF OBJECT_ID('dbo.LENDING_DETAILS', 'U') IS NOT NULL DROP TABLE dbo.LENDING_DETAILS;
IF OBJECT_ID('dbo.CUSTOMERS', 'U') IS NOT NULL DROP TABLE dbo.CUSTOMERS;
IF OBJECT_ID('dbo.ADMIN_USERS', 'U') IS NOT NULL DROP TABLE dbo.ADMIN_USERS;
IF OBJECT_ID('dbo.PAYMENT_SCHEDULES', 'U') IS NOT NULL DROP TABLE dbo.PAYMENT_SCHEDULES;
IF OBJECT_ID('dbo.INTEREST_RATES', 'U') IS NOT NULL DROP TABLE dbo.INTEREST_RATES;
GO


CREATE TABLE CUSTOMERS (
    customer_id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) UNIQUE NOT NULL,
    password_hash NVARCHAR(255) NOT NULL,
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50) NOT NULL,
    middle_initial NVARCHAR(5),
    contact_no NVARCHAR(20),
    created_at DATETIME DEFAULT GETDATE()
);

CREATE TABLE ADMIN_USERS (
    admin_id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) UNIQUE NOT NULL,
    password_hash NVARCHAR(255) NOT NULL,
    full_name NVARCHAR(100) NOT NULL,
    role NVARCHAR(50) DEFAULT 'Staff',
    created_at DATETIME DEFAULT GETDATE()
);

CREATE TABLE PAYMENT_SCHEDULES (
    schedule_id INT IDENTITY(1,1) PRIMARY KEY,
    schedule_name NVARCHAR(20) UNIQUE NOT NULL,
    payment_frequency_days INT NOT NULL
);

CREATE TABLE LOANS (
    loan_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT NOT NULL,
    schedule_id INT NOT NULL,
    principal_amount DECIMAL(10, 2) NOT NULL,
    interest_rate_percent DECIMAL(5, 2) NOT NULL,
    start_date DATE NOT NULL,
    due_date DATE NOT NULL,
    current_balance DECIMAL(10, 2) NOT NULL,
    status NVARCHAR(20) DEFAULT 'Active',

    FOREIGN KEY (customer_id) REFERENCES CUSTOMERS(customer_id) ON DELETE NO ACTION,
    FOREIGN KEY (schedule_id) REFERENCES PAYMENT_SCHEDULES(schedule_id) ON DELETE NO ACTION
);

CREATE TABLE TRANSACTIONS (
    transaction_id INT IDENTITY(1,1) PRIMARY KEY,
    loan_id INT NOT NULL,
    customer_id INT NOT NULL,
    transaction_type NVARCHAR(10) NOT NULL,
    transaction_date DATETIME DEFAULT GETDATE(),
    amount DECIMAL(10, 2) NOT NULL,
    principal_paid DECIMAL(10, 2) DEFAULT 0.00,
    interest_paid DECIMAL(10, 2) DEFAULT 0.00,
    notes NVARCHAR(255),

    FOREIGN KEY (loan_id) REFERENCES LOANS(loan_id) ON DELETE NO ACTION,
    FOREIGN KEY (customer_id) REFERENCES CUSTOMERS(customer_id) ON DELETE NO ACTION
);

CREATE TABLE INTEREST_RATES (
    rate_id INT IDENTITY(1,1) PRIMARY KEY,
    interest_rate_percent DECIMAL(5, 2) NOT NULL,
    valid_from DATE NOT NULL,                     
    valid_until DATE,                           
    
    UNIQUE (interest_rate_percent, valid_from) 
);
GO

INSERT INTO PAYMENT_SCHEDULES (schedule_name, payment_frequency_days) VALUES ('Weekly', 7), ('Monthly', 30);

INSERT INTO CUSTOMERS (username, password_hash, first_name, last_name, contact_no)
VALUES ('user1', 'placeholder_hash', 'Rhea', 'Almelda', '09171234567');

INSERT INTO LOANS (customer_id, schedule_id, principal_amount, interest_rate_percent, start_date, due_date, current_balance)
VALUES (1, 2, 10000.00, 5.00, GETDATE(), DATEADD(day,30,GETDATE()), 10500.00);


DECLARE @Principal DECIMAL(10, 2) = 10000.00;
DECLARE @Rate DECIMAL(5, 2) = 5.00;
DECLARE @Interest DECIMAL(10, 2) = @Principal * (@Rate / 100.00); -- 500.00
DECLARE @TotalDue DECIMAL(10, 2) = @Principal + @Interest; -- 10500.00

INSERT INTO LOANS (customer_id, schedule_id, principal_amount, interest_rate_percent, start_date, due_date, total_interest, total_due_at_start, current_balance)
VALUES (
    1, 
    (SELECT schedule_id FROM PAYMENT_SCHEDULES WHERE schedule_name = 'Monthly'), 
    @Principal, 
    @Rate, 
    GETDATE(), 
    DATEADD(day, 30, GETDATE()), 
    @Interest, 
    @TotalDue, 
    @TotalDue
);

SELECT * FROM LOANS