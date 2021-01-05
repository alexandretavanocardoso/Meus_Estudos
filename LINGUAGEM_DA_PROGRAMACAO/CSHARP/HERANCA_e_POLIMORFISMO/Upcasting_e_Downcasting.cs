
/* Upcasting e Downcasting */

-- Casting é converter de um tipo para outro

====>> Upcasting <<====

-- Casting da subclasse para superclasse
-- Uso comum: Polimorfismo


NomeClass varSuperClasse = varSubclasse;


====>> Downcasting <<====

-- Casting da superclassse para subclasse
-- Palavra "as"
-- Palavra "is"
-- Uso comum: métodos que recebem parametros genericos (Ex. Equals)

NomeSubClass varSubClasse = (NomeSubClass)varSuperclasse;

-- ' as ' ' Associar de outra sintaxe '

Tipo var = var as Tipo


-- ' is ' ' Testa e Verifica se é uma Instância  '

if(variavel is SubClasse){
	
}

