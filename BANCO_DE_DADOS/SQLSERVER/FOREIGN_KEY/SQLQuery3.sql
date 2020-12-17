

/* Foreign key */

CREATE TABLE Tabela (
	TabelaId INT PRIMARY KEY AUTO_ENCREMENT,		
	Nome VARCHAR(30) NOT NULL,
	TabelaForeignId INT, 
	FOREIGN KEY(TabelaForeignId) 
	REFERENCES TabelaForeign(TabelaForeignId) 
);
CREATE TABLE TabelaForeign (
	TabelaForeignId INT PRIMARY KEY AUTO_ENCREMENT,		
	Nome VARCHAR(30) NOT NULL,
);

/* Foreign key com UNIQUE */]
-- Uma unica chave estrangeira (Id) vindo da tabela para cada um

/* Chave Estrangeira 1 x 1 - UNIQUE*/
-- Apenas um dado pra um

CREATE TABLE Cidade (
	CidadeId INT PRIMARY KEY AUTO_ENCREMENT,		
	Nome VARCHAR(30) NOT NULL,
	EstadoId INT UNIQUE, 
	FOREIGN KEY(EstadoId) 
	REFERENCES Estado(EstadoId) 
);

CREATE TABLE Estado (
	EstadoId INT PRIMARY KEY AUTO_ENCREMENT,
	Nome VARCHAR(30)
);


