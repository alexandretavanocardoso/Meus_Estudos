SELECT *
FROM Person.Person

-- Concatenando
SELECT LastName,MiddleName,CONCAT(LastName,MiddleName)as Junçao
FROM Person.Person

-- Deixando em maiusculo
SELECT UPPER (LastName)
FROM Person.Person

-- Deixando em minusculo
SELECT LOWER (LastName)
FROM Person.Person

SELECT LastName, LEN (LastName)
FROM Person.Person

SELECT SUBSTRING (LastName,1,3)
FROM Person.Person

-- Trocando
SELECT REPLACE(LastName,'A','(TROCANDO)')
FROM Person.Person
