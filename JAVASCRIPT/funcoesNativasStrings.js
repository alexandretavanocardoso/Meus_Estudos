/* 
    FUNCOES NATIVAS PARA MANIPULAR STRING
    https://www.w3schools.com/jsref/jsref_obj_string.asp
*/


/*** 
    length
    Retorna a quantidade de caracteres
 ***/

var nome = "Alexandre"
document.write(nome.length);

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
    replace()
    Substitui textos, caracteres especiais
 ***/

var nome = "Alexandre"
document.write(nome.replace('Alexandre', 'Tavano'));

/*** 
    substr()
    Extrai parte da string a partir de uma posição
    inicial, podemos colocar quandas posições 
    queremos em sequencia daquele indice
 ***/

var nome = "Alexandre"
document.write(nome.substr(2, 5));

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
    trim()
    Remove espaço em bracos que estao na extremidades
    dos caracteres, esquerda - direita

 ***/

var nome = "Alexandre tavano"
document.write('-' + nome.trim() + '-');