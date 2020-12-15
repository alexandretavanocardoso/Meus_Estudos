

/* CRIANDO AS CONSTRAINTS */

-- CONSTRAINS FORMA O NOME DA FK, PK NO BANCO DE DADOS

ALTER TABLE CONSULTA ADD CONSTRAINT FK_CONSULTA_PACIENTE
FOREIGN KEY(ID_PACIENTE) REFERENCES PACIENTE(IDPACIENTE);

ALTER TABLE CONSULTA ADD CONSTRAINT FK_CONSULTA_MEDICO
FOREIGN KEY(ID_MEDICO) REFERENCES MEDICO(IDMEDICO);

ALTER TABLE CONSULTA ADD CONSTRAINT FK_CONSULTA_HOSPITAL
FOREIGN KEY(ID_HOSPITAL) REFERENCES HOSPITAL(IDHOSPITAL);

ALTER TABLE INTERNACAO ADD CONSTRAINT FK_INTERNACAO_CONSULTA
FOREIGN KEY(ID_CONSULTA) REFERENCES CONSULTA(IDCONSULTA);
	