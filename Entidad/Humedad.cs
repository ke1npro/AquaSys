using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Humedad
    {
        public DateTime Fecha { get; set; }
        public float Porcentaje { get; set; }
        // expresado en 2 enteros y 1 decimal de precision: 12.3%
        public override string ToString()
        {
            string fecha = Fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string porc = Porcentaje.ToString("F1");
            return $"{fecha};{porc}";
        }
    }
}
