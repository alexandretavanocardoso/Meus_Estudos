

/* ACTION (Exemplo com Foreach) */

-- Representa um método void que recebe zero ou mais argumentos

-- Até 16 sobrecargas: EX.
public delegate void Action(); // Sem
public delegate void Action<in T>(T obj);
public delegate void Action<in T, in T2>(T1 arg, T2 arg);

/* Exemplo */


List<Produto> lista = neew Lista<Produto>();

lista.Add(new Produto("Garfo", 10.00));
lista.Add(new Produto("Ropa", 20.00));

Action<Produto> act = ValorAtualizado; // funçaõ aux
Action<Produto> act = p => {p,Price += p.Price * 0.1; }; // Usando expressão lambd

list.Foreach(act);
foreach (Produto p in lista){
	Console.WriteLine(p);
}

/* Expressão aux */

static void ValorAtualizado(produto p){
	p.Price += p.Price * 0.1;
}


