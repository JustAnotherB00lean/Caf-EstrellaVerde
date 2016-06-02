using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cafeteria.Models
{
    public class Clase_Licor_Bebida
    {
          private int Cod_bebida; //Establecer caracteristicas privadas
          private int Cod_licor;

          public Clase_Licor_Bebida() //constructor de la clase
            { }
            public int _Cod_bebida { get { return Cod_bebida; } set { Cod_bebida = value; } } //Convertir privadas a publicas las caracteristicas
            public int _Cod_licor { get { return Cod_licor; } set { Cod_licor = value; } }


            public static int insertar_Bebidas(int Cod_bebida, int Cod_licor)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC INSERTAR_LICORBEBIDA ?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_bebida, 1);
                conx_detalles.annadir_parametro(Cod_licor, 1);
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

            public static int eliminar_Bebidas(int Cod_bebida, int Cod_licor)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC ELIMINAR_LICORBEBIDA ?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_bebida, 1);
                conx_detalles.annadir_parametro(Cod_licor, 1);
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

            public static int modificar_Bebidas(int Cod_bebida, int Cod_licor)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC MODIFICAR_LICORBEBIDA ?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_bebida, 1);
                conx_detalles.annadir_parametro(Cod_licor, 1);
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

            public static List<Clase_Licor_Bebida> Todas_las_bebidas()
            {
                List<Clase_Licor_Bebida> Listaadevolver = new List<Clase_Licor_Bebida>();
                Conexion cnx = new Conexion();
                cnx.parametro();
                cnx.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;
                CONSULTA = "EXEC SELECCIONAR_LICORBEBIDA ?";
                cnx.annadir_consulta(CONSULTA);
                cnx.annadir_parametro(0, 1);
                CONTENEDOR = cnx.busca();
                while (CONTENEDOR.Read())
                {
                    Clase_Licor_Bebida NUEVABEBIDA = new Clase_Licor_Bebida();
                    NUEVABEBIDA.Cod_bebida = Convert.ToInt32(CONTENEDOR["Cod_bebida"]);
      
                     Listaadevolver.Add(NUEVABEBIDA);

                }
                cnx.conexion.Close();
                cnx.conexion.Dispose();
                CONTENEDOR.Close();
                return Listaadevolver;

            }
    }
}