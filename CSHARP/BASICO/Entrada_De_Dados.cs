

/* ENTRADA DE DADOS */

\\\\ A Partir Do Teclado \\\\
-- Retornados na forma de string

Console.ReadLine();
-- Le na forma de string
	
// Armazenando dado
string frase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

string[] vet = Console.ReadLine.Split(' ');
string a = vet[0];
string b = vet[1];
string c = vet[2];

// Imprimindo a dado armazenado
Console.WriteLine("Voce Digitou: ");
Console.WriteLine(frase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

\\\\ Outras Leituras \\\\

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double db = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] vet = Console.ReadLine().Split(' ');
string p1 = vet[0];
char p2 = char.Parse(vet[1]);
int p3 = int.Parse(vet[2])
double p4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(db.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
Console.WriteLine(p4.ToString("F2", CultureInfo.InvariantCulture)); 

