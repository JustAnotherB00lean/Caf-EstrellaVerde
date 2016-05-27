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
    public class Sucursal2Controller : ApiController
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "Insertar":
                    {
                        Models.Clase_Sucursales.Sucursales.insertar_sucursal(Convert.ToInt32(form.Get("Cod_Postal")), form.Get("Provincia"), form.Get("Canton"), form.Get("Distrito"), Convert.ToInt32(form.Get("Telefono")), form.Get("lema"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }
                case "Modificar":
                    {

                        Models.Clase_Sucursales.Sucursales.modificar_Sucursal(Convert.ToInt32(form.Get("Cod_Postal")), form.Get("Provincia"), form.Get("canton"), form.Get("distrito"), Convert.ToInt32(form.Get("Telefono")), form.Get("Lema"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }
                case "Eliminar":
                    {
                        Models.Clase_Sucursales.Sucursales.eliminar_Sucursal(Convert.ToInt32(form.Get("Cod_Postal")));
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
