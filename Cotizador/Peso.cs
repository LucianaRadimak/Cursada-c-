﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        #region Campos
        double cantidad;
        static double cotzRespectoDolar;
        #endregion

        #region Constructores
        static Peso()
        {
            cotzRespectoDolar = 102.65;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }
        #endregion

        #region Convertores
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / cotzRespectoDolar);
        }
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }
        public static implicit operator Peso(double p)
        {
            return new Peso(p);

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
        public static bool operator ==(Peso p, Dolar d)
        {
            return p == (Peso)d;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p == (Peso)e;
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).cantidad);
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).cantidad);
        }
        #endregion
    }
}
