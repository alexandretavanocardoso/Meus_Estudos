/************
    Object.defineProperty();
    Defini uma propriedade, para nao poder alterar ela
************/
function Produto(nome, preco, estoque) {
    this.nome = nome;
    this.preco = preco;

    Object.defineProperty(this, "estoque", {
        enumerable: true, // mostra a chave
        value: estoque, // valor
        writable: false, // Pode alterar ?
        configurable: false // pode reconfigurar a chave?
    });
}
const produto1 = new Produto("Camisa", 10.0, 5);

/************
    Object.defineProperties();
    Defini mais de uma propriedade, para nao poder alterar ela
************/
function Produto2(nome, preco, estoque) {
    this.nome = nome;
    this.preco = preco;

    Object.defineProperties(this, {
        nome: {
            enumerable: true, // mostra a chave
            value: estoque, // valor
            writable: false, // Pode alterar ?
            configurable: false // pode reconfigurar a chave?
        },
        preco: {
            enumerable: true, // mostra a chave
            value: estoque, // valor
            writable: false, // Pode alterar ?
            configurable: false // pode reconfigurar a chave?
        }
    });
}
const produto2 = new Produto2("Camisa", 10.0, 5);

/************
    Getters
    Setters
    Maneira de proteger propriedade
************/
function Produto(nome, preco, estoque) {
    this.nome = nome;
    this.preco = preco;

    let estoquePrivado = estoque;
    Object.defineProperty(this, "estoque", {
        enumerable: true, // mostra a chave
        get: function(){
            // modifica valor
            return estoquePrivado;
        },
        set: function(valor){
            if(typeof valor !== 'number'){
                return;
            }
            // valida valor
            estoquePrivado = valor;
        },
        configurable: false // pode reconfigurar a chave?
    });
}
const produto1 = new Produto("Camisa", 10.0, 5);

/************
   Object.assign({}, Objeto);
   Copia outro Objeto
************/
const produto = {nome: "Carro", preco: 100.000};
const produto1 = Object.assign({}, produto, {material:"ferro"});

/************
    Object.keys(objeto);
    Ve as chaves do objeto
************/
Object.keys(produto);

/************
    Object.getOwnPropertyDescriptor(obejeto);
    Retorna o descritor da propriedade   
************/
Object.getOwnPropertyDescriptor(produto.nome);

/************
    Object.value();
    retorna o valor
************/
Object.value(produto.nome);

/************
    Object.freeze();
    Não deixa o obejto ou propriedade ser usado
************/
Object.freeze(produto.nome);

/************
    Object.entries();
    retorna o objeto
************/
Object.entries(produto);

/************
   ...(objeto)
   Copia o objeto
************/
console.log(...(produto));

/************
   Prototypes
************/ 





