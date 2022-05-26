go
create  function somarseq(@num int) returns int as
begin
	declare @i int, @soma int
	set @i = 1
	set @soma = 0
	while (@i <= @num)
	begin
		set @soma = @soma + @i
		set @i = @i + 1
	end
	return @soma
end

select dbo.somarseq (2)
--------------------------------------------------------
go
alter  function somarseq(@num int) returns int as
begin
	declare @i int, @soma int
	set @i = 1
	set @soma = 0
	while (@i <= @num)
	begin
		set @soma = @soma + @i*@i -- quadrado de @i
		set @i = @i + 1
	end
	return @soma
end

select dbo.somarseq (4)
---------------------------------------------------------------
go
alter function RefBiblio (@nome nvarchar(100)) returns nvarchar(100)
begin
	declare @nomeFinal nvarchar(100),
			@i int,
			@letra nvarchar(1)
	set @nomeFinal=''
	set @letra =''
	set @i = len(@nome)
	while @i >= 1
	begin
		set @letra = SUBSTRING(@nome, @i, 1)
		if @letra = ''
			break
		set @i = @i - 1
	end
	set @nomeFinal = SUBSTRING(@nome, @i, len(@nome)-@i+1)+
								', '+SUBSTRING(@nome, 0, @i)
	return @nomeFinal
end

select dbo.RefBiblio('m s')

select contactname, dbo.RefBiblio(contactname) as Inverso from Customers
-------------------------------------------------------------------------
go
create function criptografar(@texto nvarchar(100)) returns nvarchar(100)
begin
	declare @i int, @textocrip nvarchar(100), @letra nchar
	set @=1
	set @textocrip=''
	while @i <= len (@texto)
	begin
		set @letra = SUBSTRING(@texto, @i, 1)
		set @letra = char (ascii(@letra)+3)
		set @textocrip = @textocrip + @letra
		set @i = @i + 1
