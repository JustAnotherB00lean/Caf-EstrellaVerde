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
    public class ClienteController : ApiController
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {

                case "Insertar":
                    {
                        Models.Clase_Cliente.cliente.insertar_cliente(Convert.ToInt32(form.Get("id")), form.Get("Nombre"), Convert.ToInt32(form.Get("Tipo")), form.Get("Correo"), form.Get("Password"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }
                    case "Modificar":
                    {

                    Models.Clase_Cliente.cliente.modificar_cliente(Convert.ToInt32(form.Get("id")), form.Get("Nombre"), Convert.ToInt32(form.Get("Tipo")), form.Get("Correo"), form.Get("Password"));
                    HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                    return response;
                        break;
                    }
                    case "Eliminar":
                    {
                        Models.Clase_Cliente.cliente.eliminar_cliente(Convert.ToInt32(form.Get("id")));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
                        return response;
                        break;
                    }
                    case "listar":
                    {
                        List<Models.Clase_Cliente.cliente> LISTAVACIA = new List<Models.Clase_Cliente.cliente>();
                        HttpResponseMessage response = Request.CreateResponse<List<Models.Clase_Cliente.cliente>>(HttpStatusCode.Created, Models.Clase_Cliente.cliente.Todos_los_clientes());
                        return response;
                        break;
                    }
                    case "login":
                    {
                        Models.Clase_Cliente.cliente.login(Convert.ToInt32(form.Get("id")), form.Get("pass"));
                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
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
