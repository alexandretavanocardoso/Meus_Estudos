/*	OPERADOR     -     DESCRIÇAO 
	=				   IGUAL
	>				   MAIOR QUE	
	<				   MENOR QUE
	>=				   MAIOR QUE OU IGUAL
	<=			       MENOR QUE OU IGUAL
	<>				   DIFERENTE DE
	AND			       OPERADOR LÒGICO "E"
	OR				   OPERADOR LÒGICO "OU"
*/

SELECT *
FROM Person.Person
WHERE LastName = 'Alexander' and FirstName = 'anna'

SELECT *
FROM Production.Product
Where color = 'blu' or color = 'red'

SELECT *
FROM Production.Product
Where ListPrice > 1500 and ListPrice < 5000

SELECT *
FROM Production.Product
Where color <> 'red'

SELECT *
FROM Production.Product
Where Weight > 500  and Weight < 700

SELECT *
FROM HumanResources.Employee
Where MaritalStatus= 'm' and SalariedFlag = 1]

SELECT *
FROM Person.Person
Where FirstName = 'peter' and LastName = 'krebs'

SELECT *
FROM Person.EmailAddress
Where BusinessEntityID = 26


