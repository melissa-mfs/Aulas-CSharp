create database empresanoite
use empresanoite

create table funcionarios(
	CodigoFun int,
	nomefunc nvarchar(30),
	cidade nvarchar(30),
	quantfilhos int
);

insert into funcionarios(CodigoFun, nomefunc, cidade, quantfilhos)
values (1,'Ari', 'SBC',0),
		(2, 'Eva', 'Diadema',0),
		(3, 'Rui', 'SBC', 0);

create table filhos(
	codfunc int,
	NomeFilho nvarchar(30),
	AnoNasc int
);

--Aumenta automaticamente a quantidade de filhos do funcionario
go
create trigger somafilhos on filhos after insert as
begin
	declare @cf int
	select @cf = codfunc from inserted --pega do valor que está sendo inserido
	update funcionarios set quantfilhos+=1 
				where CodigoFun = @cf
end

select * from funcionarios

insert into filhos(codfunc, NomeFilho, AnoNasc)
values (1,'Ana', 1992);

select * from funcionarios


-- Exemplo 2
Create database Banco
use Banco

Create table Contas(
	Codconta int, 
	Dataabertura nvarchar(30), 
	Saldo int, 
	Cliente nvarchar(30)
);

insert into contas(Codconta, Dataabertura, Saldo, Cliente)
	values(100, '01/01/2022', 0, 'Victor')
insert into contas(Codconta, Dataabertura, Saldo, Cliente)
	values(16, '01/03/2022', 0, 'Amanda')

create table Depositos(
	Codconta int,
	Datadeposito datetime,
	valor money
);

create table Saques(
	Codconta int,
	Datasaque datetime,
	valor money
);

go
create trigger Saque on Saques after insert as
begin
	declare @codconta int,
			@valor money
	select @codconta = @codconta from inserted
	select @valor = valor from inserted
	update contas set saldo -= @valor
	where codconta = @codconta
end

go
create trigger deposito on Depositos after insert as
begin
	declare @codconta int,
			@valor money
	select @codconta = @codconta from inserted
	select @valor = valor from inserted
	update contas set saldo += @valor
	where codconta = @codconta
end

select * from contas;

insert into Depositos(Codconta, Datadeposito, valor)
	values(16, '02/03/2022', 1000);

select * from contas;