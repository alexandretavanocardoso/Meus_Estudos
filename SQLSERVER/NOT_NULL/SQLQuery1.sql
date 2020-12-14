
Create Table CarteiraMotorista(
	id int not null,
	nome varchar(150) NOT NULL, --Obriga a colocar o nome
	idade int CHECK (idade >= 18)	
);

SELECT * FROM CarteiraMotorista
