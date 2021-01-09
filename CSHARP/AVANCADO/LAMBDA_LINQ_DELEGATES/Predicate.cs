

/* PREDICATE  */

-- Representa um método que recebe um objeto do tipo T e retorna um valor bool


public delegate bool Predicate<in T>(T obj);

// Exemplo

List<Produto> lista = new Lista<Produto>();

lista.Add(new Produto("Garfo"));
lista.Add(new Produto("Ropa"));

// Exemplo predicate com RemoveAll

lista.RemoveAll(p => p.Name == "Garfo");

foreach (Produto p in lista){
	Console.Write(p);
}

