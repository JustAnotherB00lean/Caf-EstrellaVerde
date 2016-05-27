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
    public class LicorController : ApiController
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Post(FormDataCollection form)
        {

            switch (form.Get("op"))
            {
                case "Insertar":
                    {
                        Models.Clase_Licor.Licor.insertar_licor(Convert.ToInt32(form.Get("id")), form.Get("nombre"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }

                case "Modificar":
                    {
                        Models.Clase_Licor.Licor.modificar_licor(Convert.ToInt32(form.Get("id")), form.Get("nombre"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }

                case "Eliminar":
                    {
                        Models.Clase_Licor.Licor.eliminar_licor(Convert.ToInt32(form.Get("id")));
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
