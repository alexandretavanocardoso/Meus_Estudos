
/* Seleciona os maiores */

SELECT TOP 10 ListPrice AS Pre�o
FROM Production.Product

SELECT TOP 10 ListPrice AS "Pre�o Produto"
FROM Production.Product

SELECT TOP 10 AVG(listPrice) AS "Pre�o Medio" 
FROM Production.Product

--Encontrar o firstname e Lastname e renomear
SELECT TOP 10 FirstName AS "Nome",
LastName AS "Sobrenome"
FROM Person.Person

--Apelidar o ProsuctNumber para "Numero do Produto"
SELECT TOP 10 ProductNumber AS "Numero De Produto"
FROM Production.Product

--Apelidar UnitPrice para "Pre�o Unitario"
SELECT TOP 10 UnitPrice AS "Pre�o Unitario"
FROM Sales.SalesOrderDetail
	