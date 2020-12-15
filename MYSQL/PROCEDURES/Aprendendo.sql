
/* STORAGE PROCEDURES */

-- Bloco nomeado, Procedimentos armzenados

-- 1° PASSO
-- Trocar DELIMITER
-- Ele ignora o ";" da programaçao dentro da procedure
DELIMITER $

-- 2° PASSO
-- Criar Procedure

-- Sem parametro
CREATE PROCEDURE Nome()
BEGIN
	query;
END
$

-- Sem parametro EX.
CREATE PROCEDURE Nome()
BEGIN
	Select 100 + 50 AS CONTA;
END
$

-- Com parametro
CREATE PROCEDURE Nome(Parametros)
BEGIN
	Query;
END
$

-- Com parametro EX.
CREATE PROCEDURE Nome(N1 INT, N2 INT)
BEGIN
	Select N1 + N2 AS CONTA;
END
$

-- Chamando Procedure
-- Podemos mudar o DELIMITER se nao for mais usar
DELIMITER ;

-- Sem parametro
CALL NomeProcedure();

-- Com parametro
CALL NomeProcedure(Valores);

-- Com parametro EX.
CALL NomeProcedure(100,50);

-- Deletando Procedure
DROP PROCEDURE NomeProcedure()