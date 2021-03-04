// São executadas quando uma Ação finaliza, ocorre
// Funcoes encaminhadas por parametros
// Da continuidade no processamento da logica

// Exemplos

function exibirArtigo(id, callbackSucesso, callbackErro) {
    //recuperar dados

    if (true) {
        callbackSucesso('Sucesso', 'Cadastro com Sucesso');
    } else {
        callbackErro('Alerta', 'Falha ao cadastrar');
    }
}

var callbackSucesso = function(titulo, descricao) {
    document.write(titulo, descricao)
}

var callbackErro = function(titulo, descricao) {
    document.write(titulo, descricao)
}

exibirArtigo(1, callbackSucesso, callbackErro);