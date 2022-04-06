--------------------------
----FUNÇŐES DE SISTEMA----
--------------------------

--FUNÇŐES MATEMÁTICAS

select ABS(5); --retorna o valor absoluto (positivo)
select ABS(+5);
select ABS(-5);
select ABS(0);

select sign(5); --Retorna o sinal (+1), (0) ou (-1).
select sign(+5);
select sign(-5);
select sign(0);

select sin(5); --seno
select cos(5); --cosseno
select tan(5); --tangente

select Asin(50); --arco seno
select Acos(50); --arco cosseno
select Atan(50); --arco tangente
select Atn2(50,40); --angulo em radianos
select Radians(5); 
select DEGREES(5); --angulo em graus de um angulo em radiano
select log(32,2);
select log10(100);

select sqrt(144);

select power(3,2);
select power(2,30);

select pi();

-- Um tanque de 5m de R e 20m de Altura, cabe quanto combustivel?
select pi()* power (5,2) * 20;

select pi()* power(5,2) *20*1000*7
select 3.14* power(5,2) *20*1000*7

select ceiling(2.65); --retorna o menor inteiro
select ceiling(2.0000001);

select floor(2.65); --retorna o maior inteiro
select floor(2.9999999999);

select round(2.4568,2); --arredonda com especificação de casa
select round(2.4568,2);


select square(5);

--------------------------
--FUNÇŐES DE DATA E HORA--
--------------------------

select getdate(); --AA/MM/DD HH:MM:SS:MS
select SYSDATETIME(); --AA/MM/DD HH:MM:SS:MS:NS
select SYSUTCDATETIME();
select SYSDATETIMEOFFSET();

select day(getdate()); --Dia
select month(getdate()); --Męs
select year(getdate()); --Ano

select DATEPART(yy, getdate()); --ano
select DATEPART(mm, getdate()); --męs
select DATEPART(dy, getdate()); --dias
select DATEPART(hh, getdate()); --horas
select DATEPART(mi, getdate()); --minutos
select DATEPART(ss, getdate()); --segundos
select DATEPART(ms, getdate()); --milisegundos
select DATEPART(ns, getdate()); --nanosegundos

select datepart(dy, '12/11/1990'); --dia do ano
select datepart(dw, '12/11/1990'); --dia da semana

select datename(mm, '12/11/1990'); --nome do męs
select datename(dw, '12/11/1990'); --nome dia da semana

-----------------------------------
--Data, nome do dia da semana
select orderdate, datename(dw,orderdate) from Orders;

--Nome do produtos, preço unitário, preço elevado a 2
select ProductName, UnitPrice, power(UnitPrice,2) from products;

select dateadd(ss,1000000, '12/11/1990'); --add ss a data
select dateadd(dd,200,getdate());  --add dd a data

select datediff(yy,'12/11/1990', getdate()); --Quantos anos fazem

select datediff(dd,getdate(),'12/11/2022'); --Quantos dias faltam 
select datediff(hh,getdate(),'12/11/2022'); --Quantas horas faltam
