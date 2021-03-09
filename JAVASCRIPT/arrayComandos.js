
/*
    SPLICE();
    Retorna um array
*/
// splice(indice, Elementos a Remover, adiona elemento: ele1,ele2)
const nome = ["Maria", "Alexandre", "Carlos", "Zé"];

const removidos = nome.splice(2, 1);
console.log(nome, removidos);

/*
    CONCAT()
*/
let concatenacao = [1, 2];
let concatenacao1 = [3,4];
console.log(concatenacao.concat(concatenacao1));

/*
    FILTER()
    filter(function(e) {});
*/
const numeros = [5,8,7,4,1,78,54,2,1];
const numerosFiltrados = numeros.filter(function(valor) {
    return valor > 7;
});
console.log(numerosFiltrados);

const pessoas = [
    {nome: "Alexandre", idade: 10},
    {nome: "Tavano", idade: 54},
    {nome: "Cardoso", idade: 5},
    {nome: "luiz", idade: 20},
]

const nomeCom5Letras = pessoas.filter(function(e){ return e.nome.length >= 5});
console.log(nomeCom5Letras);

const pessoasComMaisDe50Anos = pessoas.filter(function(e){return e.idade > 50});
console.log(pessoasComMaisDe50Anos);

// endsWith("") -> Pega a ultima letra da string
const termiaComO = pessoas.filter(function(e) {return e.nome.toLowerCase().endsWith("o") });
console.log(termiaComO);

/*
    MAP()
    map(function(e) {});
*/

/*
    REDUCE()
    reduce(function(e) {});
*/

