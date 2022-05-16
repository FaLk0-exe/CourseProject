CREATE VIEW ProductView AS
SELECT
product.[name] as 'Name',
product_category.[name] as 'Category',
manufacturer.[name] as 'Manufacturer',
price,
comment,
product_amount.product_amount_value
FROM product JOIN product_category ON product.product_category_id = product_category.id
JOIN manufacturer ON product.manufacturer_id=manufacturer.id
JOIN product_amount ON product_amount.product_id=product.id;