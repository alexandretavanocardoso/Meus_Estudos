--Quais nomes do sistema tem uma ocorrencia maior que 10, porem somente onde o titulo é' Mr'

/*

determina uma condição de busca para um grupo ou um conjunto de registros, 
definindo critérios para limitar os resultados obtidos a partir do agrupamento de registros.

*/

SELECT FirstName,COUNT(FirstName) as "Quantidades"
FROM Person.Person
Where Title = 'Mr.'
GROUP BY FirstName
having count(firstname) > 10;

--EX. Produtos que no total de vendas estao entre 162k a 500k

SELECT TOP 10 *
FROM Sales.SalesOrderDetail

SELECT ProductID,sum(LineTotal) as "Total"
FROM Sales.SalesOrderDetail
GROUP BY ProductID
hAVING sum(LineTotal) between 162000 and 500000


SELECT ProductID,AVG(LineTotal)
FROM Sales.SalesOrderDetail
GROUP BY ProductID
having AVG(LineTotal) < 1000000

