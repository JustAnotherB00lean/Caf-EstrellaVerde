using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koffing.Models
{
    public class Licor
    {
        private int Cod_Postal_S; //Establecer caracteristicas privadas
        private int Cod_combo;
        private decimal Precio_Salon;
        private decimal Precio_Terraza;

        public Licor() //constructor de la clase
        { }
        public int _Cod_Postal_S { get { return Cod_Postal_S; } set { Cod_Postal_S = value; } } //Convertir privadas a publicas las caracteristicas
        public int _Cod_combo { get { return Cod_combo; } set { Cod_combo = value; } }
        public decimal _Precio_Salon { get { return Precio_Salon; } set { Precio_Salon = value; } }
        public decimal _Precio_Terraza { get { return Precio_Terraza; } set { Precio_Terraza = value; } }

    }
}




