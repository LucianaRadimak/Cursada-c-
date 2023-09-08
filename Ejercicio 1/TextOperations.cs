using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    internal class TextOperations
    {
        /// <summary>
        /// Cuenta la cantidad de letras que tiene una palabra
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns>Número de letras</returns>
        public static int ContarLetras(string palabra) 
        {
            return palabra.Length;
        }
        /// <summary>
        /// Cuenta la cantidad de palabras que contiene un texto
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>Número de palabras</returns>
        public static int ContarPalabras(string texto)
        {
            string[] palabras = texto.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
        /// <summary>
        /// Cuenta la cantidad de vocales que contiene una palabra
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns>Número de vocales</returns>
        public static int ContarVocales(string palabra)
        {
            string vocales;
            vocales = "AEIOUaeiou";
            int cantidadVocales;
            cantidadVocales= 0;
            foreach (char letra in palabra)
            {
                if(vocales.Contains(letra))
                {
                    cantidadVocales++;
                }                
            }
            return cantidadVocales;
        }
        /// <summary>
        /// Cuenta la cantidad de consonantes que contiene una palabra
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns>Número de consonantes</returns>
        public static int ContarConsonantes(string palabra)
        {
            string vocales;
            vocales = "AEIOUaeiou";
            int cantidadConsonantes;
            cantidadConsonantes= 0;
            foreach (char letra in palabra)
            {
                if (char.IsLetter(letra) && !vocales.Contains(letra))
                {
                    cantidadConsonantes++;
                }
            }
            return cantidadConsonantes;
        }
        /// <summary>
        /// Reemplaza el carácter original de un texto por el indicado.
        /// </summary>
        /// <param name="palabra"></param>
        /// <param name="original">caracter a remplazar</param>
        /// <param name="nuevo">nuevo caracter</param>
        /// <returns>Texto con nuevo caracter</returns>
        public static string ReemplazarCaracter(string palabra, char caracterOriginal, char caracterNuevo)
        {
            return palabra.Replace(caracterOriginal, caracterNuevo);
        }
        
        //public static bool ConvertirStringAEntero(string texto, out int numeroEntero)
        //{
        //    return int.TryParse(texto, out numeroEntero);
        //}

        public static StringBuilder ConvertirStringASB(string palabra)
        {
            return new StringBuilder(palabra);
        }

        public static StringBuilder ConvertirParrafoASB(string parrafo)
        {
            string[] frases = parrafo.Split(".", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            foreach (string frase in frases)
            {
                sb.AppendLine(frase.Trim());
            }
            return sb;
        }

        public static void MostrarTexto(string mensaje, string texto)
        {
            Console.WriteLine($"{mensaje}. {texto}");
        }

        public static void MostrarTextoSB(StringBuilder texto)
        {
            Console.WriteLine(texto.ToString());
        }
    }
        
}

