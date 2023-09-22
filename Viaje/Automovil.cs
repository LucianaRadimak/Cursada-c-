using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaje
{
    public class Automovil : VehiculoTerrestre
    {
        short cantidadMarchas;
        int cantidadPasajeros;

        public Automovil(Colores color, short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, int cantidadPasajeros) : base(color, cantidadRuedas, cantidadPuertas)
        {
            this.cantidadMarchas=cantidadMarchas;
            this.cantidadPasajeros=cantidadPasajeros;
        }

        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas=value; }
        public int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros=value; }
    }
}
