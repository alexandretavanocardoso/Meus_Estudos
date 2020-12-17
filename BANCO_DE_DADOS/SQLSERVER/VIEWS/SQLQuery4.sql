CREATE VIEW [Pessoas Simplificadas] AS
select FirstName,MiddleName,LastName
from Person.Person
where Title = 'MR.'

SELECT * FROM [Pessoas Simplificadas]