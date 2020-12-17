CREATE table youtb(		
	id int primary key,
	nome varchar(150) not null unique,
	categoria varchar(200) not null,
	datacriacao datetime not null

);

--Adicionar
ALTER TABLE youtb
add ativo bit

--Alterar Coluna
ALTER TABLE youtb
ALTER COLUMN categoria varchar(200) not null

--Alterar Nome Coluna
EXEC sp_RENAME 'NomeTabela.NomeColunaAtual','NomeColunaNova','COLUMN'
--ex.
EXEC sp_RENAME 'youtb.nome','nome canal','COLUMN'

--Alterar Nome Tabela
EXEC sp_RENAME 'NomeTabelaAtual','NomeTabelaNova'
--ex.
EXEC sp_RENAME 'youtb','youtbtrocado'

select * from youtbtrocado
