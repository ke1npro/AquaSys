using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace DAL
{
    public class ParametroRepository
    {
        string ruta;
        PlantaRepository plantaRepository;
        public ParametroRepository(string ruta) { 
            this.ruta = ruta; 
            if (!File.Exists(ruta))
            {
                File.Create(ruta).Close();
            }
            plantaRepository = new PlantaRepository(Utils.ARC_PLANTA);
        }

        public Parametros Obtener()
        {
            StreamReader sr=new StreamReader(ruta);
            Parametros parametro=new Parametros();
            using (sr)
            {
                var aux = sr.ReadLine();
                if (aux == null)
                {
                    return null;
                }
                var linea = aux.Split(';');

                int id = int.Parse(linea[0]);
                parametro.Area = int.Parse(linea[1]);
                Planta planta = plantaRepository.ObtenerPorId(id);
                parametro.AsignarPlanta(planta);

                return parametro;
            }
        }

        public string Guardar(Parametros parametro)
        {
            StreamWriter sw = new StreamWriter(ruta);
            using (sw)
            {
                sw.WriteLine(parametro.ToString());
                return "Se han guardado los parametros";
            }
        }
    }
}
