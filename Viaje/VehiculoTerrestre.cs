namespace Viaje
{
    public class VehiculoTerrestre
    {
        Colores color;
        short cantidadRuedas;
        short cantidadPuertas;

        public VehiculoTerrestre(Colores color, short cantidadRuedas, short cantidadPuertas)
        {
            this.color=color;
            this.cantidadRuedas=cantidadRuedas;
            this.cantidadPuertas=cantidadPuertas;
        }

        public Colores Color { get => color; set => color=value; }
        public short CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas=value; }
        public short CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas=value; }
    }
}