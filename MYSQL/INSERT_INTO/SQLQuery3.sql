CREATE TABLE Aula(
	Aulaid INT PRIMARY KEY,
	Nome VARCHAR(200)
);



INSERT INTO Aula (Aulaid,Nome)
VALUES (1,'Aula1')

SELECT * FROM Aula

--Varias Linhas


INSERT INTO Aula (Aulaid,Nome)
VALUES 
(2,'Aula2'),
(3,'Aula3'),
(4,'Aula4');

--Inserir informaçoes da um Tabela para outra tabela existente

SELECT * INTO TabelaNova FROM Aula --CRIA UMA TABELA E JA JOGA AS INFORMAÇOES

SELECT * FROM TabelaNova	

--Desafio

CREATE TABLE Escola(
	Escolaid INT PRIMARY KEY,
	Nome VARCHAR(100)
);


CREATE TABLE Escola5(
	Escola5id INT PRIMARY KEY,
	Nome VARCHAR(100)
);

SELECT * FROM Escola5

INSERT INTO Escola (Escolaid,Nome) VALUES (1,'Verdão')
INSERT INTO Escola (Escolaid,Nome) VALUES (2,'Adelaide'), (3,'Castelo'), (4,'Sesi');

INSERT INTO Escola5(Escola5id,Nome) VALUES (1,'Tyto')




