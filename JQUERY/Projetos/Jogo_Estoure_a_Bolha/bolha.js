function addBola() {

    // Gera numeros aleatorios em decimal
    // Math.floor() - Converte pra inteiro
    var x = Math.floor(Math.random() * 800);
    var y = Math.floor(Math.random() * 500);
    var cores = Math.floor(Math.random() * 4)


    var bola = $('<div class="bola"></div>');
    bola.css('left', x + 'px');
    bola.css('top', y + 'px');

    switch (cores) {
        case 0:
            bola.css('background-color', 'blue');
            break;
        case 1:
            bola.css('background-color', 'red');
            break;
        case 2:
            bola.css('background-color', 'yellow');
            break;
        case 3:
            bola.css('background-color', 'black');
            break;
        case 4:
            bola.css('background-color', 'green');
            break;
    }

    bola.on('click', function() {

        $(this).fadeOut('fast');
        placar++;
        updatePlacar();

    });

    $(document.body).append(bola);

}

function updatePlacar() {

    $('#placar').html(placar);

}

var placar = 0;

$(function() {

    $('#comecar').on('click', function() {

        setInterval(addBola, 1000);

    });
});