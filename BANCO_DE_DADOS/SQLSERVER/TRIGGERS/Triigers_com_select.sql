

/* TRIGGERS COM SELECT */

/* TABELA TRIGGER COM SELECT */
CREATE TABLE EMPREGADO(
	IDEMPREGADO INT PRIMARY KEY IDENTITY,
	NOME VARCHAR(30),
	SALARIO MONEY,
	IDGERENTE INT
		
);
GO

ALTER TABLE EMPREGADO
ADD CONSTRAINTS FK_GERENTE
FOREIGN KEY(IDGERENTE)
REFERENCES EMPREGADO(IDEMPREGADO
GO

INSERT INTO EMPREGADO VALUES('CLARA', 5.000, NULL)
INSERT INTO EMPREGADO VALUES('CELIA', 5.000, 1)
INSERT INTO EMPREGADO VALUES('FERNANDA', 8.000, 1)
GO

CREATE TABLE HIST_SALARIO(
	IDEMPREGADO INT,
	NOME VARCHAR(30),
	ANTIGOSALARIO MONEY,
	NOVOSALARIO MONEY,
	DATA DATETIME


-- CREANDO TRIGGER
CREATE TRIGGER TRG_SALARIO
ON DBO.EMPREGADO
FOR UPDATE AS
IF UPDATE(SALARIO)
BEGIN
	
	INSERT INTO HIST_SALARIO 
	(IDEMPREGADO, NOME, ANTIGOSALARIO, NOVOSALARIO,DATA)
	SELECT D.IDEMPREGADO, I.NOME D.SALARIO, I.SALARIO, GETDATE()
	FROM DELETED D, INSERTED I
	WHERE D.IDEMPREGADO = I.IDEMPREGADO
	
END
GO


/* VARIAVEIS COM SELECT */

CREATE TABLE RESULTADO(
	IDRESULTADO INT PRIMARY KEY IDENTITY,
	RESULTADO INT
);

INSERT INTO RESULTADO VALUES((SELECT 10 + 10))
GO

-- VARIAVEIS - ANONIMO

DECLARE   @RESULTADO INT
SET @RESULTADO = (SELECT 10 + 10)
INSERT INTO RESULTADO VALUES(@RESULTADO)
PRINT 'VALOR INSERIDO NA TABELA ' + CAST(@RESULTADO AS VARCHAR)
GO