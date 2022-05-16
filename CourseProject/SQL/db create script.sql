CREATE TABLE [user](
id INT NOT NULL primary key identity(1,1),
initials nvarchar(max) collate Cyrillic_General_CI_AS null,
[login] VARCHAR(20) NOT NULL,
[password] VARCHAR(15) NOT NULL
);

CREATE TABLE product_category
(
id INT NOT NULL primary key identity(1,1),
[name] NVARCHAR(30) NOT NULL
);

CREATE TABLE manufacturer(
id INT NOT NULL primary key identity(1,1),
[name] NVARCHAR(30) NOT NULL
);

CREATE TABLE product(
id INT NOT NULL primary key identity(1,1),
product_category_id INT NOT NULL,
manufacturer_id INT NOT NULL,
price MONEY DEFAULT 0,
comment NVARCHAR(256) DEFAULT 'empty',
CONSTRAINT FK_product_product_category FOREIGN KEY(product_category_id) REFERENCES product_category(id),
CONSTRAINT FK_product_manufacturer FOREIGN KEY(manufacturer_id) REFERENCES manufacturer(id)
);

CREATE TABLE product_amount(
id INT NOT NULL primary key identity(1,1),
product_id INT NOT NULL,
product_amount_value INT DEFAULT 0,
CONSTRAINT FK_product_amount_product FOREIGN KEY(product_id) REFERENCES product(id)
);

CREATE TABLE customer_order(
id INT NOT NULL primary key identity(1,1),
operation_time DATETIME DEFAULT GETDATE(),
customer_id INT NOT NULL,
CONSTRAINT FK_customer_customer_order FOREIGN KEY(customer_id) REFERENCES customer(id)
);

CREATE TABLE order_details(
id INT NOT NULL primary key identity(1,1),
customer_order_id INT NOT NULL,
product_id INT NOT NULL,
price MONEY NOT NULL,
price_with_discount MONEY NOT NULL,
product_amount INT DEFAULT 1,
CONSTRAINT FK_order_details_customer_order FOREIGN KEY(customer_order_id) REFERENCES customer_order(id) ON DELETE CASCADE,
CONSTRAINT FK_order_details_product FOREIGN KEY(customer_order_id) REFERENCES product(id)
)
