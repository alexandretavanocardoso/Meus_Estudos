$(document).ready(function() {

    function Filtro(data, params) {

        return [...data].filter((item) => {

            // g = retorna tudo q consiguir, i = nao leva em consideração letra maiusculo e minuscula
            var regex = eval(`/${params.term}/gi`);

            var result = item.nome.match(regex);

            return (result);

        });
    }

    $("#select-estado").select2({
        ajax: {
            url: "https://servicodados.ibge.gov.br/api/v1/localidades/estados",
            processResults: (data, params) => {

                var newData = Filtro(data, params);

                return {
                    results: newData
                }
            },
            // filtro com select 2
            data: params => {

                return {
                    q: params.term
                }

            }
        },
        // mostrar no select
        templateResult: (data) => {

            return data.nome;
            // return data.sigla;
        },
        // mostrar no select ao clicar
        templateSelection: data => {

            return data.nome;

        }
    });

    // Trazendo cidades pelo estado
    $("#select-estado").on('select2:select', event => {

        var idEstado = event.params.data.id;

        $('#select-cidade').select2({
            ajax: {
                url: `https://servicodados.ibge.gov.br/api/v1/localidades/estados/${idEstado}/distritos`,
                processResults: (data, params) => {

                    var newData = Filtro(data, params);

                    return {
                        results: newData
                    }
                },
                data: params => {
                    return {
                        q: params.term
                    }
                }
            },
            templateResult: data => {

                return data.nome;

            },
            templateSelection: data => {

                return data.nome;

            }
        })

    });


});