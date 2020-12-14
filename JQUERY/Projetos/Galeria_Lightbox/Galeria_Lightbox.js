$(function() {

    $('a.galeria').on('click', function() {

        //Captura o caminho da imagem
        var img = $(this).find('img').attr('src');

        // Troca a parte branca pro caminho da nossa imagem
        $('.divbox img').attr('src', img);

        // Aparecer imagem
        $('.bgbox, .divbox').fadeIn('fast');

    });

    // Evento para fechar
    $('.bgbox, .divbox button').on('click', function() {

        $('.bgbox, .divbox').fadeOut('fast');

    });


});