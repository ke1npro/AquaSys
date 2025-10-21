using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RiegoRepository:ICrud<Riego>
    {
        string ruta;
        List<Riego> lista=new List<Riego>();
        public RiegoRepository(string ruta) {
            this.ruta = ruta;
            StreamWriter sw = new StreamWriter(ruta, true);
        }

        public string Agregar(Riego riego)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            using (sw)
            {
                try
                {
                    sw.WriteLine(riego.ToString());
                    return "Se ha guardado el riego";
                }
                catch (Exception e)
                {
                    return $"No se pudo guardar, {e.Message}";
                }
            }
        }

        public string Guardar()
        {
            StreamWriter sw = new StreamWriter(ruta);
            foreach (Riego riego in lista)
            {
                sw.WriteLine(riego.ToString());
            }
            return "Se ha guardado todo en memoria exitosamente";
        }

        public List<Riego> ObtenerTodo()
        {
            StreamReader sr= new StreamReader(ruta);
            using (sr)
            {
                
                while (!sr.EndOfStream) 
                {
                    lista.Add(Mappear(sr.ReadLine()));
                }
                return lista;
            }
        }

        private Riego Mappear(string v)
        {
            var aux = v.Split(';');
            Riego riego = new Riego();
            riego.Id=int.Parse(aux[0]);
            DateTime fecha = DateTime.ParseExact(aux[1], "yyyy-MM-dd HH:mm:ss",null);
            riego.Fecha=fecha; 
            riego.Tiempo=int.Parse(aux[2]);
            riego.AguaGastada = int.Parse(aux[3]);
            return riego;
        }
    }
}
