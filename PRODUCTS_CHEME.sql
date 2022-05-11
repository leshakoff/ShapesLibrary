CREATE TABLE Products (
	Id INT NOT NULL PRIMARY KEY,
	Name NVARCHAR(200)
)

INSERT INTO Products VALUES
(1, 'Жвачка'), 
(2, 'Шоколад'), 
(3, 'Мармелад'), 
(4, 'Сок'),
(5, 'Сигареты'), 
(6, 'Стулья')

CREATE TABLE Categories (
	Id INT NOT NULL PRIMARY KEY,
	Name NVARCHAR(200)
)

INSERT INTO Categories VALUES
(1, 'Сладкое'),
(2, 'Шоколад'),
(3, 'Прочее')

CREATE TABLE ProductCategories (
	Id INT NOT NULL PRIMARY KEY,
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id)
)

INSERT INTO ProductCategories VALUES
(1, 1, 1), 
(2, 2, 1), 
(3, 2, 2), 
(4, 3, 1), 
(5, 4, 1), 
(6, 4, 3), 
(7, 5, 3)



SELECT p."Name" as 'PRODUCTS', c."Name" as 'CATEGORIES'
FROM Products p
LEFT JOIN ProductCategories pc
	ON p.Id = pc.ProductId
LEFT JOIN Categories c
	ON pc.CategoryId = c.Id;
