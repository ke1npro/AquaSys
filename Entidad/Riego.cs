using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Riego
    {
        public DateTime Fecha { get; set; }
        public int Tiempo { get; set; }
        public int AguaGastada { get; set; }

        public override string ToString()
        {
            return $"{Fecha.ToString("yyyy-MM-dd HH:mm:ss")};{Tiempo};{AguaGastada}";
        }

       
    }
}
