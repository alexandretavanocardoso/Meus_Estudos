

/* Junção de Tabelas, Porem nao pega os dados Nulls*/

SELECT TA.TabelaAId, TB.NomeColunaTabelaB
FROM TabelaA TA
INNER JOIN TabelaB TB 
ON(TA.TabelaAId = TB.TabelaBId)