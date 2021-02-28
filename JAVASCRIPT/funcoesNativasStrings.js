/* 
    FUNCOES NATIVAS PARA MANIPULAR STRING
    https://www.w3schools.com/jsref/jsref_obj_string.asp
*/

/*** 
    split()
    Separa a partir de um valor
 ***/
var nome = "Alexandre"
document.write(nome.split(" "));

/*** 
    trim()
    Remove espaço em bracos que estao na extremidades
    dos caracteres, esquerda - direita
 ***/
var nome = "Alexandre tavano"
document.write('-' + nome.trim() + '-');

/*** 
    length
    Retorna a quantidade de caracteres
 ***/
var nome = "Alexandre"
document.write(nome.length);

/*** 
    eval()
    converte um numero em string para Numerico
    usa a "promp" js do prorio navegador
 ***/
var nome = "1"
document.write(eval(nome.value));

/*** 
    replace()
    Substitui textos, caracteres especiais
 ***/
var nome = "Alexandre"
document.write(nome.replace('Alexandre', 'Tavano'));

/*** 
    toUpperCase()
    Converte pra maiusculo
 ***/
var nome = "Alexandre"
document.write(nome.toUpperCase());

/*** 
    toLowerCase()
    Converte pra minusculo
 ***/
var nome = "Alexandre"
document.write(nome.toLowerCase());

/*** 
    concat()
    Concatena os valores, separados por virgula
 ***/
let nome = "Alexandre";
document.write(nome.concat(nome, ' concatenado'))

//#region [ Indices ]
/*** 
    charAt()
    Retorna o caracter naquele indice indicado
 ***/
var nome = "Alexandre"
document.write(nome.charAt(7));

/*** 
    indexOf()
    Retorna a posição de um caracter da sua
    primeira ocorrencia
 ***/
var nome = "Alexandre"
document.write(nome.indexOf('A'));

/*** 
    lastIndexOf()
    Começa de tras pra frente
    Retorna a posição de um caracter
 ***/
var nome = "Alexandre"
document.write(nome.lastIndexOf('A'));

/*** 
    substr()
    Extrai parte da string a partir de uma posição
    inicial, podemos colocar quandas posições 
    queremos em sequencia daquele indice
 ***/
var nome = "Alexandre"
document.write(nome.substr(2, 5));

/*** 
    slice()
    Mesmo estilo do substr()
 ***/
var nome = "Alexandre"
document.write(nome.slice(2, 8));
//#endregion [ Indices ]

//#region [ Usam Expressoes Regulares ]
/*** 
    match()
    Usa expressoes regulares
 ***/
let nome = "Alexandre";
document.write(nome.match(/[a-z]/g));

/*** 
    search()
    Usa expressoes regulares
    Retorna o Indice
 ***/
let nome = "Alexandre";
document.write(nome.search(/[a-z]/));
//#endregion [ Usam Expressoes Regulares ]