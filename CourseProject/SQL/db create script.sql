USE vapeshop;

CREATE TABLE contact_type(
id INT NOT NULL UNIQUE,
[name] NVARCHAR(30) NOT NULL,
CONSTRAINT PK_contact_type PRIMARY KEY(id)
)

CREATE TABLE person(
id INT NOT NULL UNIQUE,
first_name NVARCHAR(20) NOT NULL,
last_name NVARCHAR(20) NOT NULL,
surname NVARCHAR(20) NOT NULL,
date_of_birth DATE NOT NULL,
CONSTRAINT PK_person PRIMARY KEY(id)
);

CREATE TABLE customer(
id INT NOT NULL UNIQUE,
customer_id INT NOT NULL,
bonus_points INT DEFAULT 0,
[login] VARCHAR(20) NOT NULL
CHECK(LEN([login])>=5 and LEN([login])<=20),
[password] VARCHAR(15) NOT NULL
CHECK(LEN([password])>=6 and LEN([password])<=15),
CONSTRAINT PK_customer PRIMARY KEY(id),
CONSTRAINT FK_customer_person FOREIGN KEY (customer_id)
REFERENCES person(id)
);

CREATE TABLE employee(
id INT NOT NULL UNIQUE,
employee_id INT NOT NULL,
[login] VARCHAR(20) NOT NULL
CHECK(LEN([login])>=5 and LEN([login])<=20),
[password] VARCHAR(15) NOT NULL
CHECK(LEN([password])>=6 and LEN([password])<=15),
CONSTRAINT PK_employee PRIMARY KEY(id),
CONSTRAINT FK_employee_person FOREIGN KEY (employee_id)
REFERENCES person(id),
);

CREATE TABLE person_contact(
id INT NOT NULL UNIQUE,
contact_type_id INT NOT NULL,
person_id INT NOT NULL,
person_contact_value NVARCHAR(40) NOT NULL,
CONSTRAINT PK_person_contact PRIMARY KEY(id),
CONSTRAINT FK_person_contact_person FOREIGN KEY(person_id) REFERENCES person(id),
CONSTRAINT FK_person_contact_contact_type FOREIGN KEY(contact_type_id) REFERENCES contact_type(id)
);

CREATE TABLE product_category
(
id INT NOT NULL UNIQUE,
[name] NVARCHAR(30) NOT NULL,
CONSTRAINT PK_product_category PRIMARY KEY(id)
);

CREATE TABLE manufacturer(
id INT NOT NULL UNIQUE,
[name] NVARCHAR(30) NOT NULL,
CONSTRAINT PK_manufacturer PRIMARY KEY(id)
);

CREATE TABLE product(
id INT NOT NULL UNIQUE,
product_category_id INT NOT NULL,
manufacturer_id INT NOT NULL,
price MONEY DEFAULT 0,
comment NVARCHAR(256) DEFAULT 'empty',
CONSTRAINT PK_PRODUCT PRIMARY KEY(id),
CONSTRAINT FK_product_product_category FOREIGN KEY(product_category_id) REFERENCES product_category(id),
CONSTRAINT FK_product_manufacturer FOREIGN KEY(manufacturer_id) REFERENCES manufacturer(id)
);

CREATE TABLE product_amount(
id INT NOT NULL UNIQUE,
product_id INT NOT NULL,
product_amount_value INT DEFAULT 0,
CONSTRAINT PK_product_amount PRIMARY KEY(id),
CONSTRAINT FK_product_amount_product FOREIGN KEY(product_id) REFERENCES product(id)
);

CREATE TABLE customer_order(
id INT NOT NULL UNIQUE,
operation_time DATETIME DEFAULT GETDATE(),
customer_id INT NOT NULL,
CONSTRAINT PK_customer_order PRIMARY KEY(id),
CONSTRAINT FK_customer_customer_order FOREIGN KEY(customer_id) REFERENCES customer(id)
);

CREATE TABLE order_details(
id INT NOT NULL UNIQUE,
customer_order_id INT NOT NULL,
product_id INT NOT NULL,
price MONEY NOT NULL,
price_with_discount MONEY NOT NULL,
product_amount INT DEFAULT 1,
CONSTRAINT PK_order_details PRIMARY KEY(id),
CONSTRAINT FK_order_details_customer_order FOREIGN KEY(customer_order_id) REFERENCES customer_order(id) ON DELETE CASCADE,
CONSTRAINT FK_order_details_product FOREIGN KEY(customer_order_id) REFERENCES product(id)
)