SELECT *
FROM Person.Person
ORDER BY FirstName asc

SELECT *
FROM Person.Person
ORDER BY FirstName desc

SELECT *
FROM Person.Person
ORDER BY FirstName asc, LastName desc

SELECT FirstName,LastName,MiddleName
FROM Person.Person
ORDER BY MiddleName asc

SELECT Top 10 ProductID
FROM Production.Product
ORDER BY ListPrice desc

SELECT Top 4 Name,ProductNumber
FROM Production.Product
ORDER BY ProductID



