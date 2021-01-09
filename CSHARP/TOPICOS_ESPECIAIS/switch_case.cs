
/* SWITCH CASE */

-- Estrutura opcional a if e else
	
var Variavel = valor;

switch(variavel){
	case 1:
		Comando
		break;
	case 2:
		Comando
		break;
	case 3:
		Comando
		break;
	default:
		Caso nada dar certo
		break;
}

// Exemplo 
int x = int.Parse(Console.ReadLine());
string day;

switch (x)
{
	case 1:
		day = "Sunday";
		break;
	case 2:
		day = "Monday";
		break;
	case 3:
		day = "Tuesday";
		break;
	default:
		day = "Invalid";
		break;
}

Console.WriteLine("Day: " + day);
