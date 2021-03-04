/* 
    ATRIBUIÇÃO VIA DESUSTRUTURAÇÃO ARRAYS
*/

// atribui 
let a = "A";
let b = "B";
let c = "C";

// desustruturação
// Inverte os valores
const letras = [b, c, a];
[a,b,c] = letras;

/* 
    ATRIBUIÇÃO VIA DESUSTRUTURAÇÃO OBJETOS
*/

const pessoa = {
  nome: "Alexandre",
  sobreNome: "Tavano",
  idade: 18,
  endereco: {
    bairro: "Santa Casa",
    Avenida: "São josé"
  }
}
// Atribuição e desustruturacao
const { nome: teste='' } = pessoa;
