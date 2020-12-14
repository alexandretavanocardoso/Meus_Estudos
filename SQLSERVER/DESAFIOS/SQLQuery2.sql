--DESAFIOS BETWEEN, LIKE, IN

--1-Quantos produtos temos cadastrado no sistema que custam mais que 1500 dolar?

SELECT COUNT(ListPrice)
FROM Production.Product
WHERE listPrice > 1500

--2-Quastas pessoas temos com o sobrenome que inicia com p?

SELECT COUNT(LastName)
FROM Person.Person
Where LastName like 'p%'

--3-Quastas pessoas temos com o sobrenome que inicia com p?

SELECT COUNT(Distinct (city))
FROM Person.Address

--4-Quais sao as cidades unicas cadastrada no sistema?

SELECT Distinct city
FROM Person.Address

--5-Quantos produtos vermelhos tem preço entre 500 e 1000 dolars?

SELECT *
FROM Production.Product
WHERE Color = 'red'
AND listPrice between 500 and 1000

--6--Quastos produtos cadastrados tem a palavra 'road' no nome deles?

SELECT COUNT(*)
FROM Production.Product
WHERE name Like '%road';  