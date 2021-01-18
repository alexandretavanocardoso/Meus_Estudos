/* Variaveis */

// string
let msg: string = "TypeScript";
console.log(msg);

// number
let episodio: number = 4;
console.log(msg + 4);
episodio = episodio + 1;
console.log(episodio);

// any - Aceita qualquer valor
let Droid;
Droid = 1;
Droid = 'Olá';
console.log(Droid);

/* Funções */

// As funções caso nao houver retorno colocamos void
// Se houver colocamos, number ou string ou boolean

let funcao1 = function (parsecs: number) : boolean {
    return parsecs < 12
}
let distance = 14;
console.log(`${distance} é maior que 12: ${funcao1(distance) ? 'YESS' : 'NAO'}`);

// função menor
let call = (name: string) => console.log(`${name}`);
call('Alexandre');

// Valor nao é obrigatorio
function inc(speed: number, inc?: number) : number {
    return speed + inc;
}

console.log(`${inc(5, 1)}`);
