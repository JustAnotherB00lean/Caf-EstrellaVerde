function login()
{

    var NuevoUsuario = new Object();
    NuevoUsuario.Id = document.getElementById("Id").value;
    NuevoUsuario.pass = document.getElementById("Password").value;
    NuevoUsuario.op = "Login";
    $.ajax({
        url: "http://localhost:1331/Api/CLIENTE",
        type: "POST",
        datatype: "json",
        data: NuevoUsuario,
        success: function(data,textstatus,xhr){

        if(data==1)
        {
        alert("Sesion iniciada correctamente");
            location.href="indexADMIN.html";
    }
    },
        error:function(xhr,textstatus,errorThrown){

        alert("Id o contraseña incorrecta");
            location.href="login.html";

        }
    });
}
