function onClick_CalcularValores(tipo, valor){
    if(tipo == "Acao"){
        if (valor == "C") {
            // limpa o campo
            document.getElementById("input").value = "";
        } 
        else if (valor == "/") {
            // mostra o valor, concatenado com o "/"
            document.getElementById("input").value += valor;
        }
        else if (valor == "*") {
             // mostra o valor, concatenado com o "*"
            document.getElementById("input").value += valor
        }
        else if (valor == "-") {
             // mostra o valor, concatenado com o "-"
            document.getElementById("input").value += valor
        }
        else if (valor == "+") {
             // mostra o valor, concatenado com o "+"
            document.getElementById("input").value += valor
        }
        else if (valor == ".") {
             // mostra o valor, concatenado com o "."
            document.getElementById("input").value += valor
        }

        if (valor == "="){
            // pega o valor que esta no Input em String
            // e com o eval(), converte para Numeric
            var valorCampo = eval(document.getElementById("input").value);
            
            // trocar o valor do input pelo novo valor calculado
            document.getElementById("input").value = valorCampo;
        }

    } else if(tipo == "Valor"){   
        // mostra o valor, concatenando  
        document.getElementById("input").value += valor;
    }
}