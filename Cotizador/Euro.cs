﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        #region Campos
        double cantidad;
        static double cotzRespectoDolar;
        #endregion

        #region Constructores
        static Euro()
        {
            cotzRespectoDolar = 1.0658;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }
        #endregion

        #region Convertores
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / cotzRespectoDolar);
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
        #endregion

        #region Propiedades
        public double GetCantidad()
        {
            return cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e == (Euro)p;
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }        
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }
        #endregion
    }
}
