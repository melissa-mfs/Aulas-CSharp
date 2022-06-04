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
	CodLivro int,
	Titulo nvarchar(50),
	Autor nvarchar(30),
	Editora nvarchar(30),
	Constraint PK_Livro Primary Key (CodLivro)
);

Create table Emprestimos(
	CodLivro int,
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
	('2', 'Anthony', 'Rua Exemplo', 'Bairro Exemplo', 'Cidade Exemplo', '900000000');

Insert Into Livros Values
	('1', 'Titulo Exemplo', 'Autor Exemplo', 'Editora Exemplo');

Insert into Emprestimos Values
	('21', '1', '24/05/2022', '25/05/2022')

select * from Amigos
select * from Livros
select * from Emprestimos

Select CodAmigo from Amigos where CodAmigo = (select max(CodAmigo) from Amigos);

Select Amigos.CodAmigo, Amigos.Nome, Livros.CodLivro, Livros.Titulo, 
Emprestimos.DataEmprestimo, Emprestimos.DataDevolucao from Amigos 
inner join Emprestimos on Amigos.CodAmigo = Emprestimos.CodAmigo
inner join Livros on Emprestimos.CodLivro = Livros.CodLivro
where Livros.Titulo like '%Anime%' or Livros.CodLivro = '1';