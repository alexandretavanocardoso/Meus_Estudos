
/* NULLABLE */

-- Recurso para que dados tipo valor (struct) possam receber o valor null

-- Para dados Opcionais que pode ter nulos

	Nullable<double> x = null; 

		OU

	double? x = null;
	
-- Nele existe 3 operações basicas --

- GetValueOrDefault() - Pega o valor da variavel, porem se o valor é nulo imprimi o "0"
- HasValue - Verificar se tem valor, imprimi false ou true
- Value - Pega o valor da variavel, porém se o valor é null da erro. Para funcionar com]
valores nulos tem que fazer uma validação verificando se tem valor ou não

-- EX.

double? x = null;
double? y = 10.0;

Console.WriteLine(x.GetValueOrDefault()); // Valor 0
Console.WriteLine(y.GetValueOrDefault()); // valor 10

Console.WriteLine(x.HasValue); // false
Console.WriteLine(y.HasValue); // true

if(x.HasValue) // validação se for nulo
	Console.WriteLine(x.Value); // Se tiver valor
else
	Console.WriteLine("X é nulo"); // Se fou 

-- Operador de coalescência nula --

double? x = null;
double? y = 10;

double a = x ?? 5;
double b = y ?? 10;

Console.WriteLine(a);
Console.WriteLine(b);


