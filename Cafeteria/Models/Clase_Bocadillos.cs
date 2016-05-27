using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Models
{
    class Clase_Bocadillos
    {
        public class Bocadillos
        {
            private int Cod_bocadillo; //Establecer caracteristicas privadas
            private string Nombre;
            private string Ingredientes;
            private decimal Precio_ind;

            private decimal Precio_porc;
            private decimal Precio_T_ind;
            private decimal Precio_T_porc;
            private Bitmap foto;

            public Bocadillos() //constructor de la clase
            { }
            public int _Cod_bocadillo { get { return Cod_bocadillo; } set { Cod_bocadillo = value; } } //Convertir privadas a publicas las caracteristicas
            public string _Nombre { get { return Nombre; } set { Nombre = value; } }
            public string _Ingredientes { get { return Ingredientes; } set { Ingredientes = value; } }
            public decimal _Precio_ind { get { return Precio_ind; } set { Precio_ind = value; } }
            public decimal _Precio_porc { get { return Precio_porc; } set { Precio_porc = value; } }
            public decimal _Precio_T_ind { get { return Precio_T_ind; } set { Precio_T_ind = value; } }
            public decimal _Precio_T_porc { get { return Precio_T_porc; } set { Precio_T_porc = value; } }
            public Bitmap _foto { get { return foto; } set { foto = value; } }

            public static int insertar_Bocadillos(int Cod_bocadillo, String Nombre, String ingredientes, decimal precio_ind, decimal precio_por, decimal Precio_T_ind, decimal Precio_T_porc, byte[] foto)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC INSERTAR_BOCADILLOS ?,?,?,?,?,?,?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_bocadillo, 1);
                conx_detalles.annadir_parametro(Nombre, 2);
                conx_detalles.annadir_parametro(ingredientes, 2);
                conx_detalles.annadir_parametro(precio_ind, 3);
                conx_detalles.annadir_parametro(precio_por, 3);
                conx_detalles.annadir_parametro(Precio_T_ind, 3);
                conx_detalles.annadir_parametro(Precio_T_porc, 3);
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

            public static int modificar_Bocadillos(int Cod_bocadillo, String Nombre, String ingredientes, decimal precio_ind, decimal precio_por, decimal Precio_T_ind, decimal Precio_T_porc, byte[] foto)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC MODIFICAR_BOCADILLOS ?,?,?,?,?,?,?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_bocadillo, 1);
                conx_detalles.annadir_parametro(Nombre, 2);
                conx_detalles.annadir_parametro(ingredientes, 2);
                conx_detalles.annadir_parametro(precio_ind, 3);
                conx_detalles.annadir_parametro(precio_por, 3);
                conx_detalles.annadir_parametro(Precio_T_ind, 3);
                conx_detalles.annadir_parametro(Precio_T_porc, 3);
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

            public static int eliminar_Bocadillos(int Cod_bocadillo)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC ELIMINAR_BOCADILLOS ?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_bocadillo, 1);
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

        }
    }
}
