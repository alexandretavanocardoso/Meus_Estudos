-- CLentes da mesma regiao

SELECT *
FROM Customers

SELECT A.ContactName, B.ContactName, A.Region, B.Region
FROM Customers A, Customers B
Where A.Region = B.Region

--Encontrar(Nome e data e contrataçao) de todos
--os funcionsrios que foram contratados no memo ano

SELECT A.FirstName,A.HireDate,B.FirstName,B.HireDate
FROM Employees A, Employees B
WHERE DATEPART(YEAR,A.HireDate) = DATEPART(YEAR,B.hiredate)

--Saber na tabela "Detalhe do pedido" {ORDER DETAILS} quais produtos
--tem o mesmo percentual de desconto

SELECT A.ProductID, B.ProductID, A.Discount, B.Discount
FROM [Order Details] A, [Order Details] B
WHERE A.Discount = B.Discount 