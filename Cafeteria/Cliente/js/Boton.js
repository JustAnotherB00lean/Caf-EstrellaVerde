function insertarCliente()
{
    var NuevaCliente = new Object();
    NuevaCliente.id  = document.getElementById("id").value;
    NuevaCliente.nombre= document.getElementById("nombre").value;
    NuevaCliente.tipo= document.getElementById("tipo").value;
    NuevaCliente.correo= document.getElementById("correo").value;
    NuevaCliente.password= document.getElementById("password").value;
    NuevaCliente.op= "Insertar";
    $.ajax({
        url:"http://localhost:4684/Api/Cliente", 
        type: "POST", 
        datatype: "json", 
        data: NuevaCliente, 
        success:function(data,textstatus,xhr){
            if(data==1)
            { 
                alerta("Correcto Rick") 
            } 
        }, 
        error:function(xhr,textstatus,errorThrown){ 
            alert(textstatus); } 
    });
}
function ModificarCliente()
{
    var ModificarCliente = new Object();
    ModificarCliente.id  = document.getElementById("id").value;
    ModificarCliente.nombre= document.getElementById("nombre").value;
    ModificarCliente.tipo= document.getElementById("tipo").value;
    ModificarCliente.correo= document.getElementById("correo").value;
    ModificarCliente.password= document.getElementById("password").value;
    ModificarCliente.op= "Modificar";
    $.ajax({
        url:"http://localhost:4684/Api/Cliente", 
        type: "POST", 
        datatype: "json", 
        data: ModificarCliente, 
        success:function(data,textstatus,xhr){
            if(data==1)
            { 
                alerta("Correcto Rick") 
            } 
        }, 
        error:function(xhr,textstatus,errorThrown){ 
            alert(textstatus); } 
    });
}

function EliminarCliente()
{
  var EliminarCliente = new Object();
   EliminarCliente.id  = document.getElementById("id").value;
    EliminarCliente.Op= "Eliminar";
    $.ajax({
        url:"http://localhost:4684/Api/Cliente", 
        type: "POST", 
        datatype: "json", 
        data: EliminarCliente, 
        success:function(data,textstatus,xhr){
            if(data==1)
            { 
                alerta("Correcto Rick") 
            } 
        }, 
        error:function(xhr,textstatus,errorThrown){ 
            alert(textstatus); } 
    });
}