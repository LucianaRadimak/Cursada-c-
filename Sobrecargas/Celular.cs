using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    internal class Celular
    {
        #region Atributos
        EMarca marca;
        string modelo;
        int ram;
        double almacenamiento;
        double almacenamientoActual;
        bool encendido;
        List<string> agenda;
        List<string> apps;
        #endregion

        #region Constructores

        public Celular()
        {
            this.apps = new List<string>();
            this.agenda = new List<string>();
        }

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento):this()
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ram = ram;
            this.almacenamiento = almacenamiento;
            this.encendido = false;
            this.almacenamientoActual = almacenamiento;
        }

        public Celular(EMarca marca, string modelo, int ram, double almacenamiento, List<string> agenda) : this(marca, modelo, ram, almacenamiento)
        {
            this.agenda = agenda;
        }
        #endregion

        #region Metodos
        public string AlternarEncendido()
        {
            this.encendido = !this.encendido;
            return this.encendido ? "Encendiendo..." : "Apagando...";
        }
        #endregion

    }
}
