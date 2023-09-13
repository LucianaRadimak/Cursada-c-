using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes
{
    internal class Empresa
    {
        string nombre;
        string direccion;

        public Empresa(string nombre, string direccion)
        {
            this.nombre=nombre;
            this.direccion=direccion;
        }

        public string Nombre { get => nombre; set => nombre=value; }
        public string Direccion { get => direccion; set => direccion=value; }

        #region Conversores
        public static implicit operator Alumno(Empresa empresa)
        {
            return new Alumno(empresa.nombre, 0, empresa.direccion, 0);
        }
        #endregion
    }
}
