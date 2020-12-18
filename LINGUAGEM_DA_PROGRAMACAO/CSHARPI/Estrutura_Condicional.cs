

/* ESTRUTURA CONDICIONAL  */

	if(condicao)
	{
		comando;
	}
	else
	{
		comando;
	}
-------------------------
	if(condicao)
	{		
		comando;
	}
	else if(condicao)
	{
		comando;
	}
	else {
		comando;
	}
	
-------------------------
	if(condicao)
	{		
		comando;
	}
	else if(condicao)
	{
		comando;
	}
	else if(condicao){
		comando;
	}
	else{
		comando;
	}
			
/* Exemplo Avançados */

int a = 50;
int b = 30;

if(a > 20 && b < 50)
{
	Console.WriteLine("Tudo Certo");
}
else
{
	Console.WriteLine("Uma Condição esta errada");
}

if (a > 20 || b > 50)
{
	Console.WriteLine("Tudo Certo");
}
else
{
	Console.WriteLine("Uma Condição esta errada");
}

if (a > 20 != b > 50)
{
	Console.WriteLine("Uma Condição esta errada");
}
else
{
	Console.WriteLine("Tudo Certo");
}

