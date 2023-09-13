using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes
{
    internal class Alumno
    {
        string nombre;
        string direccion;
        int telefono;        
        int cantidadMaterias;

        public Alumno(string nombre, int telefono, string direccion, int cantidadMaterias)
        {
            this.nombre=nombre;
            this.telefono=telefono;
            this.direccion=direccion;
            this.cantidadMaterias=cantidadMaterias;
        }

        public string Nombre { get => nombre; set => nombre=value; }
        public int Telefono { get => telefono; set => telefono=value; }
        public string Direccion { get => direccion; set => direccion=value; }
        public int CantidadMaterias { get => cantidadMaterias; set => cantidadMaterias=value; }
        
        #region Conversores
        public static explicit operator Empresa(Alumno unAlumno)
        {
            return new Empresa(unAlumno.nombre, unAlumno.direccion);
        }
        #endregion
    }
}
