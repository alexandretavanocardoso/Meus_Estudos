/************
    DOM
************/
// Cria um Elemento
document.createElement("div");

// Adiciona um elemento
document.append();

// Adiciona um filho no pai
document.appendChild();

// #region [ Pegando Ids, Name, Classe, Tag ]
// Pega o ID
document.getElementById("");

// Pega a CLASSE
document.getElementsByClassName("");

// Pega a TAG
document.getElementsByTagName("");

// Pega o NAME
document.getElementsByName("");

// Pode fazer um caminho
document.querySelector("");
// #endregion [ Pegando Ids, Name, Classe, Tag ]

// #region [ Manipulando Valores ]
/* MANIPULANDO VALORES DE INPUTS */
var a = "";

a.value();
a.val();
a.trim(); // Remover espaços de string
// #endregion [ Manipulando Valores ]

// #region [ Manipulando a Estilização ]
/* MANIPULANDO ESTILOS DOS ELEMENTOS */
var a = document.getElementsById("teste");

a.style.propriedade = "";

a.style.background = "cor";
a.style.display = "none";
a.style.backgroundImage = "url";
a.style.fontSize = "18px";
// #endregion [ Manipulando a Estilização ]

// #region [ Manipulando Classes ]
/* MANIPULANDO CLASSES DOS ELEMENTOS */
var a = document.getElementsById("teste");

a.className = "Classe";

a.classList.add();
a.classList.remove();
a.classList.toggle();
// #endregion [ Manipulando Classes ]



