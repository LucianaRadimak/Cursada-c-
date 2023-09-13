namespace Sobrecargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> agenda;
            agenda = new List<String>();
            agenda.Add("11 12345678");
            agenda.Add("11 23456789");
            agenda.Add("11 34567890");
            Celular celular1;
            celular1 = new Celular(EMarca.Samsumg, "J7", 32, 64, agenda);
            Console.WriteLine(celular1.AlternarEncendido());
            celular1.Modelo = "j13";
            Console.WriteLine(celular1.Modelo);
            celular1.Llamar(agenda[1]);
            celular1.Llamar("11 23345678");
            Console.WriteLine(celular1.AlternarEncendido());
            celular1.Llamar(agenda[1]);
            Console.WriteLine(celular1.AlternarEncendido());
            Contacto contacto;
            contacto = new Contacto("juan", "11 34567890");
            celular1.Llamar(contacto);
            App app1;
            app1 = new App("Instagram", 25);
            App app2;
            app2 = new App("Tinder", 30);
            App app3;
            app3 = new App("WhatsApp", 15);
            List<App> listaApps = new List<App>();
            listaApps.Add(app1);
            listaApps.Add(app2);
            listaApps.Add(app3);
            bool exito;
            foreach(App aplicacion in listaApps)
            {
                exito = celular1 + aplicacion;
                if (exito)
                {
                    Console.WriteLine($"Exito al instalar {aplicacion.nombre}");
                }
                else
                {
                    Console.WriteLine($"No se pudo instalar {aplicacion.nombre} por falta de memoria");
                }             
            }
            Console.WriteLine(celular1.ToString());         
            
        }
    }
}