

/* FOR - Para */

// Se a condiçao estiver correta faz o Looping

for(inicio; condicao, incremento)
{
	Comando;
}

// Ex. Basico

for (int i = 0; i < length; i++)
{

}

// Ex. Exercicio

Console.Write(" Quantos numeros inteiros voce vai digitar? ");
int N = int.Parse(Console.ReadLine());

int soma = 1;
for (int i = 1; i <= N; i++)
{
	Console.Write("Valor #{0}: ", i);
	int valor = int.Parse(Console.ReadLine());
	soma = soma * valor;
}

Console.Write("Soma é igual a: " + soma);