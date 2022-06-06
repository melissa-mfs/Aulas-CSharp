Create database LocadoraLivros
use LocadoraLivros

create table Amigos(
	CodAmigo int,
	Nome nvarchar(30),
	Endereco nvarchar(50),
	Bairro nvarchar(30),
	Cidade nvarchar(30),
	Telefone nvarchar(9),
	Constraint PK_Amigo Primary Key (CodAmigo)
);

Create table Livros(
	CodLivro varchar(6),
	Titulo nvarchar(50),
	Autor nvarchar(30),
	Editora nvarchar(30),
	Constraint PK_Livro Primary Key (CodLivro)
);

Create table Emprestimos(
	CodLivro varchar(6),
	CodAmigo int,
	DataEmprestimo date,
	DataDevolucao date,
	Constraint PK_Emprestimo Primary Key (CodLivro, CodAmigo),
	Constraint FK_Amigo Foreign Key (CodAmigo)
	References Amigos(CodAmigo),
	Constraint FK_Livro Foreign Key (CodLivro)
	References Livros(CodLivro)
);

Insert Into Amigos Values
	('1', 'Cassia', 'Rua Exemplo', 'Bairro Exemplo', 'Cidade Exemplo', '900000000'),
	('2', 'Anthony', 'Rua Exemplo', 'Bairro Exemplo', 'Cidade Exemplo', '900000000'),
	('3', 'Melissa', 'Rua Japão', 'Baronesa', 'Mauá', '912345678'),
	('4', 'Amanda', 'Rua Esmeralda', 'Jardim Mauá', 'Mauá', '900000000'),
	('5', 'Geovana', 'Rua das Pérolas', 'Liberdade', 'São Paulo', '987654321');

Insert Into Livros Values
	('1', 'Titulo Exemplo', 'Autor Exemplo', 'Editora Exemplo'),
	('123', 'Alice: através do espelho', 'Lewis Carrol', 'Macmillan'),
	('3', 'Harry Potter e o cálice de fogo', 'J.K Rowling', 'Intrísica'),
	('3452', 'Percy Jackson e o mar de monstros', 'Rick Riordan', 'Macmillan'),
	('4', 'Harry Potter e a camara secreta', 'J.K Rownling', 'Intrísica');

Insert into Emprestimos Values
	('1', '2', '24/05/2022', '25/06/2022'),
	('3', '4', '24/02/2022', '25/03/2022'),
	('5', '123', '24/04/2022', '25/05/2022'),
	('1', '3452', '24/03/2022', '25/03/2022'),
	('1', '3', '24/04/2022', '25/05/2022');

select * from Amigos
select * from Livros
select * from Emprestimos

Select CodAmigo from Amigos where CodAmigo = (select max(CodAmigo) from Amigos);

Select Amigos.CodAmigo, Amigos.Nome, Livros.CodLivro, Livros.Titulo, 
Emprestimos.DataEmprestimo, Emprestimos.DataDevolucao from Amigos 
inner join Emprestimos on Amigos.CodAmigo = Emprestimos.CodAmigo
inner join Livros on Emprestimos.CodLivro = Livros.CodLivro
where Livros.Titulo like '%Anime%' or Livros.CodLivro like '1%';

Select Amigos.CodAmigo, Amigos.Nome, Livros.CodLivro, Livros.Titulo, 
Emprestimos.DataEmprestimo, Emprestimos.DataDevolucao from Amigos 
inner join Emprestimos on Amigos.CodAmigo = Emprestimos.CodAmigo
inner join Livros on Emprestimos.CodLivro = Livros.CodLivro
where DataEmprestimo like '%2022-05%' or DataDevolucao like '%2022-06%';

drop table Emprestimos;
drop table Livros;
drop table Amigos;
