
/* MODIFICADORES DE PARAMETROS REf E OUT */

---- REF ----

-- O parametro da função se torna uma referencia para a variavel original
-- Tem que Atribuir em ambos locais
-- Tem que inicialixar a variavel principal

Ex.

-- Classe
class Calculator{
	
	public statis void Triplica(ref int x){
		
		x = x * 3;
		
	}
	
}

-- Programa Principal

int a = 10;

Calculator.Triplica(ref a);

Console.WriteLine(a);

---- OUT ---- Saida

-- Similar ao "ref"
-- Não precisa iniciar a variavel principal

Ex.

-- Classe
class Calculator{
	
	public statis void Triplica(int origin, out int result){
		
		result = origin * 3;
		
	}
	
}

-- Programa Principal

int a = 10;
int triple;

Calculator.Triplica(a, out triple);

Console.WriteLine(triple);


