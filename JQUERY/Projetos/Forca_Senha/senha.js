$(function() {

    $('#senha').on('keyup', function() {

        var txt = $(this).val();
        var forca = 0;
        var textoForca = " ";

        // letras, numeros, caracteres especiais, minimo de caracteres

        if (txt.length > 6) {
            forca += 25;
            textoForca = "A senha deve ter no minimo 6 caracteres"
        }

        // A até Z
        var reg = new RegExp(/[a-z]/i);
        if (reg.test(txt)) {
            forca += 25;
            textoForca = "Fraca"
        }

        // 0 até 9
        var number = new RegExp(/[0-9]/i);
        if (number.test(txt)) {
            forca += 25;
            textoForca = "Média"
        }

        // Caracteres especiais
        var especial = new RegExp(/[^a-z0-9]/i);
        if (especial.test(txt)) {
            forca += 25;
            textoForca = "Forte"
        }

        // Apenas aceita a senha maior que 75
        if (forca >= 75) {
            var aceita = 'ACEITA';
        } else {
            var aceita = 'NAO ACEITA';
        }

        $('#forca').html("força:" + " " + textoForca + " <br> " + txt + " <br> " + aceita);


    });


});