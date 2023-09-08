using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2b
{
    internal class Estudiante
    {
        string apellido;
        string legajo;
        string nombre;
        int notaPrimerParcial;
        int notaSegundoParcial;
        static Random random;
        static Estudiante()
        {
            random = new Random();
        }

        public int CalcularNotaFinal()
        {
            if(notaPrimerParcial > 3 && notaSegundoParcial > 3)
            {
                return random.Next(6, 11);
            }
            else
            {
                return -1;
            }
        }

        private double CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2.0;
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nota del primer parcial: {notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {notaSegundoParcial}");
            double promedio = CalcularPromedio();
            sb.AppendLine($"Promedio: {promedio}");
            int notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota Final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();                        
        }

        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }         
    }
}
