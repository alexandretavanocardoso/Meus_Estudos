

/* MEMBROS ESTÁTICOS */



// Exemplo

// Versão 1 - MÉTODOS NA PROPRIA CLASSE DO PROGRAMA

class Program
{
	static double Pi = 3.14;

	static void Main(string[] args)
	{
		Console.WriteLine("Digite o valor do raio: ");
		double raio = double.Parse(Console.ReadLine());

		double circ = Circunferencia(raio);
		double vol = -Volume(raio);

		Console.WriteLine("Circunferecia: " + circ.ToString("F2"));
		Console.WriteLine("Volume: " + vol.ToString("F2"));
		Console.WriteLine("Valor de Pi: " + Pi.ToString("F2"));
	}

	static double Volume(double r)
	{
		return 4.0 / 3 * Pi * Math.Pow(r, 3);
	}

	static double Circunferencia(double r)
	{
		return 2.0 * Pi * r;
	}
	
}

// Versão 2




