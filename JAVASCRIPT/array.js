/************
    ARRAY
************/

// #region [ Array Multidimensional ]
/* ARRAY MULTIDIMENSIONAL */
// Variavel que engloba indices de outros arrays
// listaCoisa['Indice']

var listaCoisa = new Array();

listaCoisa['Frutas'] = new Array();
listaCoisa['Frutas'][1] = "Banana";
listaCoisa['Frutas'][2] = "Maçã";
listaCoisa['Frutas'][3] = "Doce";

listaCoisa['Carros'] = new Array();
listaCoisa['Carros'][1] = "Camaro";
listaCoisa['Carros'][2] = "Corsa";
listaCoisa['Carros'][3] = "Fusca";

// Caminho para chegar no elemento desejado
listaCoisa(['Frutas'][2]);
listaCoisa(['Carros'][3]);
// #endregion [ Array Multidimensional ]

// #region [ Array Metodos de Inclusão e Exclusão ]
/* ARRAY METODOS DE INCLUSÃO E EXCLUSÃO DE ELEMENTOS */

var listaFrutas = new Array();
listaFrutas[0] = "Banana";
listaFrutas[1] = "Maçã";

// Incluir no final do array
listaFrutas.push("Torta");

// Incluir no começo do array
listaFrutas.unshift("Uva");

// Excluir no final
listaFrutas.pop();

// Excluir no começo
listaFrutas.shift();
// #endregion [ Array Metodos de Inclusão e Exclusão ]

// #region [ Array Metodos de Pesquisas ]
/* ARRAY METODOS DE PESQUISA */
var listaPesquisa = new Array();

listaPesquisa[0] = "Resultado";

// Pesquisa o elemento, retornando o Indice
listaPesquisa.indexOf("Resultado");
// #endregion [ Array Metodos de Pesquisas ]

// #region [ Array Ordenação de Elementos ]
/* ARRAY ORDENACAO DE ELEMENTOS */
var listaOrdenacao = new Array();

listaOrdenacao[0] = "Posicao 0";
listaOrdenacao[1] = "Posicao 1";
listaOrdenacao[2] = "Posicao 2";
listaOrdenacao[3] = "Posicao 3";

// reordenação, juntamente com os indices
// Palavras, Letras
listaOrdenacao.sort();

var listaOrdenacaoNumeros = new Array();

listaOrdenacao[0] = 12;
listaOrdenacao[0] = 40;
listaOrdenacao[1] = 5;
listaOrdenacao[2] = 7;
listaOrdenacao[3] = 268;

// reordenação, juntamente com os indices
// Numerico
// usar função, usar referencia da função sem o "()"
listaOrdenacao.sort(listaOrdenacaoNumeros);

function listaOrdenacaoNumeros(a, b){
    return a - b;
}
// #endregion [ Array Ordenação de Elementos ]