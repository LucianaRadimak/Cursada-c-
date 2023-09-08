using System.Diagnostics;
using System.Linq.Expressions;

namespace clase_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            double precio;
            string estacionIngresada;
            string localidadIngresada;
            bool continuar;
            string respuesta;
            precio = 15000;
            continuar = true;
            
            while (continuar)
            {
                do 
                { 
                    Console.WriteLine("ingrese estación (Invierno/Verano/Otoño/Primavera): ");
                    estacionIngresada = Console.ReadLine().ToLower();
                } while(estacionIngresada != "invierno" && estacionIngresada != "verano" && estacionIngresada != "otoño" && estacionIngresada != "primavera");

                do
                {
                    Console.WriteLine("ingrese localidad (Bariloche/Cataratas/Mar del Plata/Cordoba): ");
                    localidadIngresada = Console.ReadLine().ToLower();
                } while (localidadIngresada != "bariloche" && localidadIngresada != "cataratas" && localidadIngresada != "mar del plata" && localidadIngresada != "cordoba");

                switch (estacionIngresada)
                {
                    /*
                    -en Invierno: Bariloche tiene un aumento del 20% Cataratas y Córdoba tiene un
                    descuento del 10% Mar del Plata tiene un descuento del 20%
                    -en Verano: Bariloche tiene un descuento del 20% Cataratas y Córdoba tiene
                    un aumento del 10% Mar del Plata tiene un aumento del 20%
                    -en Otoño y Primavera: Bariloche tiene un aumento del 10% Cataratas tiene un
                    aumento del 10% Mar del Plata tiene un aumento del 10% y Córdoba tiene el
                    precio sin descuento.
                    Validar el ingreso de datos
                    */
                    case "invierno":
                        switch (localidadIngresada)
                        {
                            case "bariloche":
                                precio *= 1.20;
                                break;
                            case "cataratas":
                            case "cordoba":
                                precio *= 0.90;
                                break;
                            case "mar del plata":
                                precio *= 0.80;
                                break;                         
                        }
                        break;
                    case "verano":
                        switch (localidadIngresada)
                        {
                            case "bariloche":
                                precio *= 0.80;
                                break;
                            case "cataratas":
                            case "cordoba":
                                precio *= 1.10;
                                break;
                            case "mar del plata":
                                precio *= 1.20;
                                break;                                                     
                        }
                        break;                
                    case "otoño":
                    case "primavera":
                        switch (localidadIngresada)
                        {
                            case "bariloche":                                
                            case "cataratas":
                            case "mar del plata":
                                precio *= 1.10;
                                break;                            
                        }
                        break;                  
                }
                Console.WriteLine("Estacion: {0} Localidad: {1} Precio a pagar: {2}", estacionIngresada, localidadIngresada, precio);
                do
                {
                    Console.WriteLine("¿Desea continuar? (si/no): ");
                    respuesta = Console.ReadLine().ToLower();
                } while (respuesta != "si" && respuesta != "no");
                if (respuesta == "no") 
                {
                    continuar = false;                  
                }
                else 
                {
                    precio = 15000;
                }
            }            
        }
    }
}