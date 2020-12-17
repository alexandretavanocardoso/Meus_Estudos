SELECT ProductID, Name, ProductNumber
FROM Production.Product
WHERE Name LIKE  '%Chain%'

UNION

SELECT ProductID, Name, ProductNumber
FROM Production.Product
WHERE Name LIKE  '%Decal%'




SELECT FirstName, Title, MiddleName
FROM Person.Person
WHERE Title = 'MR.'

UNION


SELECT FirstName, Title, MiddleName
FROM Person.Person
WHERE MiddleName = 'A'

-- EXERCICIO

SELECT EmailAddressID, EmailAddress
FROM Person.EmailAddress
Where BusinessEntityID = 2
UNION
SELECT EmailAddressID, EmailAddress
FROM Person.EmailAddress
Where BusinessEntityID = 4
