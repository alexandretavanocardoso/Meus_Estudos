/* Variaveis */
// string
var msg = "TypeScript";
console.log(msg);
// number
var episodio = 4;
console.log(msg + 4);
episodio = episodio + 1;
console.log(episodio);
// any - Aceita qualquer valor
var Droid;
Droid = 1;
Droid = 'Olá';
console.log(Droid);
/* Funções */
// As funções caso nao houver retorno colocamos void
// Se houver colocamos, number ou string ou boolean
var funcao1 = function (parsecs) {
    return parsecs < 12;
};
var distance = 14;
console.log(distance + " \u00E9 maior que 12: " + (funcao1(distance) ? 'YESS' : 'NAO'));
// função menor
var call = function (name) { return console.log("" + name); };
call('Alexandre');
// Valor nao é obrigatorio
function inc(speed, inc) {
    return speed + inc;
}
console.log("" + inc(5, 1));
