using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Cuenta
    {
        string titular;
        int cantidad;
        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return titular;
        }
        public int GetCantidad()
        {
            return cantidad;
        }
        public string CuentaToString()
        {
            return $"Titular: {titular} Saldo: {cantidad:C}";
        }
        public void IngresarDinero(int montoAcreditar)
        {
            if(montoAcreditar > 0)
            {
                cantidad += montoAcreditar;
                Console.WriteLine($"Se ingresaron {montoAcreditar:C} a la cuenta.");
            }
            else
            {
                Console.WriteLine($"El monto ingresado debe ser positivo.");
            }
        }
        public void RetirarDinero(int montoDebitar)
        {
            if(montoDebitar > 0)
            { 
                cantidad -= montoDebitar;
                Console.WriteLine($"Se retiraron {montoDebitar:C} de la cuenta.");
            }
        }
        /*
         Un constructor que permita inicializar todos los atributos.
        Un método getter para cada atributo.
        CuentaToString: retornará una cadena de texto con todos los datos de la cuenta.
        IngresarDinero: recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
        RetirarDinero: recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
         */

    }
}
