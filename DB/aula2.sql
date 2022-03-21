-- nome da tabela.coluna
select * from Products 
Inner join [Order Details] 
on products.ProductID = [Order Details].ProductID;

-- apelido.coluna
select * from Products as p
Inner join [Order Details] as od
on p.ProductID = od.ProductID;

-- apelido.coluna
select * from  Products as p
Inner join Suppliers as s
on p.SupplierID = s.SupplierID;

-- apelido.coluna
select * from Categories as c
Inner Join  Products as p
on c.CategoryID = p.CategoryID;

-- apelido.coluna
select * from Orders as o
Inner join Customers as c
on o.CustomerID = c.CustomerID;

-- apelido.coluna
select * from Orders as o 
Inner Join Employees as e
on o.EmployeeID = e.EmployeeID;

-- apelido.coluna
select * from Orders as o
Inner join [Order Details] as od
on o.OrderID = od.OrderID;

-- nome diferentes das colunas(em comum) nas tabelas
select * from Shippers
Inner Join Orders
on ShipperID = ShipVia;

select * from [Order Details] as od
Inner Join Products as p
on p.ProductID = OD.ProductID
	Inner Join Categories as ca
	on p.CategoryID = ca.CategoryID;

select * from Orders as o
Inner Join Customers as c
on o.CustomerID = c.CustomerID
	Inner Join Shippers as s
	on s.ShipperID = o.ShipVia;

select * from Employees as e
Inner Join Orders as o
on e.EmployeeID= o.EmployeeID
	Inner Join Customers as c
	on o.CustomerID = c.CustomerID;

select * from Suppliers as s
Inner join Products as p
on s.SupplierID = p.SupplierID
	Inner join Categories as ca
	on p.CategoryID = ca.CategoryID;

select * from [Order Details] as od
Inner join Orders as o
on od.OrderID = o.OrderID
	Inner join Customers as c
	on o.CustomerID = c.CustomerID
		Inner join Employees as e
		on o.EmployeeID = e.EmployeeID;


-- combina as categorias com cada nome de produto
select Productname, categoryname from Products, Categories
where ProductName like 'chai';

-- o Inner join filtra as tabelas e faz a conexão dos dados
select Productname, categoryname from Products as p
Inner join Categories as c
on p.CategoryID = c.CategoryID;

select Productname, categoryname from Products as p
Inner join Categories as c
on p.CategoryID = c.CategoryID where ProductName like 'chai';


create table Profe 
	( Codpro int identity (1,1),
	nomepro nvarchar (30),
	cidade nvarchar (30))

create table Disciplina 
	( Coddisc int identity (1,1),
	discip nvarchar (40),
	codpro int)

	insert into Profe values 
	( 1, 'Pavão', 'Mauá')

	insert into Disciplina values
	( 1, 'BD', 1)S