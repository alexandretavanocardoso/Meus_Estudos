

/* PROCEDURES */

--- ESTRUTURA
CREATE PROC NOME_PROC
AS
	QUERY
GO

-- EXECUTANDO
EXEC NOME_PROC


-- APAGANDO
DROP PROC NOME_PROC
GO

-- CRIANDO TABELAS TESTES
CREATE TABLE PESSOA(
	IDPESSOA INT NOT PRIMARY KEY IDENTITY,
	NONE VARCHAR(30) NOT NULL,
	SEXO CHAR(1) NOT NULL CHECK(SEXO IN('M', 'F')),
	NASCIMENTO DATE NOT NULL
);
GO

CREATE TABLE TELEFONE(
	IDTELEFONE INT NOT PRIMARY KEY IDENTITY,
	MONE VARCHAR(30) NOT NULL,
	TIPO CHAR(1) NOT NULL,
	NUMERO CHAR(10) NOT NULL,
	IDPESSOA INT
);
GO

ALTER TABLE TELEFONE
ADD CONSTRAINT FK_PESSOA
FOREIGN KEY(IDPESSOA)
REFERENCES PESSOA(IDPESSOA)
GO

INSERT INTO PESSOA VALUES('ANTONIO','M','1981-02-13')
INSERT INTO TELEFONE VALUES('CEL','9879008', 1)
GO

/* CRIANDO PROCEDURE SEM PARAMETROS */

CREATE PROC SOMA
AS
	SELECT 10 +10 AS SOMA
GO

-- EXECUÇÃO DA PROC
EXEC SOMA
GO

/* CRIANDO PROCEDURES COM PARAMETROS */
CREATE PROC CONTA @NUM1 INT, @NUM2 INT
AS
	SELECT @NUM1 + #NUM2 AS RESULTADO
GO

-- EXECUÇÃO DA PROC 
EXEC CONTA 90, 78
GO

-- APAGANDO
DROP PROC CONTA
GO
	
/* PROCEDURES COM TABELAS */
SELECT P.NOME, N.NUMERO
FROM PESSOA P
INNER JOIN TELEFONE T
ON P.IDPESSOA = T.IDPESSOA
WHERE TIPO = 'CEL'

-- CRIANDO PROC
--- VAI TRAZRE OS TELEFONES DE ACORDO COM O TIPO PASSADO
CREATE PROC TELEFONES @TIPO CHAR(3)
AS
	SELECT P.NOME, N.NUMERO
	FROM PESSOA P
	INNER JOIN TELEFONE T
	ON P.IDPESSOA = T.IDPESSOA
	WHERE T.TIPO = @TIPO
GO


EXEC TELEFONE 'CEL'
GO

EXEC TELEFONE 'TEL'


/* PARAMETROS DE OUTPUT - SAIDA */

SELECT TIPO COUNT(*) AS QUANTIDADE
FROM TELEFONE
GROUP BY TIPO
GO

CREATE PROC GET_TIPO @TIPO CHAR(3), @CONTADOR INT OUTPUT
AS
	SELECT @CONTADOR = COUNT(*) FROM TELEFONE
	WHERE TIPO = @TIPO
GO

DECLARE @SAIDA INT
EXEC GET_TIPO @TIPO = 'CEL', @CONTADOR = @SAIDA OUTPUT
-- IMPRIMINDO VARIAVEL
SELECT @SAIDA
GO






























