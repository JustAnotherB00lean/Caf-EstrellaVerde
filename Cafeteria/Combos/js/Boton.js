function insertarCombo()
{
    var NuevaCombo = new Object();
    NuevaCombo.Codigo_combo  = document.getElementById("Codigo_combo").value;
    NuevaCombo.Codigo_Postal_S= document.getElementById("Codigo_Postal_S").value;
    NuevaCombo.Precio_Salon= document.getElementById("Precio_Salon").value;
    NuevaCombo.Precio_Terraza= document.getElementById("Precio_Terraza").value;
    NuevaCombo.op= "Insertar";
    $.ajax({
        url:"http://localhost:4684/Api/Combos", 
        type: "POST", 
        datatype: "json", 
        data: NuevaCombo, 
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
function ModificarCombo()
{
    var ModificarCombo = new Object();
    ModificarCombo.Codigo_combo  = document.getElementById("Codigo_combo").value;
    ModificarCombo.Codigo_Postal_S= document.getElementById("Codigo_Postal_S").value;
    ModificarCombo.Precio_Salon= document.getElementById("Precio_Salon").value;
    ModificarCombo.Precio_Terraza= document.getElementById("Precio_Terraza").value;
    ModificarCombo.op= "Modificar";
    $.ajax({
        url:"http://localhost:4684/Api/Combos", 
        type: "POST", 
        datatype: "json", 
        data: ModificarCombo, 
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

function EliminarCombo()
{
  var EliminarCombo = new Object();
   EliminarCombo.Codigo_combo  = document.getElementById("Codigo_combo").value;
    EliminarCombo.Op= "Eliminar";
    $.ajax({
        url:"http://localhost:4684/Api/Combos", 
        type: POST, 
        datatype: "json", 
        data: EliminarCombo, 
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