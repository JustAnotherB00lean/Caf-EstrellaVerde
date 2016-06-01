<script type="text/javascript">
function listadeproductos() {
    var Producto = new Object();
    Producto.op = "listar";

    $.ajax({
        url: "http://localhost:1331/api/Producto",
   
        type: 'POST',
        dataType: 'json',
        data: Producto,
        success: function (data, textStatus, xhr) {
            
            for (var ele in data) {
                var x = document.getElementById('Bebida')
                x= x + "<li id='1'> <span>India</span> </li>"
                var option = document.createElement("option");
                option.text = data[ele]._Nombre;
                option.value = data[ele]._Id;
                option.id= data[ele]._Id;
                x.add(option);
            }


        },"
            error: function (xhr, textStatus, errorThrown) {
                alert(xhr);
            }
});

}
</script>
