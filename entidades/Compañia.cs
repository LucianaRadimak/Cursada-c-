using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    public class Compañia
    {
        string razonSocial;
        DateTime fechaDeApertura;
        Stack<Celular> celulares;

        public Compañia(string razonSocial)
        {
            this.razonSocial=razonSocial;
            this.celulares= new Stack<Celular>();
            this.fechaDeApertura = DateTime.Today;
        }
        public Compañia(string razonSocial, Stack<Celular> celulares):this(razonSocial)
        {                        
            this.celulares=celulares;           
        }
        public string MostrarCompañia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*******************************************");
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Fecha de apertura: {this.fechaDeApertura.ToString()}");         
            if (this.celulares.Count > 0)
            {
                sb.AppendLine("Celulares en el stack: ");
                foreach (Celular celular in this.celulares)
                {
                    sb.AppendLine(celular.ToString());                    
                }
            }
            else
            {
                sb.AppendLine("No hay celulares en el stack");
            }            
            return sb.ToString();
        }
        public string RazonSocial { get => razonSocial; set => razonSocial=value; }
        public DateTime FechaDeApertura { get => fechaDeApertura; set => fechaDeApertura=value; }
    }
}
