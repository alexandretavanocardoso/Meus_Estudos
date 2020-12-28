
/* LISTAS */

----- Declarando e Criando uma lista vazia -----

List<Tipo> NomeLista = new List<Tipo>();

// Ex
List<string> list = new List<string>();

----- Declarando e Crianco uma lista com valores -----

List<Tipo> NomeLista = new List<Tipo> { Valores };

// Ex
List<string> list2 = new List<string> { "Maria", "Alex" };

----- Inserindo elementos na lista -----

Add() - Adiciona os elementos no final da lista 
Insert() - Adiciona os elementos na posição desejada, Ex. list.Insert(1, "Primeira");

----- Tamanho da Lista -----

Count - Conta o Tamanho da lista, list.Count

----- Encontrar Primeiro ou Ultimo Elementos da Lista -----

list.Find - Primeiro, list.Find(Função ou Expressão Lambda)
list.FindLast - Ultimo, list.FindLast(Função ou Expressão Lambda);

----- Encontrar Primeira ou Ultima Posição de Elementos na Lista -----

list.FindIndex - Primeira, list.FindIndex(Função ou Expressão Lambda);
list.FindLastIndex - Ultima, list.FindIndex(Função ou Expressão Lambda);

----- Filtrar a Lista com Base em um Predicado -----

list.FindAll - Filtra Criando outra Lista com os valores, List<string> list2 = list.FindAll(Função ou Expressão Lambda);

----- Remover Elementos da Lista -----

Remove - Remove os selecionados, list.Remove(valor)
RemoveAll - Remove Todos com o valor selecionado, list.RemoveAll(Função ou Expressão Lambda)
RemoveAt - Remove Pela Posição, list.RemoveAt(Posição);
RemoveRange - Remove os Elementos de uma Faixa,  list.RemoveRange(Posição, Qtd de elementos que vai ser removido após a posição);

----- Exemplos Práticos -----

List<string> list = new List<string>();

// Exemplo com Add e Insert
list.Add("Alexandre");
list.Add("Ricardo");
list.Add("Ana");
list.Insert(1, "Marco");

// Exemplo com Count
Console.WriteLine(list.Count);

// Exemplo com Find e FindLast
string s1 = list.Find(x => x[0] == 'A');
string s2 = list.FindLast(x => x[0] == 'A');

// Exemplo FindIndex e FindLastIndex
int p1 = list.FindIndex(x => x[0] == 'A');
int p2 = list.FindLastIndex(x => x[0] == 'A');

// Exemplo com FindAll
List<string> list2 = list.FindAll(x => x.Length > 5);

// Exemplo Remove, RemoveAll, RemoveAt, RemoveRange
list.Remove("Marco");
list.RemoveAll(x => x[0] == 'M');
list.RemoveAt(3);
list.RemoveRange(2, 2);