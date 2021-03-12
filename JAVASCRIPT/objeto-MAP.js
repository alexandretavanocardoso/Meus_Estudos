/************
    MAP()
    retorna um array, "mapa"
************/

const pessoas = [
    {id: 3, nome: "Ale"},
    {id: 2, nome: "Ale"},
    {id: 1, nome: "Ale"},
];

const novasPessoas = new Map();
for (const pessoa of pessoas){
    const {id} = pessoa;
    // seta o valor
    novasPessoas.set(id, {...pessoa});
} 
// obtem o valor
console.log(novasPessoas.get(2));


