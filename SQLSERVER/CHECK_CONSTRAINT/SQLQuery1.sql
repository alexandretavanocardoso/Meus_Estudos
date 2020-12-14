
/* Checa se a condição esta valida*/

Create Table CarteiraMotorista(
	id int not null,
	nome varchar(150) not null,
	idade int CHECK (idade >= 18)
);

insert into CarteiraMotorista (id,nome,idade) values (1,'Alexandre','18') 

Select * from CarteiraMotorista

insert into CarteiraMotorista (id,nome,idade) values (1,'Alexandre','17') --Da erro, Pois colocamos na tabela	
																	      --que o minimo de idade que pode ser
																		  --inserida é "18", 'idade int CHECK (idade >= 18)'