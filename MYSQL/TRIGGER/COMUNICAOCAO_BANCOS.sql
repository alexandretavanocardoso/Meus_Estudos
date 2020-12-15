
/* TRIGGER - GATILHO */

-- NEW - NOVO - INSERT
-- OLD - VELHO - DELETE
-- UPDATE - NEW, OLD

/* PARA BACKUPS DE BANCOS, UM PARA O OUTRO */

-- COMUNICAÇÃO, USAR "."
NOMEBANCO.NOMETABELA

DELIMITER $
CREATE TRIGGER BACKUP_TABELA
BEFORE	INSERT ON TABELA
FOR EACH ROW
BEGIN
	INSERT INTO BACKUP_TABELA.TABELA_COLUNA VALUES(VALORES);
END$

-- EXEMPLO
DELIMITER $
-- INSERINDO
CREATE TRIGGER BACKUP_PRODUTO
BEFORE	INSERT ON PRODUTOS
FOR EACH ROW
BEGIN
	-- INSERT INTO BACKUP.BKP_PRODUTOS VALUES(); 
	INSERT INTO BACKUP.BKP_PRODUTOS VALUES(NULL,NEW.IDPRODUTO,
										   NEW.NOME, NEW.VALOR);
END$

-- DELETANDO
CREATE TRIGGER BACKUP_PRODUTO
BEFORE DELETE ON PRODUTOS
FOR EACH ROW
BEGIN
	-- INSERT INTO BACKUP.BKP_PRODUTOS VALUES(); 
	INSERT INTO BACKUP.BKP_PRODUTOS VALUES(NULL,OLD.IDPRODUTO,
										   OLD.NOME, OLD.VALOR);
END$

DELIMITER ;

CREATE DATABASE LOJA;
USE LOJA;

CREATE TABLE PRODUTOS(
	IDPRODUTO INT PRIMARY KEY,
	NOME VARCHAR(30),
	FLOAT(10,2)
);

CREATE DATABASE BACKUP;
USE BACKUP;

CREATE TABLE BKP_PRODUTOS(
	IDBKP INT PRIMARY KEY,
	IDPRODUTO INT;
	NOME VARCHAR(30),
	FLOAT(10,2)
);
