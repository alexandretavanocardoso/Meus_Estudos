
/* TRIGGER - GATILHO */

-- IMPLEMENTA A COMUNICAÇÃO DE BANCO DE DADOS

/* AFTER, BEFORE, INSERT, DELETE OU UPDATE */

-- BEFORE - ANTES
-- AFTER - DEPOIS

-- INSERT - NEW
-- DELETE - OLD
-- UPDATE - OLD, NEW


ALTER TABLE NomeBanco.NomeTabela
ADD EVENTO CHAR(1);

CREATE TRIGGER NomeTrigger
BEFORE DELETE ON PRODUTOS
FOR EACH ROW
BEGIN
	-- INSERT INTO BACKUP.BKP_PRODUTOS VALUES(); 
	INSERT INTO BACKUP.BKP_PRODUTOS VALUES(NULL,OLD.IDPRODUTO,
										   OLD.NOME, OLD.VALOR,'EVENTO');
END$

-- EX.

ALTER TABLE BACKUP.BKP_PRODUTO
ADD EVENTO CHAR(1);

DELIMITER $

-- DELETANDO
CREATE TRIGGER BACKUP_PRODUTO
BEFORE DELETE ON PRODUTOS
FOR EACH ROW
BEGIN
	-- INSERT INTO BACKUP.BKP_PRODUTOS VALUES(); 
	INSERT INTO BACKUP.BKP_PRODUTOS VALUES(NULL,OLD.IDPRODUTO,
										   OLD.NOME, OLD.VALOR,'D');
END$



