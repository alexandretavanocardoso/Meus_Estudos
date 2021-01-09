
/* GETHASHCODE - EQUALS */

====>> GetHashCode <<====

-- São operações de classe Object utilizdas para compara se um objeto é igual ao outro

-- Rápido, porém resposta positava nao é 100%

-- Retorna um numero inteiro representando um código gerado a partir das informações do
objeto

Ex.

string a = "Maria";
string b = "Alex";

// Console.WriteLine(object.GetHashCode);

Console.WriteLine(a.GetHashCode()); // -159319
Console.WriteLine(b.GetHashCode()); // 649970431

===> Equals <===

-- São operações de classe Object utilizdas para compara se um objeto é igual ao outro

-- leento, resposta 100%

-- retorna true ou false

Ex.

string a = "Maria";
string b = "Alex";

// Console.WriteLine(object1.Equals(object2));

Console.WriteLine(a.Equals(b)); // false