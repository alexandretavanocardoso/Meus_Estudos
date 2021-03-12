/******* *****
    Pr rototype
    se refere a primeira função ou metodo criado
    usando elas de modelo para futuras produções
************/
function Pessoa(nome, sobrenome){
    this.nome = nome;
    this.sobrenome = sobrenome;
}
Pessoa.prototype.nomeCompleto = function(){
    return this.nome + " " + this.sobrenome;
}; 

const p1 = Pessoa("Alexandre", "Tavano");