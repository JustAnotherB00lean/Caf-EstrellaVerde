using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Cafeteria.Controllers
{
    public class BebidasController : ApiController
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {
                case "Insertar":
                    {
                        Models.Clase_Bebidas.Bebidas.insertar_Bebidas(Convert.ToInt32(form.Get("id")),form.Get("nombre"),form.Get("ingredientes"),Convert.ToInt32(form.Get("precio_ind")),Convert.ToInt32(form.Get("precio_porc")),Convert.ToInt32(form.Get("precio_t_ind")),Convert.ToInt32(form.Get("precio_t_porc")), form.Get("foto"));
                         HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }

                case "Modificar":
                    {
                        String foto = form.Get("foto");
                        foto = foto.Replace("data:image/jpeg;base64,", "");
                        byte[] bytes_foto = Convert.FromBase64String(foto);
                        //var memory_foto = new MemoryStream(bytes_foto);
                        //Bitmap bmp = new Bitmap(memory_foto);

                        Models.Clase_Bebidas.Bebidas.modificar_Bebidas(Convert.ToInt32(form.Get("id")), form.Get("nombre"), form.Get("ingredientes"), Convert.ToInt32(form.Get("precio_ind")), Convert.ToInt32(form.Get("precio_porc")), Convert.ToInt32(form.Get("precio_t_ind")), Convert.ToInt32(form.Get("precio_t_porc")), form.Get("foto"));
                         HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        //memory_foto.Close();
                        break;
                    }

                case "Eliminar":
                    {
                        Models.Clase_Bebidas.Bebidas.eliminar_Bebidas(Convert.ToInt32(form.Get("id")));
                         HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                         return response;
                        break;
                    }
        case "listar":
                    {

                         List<Models.Clase_Bebidas.Bebidas> LISTAVACIA = new List<Models.Clase_Bebidas.Bebidas>();
                        HttpResponseMessage response = Request.CreateResponse<List<Models.Clase_Bebidas.Bebidas>>(HttpStatusCode.Created, Models.Clase_Bebidas.Bebidas.Todas_las_bebidas());
                        return response;
                        break;
                    }
                default:{
                    HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                         return response;
                break;
                }
        }
    }
    }
}
