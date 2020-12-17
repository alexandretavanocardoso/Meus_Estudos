

/* IF E ELSE */

IF(@NUMERO = 5)
	PRINT ('O VALOR É VERDADEIRO')
ELSE
	PRINT ('O VALOR É FALSO')

DECLARE
	@NUMERO INT = 5
BEGIN

	IF(@NUMERO = 5)
		PRINT ('O VALOR É VERDADEIRO')
	ELSE
		PRINT ('O VALOR É FALSO')	
END
GO

/* CASE */

DECLARE
	@CONT INT
BEGIN
	
	SELECT 
		    CASE
				WHEN COLUNA1 = 'FIAT' THEN 'FAIXA1'
				ELSE 'OUTRA OPÇAO'
		    END AS COLUNA1TEXTO,
		    
			CASE			
				WHEN COLUNA2 = 'FORD' THEN 'FAIXA2'
				ELSE 'OUTRA FAIZA'
			END AS Coluna2TEXTO,
			
			CASE			
				WHEN COLUNA3 = 'FORD' THEN 'FAIXA3'
				WHEN COLUNA4 = 'FORD' THEN 'FAIXA4'
				ELSE 'OUTRA FAIZA'
			END AS Coluna2TEXTO
	FROM TABELA
	
END
GO



