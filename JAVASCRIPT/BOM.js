/************
    BOM
************/

// #region [ Window ]
// https://www.w3schools.com/js/js_window.asp
var janela = document.getElementById("janela");

// Fecha
janela.close();

// Abre
janela.open();

// Abre e consegue chamar uma url
janela.open("http://google.com");

// Abre com estilizacao
janela.open("height=300px, widht=20px");

// Print da tela
window.print();
// #endregion [ Window ]

// #region [ Screen ]
// https://www.w3schools.com/js/js_window_screen.asp

// Altura e largura do Browser, excluido a barra de ferramentas
window.screen.availHeight();
window.screen.availWidth();

// Altura e largura do Browser, com a barra de ferramentas
window.screen.height();
window.screen.width();
// #endregion [ Screen ]

// #region [ Location ]
// https://www.w3schools.com/js/js_window_location.asp

// Redirecionamento com href
window.location.href = "http://google.com";

// Recarrega a pagina
window.reload();

// #endregion [ Location ]

// #region [ Timing ]
// https://www.w3schools.com/js/js_timing.asp

// Executa a ação UMA vez após o tempo
setTimeout(function() {
    alert("ola");
}, 1000);

// SEMPRE executar a acao após o tempo
setInterval(function() {
    alert("ola");
}, 1000);
// #endregion [ Timing ]
