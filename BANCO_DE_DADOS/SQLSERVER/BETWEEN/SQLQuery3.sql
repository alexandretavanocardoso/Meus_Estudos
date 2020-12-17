
/* Entre um valor e outro */

SELECT *
FROM Production.Product
WHERE ListPrice BETWEEN 1000 And 1500

SELECT *
FROM Production.Product
WHERE ListPrice NOT  BETWEEN 1000 And 1500

SELECT *
FROM HumanResources.Employee
Where HireDate BETWEEN '2009/01/01' And '2010/01/01' 
Order by HireDate
