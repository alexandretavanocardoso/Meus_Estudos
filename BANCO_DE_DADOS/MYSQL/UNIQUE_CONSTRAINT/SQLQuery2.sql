
/* UNIQUE */

-- OBRIGA A NAO TER REPETICOES DE VALORES

CREATE TABLE EX(
	id int not null,
	CodigoCNH int not null UNIQUE
);

SELECT  * FROM EX

insert into EX (id,CodigoCNH) values (1,123456)

--Da erro pois o UNIQUE obriga a nao ter repetiçao de valores
insert into EX (id,CodigoCNH) values (1,123456)