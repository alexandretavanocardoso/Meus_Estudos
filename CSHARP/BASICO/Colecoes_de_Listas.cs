Trabalhar com coleções é algo bastante comum em diferentes linguagens de programação. O mais comum é a utilização de vetores. Entretanto, vetores apresentam algumas desvantagens, que em alguns casos tornam um pouco desinteressante a sua utilização. Entre as desvantagens estão a necessidade de se determinar a capacidade do vetor e a ausência de métodos de ordenação e filtragem, logo se você precisar ordenar um vetor, por exemplo, precisará escrever código que faça isso.


Para suprir essa necessidade, o .Net Framework oferece classes que representam coleções, com características específicas que tornam a sua utilização em interessante. Neste artigo será abordada a classe List, que é uma coleção genérica, que permitirá criar listas de tipos que a gente define quando realizamos a declaração.

Por exemplo:
Podemos criar uma lista de inteiros, representada por:
List<int>

Podemos criar uma lista de strings, representada por:
List<string>

De maneira geral podemos representar uma lista por:
List<T>
Onde T é o tipo dos itens que a coleção irá conter.

Obs.: Os exemplos a seguir não seguem uma sequência, apenas apresentam a forma de utilização dos métodos.

Vamos à um exemplo prático:
//Criaremos uma lista de inteiros.
List<int> minhaLista = new List<int>();



Principais propriedades:

Capacity: representa o número de elementos que a lista pode suportar sem que precise ser redimensionada. A partir desse número, novos elementos farão com que o compilador aloque mais memória para a lista.
Exemplo:
//Exibe a capacidade da lista
Console.WriteLine(minhaLista.Capacity);

Count: retorna a quantidade de itens que atualmente existe na lista.
Exemplo:
//Exibe a quantidade de itens da lista
Console.WriteLine(minhaLista.Count);



Principais métodos:
A seguir serão citados alguns dos principais métodos da classe List.

Add(T item): adiciona o parâmetro de tipo T (definido na declaração) no final da lista.
Exemplo:
//Adiciona o valor 5 na lista
minhaLista.Add(5);

AddRange(IEnumerable collection): adiciona todos os itens da coleção que foi passada como parâmetro à lista.
Exemplo:
List<int> outraLista = new List<int>();
outraLista.Add(10);
outraLista.Add(20);
outraLista.Add(30);
//Adiciona os itens de outraLista na minhaLista
minhaLista.AddRange(outraLista);

Clear(): como o nome sugere, esse método limpa a lista, removendo todos os elementos.
Exemplo:
//Limpa a lista
minhaLista.Clear();

Contains(T item): retorna um valor booleano indicando se o item pesquisado existe na lista.
Exemplo:
minhaLista.Add(10);
minhaLista.Add(20);
minhaLista.Add(30);
//Verifica se a lista possui o valor 10
if (minhaLista.Contains(10))
Console.WriteLine(“A lista possui o valor 10”);

Insert(int index, T item): funciona semelhante ao Add, mas insere o item em uma posição definida por index.
Exemplo:
minhaLista.Add(10);
minhaLista.Add(20);
//Insere o valor 30 no índice 1, ou seja, faz 30 tornar-se o segundo elemento.
minhaLista.Insert(1, 30); //Neste momento estão na lista 10, 30 e 20

InsertRange(int index, IEnumerable collection): funciona semelhante ao AddRange, mas insere a nova lista na posição definida por index.
Exemplo:
minhaLista.Add(10);
minhaLista.Add(14);
List<int> outraLista = new List<int>();
outraLista.Add(11);
outraLista.Add(12);
outraLista.Add(13);
//Insere os elementos de outraLista em minhaLista a partir do índice 1
minhaLista.Insert(1, outraLista); //Neste momento estão na lista 10, 11, 12, 13 e 14

Remove(T item): remove o item da lista e retorna um booleano indicando o sucesso da operação. Caso o item não seja encontrado, também retorna false.
Exemplo:
minhaLista.Add(10);
minhaLista.Add(20);
minhaLista.Add(30);
//Remove o valor 20 da lista
if (minhaLista.Remove(20))
Console.WriteLine(“Removeu com sucesso”);
else
Console.WriteLine(“Não encontrou o número”);

RemoveAt(int index): remove o item que está em uma posição específica na lista.
Exemplo:
minhaLista.Add(10);
minhaLista.Add(20);
minhaLista.Add(30);
//Remove o valor que está no índice 2 da lista
minhaLista.RemoveAt(2);

Sort(): ordena a lista utilizando o comparador padrão do tipo de item contido na lista. Este método também pode receber como parâmetro objetos que definem a forma como a comparação entre os itens deve ser feita.
Exemplo:
minhaLista.Add(10);
minhaLista.Add(40);
minhaLista.Add(90);
minhaLista.Add(30);
//Ordena o conteúdo da lista
minhaLista.Sort();



Percorrendo Listas

Existem diferentes formas para percorrer uma lista. A seguir são mostradas duas formas: uma usando for e outra foreach.

//Percorrendo a lista com foreach
foreach (int item in minhaLista)
{
     Console.WriteLine(item);
}

//Percorrendo a lista com for
for (int i=0; i<minhaLista.Count; i++)
{
     Console.WriteLine(minhaLista[i]);
}