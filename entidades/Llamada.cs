using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    public class Llamada
    {
        DateTime fecha;
        string numeroDestino;
        int duracionSegundos;

        public Llamada(DateTime fecha, string numeroDestino, int duracion)
        {
            this.fecha=fecha;
            this.numeroDestino=numeroDestino;
            this.duracionSegundos=duracion;
        }

        public string duracionFormateada()
        {
            int horas = DuracionSegundos / 3600;
            int minutos = (DuracionSegundos % 3600) / 60;
            int segundos = DuracionSegundos % 60;

            return $"{horas} horas, {minutos} minutos y {segundos} segundos";

        }

        public DateTime Fecha { get => fecha; set => fecha=value; }
        public string NumeroDestino { get => numeroDestino; set => numeroDestino=value; }
        public int DuracionSegundos { get => duracionSegundos; set => duracionSegundos=value; }
    }
}
