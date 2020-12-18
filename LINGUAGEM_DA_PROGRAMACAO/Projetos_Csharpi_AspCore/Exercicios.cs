

/* EXERCICIOS */

/* 1 */

string produto1 = " Computador ";
string produto2 = " Mesa de Escritório ";

int idade = 30;
int codigo = 5290;
char genero = " M ";

double preco1 = 120.00;
double preco2 = 200.00;
double total = preco1 + preco2;

Console.WriteLine(" Produtos: {0}, {1}", produto1, produto2);
Console.WriteLine(" Computador: cujo o preço é: " + preco1);
Console.WriteLine(" Mesa: Cujo o preço é: " + preco2);
Console.WriteLine(" O total é de: {0} ", total);

Console.WriteLine(" Registro: {0} anos de idade, Código {1}, genero {3}", idade, codigo, genero);

/* 2 */

Console.Write("Digite seu nome: ", " ");
string nome = Console.ReadLine();

Console.Write("Digite o numero de quarto: ", " ");
int quarto = int.Parse(Console.ReadLine());

Console.Write("Digite o preco dos quartos: ", " ");
double preco = double.Parse(Console.ReadLine());

Console.Write("Digite seu sobrenome, idade, altura: ", " ");
string[] combo = Console.ReadLine().Split(' ');

string sobreNome = combo[0];
int idade = int.Parse(combo[1]);
double altura = double.Parse(combo[2]);

Console.WriteLine("Confirmando seus Registros: ");
Console.WriteLine(nome);
Console.WriteLine(quarto);
Console.WriteLine(preco);
Console.WriteLine(sobreNome);
Console.WriteLine(idade);
Console.WriteLine(altura);

/* 3 */

