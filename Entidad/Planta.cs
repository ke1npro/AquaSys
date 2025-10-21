using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Planta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float HumedadMinima { get; set; }
        public float HumedadMaxima { get; set; }

        public override string ToString()
        {
            //Convertir float a string con 1 decimal de precision
            string aux1 = HumedadMinima.ToString("F1");
            string aux2 = HumedadMaxima.ToString("F1");
            
            return $"{Id};{Nombre};{aux1};{aux2}";
        }
    
    }
}
