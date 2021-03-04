// retorno objetos
// faz automatico 

// Inicia com a letra maiuscula

function Pessoa(nome, sobrenome){
    // Sem o this ele nao cria o obejto, só existe na propria na função
    const idInterno = 1;
    const metodoInterno = function(){return "olá"};

    this.nome = nome;
    this.sobrenome = sobrenome;

    this.metodo = function() {
        console.log("Metodo");
    }
}
const pessoa1 = new Pessoa("Luiz", "Carlos");
const pessoa2 = new Pessoa("Tavano", "Alexandre");

console.log(pessoa1.nome, pessoa2.nome);
console.log(pessoa1, pessoa2);
pessoa2.metodo();