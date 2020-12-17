
/* ORDER BY */

-- Ordena por Crescente ou descrecente

--> APENAS ORDER BY
--> ASC - Crescente
--> DESC - Descrecente

--> APENAS ORDER BY
--> ASC - Crescente
SELECT *
FROM Tabela
ORDER BY Coluna

--> ASC - Crescente
SELECT *
FROM Tabela
ORDER BY Coluna ASC

--> DESC - Descrecente
SELECT *
FROM Tabela
ORDER BY Coluna DESC

/* ORDENANDO POR MAIS DE UMA COLUNA*/
SELECT *
FROM Tabela
ORDER BY Coluna, Coluna2

/* ORDENANDO POREM MOSTRANDO UMA COLUNA */
SELECT NOME
FROM Tabela
ORDER BY Coluna, NOME


