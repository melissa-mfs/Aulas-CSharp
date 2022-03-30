--
select OrderID, OrderDate, RequiredDate,
datediff (dd, OrderDate, RequiredDate)
from orders;

--mostrar a quantidade de dias (prazo) para a entrega do produto
select OrderID, OrderDate, RequiredDate,
datediff (dd, OrderDate, RequiredDate) as 'Prazo',
datediff (dd, OrderDate, ShippedDate) as 'Tempo da Entrega'
from orders;

-- Mostrar produtos que passaram do prazo

-- Forma 1
select OrderID, OrderDate, RequiredDate,
datediff (dd, OrderDate, RequiredDate) as Prazo,
datediff (dd, OrderDate, ShippedDate) as Tempo_Entrega
from orders 
where datediff (dd, OrderDate, ShippedDate) > datediff (dd, OrderDate, RequiredDate);

-- Forma 2
Create view PedidosComAtraso as  --Cria uma consulta (Objeto)
select OrderID, OrderDate, RequiredDate,
datediff (dd, OrderDate, RequiredDate) as Prazo,
datediff (dd, OrderDate, ShippedDate) as Tempo_Entrega
from orders;

select * from PedidosComAtraso where Tempo_Entrega > Prazo;

-- Forma 3
select OrderID, OrderDate, RequiredDate,
datediff (dd, OrderDate, RequiredDate) as Prazo,
datediff (dd, OrderDate, ShippedDate) as Tempo_Entrega
from orders where ShippedDate > RequiredDate;

-- Forma 4
select OrderID, OrderDate, RequiredDate,
datediff (dd, OrderDate, RequiredDate) as Prazo,
datediff (dd, OrderDate, ShippedDate) as Tempo_Entrega
from orders where datediff (dd, RequiredDate, ShippedDate) > 0;

-- Forma 5
select OrderID, OrderDate, RequiredDate,
datediff (dd, OrderDate, RequiredDate) as Prazo,
datediff (dd, OrderDate, ShippedDate) as Tempo_Entrega,
datediff (dd, RequiredDate, ShippedDate) as Dias_Atraso
from orders where datediff (dd, RequiredDate, ShippedDate) > 0;

---------------------------------------------------------------------------

--Quais usuários fazem aniversário no mês de janeiro
Select FirstName, BirthDate, datename(mm, BirthDate) as Mês 
from Employees where datename(mm, BirthDate) = 'Janeiro';

--Qual a idade dos funcionários
select FirstName, BirthDate,datediff(yy,BirthDate, getdate()) as Aniversario
from Employees;

--Quanto tempo cada funcionario tem na empresa
select FirstName, HireDate,datediff(yy,HireDate, getdate()) as Tempo_Empresa
from Employees;

--Qual a idade do funcionario quando entrou na empresa
--Forma 1
select FirstName, BirthDate, HireDate, datediff(yy,BirthDate, HireDate) as Idade
from Employees;

--Forma 2
select FirstName, BirthDate, HireDate, year(HireDate) - YEAR(BirthDate) as Idade
from Employees;


--------------------------------------------------------------------------------
------- FUNÇÕES DE STRING
--------------------------------------------------------------------------------

--Tabela ASCII
select ascii('a');
select ascii('A');
select ascii('3');
select ascii('*');

select char(97);
select char(65);
select char(51);
select char(42); 
select char(3);

select lower('Nome'); --Deixa as letras minusculas
select upper('Nome'); --Deixa as letras maiusculas

--Pegar as letras da esquerda
select left('Computador', 3);
select left('Lindomar', 5);
select left('Mariana', 4);

--Pegar as letras da direita
select right('Computador', 3);
select right('Lindomar', 5);
select right('Mariana', 4);

--Pegar da letra dois até a três
select SUBSTRING('Graviola', 2,3);

select SUBSTRING('Graviola', 2,3) + SUBSTRING('Anime', 5, 5) + SUBSTRING('Banana', 3, 2);

--Remover espaços
select ltrim('         Linda') + rtrim(' Flor     ') + trim('    do dia   ');

--Reverso de frases
select reverse('anime');

--Repetir letras ou palavras
select 'Anime é vida'+ REPLICATE('a', 30);

--Colocar espaços
select 'Com' + space(10) + 'espaço';

--Trocar letras
select REPLACE('banana', 'n', 't');