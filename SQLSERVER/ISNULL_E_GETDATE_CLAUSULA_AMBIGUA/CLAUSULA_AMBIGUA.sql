

/* CLAUSULA AMBIGUA */

-- QUANDO FAZ JOIN E TEM COLUNAS IGUAIS EM UMA TABELA

-- LETRAS PARA DISTINGUR UMA TABELA E SUAS COLUNAS DE OUTRA TABELA

-- EX.

SELECT A.NOME, T.TIPO, T.NUMERO, E.BAIRRO, E.ESTADO
FROM ALUNO A 
LEFT JOIN TELEFONE T
ON(A.IDALUNO = T.IDALUNO)
INNER JOIN ENDERECO E
ON(A.IDALUNO = E.IDALUNO)
GO