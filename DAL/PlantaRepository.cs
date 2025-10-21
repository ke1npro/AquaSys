using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlantaRepository:ICrud<Planta>
    {
        string ruta;
        List<Planta> lista=new List<Planta>();

        public PlantaRepository(string ruta) {
            this.ruta = ruta;
            using (StreamWriter sw = new StreamWriter(ruta, true)) { } ;
            lista = ObtenerTodo();

        }

      
        public string Agregar(Planta planta)
        {
            StreamWriter sw = new StreamWriter(ruta,true);
            using (sw)
            {
                try
                {
                    sw.WriteLine(planta.ToString());
                    return "Se ha guardado la planta";
                }catch(Exception e)
                {
                    return $"No se pudo guardar, {e.Message}";
                }
            }
        }

        public string Eliminar(int id)
        {
            var aux = ObtenerPorId(id);
            if (aux != null)
            {
                Guardar();
                return $"Se ha eliminado la planta {aux.Nombre}";
            }
            else
            {
                return "No se encontró la planta a eliminar";
            }
            
            
        }

        public string Guardar()
        {
            StreamWriter sw = new StreamWriter(ruta);
            foreach (Planta planta in lista)
            {
                sw.WriteLine(planta.ToString());
            }
            return "Se ha guardado todo en memoria exitosamente";
        }

        public List<Planta> ObtenerTodo()
        {
            lista.Clear();
            StreamReader sr = new StreamReader(ruta);
            
            using (sr) { 
                while (!sr.EndOfStream)
                {
                    lista.Add(Mappear(sr.ReadLine()));
                }
                return lista;
            }
        }
        public Planta ObtenerPorId(int id)
        {
            return lista.FirstOrDefault(a => a.Id == id);
        }
        private Planta Mappear(string v)
        {
            Planta planta = new Planta();
            string[] aux = v.Split(';');
            planta.Id = Convert.ToInt16(aux[0]);
            planta.Nombre= aux[1];
            planta.HumedadMinima = float.Parse(aux[2]);
            planta.HumedadMaxima = float.Parse(aux[3]);
            return planta;
        }

    }
}
