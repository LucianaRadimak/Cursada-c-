using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumador
{
    internal class Sumador
    {
        int cantidadSumas;

        public int CantidadSumas { get => cantidadSumas; set => cantidadSumas=value; }
        #region Constructores
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador(): this (0)
        {            
        }
        #endregion
        
        #region Metodos
        
        public long Sumar(long numero, long otroNumero)
        {
            this.cantidadSumas++;
            return numero + otroNumero;
        }
        public string Sumar(string texto, string otroTexto)
        {
            this.cantidadSumas++;
            return string.Format($"{texto} {otroTexto}");
        }
        #endregion

        #region sobrecargaOperadores
        public static explicit operator int (Sumador sumador)
        {
            return sumador.cantidadSumas;
        }
        public static long operator + (Sumador a, Sumador b)
        {
            return (int)a + (int)b;
        }
        public static bool operator | (Sumador a, Sumador b)
        {
            bool igualdad;
            igualdad = false;
            if((int)a == (int)b)
            {
                igualdad = true;
            }
            return igualdad;
        }
        #endregion
    }
}
