/* 
    FUNCOES NATIVAS PARA OPERACOES MATEMATICAS
    https://www.w3schools.com/jsref/jsref_obj_math.asp
*/


/*** 
    toString()
    Converte para string
***/
let num = 1;
console.log(num.toString());
console.log(num.toString(2)); // Vemos o binário

/*** 
    toFixed()
    Casas decimais 
***/
let num1 = 10.5550;
console.log(num1.toFixed(2));

//#region [ Number ]
/*** 
    Number.isInteger(variavel)
    Vemos se o numero é inteiro ou não
    Retorna true or false
***/
let num2 = 10;
console.log(Number.isInteger(num2));

/*** 
    Number.isNaN(variavel)
    Vemos se a conta é "NANN"
    Retorna true or false
***/
let num3 = 10 * "olá";
console.log(Number.isNaN(num3));

/*** 
    Number(variavel)
***/
let num6 = 2.1;
console.log(Number(num6));
//#endregion [ Number ]

//#region [ Parse ]
/*** 
    parseInt(variavel)
    Converte apra Inteiro
***/
let num4 = 1.6;
console.log(parseInt(num4));

/*** 
    parseFloat(variavel)
    Converte pra float
***/
let num5 = 1.6;
console.log(parseFloat(num5));
//#endregion [ Parse ]