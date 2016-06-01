function insertarSucursal()
{
    var NuevaSucursal = new Object();
    NuevaSucursal.Cod_Postal  = document.getElementById("Cod_Postal").value;
    NuevaSucursal.Provincia= document.getElementById("Provincia").value;
    NuevaSucursal.Canton= document.getElementById("Canton").value;
    NuevaSucursal.Distrito= document.getElementById("Distrito").value;
    NuevaSucursal.Telefono= document.getElementById("Telefono").value;
    NuevaSucursal.Lema= document.getElementById("Lema").value;
    NuevaSucursal.op= "Insertar";
    $.ajax({
        url:"http://localhost:4684/Api/Sucursals", 
        type: "POST", 
        datatype: "json", 
        data: NuevaSucursal, 
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
function ModificarSucursal()
{
    var ModificarSucursal = new Object();
    ModificarSucursal.Cod_Postal  = document.getElementById("Cod_Postal").value;
    ModificarSucursal.Provincia= document.getElementById("Provincia").value;
    ModificarSucursal.Canton= document.getElementById("Canton").value;
    ModificarSucursal.Distrito= document.getElementById("Distrito").value;
    ModificarSucursal.Telefono= document.getElementById("Telefono").value;
    ModificarSucursal.Lema= document.getElementById("Lema").value;
    ModificarSucursal.op= "Modificar";
    $.ajax({
        url:"http://localhost:4684/Api/Sucursals", 
        type: "POST", 
        datatype: "json", 
        data: ModificarSucursal, 
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

function EliminarSucursal()
{
  var EliminarSucursal = new Object();
   EliminarSucursal.Cod_Postal  = document.getElementById("Cod_Postal").value;
    EliminarSucursal.Op= "Eliminar";
    $.ajax({
        url:"http://localhost:4684/Api/Sucursals", 
        type: POST, 
        datatype: "json", 
        data: EliminarSucursal, 
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