namespace Apuntes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Pepito ruiz días   ";
            int compara = string.Compare("luis", "pepe");
            Console.WriteLine(compara);
            bool contiene = nombre.Contains("Pepito");
            Console.WriteLine(contiene);
            int indice = nombre.IndexOf("as");
            Console.WriteLine(indice);
            string otroNombre = nombre.Trim();
            Console.WriteLine($"{otroNombre} ACA TERMINA");

            ///// <summary>
            ///// determina la paridad de un numero
            ///// </summary>
            ///// <param name="numero"></param>
            ///// <returns>true si es par, false si es impar</returns>
            //public static bool DeterminarParidad(int numero)
            //{
            //    return (numero % 2 == 0);
            //}
            //
            //char[] arrayNombre = nombre.ToCharArray();
            //for (int i=0; i<arrayNombre.Length; i++)
            //{
            //    Console.WriteLine("***{0}", arrayNombre[i]);
            //}
            //StringBuilder texto = new StringBuilder();
            //texto.AppendLine("gdsgdsgsf");
            //texto.Append("1gdfsjghdfsjhghfsd");
            //Console.WriteLine(texto);

            //int numero;
            //Console.WriteLine("Ingresame un número");
            //numero = int.Parse(Console.ReadLine());
            //if(Metodos.DeterminarParidad(numero))
            //{
            //    Console.WriteLine("El numero es par");
            //}
            //else 
            //{
            //    Console.WriteLine("El numero es impar");
            //}
            ///*         
        //string nombre;
        //int edad;
        //Console.WriteLine("Ingrese su nombre: ");
        //nombre = 
        //Console.WriteLine("Ingrese su edad: ");
        //edad = int.Parse(Console.ReadLine());
        //Console.WriteLine("Tu nombre es {0} y tenes {1} años", nombre, edad);

        //
        //float numero = 15; //Implicita
        //int otroNumero = (int)3.5;//Explicita
        //int dni = 458955355;
        //long dni = 45895585555;
        //
        /*
         *Mostrar mensajes por consola: Console.WriteLine(lo que se quiere mostrar);
         *Pedir datos por consola: Console.ReadLine();
                METODOS DE CONCATENACION
        Console.WriteLine($"Tu nombre es {nombre}"); METODO 1
        Console.WriteLine("Tu nombre es {0}", nombre); METODO 2
        */
         Console.WriteLine("Hello, World!");

        
        }
        
        }
    }
