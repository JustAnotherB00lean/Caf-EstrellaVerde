using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Models
{
    class Clase_Cliente
    {
        public class cliente
        {
            private int id; //Establecer caracteristicas privadas
            private string nombre;
            private Boolean tipo;
            private string correo;
            private string password;

            public cliente() //constructor de la clase
            { }
            public int _id { get { return id; } set { id = value; } } //Convertir privadas a publicas las caracteristicas
            public string _nombre { get { return nombre; } set { nombre = value; } }
            public Boolean _tipo { get { return tipo; } set { tipo = value; } }
            public string _correo { get { return correo; } set { correo = value; } }
            public string _password { get { return password; } set { password = value; } }

            public static int login(int _id, String _password)
            {
                int resultado = 0;

                Conexion conx_detalles = new Conexion(); //Crear conexion
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR; //Declarar contenedor

                CONSULTA = "EXEC login ?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(_id, 1);
                conx_detalles.annadir_parametro(_password, 2);

                CONTENEDOR = conx_detalles.busca();
                while (CONTENEDOR.Read()) //Leer contenedor
                {
                    resultado = Convert.ToInt32(CONTENEDOR[0].ToString());
                }
                conx_detalles.conexion.Close();
                conx_detalles.conexion.Dispose();
                CONTENEDOR.Close();

                return resultado;
            }

            public static int insertar_cliente(int id, String Nombre, int tipo, String correo, String password) //Declarar funcion
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion(); //Crear conexion
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR; //Declarar contenedor

                CONSULTA = "EXEC INSERTAR_CLIENTE ?,?,?,?,?"; //Establecer Parametros
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(id, 1);
                conx_detalles.annadir_parametro(Nombre, 2);
                conx_detalles.annadir_parametro(tipo, 1);
                conx_detalles.annadir_parametro(correo, 2);
                conx_detalles.annadir_parametro(password, 2);
                CONTENEDOR = conx_detalles.busca();
                while (CONTENEDOR.Read()) //Leer contenedor
                {
                    respuesta = Convert.ToInt32(CONTENEDOR[0].ToString());
                }
                conx_detalles.conexion.Close();
                conx_detalles.conexion.Dispose();
                CONTENEDOR.Close();
                return respuesta; // Devolver respuesta
            }

            public static int modificar_cliente(int id, String Nombre, int tipo, String correo, String password) //Declarar funcion
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion(); //Crear conexion
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR; //Declarar contenedor

                CONSULTA = "EXEC MODIFICAR_CLIENTE ?,?,?,?,?"; //Establecer Parametros
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(id, 1);
                conx_detalles.annadir_parametro(Nombre, 2);
                conx_detalles.annadir_parametro(tipo, 1);
                conx_detalles.annadir_parametro(correo, 2);
                conx_detalles.annadir_parametro(password, 2);
                CONTENEDOR = conx_detalles.busca();
                while (CONTENEDOR.Read()) //Leer contenedor
                {
                    respuesta = Convert.ToInt32(CONTENEDOR[0].ToString());
                }
                conx_detalles.conexion.Close();
                conx_detalles.conexion.Dispose();
                CONTENEDOR.Close();
                return respuesta; // Devolver respuesta
            }

            public static int eliminar_cliente(int id) //Declarar funcion
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion(); //Crear conexion
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR; //Declarar contenedor

                CONSULTA = "EXEC ELIMINAR_CLIENTE ?"; //Establecer Parametros
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(id, 1);
                CONTENEDOR = conx_detalles.busca();
                while (CONTENEDOR.Read()) //Leer contenedor
                {
                    respuesta = Convert.ToInt32(CONTENEDOR[0].ToString());
                }
                conx_detalles.conexion.Close();
                conx_detalles.conexion.Dispose();
                CONTENEDOR.Close();
                return respuesta; // Devolver respuesta
            }

            public static List<cliente> Todos_los_clientes()
            {
                List<cliente> Listaadevolver = new List<cliente>();
                Conexion cnx = new Conexion();
                cnx.parametro();
                cnx.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;
                CONSULTA = "EXEC SELECCIONAR_CLIENTE ?";
                cnx.annadir_consulta(CONSULTA);
                cnx.annadir_parametro(0, 1);
                CONTENEDOR = cnx.busca();
                while (CONTENEDOR.Read())
                {
                    cliente NUEVOCLIENTE = new cliente();
                    NUEVOCLIENTE.id = Convert.ToInt32(CONTENEDOR["id"]);
                    NUEVOCLIENTE.nombre = CONTENEDOR["nombre"].ToString();
                    NUEVOCLIENTE.tipo = Convert.ToBoolean(CONTENEDOR["tipo"]);
                    NUEVOCLIENTE.correo = CONTENEDOR["correo"].ToString();
                    NUEVOCLIENTE.password = CONTENEDOR["password"].ToString();
                    Listaadevolver.Add(NUEVOCLIENTE);

                }
                cnx.conexion.Close();
                cnx.conexion.Dispose();
                CONTENEDOR.Close();
                return Listaadevolver;

            }

            //public static List<Clases.Usuario> SELECCIONA_USUARIO(int _ID)
            //{
            //    List<Clases.Usuario> LISTA_CLASE_USUARIO = new List<Clases.Usuario>();


            //    Conexion conx_detalles = new Conexion();
            //    conx_detalles.parametro();
            //    conx_detalles.inicializa();
            //    string CONSULTA;
            //    System.Data.OleDb.OleDbDataReader CONTENEDOR;

            //    CONSULTA = "EXEC SELECCIONA_USUARIO ?";
            //    conx_detalles.annadir_consulta(CONSULTA);
            //    conx_detalles.annadir_parametro(_ID, 1);

            //    CONTENEDOR = conx_detalles.busca();
            //    while (CONTENEDOR.Read())
            //    {
            //        Clases.Usuario CLASE_USUARIO = new Clases.Usuario();
            //        CLASE_USUARIO.ID = Convert.ToInt32(CONTENEDOR["ID"].ToString());
            //        CLASE_USUARIO.NOMBRE = CONTENEDOR["NOMBRE"].ToString();
            //        CLASE_USUARIO.PRIMER_APELLIDO = CONTENEDOR["PRIMER_APELLIDO"].ToString();
            //        CLASE_USUARIO.SEGUNDO_APELLIDO = CONTENEDOR["SEGUNDO_APELLIDO"].ToString();

            //        CLASE_USUARIO.TELEFONO = CONTENEDOR["TELEFONO"].ToString();
            //        CLASE_USUARIO.MOVIL = CONTENEDOR["MOVIL"].ToString();
            //        CLASE_USUARIO.DIRECCION = CONTENEDOR["DIRECCION"].ToString();

            //        LISTA_CLASE_USUARIO.Add(CLASE_USUARIO);

            //    }
            //    conx_detalles.conexion.Close();
            //    conx_detalles.conexion.Dispose();
            //    CONTENEDOR.Close();
            //    return LISTA_CLASE_USUARIO;
            //}


            //public List<cliente> Seleccionar_Cliente(int Codigo_Clientes)
            //{
            //    List<cliente> listadocliente = new List<cliente>;
            //    return listadocliente;
            //}
        }
    }
}
