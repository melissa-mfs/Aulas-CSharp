--Cria procedure de calculo de velocidade
create procedure velocidade @dist float, @tempo float as 
begin
	declare @velocidade float
	set @velocidade = @dist/@tempo
	select @velocidade --imprimi
end

execute velocidade 500,7
-------------------------------------------------
--Função para calcular a velocidade
go 
create function FuncVeloc (@dist float, @tempo float) returns float as
begin
	declare @velocidade float 
	set @velocidade = @dist/@tempo
	return @velocidade --retorna
end

go
select dbo.FuncVeloc (500,7) --imprimi
--------------------------------------------------
--Alterando a função calcula o volume de um cilindro
go 
Alter function FuncVolume (@R float, @H float) returns float as
begin
	declare @volume float 
	set @volume = pi()*square(@R)*@H
	return @volume --retorna
end

go
select dbo.FuncVolume (3,3)
---------------------------------------------------------
--Função do calculo Reynolds onde é retornado um varchar
go
create function reynolds (@velocidade float, @dist float, 
							@visc float, @dens float) returns varchar(15) as
begin
	declare @nr float, @resultado varchar(15)
	set @nr = @velocidade*@dist*@dens/@visc
		if @nr <=2000
		begin
			set @resultado = 'Laminado'
		end
		else
			begin
			set @resultado = 'Turbilhonado'
		end
	return @resultado
end

go
select dbo.reynolds (3,3,3,3)
--------------------------------------------------------
go
Create function media (@p1 float, @p2 float, @T float) returns varchar(50) as
begin
	declare @media float, @resultado varchar(50)
	set @media = (@p1*0.35)+(@p2*0.35)+(@T*0.30)
		if @media < 3
		begin
			set @resultado = @media
		end
		else if @media < 6 
		begin
			set @resultado = @media
		end
		else
			begin 
			set @resultado = @media
		end
	return @resultado
end

go
select dbo.media (3, 8, 8)
----------------------------------------------------------
go
create function resulfatec (@media float) returns varchar(30) as
begin
	declare @resultado varchar(30)
	if @media >= 0 and @media <= 2.99
		set @resultado = 'Reprovado'
	else if @media >= 3 and @media <= 5.99
		set @resultado = 'P3'
	else if @media >= 6 and @media <= 10
		set @resultado = 'Aprovado'
	return @resultado
end

go
select dbo.resulfatec (7) as 'Média'
------------------------------------------------------
select dbo.media(4,7,10) as 'Média',
	dbo.resulfatec(dbo.media(4,7,10)) as 'Resultado'
-------------------------------------------------------
go
Create table fatec (
cod int identity (1,1),
Nome varchar (40),
P1 float, P2 float, T float)

insert into fatec (nome, p1, p2, t) values ('Joana', 5, 3, 8)
insert into fatec (nome, p1, p2, t) values ('Diana', 6, 7, 8)
insert into fatec (nome, p1, p2, t) values ('Lisa', 7, 2, 8)
insert into fatec (nome, p1, p2, t) values ('Carol', 2, 4, 8)
insert into fatec (nome, p1, p2, t) values ('Julia', 8, 3, 8)

--Se caso for usar o valor da média não será possível
--Pq é texto e não float ou int
select *, dbo.media(p1,p2,t) as 'media',
	dbo.resulfatec(dbo.media(p1,p2,t)) as 'Resultado'
	from fatec
--------------------------------------------------------------
-- Função de Juros composto 
-- 1000 2% 5  ----> 1104,085
go
Create function JuroComposto (@valor float, @juro float, @meses int) returns float as
begin
	declare @resultado float, @i int
	set @i=1
	while(@i <= @meses)
	begin
		set @valor = @valor * (1+@juro/100)
		set @i = @i+1
	end
	return @valor
end
-----------------------------------------------
select dbo.JuroComposto (1000,2,5)
-----------------------------------------------
Create table emprestimos(
	nome nvarchar(30),
	valor float,
	tempo int,
	juro float)

insert into emprestimos values('Bruna', 2000, 30, 1)
insert into emprestimos values('Renata', 1500, 30, 4)
insert into emprestimos values('Amanda', 600, 60, 6)
insert into emprestimos values('Helen', 4300, 12, 2)

--------------------------------------------------
select * from emprestimos

select *, ROUND(dbo.JuroComposto(valor, juro,tempo),2) from emprestimos

select *, ROUND(dbo.JuroComposto(valor, juro,tempo),2) as Total,
	ROUND(dbo.JuroComposto(valor, juro,tempo),2)-valor as Juros
	from emprestimos
---------------------------------------------------
go
Create function Referencia(@nome nvarchar(100)) returns nvarchar(100) as
begin
	declare @NomeFinal nvarchar(100), @i int, @letra nvarchar(1)
	set @NomeFinal=''
	set @letra = ''
	set @i = len(@nome)
	while @i >= 1
	begin
		set @letra = substring(@nome,@i,1)
		if @letra = ' '
			break
		set @i = @i - 1
	end
	set @NomeFinal = SUBSTRING()