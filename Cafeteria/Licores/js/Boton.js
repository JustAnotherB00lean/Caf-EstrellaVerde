function insertarLicor()
{
    var NuevaLicor = new Object();
    NuevaLicor.Cod_licor  = document.getElementById("Cod_licor").value;
    NuevaLicor.Nombre= document.getElementById("Nombre").value;
    NuevaLicor.op= "Insertar";
    $.ajax({
        url:"http://localhost:4684/Api/Licors", 
        type: "POST", 
        datatype: "json", 
        data: NuevaLicor, 
        success:function(data,textstatus,xhr){
            if(data==1)
            { 
                alerta("Correcto Rick") 
            } 
        }, 
        error:function(xhr,textstatus,errorThrown)
        { 
            alert(textstatus); } 
    });
}
function ModificarLicor()
{
    var ModificarLicor = new Object();
    ModificarLicor.Cod_licor  = document.getElementById("Cod_licor").value;
    ModificarLicor.Nombre= document.getElementById("Nombre").value;
    ModificarLicor.op= "Modificar";
    $.ajax({
        url:"http://localhost:4684/Api/Licors", 
        type: "POST", 
        datatype: "json", 
        data: ModificarLicor, 
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

function EliminarLicor()
{
  var EliminarLicor = new Object();
   EliminarLicor.Cod_licor  = document.getElementById("Cod_licor").value;
    EliminarLicor.Op= "Eliminar";
    $.ajax({
        url:"http://localhost:4684/Api/Licors", 
        type: POST, 
        datatype: "json", 
        data: EliminarLicor, 
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