--Sorteia números de 0 a 0,999...
select rand()

--Sorteia de 1 a 6 arredondando para baixo
select floor(rand()*6) + 1

--Sorteia de 7 a 10 arredondando para baixo
select floor(rand()*4) + 7

--Sorteia de 7 a 10 com uma casa decimal
select round(rand()*3 + 7,1)

-----------------------------------------------
--Exercicios:

--selecionar todos os fornecedores da argentina
--select CompanyName, Country from Suppliers;
select CompanyName from Suppliers where Country = 'Argentina';

--selecionar todos os clientes da cidade "London"
select ContactName from Customers where City = 'London';

--contar a quantidade de pedidos de cada cliente (group by)
select ContactName, count(OrderID) as 'Pedidos p/ Cliente' from Customers 
inner join Orders on Customers.CustomerID = Orders.CustomerID 
group by Orders.CustomerID, ContactName;

--contar a quantidade de pedidos por funcionários (group by)
select firstname, count(OrderID) as 'Pedidos p/ Funcionário' from Employees 
inner join Orders on Employees.EmployeeID = Orders.EmployeeID 
group by FirstName;

--fazer inner join entre as tabelas de suplies, categories, products
select * from Categories 

inner join products on categories.CategoryID = Products.CategoryID
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID; 

--fazer inner join entre as tabelas de order details, products, categories
select * from [Order Details] 
inner join Products on [Order Details].ProductID = Products.ProductID
inner join Categories on Products.CategoryID = Categories.CategoryID; 

--utilizar a consulta acima, calcule a soma das vendas por categorias
select CategoryName, sum([Order Details].UnitPrice*Quantity) 
as 'Venda p/ Categoria' from [Order Details] 
inner join Products on [Order Details].ProductID = Products.ProductID
inner join Categories on Products.CategoryID = Categories.CategoryID
group by CategoryName; 

----------------------------------------------------------------------

go
create view ClientesDeLondres as --cria a view (tabela temporária)
select * from Customers where city='london';

go
select * from ClientesDeLondres --executa a consulta

----------------------------------------------------------------------

go
create procedure CliPorCidade @cidade nvarchar(30) as --cria view com objeto
begin
select * from Customers where city=@cidade --usa o objeto para filtrar
end

exec CliPorCidade 'Paris'; --executa a consulta
exec CliPorCidade 'Buenos Aires';

----------------------------------------------------------------------------------

go
create procedure ProdutoPorCategoria @nomecateg nvarchar(30) as
select * from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where CategoryName = @nomecateg;

go
exec ProdutoPorCategoria 'beverages';

------------------------------------------------------------------------

go
create procedure Somar @num1 int, @num2 int as
begin
declare @soma int --declara a variavel soma
set @soma = @num1 + @num2 --faz a soma
select @soma -- mostra o resultado
end

go
exec Somar '2','4'; --executa a consulta

-------------------------------------------------------------

--monte uma procedure para calcular a area de um triangulo
-- a = (b*h)/2

go
create procedure AreaTriangulo @base float, @altura float as
begin
declare @area float
set @area = (@base * @altura) / 2
select @area
end

go
exec AreaTriangulo '6' , '3';

--------------------------------------------------------------------
--monte uma procedure para calcular a area de um trapezio
-- a = (B+b)*h/2

go
create procedure AreaTrapezio @bmaior float, @bmenor float, @altura float as
begin
declare @area float
set @area = (@bmaior+@bmenor)* @altura / 2
select @area
end

go
exec AreaTrapezio'6' , '3', '4';