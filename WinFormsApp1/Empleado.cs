using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Empleado
    {
        string nombre;
        float salario;
        string genero;
        List<string> tareas;

        public Empleado(string nombre, float salario, string genero, List<string> listaTareas)
        {
            this.nombre=nombre;
            this.salario=salario;
            this.genero=genero;
            this.tareas= new List<string>(listaTareas);
        }

        #region propiedades
        public string Nombre { get => nombre; set => nombre=value; }
        public float Salario { get => salario; set => salario=value; }
        public string Genero { get => genero; set => genero=value; }
        public List<string> Tareas { get => tareas; set => tareas=value; }
        #endregion

        #region metodos
        public override string ToString()
        {

            return Nombre + "-" + Salario + "-" + Genero;
        }
        #endregion
    }
}
