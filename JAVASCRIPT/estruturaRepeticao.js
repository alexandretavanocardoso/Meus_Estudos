/************
    ESTRUTURA DE REPETIÇÃO
************/

// #region [ WHILE ]
// Enquanto
while(Condicao){

    // código

// #region [ OUTROS COMANDOS QUE PODEMOS COLOCAR ]
    // parada Obrigatoria
    break;

    // Interrompe o bloco de codigo
    // e pula pra condicao principal
    continue;
// #endregion [ OUTROS COMANDOS QUE PODEMOS COLOCAR ]

    // critério de parada, pois incrementa
    x++; // Incremento
}
// EX
var x = 1;
while(x <= 10){
    document.write(x + '<br />');

    // parada Obrigatoria
    break;

    // Interrompe o bloco de codigo
    // e pula pra condicao principal
    continue;

    // critério de parada
    x++; // Incremento
}
// #endregion [ WHILE ]

// #region [ DO WHILE ]
do {
    // comando 
    // passa primeiro no DO, depois pr o While
} while (condicao) {

    x++;
}
// #endregion [ DO WHILE ]

// #region [ FOR ]
for(variavel;condicao;incremento){
    // comando
}

// Ex, Incremento
for(var i = 0; i <= 10; i++){
    document.write(i);
}
// Ex, Decremento
for(var i = 10; i <= 0; i--){
    document.write(i);
}
// #endregion [ FOR ]

// #region [ FOR IN ]
var listaConvidados = ["Ale", "Tav", "Maria"];

for ( var convidados in listaConvidados ){
    document.write(convidados + "=" + listaConvidados[convidados]);
}
// #endregion [ FOR IN ]

// #region [ FOREACH ]
// Aplicado a Arrays
var lista = ["1", "2"];

lista.forEach(function(valor, indice, array) {
    document.write("Indice:" + indice);
    document.write("Valor:" + valor);
    document.write("Array:" + array);
});

lista.forEach(function(item) {
    document.write("item:" + item);
});

// #endregion [ FOREACH ]