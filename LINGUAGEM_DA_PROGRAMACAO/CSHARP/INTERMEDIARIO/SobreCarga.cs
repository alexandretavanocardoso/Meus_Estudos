
/* SOBRECARGA */

-- Pode ser Padrao sem parametros

// Exemplo:

// Fazendo constutor

public Produto(string nome, double preco)
{
	Nome = nome;
	Preco = preco;
	Quantidade = 5;
}

// ao inves de perguntar ao usuario pra digitar a qtd

-- joga a quantidade direto sem o usuario digitar

produto p new Produto(nome, preco);

// Exemplo sem parametro, (Padrao)
public Produto()
{
}