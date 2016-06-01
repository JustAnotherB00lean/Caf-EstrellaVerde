var fotoenstring = "";

function insertarBebida()
{
    var NuevaBebida = new Object();
    NuevaBebida.id  = document.getElementById("Codigo Bebida").value;
    NuevaBebida.Nombre= document.getElementById("Nombre").value;
    NuevaBebida.ingredientes= document.getElementById("Ingredientes").value;
    NuevaBebida.precio_porc= document.getElementById("Precio_Porc").value;
    NuevaBebida.precio_ind= document.getElementById("Precio_ind").value;
    NuevaBebida.precio_T_porc= document.getElementById("Precio_Porc_T").value;
    NuevaBebida.precio_T_ind= document.getElementById("Precio_ind_T").value;
    NuevaBebida.op= "Insertar";
    
    var fileToLoad = document.getElementById("imagencita").files[0];
    var fileReader = new FileReader();
 
    fileReader.onload = function(fileLoadedEvent) 
    {
       
        fotoenstring = fileLoadedEvent.target.result;
       
    };
    
    fileReader.readAsDataURL(fileToLoad);

    NuevaBebida.foto = fotoenstring;
    $.ajax({
        url:"http://localhost:4684/Api/Bebidas", 
        type: "POST", 
        datatype: "json", 
        data: NuevaBebida, 
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
function ModificarBebida()
{
    var ModificarBebida = new Object();
    ModificarBebida.id  = document.getElementById("Codigo Bebida").value;
    ModificarBebida.Nombre= document.getElementById("Nombre").value;
    ModificarBebida.ingredientes= document.getElementById("Ingredientes").value;
    ModificarBebida.precio_porc= document.getElementById("Precio_Porc").value;
    ModificarBebida.precio_ind= document.getElementById("Precio_ind").value;
    ModificarBebida.precio_T_porc= document.getElementById("Precio_Porc_T").value;
    ModificarBebida.precio_T_ind= document.getElementById("Precio_ind_T").value;
    ModificarBebida.op= "Modificar";
    
    var fileToLoad = document.getElementById("imagencita").files[0];
    var fileReader = new FileReader();
 
    fileReader.onload = function(fileLoadedEvent) 
    {
       
        fotoenstring = fileLoadedEvent.target.result;

    };
    
    fileReader.readAsDataURL(fileToLoad);

    ModificarBebida.foto = fotoenstring;
    $.ajax({
        url:"http://localhost:4684/Api/Bebidas", 
        type: "POST", 
        datatype: "json", 
        data: ModificarBebida, 
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

function EliminarBebida()
{
  var EliminarBebida = new Object();
   EliminarBebida.id  = document.getElementById("Codigo Bebida").value;
    EliminarBebida.Op= "Eliminar";
    
    
    $.ajax({
        url:"http://localhost:4684/Api/Bebidas", 
        type: "POST", 
        datatype: "json", 
        data: EliminarBebida, 
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