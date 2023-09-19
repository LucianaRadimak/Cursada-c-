using System.Diagnostics.Contracts;

namespace Sobrecargas
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Creo el stack de celulares vacio
            Stack<Celular> celularesMovistar;
            celularesMovistar = new Stack<Celular>();
            
            // Creo agendas para cada celular
            // 1
            Dictionary<Contacto, DateTime> agenda1 = new Dictionary<Contacto, DateTime>();
            agenda1[new Contacto("Amigo", "987654321")] = DateTime.Today;
            agenda1[new Contacto("", "345678901")] = DateTime.Today;
            // 2
            Dictionary<Contacto, DateTime> agenda2 = new Dictionary<Contacto, DateTime>();
            agenda2[new Contacto("Profesora", "111111111")] = DateTime.Today;
            agenda2[new Contacto("Sonia", "222222222")] = DateTime.Today;
            // 3
            Dictionary<Contacto, DateTime> agenda3 = new Dictionary<Contacto, DateTime>();
            agenda3[new Contacto("mamá", "999999999")] = DateTime.Today;
            agenda3[new Contacto("Jefe", "777777777")] = DateTime.Today;
            
            //Creo cada celular con sus agendas y los enciendo
            // 1
            Celular celular1;
            celular1 = new Celular(EMarca.Samsumg, "Galaxy S21", 8, 128, "Germán", "12345678", agenda1);
            celular1.AlternarEncendido();
            // 2
            Celular celular2;
            celular2 = new Celular(EMarca.Xiaomi, "C3", 12, 64, "Rodrigo", "55555555", agenda2);
            celular2.AlternarEncendido();
            // 3
            Celular celular3;
            celular3 = new Celular(EMarca.Motorola, "A6", 6, 32, "Francis", "11111111", agenda3);
            celular3.AlternarEncendido();

            // AGREGO LOS CELULARES AL STACK CELULARESMOVISTAR
            celularesMovistar.Push(celular1);
            celularesMovistar.Push(celular2);
            celularesMovistar.Push(celular3);

            // Trato de instalar apps a cada celular
            App app1;
            app1 = new App("Instagram", 25);
            App app2;
            app2 = new App("Tinder", 30);
            App app3;
            app3 = new App("WhatsApp", 20);
            App app4;
            app4 = new App("Pinterest", 10);
            App app5;
            app5 = new App("Galeria", 5); 

            List<App> listaApps = new List<App>();
            listaApps.Add(app1);
            listaApps.Add(app2);
            listaApps.Add(app3);
            listaApps.Add(app4);
            listaApps.Add(app5);

            bool exito;
            foreach (Celular celular in celularesMovistar)
            {
                foreach(App aplicacion in listaApps)
                {
                    exito = celular + aplicacion;
                    if (exito)               
                       Console.WriteLine($"Exito al instalar {aplicacion.Nombre}. Celular: {celular.Marca} modelo: {celular.Modelo}");
               
                    else                
                       Console.WriteLine($"No se pudo instalar {aplicacion.Nombre} por falta de memoria. Celular: {celular.Marca} modelo: {celular.Modelo}");
                } 
            }           
        
            //Cada celular realiza llamadas
            celular1.Llamar("987654321");
            celular2.Llamar("222222222");
            celular2.Llamar("111111111");

            //celular3.Llamar("777777777"); //Este celular no realizo ninguna llamada
            
            //Creo la compañia "Movistar" y la muestro
            Compañia movistar = new Compañia("Movistar", celularesMovistar);
            Console.WriteLine(movistar.MostrarCompañia());                     
        }
    }
}