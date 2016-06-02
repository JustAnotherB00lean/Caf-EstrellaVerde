using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Cafeteria.Controllers
{
    public class ComboProductoController : ApiController
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {
                case "Insertar":
                    {

                        //MemoryStream memory_foto = new MemoryStream(bytes);
                        //Bitmap bmp = (Bitmap)Bitmap.FromStream(memory_foto);
                        //Bitmap bmp = new Bitmap(34, 34);

                        Models.Producto_Combo.agregar_producto_combo(Convert.ToInt32(form.Get("combo")), Convert.ToInt32(form.Get("bebida")), Convert.ToInt32(form.Get("bocadillo")));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        //memory_foto.Close();
                        break;
                    }

                case "Modificar":
                    {

                        //var memory_foto = new MemoryStream(bytes_foto);
                        //Bitmap bmp = new Bitmap(memory_foto);

                        Models.Clase_Licor_Bebida.insertar_Bebidas(Convert.ToInt32(form.Get("Cod_bebida")), Convert.ToInt32(form.Get("Cod_licor")));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        //memory_foto.Close();
                        break;
                    }

                case "Eliminar":
                    {
                        Models.Clase_Licor_Bebida.insertar_Bebidas(Convert.ToInt32(form.Get("Cod_bebida")), Convert.ToInt32(form.Get("Cod_licor")));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }
                case "listar":
                    {

                        List<Models.Clase_Licor_Bebida> LISTAVACIA = new List<Models.Clase_Licor_Bebida>();
                        HttpResponseMessage response = Request.CreateResponse<List<Models.Clase_Licor_Bebida>>(HttpStatusCode.Created, Models.Clase_Licor_Bebida.Todas_las_bebidas());
                        return response;
                        break;
                    }
                default:
                    {
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }
            }
        }
    }
}
