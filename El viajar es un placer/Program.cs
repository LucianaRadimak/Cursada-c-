using Viaje;

namespace El_viajar_es_un_placer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil auto;
            auto = new Automovil(Colores.rojo, 4, 2, 6, 5);
            Console.WriteLine($"Auto= *Color: {auto.Color} *Ruedas: {auto.CantidadRuedas} *Puertas: {auto.CantidadPuertas} *Marchas: {auto.CantidadMarchas} *Pasajeros: {auto.CantidadPasajeros}");

            Camion camion;
            camion = new Camion(Colores.azul, 8, 4, 5, 300);
            Console.WriteLine($"Camion= *Color: {camion.Color} *Ruedas: {camion.CantidadRuedas} *Puertas: {camion.CantidadPuertas} *Marchas: {camion.CantidadMarchas} *Peso Carga: {camion.PesoCarga}");

            Moto moto;
            moto = new Moto(Colores.negro, 2, 0, 5);
            Console.WriteLine($"Moto= *Color: {moto.Color} *Ruedas: {moto.CantidadRuedas} *Puertas: {moto.CantidadPuertas} *Cilindrada: {moto.Cilindrada}");
        }
    }
}