
/* TRIGGER - GATILHO */

-- NEW - NOVO - INSERT
-- OLD - VELHO - DELETE
-- UPDATE - NEW, OLD

-- ESTRUTURA
DELIMITER $
CREATE TRIGGER NOME
BEFORE/AFTER INSERT/DELETE/UPDATE ON TABELA
FOR EACH ROW -- PARA CADA LINHA
BEGIN -- INICIO

	QUALQUER COMANDO SQL;

END $-- FIM

-- DROPANDO

DRP TRIGGER NOME_TRIGGER;

/* PRATICA */

DELIMITER $

-- USANDO DELETE, OLD
-- ESSA TRIGGER, SERIA QUE ANTES DE DELETAR O USUARIO VAI INSERIR ELE NA TABLA DE BACKUP
CREATE TRIGGER BACKUP_USER
BEFORE DELETE ON USUARIO -- (ANTES DO DELETE, OLD)
FOR EACH ROW -- PARA CADA LINHA
BEGIN -- INICIO

	INSERT INTO BKP_USUARIO VALUES
	(NULL, OLD.IDUSUARIO, OLD.NOME, OLD.LOGIN)

END $ -- FIM
