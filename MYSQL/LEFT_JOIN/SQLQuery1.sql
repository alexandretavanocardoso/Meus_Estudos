

/* Jun��o de Tabelas, Porem pega os dados Nulls*/

SELECT TA.TabelaAId, TB.NomeColunaTabelaB
FROM TabelaA TA
LEFT JOIN TabelaB TB 
ON(TA.TabelaAId = TB.TabelaBId)