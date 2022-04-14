--EXEMPLO DE DOIS INNER JOIN, COM TRÊS TABELAS
SELECT * FROM Products AS P 
INNER JOIN Categories AS C 
ON P.CategoryID = C.CategoryID
INNER JOIN Suppliers AS S
on S.SupplierID = P.SupplierID

--*******************************************************
--*********************GROUP BY**************************
--*******************************************************
--Executa a função na coluna escolhida em linha, de cada produto (fornecedor) 

--QUANTIDADE DE TIPOS DE BEBIDAS
SELECT COUNT(*) AS TIPOS FROM Products WHERE CategoryID = 1;

--QUANTIDADE DE BEBIDAS NO ESTOQUE DA CATEGORIA 1
SELECT SUM(UnitsInStock) AS BEBIDAS FROM Products WHERE CategoryID = 1;

--VALOR TOTAL DO PREÇO DAS BEBIDAS DA CATEGORIA 1
SELECT SUM(UnitsInStock*UnitPrice) AS VALOR_TOTAL FROM Products WHERE CategoryID = 1;

--QUANTIDADES DE BEBIDAS POR CATEGORIA
SELECT COUNT(*) AS QUANTIDADES FROM Products GROUP BY CategoryID;

--SOMAR O PREÇO PARA CADA CATEGORIA 
SELECT SUM(UnitsInStock*UnitPrice) AS VALOR_TOTAL FROM Products GROUP BY CategoryID;

--CONTAR A QUANTIDADE DE PRODUTOS DOS FORNECEDORES
SELECT COUNT(*) AS QUANTIDADES FROM Products GROUP BY SupplierID;

--VERSÃO COM NOMES

--QUANTIDADES DE BEBIDAS POR CATEGORIA
SELECT C.CategoryName, COUNT(*) AS TIPOS FROM Products AS P 
INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID 
GROUP BY C.CategoryName;

--SOMAR O PREÇO PARA CADA CATEGORIA 
SELECT C.CategoryName, SUM(UnitsInStock*UnitPrice) AS VALOR_TOTAL FROM Products AS P
INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID 
GROUP BY C.CategoryName;

--CONTAR A QUANTIDADE DE PRODUTOS DOS FORNECEDORES
SELECT S.CompanyName, COUNT(*) AS QUANTIDADES FROM Products AS P
INNER JOIN Suppliers AS S ON P.SupplierID = S.SupplierID 
GROUP BY S.CompanyName;

--CONTAR A QUANTIDADE DE PEDIDO DOS CLIENTES
SELECT C.CompanyName, COUNT(*) AS QUANTIDADES FROM Orders AS O
INNER JOIN Customers AS C ON C.CustomerID = O.CustomerID 
GROUP BY C.CompanyName;

--CONTAR A QUANTIDADE DE PEDIDO DOS CLIENTES, INCLUINDO NOME DOS CLIENTES
SELECT C.CompanyName, C.ContactName, COUNT(*) AS QUANTIDADES FROM Orders AS O
INNER JOIN Customers AS C ON C.CustomerID = O.CustomerID 
GROUP BY C.CompanyName, C.ContactName;

--CONTE A QUANTIDADE DE PEDIDOS DOS EMPREGADOS
SELECT E.FirstName, COUNT(*) AS QUANTIDADES FROM Employees AS E
INNER JOIN Orders AS  O ON  O.EmployeeID = E.EmployeeID 
GROUP BY E.FirstName;

--CONTE A QUANTIDADE DE PEDIDOS POR PAÍS
SELECT C.Country, COUNT(*) AS QUANTIDADES FROM Orders AS O
INNER JOIN Customers AS C ON C.CustomerID = O.CustomerID 
GROUP BY C.Country;

--somar o valor dos pedidos por clientes
SELECT C.CompanyName, C.ContactName, SUM(UnitPrice*Quantity) AS Valores FROM Orders AS O
INNER JOIN Customers AS C ON C.CustomerID = O.CustomerID 
INNER JOIN [Order details] AS OD ON O.orderid = OD.orderid 
GROUP BY C.CompanyName,C.ContactName;

--somar o valor dos pedidos por país
SELECT C.Country, SUM(UnitPrice*Quantity) AS Valores FROM Orders AS O
INNER JOIN Customers AS C ON C.CustomerID = O.CustomerID 
INNER JOIN [Order details] AS OD ON O.orderid = OD.orderid 
GROUP BY C.Country;

--somar o valor dos pedidos por país e clientes ordenados por alfabeto
SELECT C.Country, C.ContactName, SUM(UnitPrice*Quantity) AS Valores FROM Orders AS O
INNER JOIN Customers AS C ON C.CustomerID = O.CustomerID 
INNER JOIN [Order details] AS OD ON O.orderid = OD.orderid 
GROUP BY C.Country,C.ContactName ORDER BY C.ContactName;

--somar o valor dos pedidos por país e clientes ordenados por ordem de valores crescentes
SELECT C.Country, C.ContactName, SUM(UnitPrice*Quantity) AS Valores FROM Orders AS O
INNER JOIN Customers AS C ON C.CustomerID = O.CustomerID 
INNER JOIN [Order details] AS OD ON O.orderid = OD.orderid 
GROUP BY C.Country,C.ContactName ORDER BY Valores;

--somar o valor dos pedidos por empregados
SELECT FirstName, SUM(UnitPrice*Quantity) AS Valores FROM Orders AS O
INNER JOIN Customers AS C ON C.CustomerID = O.CustomerID 
INNER JOIN [Order details] AS OD ON O.orderid = OD.orderid 
INNER JOIN Employees AS E ON E.EmployeeID = O.EmployeeID 
GROUP BY FirstName ORDER BY Valores;

--somar o valor dos pedidos por empregados se for do ano de 2021
SELECT FirstName, SUM(UnitPrice*Quantity) AS Valores FROM Orders AS O
INNER JOIN Customers AS C ON C.CustomerID = O.CustomerID 
INNER JOIN [Order details] AS OD ON O.orderid = OD.orderid 
INNER JOIN Employees AS E ON E.EmployeeID = O.EmployeeID 
WHERE year (orderdate) = 2021
GROUP BY FirstName ORDER BY Valores;

--somar o valor dos pedidos por empregados se for do ano de 2021 com o bonus
SELECT FirstName, SUM((UnitPrice*Quantity) * (1-Discount)) AS Valores,
SUM((UnitPrice*Quantity) * (1-Discount)) * 0.03 AS Bonus FROM Orders AS O
INNER JOIN Customers AS C ON C.CustomerID = O.CustomerID 
INNER JOIN [Order details] AS OD ON O.orderid = OD.orderid 
INNER JOIN Employees AS E ON E.EmployeeID = O.EmployeeID 
WHERE year (orderdate) = 2021
GROUP BY FirstName ORDER BY Valores;