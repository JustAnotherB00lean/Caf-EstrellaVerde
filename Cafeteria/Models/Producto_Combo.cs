using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cafeteria.Models
{
    public class Producto_Combo
    {
        private int id_combo;
        private int id_producto;

        Producto_Combo();

        public int _id_combo { get { return id_combo; } set { id_combo = value; } }
        public int _id_producto { get { return id_producto; } set { id_producto = value; } }

        public static int agregar_producto_combo(int combo, int producto)
        {
            int respuesta = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC INSERTAR_PRODUCTOCOMBO ?,?";
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(combo, 1);
            conx_detalles.annadir_parametro(producto, 1);


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