var contador = 0;

function listadeproductos() {
    var bebida = new Object();
    bebida.op = "listar";
    contador += 1;
    $.ajax({
        url: "http://localhost:4684/api/Bebidas",

        type: 'POST',
        dataType: 'json',
        data: bebida,
        success: function (data, textStatus, xhr) {

            for (var ele in data) {
                var x = document.getElementById('bebida').innerHTML;
                document.getElementById('bebida').innerHTML = x + "<li id='" + contador + "' class='" + data[ele]._Cod_bebida + "'> <span> "+ data[ele]._Nombre +" </span> </li>";

            }


        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr + " la wea fallo");
        }
    });

}
