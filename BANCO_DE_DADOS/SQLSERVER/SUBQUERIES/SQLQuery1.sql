--Monte um relatorio de todos os produtos cadastrados que tem preços de venda acima da mrdia

SELECT *
FROM Production.Product
WHERE ListPrice > (SELECT AVG(ListPrice) FROM Production.Product)

--Saber nome dos funcionarios que tenham o trabalho de "Design Engineer"

SELECT *
FROM Person.Person

SELECT *
FROM HumanResources.Employee
WHERE JobTitle = 'Design Engineer'

SELECT FirstName
FROM Person.Person
Where BusinessEntityID IN (		--IN = Verificaçao de valores
SELECT BusinessEntityID FROM HumanResources.Employee
WHERE JobTitle = 'Design Engineer'
)

-- todos os endereços no estado 'Alberta'

SELECT *
FROM Person.Address

SELECT *
FROM Person.StateProvince

SELECT AddressLine1 as "Endereço Cidade Alberta"
FROM Person.Address
WHERE StateProvinceID IN (SELECT StateProvinceID
FROM Person.StateProvince
Where name = 'Alberta'
)