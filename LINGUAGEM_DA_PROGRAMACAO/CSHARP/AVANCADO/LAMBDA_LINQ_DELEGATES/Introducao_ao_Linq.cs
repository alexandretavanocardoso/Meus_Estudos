

/* INTRODUÇÃO AO LINQ  */

-- Language Integrate Query

- Conjunto de tecnologias baseadas na integração de funcionalidades de
onsulta diretamente na linguagem C#

-- Possui diversas operações de consultas, cujos parametros tipicamente são
expressões lambda ou expressões de sintaxe similar ao SQL

-- Tres Passos
	- Criar um data source (coleção, array, recurso de E/S, etc)
	- Definir a query
	- Executar a query (foreach ou alguma operação terminal)
	
/* Exemplo */

// Especifica data source
int[] numbers = new int() {2, 3, 4, 5};

// Definindo query
var result = numbers
	.Where(x => x % 2 == 0)
	.Select(x => x * 10);

// Executar Consulta
foreach(int x in result){
	Console.Write(x); // 20, 40
}

