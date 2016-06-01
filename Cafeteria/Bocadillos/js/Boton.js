var fotoenstring= "";

function insertarBocadillo()
{
    var NuevaBocadillo = new Object();
    NuevaBocadillo.Cod_bocadillo  = document.getElementById("Codigo Bocadillo").value;
    NuevaBocadillo.Nombre= document.getElementById("Nombre").value;
    NuevaBocadillo.Ingredientes= document.getElementById("Ingredientes").value;
    NuevaBocadillo.precio_porc= document.getElementById("Precio_Porc").value;
    NuevaBocadillo.precio_ind= document.getElementById("Precio_ind").value;
    NuevaBocadillo.precio_t_porc= document.getElementById("Precio_T").value;
    NuevaBocadillo.precio_t_ind= document.getElementById("Precio_ind_T").value;
    NuevaBocadillo.op= "Insertar";
    
     var fileToLoad = document.getElementById("imagencita").files[0];
    var fileReader = new FileReader();
 
    fileReader.onload = function(fileLoadedEvent) 
    {
       
        fotoenstring = fileLoadedEvent.target.result;
       
    };
    
    fileReader.readAsDataURL(fileToLoad);

    NuevaBocadillo.foto = fotoenstring;
    $.ajax({
        url:"http://localhost:4684/Api/bocadillos", 
        type: "POST", 
        datatype: "json", 
        data: NuevaBocadillo, 
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
function ModificarBocadillo()
{
    var ModificarBocadillo = new Object();
    ModificarBocadillo.Cod_bocadillo  = document.getElementById("Codigo Bocadillo").value;
    ModificarBocadillo.Nombre= document.getElementById("Nombre").value;
    ModificarBocadillo.Ingredientesngredientes= document.getElementById("Ingredientes").value;
    ModificarBocadillo.Precio_porc= document.getElementById("Precio_Porc").value;
    ModificarBocadillo.Precio_ind= document.getElementById("Precio_ind").value;
    ModificarBocadillo.precio_t_porc= document.getElementById("Precio_T").value;
    ModificarBocadillo.Precio_T_ind= document.getElementById("Precio_ind_T").value;
    ModificarBocadillo.op= "Modificar";
    
     var fileToLoad = document.getElementById("imagencita").files[0];
    var fileReader = new FileReader();
 
    fileReader.onload = function(fileLoadedEvent) 
    {
       
        fotoenstring = fileLoadedEvent.target.result;
       
    };
    
    fileReader.readAsDataURL(fileToLoad);

    ModificarBocadillo.foto = fotoenstring;
    $.ajax({
        url:"http://localhost:4684/Api/bocadillos", 
        type: "POST", 
        datatype: "json", 
        data: ModificarBocadillo, 
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

function EliminarBocadillo()
{
  var EliminarBocadillo = new Object();
   EliminarBocadillo.Cod_bocadillo  = document.getElementById("Codigo Bocadillo").value;
    EliminarBocadillo.Op= "Eliminar";
    $.ajax({
        url:"http://localhost:4684/Api/bocadillos", 
        type: "POST", 
        datatype: "json", 
        data: EliminarBocadillo, 
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