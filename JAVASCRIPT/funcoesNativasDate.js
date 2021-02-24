/* 
    FUNCOES NATIVAS PARA MANIPULAR DATAS
    https://www.w3schools.com/jsref/jsref_obj_date.asp
*/


// #region [GET]
// Recupera Datas

/*** 
    new Date()
    Data atual
 ***/

var dataAtual = new Date();

/*** 
    getDate()
    Dia do mês
 ***/

var data = new Date();
data.getDate();

/*** 
    getMonth()
    Recupera o mês numericamente
 ***/

var data = new Date();
data.getMonth() + 1;

/*** 
    getFullYear()
    Recupera o ano
 ***/

var data = new Date();
data.getFullYear();

/*** 
    getFullgetSecondsYear()
    Recupera o segundo
 ***/

var data = new Date();
data.getSeconds();

/*** 
    getFullgetSecondsYear()
    Recupera o segundo
 ***/

var data = new Date();
data.getSeconds();
// #endregion [GET]

// #region [SET]
// Seta Datas

/*** 
    setDate()
    Seta dia do mes
 ***/

var data = new Date();

document.write(data.toString())
data.setDate(data.getDate() + 1);

/*** 
    setMonth()
    Seta o mes
 ***/

document.write(data.toString())
data.setMonth(data.getMonth() + 2);

/*** 
    setFullYear()
    Seta o ano
 ***/

document.write(data.toString())
data.setFullYear(data.getFullYear() + 2);

//#endregion [SET]

// #region [CALCULO DE DATAS]
var data1 = new Date(2021, 5, 20);
var data2 = new Date(2021, 7, 23);

document.write(data1.toString());
document.write(data2.toString());
document.write('<hr >');
// getType()
// Recupera q quantidade de Milisecundos
// padrao é: 1 de janeiro de 1970
document.write(data1.getTime());
document.write(data2.getTime());
document.write('<hr >');

var milisegundos_entre_dadas = Math.abs(data1.getTime() - data2.getTime());

// Quantidade de milisecundos entra datas
document.write(milisegundos_entre_dadas);
document.write('<hr >');

var milisegundos_por_dia = (1 * 24 * 60 * 60 * 1000);
document.write('1 dia tem:' + +'Milisegundos');
document.write(Math.ceil(milisegundos_entre_dadas / milisegundos_por_dia));
//#endregion [CALCULO DE DATAS]