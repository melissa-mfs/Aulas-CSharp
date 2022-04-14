select * from customers where companyname like 'a%';

select * from customers where companyname like '[ad]%';

select * from customers where companyname like '[a-d]%';

-- pega os nomes que não comecem entre A a D (abcd)
select * from customers where companyname like '[^a-d]%';

--pega o que comece com e e termine com n
select * from customers where companyname like 'E%n';

-- pega o que termina com en
select * from customers where companyname like '%en';


-- não importa o começo ou o meio, tendo AD
select * from customers where companyname like '%ad%';

select count(*) from products;

select count(*) from products where categoryid=1;

select count(*) from Customers where Country = 'mexico';

select Country from Customers where Country = 'mexico';
select Country from Customers;

select count(*)from orders where customerid='anton';

--quantidade de vezes que o produto de código 11 foi vendido
select count(*) from [Order Details]where ProductID=11

select avg(unitprice) from Products;

select avg(unitprice) from Products where categoryid=1;

--a media da quantidade de bebidas no estoque
select avg (unitsinstock) from products where categoryid=1
select*from products;

select sum (unitsonorder) from products;

select sum (UnitPrice) from products;

-- valor total de todos e os detalhes
select productname,unitprice,unitsinstock,
UnitPrice*UnitsInStock as 'valor total' from Products;

-- valor total de todos
select sum(UnitPrice*UnitsInStock) as 'Todos produtos' from Products;

-- valor total de todos os produtos da categoria 5
select sum(UnitPrice*UnitsInStock) as 'Todos produtos' from Products
where CategoryID = 5;

select* from [ORDER DETAILS]

select *, UnitPrice*Quantity as 'subtotal' from [ORDER DETAILS]

-- valor total do pedido 10248 e os detalhes
select *,(UnitPrice*Quantity)*(1-Discount) as 'subtotal' 
from [ORDER DETAILS] where OrderID = 10248

-- valor total do pedido 10248
select sum((UnitPrice*Quantity)*(1-Discount)) as 'total' 
from [ORDER DETAILS] where OrderID = 10248

--vendido no ano de 2020
select sum((UnitPrice*Quantity)*(1-Discount)) as 'total' 
from [ORDER DETAILS] as od inner join orders as o
on o.OrderID = od.OrderID
where OrderDate between '01/01/2020' and '31/12/2020';

select min(unitprice) as 'menor valor' from products;

select * from products
where UnitPrice = (select min(unitprice) from Products);

select max(unitprice) as 'maior valor' from Products;