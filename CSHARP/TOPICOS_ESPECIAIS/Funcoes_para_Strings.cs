
/* FUNÇÕES PARA STRINGS */

----- Formatar -----

ToLower() - Formata tudo em minusculo, ex.  string s1 = origin.ToLower();
ToUpper() - Formata tudo em Maiusculo, ex.  string s1 = origin.ToUpper();
Trim() - Apaga os Espaços em Brancos, ex.  string s1 = origin.Trim();

----- Buscar -----

IndexOf - Primeiro, pesquisa pela posição, int n1 = origin.IndexOf("bc");
LastIndexOf - Ultimo, pesquisa pela posição, int n1 = origin.LastIndexOf("bc");

----- Recortar -----

Substring(inicio) - Começar a cortar na posição escolhida, ex. string s4 = origin.Substring(2);
Substring(inicio, tamanho) - Começar a cortar na posição escolhida e para na posiçao escolhida, ex. string s4 = origin.Substring(2, 10);
Split(' ') - Recorta com base em um caracter

----- Substituir -----

Replace(char, char) - Muda um tipo Char, ex. string s6 = origin.Replace('a', 'x');
Replace(string, string) - Muda um tipo String, ex. string s6 = origin.Replace('a', 'x');

----- Outros -----

String.IsNullOrEmpty(str) - Ve se a variavel é nula, ex. String.IsNullOrEmpty(origin);
String.IsNullOrWhiteSpace(str) - Ve se a variavel é nula ou espaços em brancos , ex. String.IsNullOrWhiteSpace(origin);

----- Conversão para numero -----

int.Parse(str) - Converte para numero
Convert.ToInt32(str) - Converte para numero

----- Conversão de número -----

ToString() - Converte para string

----- Exemplos -----

// Formatar
string origin = "abcde ABCDE ABC abc";

string s1 = origin.ToUpper();
string s2 = origin.ToLower();
string s3 = origin.Trim();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

// Buscar
int n1 = origin.IndexOf("bc");
int n2 = origin.LastIndexOf("bc");

Console.WriteLine(n1);
Console.WriteLine(n1);

// Recortar
string s4 = origin.Substring(2);
string s5 = origin.Substring(2, 10);

Console.WriteLine(s4);
Console.WriteLine(s5);

// Sunstituir
string s6 = origin.Replace('a', 'x');
string s7 = origin.Replace("abc", "def");

Console.WriteLine(s6);
Console.WriteLine(s7);

// Outros
bool b1 = String.IsNullOrEmpty(origin);
bool b2 = String.IsNullOrWhiteSpace(origin);

Console.WriteLine(b1);
Console.WriteLine(b2);
