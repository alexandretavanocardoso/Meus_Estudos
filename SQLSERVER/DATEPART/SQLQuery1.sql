
/* retorna a parte especificada de uma data como um inteiro */

SELECT SalesOrderID, DATEPART(year, OrderDate) as ANO
FROM Sales.SalesOrderHeader

SELECT SalesOrderID, DATEPART(day, OrderDate) as DIA
FROM Sales.SalesOrderHeader

SELECT SalesOrderID, DATEPART(MONTH, OrderDate) as M�S
FROM Sales.SalesOrderHeader

SELECT ProductID, DATEPART(YEAR,ModifiedDate) as "Ano Modifica��o"
FROM Production.Product