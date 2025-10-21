using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Riego
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Tiempo { get; set; }
        public int AguaGastada { get; set; }

        public override string ToString()
        {
            return $"{Id};{Fecha.ToString("yyyy-MM-dd HH:mm:ss")};{Tiempo};{AguaGastada}";
        }

       
    }
}
