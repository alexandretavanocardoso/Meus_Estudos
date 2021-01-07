
/* EXCEÇÕES - TEORIA */

-- Qualquer condição de erro ou comportamento inesperado encontrado por um
programa em execução

-- No .NET, uma exceção é um objeto herdado da classe System.Exception

-- Quando lanãda, uma exceção é propragada na pilha de chamadas de métodos
em execução, até que seja capturada (tratada) ou  programa seja encerrado

POR QUE EXCEÇÃO ?	

-- O modelo de tratamento de exceções permite que erros sejam tratados de forma
consistente e flexivel, usando boas praticas

-- Vantagens {
	
	- Delega a lógica do erro para a classe / método responsável por conhecer
	as regras que podem ocasionar o erro
	
	- Trata de forma organixada (Inclusive Hierárquia) exceções de tipos diferentes
	
	- A exceção pode carregar dados quaisquer
	
} 

