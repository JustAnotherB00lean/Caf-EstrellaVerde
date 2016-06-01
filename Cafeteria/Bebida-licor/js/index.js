$(document).ready(function() {
  
  $(".selLabel").click(function () {
    $('.dropdown').toggleClass('active');
       
  });
    
     
    $(".selLabel1").click(function () {
   $('.dropdown1').toggleClass('active');
       
  });
    
  
  $(".dropdown-list li").click(function() {
    $('.selLabel').text($(this).text());
    $('.dropdown').removeClass('active');
    $('.selected-item p span').text($('.selLabel').text());
  });
    
     $(".dropdown1-list li").click(function() {
    $('.selLabel1').text($(this).text());
    $('.dropdown1').removeClass('active');
    $('.selected-item1 p span').text($('.selLabel1').text());
  });
  
});

(function() {
  var resize;
 
  $("btn").click(function() {
      insertarBebida();
    if ($("btn").hasClass("loading-start")) {
      if ($("btn").hasClass("loading-end")) {
        return $("btn").attr("class", "");
      }
    } else {
      setTimeout((function() {
        return $("btn").addClass("loading-start");
      }), 0);
      setTimeout((function() {
        return $("btn").addClass("loading-progress");
      }), 500);
      return setTimeout((function() {
        return $("btn").addClass("loading-end");
      }), 1500);
    }
  });

  resize = function() {
    return $("body").css({
      "margin-top": ~~((window.innerHeight - 260) / 2) + "px"
    });
  };

  $(window).resize(resize);

  resize();

}).call(this);



//---------------------------------------------------------------------------------------------------------------------------------------//
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