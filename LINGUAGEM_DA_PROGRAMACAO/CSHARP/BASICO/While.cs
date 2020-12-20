

/* WHILE */

// Se a condiçao estiver correta faz o Looping

While ( Condicao ) {
	
	comando;
	
};

While ( Condicao ) {
	
	comando;
	
	var++;
};

/* Exemplos */

Console.Write("Digite um numero: ", " ");
double x = double.Parse(Console.ReadLine());

while (x >= 0)
{
	double raiz = Math.Sqrt(x);
	Console.WriteLine(raiz.ToString());

	Console.Write("Digite outro numero: ", " ");
	x = double.Parse(Console.ReadLine());

	x++;
};

Console.Write("Numero Negativo: ", " ");
