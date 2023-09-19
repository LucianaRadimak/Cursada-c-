using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    internal class App
    {
        string nombre;
        double size;        
        
        public App(string nombre, double size)
        {
            this.nombre = nombre;
            this.size = size;
        }
        public string Nombre { get => nombre; set => nombre=value; }
        public double Size { get => size; set => size=value; }

        //Sobrecarga del operador explícito para convertir App a string
        public static explicit operator string(App app)
        {
            return $"*{app.nombre} ({app.size} GB)";
        }

        // Sobrecarga del operador explícito para convertir App a double
        public static implicit operator double(App app)
        {
            return app.size;
        }
    }
}
