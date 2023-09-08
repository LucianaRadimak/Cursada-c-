namespace Ejercicio_2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1;
            estudiante1 = new Estudiante("Isaac", "Newton", "16421727");
            Estudiante estudiante2;
            estudiante2 = new Estudiante("Napoleón", "Bonaparte", "17691821");
            Estudiante estudiante3;
            estudiante3 = new Estudiante("Albert", "Einstein", "18791955");

            estudiante1.SetNotaPrimerParcial(7);
            estudiante1.SetNotaSegundoParcial(8);

            estudiante2.SetNotaPrimerParcial(3);
            estudiante2.SetNotaSegundoParcial(5);

            estudiante3.SetNotaPrimerParcial(9);
            estudiante3.SetNotaSegundoParcial(10);

            Console.WriteLine("Datos de Estudiante 1:");
            Console.WriteLine(estudiante1.Mostrar());

            Console.WriteLine("Datos de Estudiante 2:");
            Console.WriteLine(estudiante2.Mostrar());

            Console.WriteLine("Datos de Estudiante 3:");
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}