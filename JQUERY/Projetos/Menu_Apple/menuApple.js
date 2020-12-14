$(function() {

    $('.icone').hover(function() {

        $(this).animate({
            "marginTop": -30
        }, 300);

    }, function() {

        $(this).animate({
            "marginTop": 0
        }, 300);

    });

});