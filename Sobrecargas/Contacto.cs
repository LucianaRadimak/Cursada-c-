using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    internal class Contacto
    {
        string nombre;
        string numero;

        public Contacto(string nombre, string numero)
        {
            this.nombre=nombre;
            this.numero=numero;
        }
        public string Nombre { get => nombre; set => nombre=value; }
        public string Numero { get => numero; set => numero=value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();            
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Número: {this.numero}");            
            return sb.ToString();
        }
    }
}
