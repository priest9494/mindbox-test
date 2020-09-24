CREATE TABLE categories (id SERIAL PRIMARY KEY, name VARCHAR(30));

CREATE TABLE products (id SERIAL PRIMARY KEY, name VARCHAR(30));

CREATE TABLE pairs (product_id int, category_id int);

INSERT INTO categories(name) VALUES ('a'), ('b'), ('c'), ('d');

INSERT INTO products(name) VALUES ('aa'), ('bb'), ('cc'), ('dd');

INSERT INTO pairs VALUES ('1', '1'), ('1', '2'), ('1', '3'), ('1', '4'), ('2', '1'), ('3', '1'), ('3', '4');

SELECT products.name, categories.name FROM products
LEFT JOIN pairs ON products.id = pairs.product_id
LEFT JOIN categories ON categories.id = pairs.category_id;