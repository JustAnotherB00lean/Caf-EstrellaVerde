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
    public class BocadillosController : ApiController
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Post(FormDataCollection form)
        {


            switch (form.Get("op"))
            {
                case "Insertar":
                    {
                        String foto = form.Get("foto");
                        foto = foto.Replace("data:image/jpeg;base64,", "");
                        byte[] bytes_foto = Convert.FromBase64String(foto);
                        //var memory_foto = new MemoryStream(bytes_foto);
                        //Bitmap bmp = new Bitmap(memory_foto);

                        Models.Clase_Bocadillos.Bocadillos.insertar_Bocadillos(Convert.ToInt32(form.Get("id")), form.Get("nombre"), form.Get("ingredientes"), Convert.ToDecimal(form.Get("precio_ind")), Convert.ToDecimal(form.Get("precio_porc")), Convert.ToDecimal(form.Get("precio_t_ind")), Convert.ToDecimal(form.Get("precio_t_porc")), bytes_foto);
                        //memory_foto.Close();
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }

                case "Modificar":
                    {
                        String foto = form.Get("foto");
                        foto = foto.Replace("data:image/jpeg;base64,", "");
                        byte[] bytes_foto = Convert.FromBase64String(foto);

                        Models.Clase_Bocadillos.Bocadillos.modificar_Bocadillos(Convert.ToInt32(form.Get("id")), form.Get("nombre"), form.Get("ingredientes"), Convert.ToDecimal(form.Get("precio_ind")), Convert.ToDecimal(form.Get("precio_porc")), Convert.ToDecimal(form.Get("precio_t_ind")), Convert.ToDecimal(form.Get("precio_t_porc")), bytes_foto);
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }

                case "Eliminar":
                    {
                        Models.Clase_Bocadillos.Bocadillos.eliminar_Bocadillos(Convert.ToInt32(form.Get("id")));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }

                case "listar":
                    {

                        List<Models.Clase_Bocadillos.Bocadillos> LISTAVACIA = new List<Models.Clase_Bocadillos.Bocadillos>();
                        HttpResponseMessage response = Request.CreateResponse<List<Models.Clase_Bocadillos.Bocadillos>>(HttpStatusCode.Created, Models.Clase_Bocadillos.Bocadillos.Todas_los_Bocadillos());
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
