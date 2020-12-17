-- Descobrir quais pessoas tem um cartao de credito registrado

SELECT *
FROM Person.Person PP
INNER JOIN Sales.PersonCreditCard PC
ON PP.BusinessEntityID = PC.BusinessEntityID
-- INNER JOIN: 19.118 Linhas
--Retorna apenas colunas com dados preenchidos

SELECT *
FROM Person.Person PP
LEFT JOIN Sales.PersonCreditCard PC
ON PP.BusinessEntityID = PC.BusinessEntityID
--LEFT JOIN: 19.972 Linhas
--Retorna colunas com dados preenchidos e quais nao estao aparecera "NULL"

