using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaje
{
    public class Moto : VehiculoTerrestre
    {
        short cilindrada;

        public Moto(Colores color, short cantidadRuedas, short cantidadPuertas, short cilindrada) : base(color, cantidadRuedas, cantidadPuertas)
        {
            this.cilindrada=cilindrada;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada=value; }
    }
}
