namespace Apuntes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Colecciones
            //ARRAYS UNIDIMENSIONALES: VECTOR//
            int[] edades = { 20, 18, 54, 33, 21 };
            // Para leer y editar utilizar un for
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine(edades[i]);
            }
            // Para solo lectura usar un foreach
            foreach (int i in edades)
                Console.WriteLine(i);
            //ARRAYS BIDIMENSIONALES: MATRIZ//
            int[,] matriz = new int[,] { { 5, 9 }, { 8, 72 }, { 3, 7 } };
            //Se recorren con el metodo del burbujeo
            for(int i = 0; i<matriz.GetLength(0); i++) //0 son filas, 1 son columnas
            {
                for(int j = 0; j<matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i<matriz.GetLength(0); i++) //0 son filas, 1 son columnas
            {
                Console.WriteLine(matriz[i, 1]);
            }
            //LISTAS//
            List<int> numeros = new List<int>();
            numeros.Add(2);
            numeros.Add(8);
            numeros.Add(9);
            numeros.Add(7);
            numeros.Add(1);
            Console.WriteLine(numeros[0]);
            bool esta = numeros.Contains(2);
            Console.WriteLine(esta);
            int indice = numeros.IndexOf(1);
            Console.WriteLine(indice);
            numeros.Remove(3);
            foreach (int i in numeros)
                Console.WriteLine(i);
            int cantidad = numeros.Count;
            Console.WriteLine(cantidad);

            #endregion

            #region METODOS DE CONCATENACION
            string nombre = "Luciana";
            // METODO 1
            Console.WriteLine($"Tu nombre es {nombre}"); 
            // METODO 2
            Console.WriteLine("Tu nombre es {0}", nombre); 
            // EJEMPLO DE USO
            string nuevoNombre;
            string nuevaEdad;
            Console.WriteLine("Ingrese su nombre: ");
            nuevoNombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            nuevaEdad = Console.ReadLine();
            Console.WriteLine("Tu nombre es {0} y tienes {1} años", nuevoNombre, nuevaEdad);             
            #endregion
            
            #region Conversiones
            int numeroEntero;
            numeroEntero = 10;
            float numeroFlotante;
            numeroFlotante = 20.5f;
            //implicita (no implica perdida de datos, por lo que no hay que forzarla)
            float conversionAFlotante = numeroEntero;
            //explicita (implica perdida de datos, por lo que hay que forzarla)
            int conversionAEntero = (int)numeroFlotante;
            /*
             * Para ver sobre conversores explicitos e implicitos de objetos
             * consultar la región "conversores" en las clases Alumno y Empresa
             */
            //Crear una empresa a partir de un alumno
            Alumno unAlumno;
            unAlumno = new Alumno("Juan", 12345678, "Av. Villaflor 123", 6);
            Empresa nuevaEmpresa;
            nuevaEmpresa = (Empresa)unAlumno;
            //Crear un alumno a partir de una empresa
            Empresa unaEmpresa;
            unaEmpresa = new Empresa("Pepe", "Av. Siempreviva 742");
            Alumno nuevoAlumno;
            nuevoAlumno = (Alumno)unaEmpresa;            
            #endregion


            //string nombre = "Pepito ruiz días   ";
            //int compara = string.Compare("luis", "pepe");
            //Console.WriteLine(compara);
            //bool contiene = nombre.Contains("Pepito");
            //Console.WriteLine(contiene);
            //int indice = nombre.IndexOf("as");
            //Console.WriteLine(indice);
            //string otroNombre = nombre.Trim();
            //Console.WriteLine($"{otroNombre} ACA TERMINA");

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
            //nombre = Console.ReadLine()
            //Console.WriteLine("Ingrese su edad: ");
            //edad = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tu nombre es {0} y tenes {1} años", nombre, edad);


            /*
             *Mostrar mensajes por consola: Console.WriteLine(lo que se quiere mostrar);
             *Pedir datos por consola: Console.ReadLine();
            */
            Console.WriteLine("Hello, World!");        
        
        }
        
        }
    }
