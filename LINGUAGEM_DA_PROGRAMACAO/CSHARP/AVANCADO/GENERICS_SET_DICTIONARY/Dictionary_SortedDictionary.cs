
/* DICTIONARY - SORTEDDICTIONARY */

-- Dictionary<TKey, TValue>

-- Coleção generica de pares chave/valor
	- Não admite rtepetições do objeto chave/valor
	- Os elementos são indexados pelo objeto chave (não possuem posição)
	- Acesso, inserção e remoção de elementos são rápidos
	
-- Uso comum: Cookies, local storage, qualquer modelo chave-valor

===>> Métodos Importante <<====

- dictionary[key] - Acessa o elemento pela chave informada

- add(key, value) - Adiciona elemento (exceção em caso de repetição)
- Clear() - Esvazia a coleção
- Counbt - Quantidade de chaves
- ContainsKey(key) - Verificar se a dada chave existe
- ContainsValue(value) - Verifica se o dado valor existe
- Remove(key) - Remove um elemento pela chave

====>> Dictionary <<====

-- Armazena em tabela Hash
-- Extremamente rápid: inserção, remoção e busca
-- A ordem dos elementos não é garantido

====>> SortedDictionary <<====

-- Armazena em arvore
-- Rapido: inserção, remoção e busca
-- Os elemetnos são armazenados ordenadamente conforme implemntação Icompare

/* Exemplo de Cookie */

Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "Aleexandre";
cookies["email"] = "alexandre@outloook.com";
cookies["fone"] = "99999999";

Console.WriteLine(coleção["email"]);
Console.WriteLine(coleção["fone"]);

cookies.Remove("email");

if(cookies.ContainsKey("email")){
	Console.WriteLine(coleção["email"]);
} else{
	Console.WriteLine("Error");
}

Console.writeLine("Tamanho: " + cookies.Count);

Console.WriteLine("Todos: ");
foreach(KeyValuePair<string, string> item in cookies){
	Console.WriteLine(item.Key + ": " + item.Value);
}

or

foreach(var item in cookies){
	Console.WriteLine(item.Key + ": " + item.Value);
}


















