namespace Ejercicio_1
{
    /*
     ● int ContarLetras(string palabra): Cuenta la cantidad de letras que tiene una
    palabra.
    ● int ContarPalabras(string texto): Cuenta la cantidad de palabras que contiene
    el texto;
    ● int ContarVocales(string palabra): Cuenta la cantidad de vocales que
    contiene una palabra.
    ● int ContarConsonantes(string palabra): Cuenta la cantidad de consonantes
    que contiene una palabra.
    ● string ReemplazarCaracter(string palabra, char original, char nuevo):
    Reemplaza el carácter original por el indicado.
    ● bool ConvertirStringAEntero(string texto, int xxx numeroEntero): Devuelve si
    es posible convertir un texto a entero y si es posible lo devuelve en la
    variable numeroEntero.
    ● StringBuilder ConvertirStringASB(string palabra): Recibe un string y lo guarda
    en un StringBuilder.
    ● StringBuilder ConvertirParrafoASB(string parrafo): Recibe un párrafo y
    guarda cada frase en una línea nueva de un StringBuilder. Cada frase finaliza
    cuando encontramos un punto (.).
    ● void MostrarTexto(string mensaje, string texto): Muestra por consola el
    mensaje y el texto recibido.
    ● void MostrarTextoSB(StringBuilder texto): Muestra por consola el texto
    recibido. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string metodoSolicitado;
            string textoRecibido;

            bool continuar;
            continuar = true;
            string respuesta;
            string mensaje;
            mensaje = "Seleccione la opcion a testear";
            mensaje += "\n1. Contar letras";
            mensaje += "\n2. Contar palabras";
            mensaje += "\n3. Contar vocales";
            mensaje += "\n4. Contar consonantes";
            mensaje += "\n5 Remplazar caracteres";
            mensaje += "\n";

            while (continuar)
            {
                do
                {
                   Console.WriteLine(mensaje);
                    metodoSolicitado = Console.ReadLine();
                } while (metodoSolicitado != "1" && metodoSolicitado != "2" && metodoSolicitado != "3" && metodoSolicitado != "4" && metodoSolicitado != "5");
                switch (metodoSolicitado)
                {
                    case "1":
                        int cantidadLetras;
                        Console.WriteLine("Ingrese una palabra: ");
                        textoRecibido = Console.ReadLine();
                        cantidadLetras = TextOperations.ContarLetras(textoRecibido);
                        Console.WriteLine($"La palabra \"{textoRecibido}\" tiene {cantidadLetras} letras");
                        break;
                    case "2":
                        int cantidadPalabras;
                        Console.WriteLine("Ingrese un texto: ");
                        textoRecibido = Console.ReadLine();
                        cantidadPalabras = TextOperations.ContarPalabras(textoRecibido);
                        Console.WriteLine($"El texto \"{textoRecibido}\" tiene {cantidadPalabras} palabras");
                        break;
                    case "3":
                        int cantidadVocales;
                        Console.WriteLine("Ingrese una palabra: ");
                        textoRecibido = Console.ReadLine();
                        cantidadVocales = TextOperations.ContarVocales(textoRecibido);
                        Console.WriteLine($"La palabra \"{textoRecibido}\" tiene {cantidadVocales} vocales");
                        break;
                    case "4":
                        int cantidadConsonantes;
                        Console.WriteLine("Ingrese una palabra: ");
                        textoRecibido = Console.ReadLine();
                        cantidadConsonantes = TextOperations.ContarConsonantes(textoRecibido);
                        Console.WriteLine($"La palabra \"{textoRecibido}\" tiene {cantidadConsonantes} consonantes");
                        break;
                    case "5":
                        string caracterExistente;
                        string caracterNuevo;
                        string nuevoTexto;
                        Console.WriteLine("Ingrese un texto/palabra: ");
                        textoRecibido = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Caracter a remplazar: ");
                            caracterExistente = Console.ReadLine();
                        } while (caracterExistente.Length > 1);
                        do
                        {
                            Console.WriteLine("Nuevo caracter: ");
                            caracterNuevo = Console.ReadLine();
                        } while (caracterNuevo.Length > 1);
                        nuevoTexto =  TextOperations.ReemplazarCaracter(textoRecibido, char.Parse(caracterExistente) , char.Parse(caracterNuevo));
                        Console.WriteLine($"se ha cambiado \"{textoRecibido}\" a \"{nuevoTexto}\", felicidades!");
                        break;

                }
                
                do
                {
                    Console.WriteLine("¿Desea continuar? (si/no): ");
                    respuesta = Console.ReadLine().ToLower();
                } while (respuesta != "si" && respuesta != "no");
                
                if (respuesta == "no")
                {
                    continuar = false;
                }
            }
            ///////   
        }
    }
}