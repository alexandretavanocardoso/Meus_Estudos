

/* FUNC (Exemplo com Select) */

- Representa um método que recebe 0 ou mais argumentos e retorna valor

-- 16 Sobrecargas igual Action<>

/* Exemplo */

List<Produto> lista = new Lista<Produto>();

lista.Add(new Produto("Garfo"));
lista.Add(new Produto("Ropa"));

List<string> result = list.Select(NameToUpper).ToList(); -- toList() - converte pra listas
foreach (string s in result){
	Console.WriteLine(s);
}

/* aux */
static string NameToUpper(Produto p){
	return p.Name.ToUpper();
}