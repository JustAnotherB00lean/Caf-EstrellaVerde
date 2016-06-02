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
    public class CombosController : ApiController
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            

            switch (form.Get("op"))
            {
                case "Insertar":
                    {
                        Models.Clase_Combos.Combo.insertar_combo(Convert.ToInt32(form.Get("cod_postal_s")),Convert.ToInt32(form.Get("cod_combo")),Convert.ToDecimal(form.Get("precio_salon")),Convert.ToDecimal(form.Get("precio_terraza")));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }

                case "Modificar":
                    {
                        Models.Clase_Combos.Combo.modificar_combo(Convert.ToInt32(form.Get("cod_postal_s")),Convert.ToInt32(form.Get("cod_combo")),Convert.ToDecimal(form.Get("precio_salon")),Convert.ToDecimal(form.Get("precio_terraza")));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }

                case "Eliminar":
                    {
                        Models.Clase_Combos.Combo.eliminar_combo(Convert.ToInt32(form.Get("cod_combo")));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }
                case "listar":
                    {

                        List<Models.Clase_Combos.Combo> LISTAVACIA = new List<Models.Clase_Combos.Combo>();
                        HttpResponseMessage response = Request.CreateResponse<List<Models.Clase_Combos.Combo>>(HttpStatusCode.Created, Models.Clase_Combos.Combo.Todas_los_Combos());
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
