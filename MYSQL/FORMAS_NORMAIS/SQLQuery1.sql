
/* FORMAS NORMAIS */

/*
-- 1° -- PRIMEIRA FN

	ATOMICIDADE - UM CAMPO NAO PODE SER DIVISIVEL
	- UM CAMPO NAO PODE SER VETORIZADO
	- PK - PRIMARY KEY

*/

/*
-- 2° -- SEGUNDA FN

	QUANDO TEM CHAVE COMPOSTA
	QUANDO TEM UMA TABELA COM AS PK
	
*/

/*
-- 3° -- TERCEIRA FN

	QUANDO TEM CHAVE COMPOSTA
	QUANDO TEM UMA TABELA COM AS PK
	
*/


-- EX. 2° E 3°

CREATE DATABASE CONSULTORIO;

CREATE TABLE PACIENTE(
	IDPACIENTE INT PRIMARY KEY AUTO_INCREMENT,
	NOME VARCHAR(30),
	SEXO CHAR(1),
	EMAIL VARCHAR(30),
	NASCIMENTO DATE
);

CREATE TABLE MEDICO(
	IDMEDICO INT PRIMARY KEY IDENTITY,
	NOME VARCHAR(30),
	SEXO CAHR(1),
	ESPECIALIDADE VARCHAR(30),
	FUNCIONARIO ENUM('S','N')
);

CREATE TABLE HOSPITAL(
	IDHOSPITAL INT PRIMARY KEY AUTO_INCREMENT,
	NOME VARCHAR(30),
	BAIRRO VARCHAR(30),
	CIDADE VARCHAR(30),
	ESTADO CHAR(2)
);

CREATE TABLE CONSULTA(
	IDCONSULTA INT PRIMARY KEY AUTO_INCREMENT,
	ID_PACIENTE INT,
	ID_MEDICO INT,
	ID_HOSPITAL INT,
	DATA DATETIME,
	DIAGNOSTICO VARCHAR(50)
);

CREATE TABLE INTERNACAO(
	IDINTERNACAO INT PRIMARY KEY AUTO_INCREMENT,
	ENTRADA DATETIME,
	QUARTO INT,
	SAIDA DATETIME,
	OBSERVACOES VARCHAR(50),
	ID_CONSULTA INT UNIQUE	
);