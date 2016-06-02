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
                var select = document.getElementById("Bebida").innerHTML;
                document.getElementById("Bebida").innerHTML = select + "<option value='" + data[ele]._Cod_bebida + "' class='" + contador_bebida + "'>" + data[ele]._Nombre + "</option>";
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr + " la wea fallo");
        }
    });

    $.ajax({
        url: "http://localhost:4684/api/Licor",

        type: 'POST',
        dataType: 'json',
        data: licor,
        success: function (data, textStatus, xhr) {

            for (var ele in data) {
                var select = document.getElementById("Licor").innerHTML;
                document.getElementById("Licor").innerHTML = select + "<option value='" + data[ele]._Cod_licor + "' class='" + contador_licor + "'>" + data[ele]._nombre + "</option>";
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr + " la wea fallo");
        }
    });

}
