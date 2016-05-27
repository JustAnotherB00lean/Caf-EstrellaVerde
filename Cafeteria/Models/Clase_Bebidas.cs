using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Models
{
    class Clase_Bebidas
    {
        public class Bebidas
        {
            private int Cod_bebida; //Establecer caracteristicas privadas
            private string Nombre;
            private string Ingredientes;
            private int Precio_ind;
            private int Precio_porc;
            private int Precio_T_ind;
            private int Precio_T_porc;
            private byte[] foto;
            private List<Clase_Bebidas> listadoBebidas;

            public Bebidas() //constructor de la clase
            { }
            public int _Cod_bebida { get { return Cod_bebida; } set { Cod_bebida = value; } } //Convertir privadas a publicas las caracteristicas
            public string _Nombre { get { return Nombre; } set { Nombre = value; } }
            public string _Ingredientes { get { return Ingredientes; } set { Ingredientes = value; } }
            public int _Precio_ind { get { return Precio_ind; } set { Precio_ind = value; } }
            public int _Precio_porc { get { return Precio_porc; } set { Precio_porc = value; } }
            public int _Precio_T_ind { get { return Precio_T_ind; } set { Precio_T_ind = value; } }
            public int _Precio_T_porc { get { return Precio_T_porc; } set { Precio_T_porc = value; } }
            public byte[] _foto { get { return foto; } set { foto = value; } }

            public List<Clase_Bebidas> _listadoBebidas { get { return listadoBebidas; } set { listadoBebidas = value; } }

            public static int insertar_Bebidas(int Cod_bebida, String Nombre, String ingredientes,int precio_ind, int precio_por, int Precio_T_ind, int Precio_T_porc, byte[] foto)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC INSERTAR_BEBIDAS ?,?,?,?,?,?,?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_bebida, 1);
                conx_detalles.annadir_parametro(Nombre, 2);
                conx_detalles.annadir_parametro(ingredientes, 2);
                conx_detalles.annadir_parametro(precio_ind, 1);
                conx_detalles.annadir_parametro(precio_por, 1);
                conx_detalles.annadir_parametro(Precio_T_ind, 1);
                conx_detalles.annadir_parametro(Precio_T_porc, 1);
                conx_detalles.annadir_parametro(foto, 5);
                CONTENEDOR = conx_detalles.busca();
                while (CONTENEDOR.Read())
                {
                    respuesta = Convert.ToInt32(CONTENEDOR[0].ToString());
                }
                conx_detalles.conexion.Close();
                conx_detalles.conexion.Dispose();
                CONTENEDOR.Close();
                return respuesta;
            }

            public static int eliminar_Bebidas(int Cod_bebida)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC ELIMINAR_BEBIDAS ?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_bebida, 1);
                CONTENEDOR = conx_detalles.busca();
                while (CONTENEDOR.Read())
                {
                    respuesta = Convert.ToInt32(CONTENEDOR[0].ToString());
                }
                conx_detalles.conexion.Close();
                conx_detalles.conexion.Dispose();
                CONTENEDOR.Close();
                return respuesta;
            }

            public static int modificar_Bebidas(int Cod_bebida, String Nombre, String ingredientes, int precio_ind, int precio_por, int Precio_T_ind, int Precio_T_porc, byte[] foto)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC MODIFICAR_BEBIDAS ?,?,?,?,?,?,?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_bebida, 1);
                conx_detalles.annadir_parametro(Nombre, 2);
                conx_detalles.annadir_parametro(ingredientes, 2);
                conx_detalles.annadir_parametro(precio_ind, 1);
                conx_detalles.annadir_parametro(precio_por, 1);
                conx_detalles.annadir_parametro(Precio_T_ind, 1);
                conx_detalles.annadir_parametro(Precio_T_porc, 1);
                conx_detalles.annadir_parametro(foto, 5);
                CONTENEDOR = conx_detalles.busca();
                while (CONTENEDOR.Read())
                {
                    respuesta = Convert.ToInt32(CONTENEDOR[0].ToString());
                }
                conx_detalles.conexion.Close();
                conx_detalles.conexion.Dispose();
                CONTENEDOR.Close();
                return respuesta;
            }

            public static List<Bebidas> Todas_las_bebidas()
            {
                List<Bebidas> Listaadevolver = new List<Bebidas>();
                Conexion cnx = new Conexion();
                cnx.parametro();
                cnx.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;
                CONSULTA = "EXEC SELECCIONAR_BEBIDAS ?";
                cnx.annadir_consulta(CONSULTA);
                cnx.annadir_parametro(0, 1);
                CONTENEDOR = cnx.busca();
                while (CONTENEDOR.Read())
                {
                    Bebidas NUEVABEBIDA = new Bebidas();
                    NUEVABEBIDA.Cod_bebida = Convert.ToInt32(CONTENEDOR["Cod_bebida"]);
                    NUEVABEBIDA.Nombre = CONTENEDOR["Nombre"].ToString();
                    NUEVABEBIDA.Ingredientes = CONTENEDOR["ingredientes"].ToString();
                    NUEVABEBIDA.Precio_ind = Convert.ToInt32(CONTENEDOR["Precio_ind"]);
                    NUEVABEBIDA.Precio_porc = Convert.ToInt32(CONTENEDOR["Precio_porc"]);
                    NUEVABEBIDA.Precio_T_ind = Convert.ToInt32(CONTENEDOR["Precio_T_ind"]);
                    NUEVABEBIDA.Precio_T_porc = Convert.ToInt32(CONTENEDOR["Precio_T_porc"]);


                    NUEVABEBIDA.foto = Encoding.ASCII.GetBytes(CONTENEDOR["FOTO"].ToString()); 
                     Listaadevolver.Add(NUEVABEBIDA);

                }
                cnx.conexion.Close();
                cnx.conexion.Dispose();
                CONTENEDOR.Close();
                return Listaadevolver;

            }

            //public List<Bebidas> Seleccionar_Bebida(int Codigo_Bebida)
            //{
            //    List<Bebidas> lista_bebidas= new List<Bebidas>;
            //    return lista_bebidas;
            //}
        }
    }
}
