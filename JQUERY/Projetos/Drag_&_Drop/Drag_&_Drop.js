$(function() {

    $('#objeto').on('mousedown', function() {

            $('#objeto').on('mousemove', (event) => {

               // Pega a posição do objeto
               var x = event.originalEvent.pageX;
               var y = event.originalEvent.pageY;
               
               // Pega a largura e altura do objeto
               var width = $(this).width();
               var height = $(this).height();

               // Faz mover o objeto de acordo com a poição e largura/altura
               $(this).css('left', (x - (width/2))+'px');
               $(this).css('top', (y - (height/2))+'px');
            });

    });


    // Quando solta o mouse
    $('#objeto').on('mouseup', function() {


          $('#objeto').unbind('mousemove');

    });

});