using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    internal class Celular
    {
        #region Atributos
        EMarca marca;
        string modelo;
        int ram;
        double almacenamiento;
        double almacenamientoActual;
        bool encendido;
        List<string> agenda;
        List<string> apps;
        #endregion

        #region Constructores

        public Celular()
        {
            this.apps = new List<string>();
            this.agenda = new List<string>();
        }

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento):this()
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ram = ram;
            this.almacenamiento = almacenamiento;
            this.encendido = false;
            this.almacenamientoActual = almacenamiento;
        }

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento, List<string> agenda) : this(marca, modelo, ram, almacenamiento)
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
                if (BuscarEnAgenda(contacto.numero))
                {
                    Console.WriteLine($"llamando a {contacto.nombre}");
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
        private bool BuscarEnAgenda(string numeroIngresado)
        {
            bool estaEnAgenda;
            estaEnAgenda = false;
            foreach(string numero in this.agenda)
            {
                if(numero == numeroIngresado)
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
            if (this.encendido && this != aplicacion && VerificarEspacio(aplicacion.size))
            {
                exito = true;
                this.apps.Add(aplicacion.nombre);
                this.almacenamientoActual -= aplicacion.size;
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
            sb.AppendLine($"Almacenamiento: {this.almacenamiento}");            
            if (this.apps.Count > 0)
            {
                sb.AppendLine("Aplicaciones instaladas");
                foreach (string aplicacion in apps)
                {
                    sb.AppendLine($"\t{aplicacion}");
                }
            }
            else
            {
                sb.AppendLine("No hay apps instaladas");
            }
            sb.AppendLine("*******************************************");
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Celular miCelu, App miApp)
        {
            bool exito;
            exito = false;
            foreach (string aplicacion in miCelu.Apps) 
            {
                if (aplicacion == miApp.nombre)
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
        public int Ram { get => ram; set => ram = value; }
        public double Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public double AlmacenamientoActual { get => almacenamientoActual; set => almacenamientoActual = value; }
        public List<string> Agenda { get => agenda; set => agenda = value; }
        public List<string> Apps { get => apps; set => apps=value; }
        #endregion
    }
}
