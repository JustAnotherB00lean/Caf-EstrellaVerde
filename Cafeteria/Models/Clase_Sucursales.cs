using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.Models
{
    class Clase_Sucursales
    {
        public class Sucursales
        {
            private int Cod_Postal; //Establecer caracteristicas privadas
            private string Provincia;
            private string Canton;
            private string Distrito;
            private int Telefono;
            private string lema;
            private List<Clase_Sucursales> listadoSucursales;

            public Sucursales() //constructor de la clase
            { }
            public int _Cod_Postal { get { return Cod_Postal; } set { Cod_Postal = value; } } //Convertir privadas a publicas las caracteristicas
            public string _Provincia { get { return Provincia; } set { Provincia = value; } }
            public string _Canton { get { return Canton; } set { Canton = value; } }
            public string _Distrito { get { return Distrito; } set { Distrito = value; } }
            public int _Telefono { get { return Telefono; } set { Telefono = value; } }
            public string _lema { get { return lema; } set { lema = value; } }

            public static int insertar_sucursal(int cod_postal, String provincia, string canton, string distrito, int telefono, string lema)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC INSERTAR_SUCURSAL ?,?,?,?,?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(cod_postal, 1);
                conx_detalles.annadir_parametro(provincia, 2);
                conx_detalles.annadir_parametro(canton, 2);
                conx_detalles.annadir_parametro(distrito, 2);
                conx_detalles.annadir_parametro(telefono, 1);
                conx_detalles.annadir_parametro(lema, 2);
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

            public static int modificar_Sucursal(int cod_postal, string provincia, string canton, string distrito, int telefono, string lema)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC MODIFICAR_SUCURSAL ?,?,?,?,?,?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(cod_postal, 1);
                conx_detalles.annadir_parametro(provincia, 2);
                conx_detalles.annadir_parametro(canton, 2);
                conx_detalles.annadir_parametro(distrito, 2);
                conx_detalles.annadir_parametro(telefono, 1);
                conx_detalles.annadir_parametro(lema, 2);
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

            public static int eliminar_Sucursal(int cod_postal)
            {
                int respuesta = 0;

                Conexion conx_detalles = new Conexion();
                conx_detalles.parametro();
                conx_detalles.inicializa();
                string CONSULTA;
                System.Data.OleDb.OleDbDataReader CONTENEDOR;

                CONSULTA = "EXEC eliminar_Sucursal ?";
                conx_detalles.annadir_consulta(CONSULTA);
                conx_detalles.annadir_parametro(cod_postal, 1);
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

            public List<Clase_Sucursales> _listadoSucursales { get { return listadoSucursales; } set { listadoSucursales = value; } }
          
            public List<Sucursales> Seleccionar_Sucursales(int Codigo_Sucursales)
            {
                List<Sucursales> lista_Sucursales = new List<Sucursales>();
                return lista_Sucursales;
            }
        }
    }
}
