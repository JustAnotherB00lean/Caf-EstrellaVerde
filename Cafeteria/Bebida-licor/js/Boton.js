var fotoenstring = "";

function insertarBebida()
{
    var NuevaBebida = new Object();
    NuevaBebida.Cod_bebida  = document.getElementById("bebida").value;
    NuevaBebida.Cod_licor  =  document.getElementById("licor").value;
    NuevaBebida.op= "Insertar";
    
    var fileReader = new FileReader();
 
    fileReader.onload = function(fileLoadedEvent) 
    {
       
        fotoenstring = fileLoadedEvent.target.result;
       
    };
    
    fileReader.readAsDataURL(fileToLoad);

    $.ajax({
        url:"http://localhost:4684/Api/LicorBebida", 
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
   NuevaBebida.Cod_bebida  = document.getElementById("Codigo Bebida").value;
    NuevaBebida.Cod_licor  =  document.getElementById("Codigo Bebida").value;
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
   NuevaBebida.Cod_bebida  = document.getElementById("Codigo Bebida").value;
    NuevaBebida.Cod_licor  =  document.getElementById("Codigo Bebida").value;
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