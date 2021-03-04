// pauda o codigo em determinado local
// Colocamos "*"
// Cada vez que chamo executa o "yield"
// conta pela quantidade das chamadas

function* geradora1(){
    // Codigo qualquer
    yield "valor 1";
    // Codigo qualquer
    yield "valor 2";
    // Codigo qualquer
    yield "valor 3";
}

const g1 = gerador2();
console.log(g1.next().value);
console.log(g1.next().value);
console.log(g1.next().value);
console.log(g1.next());

function* gerador2(){
    let i = 0;

    while(i < 20){
        yield i;
        i++;
    }
}