var contador_bebida = 0;
var contador_licor = 0;

function listadeproductos() {
    var bebida = new Object();
    var licor = new Object();
    bebida.op = "listar";
    licor.op = "listar";
    contador_bebida += 1;
    contador_licor += 1;

    $.ajax({
        url: "http://localhost:4684/api/Bebidas",

        type: 'POST',
        dataType: 'json',
        data: bebida,
        success: function (data, textStatus, xhr) {
            for (var ele in data) {
                var x = document.getElementById('bebida').innerHTML;
                document.getElementById('bebida').innerHTML = x + "<li id='" + contador_bebida + "' class='" + data[ele]._Cod_bebida + "'> <span>" + data[ele]._Nombre + "</span> </li>";
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr + " la wea fallo");
        }
    });

    //$.ajax({
    //    url: "http://localhost:4684/api/Licor",

    //    type: 'POST',
    //    dataType: 'json',
    //    data: licor,
    //    success: function (data, textStatus, xhr) {

    //        for (var ele in data) {
    //            var y = document.getElementById('licor').innerHTML;
    //            document.getElementById('licor').innerHTML = y + "<li id='" + contador_licor + "' class='" + data[ele]._Cod_licor + "'> <span>" + data[ele]._nombre + "</span> </li>";
    //        }
    //    },
    //    error: function (xhr, textStatus, errorThrown) {
    //        alert(xhr + " la wea fallo");
    //    }
    //});

}
