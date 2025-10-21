using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Parametros
    {
        public Planta Planta { get; private set; }
        public int Area { get; set; }

        public void AsignarPlanta(Planta planta)
        {
            this.Planta = planta;
        }
        public override string ToString()
        {
            return $"{Planta.Id};{Area}";
        }
    }
}
