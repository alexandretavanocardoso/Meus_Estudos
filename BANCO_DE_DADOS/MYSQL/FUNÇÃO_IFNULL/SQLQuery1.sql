
/* FUNÇÃO IF NULL */

-- Se alguma coluna tiver dados nulos 
-- tem que passar parametros (Coluna, " Texto pra aparecer pro cliente")

-- IFNULL(Coluna, " Texto ") AS Apelido

SELECT 
IFNULL(C.NOME, "SEM NOME") AS NOME,
IFNULL(C.EMAIL, "SEM E-MAIL") AS E-MAIL,
IFNULL(C.ESTADO, "SEM ESTADO") AS ESTADO,
N.NUMERO
FROM CLIENTE C
INNER JOIN ENDERECO E
ON C.IDCLIENTE = E.IDCLIENTE
INNER JOIN NUMERO N
ON N.IDCLIENTE = N.IDCLIENTE