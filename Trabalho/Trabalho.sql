create table Amigos(
	CodAmigo int,
	Nome nvarchar(30),
	Endereco nvarchar(50),
	Bairro nvarchar(30),
	Cidade nvarchar(30),
	telefone nvarchar(9)
);

Create table Livros(
	CodLivro int,
	Titulo nvarchar(50),
	Autor nvarchar(30),
	Editora nvarchar(30),
	CodAmigo int
);

Create table emprestimos(
	CodLivro int,
	CodAmigo int,
	DataEmprestimo nvarchar(10),
	DataDevolucao nvarchar(10)
);