using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Models
{
    class Clase_Combos
    {
        public class Combo
        {
            private int Cod_Postal_S; //Establecer caracteristicas privadas
            private int Cod_combo;
            private decimal Precio_Salon;
            private decimal Precio_Terraza;
            private List<Clase_Bebidas> listadoBebidas;
            private List<Clase_Bocadillos> listadoBocadillos;

            public Combo() //constructor de la clase
            { }
            public int _Cod_Postal_S { get { return Cod_Postal_S; } set { Cod_Postal_S = value; } } //Convertir privadas a publicas las caracteristicas
            public int _Cod_combo { get { return Cod_combo; } set { Cod_combo = value; } }
            public decimal _Precio_Salon { get { return Precio_Salon; } set { Precio_Salon = value; } }
            public decimal _Precio_Terraza { get { return Precio_Terraza; } set { Precio_Terraza = value; } }
            public List<Clase_Bebidas> _listadoBebidas { get { return listadoBebidas; } set { listadoBebidas = value; } }
            public List<Clase_Bocadillos> _listadoBocadillos { get { return listadoBocadillos; } set { listadoBocadillos = value; } }

            public static int insertar_combo(int Cod_Postal, int Cod_combo, decimal precio_s, decimal precio_t)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC INSERTAR_COMBO ?,?,?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_Postal, 1);
                conx_detalles.annadir_parametro(Cod_combo, 1);
                conx_detalles.annadir_parametro(precio_s, 3);
                conx_detalles.annadir_parametro(precio_t, 3);
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

            public static int modificar_combo(int Cod_Postal, int Cod_combo, decimal precio_s, decimal precio_t)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC MODIFICAR_COMBO ?,?,?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_Postal, 1);
                conx_detalles.annadir_parametro(Cod_combo, 1);
                conx_detalles.annadir_parametro(precio_s, 3);
                conx_detalles.annadir_parametro(precio_t, 3);
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

            public static int eliminar_combo(int Cod_combo)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC ELIMINAR_COMBO ?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(Cod_combo, 1);
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
