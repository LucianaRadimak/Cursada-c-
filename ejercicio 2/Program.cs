namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta nuevaCuenta;
            nuevaCuenta = new Cuenta("German", 100000);

            bool continuar;
            continuar = true;
            string respuesta;
            string operacion;
            string mensaje;
            mensaje = "Elija la opción a ejecutar";
            mensaje += "\n1. Ingresar dinero a la cuenta";
            mensaje += "\n2. Retirar dinero de la cuenta";
            mensaje += "\n3. Ver estado de la cuenta";
            do
            {
                do
                {
                    Console.WriteLine(mensaje);
                    operacion = Console.ReadLine();
                } while (operacion!= "1" && operacion!= "2" && operacion != "3");
                switch(operacion)
                {
                    case "1":
                        int dineroIngresar;
                        do
                        {
                            Console.WriteLine("¿Qué cantidad desea ingresar?");
                            dineroIngresar = int.Parse(Console.ReadLine());
                        } while (dineroIngresar < 0);
                        nuevaCuenta.IngresarDinero(dineroIngresar);
                        break;
                    case "2":
                        int dineroRetirar;
                        do
                        {
                            Console.WriteLine("¿Qué cantidad desea retirar?");
                            dineroRetirar = int.Parse(Console.ReadLine());
                        } while (dineroRetirar < 0);
                        nuevaCuenta.RetirarDinero(dineroRetirar);
                        break;
                    case "3":
                        Console.WriteLine(nuevaCuenta.CuentaToString());
                        break;
                }
                do 
                {
                    Console.WriteLine("¿Desea continuar con las operaciones? si/no");
                    respuesta = Console.ReadLine().ToLower();
                } while(respuesta!= "no" && respuesta != "si");
                if(respuesta == "no")
                {
                    continuar = false;
                }
            } while (continuar);
            


            
        }
    }
}