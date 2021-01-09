
/* HASHSET - SORTEDSET */

-- Representa um conjunto de elementos (similar ao da Algebra)
	- Não admite repetições
	- Elementos não possum posição
	- Acesso, inserção e remoçao de elementos sao rapidos
	- Oferece operações eficientes de conjunto: interseção, união, diferença
	
====>> Métodos Importantes <<====

-- Add()
-- Clear
-- Contains() - Verifica se tem existe ou não o elemento, retorna true ou false
-- UnionWith(other) - Operação união: Adiciona no conjunto os elementos do 
outro conjunto, sem repetoção
-- IntersectWith(other) - operação interseção: Remove do conjunto os elementos não contidos
em other
-- ExceptWith(other) - operação de diferença: Remover do conjunto os elementos contidos
em other
-- Remove(T)
-- RemoveWhere(predicato)

====>> HashSet<T> <<====

-- Armazena os elementos organizando em uma tabela HashSet
-- Extremamente rápido: inserção, remoção, busca
-- A ordem dos elementos nãp é garantida

====>> SortedSet<T> <<====

-- Armazena em árvore
-- Rápido: inserção, remoção e busca
-- Os elementos são armazenados ordenadamente conforme implementação IComparer<T>


/* Exemplo HashSet */

HashSet<string> set = new HashSet<string>(); // Instanciando conjunto

set.Add("TV");

Console.WriteLine(set.Contains("TV")); // true

foreach(string p in set){
	Console.WriteLine(p)
}

/* Exemplo SortedSet */

SortedSet<int> a = new SortedSet<int>() { 0, 2, 3, 4, 10}; // Instanciando coleção
SortedSet<int> b = new sortedSet<int>() { 5, 7, 9, 10, 2};

ImprimiColecao(a); // imprimi coleção

// union
SortedSet<int> c = new SortedSet<int>(a); // instanciano e inserindo elementos de outro conjunto
c.UnionWith(b); // União de c com b

ImprimiColecao(c);

// intersection -- elementos que existem em ambos conjuntos
SortedSet<int> d new SortedSet<int>(a);
d.IntersectWith(b); // Intersecção de a e b

ImprimiColecao(d);

// difference --  elementos que não existem em ambos conjuntos
SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b)/ // Diferença entre a e b

ImprimiColecao(e);

// função auxiliar
static void ImprimiColecao<T>(IEnumerable<T> collection){
	foreach (T obj in collection){
		Console.Write(obj + " ");
	}
	Console.WriteLine();
}



























