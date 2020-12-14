(function($) {

    $.fn.load = function(action = 'load', params) {

        // Padrao
        /*
            var defaults = {
                divClass: 'dual-ring',
                divQtd: 0
            }
        */

        // substitui o padrao
        // var options = $.extend(defaults, params);

        return this.each(function() {

            switch (action) {

                case 'load':

                    var divToAppend = document.createElement("div");
                    divToAppend.id = 'load';
                    $(divToAppend).css({
                        width: "100%",
                        height: "100%",
                        "background-color": "#ccc"
                    });

                    var divLoad = document.createElement("div");
                    divLoad.className = 'lds-dual-ring'; //+ options.divClass
                    $(divLoad).css({
                        position: "absolute",
                        top: "50%",
                        left: "50%"
                    });

                    /* For para as subtituições, pois tem varias divs dependendo
                     do loader
                        for (var i = 1; 1 <= options.divClass; i++) {
                            $(divLoad).append("<div></div>");
                        }
                    */

                    // Adicionando o html no outro
                    $(divToAppend).append(divLoad);

                    $(this).append(divToAppend).hide().fadeIn('slow');

                    break;
                case 'unload':

                    $("#load").fadeOut(function() {
                        $(this).remove();
                    });
                    break;
                default:
                    console.error("Informe uma ação válida");

            }

        });

    }

})(jQuery);