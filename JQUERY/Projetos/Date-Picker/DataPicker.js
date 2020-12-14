$(function() {

    var horaEscolhaCampo;

    $('input').on('focus', function() {

        var pos = $(this).offset();
        var width = $(this).width();

        $('.horaEescolha').css('left', pos.left + width + 35);
        $('.horaEescolha').css('top', pos.top);
        $('.horaEescolha').show('fast');

        horaEscolhaCampo = $(this);

    });

    $('input').on('blur', function() {

        setTimeout(function() {
            $('.horaEescolha').hide('fast');
        }, 200);

    });

    $('.horaEescolha button').on('click', function() {

        // pega o valor e aparece no input
        var hora = $(this).html();
        horaEscolhaCampo.val(hora);

    });
});