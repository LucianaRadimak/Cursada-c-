using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    public class Celular
    {
        #region Atributos
        EMarca marca;
        string modelo;
        int ram;
        double almacenamiento;
        double almacenamientoActual;
        bool encendido;
        Dictionary<Contacto, DateTime> agenda;
        List<App> apps;
        string titular;
        string numero;
        Queue<Llamada> llamadasRealizadas;
        Random random;
        #endregion

        #region Constructores

        public Celular()
        {
            random = new Random();
            this.apps = new List<App>();
            this.llamadasRealizadas = new Queue<Llamada>();
            this.agenda = new Dictionary<Contacto, DateTime>();
        }

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento, string titular, string numero):this()
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ram = ram;
            this.almacenamiento = almacenamiento;
            this.encendido = false;
            this.almacenamientoActual = almacenamiento;
            this.titular = titular;
            this.numero = numero;
        }

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento, string titular, string numero, Dictionary<Contacto, DateTime> agenda) : this(marca, modelo, ram, almacenamiento, titular, numero)
        {
            this.agenda = agenda;
        }
        #endregion

        #region Metodos
        public string AlternarEncendido()
        {
            this.encendido = !this.encendido;
            return this.encendido ? "Encendiendo..." : "Apagando...";
        }
        
        public void Llamar(string numero)
        {
            if(this.encendido)
            {
                if(BuscarEnAgenda(numero))
                {
                    Console.WriteLine($"llamando a {numero}");
                    int duracionSegundos;
                    duracionSegundos = random.Next(1, 10000);
                    Llamada llamadaNueva;
                    llamadaNueva = new Llamada(DateTime.Now, numero, duracionSegundos);
                    this.llamadasRealizadas.Enqueue(llamadaNueva);
                }
                else
                {
                    Console.WriteLine("numero no encontrado");
                }
            }
            else 
            {
                Console.WriteLine("celu apagado");
            }
        }
        
        public void Llamar(Contacto contacto)
        {
            if (this.encendido)
            {
                if (BuscarEnAgenda(contacto))
                {
                    if((contacto.Nombre).Length > 0)
                        Console.WriteLine($"llamando a {contacto.Nombre}");
                    else
                        Console.WriteLine($"llamando a {contacto.Numero}");

                    int duracionSegundos;
                    duracionSegundos = random.Next(1, 10000);
                    Llamada llamadaNueva;
                    llamadaNueva = new Llamada(DateTime.Now, contacto.Numero, duracionSegundos);
                    this.llamadasRealizadas.Enqueue(llamadaNueva);
                }
                else
                {
                    Console.WriteLine("contacto no encontrado");
                }
            }
            else
            {
                Console.WriteLine("celu apagado");
            }
        }
        private bool BuscarEnAgenda(Contacto contacto)
        {
            bool estaEnAgenda;
            estaEnAgenda = false;
            if(agenda.ContainsKey(contacto))
            {
                estaEnAgenda = true;                
            }              
            return estaEnAgenda;
        }

        private bool BuscarEnAgenda(string numero)
        {
            bool estaEnAgenda;
            estaEnAgenda = false;
            foreach (Contacto contacto in agenda.Keys)
            {
                if (contacto.Numero == numero)
                {
                    estaEnAgenda = true;
                    break;
                }
            }            
            return estaEnAgenda;
        }

        private bool InstalarApp(App aplicacion)
        {
            bool exito;
            exito = false;
            if (this.encendido && this != aplicacion && VerificarEspacio((double)aplicacion))
            {
                exito = true;
                this.apps.Add(aplicacion);
                this.almacenamientoActual -= aplicacion.Size;
            }
            //Encendido
            //App no este instalada
            //Haya espacio
            return exito;
        }

        private bool VerificarEspacio(double nuevoSize)
        {
            return (this.almacenamientoActual - nuevoSize) >= 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*******************************************");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"RAM: {this.ram}");
            sb.AppendLine($"Almacenamiento: {this.almacenamiento} GB");
            sb.AppendLine($"Titular: {this.titular}");
            sb.AppendLine($"Número: {this.numero}");
            if (this.apps.Count > 0)
            {
                sb.AppendLine("Aplicaciones instaladas");
                foreach (App aplicacion in apps)
                {
                    sb.AppendLine((string)aplicacion);
                }
            }
            else
            {
                sb.AppendLine("No hay apps instaladas");
            }
            sb.AppendLine(this.MostrarLlamadasRealizadas());
            return sb.ToString();
        }

        private string MostrarLlamadasRealizadas()
        {
            StringBuilder sb = new StringBuilder();           
            if (this.llamadasRealizadas.Count > 0)
            {
                sb.AppendLine($"Llamadas realizadas: ");
                foreach (Llamada llamada in this.llamadasRealizadas)
                {
                    sb.AppendLine($"Fecha y hora: {llamada.Fecha}, Destino: {llamada.NumeroDestino}, Duración: {llamada.duracionFormateada()}");
                }
            }
            else
            {
                sb.Append("No se encontraron llamadas realizadas.");
            }
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Celular miCelu, App miApp)
        {
            bool exito;
            exito = false;
            foreach (App aplicacion in miCelu.apps) 
            {
                if (aplicacion == miApp)
                {
                    exito = true;
                    break;
                }
            }

            return exito;
        }
        public static bool operator !=(Celular miCelu, App miApp)
        {
            return !(miCelu == miApp);
        }

        public static bool operator +(Celular miCelu, App miApp)
        {
            return miCelu.InstalarApp(miApp);
        }        
        #endregion

        #region Propiedades
        public string Modelo { get => modelo; set => modelo = value;}        
        public string Titular { get => titular; set => titular=value; }
        public string Numero { get => numero; set => numero=value; }
        public EMarca Marca { get => marca; set => marca=value; }
        #endregion
    }
}
