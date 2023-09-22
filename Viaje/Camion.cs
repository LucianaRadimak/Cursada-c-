using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaje
{
    public class Camion : VehiculoTerrestre
    {
        short cantidadMarchas;
        int pesoCarga;

        public Camion(Colores color, short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, int pesoCarga) : base(color, cantidadRuedas, cantidadPuertas)
        {
            this.cantidadMarchas=cantidadMarchas;
            this.pesoCarga=pesoCarga;
        }

        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas=value; }
        public int PesoCarga { get => pesoCarga; set => pesoCarga=value; }
    }
}
