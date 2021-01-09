
/* MATRIZES */

----- Declaração e Instanciação -----

 Tipo[,] Nomematriz = new Tipo[QtdLinhas, QtdColunas];

// Ex.
double[,] matriz = new double[2, 3];

----- Propriedades -----

-- Length

- Quantos Elementos a Matriz tem no Total

matriz.Length

-- Rank

- Quantidade de Linhas

matriz.Rank

-- GetLength

-- Tamanho das dimensões da matriz, linhas e colunas

matriz.GetLength(Posição)

----- Acesso aos Elementos e Percorrendo Matriz -----

-- Usamos o for

for (int i = 0; i < N; i++)
{
	string[] values = Console.ReadLine().Split(' ');

	for (int j = 0; j < N; j++)
	{
		mat[i, j] = int.Parse(values[j]);
	}
}

----- Exercicio -----
Console.Write("Numero de Linhas e Coluna: ");
int N = int.Parse(Console.ReadLine());

int[,] mat = new int[N, N];

for (int i = 0; i < N; i++)
{
	string[] values = Console.ReadLine().Split(' ');

	for (int j = 0; j < N; j++)
	{
		mat[i, j] = int.Parse(values[j]);
	}
}

Console.WriteLine("Main Diagonal: ");
for (int i = 0; i < N; i++)
{
	Console.Write(mat[i, i] + " ");
}

Console.WriteLine();

int count = 0;
for (int i = 0; i < N; i++)
{

	for (int j = 0; j < N; j++)
	{
		if(mat[i, j] < 0)
		{
			count++;
		}
	}
}
Console.WriteLine("Negative Numbers: " + count);