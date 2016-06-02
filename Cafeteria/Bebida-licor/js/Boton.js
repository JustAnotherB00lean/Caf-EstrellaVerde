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
                var y = document.getElementById('Licor').innerHTML;
                document.getElementById('Licor').innerHTML = y + "<option value='" + data[ele]._Cod_licor + "' class='" + contador_licor + "'>" + data[ele]._nombre + "</option>";
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(xhr + " la wea fallo");
        }
    });

}

function insertarproducto() {
    var NuevaCliente = new Object();
    NuevaCliente.Cod_bebida = document.getElementById("Bebida").value;
    NuevaCliente.Cod_licor = document.getElementById("Licor").value;
    NuevaCliente.op = "Insertar";
    $.ajax({
        url: "http://localhost:4684/Api/LicorBebida",
        type: "POST",
        datatype: "json",
        data: NuevaCliente,
        success: function (data, textstatus, xhr) {
            if (data == 1) {
                alert("Correcto Rick")
            }
        },
        error: function (xhr, textstatus, errorThrown) {
            alert(textstatus);
        }
    });
}
function ModificarCliente() {
    var ModificarCliente = new Object();
    ModificarCliente.id = document.getElementById("id").value;
    ModificarCliente.nombre = document.getElementById("nombre").value;
    ModificarCliente.tipo = document.getElementById("tipo").value;
    ModificarCliente.correo = document.getElementById("correo").value;
    ModificarCliente.password = document.getElementById("password").value;
    ModificarCliente.op = "Modificar";
    $.ajax({
        url: "http://localhost:4684/Api/Cliente",
        type: "POST",
        datatype: "json",
        data: ModificarCliente,
        success: function (data, textstatus, xhr) {
            if (data == 1) {
                alerta("Correcto Rick")
            }
        },
        error: function (xhr, textstatus, errorThrown) {
            alert(textstatus);
        }
    });
}

function EliminarCliente() {
    var EliminarCliente = new Object();
    EliminarCliente.id = document.getElementById("id").value;
    EliminarCliente.Op = "Eliminar";
    $.ajax({
        url: "http://localhost:4684/Api/Cliente",
        type: "POST",
        datatype: "json",
        data: EliminarCliente,
        success: function (data, textstatus, xhr) {
            if (data == 1) {
                alerta("Correcto Rick")
            }
        },
        error: function (xhr, textstatus, errorThrown) {
            alert(textstatus);
        }
    });
}
