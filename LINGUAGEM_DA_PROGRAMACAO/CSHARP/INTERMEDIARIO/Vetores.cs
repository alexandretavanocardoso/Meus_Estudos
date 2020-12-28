
/* VETORES */

Ex 1 -- Struct

Console.Write("Digite a quantidade de pessoas: ");
int N = int.Parse(Console.ReadLine());

double[] Vect = new double[N]; // Criando Vetor

for (int i = 0; i < N; i++)
{
	Console.Write("Digite a altura #{0}:  ", i);
	Vect[i] = double.Parse(Console.ReadLine()); // Grava no Vetor
}

double sum = 0.0;
for (int i = 0; i < N; i++)
{
	sum += Vect[i]; // Soma com os valores do vetor
}

double avg = sum / N;

Console.WriteLine("Altura Média: " + avg.ToString("F2"));

EX 2 -- Classe

class Produto // Classe Produto
{
	public string Nome { get; set; }
	public double Preco { get; set; }
}

Console.Write("Digite a quantidade de produtos: ");
int N = int.Parse(Console.ReadLine());

Produto[] Vect = new Produto[N]; // Criando Vetor

for (int i = 0; i < N; i++)
{
	Console.Write("Digite o nome do produto #{0}: ", i );
	string nome = Console.ReadLine();

	Console.Write("Digite o preço do produto #{0}: ", i);
	double preco = double.Parse(Console.ReadLine());

	Vect[i] = new Produto { Nome = nome, Preco = preco }; // Instanciando valores
}

double soma = 0.0;

for (int i = 0; i < N; i++)
{
	soma += Vect[i].Preco;    
}

double avg = soma / N;

Console.Write(avg.ToString("F2"));

