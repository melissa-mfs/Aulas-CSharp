--------------------------
----FUNÇÕES DE SISTEMA----
--------------------------

--FUNÇÕES MATEMÁTICAS

select ABS(5);
select ABS(+5);
select ABS(-5);
select ABS(0);

select sign(5);
select sign(+5);
select sign(-5);
select sign(0);

select sin(5);
select cos(5);
select tan(5);

select Asin(50);
select Acos(50);
select Atan(50);
select Atn2(50,40);
select Radians(5);
select DEGREES(5);
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

select ceiling(2.65);
select ceiling(2.0000001);

select floor(2.65);
select floor(2.9999999999);

select round(2.4568,2);
select round(2.4568,2);


select square(5);

--------------------------
--FUNÇÕES DE DATA E HORA--
--------------------------

select getdate(); --AA/MM/DD HH:MM:SS:MS
select SYSDATETIME(); --AA/MM/DD HH:MM:SS:MS:NS
select SYSUTCDATETIME();
select SYSDATETIMEOFFSET();

select day(getdate()); --Dia
select month(getdate()); --Mês
select year(getdate()); --Ano

select DATEPART(yy, getdate());
select DATEPART(mm, getdate());
select DATEPART(dy, getdate());
select DATEPART(hh, getdate());
select DATEPART(mi, getdate());
select DATEPART(ss, getdate());
select DATEPART(ms, getdate());
select DATEPART(ns, getdate());

select datepart(dy, '12/11/1990');
select datepart(dw, '12/11/1990');

select datename(mm, '12/11/1990');
select datename(dw, '12/11/1990');

-----------------------------------
select orderdate, datename(dw,orderdate) from Orders;

select ProductName, UnitPrice, power(UnitPrice,2) from products;

select dateadd(ss,1000000, '12/11/1990');
select dateadd(dd,200,getdate());

select datediff(yy,'12/11/1990', getdate());