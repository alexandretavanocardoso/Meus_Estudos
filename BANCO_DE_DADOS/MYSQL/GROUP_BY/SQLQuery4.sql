SELECT *
FROM Sales.SalesOrderDetail

SELECT SpecialOfferID,Sum(UnitPrice) AS Soma
FROM Sales.SalesOrderDetail
GROUP BY SpecialOfferID

SELECT firstname, Count(firstname) AS Contagem
FROM Person.Person
GROUP BY FirstName

SELECT color,AVG(listprice) "Preço"
FROM Production.Product
GROUP BY color

SELECT MiddleName,Count(FirstName) "quantidade"
FROM Person.Person
GROUP BY MiddleName

SELECT ProductID,AVG(OrderQty) "Media"
FROM Sales.SalesOrderDetail
GROUP BY ProductID

SELECT TOP 10 productID, sum(Linetotal)
FROM Sales.SalesOrderDetail
GROUP BY  productID
ORDER BY sum(LineTotal) desc;

SELECT productID, COunt(ProductID) "Contagem", AVG(orderqty) "Media"
FROM Production.WorkOrder
GROUP BY ProductID