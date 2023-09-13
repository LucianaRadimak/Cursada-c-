namespace Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador miSumador = new Sumador();
            Console.WriteLine(miSumador.Sumar("hola", "mundo"));
            Console.WriteLine(miSumador.Sumar(5, 9));
            Sumador otroSumador = new Sumador(3);
            if(miSumador | otroSumador)
            {
                Console.WriteLine("Igualdad encontrada");
            }
            else
            {
                Console.WriteLine("Desigualdad encontrada");
            }
            Console.WriteLine($"Sumador A: {miSumador.CantidadSumas}. Sumador B: {otroSumador.CantidadSumas}");
            Console.WriteLine($"Sumas totales: {miSumador+otroSumador}");
        }
    }
}