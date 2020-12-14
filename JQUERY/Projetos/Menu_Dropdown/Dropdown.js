$(function() {

    $('li').hover(function() {

        // Passa Mouse
        $(this).find('.submenu1').slideDown('slow');

    }, function() {

        // Tira Mouse
        $(this).find('.submenu1').slideUp('slow');

    })

});