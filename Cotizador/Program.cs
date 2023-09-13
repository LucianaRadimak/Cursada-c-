using Billetes;
namespace Cotizador
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos de Dolar, Euro y Peso
            Dolar dolar1 = new Dolar(100);
            Euro euro1 = new Euro(85);
            Peso peso1 = new Peso(5000);

            // conversiones explícitas
            Dolar dolarDesdeEuro = (Dolar)euro1;
            Dolar dolarDesdePeso = (Dolar)peso1;

            // Mostrar valores convertidos
            Console.WriteLine($"Euro a Dolar: {euro1.GetCantidad()} Euros = {dolarDesdeEuro.GetCantidad()} Dólares");
            Console.WriteLine($"Peso a Dolar: {peso1.GetCantidad()} Pesos = {dolarDesdePeso.GetCantidad()} Dólares");

            // suma y resta
            Dolar sumaDolar = dolar1 + euro1;
            Dolar restaDolar = dolar1 - peso1;

            // Mostrar resultados
            Console.WriteLine($"Suma en Dólar: {dolar1.GetCantidad()} + {euro1.GetCantidad()} Euros = {sumaDolar.GetCantidad()} Dólares");
            Console.WriteLine($"Resta en Dólar: {dolar1.GetCantidad()} - {peso1.GetCantidad()} Pesos = {restaDolar.GetCantidad()} Dólares");

            // Comparar cantidades
            bool igualDolarEuro = dolar1 == euro1;
            bool igualDolarPeso = dolarDesdePeso == dolar1;

            Console.WriteLine($"¿Dólar igual a Euro? {igualDolarEuro}");
            Console.WriteLine($"¿Dólar igual a Peso? {igualDolarPeso}");
        }
    }
}
